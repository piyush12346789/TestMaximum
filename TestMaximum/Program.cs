using System;

namespace TestMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            string TC1 = MaximumNumberCheck.MaximumNumber("ghi","def","abc");
            string TC2 = MaximumNumberCheck.MaximumNumber("mno", "pqr", "jkl");
            string TC3 = MaximumNumberCheck.MaximumNumber("stu", "vwx", "yza");
            Console.WriteLine("Maximum number in TC1 is: {0}",TC1);
            Console.WriteLine("Maximum number in TC2 is: {0}",TC2);
            Console.WriteLine("Maximum number in TC3 is: {0}",TC3);
        }
    }
}
