using System;
using System.Collections.Generic;
using GreedKataGame.Presentation.Factories;
using GreedKataGame.Presentation.Implementation;
using GreedKataGame.Presentation.Implementation.Commands;
using GreedKataGame.Presentation.Implementation.GameOptions;
using GreedKataGame.Presentation.Interfaces;

namespace GreedKataGame
{
    class Program
    {
        static IEnumerable<IGameOption> CreateGameOptions()
        {
            var optionsFactory = new GameOptionsFactory();
            return optionsFactory.CreateOptions();
        }

        static void Main(string[] args)
        {
            var gameOptions = CreateGameOptions();
            UserInterface ui = new UserInterface(gameOptions);

            while (ui.HasCommandToExecute())
            {
                ui.ExecuteCurrentCommand();
            }
        }
    }
}
