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
        public delegate void addItemHandler(int index, int count);

        public MainForm()
        {
            InitializeComponent();
            timeout = false;
            boxes = new RichTextBox[] { threadBox1, threadBox2, threadBox3, threadBox4, threadBox5, threadBox6 };
        }

        private void SetText(int index, int count)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            boxes[index].Text += count + "\n";
            boxes[index].SelectionStart = boxes[index].Text.Length;
            boxes[index].ScrollToCaret();
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispatcher disp = Dispatcher.CurrentDispatcher;
            Close();
        }

        private void startThreadsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThreadDialog dialog = new ThreadDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                numThreads = dialog.NumThreads;
                seconds = dialog.Seconds;

                foreach (var i in boxes)
                {
                    i.Clear();
                }

                startTimer();

                for (int i = 1; i < numThreads; i++)
                {
                    int temp = i;
                    Thread thread = new Thread(() => this.startThreads(temp));
                    thread.Start();
                }

                

            }
        }

        private void startThreads(int i)
        {
            int count = 0;

            while (!timeout)
            {
                //SetText(i, count);
                this.Invoke(new addItemHandler(SetText), new object[] { i, count });
                count++;
            }
        }

        void startTimer()
        {
            Task.Run(() =>
            {
                timeout = false;
                Thread.Sleep(seconds * 1000);
                timeout = true;

                this.Invoke((MethodInvoker)delegate
                {
                    for (int i = 0; i < numThreads; i++)
                    {
                        boxes[i].Text += DateTime.Now.ToString("h:mm:ss tt");
                    }
                });

                
            });

        }
    }
}
