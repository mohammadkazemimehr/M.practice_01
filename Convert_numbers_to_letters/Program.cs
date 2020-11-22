using System;
namespace Convert_numbers_to_letters
{
    class program
    {
        static void Main()
        {
            Console.WriteLine("pleas Enter the number : ");
            int A = Convert.ToInt32(Console.ReadLine());

            switch (A)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                default:
                    Console.WriteLine("invalid Number");
                    break;
            }
        }
    }
}