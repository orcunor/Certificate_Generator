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
    public partial class frmEncryptionAndDecryption : Form
    {
        public frmEncryptionAndDecryption()
        {
            InitializeComponent();
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxOutputString.Text = Cryptography.EncryptWithPublicKey(textBoxPublicKey.Text, textBoxInputString.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message , "Decryption Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxOutputString.Text = Cryptography.DecryptWithPrivateKey(textBoxPrivateKey.Text, textBoxOutputString.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Decryption Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBrowse1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog OpenFileDialog = new OpenFileDialog();
                OpenFileDialog.Filter = "PEM files(*.PEM) | *.PEM";
                DialogResult dialogResult = OpenFileDialog.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    textBoxPublicKey.Text = OpenFileDialog.FileName;

                }
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        private void buttonBrowse2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog OpenFileDialog = new OpenFileDialog();
                OpenFileDialog.Filter = "PEM files(*.PEM) | *.PEM";
                DialogResult dialogResult = OpenFileDialog.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    textBoxPrivateKey.Text = OpenFileDialog.FileName;

                }
                textBoxInputString.Enabled = textBoxPublicKey.Text.Length > 0 && textBoxPrivateKey.Text.Length > 0;
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        private void buttonCopyToInput_Click(object sender, EventArgs e)
        {
            textBoxInputString.Text = textBoxOutputString.Text;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxInputString_TextChanged(object sender, EventArgs e)
        {
            buttonEncrypt.Enabled = textBoxInputString.Text.Length > 0 && textBoxPublicKey.Text.Length > 0;
            buttonDecrypt.Enabled = textBoxInputString.Text.Length > 0 && textBoxPrivateKey.Text.Length > 0;
        }
    }
}
