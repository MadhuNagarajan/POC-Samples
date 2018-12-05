using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HoP.TechnicalTest.GameService.UnitTest
{
    [TestClass]
    public class Handling_ComputerPlayer_RandomNumber_Generator
    {
        
        [TestMethod]
        public void When_ComputerChoice_RandomGenerator_Called()
        {
            RockPaperScissorsService rpsSvc = new RockPaperScissorsService();
            int result = rpsSvc.ComputerChoice();

            Assert.AreNotEqual(result, 4);
        }

        [TestMethod]
        public void When_ComputerChoice_RandomGenerator_NotNull()
        {
            RockPaperScissorsService rpsSvc = new RockPaperScissorsService();
            int result = rpsSvc.ComputerChoice();

            Assert.IsNotNull(result);
        }
    }
}
