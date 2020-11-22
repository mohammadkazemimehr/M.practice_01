using System;

namespace Sorting_numbers
{
    class program
    {
        static void Main()
        {
            Console.WriteLine(" pleas enter first number ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("pleas enter second number");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("pleas enter third number");
            int C = Convert.ToInt32(Console.ReadLine());

            if (A > B)
            {
                if (B > C)
                {
                    Console.Write(A + ">");
                    Console.Write(B + ",>");
                    Console.Write(C);
                }
                else if (A > C)
                {
                    Console.Write(A + ">");
                    Console.Write(C + ">");
                    Console.Write(B);
                }
                else
                {
                    Console.Write(C + ">");
                    Console.Write(A + ">");
                    Console.Write(B);
                }
            }
            else if (A > C)
            {
                Console.Write(B + ">");
                Console.Write(A + ">");
                Console.Write(C);
            }
            else if (B > C)
            {
                Console.Write(B + ">");
                Console.Write(C + ">");
                Console.Write(A);
            }
            else
            {
                Console.Write(C + ">");
                Console.Write(B + ">");
                Console.Write(A);
            }
        }
    }
}