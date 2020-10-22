using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestMaximum;

namespace FindMaximumTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Passing_Integer_Array_Should_Return_Maximum_Value()
        {
            int[] intArray = { 10, 20, 30 };
            int expected = 30;
            GenericMaximum<int> find = new GenericMaximum<int>(intArray);
            int actual = find.MaxValue();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Passing_float_Array_Should_Return_Maximum_Value()
        {
            float[] floatArray = { 10.5f, 20.5f, 30.5f };
            float expected = 30.5f;
            GenericMaximum<float> find = new GenericMaximum<float>(floatArray);
            float actual = find.MaxValue();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Passing_string_Array_Should_Return_Maximum_Value()
        {
            string[] strArray = { "10", "20", "30" };
            string expected = "30";
            GenericMaximum<string> find = new GenericMaximum<string>(strArray);
            string actual = find.MaxValue();
            Assert.AreEqual(expected, actual);
        }
    }
}