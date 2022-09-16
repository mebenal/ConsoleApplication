using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2.
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Please enter your location: ");
            string location = Console.ReadLine();

            // 3.
            Console.WriteLine($"\nMy name is {name},");
            Console.WriteLine($"I am from {location}");

            // 4.
            DateTime dateCurrent = DateTime.Now;

            Console.WriteLine($"\nThe current date is {dateCurrent.ToShortDateString()}");

            // 5.
            int yearChristmas = dateCurrent < new DateTime(dateCurrent.Year, 12, 25) ? dateCurrent.Year : dateCurrent.Year + 1;
            DateTime dateChristmas = new DateTime(yearChristmas, 12, 25);

            Console.WriteLine($"and there are {(dateChristmas - dateCurrent).Days} days until next christmas.");

            // 6.
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.Write("\nPlease enter the width of the window in meters: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("Please enter the height of the window in meters: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;

            glassArea = width * height;

            Console.WriteLine($"\nThe length of the wood is {woodLength} feet");
            Console.WriteLine($"The area of the glass is {glassArea} square metres");

            // 7.
            Console.Write("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
