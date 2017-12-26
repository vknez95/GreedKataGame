using System;
using System.Collections.Generic;
using System.Linq;
using GreedKataGame.Presentation.Factories;
using GreedKataGame.Presentation.Implementation.CommandResults;
using GreedKataGame.Presentation.Implementation.GameOptions;
using GreedKataGame.Presentation.Interfaces;
using GreedKataGame.Presentation.Validators;

namespace GreedKataGame.Presentation.Implementation.Commands
{
    internal class ContinueToPlayCommand : ICommand
    {
        private readonly IValidator validator;
        private readonly IEnumerable<IGameOption> gameOptions;
        private readonly IDiceOption diceOption;
        private readonly GameOptionsFactory optionsFactory = new GameOptionsFactory();

        public ContinueToPlayCommand(IDiceOption diceOption)
        {
            this.gameOptions = new List<IGameOption>()
            {
                new ContinueOption('y', "Yes"),
                new ContinueOption('n', "No")
            };

            validator = new Validator(gameOptions);

            this.diceOption = diceOption;
        }

        public ICommandResult Execute()
        {
            Console.Write("Continue to play (y/n)? ");
            
            while (true)
            {
                string inputKey = Console.ReadLine().ToLower();

                if (validator.IsValid(inputKey))
                {
                    if (inputKey.First() == 'y')
                    {
                        return new ValidGameOptionChosen(diceOption);
                    }
                    else
                    {
                        return new ChooseDiceOption(optionsFactory.CreateOptions());
                    }
                }
                else
                {
                    Console.Write("\nPlease type either y/n... ");
                }
            }
        }
    }
}
