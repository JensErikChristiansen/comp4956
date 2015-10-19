namespace Lab1 {
    partial class RegisterDialog {
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
            this.labelSpecialty = new System.Windows.Forms.Label();
            this.textBoxSpecialty = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxApplication = new System.Windows.Forms.TextBox();
            this.labelApplication = new System.Windows.Forms.Label();
            this.textBoxOwner = new System.Windows.Forms.TextBox();
            this.labelOwner = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.spinnerYear = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerYear)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSpecialty
            // 
            this.labelSpecialty.AutoSize = true;
            this.labelSpecialty.Location = new System.Drawing.Point(29, 21);
            this.labelSpecialty.Name = "labelSpecialty";
            this.labelSpecialty.Size = new System.Drawing.Size(65, 17);
            this.labelSpecialty.TabIndex = 7;
            this.labelSpecialty.Text = "Specialty";
            // 
            // textBoxSpecialty
            // 
            this.textBoxSpecialty.Location = new System.Drawing.Point(100, 18);
            this.textBoxSpecialty.Name = "textBoxSpecialty";
            this.textBoxSpecialty.Size = new System.Drawing.Size(212, 22);
            this.textBoxSpecialty.TabIndex = 1;
            this.textBoxSpecialty.Leave += new System.EventHandler(this.textBoxLeave);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(49, 145);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(96, 35);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOKClick);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(171, 145);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(96, 35);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // textBoxApplication
            // 
            this.textBoxApplication.Location = new System.Drawing.Point(100, 46);
            this.textBoxApplication.Name = "textBoxApplication";
            this.textBoxApplication.Size = new System.Drawing.Size(212, 22);
            this.textBoxApplication.TabIndex = 2;
            this.textBoxApplication.Leave += new System.EventHandler(this.textBoxLeave);
            // 
            // labelApplication
            // 
            this.labelApplication.AutoSize = true;
            this.labelApplication.Location = new System.Drawing.Point(17, 49);
            this.labelApplication.Name = "labelApplication";
            this.labelApplication.Size = new System.Drawing.Size(77, 17);
            this.labelApplication.TabIndex = 8;
            this.labelApplication.Text = "Application";
            // 
            // textBoxOwner
            // 
            this.textBoxOwner.Location = new System.Drawing.Point(100, 74);
            this.textBoxOwner.Name = "textBoxOwner";
            this.textBoxOwner.Size = new System.Drawing.Size(212, 22);
            this.textBoxOwner.TabIndex = 3;
            this.textBoxOwner.Leave += new System.EventHandler(this.textBoxLeave);
            // 
            // labelOwner
            // 
            this.labelOwner.AutoSize = true;
            this.labelOwner.Location = new System.Drawing.Point(45, 77);
            this.labelOwner.Name = "labelOwner";
            this.labelOwner.Size = new System.Drawing.Size(49, 17);
            this.labelOwner.TabIndex = 9;
            this.labelOwner.Text = "Owner";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(56, 105);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(38, 17);
            this.labelYear.TabIndex = 10;
            this.labelYear.Text = "Year";
            // 
            // spinnerYear
            // 
            this.spinnerYear.Location = new System.Drawing.Point(100, 102);
            this.spinnerYear.Maximum = new decimal(new int[] {
            2999,
            0,
            0,
            0});
            this.spinnerYear.Name = "spinnerYear";
            this.spinnerYear.Size = new System.Drawing.Size(91, 22);
            this.spinnerYear.TabIndex = 4;
            // 
            // RegisterDialog
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(357, 192);
            this.Controls.Add(this.spinnerYear);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.textBoxOwner);
            this.Controls.Add(this.labelOwner);
            this.Controls.Add(this.textBoxApplication);
            this.Controls.Add(this.labelApplication);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxSpecialty);
            this.Controls.Add(this.labelSpecialty);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterDialog";
            this.Text = "Registry";
            ((System.ComponentModel.ISupportInitialize)(this.spinnerYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSpecialty;
        private System.Windows.Forms.TextBox textBoxSpecialty;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxApplication;
        private System.Windows.Forms.Label labelApplication;
        private System.Windows.Forms.TextBox textBoxOwner;
        private System.Windows.Forms.Label labelOwner;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.NumericUpDown spinnerYear;
    }
}