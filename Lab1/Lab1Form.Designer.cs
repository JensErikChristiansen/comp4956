namespace Lab1 {
    partial class formLab1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.buttonDiskInfo = new System.Windows.Forms.Button();
            this.buttonProcessInfo = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.RichTextBox();
            this.buttonRegApp = new System.Windows.Forms.Button();
            this.buttonWinTextColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDiskInfo
            // 
            this.buttonDiskInfo.Location = new System.Drawing.Point(12, 120);
            this.buttonDiskInfo.Name = "buttonDiskInfo";
            this.buttonDiskInfo.Size = new System.Drawing.Size(148, 47);
            this.buttonDiskInfo.TabIndex = 1;
            this.buttonDiskInfo.Text = "Get Disk Info";
            this.buttonDiskInfo.UseVisualStyleBackColor = true;
            this.buttonDiskInfo.Click += new System.EventHandler(this.buttonDiskInfoClick);
            // 
            // buttonProcessInfo
            // 
            this.buttonProcessInfo.Location = new System.Drawing.Point(12, 173);
            this.buttonProcessInfo.Name = "buttonProcessInfo";
            this.buttonProcessInfo.Size = new System.Drawing.Size(148, 47);
            this.buttonProcessInfo.TabIndex = 2;
            this.buttonProcessInfo.Text = "Get Process Info";
            this.buttonProcessInfo.UseVisualStyleBackColor = true;
            this.buttonProcessInfo.Click += new System.EventHandler(this.buttonProcessInfoClick);
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(166, 14);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(357, 397);
            this.info.TabIndex = 3;
            this.info.Text = "";
            // 
            // buttonRegApp
            // 
            this.buttonRegApp.Location = new System.Drawing.Point(12, 14);
            this.buttonRegApp.Name = "buttonRegApp";
            this.buttonRegApp.Size = new System.Drawing.Size(148, 47);
            this.buttonRegApp.TabIndex = 4;
            this.buttonRegApp.Text = "Register Application";
            this.buttonRegApp.UseVisualStyleBackColor = true;
            this.buttonRegApp.Click += new System.EventHandler(this.buttonRegAppClick);
            // 
            // buttonWinTextColor
            // 
            this.buttonWinTextColor.Location = new System.Drawing.Point(12, 67);
            this.buttonWinTextColor.Name = "buttonWinTextColor";
            this.buttonWinTextColor.Size = new System.Drawing.Size(148, 47);
            this.buttonWinTextColor.TabIndex = 5;
            this.buttonWinTextColor.Text = "Change Window Text Color";
            this.buttonWinTextColor.UseVisualStyleBackColor = true;
            this.buttonWinTextColor.Click += new System.EventHandler(this.buttonWinTextColorClick);
            // 
            // formLab1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 423);
            this.Controls.Add(this.buttonWinTextColor);
            this.Controls.Add(this.buttonRegApp);
            this.Controls.Add(this.info);
            this.Controls.Add(this.buttonProcessInfo);
            this.Controls.Add(this.buttonDiskInfo);
            this.Name = "formLab1";
            this.Text = "Lab 1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonDiskInfo;
        private System.Windows.Forms.Button buttonProcessInfo;
        private System.Windows.Forms.RichTextBox info;
        private System.Windows.Forms.Button buttonRegApp;
        private System.Windows.Forms.Button buttonWinTextColor;
    }
}

