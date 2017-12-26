using System;
using System.Collections.Generic;
using System.Linq;
using GreedKataGame.Presentation.Interfaces;

namespace GreedKataGame.Presentation.Implementation.GameOptions
{
    public class ContinueOption : IGameOption
    {   
        private readonly char id;
        private readonly string description;

        public ContinueOption(char id, string description)
        {
            this.id = id;
            this.description = description;
        }

        public char Id => id;

        public string Description => description;

        public bool IsExitOption => false;
    }
}
