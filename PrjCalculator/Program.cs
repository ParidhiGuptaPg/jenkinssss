using System;

namespace PrjCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            calculator calculator = new calculator();
            Console.WriteLine("Add:{0}", calculator.Add(7, 9));
            Console.WriteLine("Sub:{0}", calculator.Sub(9, 89));
            Console.WriteLine("Hello World!");
        }
    }
}
