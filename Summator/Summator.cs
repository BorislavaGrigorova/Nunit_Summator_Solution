using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summator
{
    public static class Summator
    {
        public static long Sum(int[] arr)
        {
                long sum = 0;

                for (long i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }

                return sum;            
        }

        public static int Average(int[] arr)
        {
            int sum = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum / arr.Length;
        }
        
         public static string Text(string FirstName, string LastName )
        {
            string firstName = FirstName;
            string lastName = LastName;

            return firstName + lastName;
        }
        
                public static string Date(int v)
        {
            string dateTime = "7/11/2021";

            return dateTime;
        }
    }
}
