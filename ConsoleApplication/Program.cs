using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var today = DateTime.Now;
            var christmas = new DateTime(today.Year, 12, 25);
            var daysUntilChristmas = Math.Round(christmas.Subtract(today).TotalDays);

            // 2. Store two variables
            string name = "Nate Petersen";
            string location = "Ogden, UT USA";

            // 3. Output two WriteLine statements using string interpolation
            Console.WriteLine($"My name is {name}");
            Console.WriteLine($"I am from {location}");

            // 4. Output the current date but not the current time
            Console.WriteLine($"Today's Date: {today.ToString("MM/dd/yyyy")}");

            // 5. Output the number of days until Christmas this year
            Console.WriteLine($"Number of days until Christmas: {daysUntilChristmas}");

            // 6. Add the program example from section 2.1 in the C# Programming Yellow Book by Rob Miles
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            // 7. Provide appropriate text labels when requesting dimensional input
            Console.Write("Please enter the window width: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("Please enter the window height: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square meters");

        }
    }
}