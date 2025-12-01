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
                int number = int.Parse(line.Substring(1));

                if (TowardHigher.Equals(letter))
                {
                    for (int i = 0; i < number; i++)
                    {
                        currentValue = (currentValue + 1) % 100;
                        if (currentValue == 0)
                        {
                            zeroCount++;
                        }
                    }
                }
                else if (TowardLower.Equals(letter))
                {
                    for (int i = 0; i < number; i++)
                    {
                        currentValue = currentValue - 1;
                        if (currentValue < 0)
                        {
                            currentValue = 99;
                        }
                        if (currentValue == 0)
                        {
                            zeroCount++;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Unknown letter: " + letter);
                }
            }

            Console.WriteLine("Zero count is: " + zeroCount);
        }
    }
}
