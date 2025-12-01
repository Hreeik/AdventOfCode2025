using AdventOfCode2025.Days;
using System;

namespace AdventOfCode2025
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter day number:");
                var input = Console.ReadLine();

                Day? day = null;

                switch (input)
                {
                    case "1":
                        day = new Day1();
                        break;
                    case "2":
                        day = new Day2();
                        break;
                    case "3":
                        day = new Day3();
                        break;
                    case "4":
                        day = new Day4();
                        break;
                    case "5":
                        day = new Day5();
                        break;
                    case "6":
                        day = new Day6();
                        break;
                    case "7":
                        day = new Day7();
                        break;
                    case "8":
                        day = new Day8();
                        break;
                    case "9":
                        day = new Day9();
                        break;
                    case "10":
                        day = new Day10();
                        break;
                    case "11":
                        day = new Day11();
                        break;
                    case "12":
                        day = new Day12();
                        break;
                    default:
                        Console.WriteLine("Day not implemented yet.");
                        break;
                }

                if (day != null)
                {
                    day.run();
                }
                else
                {
                    Console.WriteLine("Day not select.");
                }
            } 
            catch (Exception e)
            {
                Console.WriteLine("Process failed " + e.Message);
            }

        }
    } 
}
