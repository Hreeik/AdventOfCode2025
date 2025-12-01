using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2025.Utility
{
    internal class FileReader : IFileReader
    {

        public IList<String> ReadFile(string fileName)
        {
            IList<String> results = new List<String>() { };
            String line = null;

            try
            {
                StreamReader streamReader = new StreamReader("Days\\Inputs\\" + fileName);
                line = streamReader.ReadLine();

                while (line != null)
                {
                    results.Add(line);
                    line = streamReader.ReadLine();
                }

                streamReader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

            Console.WriteLine("Results " + results.Count());

            return results;
        }
    }
}
