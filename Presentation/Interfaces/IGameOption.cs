using System.Collections.Generic;

namespace GreedKataGame.Presentation.Interfaces
{
    public interface IGameOption
    {
        bool IsExitOption { get; }
        
        char Id { get; }
        
        string Description { get; }
    }
}
