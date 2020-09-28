namespace WindowsFormsApplication2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbEncrypt = new System.Windows.Forms.TextBox();
            this.txbDecrypt = new System.Windows.Forms.TextBox();
            this.txbTextToEncrypt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Encrypted Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Decrypted Text";
            // 
            // txbEncrypt
            // 
            this.txbEncrypt.Location = new System.Drawing.Point(108, 123);
            this.txbEncrypt.Name = "txbEncrypt";
            this.txbEncrypt.Size = new System.Drawing.Size(278, 20);
            this.txbEncrypt.TabIndex = 2;
            // 
            // txbDecrypt
            // 
            this.txbDecrypt.Location = new System.Drawing.Point(507, 123);
            this.txbDecrypt.Name = "txbDecrypt";
            this.txbDecrypt.Size = new System.Drawing.Size(182, 20);
            this.txbDecrypt.TabIndex = 3;
            // 
            // txbTextToEncrypt
            // 
            this.txbTextToEncrypt.Location = new System.Drawing.Point(332, 38);
            this.txbTextToEncrypt.Name = "txbTextToEncrypt";
            this.txbTextToEncrypt.Size = new System.Drawing.Size(100, 20);
            this.txbTextToEncrypt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Text to Encrypt";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(271, 207);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(144, 23);
            this.btnEncrypt.TabIndex = 6;
            this.btnEncrypt.Text = "Encrypt/Decrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 251);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbTextToEncrypt);
            this.Controls.Add(this.txbDecrypt);
            this.Controls.Add(this.txbEncrypt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbEncrypt;
        private System.Windows.Forms.TextBox txbDecrypt;
        private System.Windows.Forms.TextBox txbTextToEncrypt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEncrypt;
    }
}

