
namespace GenCertificate
{
    partial class frmVerifySignature
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonVerifySignature = new System.Windows.Forms.Button();
            this.textBoxGenerateSignature = new System.Windows.Forms.TextBox();
            this.labelGenerateSignature = new System.Windows.Forms.Label();
            this.textBoxInputString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.textBoxPublicKeyFolder = new System.Windows.Forms.TextBox();
            this.lblSelectPrivateKey = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(450, 258);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(103, 23);
            this.buttonExit.TabIndex = 27;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonVerifySignature
            // 
            this.buttonVerifySignature.Location = new System.Drawing.Point(324, 258);
            this.buttonVerifySignature.Name = "buttonVerifySignature";
            this.buttonVerifySignature.Size = new System.Drawing.Size(111, 23);
            this.buttonVerifySignature.TabIndex = 26;
            this.buttonVerifySignature.Text = "Verify Signature";
            this.buttonVerifySignature.UseVisualStyleBackColor = true;
            this.buttonVerifySignature.Click += new System.EventHandler(this.buttonVerifySignature_Click);
            // 
            // textBoxGenerateSignature
            // 
            this.textBoxGenerateSignature.Location = new System.Drawing.Point(24, 144);
            this.textBoxGenerateSignature.Multiline = true;
            this.textBoxGenerateSignature.Name = "textBoxGenerateSignature";
            this.textBoxGenerateSignature.Size = new System.Drawing.Size(529, 108);
            this.textBoxGenerateSignature.TabIndex = 25;
            // 
            // labelGenerateSignature
            // 
            this.labelGenerateSignature.AutoSize = true;
            this.labelGenerateSignature.Location = new System.Drawing.Point(21, 128);
            this.labelGenerateSignature.Name = "labelGenerateSignature";
            this.labelGenerateSignature.Size = new System.Drawing.Size(283, 13);
            this.labelGenerateSignature.TabIndex = 24;
            this.labelGenerateSignature.Text = "Enter the signature which was generated using private key";
            // 
            // textBoxInputString
            // 
            this.textBoxInputString.Location = new System.Drawing.Point(24, 94);
            this.textBoxInputString.Name = "textBoxInputString";
            this.textBoxInputString.Size = new System.Drawing.Size(534, 20);
            this.textBoxInputString.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Enter the input string associated with this signature";
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(473, 40);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(85, 23);
            this.buttonBrowse.TabIndex = 21;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // textBoxPublicKeyFolder
            // 
            this.textBoxPublicKeyFolder.Location = new System.Drawing.Point(24, 40);
            this.textBoxPublicKeyFolder.Name = "textBoxPublicKeyFolder";
            this.textBoxPublicKeyFolder.ReadOnly = true;
            this.textBoxPublicKeyFolder.Size = new System.Drawing.Size(443, 20);
            this.textBoxPublicKeyFolder.TabIndex = 20;
            // 
            // lblSelectPrivateKey
            // 
            this.lblSelectPrivateKey.AutoSize = true;
            this.lblSelectPrivateKey.Location = new System.Drawing.Point(21, 21);
            this.lblSelectPrivateKey.Name = "lblSelectPrivateKey";
            this.lblSelectPrivateKey.Size = new System.Drawing.Size(272, 26);
            this.lblSelectPrivateKey.TabIndex = 19;
            this.lblSelectPrivateKey.Text = "Select Public Key PEM to be used for verifying signature\r\n\r\n";
            // 
            // frmVerifySignature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 307);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonVerifySignature);
            this.Controls.Add(this.textBoxGenerateSignature);
            this.Controls.Add(this.labelGenerateSignature);
            this.Controls.Add(this.textBoxInputString);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textBoxPublicKeyFolder);
            this.Controls.Add(this.lblSelectPrivateKey);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVerifySignature";
            this.Text = "Verify Digital Signature";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonVerifySignature;
        private System.Windows.Forms.TextBox textBoxGenerateSignature;
        private System.Windows.Forms.Label labelGenerateSignature;
        private System.Windows.Forms.TextBox textBoxInputString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox textBoxPublicKeyFolder;
        private System.Windows.Forms.Label lblSelectPrivateKey;
    }
}