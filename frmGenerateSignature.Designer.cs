
namespace GenCertificate
{
    partial class frmGenerateSignature
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
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.textBoxPrivateKeyFolder = new System.Windows.Forms.TextBox();
            this.lblSelectPrivateKey = new System.Windows.Forms.Label();
            this.textBoxInputString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxGenerateSignature = new System.Windows.Forms.TextBox();
            this.labelGenerateSignature = new System.Windows.Forms.Label();
            this.buttonGenerateSignature = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(451, 43);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(85, 23);
            this.buttonBrowse.TabIndex = 12;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // textBoxPrivateKeyFolder
            // 
            this.textBoxPrivateKeyFolder.Location = new System.Drawing.Point(25, 45);
            this.textBoxPrivateKeyFolder.Name = "textBoxPrivateKeyFolder";
            this.textBoxPrivateKeyFolder.ReadOnly = true;
            this.textBoxPrivateKeyFolder.Size = new System.Drawing.Size(420, 20);
            this.textBoxPrivateKeyFolder.TabIndex = 11;
            // 
            // lblSelectPrivateKey
            // 
            this.lblSelectPrivateKey.AutoSize = true;
            this.lblSelectPrivateKey.Location = new System.Drawing.Point(22, 29);
            this.lblSelectPrivateKey.Name = "lblSelectPrivateKey";
            this.lblSelectPrivateKey.Size = new System.Drawing.Size(323, 13);
            this.lblSelectPrivateKey.TabIndex = 10;
            this.lblSelectPrivateKey.Text = "Select Private Key Folder (.PEM) to be used for generate signature:\r\n";
            // 
            // textBoxInputString
            // 
            this.textBoxInputString.Location = new System.Drawing.Point(25, 104);
            this.textBoxInputString.Name = "textBoxInputString";
            this.textBoxInputString.Size = new System.Drawing.Size(458, 20);
            this.textBoxInputString.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Enter the input string for create a signature:";
            // 
            // textBoxGenerateSignature
            // 
            this.textBoxGenerateSignature.Location = new System.Drawing.Point(25, 161);
            this.textBoxGenerateSignature.Multiline = true;
            this.textBoxGenerateSignature.Name = "textBoxGenerateSignature";
            this.textBoxGenerateSignature.ReadOnly = true;
            this.textBoxGenerateSignature.Size = new System.Drawing.Size(529, 108);
            this.textBoxGenerateSignature.TabIndex = 16;
            // 
            // labelGenerateSignature
            // 
            this.labelGenerateSignature.AutoSize = true;
            this.labelGenerateSignature.Location = new System.Drawing.Point(22, 145);
            this.labelGenerateSignature.Name = "labelGenerateSignature";
            this.labelGenerateSignature.Size = new System.Drawing.Size(99, 13);
            this.labelGenerateSignature.TabIndex = 15;
            this.labelGenerateSignature.Text = "Generate Signature";
            // 
            // buttonGenerateSignature
            // 
            this.buttonGenerateSignature.Location = new System.Drawing.Point(327, 287);
            this.buttonGenerateSignature.Name = "buttonGenerateSignature";
            this.buttonGenerateSignature.Size = new System.Drawing.Size(111, 23);
            this.buttonGenerateSignature.TabIndex = 17;
            this.buttonGenerateSignature.Text = "Generate Signature";
            this.buttonGenerateSignature.UseVisualStyleBackColor = true;
            this.buttonGenerateSignature.Click += new System.EventHandler(this.buttonGenerateSignature_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(451, 287);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(103, 23);
            this.buttonExit.TabIndex = 18;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // frmGenerateSignature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 328);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonGenerateSignature);
            this.Controls.Add(this.textBoxGenerateSignature);
            this.Controls.Add(this.labelGenerateSignature);
            this.Controls.Add(this.textBoxInputString);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textBoxPrivateKeyFolder);
            this.Controls.Add(this.lblSelectPrivateKey);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGenerateSignature";
            this.Text = "Generate Digital Signature";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox textBoxPrivateKeyFolder;
        private System.Windows.Forms.Label lblSelectPrivateKey;
        private System.Windows.Forms.TextBox textBoxInputString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxGenerateSignature;
        private System.Windows.Forms.Label labelGenerateSignature;
        private System.Windows.Forms.Button buttonGenerateSignature;
        private System.Windows.Forms.Button buttonExit;
    }
}