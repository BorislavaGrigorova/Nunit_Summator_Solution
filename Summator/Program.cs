using System;

namespace Summator
{
    public class Program
    {
        static void Main(string[] args)
        {
            long result = Summator.Sum(new int[] { 1, 2, 3, 4, 5, 6 });

            if(result == 21)
            {
                Console.WriteLine("TEST PASS");
            }
            else
            {
                Console.WriteLine("TEST FAIL");
            }

            int average = Summator.Average(new int[] { 5, 10, 15 });

            if (average == 10)
            {
                Console.WriteLine("TEST PASS");
            }
            else
            {
                Console.WriteLine("TEST FAIL");
            }

        }
    }
}
