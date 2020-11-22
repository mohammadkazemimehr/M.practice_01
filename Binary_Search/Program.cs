using System;
namespace Binary_Search
{
    class binary
    {
        public int search(int[] Ar, int first, int last, int value)
        {
            int middle = (first + last) / 2;
            if (Ar[middle] == value)
            {
                return middle;
            }
            else if (first >= last)
            {
                return -1;
            }
            else if (value < Ar[middle])
            {
                return search(Ar, first, middle, value);
            }
            else
            {
                return search(Ar, middle, last, value);
            }
        }
    }
    class program
    {
        static void Main()
        {
            int[] iar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            binary b = new binary();
            Console.WriteLine("index of no.is {0}", b.search(iar, 0, iar.Length - 1, number));
        }

    }
}