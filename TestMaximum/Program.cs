using System;

namespace TestMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 112, 344, 432, 555, 678 };
            GenericMaximum<int> generic = new GenericMaximum<int>(intArray);
            Console.WriteLine(generic.MaxValue());
            float[] floatArray = { 11.2f, 34.4f, 4.32f, 55.5f, 6.78f };
            GenericMaximum<float> genericFloat = new GenericMaximum<float>(floatArray);
            Console.WriteLine(genericFloat.MaxValue());
            string[] stringArray = { "a111", "b222", "c333", "d55", "e999" };
            GenericMaximum<string> genericString = new GenericMaximum<string>(stringArray);
            Console.WriteLine(genericString.MaxValue());
        }
    }
}
