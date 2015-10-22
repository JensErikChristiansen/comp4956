using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace lab4
{
    class Monitors
    {
        private int producerRate = 1000;
        private int consumerRate = 2000;
        private int data = 0;
        private int qSize = 5;
        private object mutex = new object();

        Queue<int> queue;

        public Monitors()
        {
            queue = new Queue<int>();
        }
        static void Main(string[] args)
        {

        }

        private void Produce()
        {
            while (true)
            {
                Thread.Sleep(producerRate);
                lock (queue) {
                    if (queue.Count < qSize)
                    {
                        queue.Enqueue(++data); 
                    }
                }
            }
        }

        private void Consume()
        {
            while (true)
            {
                Thread.Sleep(consumerRate);

                lock(mutex)
                {
                    if (queue.Count > 0)
                    {
                        queue.Dequeue();
                    }
                }
                

            }
        }


    }

    
}
