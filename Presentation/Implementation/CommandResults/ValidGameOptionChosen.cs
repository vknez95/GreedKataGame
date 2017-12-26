using GreedKataGame.Presentation.Implementation.Commands;
using GreedKataGame.Presentation.Interfaces;

namespace GreedKataGame.Presentation.Implementation.CommandResults
{
    public class ValidGameOptionChosen : ICommandResult
    {
        private readonly IGameOption gameOption;

        public ValidGameOptionChosen(IGameOption gameOption)
        {
            this.gameOption = gameOption;
        }

        public ICommand NextCommand
        {
            get
            {
                if (gameOption.IsExitOption)
                {
                    return new ExitingCommand();
                }

                var diceOption = gameOption as IDiceOption;

                if (diceOption == null)
                {
                    return new ExitingCommand();
                }
                else
                {
                    return new RollDiceCommand(diceOption);
                }
            }
        }
    }
}
