using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace LifeIsHell
{
    public partial class frmStartGame : Form
    {
        Random rand = new Random();
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
                btnEnterShop.Visible = true;

                location.PlayerLocation(currentPlayer, txtMainScreen, picboxMainScreen);
            }
        }


        private void btnNorth_Click(object sender, EventArgs e)
        {
            currentPlayer.PlayerLocX++;
            location.PlayerLocation(currentPlayer, txtMainScreen, picboxMainScreen);
            CheckShop();
        }

        private void btnEast_Click(object sender, EventArgs e)
        {
            currentPlayer.PlayerLocY++;
            location.PlayerLocation(currentPlayer, txtMainScreen, picboxMainScreen);
            CheckShop();
        }


        private void btnSouth_Click(object sender, EventArgs e)
        {
            currentPlayer.PlayerLocX--;
            location.PlayerLocation(currentPlayer, txtMainScreen, picboxMainScreen);
            CheckShop();
        }

        private void btnWest_Click(object sender, EventArgs e)
        {
            currentPlayer.PlayerLocY--;
            location.PlayerLocation(currentPlayer, txtMainScreen, picboxMainScreen);
            CheckShop();
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

        private void btnEnterShop_Click(object sender, EventArgs e)
        {
            Shop shopForm = new Shop(currentPlayer);
            shopForm.ShowDialog();
        }
        public void CheckShop()
        {
            if (currentPlayer.PlayerLocX == 0 && currentPlayer.PlayerLocY == 0)
            {
                btnEnterShop.Visible = true;
            }
            else
                btnEnterShop.Visible = false;
        }
        public void RandomEncounterGen()
        {
            int fightCheck = rand.Next(0, 1000);
            switch (fightCheck)
            {
                case < 330:
                    RandomEncounter();
                    break;
                case > 330:
                    break;

            }
        }
        public void RandomEncounter()
        {
            string name = GetName();
            txtMainScreen.Text = "The worst of humanity lives in hell." + Environment.NewLine;
            txtMainScreen.AppendText("You see " + name + Environment.NewLine);

        }
        public static string GetName()
        {
            Random random = new Random();
            switch (random.Next(0, 89))
            {
                case 0:
                    return "Person who drives slow in the fast lane";
                case 1:
                    return "Person who chews with their mouth open";
                case 2:
                    return "Person who talks during movies";
                case 3:
                    return "Person who wears too much perfume";
                case 4:
                    return "Person who USES ALL CAPS!!!";
                case 5:
                    return "Humblebragger";
                case 6:
                    return "Person who doesn't return the shopping cart";
                case 7:
                    return "Person who taps their foot violently";
                case 8:
                    return "Person who takes up two parking spaces";
                case 9:
                    return "Person who eats other people's lunch";
                case 10:
                    return "Person who always replys all";
                case 11:
                    return "Person who applauds at the end of a plane trip";
                case 12:
                    return "Person who applauds at the end of a movie";
                case 13:
                    return "Person in the express checkout with too many items";
                case 14:
                    return "Person talking loudly on the phone at the gym";
                case 15:
                    return "Person who doesn't replace the toilet paper";
                case 16:
                    return "Booger Eater";
                case 17:
                    return "Person who RSVPs at the last minute";
                case 18:
                    return "Person who leaves the toilet seat up";
                case 19:
                    return "Person who picks their teeth in public";
                case 20:
                    return "Person who sniffs loudly but never blows their nose";
                case 21:
                    return "Person who blows their nose at maximum volume";
                case 22:
                    return "Person who takes up both armrests on a plane";
                case 23:
                    return "Surface Shitter";
                case 24:
                    return "Chow Thief";
                case 25:
                    return "Loud Eater";
                case 26:
                    return "Person who blocks the sidewalk for their selfies";
                case 27:
                    return "Person who texts while walking in a crowd";
                case 28:
                    return "Person who asks the teacher for more homework";
                case 29:
                    return "Person who never picks up the tab";
                case 30:
                    return "Person who makes every conversation about themselves";
                case 31:
                    return "Habitual Line Cutter";
                case 32:
                    return "Person who stands too close in line";
                case 33:
                    return "Non-stop Pen Clicker";
                case 34:
                    return "Person who starts their sentences with 'No offense'";
                case 35:
                    return "Person who is never on time";
                case 36:
                    return "Person who snaps their chewing gum";
                case 37:
                    return "Overzealous Toucher";
                case 38:
                    return "Person who doesn't wipe down their machines at the gym";
                case 39:
                    return "Person who won't shut up about their diet";
                case 40:
                    return "Person who keeps their phone on full volume";
                case 41:
                    return "Person who never knows what to order";
                case 42:
                    return "Person who doesn't know how to merge";
                case 43:
                    return "Person who can't shut up about their 'fur baby'";
                case 44:
                    return "Person who wears inappropiate clothing to work";
                case 45:
                    return "Person who makes up random nicknames";
                case 46:
                    return "Close Talker";
                case 47:
                    return "One Upper";
                case 48:
                    return "Nail Biter";
                case 49:
                    return "Knuckle Cracker";
                case 50:
                    return "Person who violently cracks their neck in public";
                case 51:
                    return "Person who always interrupts";
                case 52:
                    return "Know it All";
                case 53:
                    return "Person who never returns what they 'borrow'";
                case 54:
                    return "Over Sharer";
                case 55:
                    return "Person who is holier than thou";
                case 56:
                    return "Person who thinks everything is a joke";
                case 57:
                    return "Inconsiderate Jerk";
                case 58:
                    return "Virtue Signaler";
                case 59:
                    return "Person who doesn't use their blinker";
                case 60:
                    return "Guilt Tripper";
                case 61:
                    return "Person who acts like they were raised by wolves";
                case 62:
                    return "Person who will 'literally' die without their phone";
                case 63:
                    return "Drama Queen";
                case 64:
                    return "Cheap Bastard";
                case 65:
                    return "Person who finishes your sentences";
                case 66:
                    return "Ghoster";
                case 67:
                    return "Negative Nancy";
                case 68:
                    return "Person who is way to happy to be here";
                case 69:
                    return "Consistent Complainer";
                case 70:
                    return "Person who always has to be right";
                case 71:
                    return "Passive Aggressive A-hole";
                case 72:
                    return "Person who relates everything to their daily horoscope";
                case 73:
                    return "Person who doesn't know when to shut up";
                case 74:
                    return "Person who doesn't shower";
                case 75:
                    return "Clickbait Ad";
                case 76:
                    return "Prince from Nigeria that wants to give you money";
                case 77:
                    return "Spoiled rich only child";
                case 78:
                    return "Politician";
                case 79:
                    return "Meter Maid";
                case 80:
                    return "Liberal Arts Major";
                case 81:
                    return "Person who spoils movie endings";
                case 82:
                    return "Person who wipes their nose with their hand";
                case 83:
                    return "Person who doesn't flush the toilet";
                case 84:
                    return "Whiner";
                case 85:
                    return "Person who screams when they talk";
                case 86:
                    return "Person who moans at the urinal";
                case 87:
                    return "Sweat Lord";
                case 88:
                    return "Person whose 'long story short' is still long";
                case 89:
                    return "Person with taco breath";


            }
            return "default enemy name. you shouldn't be able to see this.";
        }
    }
}
