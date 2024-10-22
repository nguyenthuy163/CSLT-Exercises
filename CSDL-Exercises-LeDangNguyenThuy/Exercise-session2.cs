using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeDangNguyenThuy31231026554
{
    internal class Exercise_session2
    {
        public static void Main2()
        {
            //Question01();
            //Question02();
            //Question03();
            Console.ReadKey();
        }

        public static void Question01()
        {
            Console.Write("Enter degrees Celsius: ");
            double celsius = double.Parse(Console.ReadLine());
            double kelvin = celsius + 273;
            double fahrenheit = celsius * 18 / 10 + 32;
            Console.WriteLine($"{celsius} celsius = {kelvin} kelvin");
            Console.WriteLine($"{celsius} celsius = {fahrenheit} fahrenheit");

        }
        public static void Question02()
        {
            Console.Write("Enter radius: ");
            double radius = double.Parse(Console.ReadLine());
            double surface = 4 * Math.PI * Math.Pow(radius, 2); ;
            double volume = 4 / 3 * Math.PI * Math.Pow(radius, 3);
            Console.WriteLine($"surface= {surface}");
            Console.WriteLine($"volume = {volume}");
        }
        public static void Question03()
        {
            Console.WriteLine("enter number 1:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number 2:");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int sum = number1 + number2;
            int subtract = number1 - number2;
            int multiplying = number1 * number2;
            int divide = number1 / number2;
            int mod = number1 % number2;
            Console.WriteLine($"{number1} + {number2} = {sum}");
            Console.WriteLine($"{number1} - {number2} = {subtract}");
            Console.WriteLine($"{number1} * {number2} = {multiplying}");
            Console.WriteLine($"{number1} / {number2} = {divide}");
            Console.WriteLine($"{number1} % {number2} = {mod}");

        }

    }
}



