using System;

namespace practice_01
{
    class Shredding_banknotes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount of money");
            int K = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while (K >= 50)
            {
                K = K - 50;
                i++;

            }
            int j = 0;
            while (K >= 20)
            {
                K = K - 20;
                j++;
            }
            int l = 0;
            while (K >= 10)
            {
                K = K - 10;
                l++;
            }
            int A = 0;
            while (K >= 5)
            {
                K = K - 5;
                A++;
            }
            int S = 0;
            while (K >= 2)
            {
                K = K - 2;
                S++;
            }
            int F = 0;
            while (K >= 1)
            {
                K = K - 1;
                F++;
            }
            Console.WriteLine("Number of 50$ : " + i);
            Console.WriteLine("Number of 20$ : " + j);
            Console.WriteLine("Number of 10$ : " + l);
            Console.WriteLine("Number of 5$ : " + A);
            Console.WriteLine("Number of 2$ : " + S);
            Console.WriteLine("Number of 1$ : " + F);
            Console.WriteLine("END");



        }
    }
}
