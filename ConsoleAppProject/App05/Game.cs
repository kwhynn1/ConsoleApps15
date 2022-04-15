using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleAppProject.App05
{
    public class Game
    {

        public const int Max_Rounds = 3;

        public int Round;

        public Player Human;

        public Player Computer;

        public Player CurrentPlayer;
        
        public Player Winner;

        private Random generator = new Random(55);

        public Game (string name) 
        {
            Human = new Player("Peter", Player.GamePlayer.Player);
            Computer = new Player("Computer", Player.GamePlayer.Computer);
            Round = 0;
        }

        public void Start() 
        {
            Round = 1;
            CurrentPlayer = Human;
            Human.Score = 0;
            Computer.Score = 0;
        }

        public void ComputerChoice()
        {
            int val = generator.Next(1,4);

            switch (val)
            {
                case 1: Computer.Choice = Player.GameChoices.Rock; break;
                case 2: Computer.Choice = Player.GameChoices.Paper; break;
                case 3: Computer.Choice = Player.GameChoices.Scissors; break;
            }
        }

        public void ScoreRound()
        {
            if (Human.Choice == Player.GameChoices.Rock && Computer.Choice == Player.GameChoices.Paper) 
            {
                Computer.Score += 2;
                Winner = Computer;

            }

            if (Round < 3)
            {
                Round++;
            }
       
        }

        public void EndGame()
        {
            if (Computer.Score > Human.Score)
            {
                Winner = Computer;
            }
            else if (Computer.Score < Human.Score)
            {
                Winner = Human;
            }

            else Winner = null;

        }


    }
}
