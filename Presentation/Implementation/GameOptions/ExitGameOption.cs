using GreedKataGame.Presentation.Interfaces;

namespace GreedKataGame.Presentation.Implementation.GameOptions
{
    public class ExitGameOption : IGameOption
    {   
        public char Id => 'x';

        public string Description => "Exit";

        public bool IsExitOption => true;
    }
}
