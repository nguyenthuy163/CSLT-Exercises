using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class Exercise1
    {
        public static void Main1()

        {
            Question01();
            //Question02();
            //Question03();
            //Question04();
            //Question05();
            //Question06();
            //Question07();
            //Question08();
            //Question09();
            //Question10();
            Console.ReadKey();

        }
        public static void Question01()
        {
            Console.Write("Nhap so a: ");
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so b: ");
            b = Convert.ToInt32(Console.ReadLine());
            int c = a + b;
            Console.WriteLine($"{a} + {b} = {c}");

        }
        public static void Question02()
        {
            Console.Write("Nhap so a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a;
            a = b; b = c;

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");


        }
        public static void Question03()
        {
            float a, b, c;
            Console.Write("Nhap so a: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Nhap so b: ");
            b = float.Parse(Console.ReadLine());
            c = a * b;
            Console.WriteLine("a*b= " + c);
        }
        public static void Question04()
        {
            double feet, meter;
            Console.Write("Nhap so feet: ");
            feet = double.Parse(Console.ReadLine());
            meter = feet / 3.280839895;
            Console.WriteLine($"{feet} feet = {meter} meter");
        }
        public static void Question05()
        {

            Console.Write("Nhap so celsius: ");
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = celsius + 273;
            Console.WriteLine($"{celsius} celsius = {fahrenheit} fahrenheit");
            Console.Write("Nhap so fahrenhiet: ");
            double fahrenheit1 = double.Parse(Console.ReadLine());
            double celsius1 = fahrenheit1 - 273;
            Console.WriteLine($"{fahrenheit1} fahrenheit = {celsius1} celsius");


        }
        public static void Question06()
        {
            int a = sizeof(int);
            Console.WriteLine($"{a}");

        }
        public static void Question07()
        {
            Console.Write("Nhap 1 ky tu: ");
            char c = char.Parse(Console.ReadLine());
            int num = c;
            Console.WriteLine($"{c} in ASCII = {num}");


        }
        public static void Question08()
        {
            Console.Write("Nhap ban kinh: ");
            double r = double.Parse(Console.ReadLine());
            double area = 2 * Math.PI * Math.Pow(r, 2);
            Console.WriteLine($"Dien tich hinh tron = {area}");


        }
        public static void Question09()
        {
            Console.Write("Nhap do dai 1 canh: ");
            double a = double.Parse(Console.ReadLine());
            double area = a * a;
            Console.WriteLine($"Dien tich hinh vuong = {area}");

        }
        public static void Question10()
        {
            Console.Write("Nhap so ngay: ");
            int day = int.Parse(Console.ReadLine());
            int year = day / 365;
            Console.WriteLine($"{year} nam ");
            int wday = day - year * 365;
            Console.WriteLine(wday / 7 + "tuan");
            int ngayle = wday % 7;
            Console.WriteLine($"{ngayle} ngay");

        }


    }
}


