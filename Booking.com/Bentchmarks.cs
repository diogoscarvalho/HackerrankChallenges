﻿using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.com
{
    [MemoryDiagnoser]
    public class Bentchmarks
    {
        private readonly List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 1, 3, 6, 1 };

        [Benchmark]
        public void CountDuplicates()
        {
            FirstChallenge.CountDuplicate(numbers);

        }

        [Benchmark]
        public void CountDuplicatesWithDictionary()
        {
            FirstChallenge.CountDuplicate(numbers);
        }
    }
}
