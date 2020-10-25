using System;
namespace GetMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            MaximumNumber maximum = new MaximumNumber();
            double output1 = maximum.MaximumFloatNumber(11.1,22.2,33.3);
            Console.WriteLine(output1);
        }
    }
}
