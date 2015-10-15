using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace Threads
{
    public partial class MainForm : Form
    {
        private int numThreads;
        private int seconds;
        private static bool timeout;
        private RichTextBox[] boxes;

        public MainForm()
        {
            InitializeComponent();
            timeout = false;
            boxes = new RichTextBox[] { threadBox1, threadBox2, threadBox3, threadBox4, threadBox5, threadBox6 };
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispatcher disp = Dispatcher.CurrentDispatcher;
            Close();
        }

        private async void startThreadsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThreadDialog dialog = new ThreadDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                numThreads = dialog.NumThreads;
                seconds = dialog.Seconds;

                for (int i = 0; i < numThreads; i++)
                {
                    startWorkerAsync(i);
                }

                String str = await timerTaskAsync();
            }
        }

        private Task startWorkerAsync(int i)
        {
            boxes[i].Text = "";
            return Task.Run(() => startWorker(i));
        }

        private void startWorker(int i)
        {
            int count = 0;

            while (!timeout)
            {
                //Dispatcher.CurrentDispatcher.Invoke((Action)delegate () {
                //    boxes[i].Text = count.ToString();
                //});
                /*
                this.Dispatcher.Invoke((Action)(() => {
                    statusLabel.Content = e;
                }));
                */
                /*
                this.Invoke((MethodInvoker)delegate
                {
                    boxes[i].Text += count.ToString() + "\n";
                });
                */

                Dispatcher.CurrentDispatcher.InvokeAsync((Action)(() =>
                {
                    boxes[i].Text += count.ToString() + "\n";
                }));

                count++;
            }
            
            this.Invoke((MethodInvoker)delegate
            {
                boxes[i].Text = DateTime.Now.ToString("h:mm:ss tt");
            });
        }

        Task<String> timerTaskAsync()
        {
            return Task.Run(() => timerTask());
        }

        String timerTask()
        {
            Thread.Sleep(seconds * 1000);
            timeout = true;
            return DateTime.Now.ToString("h:mm:ss tt");
        }
    }
}
