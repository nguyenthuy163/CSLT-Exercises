using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSDL_Exercises_LeDangNguyenThuy
{
    internal class Exercise_session5
    {
        public static void Main41(string[] args)
        {
            int m = maxOfThreeNumbers(5, 2, 4);
            Console.WriteLine(m);
            Console.ReadKey();
        }

        /// <summary>
        /// Write a C# function to find the maximum of three numbers.
        /// </summary>
        static int maxOfThreeNumbers (int a, int b, int c)
        {
            return Math.Max(Math.Max(a, b), c);

        }
        /// <summary>
        ///Write a C# function to calculate the factorial of a number (a non-negative integer). 
        /// </summary>
       
        static long Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Number must be a non-negative integer.");

            }
            if (number == 0 || number == 1)
            {
                return 1;
            }
            return number * Factorial(number - 1);
        }
        public static void Main42(string[] args)
        {

            Console.WriteLine("Enter a non-negative integer: ");
            int input = int.Parse(Console.ReadLine());
            try
            {
                long result = Factorial(input);
        Console.WriteLine($"The factorial of {input} is {result}.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Write a C# function that takes a number as a parameter and checks whether the number is prime or not.
        /// </summary>
        static bool IsPrime(int number)
        {
            if ( number < 1)
            {
                return false;
            }
            for (int i = 2; i * i <= number; i++)
            {
                if(number % i ==0)

                {
                    return false;
                }
            }
            return true;
        }
        public static void Main43(string[] args)
        {
            Console.Write("Enter a number to check if it is prime: ");
            int input = int.Parse(Console.ReadLine());
            if (IsPrime(input))
            {
                Console.WriteLine($"{input} is a prime number.");
            }
            else
            {
                Console.WriteLine($"{input} is not a prime number.");
            }
        }
        /// <summary>
        /// Write a C# function to print
        /// 1. all prime numbers that less than a number(enter prompt keyboard).
        /// 2. the first N prime numbers
        /// </summary>
        /// <param name="N"></param>
        static void printPrimeNumberUnderN(int N)
        {
            for (int i = 0; i < N; i++)
            {
                if (IsPrime(i))
                    Console.WriteLine(i);
            }
        }
        static void printFirstNPrime(int N)
        {
            int so = 2;
            int dem = 0;
            while (dem < N)
            {
                if (IsPrime(so))
                {
                    Console.WriteLine(so);
                    dem++;
                }
                so++;
            }
        }
        public static void Main44(string[] args)
        {
            Console.Write("Enter the number: ");
            int N = int.Parse(Console.ReadLine());
            printPrimeNumberUnderN(N);
            printFirstNPrime(N);
            Console.ReadKey();
        }
        /// <summary>
        /// check whether a number is "Perfect" or not. Then print all perfect number that less than 1000.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static bool IsPerfect(int number)
        {
            int sum = 0;
            for (int i = 1; i <= number/2; i++)
            {
                if (number % i == 0)
                    sum += i;
            }
            return sum == number;
        }
        static void PrintPerfectNumber(int N)
        {
            for ( int i=1; i < N; i++)
            {
                if (IsPerfect(i))
                    Console.WriteLine(i);
            }
        }
        public static void Main45(string[] args)
        {
            
            PrintPerfectNumber(1000);
            Console.ReadKey();
        }
        /// <summary>
        /// check whether a string is a pangram or not.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        static bool IsPangram(string input)
        {
            // Convert the input string to lowercase to handle case insensitivity
            input = input.ToLower();
            for (char c = 'a'; c <= 'z'; c++)
            {
                if (!input.Contains(c))
                    return false;
            }
            // If all letters are found, it's a pangram
            return true;
        }
        public static void Main46(string[] args)
        {
            Console.Write("Enter a sentence: ");
            string input = Console.ReadLine();

            if (IsPangram(input))
                Console.WriteLine("The input is a pangram.");
            else
                Console.WriteLine("The input is not a pangram.");
        }
    }
}
