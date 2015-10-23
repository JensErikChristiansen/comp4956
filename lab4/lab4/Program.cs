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
        private static int qSize;
        private static object mutex = new object();
        private static object occupiedSpace = new object();
        private static object emptySpace = new object();

        private static Queue<int> queue = new Queue<int>();

        static void Main(string[] args)
        {
            int userProducerSleepTime, userConsumerSleepTime;
            do
            {
                Console.Write("Enter a buffer size:");
            } while (!int.TryParse(Console.ReadLine(), out qSize));

            do
            {
                Console.Write("Enter a time to sleep for the producer:");
            } while (!int.TryParse(Console.ReadLine(), out userProducerSleepTime));

            do
            {
                Console.Write("Enter a time to sleep for the consumer:");
            } while (!int.TryParse(Console.ReadLine(), out userConsumerSleepTime));

            Producer p1 = new Producer(userProducerSleepTime, "chef carl");
            Consumer c1 = new Consumer(userConsumerSleepTime, "Sally");
            Producer p2 = new Producer(userProducerSleepTime, "chef dan");
            Consumer c2 = new Consumer(3, "John");

            Thread producerThread1 = new Thread(p1.Produce);
            Thread consumerThread1 = new Thread(c1.Consume);
            Thread producerThread2 = new Thread(p2.Produce);
            Thread consumerThread2 = new Thread(c2.Consume);
            producerThread1.Start();
            consumerThread1.Start();
            producerThread2.Start();
            consumerThread2.Start();
        }



        private class Producer
        {
            private int sleepTime;
            private string name;
            private volatile int data = 0;

            public Producer(int sleepTime, string name)
            {
                this.sleepTime = sleepTime * 1000;
                this.name = name;
            }

            public void Produce()
            {
                while (true)
                {
                    if (queue.Count < qSize)
                    {
                        Thread.Sleep(sleepTime); // simulate creation of data

                        lock (mutex)
                        {
                            queue.Enqueue(++data);
                            Console.WriteLine(name + " writes " + data);
                        }


                        lock (occupiedSpace)
                        {
                            Monitor.Pulse(occupiedSpace);
                        }

                    }
                    else
                    {
                        lock (emptySpace)
                        {
                            Monitor.Wait(emptySpace);
                        }
                    }
                }
            }
        }

        private class Consumer
        {
            private int sleepTime;
            private string name;

            public Consumer (int sleepTime, string name)
            {
                this.sleepTime = sleepTime * 1000;
                this.name = name;
            }

            public void Consume()
            {
                while (true)
                {
                    lock (occupiedSpace)
                    {
                        Monitor.Wait(occupiedSpace);
                    }

                    Thread.Sleep(sleepTime);

                    int data;

                    lock (mutex)
                    {
                        data = queue.Dequeue();
                        Console.WriteLine(name + " reads " + data);
                    }



                    lock (emptySpace)
                    {
                        Monitor.Pulse(emptySpace);
                    }

                }
            }
        }


    }

    
}
