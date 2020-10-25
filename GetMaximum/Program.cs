using System;
namespace GetMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            MaximumNumber maximum = new MaximumNumber();
            int output = maximum.MaximumIntegerNumber(11, 22, 33);
            Console.WriteLine(output);
        }
    }
}
