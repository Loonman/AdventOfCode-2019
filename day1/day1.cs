using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode_2019
{
    class Day1
    {
        public void Run(string inputFile)
        {
            var planets = System.IO.File.ReadLines(inputFile).Select(s => int.Parse(s));
            var fuel = getTotalFuel(planets);
            Console.WriteLine($"Total Fuel: {fuel}");
        }
        public int getTotalFuel(IEnumerable<int> masses)
        {
            var totalFuel = 0;
            foreach(var mass in masses)
            {
                totalFuel += getFuel(mass);
            }
            return totalFuel;
        }

        private int getFuel(int mass)
        {
            var fuel = Convert.ToInt32(Math.Floor(mass / 3.0d)) - 2;
            if (fuel <= 0)
            {
                return 0;
            }
            return fuel + getFuel(fuel);
        }
    }
}
