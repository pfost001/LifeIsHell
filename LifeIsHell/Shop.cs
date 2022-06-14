using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeIsHell
{
    public partial class Shop : Form
    {
        public Player shopPlayer;
        public string weapons;
        public string armor;
        public string maxhealth;
        public string numpotions;
        public string difflevel;
        public string playercoins;
        int armorprice;
        int weaponprice;
        int healthprice;
        int potionprice;
        int diffprice;
        
        public Shop(Player currentPlayer)
        {
            InitializeComponent();
            shopPlayer = currentPlayer;
            GetStats();
            SetPrices();



        }

        private void lblStoreItems_Click(object sender, EventArgs e)
        {

        }

        private void GetStats()
        {
            weapons = "Weapon Power: " + shopPlayer.PlayerAttack + Environment.NewLine;
            armor = "Armor Value: " + shopPlayer.PlayerArmor + Environment.NewLine;
            maxhealth = "Maximum Health: " + shopPlayer.PlayerHealth + Environment.NewLine;
            numpotions = "Potions: " + shopPlayer.PlayerPotions + Environment.NewLine;
            difflevel = "Difficulty Level: " + shopPlayer.GameDiff + Environment.NewLine;
            playercoins = "Player Coins: " + shopPlayer.PlayerCoin + Environment.NewLine;
            CompileStats();
            SetPrices();
        }

        private void btnBuyArmor_Click(object sender, EventArgs e)
        {
            lblNoMoney.Visible = false;
            CheckCoin("armor", armorprice);

        }

        private void btnBuyWeapon_Click(object sender, EventArgs e)
        {
            lblNoMoney.Visible = false;
            CheckCoin("weapon", weaponprice);
        }

        private void btnBuyHealth_Click(object sender, EventArgs e)
        {
            lblNoMoney.Visible = false;
            CheckCoin("health", healthprice);
        }

        private void btnBuyPotion_Click(object sender, EventArgs e)
        {
            lblNoMoney.Visible = false;
            CheckCoin("potion", potionprice);
        }

        private void btnBuyDiff_Click(object sender, EventArgs e)
        {
            lblNoMoney.Visible = false;
            CheckCoin("diff", diffprice);
        }
        private void CompileStats()
        {
            txtShopPlayerStats.Text = weapons + armor + maxhealth + numpotions + difflevel + playercoins;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SetPrices()
        {

            CalcPrices();
            txtArmorPrice.Text = "" + armorprice;
            txtWeaponPrice.Text = "" + weaponprice;
            txtHealthPrice.Text = "" + healthprice;
            txtPotionPrice.Text = "" + potionprice;
            txtDiffPrice.Text = "" + diffprice;

        }

        public void CalcPrices()
        {
            armorprice = shopPlayer.PlayerArmor * 100;
            weaponprice = shopPlayer.PlayerAttack * 50;
            healthprice = shopPlayer.PlayerHealth * 10;
            potionprice = 25;
            diffprice = shopPlayer.GameDiff * 25;
        }
        public void CheckCoin(string item, int price)
        {
            if (shopPlayer.PlayerCoin < price)
            {
                lblNoMoney.Visible = true;
            }
            else
            {
                if (item == "diff")
                {
                    shopPlayer.GameDiff++;
                }
                else if (item == "weapon")
                {
                    shopPlayer.PlayerAttack++;
                }
                else if (item == "armor")
                {
                    shopPlayer.PlayerArmor++;
                }
                else if (item == "potion")
                {
                    shopPlayer.PlayerPotions++;
                }
                else if (item == "health")
                {
                    shopPlayer.PlayerMaxHealth++;
                }
            }
            GetStats();
            SetPrices();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
