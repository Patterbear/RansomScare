﻿namespace RansomScare
{
    partial class SplashScreen
    {
        // Required designer variable.
        private System.ComponentModel.IContainer components = null;

        // Clean up any resources being used.
        // 'disposing' determines if managing resources should be disposed of
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.welcome = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.githubLink = new System.Windows.Forms.LinkLabel();
            this.infoLabel1 = new System.Windows.Forms.Label();
            this.infoLabel2 = new System.Windows.Forms.Label();
            this.infoLabel3 = new System.Windows.Forms.Label();
            this.understoodTickBox = new System.Windows.Forms.CheckBox();
            this.proceedButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // welcome
            // 
            this.welcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.welcome.Font = new System.Drawing.Font("Segoe UI Semibold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.Location = new System.Drawing.Point(0, 0);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(800, 96);
            this.welcome.TabIndex = 0;
            this.welcome.Text = "Welcome to RansomScare";
            this.welcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(0, 96);
            this.logoPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(800, 354);
            this.logoPictureBox.TabIndex = 1;
            this.logoPictureBox.TabStop = false;
            // 
            // githubLink
            // 
            this.githubLink.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.githubLink.AutoSize = true;
            this.githubLink.LinkArea = new System.Windows.Forms.LinkArea(70, 17);
            this.githubLink.Location = new System.Drawing.Point(151, 424);
            this.githubLink.Name = "githubLink";
            this.githubLink.Size = new System.Drawing.Size(479, 17);
            this.githubLink.TabIndex = 2;
            this.githubLink.TabStop = true;
            this.githubLink.Text = "RansomScare is an educational ransomware attack simulation created by Benjamin Mc" +
    "Gregor.";
            this.githubLink.UseCompatibleTextRendering = true;
            this.githubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.githubLink_LinkClicked);
            // 
            // infoLabel1
            // 
            this.infoLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel1.Location = new System.Drawing.Point(310, 96);
            this.infoLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.infoLabel1.Name = "infoLabel1";
            this.infoLabel1.Size = new System.Drawing.Size(462, 91);
            this.infoLabel1.TabIndex = 3;
            this.infoLabel1.Text = resources.GetString("infoLabel1.Text");
            this.infoLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // infoLabel2
            // 
            this.infoLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel2.Location = new System.Drawing.Point(310, 199);
            this.infoLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.infoLabel2.Name = "infoLabel2";
            this.infoLabel2.Size = new System.Drawing.Size(462, 49);
            this.infoLabel2.TabIndex = 4;
            this.infoLabel2.Text = "If the key is deleted, you WILL NOT be able to recover the encrypyted files.";
            this.infoLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // infoLabel3
            // 
            this.infoLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel3.Location = new System.Drawing.Point(310, 257);
            this.infoLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.infoLabel3.Name = "infoLabel3";
            this.infoLabel3.Size = new System.Drawing.Size(462, 48);
            this.infoLabel3.TabIndex = 5;
            this.infoLabel3.Text = "A mock ransomware screen will appear after encryption. To decrypt the files, simp" +
    "ly press the \'Recover Files\' button.";
            this.infoLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // understoodTickBox
            // 
            this.understoodTickBox.AutoSize = true;
            this.understoodTickBox.Location = new System.Drawing.Point(414, 320);
            this.understoodTickBox.Name = "understoodTickBox";
            this.understoodTickBox.Size = new System.Drawing.Size(265, 17);
            this.understoodTickBox.TabIndex = 6;
            this.understoodTickBox.Text = "I have read and understood the above information.";
            this.understoodTickBox.UseVisualStyleBackColor = true;
            // 
            // proceedButton
            // 
            this.proceedButton.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proceedButton.Location = new System.Drawing.Point(451, 343);
            this.proceedButton.Name = "proceedButton";
            this.proceedButton.Size = new System.Drawing.Size(174, 59);
            this.proceedButton.TabIndex = 7;
            this.proceedButton.Text = "Proceed";
            this.proceedButton.UseVisualStyleBackColor = true;
            this.proceedButton.Click += new System.EventHandler(this.proceedButton_Click);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.proceedButton);
            this.Controls.Add(this.understoodTickBox);
            this.Controls.Add(this.infoLabel3);
            this.Controls.Add(this.infoLabel2);
            this.Controls.Add(this.infoLabel1);
            this.Controls.Add(this.githubLink);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.welcome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SplashScreen";
            this.Text = "RansomScare - Welcome";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.LinkLabel githubLink;
        private System.Windows.Forms.Label infoLabel1;
        private System.Windows.Forms.Label infoLabel2;
        private System.Windows.Forms.Label infoLabel3;
        private System.Windows.Forms.CheckBox understoodTickBox;
        private System.Windows.Forms.Button proceedButton;
    }
}

