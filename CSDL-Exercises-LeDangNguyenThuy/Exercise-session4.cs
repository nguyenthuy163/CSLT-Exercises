using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDL_Exercises_LeDangNguyenThuy
{
    internal class Exercise_session4
    {
        public static void Main4()
        {
            //game();
            //Ex1_Question1()
            //Ex1_Question2();
            //Ex1_Question3();
            //Ex2_Question1();
            //Ex2_Question2();
            //Ex2_Question3();
            //Ex2_Question4();
            //Ex2_Question5(); 
            Ex2_Question6();
            Console.ReadKey();

        }
        public static void game()
        {
            do
            {

                //1. may nghi ngau nhien 1 so
                Random rnd = new Random();
                int comp_num = rnd.Next(0, 10) + 1;
                //2. hoi nguoi dung doan so may
                //doan den khi nao dung thi thoi
                int count = 0;
                bool isContinue = true;
                do
                {
                    count++;
                    Console.Write("Ban doan so may? <1..10> ");
                    int user_num = int.Parse(Console.ReadLine());
                    //3.kiem tra ket qua
                    if (user_num == comp_num)
                    {
                        Console.WriteLine($"Ban doan trung sau {count} lan");
                        isContinue = false;

                    }
                    else
                    {
                        if (user_num > comp_num)
                            Console.WriteLine("So ban doan lon hon so may nghi");
                        else
                            Console.WriteLine("Sp ban doan nho hon so may nghi");

                    }

                } while (isContinue);
                Console.WriteLine("=================");
                Console.WriteLine("Choi nua khong? <C/K: ");
                string tl = Console.ReadLine();
                if (tl.ToUpper().Equals("K"))
                {
                    Console.WriteLine("Thang ma khong cho go. Lan sau khong choi nua!");
                    return;
                }
            } while (true);
        }
        /// <summary>
        /// Write a C# Sharp program to check whether a given number is even or odd.
        /// </summary>
        public static void Ex1_Question1()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            
                if (num % 2 == 0)
                {
                    Console.WriteLine($"{num} is even");
                }
                else
                {
                    Console.WriteLine($"{num} is odd");
                }
            
            
            
        }
        /// <summary>
        /// Write a C# Sharp program to find the largest of three numbers
        /// </summary>
        public static void Question2()
        {
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the third number: ");
            double num3 = Convert.ToDouble(Console.ReadLine());
            double largest = num1;
            if (num2 > num1)
            {
                largest = num2;
            }
            if (num3 > num2)
            {
                largest = num3;
            }
            Console.WriteLine($"The largest number is {largest}");
        }
        /// <summary>
        /// Write a C# Sharp program to accept a coordinate point in an XY
        /// coordinate system and determine in which quadrant the coordinate point lies.
        /// </summary>
        public static void Ex1_Question3()
        {
            Console.Write("Enter the value for X coordinate: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the value for Y coordinate: ");
            double y = Convert.ToDouble(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                Console.WriteLine("The coordinate point lies in the First quadrant. ");
            }
            else if (x<0 && y >0)
            {
                Console.WriteLine("The coordinate point lies in the Second quadrant. ");
            }
            else if (x<0 && y<0)
            {
                Console.WriteLine("The coordinate point lies in the Third quadrant. ");
            }
            else if (x>0 && y<0)
            {
                Console.WriteLine("The coordinate point lies in the Fourth quadrant. ");
            }
            else if ( x==0 && y==0)
            {
                Console.WriteLine("The coordinate point lies in the coordinate origin. ");
            }
        }
        /// <summary>
        /// Write a program to check whether a triangle is Equilateral, Isosceles or Scalene.
        /// </summary>
        public static void Ex2_Question1()
        {
            Console.Write("Enter the first side of triangle: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter the second side of triangle: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter the third side of triangle: ");
            int c = int.Parse(Console.ReadLine());
            if (a + b < c)
            {
                Console.WriteLine("Not a triangle");
            }
            else
            {
                if (a == b && b == c)
                {
                    Console.WriteLine("This is an equilateral triangle");
                }
                else if (a == b || a == c || b == c)
                {
                    Console.WriteLine("This is an isosceles triangle");
                }
                else
                {
                    Console.WriteLine("This is a scalene triangle");
                }
            }
        }
        /// <summary>
        /// Write a program to read 10 numbers and find their average and sum.
        /// </summary>
        public static void Ex2_Question2()
        {
            double sum = 0;
            int count = 10;
            Console.WriteLine("Enter 10 numbers: ");
            for (int i = 1; i <= count; i++)
            {
                Console.Write($"Number {i}: ");
                double number = double.Parse(Console.ReadLine());  
                sum += number;
            }
            double average = sum / count;
            Console.WriteLine($"Sum of the numbers: {sum}");
            Console.WriteLine($"Average of the numbers: {average}");

        }
        /// <summary>
        /// Write a program to display the multiplication table of a given integer.
        /// </summary>
        public static void Ex2_Question3()
        {
            Console.WriteLine("Enter an integer to display the multiplication table: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++) 
                {
                int result = number * i;
                Console.WriteLine($"{ number} * {i} = {result}" );
                }
            Console.WriteLine();
        }
        /// <summary>
        /// Write a program to display a pattern like triangles with a number.
        /// </summary>
        public static void Ex2_Question4()
        {
            int rows = 4; 
            for (int i = 1; i <= rows ; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j}");
                }
                Console.WriteLine();
            } 

        }
        /// <summary>
        /// Write a program to display the n terms of harmonic series and their sum
        /// </summary>
        public static void Ex2_Question5()
        {
            Console.Write("Enter the number of terms (n): ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0.0;
            Console.WriteLine("Harmonic series up to " + n + " terms:");
            for (int i = 1; i <= n; i++)
            {
                Console.Write("1/" + i);
                if (i<n)
                {
                    Console.Write(" + ");
                }
                sum += 1.0 / i;
            }
            Console.WriteLine("\nSum of the series up to " + n + " terms: " + sum);
        }
        public static void Ex2_Question6()
        {
            int n, i, sum;
            Console.Write("Enter start number: ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Enter end number: ");
            int max = int.Parse(Console.ReadLine());
            Console.Write("Perfects number are: ");
            for (n = min; n<=max; n++)
            {
                i = 1;
                sum = 0;
                while  (i < n)
                {
                    if (n % i == 0)
                        sum += i;
                    i++;
       
                }
                if (sum == n)
                    Console.Write($" {n}");
            }

        }
        /// <summary>k
        /// 
        /// </summary>
        public static void Ex2_Question7()
        {
            Console.Write("Enter a number: ");
            int num = int .Parse(Console.ReadLine());
            bool isPrime = true;
            if (num <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(num); i++) 
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                   
            }
            if (isPrime)
            {
                Console.WriteLine($"{num} is a prime");
            }
            else
            {
                Console.WriteLine($"{num} is not a prime");
            }
        }


    }
}
