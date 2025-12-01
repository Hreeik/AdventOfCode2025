using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2025.Utility
{
    internal interface IFileReader
    {
        IList<String> ReadFile(string fileName);
    }
}
