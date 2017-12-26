using System;
using GreedKataGame.Application.Implementation;
using GreedKataGame.Presentation.Implementation.CommandResults;
using GreedKataGame.Presentation.Interfaces;

namespace GreedKataGame.Presentation.Implementation.Commands
{
    internal class RollDiceCommand : ICommand
    {
        private readonly IDiceOption diceOption;
        private readonly IApplicationServices application;

        public RollDiceCommand(IDiceOption diceOption)
        {
            this.diceOption = diceOption;
            this.application = new ApplicationServices(diceOption);
        }

        public ICommandResult Execute()
        {
            Console.Clear();
            Console.WriteLine("Scoring rules:\n");

            foreach (var rule in application.GetScoringRules())
            {
                Console.WriteLine(rule);
            }

            Console.WriteLine();
            Console.Write("Press any key to roll {0} dice...", diceOption.DiceNumber);
            Console.ReadKey(true);
            Console.WriteLine();
            Console.WriteLine();

            application.RollDice();
            
            Console.WriteLine("You have rolled: {0}", application.RolledDiceOutput);
            Console.WriteLine();
            Console.WriteLine("Your score is {0}!\n", application.CalculateScore());
            Console.WriteLine("Rules used:");

            foreach (var ruleUsed in application.RulesUsed)
            {
                Console.WriteLine(ruleUsed);
            }
            Console.WriteLine();

            return new GameCompleted(diceOption);
        }
    }
}
