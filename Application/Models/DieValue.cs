using System;
using System.Collections.Generic;
using System.Linq;
using GreedKataGame.Utility;

namespace GreedKataGame.Application.Models
{
    public class DieValue
    {
        public readonly int Value;

        public DieValue(int value)
        {
            Contract.Requires<ArgumentException>(value >= 1 && value <= 6, "Argument exception.", "value");
            Value = value;
        }

        public override string ToString()
        {
            if (Value == 1)
            {
                return "One";
            }
            else if (Value == 2)
            {
                return "Two";
            }
            else if (Value == 3)
            {
                return "Three";
            }
            else if (Value == 4)
            {
                return "Four";
            }
            else if (Value == 5)
            {
                return "Five";
            }
            else if (Value == 6)
            {
                return "Six";
            }
            else
            {
                throw new ArgumentException("Invalid argument.", "value");
            }
        }
    }
}
