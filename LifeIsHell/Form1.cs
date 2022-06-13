using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace LifeIsHell
{
    public partial class frmStartGame : Form
    {
        bool firstText = false;
        bool secondText = false;
        bool thirdText = false;
        bool allText = false;
        public static Player currentPlayer = new Player();
        public static Location location = new Location();

        public frmStartGame()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            btnStartGame.Visible = false;
            btnNewGame.Visible = true;
            btnLoadGame.Visible = true;
        }

        private void frmStartGame_Load(object sender, EventArgs e)
        {

        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            
            btnNewGame.Visible = false;
            btnLoadGame.Visible = false;
            txtIntroText.Visible = true;
            btnIntroContinue.Visible = true;
            txtIntroText.Text = "This is the intro text.";
            firstText = true;
        }

        private void btnIntroContinue_Click(object sender, EventArgs e)
        {
            PrintIntroText();
        }
        public void PrintIntroText() //this function provides the intro text when the continue button is pressed.
        {
            if (firstText == true)
            {
                txtIntroText.Text = "This is the second intro text.";
                secondText = true;
                firstText = false;
            }
            else if (secondText == true)
            {
                txtIntroText.Text = "This is the third intro text.";
                thirdText = true;
                secondText = false;
            }
            else if (thirdText == true)
            {
                txtIntroText.Text = "This is the final text.";
                thirdText = false;
                allText = true;
            }
            else if (allText == true)
            {
                btnIntroContinue.Visible = false;
                txtIntroText.Visible = false;
                lblTitle.Visible = false;
                InsertName nameForm = new InsertName(this);
                nameForm.ShowDialog();
                txtMainScreen.Visible = true;
                picboxMainScreen.Visible = true;
                boxDirections.Visible = true;
                txtMainScreen.Text = "Welcome to Hell " + currentPlayer.PlayerName;
               
                location.PlayerLocation(currentPlayer, txtMainScreen, picboxMainScreen);
            }
        }

        
        private void btnNorth_Click(object sender, EventArgs e)
        {
            currentPlayer.PlayerLocX++;
            location.PlayerLocation(currentPlayer, txtMainScreen, picboxMainScreen);
        }

        private void btnEast_Click(object sender, EventArgs e)
        {
            currentPlayer.PlayerLocY++;
            location.PlayerLocation(currentPlayer, txtMainScreen, picboxMainScreen);
        }

        private void btnSouth_Click(object sender, EventArgs e)
        {
            currentPlayer.PlayerLocX--;
            location.PlayerLocation(currentPlayer, txtMainScreen, picboxMainScreen);
        }

        private void btnWest_Click(object sender, EventArgs e)
        {
            currentPlayer.PlayerLocY--;
            location.PlayerLocation(currentPlayer, txtMainScreen, picboxMainScreen);
        }

        private void boxDirections_Enter(object sender, EventArgs e)
        {
            
        }

        private void picboxMainScreen_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            location.SearchLocation(currentPlayer, txtMainScreen);
        }

        private void btnTalk_Click(object sender, EventArgs e)
        {
            location.TalkLocation(currentPlayer, txtMainScreen);
        }

        private void btnInteract_Click(object sender, EventArgs e)
        {
            location.InteractLocation(currentPlayer, txtMainScreen);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
       
        public void NewPlayerSheet()
        {
            
            
        }
        public void SetPlayerName(string x)
        {
            currentPlayer.PlayerName = "";
        }

        public void txtMainScren_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}