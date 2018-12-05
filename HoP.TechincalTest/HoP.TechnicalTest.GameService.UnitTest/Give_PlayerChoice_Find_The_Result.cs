using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HoP.TechnicalTest.GameService.UnitTest
{
    [TestClass]
    public class Give_PlayerChoice_Find_The_Result
    {
        [TestMethod]
        public void When_ComputerVsPlayer_GameTie()
        {
            RockPaperScissorsService rpsSvc = new RockPaperScissorsService();
            string result = rpsSvc.PlayerVsComputer(1, 1);

            Assert.AreEqual(result, "Game tie!!!");
        }

        [TestMethod]
        public void When_ComputerVsComputer_GameTie()
        {
            RockPaperScissorsService rpsSvc = new RockPaperScissorsService();
            string result = rpsSvc.ComputerVsComputer(1, 1);

            Assert.AreEqual(result, "Game tie!!!");
        }

        [TestMethod]
        public void When_PlayerVsPlayer_GameTie()
        {
            RockPaperScissorsService rpsSvc = new RockPaperScissorsService();
            string result = rpsSvc.PlayerVsPlayer(1, 1);

            Assert.AreEqual(result, "Game tie!!!");
        }

        [TestMethod]
        public void When_ComputerVsPlayes_PlayerWon()
        {
            RockPaperScissorsService rpsSvc = new RockPaperScissorsService();
            string result = rpsSvc.PlayerVsComputer(2, 1);

            Assert.AreEqual(result, "You won!!!");
        }

        [TestMethod]
        public void When_ComputerVsPlayes_ComputerWon()
        {
            RockPaperScissorsService rpsSvc = new RockPaperScissorsService();
            string result = rpsSvc.PlayerVsComputer(1, 2);

            Assert.AreEqual(result, "Computer won!!!");
        }

        [TestMethod]
        public void When_ComputerVsComputer_Player1Won()
        {
            RockPaperScissorsService rpsSvc = new RockPaperScissorsService();
            string result = rpsSvc.ComputerVsComputer(3, 2);

            Assert.AreEqual(result, "Computer player 1 won!!!");
        }

        [TestMethod]
        public void When_ComputerVsComputer_Player2Won()
        {
            RockPaperScissorsService rpsSvc = new RockPaperScissorsService();
            string result = rpsSvc.ComputerVsComputer(2, 3);

            Assert.AreEqual(result, "Computer player 2 won!!!");
        }
                
        [TestMethod]
        public void When_PlayerVsPlayer_Player1Won()
        {
            RockPaperScissorsService rpsSvc = new RockPaperScissorsService();
            string result = rpsSvc.PlayerVsPlayer(3, 2);

            Assert.AreEqual(result, "Player 1 won!!!");
        }

        [TestMethod]
        public void When_PlayerVsPlayer_Player2Won()
        {
            RockPaperScissorsService rpsSvc = new RockPaperScissorsService();
            string result = rpsSvc.PlayerVsPlayer(2, 3);

            Assert.AreEqual(result, "Player 2 won!!!");
        }

        [TestMethod]
        public void WhenPlayerVsPlayes()
        {
            RockPaperScissorsService rpsSvc = new RockPaperScissorsService();
            string result = rpsSvc.ComputerVsComputer(2, 3);

            Assert.AreEqual(result, "Computer player 2 won!!!");
        }

        [TestMethod]
        public void When_PlayerVsComputer_Given_InvalidChoice()
        {
            RockPaperScissorsService rpsSvc = new RockPaperScissorsService();
            string result = rpsSvc.PlayerVsComputer(2, 0);

            Assert.AreEqual(result, "Invalid choice, play gain.");
        }

        [TestMethod]
        public void When_ComputerVsComputer_Given_InvalidChoice()
        {
            RockPaperScissorsService rpsSvc = new RockPaperScissorsService();
            string result = rpsSvc.ComputerVsComputer(2, 0);

            Assert.AreEqual(result, "Invalid choice, play gain.");
        }

        [TestMethod]
        public void When_PlayerVsPlayer_Given_InvalidChoice()
        {
            RockPaperScissorsService rpsSvc = new RockPaperScissorsService();
            string result = rpsSvc.PlayerVsPlayer(2, 0);

            Assert.AreEqual(result, "Invalid choice, play gain.");
        }

        [TestMethod]
        public void When_PlayerVsPlayer_Returns_SomeResult()
        {
            RockPaperScissorsService rpsSvc = new RockPaperScissorsService();
            string result = rpsSvc.PlayerVsPlayer(2, 0);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void When_ComputerVsComputer_Returns_SomeResult()
        {
            RockPaperScissorsService rpsSvc = new RockPaperScissorsService();
            string result = rpsSvc.ComputerVsComputer(2, 0);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void When_PlayerVsComputer_Returns_SomeResult()
        {
            RockPaperScissorsService rpsSvc = new RockPaperScissorsService();
            string result = rpsSvc.PlayerVsComputer(2, 0);

            Assert.IsNotNull(result);
        }
    }
}
