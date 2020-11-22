using System;
namespace change_the_string
{
    class program
    {
        static void Main()
        {
            Console.WriteLine("Enter the string : ");
            string A = Console.ReadLine();
            string newA = A;
            newA = A.Replace("-", "ط");
            newA = newA.Replace("+", "-");
            newA = newA.Replace("ط", "+");
            Console.WriteLine(newA);


        }
    }
}