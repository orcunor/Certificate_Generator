using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenCertificate
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            //this.IsMdiContainer = true;
        }

        private void buttonCreateCertificate_Click(object sender, EventArgs e)
        {
            frmGenerateCertificate frmGenerateCertificate = new frmGenerateCertificate();
            frmGenerateCertificate.Show();
        }

        private void buttonGenerateSignature_Click(object sender, EventArgs e)
        {
            frmGenerateSignature frmGenerateSignature = new frmGenerateSignature();
            frmGenerateSignature.Show();
        }

        private void buttonVerifySignature_Click(object sender, EventArgs e)
        {
            frmVerifySignature frmVerifySignature = new frmVerifySignature();
            frmVerifySignature.Show();
        }

        private void buttonAsymmetricEncDec_Click(object sender, EventArgs e)
        {
            frmEncryptionAndDecryption frmEncryptionAndDecryption = new frmEncryptionAndDecryption();
            frmEncryptionAndDecryption.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
