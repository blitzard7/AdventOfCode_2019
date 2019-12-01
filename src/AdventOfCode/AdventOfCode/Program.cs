using AdventOfCode.Modules;
using System.IO;
using System.Linq;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = ReadPuzzleData("./Data/Day1.txt").Select(x => int.Parse(x));
            var fuel = new Day1Puzzle();
            var result = data.Sum(fuel.CalculateFuel); // puzzle1: 3233481
            var sumFuel = data.Sum(fuel.SumOfMassRequirements); // puzzle2: 4847351
        }

        private static string[] ReadPuzzleData(string path) => File.ReadAllLines(path);
    }
}
