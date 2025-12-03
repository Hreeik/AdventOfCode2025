using AdventOfCode2025.Days;
using AdventOfCode2025.Utility;
using System;
using System.Reflection;

namespace AdventOfCode2025
{
    class Program
    {

        private static string ExitCommand = "exit";

        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter day number (or type '" + ExitCommand + "' to quit):");
                    var input = Console.ReadLine();

                    if (input == null || string.Equals(input.Trim().ToLower(), ExitCommand))
                    {
                        break;
                    }

                    if (!int.TryParse(input, out int dayNumber) || dayNumber < 1 || dayNumber > 12)
                    {
                        Console.WriteLine("Invalid day number. Please enter a number between 1 and 12.");
                        continue;
                    }

                    var dayClassName = $"AdventOfCode2025.Days.Day{dayNumber}";
                    var dayType = Type.GetType(dayClassName);

                    if (dayType == null)
                    {
                        Console.WriteLine($"Day {dayNumber} not implemented yet.");
                        continue;
                    }

                    var fileReader = new FileReader();
                    IDay? day = Activator.CreateInstance(dayType, fileReader) as IDay;

                    if (day != null)
                    {
                        day.run();
                    }
                    else
                    {
                        Console.WriteLine($"Failed to create Day {dayNumber} instance.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Process failed " + e.Message);
                }

                Console.WriteLine();
            }
        }
    }
}
