using System;

namespace change_location_in_array
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a Number less than 7");
            string[] A = { "A", "B", "C", "D", "E", "F", "A", "B", "C", "D", "E", "F" };
            int K = Convert.ToInt32(Console.ReadLine());
            if (K < 7)
            {
                int x = 6 + K;
                int j = K;

                for (int i = j; i < x; i++)
                {
                    Console.Write(A[i] + " ");
                }

            }
            else
            {
                Console.WriteLine(":|");
            }

        }
    }
}
