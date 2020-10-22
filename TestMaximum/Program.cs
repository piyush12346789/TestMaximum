using System;

namespace TestMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 112, 344, 432, 555, 678 };
            GenericMaximum<int> genericInteger = new GenericMaximum<int>(intArray);            
            float[] floatArray = { 11.2f, 34.4f, 4.32f, 55.5f, 6.78f };
            GenericMaximum<float> genericFloat = new GenericMaximum<float>(floatArray);
            string[] stringArray = { "a111", "b222", "c333", "d55", "e999" };
            GenericMaximum<string> genericString = new GenericMaximum<string>(stringArray);
            genericInteger.PrintMax();
            genericFloat.PrintMax();
            genericString.PrintMax();
        }
    }
}
