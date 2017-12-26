using System;
using System.Collections.Generic;
using System.Linq;
using GreedKataGame.Utility;

namespace GreedKataGame.Application.Models
{
    public class RuleSetSize
    {
        public readonly int Value;

        public RuleSetSize(int value)
        {
            Contract.Requires<ArgumentException>(value >= 3 && value <= 6, "Invalid argument.", "value");
            this.Value = value;
        }

        public override string ToString()
        {
            if (Value == 3)
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
