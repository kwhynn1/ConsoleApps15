using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App05;

namespace ConsoleAppTests
{
    [TestClass]
    public class TestGame
    {
        private Game game = new Game("Tim");

        [TestMethod]
        public void TestGameStart()
        { 
 
            game.Start();

            Assert.AreEqual(0, game.Human.Score);
            Assert.AreEqual(0, game.Human.Score);
            Assert.AreEqual(1, game.Round);

            Assert.AreEqual(Player.GamePlayer.Player, game.CurrentPlayer.PlayerType);

            Assert.AreEqual("Peter", game.Human.Name);
            Assert.AreEqual("Computer", game.Computer.Name);

        }
        [TestMethod]
        public void TestGameChoice()
        {
            game.Start();

            int[] choices = new int[4];

            for (int i = 0; i < 10000; i++)
            {
                game.ComputerChoice();
                int choice  = (int)game.Computer.Choice;
                choices[choice]++;
            }
            Assert.IsTrue(choices[0] == 0);
            Assert.IsTrue(choices[1] > 3000);
            Assert.IsTrue(choices[2] > 3000);
            Assert.IsTrue(choices[3] > 3000);
        }

        [TestMethod]
        public void TestScorePoint()
        {
            game.Start();

            game.Human.Choice = Player.GameChoices.Rock;
            game.Computer.Choice = Player.GameChoices.Paper;

            game.ScoreRound();

            Assert.AreEqual(0, game.Human.Score);
            Assert.AreEqual(2, game.Computer.Score);
            Assert.AreEqual(game.Winner.PlayerType, Player.GamePlayer.Computer);

        }



    }
}

