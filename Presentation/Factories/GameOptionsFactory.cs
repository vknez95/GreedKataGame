using System;
using System.Collections.Generic;
using System.Linq;
using GreedKataGame.Presentation.Implementation.GameOptions;
using GreedKataGame.Presentation.Interfaces;

namespace GreedKataGame.Presentation.Factories
{
    public class GameOptionsFactory
    {
        public IEnumerable<IGameOption> CreateOptions()
        {

            return new List<IGameOption>()
            {
                new DiceRollOption('a', "Five dice roll", 5),
                new DiceRollOption('b', "Six dice roll", 6),
                new ExitGameOption()
            };
        }
    }
}
