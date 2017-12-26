using System;
using System.Collections.Generic;
using System.Linq;
using GreedKataGame.Presentation.Implementation.CommandResults;
using GreedKataGame.Presentation.Interfaces;
using GreedKataGame.Presentation.Validators;

namespace GreedKataGame.Presentation.Implementation.Commands
{
    internal class ChooseDiceCommand : ICommand
    {
        private readonly IValidator validator;
        private readonly IEnumerable<IGameOption> gameOptions;

        public ChooseDiceCommand(IEnumerable<IGameOption> gameOptions)
        {
            this.gameOptions = gameOptions;
            validator = new Validator(gameOptions);
        }

        public ICommandResult Execute()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Greet Kata dice game!\n");
            Console.WriteLine("How many dice would you like to play with?\n");

            foreach (var gameOption in gameOptions)
            {
                Console.WriteLine("{0}) {1}\n", gameOption.Id, gameOption.Description);
            }

            Console.Write("Please choose one of the options to contiue > ");
            string inputKey = Console.ReadLine().ToLower();

            if (validator.IsValid(inputKey))
            {
                var gameOption = gameOptions.First(option => option.Id == inputKey.First());
                return new ValidGameOptionChosen(gameOption);
            }

            return new InvalidGameOptionChosen(gameOptions);
        }
    }
}
