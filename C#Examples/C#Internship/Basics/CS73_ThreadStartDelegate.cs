using System;
using System.Threading;

namespace ThreadStartDelegateExample
{
    class CS73_ThreadStartDelegate
    {
         void Main()
        {
            Thread T1 = new Thread(Number.PrintNumbers);
            T1.Start();

            // Wait for the thread to complete before exiting the program
            T1.Join();

            Console.WriteLine("Main thread exiting...");
        }
    }

    class Number
    {
        public static void PrintNumbers()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
