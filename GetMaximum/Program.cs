using System;
namespace GetMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 112, 344, 432, 555, 678 };
            MaximumNumber<int> generic = new MaximumNumber<int>(intArray);
            generic.PrintMaxValue();
            double[] doubleArray = { 11.2, 34.4, 4.32, 55.5, 6.78 };
            MaximumNumber<double> genericDouble = new MaximumNumber<double>(doubleArray);
            genericDouble.PrintMaxValue();
            string[] stringArray = { "111", "222", "333", "55", "999" };
            MaximumNumber<string> genericString = new MaximumNumber<string>(stringArray);
            genericString.MaxMethod();
        }
    }
}
