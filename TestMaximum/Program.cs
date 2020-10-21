using System;

namespace TestMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            int TC1 = MaximumNumberCheck.MaximumIntegerNumber(3,2,1);
            int TC2 = MaximumNumberCheck.MaximumIntegerNumber(20,30,10);
            int TC3 = MaximumNumberCheck.MaximumIntegerNumber(200,100,300);
            Console.WriteLine("Maximum number in TC1 is: {0}",TC1);
            Console.WriteLine("Maximum number in TC2 is: {0}",TC2);
            Console.WriteLine("Maximum number in TC3 is: {0}",TC3);
        }
    }
}
