using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1 {
    /// <summary>
    /// A form for entering and collecting subkey information.
    /// </summary>
    public partial class RegisterDialog : Form {

        #region properties
        public String Specialty { get; private set; }

        public String Application { get; private set; }

        public new String Owner { get; private set; }

        public int Year { get; private set; } = DateTime.Now.Year;
        #endregion

        public RegisterDialog() {
            InitializeComponent();
            spinnerYear.Value = DateTime.Now.Year;
            errorProvider = new ErrorProvider();
        }

        /// <summary>
        /// Set the properties for a new key.
        /// </summary>
        /// <param name="sender">unused</param>
        /// <param name="e">unused</param>
        private void buttonOKClick(object sender, EventArgs e) {
            Specialty = textBoxSpecialty.Text;
            Application = textBoxApplication.Text;
            Owner = textBoxOwner.Text;
            Year = (int)spinnerYear.Value;
            
            if (Specialty == "") {
                handleErrors(textBoxSpecialty);
            } else if (Application == "") {
                handleErrors(textBoxApplication);
            } else if (Owner == "") {
                handleErrors(textBoxOwner);
            } else {
                this.DialogResult = DialogResult.OK;
            }

        }

        #region validation

        ErrorProvider errorProvider;

        /// <summary>
        /// prevent user from leaving blank fields.
        /// </summary>
        /// <param name="tb">The active text box</param>
        private void handleErrors(TextBox tb) {
            if (tb.Text == "") {
                errorProvider.SetError(tb, "Value should not be empty");
                tb.Focus();
            } else {
                errorProvider.Clear();
            }
        }
        /// <summary>
        /// handles errors when user leaves each text box.
        /// </summary>
        /// <param name="sender">The active text box</param>
        /// <param name="e">unused</param>
        private void textBoxLeave(object sender, EventArgs e) {
            handleErrors((TextBox)sender);
        }
        #endregion
    }
}
