using System;
namespace GetMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            MaximumNumber maximum = new MaximumNumber();
            string output = maximum.MaximumStringNumber("22","33","44");
            Console.WriteLine(output);
        }
    }
}
