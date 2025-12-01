using AdventOfCode2025.Utility;
using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace AdventOfCode2025.Days
{
    internal class Day1 : Day
    {
        private static int StartingPoint = 50;
        private static char TowardHigher = 'R';
        private static char TowardLower = 'L';

        public void run()
        {
            IList<String> lines = new FileReader().ReadFile("input_day1.txt");
            int currentValue = StartingPoint;
            int zeroCount = 0;

            foreach (var line in lines)
            {
                char letter = line[0];
                int rawNumber = int.Parse(line.Substring(1));
                int number = rawNumber >= 100 ? rawNumber % 100 : rawNumber;

                if (TowardHigher.Equals(letter))
                {
                    int added = currentValue + number;

                    currentValue = added >= 100 ? added % 100 : added;

                }
                else if (TowardLower.Equals(letter))
                {
                    int sub = currentValue - number;

                    currentValue = sub < 0 ? 100 + sub : sub;
                } 
                else
                {
                    Console.WriteLine("Unknown letter: " + letter);
                }

                if (currentValue == 0)
                {
                    zeroCount++;
                }
            }

            Console.WriteLine("Zero count is: " + zeroCount);
        }
    }
}
