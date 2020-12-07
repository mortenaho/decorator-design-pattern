using System;

namespace decorator_design_pattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Beverage bevrage = new Tee();

            Console.WriteLine(bevrage.Description());
            bevrage = new Suger(bevrage);
            Console.WriteLine(bevrage.Description());
            Console.WriteLine("Hello World!");
        }
    }
}
