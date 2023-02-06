using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._02._23_dz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task 1
                Console.WriteLine("Enter number: ");
                int number1 = Convert.ToInt32(Console.ReadLine());
                if (number1 % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (number1 % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (number1 % 3 == 0 && number1 % 5 == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                }
            #endregion
            #region task 2
                Console.WriteLine("Enter number: ");
                int number2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter percent: ");
                int percent = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Result: {number2 / 100 * percent}");
            #endregion
            #region task 3
                Console.WriteLine("Enter 4 digits: ");
                int number_1 = Convert.ToInt32(Console.ReadLine());
                int number_2 = Convert.ToInt32(Console.ReadLine());
                int number_3 = Convert.ToInt32(Console.ReadLine());
                int number_4 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Result is {number_1 * 1000 + number_2 * 100 + number_3 * 10 + number_4}");
            #endregion
            #region task 5
                Console.WriteLine("Enter date: ");
                string strDate = Console.ReadLine();
                DateTime date = DateTime.Parse(strDate);
                if (date.Month == 1 || date.Month == 2 || date.Month == 12)
                {
                    Console.Write("Winter ");
                }
                else if (date.Month == 3 || date.Month == 4 || date.Month == 5)
                {
                    Console.Write("Spring ");
                }
                else if (date.Month == 6 || date.Month == 7 || date.Month == 8)
                {
                    Console.Write("Summer ");
                }
                else
                {
                    Console.Write("Autumn ");
                }
                Console.WriteLine(date.DayOfWeek);
            #endregion
            #region task 6
                Console.WriteLine("Celcium or Faringate (write C or F): ");
                string mode = Console.ReadLine();
                Console.WriteLine("Enter temperature");
                int temperature = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("CONVERT celcium or Faringate (write C or F): ");
                string mode2 = Console.ReadLine();
                if (mode == mode2) Console.WriteLine(temperature);
                else if (mode2 == "C") Console.WriteLine((temperature - 32) / 1.8);
                else if (mode2 == "F") Console.WriteLine(temperature * 1.8 + 32);
                else Console.WriteLine("Error");
            #endregion
            #region 7
                Console.WriteLine("Enter borders");
                int bord1 = Convert.ToInt32(Console.ReadLine()), bord2 = Convert.ToInt32(Console.ReadLine());
                if (bord1 > bord2)
                {
                    int temp = bord1;
                    bord1 = bord2;
                    bord2 = temp;
                }
                int gain = bord1 % 2 == 0 ? 2 : 1;
                for (int i = bord1 + gain; i < bord2; i++)
                {
                    Console.Write($"{i}\t");
                }
            #endregion
        }
    }
}

