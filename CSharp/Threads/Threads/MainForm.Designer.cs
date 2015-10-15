namespace Threads
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startThreadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.threadBox1 = new System.Windows.Forms.RichTextBox();
            this.threadBox2 = new System.Windows.Forms.RichTextBox();
            this.threadBox3 = new System.Windows.Forms.RichTextBox();
            this.threadBox4 = new System.Windows.Forms.RichTextBox();
            this.threadBox5 = new System.Windows.Forms.RichTextBox();
            this.threadBox6 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(828, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startThreadsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // startThreadsToolStripMenuItem
            // 
            this.startThreadsToolStripMenuItem.Name = "startThreadsToolStripMenuItem";
            this.startThreadsToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.startThreadsToolStripMenuItem.Text = "Start Threads";
            this.startThreadsToolStripMenuItem.Click += new System.EventHandler(this.startThreadsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // threadBox1
            // 
            this.threadBox1.Location = new System.Drawing.Point(12, 31);
            this.threadBox1.Name = "threadBox1";
            this.threadBox1.Size = new System.Drawing.Size(129, 327);
            this.threadBox1.TabIndex = 1;
            this.threadBox1.Text = "";
            // 
            // threadBox2
            // 
            this.threadBox2.Location = new System.Drawing.Point(147, 31);
            this.threadBox2.Name = "threadBox2";
            this.threadBox2.Size = new System.Drawing.Size(129, 327);
            this.threadBox2.TabIndex = 2;
            this.threadBox2.Text = "";
            // 
            // threadBox3
            // 
            this.threadBox3.Location = new System.Drawing.Point(282, 31);
            this.threadBox3.Name = "threadBox3";
            this.threadBox3.Size = new System.Drawing.Size(129, 327);
            this.threadBox3.TabIndex = 3;
            this.threadBox3.Text = "";
            // 
            // threadBox4
            // 
            this.threadBox4.Location = new System.Drawing.Point(417, 31);
            this.threadBox4.Name = "threadBox4";
            this.threadBox4.Size = new System.Drawing.Size(129, 327);
            this.threadBox4.TabIndex = 4;
            this.threadBox4.Text = "";
            // 
            // threadBox5
            // 
            this.threadBox5.Location = new System.Drawing.Point(552, 31);
            this.threadBox5.Name = "threadBox5";
            this.threadBox5.Size = new System.Drawing.Size(129, 327);
            this.threadBox5.TabIndex = 5;
            this.threadBox5.Text = "";
            // 
            // threadBox6
            // 
            this.threadBox6.Location = new System.Drawing.Point(687, 31);
            this.threadBox6.Name = "threadBox6";
            this.threadBox6.Size = new System.Drawing.Size(129, 327);
            this.threadBox6.TabIndex = 6;
            this.threadBox6.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 370);
            this.Controls.Add(this.threadBox6);
            this.Controls.Add(this.threadBox5);
            this.Controls.Add(this.threadBox4);
            this.Controls.Add(this.threadBox3);
            this.Controls.Add(this.threadBox2);
            this.Controls.Add(this.threadBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startThreadsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.RichTextBox threadBox1;
        private System.Windows.Forms.RichTextBox threadBox2;
        private System.Windows.Forms.RichTextBox threadBox3;
        private System.Windows.Forms.RichTextBox threadBox4;
        private System.Windows.Forms.RichTextBox threadBox5;
        private System.Windows.Forms.RichTextBox threadBox6;
    }
}

