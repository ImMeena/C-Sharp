using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello");

            /* 1. Write a C# Sharp program to compute the sum of the two given integer values. 
             * If the two values are the same, then return triple their sum   
             */
            //Console.WriteLine("Enter first number");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter second number");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //if ( num1 == num2 )
            //{
            //    Console.WriteLine(( num1 + num2 ) * 3 );
            //}
            //else
            //{
            //    Console.WriteLine( num1 + num2 );
            //}

            /* 2. Write a C# Sharp program to get the absolute difference between n and 51. 
             *  If n is greater than 51 return triple the absolute difference.
             */
            //int num = 51;
            //Console.WriteLine("Enter a number");
            //int n = Convert.ToInt32(Console.ReadLine());
            //if (n > num)
            //{
            //    Console.WriteLine(Math.Abs((num - n) * 3));
            //}
            //else
            //{
            //    Console.WriteLine(num-n);
            //}

            /* 3. Write a C# Sharp program to check two given integers, and 
             * return true if one of them is 30 or if their sum is 30. 
             */
            Console.WriteLine("Enter first integer");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second integer");
            int num2 = Convert.ToInt32(Console.ReadLine());
            bool mybool = true;
            if (num1== 30 || num2 == 30 || (num1+num2) == 30)
            {
                Console.WriteLine(mybool);
            }
            else
            {
                Console.WriteLine(!mybool);
            }
            /* 4. 
             */

            /* 5.
             */

            /* 6. 
             */

            /* 7. 
             */

            /* 8. 
             */

            /* 
             */

            Console.ReadKey();
        }
    }
}
