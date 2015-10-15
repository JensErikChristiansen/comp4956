namespace Threads
{
    partial class ThreadDialog
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
            this.runBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.threadsLabel = new System.Windows.Forms.Label();
            this.secondsLabel = new System.Windows.Forms.Label();
            this.threadsSpinner = new System.Windows.Forms.NumericUpDown();
            this.secondsSpinner = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.threadsSpinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondsSpinner)).BeginInit();
            this.SuspendLayout();
            // 
            // runBtn
            // 
            this.runBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.runBtn.Location = new System.Drawing.Point(36, 216);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(160, 66);
            this.runBtn.TabIndex = 0;
            this.runBtn.Text = "Run";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(274, 216);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(160, 66);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // threadsLabel
            // 
            this.threadsLabel.AutoSize = true;
            this.threadsLabel.Location = new System.Drawing.Point(29, 46);
            this.threadsLabel.Name = "threadsLabel";
            this.threadsLabel.Size = new System.Drawing.Size(131, 17);
            this.threadsLabel.TabIndex = 2;
            this.threadsLabel.Text = "Number of Threads";
            // 
            // secondsLabel
            // 
            this.secondsLabel.AutoSize = true;
            this.secondsLabel.Location = new System.Drawing.Point(97, 106);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(63, 17);
            this.secondsLabel.TabIndex = 3;
            this.secondsLabel.Text = "Seconds";
            // 
            // threadsSpinner
            // 
            this.threadsSpinner.Location = new System.Drawing.Point(199, 44);
            this.threadsSpinner.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.threadsSpinner.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.threadsSpinner.Name = "threadsSpinner";
            this.threadsSpinner.Size = new System.Drawing.Size(120, 22);
            this.threadsSpinner.TabIndex = 4;
            this.threadsSpinner.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // secondsSpinner
            // 
            this.secondsSpinner.Location = new System.Drawing.Point(199, 104);
            this.secondsSpinner.Name = "secondsSpinner";
            this.secondsSpinner.Size = new System.Drawing.Size(120, 22);
            this.secondsSpinner.TabIndex = 5;
            this.secondsSpinner.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // ThreadDialog
            // 
            this.AcceptButton = this.runBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(470, 310);
            this.Controls.Add(this.secondsSpinner);
            this.Controls.Add(this.threadsSpinner);
            this.Controls.Add(this.secondsLabel);
            this.Controls.Add(this.threadsLabel);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.runBtn);
            this.Name = "ThreadDialog";
            this.Text = "Start Threads";
            ((System.ComponentModel.ISupportInitialize)(this.threadsSpinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondsSpinner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label threadsLabel;
        private System.Windows.Forms.Label secondsLabel;
        private System.Windows.Forms.NumericUpDown threadsSpinner;
        private System.Windows.Forms.NumericUpDown secondsSpinner;
    }
}