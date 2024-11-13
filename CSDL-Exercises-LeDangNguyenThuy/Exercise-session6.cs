using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSDL_Exercises_LeDangNguyenThuy
{
    internal class Exercise_session6
    {
        public static void Main()
        {
            Console.Write("Enter the number of items: ");
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];

            Console.WriteLine("Enter the values for the array: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write("Enter a value: ");
                bool res = int.TryParse(Console.ReadLine(), out array[i]);
                if (!res)
                {
                    Console.WriteLine("please enter a number!");
                    i--;
                }
            }
            Console.WriteLine("Original array:");
            PrintArray(array);
            IncreaseArrayItems(array, 2);
            Console.WriteLine("Modified array (each item increased by 2):");
            PrintArray(array);
            
            static void PrintArray(int[] array)
            {
                foreach (int item in array)
                {
                    Console.Write($"{item}, ");
                   
                }
                Console.WriteLine();
            }

            static void IncreaseArrayItems(int[] array, int amount)
            {
            for (int i = 0; i < array.Length; i++)
                {
                        array[i] += amount;
                }
            }
        }

    }
}
