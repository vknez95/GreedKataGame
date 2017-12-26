using System;
using System.Collections.Generic;
using System.Linq;

namespace GreedKataGame.Application.Models
{
    public class Dice
    {
        private readonly int diceNumber;
        private int[] rolledDice;

        public Dice(int diceNumber)
        {
            this.diceNumber = diceNumber;
        }

        public int[] RollDice()
        {
            Random rnd = new Random();
            var rolledDice = new int[diceNumber];

            for (int i = 0; i < diceNumber; i++)
            {
                rolledDice[i] = rnd.Next(1, 7);
            }

            this.rolledDice = rolledDice;
            return rolledDice;
        }

        public string RolledDiceOutput
        {
            get
            {
                var output = "";

                foreach (var dice in rolledDice)
                {
                    output += $"{dice}, ";
                }

                return output.Substring(0, output.Length - 2);
            }
        }

        public int[] RolledDice => rolledDice;
    }
}
