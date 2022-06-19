using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;


namespace LifeIsHell
{
    
    public partial class frmStartGame : Form
    {
        Random rand = new Random();
        //bool firstText = false;
        //bool secondText = false;
        //bool thirdText = false;
        //bool allText = false;
        public static Player currentPlayer = new Player();
        public static Location location = new Location();
        string enemyname;
        int enemyhealth;
        int enemyattack;
        int woncoins;

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
            
            txtIntroText.Text = Environment.NewLine 
                + Environment.NewLine
                + "You awake to screaming all around you." 
                + Environment.NewLine
                + "You are surrounded by fire and winged creatures fly through the sky."
                + Environment.NewLine 
                + "The smell of smoke and blood fills your nostrils.";
            //txtIntroText.AppendText("You are surrounded by fire and winged creatures fly through the sky." + Environment.NewLine);
            //txtIntroText.AppendText("'Hello' you hear from behind you.");
           // firstText = true;           
        }

        public string[] text =
        {
            //"You awake to screaming all around you.",
            Environment.NewLine
                + Environment.NewLine
                + "'Hello' you hear from behind you.",
            Environment.NewLine
                + Environment.NewLine
                + "You turn around and see the Devil." 
                + Environment.NewLine
                + "Not a devil, but THE Devil"
                + Environment.NewLine
                + "You stare in disbelief.",
            Environment.NewLine
                + Environment.NewLine
                + "'Yeah I get that alot.'"
                + Environment.NewLine
                + "'Don't worry, you didn't make it to heaven but you were not THAT bad.'"
                + Environment.NewLine
                + "'So while you are in Hell you are free to roam about.'"
                + Environment.NewLine
                + "But there are some things you should know.'",
            Environment.NewLine
                + Environment.NewLine
                + "'You are going to have to fight to survive, here is a sword and shield.'"
                + Environment.NewLine
                + "'Don't worry too much. If you die, you'll be reborn right here.'"
                + Environment.NewLine
                + "'And every time you do die I get a little bump of endorphins.'" 
                + Environment.NewLine
                + "'It's pretty great.'",
            Environment.NewLine
                + Environment.NewLine
                + "'Have fun and I hope you die many many times.'"
                + Environment.NewLine
                + "'OH!' I almost forgot, there is a gift shop right here as well where you can spend your coins.'" 
                + Environment.NewLine
                + "The devil tosses you a sort of half ass salute and walks off.",
            "",
            
        };
        public int i = 0;
        private void btnIntroContinue_Click(object sender, EventArgs e)
        {
            PrintIntroText();
            txtIntroText.Text = text[i]+ Environment.NewLine; //= text[i] +Environment.NewLine;
            i++;
        }
        public void PrintIntroText() //this function provides the intro text when the continue button is pressed.
        {
            if (i == text.Length-1)
            {
                btnIntroContinue.Visible = false;
                txtIntroText.Visible = false;
                lblTitle.Visible = false;
                InsertName nameForm = new InsertName(this);
                nameForm.ShowDialog();
                txtMainScreen.Visible = true;
                picboxMainScreen.Visible = true;
                boxDirections.Visible = true;
                txtMainScreen.Text = "Welcome to Hell " + currentPlayer.PlayerName + "!"
                    + Environment.NewLine
                    + "Use the N, S, E, and W buttons to move around."
                    + Environment.NewLine
                    + "When fighting, use the attack button to make an all in attack."
                    + Environment.NewLine
                    + "The defend button will cause you to enter a defensive fighting stance."
                    + Environment.NewLine
                    + "The potion button will drink a potion to restore your health."
                    + Environment.NewLine
                    + "And if all else fails you can try to escape the fight with the run button."
                    + Environment.NewLine
                    + "Use the search, interact, and talk buttons while exploring."
                    + Environment.NewLine
                    + "Have fun and enjoy your life in Hell!";
                btnEnterShop.Visible = true;

                location.PlayerLocation(currentPlayer, txtMainScreen, picboxMainScreen);
            }

            //if (firstText == true)
            //{                              
            //    txtIntroText.Text = "You turn around and see the Devil." + Environment.NewLine;
            //    txtIntroText.AppendText("Not a devil, the actual Devil" + Environment.NewLine);
            //    secondText = true;
            //    firstText = false;
            //}
            //else if (secondText == true)
            //{
            //    txtIntroText.Text = "This is the third intro text.";
            //    thirdText = true;
            //    secondText = false;
            //}
            //else if (thirdText == true)
            //{
            //    txtIntroText.Text = "This is the final text.";
            //    thirdText = false;
            //    allText = true;
            //}
            //else if (allText == true)
            //{
            //    btnIntroContinue.Visible = false;
            //    txtIntroText.Visible = false;
            //    lblTitle.Visible = false;
            //    InsertName nameForm = new InsertName(this);
            //    nameForm.ShowDialog();
            //    txtMainScreen.Visible = true;
            //    picboxMainScreen.Visible = true;
            //    boxDirections.Visible = true;
            //    txtMainScreen.Text = "Welcome to Hell " + currentPlayer.PlayerName;
            //    btnEnterShop.Visible = true;

            //    location.PlayerLocation(currentPlayer, txtMainScreen, picboxMainScreen);
            //}
        }


        private void btnNorth_Click(object sender, EventArgs e)
        {
            currentPlayer.PlayerLocY++;
            //location.PlayerLocation(currentPlayer, txtMainScreen, picboxMainScreen);
            CheckShop();
            location.PlayerLocation(currentPlayer, txtMainScreen, picboxMainScreen);
        }

        private void btnEast_Click(object sender, EventArgs e)
        {
            currentPlayer.PlayerLocX++;
            //location.PlayerLocation(currentPlayer, txtMainScreen, picboxMainScreen);
            CheckShop();
            location.PlayerLocation(currentPlayer, txtMainScreen, picboxMainScreen);
        }


        private void btnSouth_Click(object sender, EventArgs e)
        {
            currentPlayer.PlayerLocY--;
            //location.PlayerLocation(currentPlayer, txtMainScreen, picboxMainScreen);
            CheckShop();
            location.PlayerLocation(currentPlayer, txtMainScreen, picboxMainScreen);
        }

        private void btnWest_Click(object sender, EventArgs e)
        {
            currentPlayer.PlayerLocX--;
            //location.PlayerLocation(currentPlayer, txtMainScreen, picboxMainScreen);
            CheckShop();
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
            location.PlayerLocation(currentPlayer, txtMainScreen, picboxMainScreen);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    boxDirections.Visible = false;
                    boxCombat.Visible = true;
                    btnAttack.Visible = true;
                    btnDefend.Visible = true;
                    btnPotion.Visible = true;
                    btnExitCombat.Visible = false;
                    btnRun.Visible = true;
                    RandomEncounter();
                    break;
                case > 330:
                    break;

            }
        }
        public void RandomEncounter()
        {
            string name = Enemy.GetName();
            txtMainScreen.Text = "Only the worst of humanity lives in hell." + Environment.NewLine;
            txtMainScreen.AppendText("You see a " + name + Environment.NewLine);
            txtMainScreen.AppendText("They charge at you, weapon raised!" + Environment.NewLine);
            CombatText(true, name, 0, 0);

        }
        public void CombatText(bool normalfight, string name, int attack, int health)
        {
            if (normalfight == true)
            {
                txtMainScreen.AppendText("Enemy: " + name + Environment.NewLine);
                enemyname = name;
                enemyattack = currentPlayer.EnemyPower();
                enemyhealth = currentPlayer.EnemyHealth();
                txtMainScreen.AppendText("Enemy Health: " + enemyhealth + Environment.NewLine);
                txtMainScreen.AppendText("Enemy Power: " + enemyattack + Environment.NewLine);
                txtMainScreen.AppendText(Environment.NewLine);
                ShowPlayerStats();
            }
            else
            {
                txtMainScreen.AppendText("Enemy: " + name + Environment.NewLine);
                enemyname = name;
                txtMainScreen.AppendText("Health: " + health + Environment.NewLine);
                enemyhealth = health;
                txtMainScreen.AppendText("Power: " + attack + Environment.NewLine);
                enemyattack = attack;
                txtMainScreen.AppendText(Environment.NewLine);
                ShowPlayerStats();
            }
        }
        public void Combat(string buttonkey)
        {
            if (currentPlayer.PlayerHealth > 0)
            {
                if (buttonkey == "attack")
                {
                    txtMainScreen.AppendText(GetAttackText() + Environment.NewLine);
                    int playerdamage = currentPlayer.AttackCalc();
                    txtMainScreen.AppendText("You deal " + playerdamage + " damage." + Environment.NewLine);
                    enemyhealth -= playerdamage;
                    if (enemyhealth > 0)
                    {
                        txtMainScreen.AppendText("You take " + enemyattack + " damage." + Environment.NewLine);
                        currentPlayer.PlayerHealth -= enemyattack;
                        txtMainScreen.AppendText("Health: " + enemyhealth + Environment.NewLine);
                        txtMainScreen.AppendText("Power: " + enemyattack + Environment.NewLine);
                        txtMainScreen.AppendText(Environment.NewLine);
                        ShowPlayerStats();
                        AreDead();
                    }
                    else
                    {
                        txtMainScreen.AppendText("You have won the fight.");
                        woncoins = currentPlayer.WinCoins();
                        currentPlayer.PlayerCoin += woncoins;
                        txtMainScreen.AppendText("You gain " + woncoins + " coins." + Environment.NewLine);
                        btnAttack.Visible = false;
                        btnDefend.Visible = false;
                        btnPotion.Visible = false;
                        btnRun.Visible = false;
                        btnExitCombat.Visible = true;
                    }

                }
                else if (buttonkey == "defend")
                {
                    txtMainScreen.AppendText("You focus your efforts on defending yourself.");
                    int playerdamage = currentPlayer.DefendCalc();
                    txtMainScreen.AppendText("You deal " + playerdamage + " damage." + Environment.NewLine);
                    enemyhealth -= playerdamage;
                    enemyattack -= currentPlayer.PlayerArmor;
                    if (enemyattack < 0)
                    {
                        enemyattack = 0;
                    }
                    if (enemyhealth > 0)
                    {
                        txtMainScreen.AppendText("You take " + enemyattack + " damage." + Environment.NewLine);
                        currentPlayer.PlayerHealth -= enemyattack;
                        txtMainScreen.AppendText("Health: " + enemyhealth + Environment.NewLine);
                        txtMainScreen.AppendText("Power: " + enemyattack + Environment.NewLine);
                        txtMainScreen.AppendText(Environment.NewLine);
                        ShowPlayerStats();
                        AreDead();
                    }
                    else
                    {
                        txtMainScreen.AppendText("You have won the fight.");
                        woncoins = currentPlayer.WinCoins();
                        currentPlayer.PlayerCoin += woncoins;
                        txtMainScreen.AppendText("You gain " + woncoins + " coins." + Environment.NewLine);
                        btnAttack.Visible = false;
                        btnDefend.Visible = false;
                        btnPotion.Visible = false;
                        btnRun.Visible = false;
                        btnExitCombat.Visible = true;
                    }
                }
                else if (buttonkey == "potion")
                {
                    if (currentPlayer.PlayerPotions > 0)
                    {
                        int potionvalue = currentPlayer.GameDiff + 5;
                        txtMainScreen.AppendText("You drink the vile tasting liquid." + Environment.NewLine);
                        txtMainScreen.AppendText("You regain " + potionvalue + " health." + Environment.NewLine);
                        currentPlayer.PlayerHealth = currentPlayer.PlayerHealth + potionvalue;
                        if (currentPlayer.PlayerHealth > currentPlayer.PlayerMaxHealth)
                        {
                            currentPlayer.PlayerHealth = currentPlayer.PlayerMaxHealth;
                        }
                        currentPlayer.PlayerPotions -= 1;
                        txtMainScreen.AppendText("Enemy Health: " + enemyhealth + Environment.NewLine);
                        txtMainScreen.AppendText("Enemy Power: " + enemyattack + Environment.NewLine);
                        txtMainScreen.AppendText(Environment.NewLine);
                        ShowPlayerStats();
                        AreDead();
                    }
                    else
                    {
                        txtMainScreen.AppendText("You fumble for a potion to discover that you have run out." + Environment.NewLine);
                        txtMainScreen.AppendText("The enemy hits you while you search for a potion." + Environment.NewLine);
                        currentPlayer.PlayerHealth -= enemyattack;
                        txtMainScreen.AppendText("You take " + enemyattack + " damage.");
                        txtMainScreen.AppendText("Enemy Health: " + enemyhealth + Environment.NewLine);
                        txtMainScreen.AppendText("Enemy Power: " + enemyattack + Environment.NewLine);
                        txtMainScreen.AppendText(Environment.NewLine);
                        ShowPlayerStats();
                        AreDead();
                    }
                }
                else if (buttonkey == "run")
                {
                    Random random = new Random();
                    int runchance = random.Next(0, 4);
                    if (runchance == 0)
                    {
                        txtMainScreen.AppendText("You fail to escape and the enemy strikes you!");
                        txtMainScreen.AppendText("You take " + enemyattack + " damage.");
                        currentPlayer.PlayerHealth -= enemyattack;
                        ShowPlayerStats();

                    }
                    else
                    {
                        txtMainScreen.AppendText("Your dodgeball skills pay off and you escape.");
                        btnAttack.Visible = false;
                        btnDefend.Visible = false;
                        btnPotion.Visible = false;
                        btnRun.Visible = false;
                        btnExitCombat.Visible = true;
                    }

                }

            }


        }
        public void EndCombat()
        {
            btnAttack.Visible = false;
            btnDefend.Visible = false;
            btnPotion.Visible = false;
            btnRun.Visible = false;
            btnExitCombat.Visible = true;
            boxCombat.Visible = false;
            boxDirections.Visible = true;
            txtMainScreen.Text = "";
            location.PlayerLocation(currentPlayer, txtMainScreen, picboxMainScreen);
        }


        public void ShowPlayerStats()
        {
            txtMainScreen.AppendText(currentPlayer.PlayerName + "'s Weapon Power: " + currentPlayer.PlayerAttack + Environment.NewLine);
            txtMainScreen.AppendText(currentPlayer.PlayerName + "'s Armor Value: " + currentPlayer.PlayerArmor + Environment.NewLine);
            txtMainScreen.AppendText(currentPlayer.PlayerName + "'s CurrentHealth: " + currentPlayer.PlayerHealth + Environment.NewLine);
            txtMainScreen.AppendText(currentPlayer.PlayerName + "'s Potions: " + currentPlayer.PlayerPotions + Environment.NewLine);
        }
        public static string GetAttackText()
        {
            Random rand = new Random();
            string[] statement = 
            {
                "You focus your efforts on a heavy attack.",
                "You take a mighty swing with your sword.",
                "You swing wildly at your enemy.",
                "You slash downward with your sword."
            };
            return statement[rand.Next(0, 4)];
        }
       
        private void btnAttack_Click(object sender, EventArgs e)
        {
            Combat("attack");
        }

        private void btnPotion_Click(object sender, EventArgs e)
        {
            Combat("potion");
        }

        private void btnDefend_Click(object sender, EventArgs e)
        {
            Combat("defend");
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Combat("run");
        }

        private void btnExitCombat_Click(object sender, EventArgs e)
        {
            if (currentPlayer.PlayerHealth > 0)
            {
                EndCombat();
            }
            else
            {
                btnAttack.Visible = false;
                btnDefend.Visible = false;
                btnPotion.Visible = false;
                btnRun.Visible = false;
                btnExitCombat.Visible = true;
                boxCombat.Visible = false;
                boxDirections.Visible = true;
                txtMainScreen.Text = "You have been reborn!";
                string name = currentPlayer.PlayerName;
                currentPlayer = new Player();
                currentPlayer.PlayerName = name;
                currentPlayer.PlayerCoin = 0;       
                location.PlayerLocation(currentPlayer, txtMainScreen, picboxMainScreen);
            }
        }
        public void AreDead()
        {
            if (currentPlayer.PlayerHealth <= 0)
            {
                txtMainScreen.Text = "You have died and lost all your coins.";
                btnAttack.Visible = false;
                btnDefend.Visible = false;
                btnPotion.Visible = false;
                btnRun.Visible = false;
                btnExitCombat.Visible = true;
            }
        }

    }
}

