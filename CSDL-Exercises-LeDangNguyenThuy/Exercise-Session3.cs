using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeDangNguyenThuy31231026554
{
    internal class Exercise_session3
    {
        public static void Main3()
        {
            //Question02();
            //Question03();
            Question05();

            Console.ReadKey();
        }
        public static void Question02()
        {
            Console.Write("Enter an integer for y from -5 to 5: ");
            string input = Console.ReadLine();
            int y;
            if (int.TryParse(input, out y))
            {
                if (y >= -5 && y <= 5)
                {
                    int x = y * y + 2 * y + 1;
                    Console.WriteLine($"y= {y}, x= {x}");
                }
                else
                {
                    Console.WriteLine("Please enter a value from -5 to 5");

                }

            }
            else
            {
                Console.WriteLine("Please enter an integer");
            }

        }
        public static void Question03()
        {
            Console.Write("Enter the distance (in kilometers): ");
            double distance = double.Parse(Console.ReadLine());
            Console.Write("Enter the time - hours: ");
            int hours = int.Parse(Console.ReadLine());
            Console.Write("Enter the time - minutes: ");
            int minutes = int.Parse(Console.ReadLine());
            Console.Write("Enter the time - seconds: ");
            int seconds = int.Parse(Console.ReadLine());
            double totaltimeinhours = hours + (minutes / 60.0) + (seconds / 360.0);
            double speedKmH = distance / totaltimeinhours;
            double distanceinmiles = distance * 0.621371;
            double speedMilesH = distanceinmiles / totaltimeinhours;
            Console.WriteLine($"speed = {speedKmH} km/h");
            Console.WriteLine($"speed = {speedMilesH} miles/h");
        }
        public static void Question05()
        {
            Console.Write("Enter a character: ");
            char inputChar = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if ("aeiouAEIOU".Contains(inputChar))
            {
                Console.WriteLine($"{inputChar} is a vowel.");
            }
            else if (char.IsDigit(inputChar))
            {
                Console.WriteLine($"{inputChar} is a digit.");
            }
            else
            {
                Console.WriteLine($"{inputChar} is a symbol or consonant.");
            }
        }

    }
}


