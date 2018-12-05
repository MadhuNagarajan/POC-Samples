using System;
using System.Windows.Forms;
using HoP.TechnicalTest.GameService;

namespace HoP.TechnicalTest.RockPaperScissorsWinApp
{
    public partial class FromRPSGame : Form
    {


        private RockPaperScissorsService rpsSvc;
        private const string PVSP = "Player Vs Player";
        private const string CVSC = "Computer Vs Computer";
        private const string PVSC = "Player Vs Computer";
        public FromRPSGame()
        {
            InitializeComponent();
            rpsSvc = new RockPaperScissorsService();
            InitailControlProperty();
            cmbxGameType.SelectedIndex = 1;
        }

        private void InitailControlProperty()
        {
            txtCompChoice1.Visible = false;
            txtCompChoice2.Visible = false;
            cmbPlayer1.Visible = false;
            cmbPlayer2.Visible = false;
            lblPlayer1.Visible = false;
            lblPlayer2.Visible = false;
            txtGameValue.Visible = false;
            
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            
            if(cmbxGameType.SelectedItem.ToString().Equals(PVSC))
            {
                txtResult.Text = rpsSvc.PlayerVsComputer(Convert.ToInt32(cmbPlayer1.SelectedItem.ToString()), Convert.ToInt32(txtCompChoice2.Text));
            }
            else if(cmbxGameType.SelectedItem.ToString().Equals(PVSP))
            {
                txtResult.Text = rpsSvc.PlayerVsPlayer(Convert.ToInt32(cmbPlayer1.SelectedItem.ToString()), Convert.ToInt32(cmbPlayer2.SelectedItem.ToString()));
            }
            else if(cmbxGameType.SelectedItem.ToString().Equals(CVSC))
            {
                txtResult.Text = rpsSvc.ComputerVsComputer(Convert.ToInt32(txtCompChoice1.Text), Convert.ToInt32(txtCompChoice2.Text));
            }
        }

        private void cmbxGameType_SelectedValueChanged(object sender, EventArgs e)
        {
            InitailControlProperty();
            txtResult.Text = "";
            lblPlayer1.Visible = true;
            lblPlayer2.Visible = true;
            txtGameValue.Visible = true;
            
            if (cmbxGameType.SelectedItem.ToString().Equals(PVSC))
            {
                txtCompChoice2.Visible = true;
                cmbPlayer1.Visible = true;
                txtCompChoice2.Text = rpsSvc.ComputerChoice().ToString();
            }
            else if (cmbxGameType.SelectedItem.ToString().Equals(PVSP))
            {
                cmbPlayer1.Visible = true;
                cmbPlayer2.Visible = true;
            }
            else if (cmbxGameType.SelectedItem.ToString().Equals(CVSC))
            {
                txtCompChoice1.Visible = true;
                txtCompChoice2.Visible = true;

                txtCompChoice1.Text = rpsSvc.ComputerChoice().ToString();
                txtCompChoice2.Text = rpsSvc.ComputerChoice().ToString();
            }

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            txtCompChoice1.Text = "";
            txtCompChoice2.Text = "";
            txtResult.Text = "";
            cmbPlayer1.SelectedItem = 0;
            cmbPlayer2.SelectedItem = 0;
            InitailControlProperty();
            cmbxGameType.SelectedIndex = 2;
        }
    }
}
