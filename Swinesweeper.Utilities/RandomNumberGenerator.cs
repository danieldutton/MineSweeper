﻿using Swinesweeper.Utilities.Interfaces;
using System;

namespace Swinesweeper.Utilities
{
    public class RandomNumberGenerator : IRandomNumberGenerator
    {
        private readonly Random _random;

        public RandomNumberGenerator()
        {
            _random = new Random();
        }

        public int GetRandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }
    }
}