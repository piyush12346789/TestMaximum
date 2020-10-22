using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaximum
{
    public class GenericMaximum<dataType> where dataType : IComparable
    {
        public dataType[] array;
        public GenericMaximum(dataType[] array)
        {
            this.array = array;
        }

        public dataType[] Sort(dataType[] values)
        {
            Array.Sort(values);
            return values;
        }
        void Add(params int[] a)
        {

        }
        public dataType MaxValue(params dataType[] values)
        {
            dataType[] sortedArray = Sort(this.array);

            return sortedArray[sortedArray.Length - 1];
        }
        public void PrintMax()
        {
            dataType[] sortedArray = Sort(this.array);
            Console.WriteLine(sortedArray[sortedArray.Length-1]);
        }
    }
}

