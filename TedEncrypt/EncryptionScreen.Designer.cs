namespace TedEncrypt
{
    partial class EncryptionScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EncryptionScreen));
            this.encryptionImage = new System.Windows.Forms.PictureBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.encryptionDoneButton = new System.Windows.Forms.Button();
            this.beginButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.encryptionImage)).BeginInit();
            this.SuspendLayout();
            // 
            // encryptionImage
            // 
            this.encryptionImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.encryptionImage.Image = ((System.Drawing.Image)(resources.GetObject("encryptionImage.Image")));
            this.encryptionImage.Location = new System.Drawing.Point(85, 12);
            this.encryptionImage.Name = "encryptionImage";
            this.encryptionImage.Size = new System.Drawing.Size(193, 177);
            this.encryptionImage.TabIndex = 0;
            this.encryptionImage.TabStop = false;
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(67, 202);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(228, 37);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.Text = "Status: Decrypted";
            // 
            // encryptionDoneButton
            // 
            this.encryptionDoneButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.encryptionDoneButton.Enabled = false;
            this.encryptionDoneButton.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptionDoneButton.Location = new System.Drawing.Point(113, 253);
            this.encryptionDoneButton.Name = "encryptionDoneButton";
            this.encryptionDoneButton.Size = new System.Drawing.Size(134, 60);
            this.encryptionDoneButton.TabIndex = 3;
            this.encryptionDoneButton.Text = "Finish";
            this.encryptionDoneButton.UseVisualStyleBackColor = true;
            this.encryptionDoneButton.Click += new System.EventHandler(this.encryptionDoneButton_Click);
            // 
            // beginButton
            // 
            this.beginButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.beginButton.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beginButton.Location = new System.Drawing.Point(113, 253);
            this.beginButton.Name = "beginButton";
            this.beginButton.Size = new System.Drawing.Size(134, 60);
            this.beginButton.TabIndex = 4;
            this.beginButton.Text = "Begin";
            this.beginButton.UseVisualStyleBackColor = true;
            this.beginButton.Click += new System.EventHandler(this.beginButton_Click);
            // 
            // EncryptionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 336);
            this.Controls.Add(this.beginButton);
            this.Controls.Add(this.encryptionDoneButton);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.encryptionImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EncryptionScreen";
            this.Text = "TedEncrypt - Encryption";
            ((System.ComponentModel.ISupportInitialize)(this.encryptionImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox encryptionImage;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button encryptionDoneButton;
        private System.Windows.Forms.Button beginButton;
    }
}