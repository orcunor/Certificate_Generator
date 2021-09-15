
namespace GenCertificate
{
    partial class frmMain
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
            this.buttonCreateCertificate = new System.Windows.Forms.Button();
            this.buttonGenerateSignature = new System.Windows.Forms.Button();
            this.buttonVerifySignature = new System.Windows.Forms.Button();
            this.buttonAsymmetricEncDec = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCreateCertificate
            // 
            this.buttonCreateCertificate.Location = new System.Drawing.Point(14, 28);
            this.buttonCreateCertificate.Name = "buttonCreateCertificate";
            this.buttonCreateCertificate.Size = new System.Drawing.Size(182, 23);
            this.buttonCreateCertificate.TabIndex = 0;
            this.buttonCreateCertificate.Text = "Create Certificate";
            this.buttonCreateCertificate.UseVisualStyleBackColor = true;
            this.buttonCreateCertificate.Click += new System.EventHandler(this.buttonCreateCertificate_Click);
            // 
            // buttonGenerateSignature
            // 
            this.buttonGenerateSignature.Location = new System.Drawing.Point(14, 80);
            this.buttonGenerateSignature.Name = "buttonGenerateSignature";
            this.buttonGenerateSignature.Size = new System.Drawing.Size(182, 23);
            this.buttonGenerateSignature.TabIndex = 1;
            this.buttonGenerateSignature.Text = "Generate Signature";
            this.buttonGenerateSignature.UseVisualStyleBackColor = true;
            this.buttonGenerateSignature.Click += new System.EventHandler(this.buttonGenerateSignature_Click);
            // 
            // buttonVerifySignature
            // 
            this.buttonVerifySignature.Location = new System.Drawing.Point(231, 80);
            this.buttonVerifySignature.Name = "buttonVerifySignature";
            this.buttonVerifySignature.Size = new System.Drawing.Size(193, 23);
            this.buttonVerifySignature.TabIndex = 2;
            this.buttonVerifySignature.Text = "Verify Signature";
            this.buttonVerifySignature.UseVisualStyleBackColor = true;
            this.buttonVerifySignature.Click += new System.EventHandler(this.buttonVerifySignature_Click);
            // 
            // buttonAsymmetricEncDec
            // 
            this.buttonAsymmetricEncDec.Location = new System.Drawing.Point(231, 28);
            this.buttonAsymmetricEncDec.Name = "buttonAsymmetricEncDec";
            this.buttonAsymmetricEncDec.Size = new System.Drawing.Size(193, 23);
            this.buttonAsymmetricEncDec.TabIndex = 3;
            this.buttonAsymmetricEncDec.Text = "Asymmetric Encryption/Decryption";
            this.buttonAsymmetricEncDec.UseVisualStyleBackColor = true;
            this.buttonAsymmetricEncDec.Click += new System.EventHandler(this.buttonAsymmetricEncDec_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(332, 118);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(92, 23);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 144);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonAsymmetricEncDec);
            this.Controls.Add(this.buttonVerifySignature);
            this.Controls.Add(this.buttonGenerateSignature);
            this.Controls.Add(this.buttonCreateCertificate);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Certificate Generator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateCertificate;
        private System.Windows.Forms.Button buttonGenerateSignature;
        private System.Windows.Forms.Button buttonVerifySignature;
        private System.Windows.Forms.Button buttonAsymmetricEncDec;
        private System.Windows.Forms.Button buttonExit;
    }
}