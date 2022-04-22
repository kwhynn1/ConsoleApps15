using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App05
{
   public class Player
    {
        /// <summary>
        /// Enum class for Game Choices
        /// </summary>
        public enum GameChoices
        {
            None,
            Paper,
            Rock,
            Scissors
        }

        /// <summary>
        /// Enum class for Game Player
        /// </summary>
        public enum GamePlayer
        {
            None,
            Player,
            Computer
        }

        /// <summary>
        /// Variables used in the Player class
        /// </summary>
        public string Name;
        public int Score;
        public GamePlayer PlayerType;
        public GameChoices Choice;

        /// <summary>
        ///  Constructor for Player Class
        /// </summary>
        public Player(string name, GamePlayer playerType) 
        { 
            this.Name = name;
            this.PlayerType = playerType;
            Score = 0;
            Choice = GameChoices.None;
        }

        /// <summary>
        ///  Used to increase Player score
        /// </summary>
        public void IncreaseScore(Player player, int increacse)
        {
            player.Score = increacse + player.Score;
        }

    }
}
