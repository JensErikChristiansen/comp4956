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
        private int producerRate;
        private int consumerRate;
        private volatile int data = 0;
        private int qSize;
        private object mutex = new object();
        private object occupiedSpace = new object();
        private object emptySpace = new object();

        Queue<int> queue = new Queue<int>();

        public Monitors(int userBufferSize, int userProducerSleepTime, int userConsumerSleepTime)
        {
            qSize = userBufferSize;
            producerRate = userProducerSleepTime * 100;
            consumerRate = userConsumerSleepTime * 100;

            Thread producerThread = new Thread(Produce);
            Thread consumerThread = new Thread(Consume);
            producerThread.Start();
            consumerThread.Start();
            producerThread.Join();
            consumerThread.Join();
        }
        static void Main(string[] args)
        {
            int userBufferSize, userProducerSleepTime, userConsumerSleepTime;
            do
            {
                Console.Write("Enter a buffer size:");
            } while (!int.TryParse(Console.ReadLine(), out userBufferSize));

            do
            {
                Console.Write("Enter a time to sleep for the producer:");
            } while (!int.TryParse(Console.ReadLine(), out userProducerSleepTime));

            do
            {
                Console.Write("Enter a time to sleep for the consumer:");
            } while (!int.TryParse(Console.ReadLine(), out userConsumerSleepTime));

            new Monitors(userBufferSize, userProducerSleepTime, userConsumerSleepTime);
        }


        private void Produce()
        {
            while (true)
            {
                if (queue.Count < qSize)
                {
                    Thread.Sleep(producerRate); // simulate creation of data
                    
                    lock (mutex)
                    {
                        queue.Enqueue(++data);
                        Console.WriteLine("Producer writes " + data);
                        Console.WriteLine("Queue size: " + queue.Count);
                    }
                    

                    lock (occupiedSpace)
                    {
                        Monitor.Pulse(occupiedSpace);
                    }

                } else
                {
                    lock (emptySpace)
                    {
                        Monitor.Wait(emptySpace);
                    }
                }

                
                
            }
        }

        private void Consume()
        {
            while (true)
            {
                lock (occupiedSpace)
                {
                    Monitor.Wait(occupiedSpace);
                }

                Thread.Sleep(consumerRate);

                int temp;

                lock (mutex)
                {
                    temp = queue.Dequeue();
                    Console.WriteLine("Consumer reads " + temp);
                    Console.WriteLine("Queue size: " + queue.Count);
                }



                lock (emptySpace)
                {
                    Monitor.Pulse(emptySpace);
                }
                
            }
        }


    }

    
}
