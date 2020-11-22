using System;
namespace Array_comparison
{
    class program
    {
        static void Main()
        {
            int[] A = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            int[] B = { 3, 2, 1, 6, 5, 4, 8, 7, 9, 10, 11, 12, 13, 14 };
            int[] C = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == B[i])
                {

                    C[i] = 0;
                }
                else if (A[i] > B[i])
                {
                    C[i] = 1;
                }
                else
                {
                    C[i] = -1;
                }

            }
            foreach (int K in C)
            {
                Console.WriteLine(K);
            }


        }

    }
}