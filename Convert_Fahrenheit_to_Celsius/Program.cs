using System;

namespace Convert_Fahrenheit_to_Celsius
{
    class prigram
    {
        static void Main()
        {
            Console.WriteLine("Enter Farenheit : ");
            int Farenheit = Convert.ToInt32(Console.ReadLine());

            double x = Farenheit - 32;
            double celsius = x * 5 / 9;
            Console.Write("celsius : " + celsius);

        }
    }
}