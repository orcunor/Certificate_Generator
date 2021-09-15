
namespace GenCertificate
{
    partial class frmEncryptionAndDecryption
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
            this.buttonBrowse1 = new System.Windows.Forms.Button();
            this.textBoxPublicKey = new System.Windows.Forms.TextBox();
            this.lblSelectPrivateKey = new System.Windows.Forms.Label();
            this.buttonBrowse2 = new System.Windows.Forms.Button();
            this.textBoxPrivateKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxInputString = new System.Windows.Forms.TextBox();
            this.textBoxOutputString = new System.Windows.Forms.TextBox();
            this.labelInputString = new System.Windows.Forms.Label();
            this.labelOutputString = new System.Windows.Forms.Label();
            this.buttonCopyToInput = new System.Windows.Forms.Button();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBrowse1
            // 
            this.buttonBrowse1.Location = new System.Drawing.Point(689, 43);
            this.buttonBrowse1.Name = "buttonBrowse1";
            this.buttonBrowse1.Size = new System.Drawing.Size(85, 23);
            this.buttonBrowse1.TabIndex = 15;
            this.buttonBrowse1.Text = "Browse...";
            this.buttonBrowse1.UseVisualStyleBackColor = true;
            this.buttonBrowse1.Click += new System.EventHandler(this.buttonBrowse1_Click);
            // 
            // textBoxPublicKey
            // 
            this.textBoxPublicKey.Location = new System.Drawing.Point(43, 46);
            this.textBoxPublicKey.Name = "textBoxPublicKey";
            this.textBoxPublicKey.ReadOnly = true;
            this.textBoxPublicKey.Size = new System.Drawing.Size(630, 20);
            this.textBoxPublicKey.TabIndex = 14;
            // 
            // lblSelectPrivateKey
            // 
            this.lblSelectPrivateKey.AutoSize = true;
            this.lblSelectPrivateKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectPrivateKey.Location = new System.Drawing.Point(40, 30);
            this.lblSelectPrivateKey.Name = "lblSelectPrivateKey";
            this.lblSelectPrivateKey.Size = new System.Drawing.Size(180, 13);
            this.lblSelectPrivateKey.TabIndex = 13;
            this.lblSelectPrivateKey.Text = "Select the Public Key PEM file";
            // 
            // buttonBrowse2
            // 
            this.buttonBrowse2.Location = new System.Drawing.Point(689, 110);
            this.buttonBrowse2.Name = "buttonBrowse2";
            this.buttonBrowse2.Size = new System.Drawing.Size(85, 23);
            this.buttonBrowse2.TabIndex = 18;
            this.buttonBrowse2.Text = "Browse..";
            this.buttonBrowse2.UseVisualStyleBackColor = true;
            this.buttonBrowse2.Click += new System.EventHandler(this.buttonBrowse2_Click);
            // 
            // textBoxPrivateKey
            // 
            this.textBoxPrivateKey.Location = new System.Drawing.Point(43, 110);
            this.textBoxPrivateKey.Name = "textBoxPrivateKey";
            this.textBoxPrivateKey.ReadOnly = true;
            this.textBoxPrivateKey.Size = new System.Drawing.Size(630, 20);
            this.textBoxPrivateKey.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Select the Private key PEM file";
            // 
            // textBoxInputString
            // 
            this.textBoxInputString.Location = new System.Drawing.Point(43, 185);
            this.textBoxInputString.Multiline = true;
            this.textBoxInputString.Name = "textBoxInputString";
            this.textBoxInputString.Size = new System.Drawing.Size(273, 178);
            this.textBoxInputString.TabIndex = 19;
            this.textBoxInputString.TextChanged += new System.EventHandler(this.textBoxInputString_TextChanged);
            // 
            // textBoxOutputString
            // 
            this.textBoxOutputString.Location = new System.Drawing.Point(480, 185);
            this.textBoxOutputString.Multiline = true;
            this.textBoxOutputString.Name = "textBoxOutputString";
            this.textBoxOutputString.ReadOnly = true;
            this.textBoxOutputString.Size = new System.Drawing.Size(294, 178);
            this.textBoxOutputString.TabIndex = 20;
            // 
            // labelInputString
            // 
            this.labelInputString.AutoSize = true;
            this.labelInputString.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInputString.Location = new System.Drawing.Point(43, 166);
            this.labelInputString.Name = "labelInputString";
            this.labelInputString.Size = new System.Drawing.Size(77, 13);
            this.labelInputString.TabIndex = 21;
            this.labelInputString.Text = "Input String:";
            // 
            // labelOutputString
            // 
            this.labelOutputString.AutoSize = true;
            this.labelOutputString.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutputString.Location = new System.Drawing.Point(498, 169);
            this.labelOutputString.Name = "labelOutputString";
            this.labelOutputString.Size = new System.Drawing.Size(86, 13);
            this.labelOutputString.TabIndex = 22;
            this.labelOutputString.Text = "Output String:";
            // 
            // buttonCopyToInput
            // 
            this.buttonCopyToInput.Location = new System.Drawing.Point(590, 160);
            this.buttonCopyToInput.Name = "buttonCopyToInput";
            this.buttonCopyToInput.Size = new System.Drawing.Size(94, 24);
            this.buttonCopyToInput.TabIndex = 23;
            this.buttonCopyToInput.Text = "Copy To Input";
            this.buttonCopyToInput.UseVisualStyleBackColor = true;
            this.buttonCopyToInput.Click += new System.EventHandler(this.buttonCopyToInput_Click);
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(352, 214);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(103, 24);
            this.buttonEncrypt.TabIndex = 24;
            this.buttonEncrypt.Text = "Encrypt";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(352, 280);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(103, 24);
            this.buttonDecrypt.TabIndex = 25;
            this.buttonDecrypt.Text = "Decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(672, 379);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(102, 24);
            this.buttonExit.TabIndex = 26;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // frmEncryptionAndDecryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 415);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.buttonCopyToInput);
            this.Controls.Add(this.labelOutputString);
            this.Controls.Add(this.labelInputString);
            this.Controls.Add(this.textBoxOutputString);
            this.Controls.Add(this.textBoxInputString);
            this.Controls.Add(this.buttonBrowse2);
            this.Controls.Add(this.textBoxPrivateKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBrowse1);
            this.Controls.Add(this.textBoxPublicKey);
            this.Controls.Add(this.lblSelectPrivateKey);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEncryptionAndDecryption";
            this.Text = "Asymmetric Encryption/Decryption";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBrowse1;
        private System.Windows.Forms.TextBox textBoxPublicKey;
        private System.Windows.Forms.Label lblSelectPrivateKey;
        private System.Windows.Forms.Button buttonBrowse2;
        private System.Windows.Forms.TextBox textBoxPrivateKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxInputString;
        private System.Windows.Forms.TextBox textBoxOutputString;
        private System.Windows.Forms.Label labelInputString;
        private System.Windows.Forms.Label labelOutputString;
        private System.Windows.Forms.Button buttonCopyToInput;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Button buttonExit;
    }
}