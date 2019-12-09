using System;
using System.IO;

namespace AdventOfCode
{
    public static class Extensions
    {

        public static string[] ReadDataAsString(this string path) => File.ReadAllLines(path);

        public static string[] SplitAt(this string data, string splitter) => data.Split(splitter, StringSplitOptions.RemoveEmptyEntries);
    }
}
