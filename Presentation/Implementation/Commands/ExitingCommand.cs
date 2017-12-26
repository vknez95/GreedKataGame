using System;
using GreedKataGame.Presentation.Implementation.CommandResults;
using GreedKataGame.Presentation.Interfaces;

namespace GreedKataGame.Presentation.Implementation.Commands
{
    internal class ExitingCommand: ICommand
    {
        public ICommandResult Execute()
        {
            Console.WriteLine("Goodbye!\n");
            
            return new NoResult();
        }
    }
}
