using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp3
{
    public class Algoritms
    {
        public int NumberReverce()
        {
            int number = int.Parse(Console.ReadLine());
            int originalNumbet = number;
            int reverseNumber = 0;
            while (number != 0)
            {
                int remainder = number % 10;
                reverseNumber = reverseNumber * 10 + remainder;
                number /= 10;
            }
            return reverseNumber;
        }
        public void IsPolindrome()
        {
            Console.Write("Son kiriting: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int originalNumber = number;
            int reverseNumber = 0;

            while (number != 0)
            {
                int remainder = number % 10;
                reverseNumber = reverseNumber * 10 + remainder;
                number /= 10;
            }

            if( originalNumber == reverseNumber)
            {
                Console.WriteLine("Polindrom");
            }
            else
            {
                Console.WriteLine("Not Polindrom");
            }
        }
        public void Sharp()
        {
            int n = 5;
            int px = n;
            int py = n;
            for (int i = 1; i <= n; i++)
            {
                for (int j =  1; j <= n * 2; j++)
                {
                    if(j == px || j == py)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                px--;
                py++;
                Console.WriteLine();
            }
        }
    }
}
