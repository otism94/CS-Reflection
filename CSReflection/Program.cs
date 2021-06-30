using System;

namespace CSReflection
{
    class Program
    {
        static void Main()
        {
            string make = "Ford";
            string model = "Fiesta";
            string registration = "WP47UQR";
            int year = 2020;
            double value = 2152.99;

            Car FordFiesta = new(make, model, registration, year, value);
            Console.WriteLine(FordFiesta.ToString());
            Console.ReadLine();
        }
    }
}
