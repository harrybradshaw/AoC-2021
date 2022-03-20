using System;
using System.Collections.Generic;
using System.Linq;

namespace Day2
{
    public class Instruction
    {
        public string Command;
        public int Value;

        public Instruction(string input)
        {
            var split = input.Split(" ");
            Command = split[0];
            Value = int.Parse(split[1]);
        }
    }
    
    public class Pilot
    {
        private readonly List<Instruction> _instructions;
        private int _depth;
        private int _horizontalPosition;
        private int _aim;
        public int MultipliedValue => _depth * _horizontalPosition;

        public Pilot()
        {
            _instructions = System.IO.File.ReadAllLines(@"C:\Work\Training\AoC-2021-input\day2.txt")
                .Select(s => new Instruction(s))
                .ToList();
        }

        public void ProcessInstructions()
        {
            _instructions.ForEach(ProcessInstruction);
        }

        private void ProcessInstruction(Instruction instruction)
        {
            switch (instruction.Command)
            {
                case "forward":
                    _horizontalPosition += instruction.Value;
                    _depth += instruction.Value * _aim;
                    break;
                case "down":
                    _aim += instruction.Value;
                    break;
                case "up":
                    _aim -= instruction.Value;
                    break;
            }
        }
    }
}