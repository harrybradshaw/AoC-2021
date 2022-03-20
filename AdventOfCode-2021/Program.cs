using System;
using Day1;
using Day2;

namespace AdventOfCode_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            var pilot = new Pilot();
            pilot.ProcessInstructions();
            Console.WriteLine(pilot.MultipliedValue);
        }
    }
}