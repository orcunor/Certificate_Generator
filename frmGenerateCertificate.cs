using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.OpenSsl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenCertificate
{
    public partial class frmGenerateCertificate : Form
    {
        public frmGenerateCertificate()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                // CN=MY COMPANY  -- Common Name
                // C=GB -- Country, ST=Berkshire --- State, L=Izmir--Location, O=MY COMPANY--Organization, E= -- E-mail
                if ((int)spinEdit1.Value > 0)
                {
                    AsymmetricCipherKeyPair CertificateKey;

                    X509Certificate2 X509RootCert = Cryptography.CreateCertificate(textBoxSubject.Text, textBoxIssuer.Text, (int)spinEdit1.Value, out CertificateKey);
                    
                    File.WriteAllBytes(textBoxOutputFolder.Text + "\\" + $"{textBoxIssuer.Text.Substring(3,5)}.cer", X509RootCert.RawData);
                    string PEMFilePublicKey = textBoxOutputFolder.Text + "\\" + $"{textBoxIssuer.Text.Substring(3, 5)}PublicKey.pem";
                    string PEMFilePrivateKey = textBoxOutputFolder.Text + "\\" + $"{textBoxIssuer.Text.Substring(3, 5)}PrivateKey.pem";

                    using (TextWriter textWriter = new StreamWriter(PEMFilePublicKey, false))
                    {
                        PemWriter pemWriter = new PemWriter(textWriter);
                        pemWriter.WriteObject(CertificateKey.Public);
                        pemWriter.Writer.Flush();
                    }
                    using (TextWriter textWriter = new StreamWriter(PEMFilePrivateKey, false))
                    {
                        PemWriter pemWriter = new PemWriter(textWriter);
                        pemWriter.WriteObject(CertificateKey.Private);
                        pemWriter.Writer.Flush();
                    }
                    

                    MessageBox.Show("The security certificates have been succesfully generated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Please enter a months value bigger than 0");
                }

                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                folderBrowserDialog.Description = "Select the folder to store the certificates";
                DialogResult dialogResult = folderBrowserDialog.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    textBoxOutputFolder.Text = folderBrowserDialog.SelectedPath;
                    buttonGenerate.Enabled = textBoxOutputFolder.Text.Length > 0;
                }
            }
            catch (Exception)
            {

                throw;
            }
           
        }

       
    }
}
