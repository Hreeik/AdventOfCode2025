using AdventOfCode2025.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2025.Days
{
    internal class Day1 : Day
    {
        public void run()
        {
            IList<String> lines = new FileReader().ReadFile("input_day1.txt");

            foreach (var line in lines)
            {
                Console.WriteLine("first: " + line);
                Console.WriteLine("count " + lines.Count());
                break;
            }
        }
    }
}
