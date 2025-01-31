using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreding
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //Thread thread1 = new Thread(PrintNum);
            //Thread thread2 = new Thread(PrintNum);

            //thread1.Start();
            //thread2.Start();

            //thread1.Join();
            //thread2.Join();

            Task task1 = Task.Run(() => PrintNum());
            Task task2 = Task.Run(() => PrintNum());

            await Task.WhenAll(task1, task2);

        }
        public static void PrintNum()
        {
            //for(int i=1; i<7; i++)
            //{
            //    Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId}");
            //    Thread.Sleep(500);
            //}

            for (int i = 1; i < 9; i++)
            {
                Console.WriteLine($"Task {Task.CurrentId}: {i}");
                Task.Delay(1000);
            }
        }
    }
}
