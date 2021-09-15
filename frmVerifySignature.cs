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
    public partial class frmVerifySignature : Form
    {
        public frmVerifySignature()
        {
            InitializeComponent();
        }

        private void buttonVerifySignature_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = Cryptography.VerifySignature(textBoxPublicKeyFolder.Text, textBoxInputString.Text, textBoxGenerateSignature.Text);
                string output = result ? "The signature matches. Verification was successfull." : "The signature does NOT Matches. Verification was failed.";
                MessageBox.Show(output, result ? "Success" : "Error");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    textBoxPublicKeyFolder.Text = openFileDialog.FileName;
                }
            }
            catch (Exception)
            {

                throw;
            }
            

        }
    }
}
