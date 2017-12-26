using System;
using System.Collections.Generic;
using System.Linq;
using GreedKataGame.Presentation.Interfaces;

namespace GreedKataGame.Presentation.Validators
{
    public class Validator : IValidator
    {
        private readonly IEnumerable<IGameOption> gameOptions;

        public Validator(IEnumerable<IGameOption> gameOptions)
        {
            this.gameOptions = gameOptions;
        }

        public bool IsValid(string inputKey)
        {
            if (inputKey.Length != 1) {
                return false;
            }

            char input = inputKey.First();
            
            return gameOptions.Where(option => option.Id == input).Any();
        }
    }
}
