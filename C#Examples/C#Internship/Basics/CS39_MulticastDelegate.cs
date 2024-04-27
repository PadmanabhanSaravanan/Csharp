using System;

delegate void MyDelegate(string message);

class CS39_MulticastDelegate
{
    static void Method1(string message)
    {
        Console.WriteLine("Method 1: " + message);
    }

    static void Method2(string message)
    {
        Console.WriteLine("Method 2: " + message);
    }

      void Main(string[] args)
    {
        MyDelegate multicastDelegate = Method1;
        multicastDelegate += Method2;

        // Invoke the multicast delegate, which will call both Method1 and Method2
        multicastDelegate("Hello, delegates!");

        // Remove Method2 from the multicast delegate
        multicastDelegate -= Method2;

        // Invoke the multicast delegate again, which will only call Method1
        multicastDelegate("Hello again!");
    }
}
