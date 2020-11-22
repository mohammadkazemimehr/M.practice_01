using System;
namespace random_dice
{
    class program
    {
        static void Main()
        {
            int Z = 0;
            int X = 0;
            int C = 0;
            int V = 0;
            int B = 0;
            int N = 0;

            for (int i = 0; i < 200; i++)
            {
                Random A = new Random();
                int Dice = A.Next(1, 7);
                switch (Dice)
                {
                    case 1:
                        Z++;
                        break;
                    case 2:
                        X++;
                        break;
                    case 3:
                        C++;
                        break;
                    case 4:
                        V++;
                        break;
                    case 5:
                        B++;
                        break;
                    case 6:
                        N++;
                        break;
                }

            }
            Console.WriteLine("number of 1 : " + Z);
            Console.WriteLine("number of 2 : " + X);
            Console.WriteLine("number of 3 : " + C);
            Console.WriteLine("number of 4 : " + V);
            Console.WriteLine("number of 5 : " + B);
            Console.WriteLine("number of 6 : " + N);

        }
    }
}