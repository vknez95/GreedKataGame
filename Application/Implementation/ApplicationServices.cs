using System;
using System.Collections.Generic;
using System.Linq;
using GreedKataGame.Application.Factories;
using GreedKataGame.Application.Models;
using GreedKataGame.Presentation.Interfaces;

namespace GreedKataGame.Application.Implementation
{
    public class ApplicationServices : IApplicationServices
    {
        private readonly IDiceOption diceOption;
        private Dice dice;
        private Greed greedGame;
        private int[] rolledDice;

        public ApplicationServices(IDiceOption diceOption)
        {
            this.diceOption = diceOption;
            this.dice = new Dice(diceOption.DiceNumber);
        }

        public IEnumerable<string> RulesUsed => greedGame.RulesUsed.Select(rule => rule.Description);

        public string RolledDiceOutput => dice.RolledDiceOutput;

        public int CalculateScore()
        {
            greedGame = new Greed(diceOption.UseAllRules);
            return greedGame.Score(rolledDice);
        }

        public IEnumerable<string> GetScoringRules()
        {
            var rulesFactory = new ScoringRulesFactory();
            return rulesFactory.CreateRules(diceOption.Id);
        }

        public int[] RollDice()
        {
            rolledDice = dice.RollDice();
            return rolledDice;
        }
    }
}
