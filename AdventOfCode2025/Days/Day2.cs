using AdventOfCode2025.Utility;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Text;

namespace AdventOfCode2025.Days
{
    internal class Day2 : IDay
    {

        private IFileReader fileReader;

        public Day2(IFileReader fileReader)
        {
            this.fileReader = fileReader;
        }

        public void run()
        {
            IList<String> values = fileReader.ReadFile(2).First().Split(",");
            long sumPart1 = 0;
            long sumPart2 = 0;

            foreach (var value in values)
            {
                var splittedValue = value.Split("-");
                long bottomValue = long.Parse(splittedValue[0]);
                long topValue = long.Parse(splittedValue[1]);

                sumPart1 += part1(topValue, bottomValue);
                sumPart2 += part2(topValue, bottomValue);
            }

            Console.WriteLine("part 1 result: " + sumPart1);
            Console.WriteLine("part 2 result: " + sumPart2);
        }

        private long part1(long topValue, long bottomValue)
        {
            long sum = 0;

            for (long i = bottomValue; i <= topValue; i++)
            {
                if (IsInvalidId(i))
                {
                    sum += i;
                }
            }

            return sum;
        }

        private bool IsInvalidId(long number)
        {
            string str = number.ToString();

            if (str.Length % 2 != 0)
            {
                return false;
            }

            int mid = str.Length / 2;
            string firstHalf = str[..mid];
            string secondHalf = str[mid..];

            return firstHalf == secondHalf;
        }

        private long part2(long topValue, long bottomValue)
        {
            long sum = 0;

            for (long i = bottomValue; i <= topValue; i++)
            {
                if (IsInvalidIdPart2(i))
                {
                    sum += i;
                }
            }

            return sum;
        }

        private bool IsInvalidIdPart2(long number)
        {
            string str = number.ToString();

            for (int patternLength = 1; patternLength <= str.Length / 2; patternLength++)
            {
                if (str.Length % patternLength != 0)
                {
                    continue;
                }

                string pattern = str[..patternLength];
                bool isRepeating = true;

                for (int i = patternLength; i < str.Length; i += patternLength)
                {
                    if (str[i..(i + patternLength)] != pattern)
                    {
                        isRepeating = false;
                        break;
                    }
                }

                if (isRepeating)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
