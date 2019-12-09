using System;
using System.Linq;

namespace AdventOfCode.Puzzles
{
    public static class Day2Puzzle
    {
        public static void Start()
        {
            var path = "../../../../../data/day02.txt";
            var data = path.ReadDataAsString();
            var split = data[0].SplitAt(",")
                .Select(x => int.Parse(x))
                .ToArray();
            var intcode = new IntCode(split);
            intcode.Start();
            Console.WriteLine(intcode.Data[0]); // puzzle 2 part one: 5534943
        }
    }
}
