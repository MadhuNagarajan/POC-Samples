namespace HoP.TechnicalTest.GameService
{
    public interface IRockPaperScissorsService
    {
        string PlayerVsComputer(int playerchoice, int computerchoice);

        string ComputerVsComputer(int computerchoice1, int computerchoice2);

        string PlayerVsPlayer(int playerchoice1, int playerchoice2);

        int ComputerChoice();
    }
}
