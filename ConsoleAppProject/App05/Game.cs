using System;
using System.Collections.Generic;
using System.Text;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App05
{
    public class Game
    {
        public Player Player1;
        public Player Player2;
        public Player Computer;
        public Player CurrentPlayer;
        public Player Winner;
        private Random generator = new Random(55);
        public string Name;
        public int Rounds;

        public void Run()
        {
            ConsoleHelper.OutputHeading("Kyle & Vince Rock Paper Scissors");
            Menu();
        }

        public Player EnterPlayerName()
        {
            Console.WriteLine();
            Console.WriteLine("Enter Player Name");
            Name = Console.ReadLine();
            Player player = new Player(Name, Player.GamePlayer.Player);
            return player;
        }
        public void EnterChoice(Player player)
        {

            if (player.PlayerType == Player1.PlayerType)
            {
                Console.WriteLine();
                Console.WriteLine("Enter Your Choice");
                Console.WriteLine("1. Rock");
                Console.WriteLine("2. Paper");
                Console.WriteLine("3. Scissors");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    player.Choice = Player.GameChoices.Rock;
                }
                else if (choice == "2")
                {
                    player.Choice = Player.GameChoices.Paper;
                }
                else if (choice == "3")
                {
                    player.Choice = Player.GameChoices.Scissors;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid Input, Try Again");
                    Player1.Choice = Player.GameChoices.None;
                }
            }

            else if (player.PlayerType == Computer.PlayerType)
            {
                int val = generator.Next(1, 3);

                switch (val)
                {
                    case 1: player.Choice = Player.GameChoices.Rock; break;
                    case 2: player.Choice = Player.GameChoices.Paper; break;
                    case 3: player.Choice = Player.GameChoices.Scissors; break;
                }
            }
        }
        public void ScoreRound(Player player, Player player2)
            {
                if (player.Choice == Player.GameChoices.Rock && player2.Choice == Player.GameChoices.Paper)
                {
                    Winner = player2;
                    player2.Score += 1;
                    Console.WriteLine();
                    Console.WriteLine($"Win is awarded to {Winner.Name}");
                }
                else if (player.Choice == Player.GameChoices.Rock && player2.Choice == Player.GameChoices.Rock)
                {
                    Console.WriteLine();
                    Console.WriteLine("No Point is awarded for this Round, Both Players Made The Same Move");
                    Winner = null;
                }
                else if (player.Choice == Player.GameChoices.Rock && player2.Choice == Player.GameChoices.Scissors)
                {
                    player.Score += 1;
                    Winner = player;
                    Console.WriteLine();
                    Console.WriteLine($"1 Point is awarded to {Winner.Name}");

                }
                else if (player.Choice == Player.GameChoices.Scissors && player2.Choice == Player.GameChoices.Scissors)
                {
                    Console.WriteLine();
                    Console.WriteLine("No Point is awarded for this Round, Both Players Made The Same Move");
                    Winner = null;
                }
                else if (player.Choice == Player.GameChoices.Scissors && player2.Choice == Player.GameChoices.Paper)
                {
                    player.Score += 1;
                    Winner = player;
                    Console.WriteLine();
                    Console.WriteLine($"1 Point is awarded to {Winner.Name}");
                }
                else if (player.Choice == Player.GameChoices.Scissors && player2.Choice == Player.GameChoices.Rock)
                {
                    Winner = player2;
                    player2.Score += 1;
                    Console.WriteLine();
                    Console.WriteLine($"Win is awarded to {Winner.Name}");
                }
                else if (player.Choice == Player.GameChoices.Paper && player2.Choice == Player.GameChoices.Paper)
                {
                    Console.WriteLine();
                    Console.WriteLine("No Point is awarded for this Round, Both Players Made The Same Move");
                    Winner = null;
                }
                else if (player.Choice == Player.GameChoices.Paper && player2.Choice == Player.GameChoices.Scissors)
                {
                    Winner = player2;
                    player2.Score += 1;
                    Console.WriteLine();
                    Console.WriteLine($"Win is awarded to {Winner.Name}");
                }
                else if (player.Choice == Player.GameChoices.Paper && player2.Choice == Player.GameChoices.Rock)
                {
                    player.Score += 1;
                    Winner = player;
                    Console.WriteLine();
                    Console.WriteLine($"1 Point is awarded to {Winner.Name}");
                }
            }
        public void GameRound(string mode)
        {
                Console.WriteLine("Enter The Number of Rounds you would like to Play");
                string input = Console.ReadLine();
                Rounds = Convert.ToInt32(input);

            if (mode == "single")
            {

                for (int i = 0; i < Rounds; i++)
                {
                    CurrentPlayer = Player1;
                    EnterChoice(CurrentPlayer);
                    CurrentPlayer = Computer;
                    EnterChoice(CurrentPlayer);
                    ScoreRound(Player1, Computer);
                    Console.WriteLine();
                    Console.WriteLine($"{Player1.Name}'s Score Is {Player1.Score}");
                    Console.WriteLine();
                    Console.WriteLine($"Computer's Score Is {Computer.Score}");
                } 

                if (Player1.Score > Computer.Score)
                {
                    Console.WriteLine();
                    Console.WriteLine($"The Winner is {Player1.Name}");
                }
                else if (Player1.Score < Computer.Score)
                {
                    Console.WriteLine();
                    Console.WriteLine($"The Winner is {Computer.Name}");
                }
            }
            else if (mode == "vs")
            {
                for (int i = 0; i < Rounds; i++)
                {
                    CurrentPlayer = Player1;
                    Console.WriteLine();
                    Console.WriteLine($"It's {Player1.Name} turn");
                    EnterChoice(CurrentPlayer);
                    CurrentPlayer = Player2;
                    Console.WriteLine();
                    Console.WriteLine($"It's {Player2.Name} turn");
                    EnterChoice(CurrentPlayer);
                    ScoreRound(Player1,Player2);
                    Console.WriteLine();
                    Console.WriteLine($"{Player1.Name}'s Score Is {Player1.Score}");
                    Console.WriteLine();
                    Console.WriteLine($"{Player2.Name}'s Score Is {Player2.Score}");
                }

                if (Player1.Score > Player2.Score)
                {
                    Console.WriteLine();
                    Console.WriteLine($"The Winner is {Player1.Name}");
                }
                else if (Player1.Score < Player2.Score)
                {
                    Console.WriteLine();
                    Console.WriteLine($"The Winner is {Player2.Name}");
                }

            }
        }
        public void Menu ()
        {
            string[] choices = new string[]
              {
                "Player Vs Computer","Player vs Player ", "Quit"
              };
            bool Quit = false; ;
            do
            {
                int choice = ConsoleHelper.SelectChoice(choices);
                switch (choice)
                {
                    case 1:
                        Player1 = EnterPlayerName();
                        Computer = new Player("Computer", Player.GamePlayer.Computer);
                        GameRound("single"); break;
                    case 2: Player1 = EnterPlayerName();
                            Player2 = EnterPlayerName();
                            GameRound("vs"); break;

                    case 3: Quit = true; break;
                }

            } while (!Quit);
        }

    }

 }
    



