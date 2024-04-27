using System;
using System.Threading;

namespace ThreadStartDelegateExample
{
    class CS74_ParameterizedThreadStart
    {
        void Main()
        {
            Console.WriteLine("Please enter the target number");
            object target = Console.ReadLine();

            // Create an instance ParameterizedThreadStart delegate
            ParameterizedThreadStart parameterizedThreadStart =
                new ParameterizedThreadStart(Number1.PrintNumbers);
            Thread T1 = new Thread(parameterizedThreadStart);
            // Pass the traget number to the start function, which
            // will then be passed automatically to PrintNumbers() function
            T1.Start(target);
        }
    }

    class Number1
    {
        public static void PrintNumbers(object target)
        {
            int number = 0;
            if (int.TryParse(target.ToString(), out number))
            {
                for (int i = 1; i <= number; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
