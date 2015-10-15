using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Threads
{
    public partial class ThreadDialog : Form
    {
        public int NumThreads
        {
            get; set;
        }
        public int Seconds
        {
            get; set;
        }
        public ThreadDialog()
        {
            InitializeComponent();
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            NumThreads = (int)threadsSpinner.Value;
            Seconds = (int)secondsSpinner.Value;
        }
    }
}
