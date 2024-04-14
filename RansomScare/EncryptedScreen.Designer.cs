namespace RansomScare
{
    partial class EncryptedScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EncryptedScreen));
            this.successImage = new System.Windows.Forms.PictureBox();
            this.informationLabel = new System.Windows.Forms.Label();
            this.decryptButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.successImage)).BeginInit();
            this.SuspendLayout();
            // 
            // successImage
            // 
            this.successImage.Image = ((System.Drawing.Image)(resources.GetObject("successImage.Image")));
            this.successImage.Location = new System.Drawing.Point(12, 12);
            this.successImage.Name = "successImage";
            this.successImage.Size = new System.Drawing.Size(286, 285);
            this.successImage.TabIndex = 0;
            this.successImage.TabStop = false;
            // 
            // informationLabel
            // 
            this.informationLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informationLabel.Location = new System.Drawing.Point(304, 23);
            this.informationLabel.Name = "informationLabel";
            this.informationLabel.Size = new System.Drawing.Size(359, 135);
            this.informationLabel.TabIndex = 2;
            this.informationLabel.Text = "Files in this folder are encrypted.\r\n\r\nIf the key is present in the directory you" +
    " may decrypt the file(s).";
            // 
            // decryptButton
            // 
            this.decryptButton.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptButton.Location = new System.Drawing.Point(493, 194);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(170, 74);
            this.decryptButton.TabIndex = 3;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(304, 194);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(170, 74);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // EncryptedScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 299);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.informationLabel);
            this.Controls.Add(this.successImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EncryptedScreen";
            this.Text = "RansomScare - Encrypted";
            ((System.ComponentModel.ISupportInitialize)(this.successImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox successImage;
        private System.Windows.Forms.Label informationLabel;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.Button exitButton;
    }
}