using System;

namespace TestMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            float TC1 = MaximumNumberCheck.MaximumNumber(3.01f,2.02f,1.03f);
            float TC2 = MaximumNumberCheck.MaximumNumber(20.01f,30.02f,10.03f);
            float TC3 = MaximumNumberCheck.MaximumNumber(200.01f,100.02f,300.03f);
            Console.WriteLine("Maximum number in TC1 is: {0}",TC1);
            Console.WriteLine("Maximum number in TC2 is: {0}",TC2);
            Console.WriteLine("Maximum number in TC3 is: {0}",TC3);
        }
    }
}
