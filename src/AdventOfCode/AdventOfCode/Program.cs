using AdventOfCode.Modules;
using System;
using System.IO;
using System.Linq;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = File.ReadAllLines("./Data/Day1.txt").Select(x => int.Parse(x));
            var fuel = new FuelCalculator();

            var result = data.Sum(fuel.Calculate);
            var sumFuel = data.Sum(fuel.SumOfMassRequirements);

            Console.WriteLine(result);
            Console.WriteLine(sumFuel);
        }
    }
}
