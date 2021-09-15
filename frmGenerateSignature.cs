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
    public partial class frmGenerateSignature : Form
    {
        public frmGenerateSignature()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGenerateSignature_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxGenerateSignature.Text = Cryptography.RSASigntWithPEMPrivateKey(textBoxPrivateKeyFolder.Text, textBoxInputString.Text);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Signing Error" + ex.Message);
            }
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "PEM files(*.PEM) | *.PEM";
                DialogResult dialogResult = openFileDialog.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    textBoxPrivateKeyFolder.Text = openFileDialog.FileName;
                }
            }
            catch (Exception)
            {

                throw;
            }
          

            //textBoxInputString.Enabled = textBoxPrivateKeyFolder.Text.Length > 0;
            //buttonGenerateSignature.Enabled = textBoxInputString.Text.Length > 0;
        }
    }
}
