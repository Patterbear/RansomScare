namespace TedEncrypt
{
    partial class DecryptionScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DecryptionScreen));
            this.decryptionDoneButton = new System.Windows.Forms.Button();
            this.statusBar = new System.Windows.Forms.ProgressBar();
            this.statusLabel = new System.Windows.Forms.Label();
            this.decryptionImage = new System.Windows.Forms.PictureBox();
            this.beginButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.decryptionImage)).BeginInit();
            this.SuspendLayout();
            // 
            // decryptionDoneButton
            // 
            this.decryptionDoneButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.decryptionDoneButton.Enabled = false;
            this.decryptionDoneButton.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptionDoneButton.Location = new System.Drawing.Point(107, 276);
            this.decryptionDoneButton.Name = "decryptionDoneButton";
            this.decryptionDoneButton.Size = new System.Drawing.Size(134, 60);
            this.decryptionDoneButton.TabIndex = 9;
            this.decryptionDoneButton.Text = "Finish";
            this.decryptionDoneButton.UseVisualStyleBackColor = true;
            this.decryptionDoneButton.Click += new System.EventHandler(this.decryptionDoneButton_Click);
            // 
            // statusBar
            // 
            this.statusBar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.statusBar.Location = new System.Drawing.Point(85, 242);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(195, 23);
            this.statusBar.Step = 100;
            this.statusBar.TabIndex = 8;
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(67, 202);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(224, 37);
            this.statusLabel.TabIndex = 7;
            this.statusLabel.Text = "Status: Encrypted";
            // 
            // decryptionImage
            // 
            this.decryptionImage.Image = ((System.Drawing.Image)(resources.GetObject("decryptionImage.Image")));
            this.decryptionImage.Location = new System.Drawing.Point(85, 12);
            this.decryptionImage.Name = "decryptionImage";
            this.decryptionImage.Size = new System.Drawing.Size(195, 178);
            this.decryptionImage.TabIndex = 10;
            this.decryptionImage.TabStop = false;
            // 
            // beginButton
            // 
            this.beginButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.beginButton.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beginButton.Location = new System.Drawing.Point(107, 276);
            this.beginButton.Name = "beginButton";
            this.beginButton.Size = new System.Drawing.Size(134, 60);
            this.beginButton.TabIndex = 11;
            this.beginButton.Text = "Begin";
            this.beginButton.UseVisualStyleBackColor = true;
            this.beginButton.Click += new System.EventHandler(this.beginButton_Click);
            // 
            // DecryptionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 363);
            this.Controls.Add(this.beginButton);
            this.Controls.Add(this.decryptionImage);
            this.Controls.Add(this.decryptionDoneButton);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.statusLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DecryptionScreen";
            this.Text = "TedEncrypt - Decryption";
            ((System.ComponentModel.ISupportInitialize)(this.decryptionImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button decryptionDoneButton;
        private System.Windows.Forms.ProgressBar statusBar;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.PictureBox decryptionImage;
        private System.Windows.Forms.Button beginButton;
    }
}