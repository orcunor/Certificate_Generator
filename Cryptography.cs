using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Encodings;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Prng;
using Org.BouncyCastle.Crypto.Signers;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.X509;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GenCertificate
{
    public class Cryptography
    {
        // BouncyCastle manage nuget package yüklemek lazım

        public static string RSASigntWithPEMPrivateKey(string privateKeyPemFileName, string text)
        {
            byte[] bytesToSign = Encoding.UTF8.GetBytes(text);
            AsymmetricCipherKeyPair keyPair = null;
            TextReader reader = File.OpenText(privateKeyPemFileName);
            keyPair = (AsymmetricCipherKeyPair)new PemReader(reader).ReadObject();

            byte[] signature = RSASigntWithPrivateKey(keyPair, bytesToSign);
            string result = Convert.ToBase64String(signature);

            return result;
        }

        public static byte[] RSASigntWithPrivateKey(AsymmetricCipherKeyPair keyPair, byte[] bytesToSign)
        {
            Sha256Digest sha256Digest = new Sha256Digest();
            byte[] theHash = new byte[sha256Digest.GetDigestSize()];
            sha256Digest.BlockUpdate(bytesToSign, 0, bytesToSign.Length);
            sha256Digest.DoFinal(theHash, 0);

            PssSigner signer = new PssSigner(new RsaEngine(), new Sha256Digest(), sha256Digest.GetDigestSize());
            signer.Init(true, keyPair.Private);
            signer.BlockUpdate(theHash, 0, theHash.Length);
            byte[] signature = signer.GenerateSignature();

            return signature;
        }

        public static bool VerifySignature(string publicKeyPemFileName, string text, string expectedSignature)
        {
            byte[] bytesToSign = Encoding.UTF8.GetBytes(text);
            byte[] expectedSignatureBytes = Convert.FromBase64String(expectedSignature);

            TextReader reader = File.OpenText(publicKeyPemFileName);
            AsymmetricKeyParameter keyPair = (AsymmetricKeyParameter)new PemReader(reader).ReadObject();

            Sha256Digest sha256Digest = new Sha256Digest();
            byte[] theHash = new byte[sha256Digest.GetDigestSize()];
            sha256Digest.BlockUpdate(bytesToSign, 0, bytesToSign.Length);
            sha256Digest.DoFinal(theHash, 0);

            PssSigner signer = new PssSigner(new RsaEngine(), new Sha256Digest(), sha256Digest.GetDigestSize());
            signer.Init(false,keyPair);
            signer.BlockUpdate(theHash, 0, theHash.Length);
            return signer.VerifySignature(expectedSignatureBytes);

        }

        public static X509Certificate2 CreateCertificate(string subjectName, string issuer, int ValidMonths, out AsymmetricCipherKeyPair asymmetricCipherKeyPair, int keyStrength = 2048)
        {
            CryptoApiRandomGenerator randomGnerator = new CryptoApiRandomGenerator();
            var random = new SecureRandom(randomGnerator);

            X509V3CertificateGenerator certificateGenerator = new X509V3CertificateGenerator();

            var serialNumber = BigIntegers.CreateRandomInRange(Org.BouncyCastle.Math.BigInteger.One, Org.BouncyCastle.Math.BigInteger.ValueOf(Int64.MaxValue), random);
            certificateGenerator.SetSerialNumber(serialNumber);



            var subjectDN = new X509Name(subjectName);
            var issuerDN = new X509Name(issuer);
            
            certificateGenerator.SetIssuerDN(issuerDN);
            certificateGenerator.SetSubjectDN(subjectDN);
            

            var notBefore = DateTime.UtcNow.Date;
            var notAfter = notBefore.AddMonths(ValidMonths);


            certificateGenerator.SetNotBefore(notBefore);
            certificateGenerator.SetNotAfter(notAfter);

            certificateGenerator.AddExtension(X509Extensions.KeyUsage.Id, true, new KeyUsage(KeyUsage.KeyEncipherment));

            AsymmetricCipherKeyPair subjectKeyPair;
            var keyGenerationParameters = new KeyGenerationParameters(random, keyStrength);
            var keyPairGenerator = new RsaKeyPairGenerator();

            keyPairGenerator.Init(keyGenerationParameters);
            subjectKeyPair = keyPairGenerator.GenerateKeyPair();
            

            certificateGenerator.SetPublicKey(subjectKeyPair.Public);

            var issuerKeyPair = subjectKeyPair;
            asymmetricCipherKeyPair = subjectKeyPair;

            certificateGenerator.SetSignatureAlgorithm("SHA256WithRSA");
            var certificate = certificateGenerator.Generate(issuerKeyPair.Private, random);
            certificate.CheckValidity();

            var x509 = new System.Security.Cryptography.X509Certificates.X509Certificate2(certificate.GetEncoded());

            return x509;

        }

        public static string EncryptWithPublicKey(string PEMFileName, string text)
        {
            byte[] bytesToOperateOn = Encoding.UTF8.GetBytes(text);
            TextReader reader = File.OpenText(PEMFileName);
            AsymmetricKeyParameter keyPair = (AsymmetricKeyParameter)new PemReader(reader).ReadObject();

            OaepEncoding engine = new OaepEncoding(new RsaEngine(), new Sha256Digest(), new Sha256Digest(), null);
            engine.Init(true, keyPair);// if encryption is true use public key else use private
            byte[] output = engine.ProcessBlock(bytesToOperateOn, 0, bytesToOperateOn.Length);
            string result = Convert.ToBase64String(output);
            return result;
        }

        public static string DecryptWithPrivateKey(string PEMFileName, string text)
        {
            byte[] bytesToOperateOn = Convert.FromBase64String(text);
            TextReader reader = File.OpenText(PEMFileName);
            AsymmetricCipherKeyPair keyPair = (AsymmetricCipherKeyPair)new PemReader(reader).ReadObject();

            OaepEncoding engine = new OaepEncoding(new RsaEngine(), new Sha256Digest(), new Sha256Digest(), null);
            engine.Init(false, keyPair.Private); // if encryption is true use public key else use private

            string result = Encoding.UTF8.GetString(engine.ProcessBlock(bytesToOperateOn, 0, bytesToOperateOn.Length));
            return result;
        }
    }
}
