using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App05
{
   public class Player
    {
        public enum GameChoices
        {
            None,
            Paper,
            Rock,
            Scissors
        }

        public enum GamePlayer
        {
            None,
            Player,
            Computer
        }

        public string Name;

        public int Score;

        public GamePlayer PlayerType;

        public GameChoices Choice;

        public Player(string name, GamePlayer playerType) 
        { 
            this.Name = name;
            this.PlayerType = playerType;
            Score = 0;
            Choice = GameChoices.None;
        }

        public void IncreaseScore(Player player, int increacse)
        {
            player.Score = increacse + player.Score;
        }

    }
}
