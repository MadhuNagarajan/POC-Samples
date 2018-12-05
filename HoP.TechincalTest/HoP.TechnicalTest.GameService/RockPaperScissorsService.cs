using System;
using System.Collections.Generic;

namespace HoP.TechnicalTest.GameService
{
    public class RockPaperScissorsService : IRockPaperScissorsService
    {
        private Dictionary<int, string> gameValue;

        private const string INVALIDCHOICE = "InvalidChoice";
        private const string CHOICE1 = "Choice1";
        private const string CHOICE2 = "Choice2";
        private const string GAMETIEMSG = "Game tie!!!";
        private const string INVALIDCHOICEMSG = "Invalid choice, play gain.";

        public RockPaperScissorsService()
        {
            gameValue = new Dictionary<int, string>();
            gameValue.Add(0, "Invalid");
            gameValue.Add(1, "Rock");
            gameValue.Add(2, "Paper");
            gameValue.Add(3, "Scissor");
        }
        public int ComputerChoice()
        {
            Random rnd = new Random();
            return rnd.Next(0, 3);            
        }             

        public string PlayerVsComputer(int playerchoice, int computerchoice)
        {
            try
            {

                if (playerchoice == computerchoice)
                    return GAMETIEMSG;

                string result = DecideWinner(playerchoice, computerchoice);

                if (result.Equals(INVALIDCHOICE))
                    return INVALIDCHOICEMSG;
                return result == CHOICE1 ? "You won!!!" : "Computer won!!!";
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public string ComputerVsComputer(int computerchoice1, int computerchoice2)
        {
            try
            {
                if (computerchoice1 == computerchoice2)
                    return "Game tie!!!";

                string result = DecideWinner(computerchoice1, computerchoice2);
                if (result.Equals(INVALIDCHOICE))
                    return INVALIDCHOICEMSG;
                return result == CHOICE1 ? "Computer player 1 won!!!" : "Computer player 2 won!!!";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string PlayerVsPlayer(int playerchoice1, int playerchoice2)
        {
            try
            {
                if (playerchoice1 == playerchoice2)
                    return "Game tie!!!";

                string result = DecideWinner(playerchoice1, playerchoice2);
                if (result.Equals(INVALIDCHOICE))
                    return INVALIDCHOICEMSG;
                return result == CHOICE1 ? "Player 1 won!!!" : "Player 2 won!!!";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private string DecideWinner(int choice1, int choice2)
        {
            try
            {
                if (gameValue[choice1] == "Rock" && gameValue[choice2] == "Scissor" || gameValue[choice1] == "Paper" && gameValue[choice2] == "Rock")
                {
                    return CHOICE1;
                }
                else if (gameValue[choice1] == "Scissor" && gameValue[choice2] == "Rock" || gameValue[choice1] == "Rock" && gameValue[choice2] == "Paper")
                {
                    return CHOICE2;
                }
                else if (gameValue[choice1] == "Scissor" && gameValue[choice2] == "Paper")
                {
                    return CHOICE1;
                }
                else if (gameValue[choice1] == "Paper" && gameValue[choice2] == "Scissor")
                {
                    return CHOICE2;
                }
                else
                {
                    return INVALIDCHOICE;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
