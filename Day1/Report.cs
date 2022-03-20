using System;
using System.Collections.Generic;
using System.Linq;

namespace Day1
{
    public class Report
    {
        private List<int> _numbers;

        public Report()
        {
            _numbers = System.IO.File.ReadAllLines(@"C:\Work\Training\AoC-2021-input\day1.txt").Select(int.Parse).ToList();
        }

        public int CountIncreased()
        {
            var count = 0;
            for (var i = 3; i < _numbers.Count; i++)
            {
                var first = _numbers[i] + _numbers[i - 1] + _numbers[i - 2];
                var second = _numbers[i-1] + _numbers[i - 2] + _numbers[i - 3];
                if (first > second)
                {
                    count++;
                }
            }

            return count;
        }
    }
}