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
        

        public Shop(Player currentPlayer)
        {
            InitializeComponent();
            shopPlayer = currentPlayer;
            
            

        }

        private void lblStoreItems_Click(object sender, EventArgs e)
        {
            
        }

        private void GetStats()
        {
            weapons = "" + shopPlayer.PlayerAttack + Environment.NewLine;
            armor = "" + shopPlayer.PlayerArmor + Environment.NewLine;
            maxhealth = "" + shopPlayer.PlayerHealth + Environment.NewLine;
            numpotions = "" + shopPlayer.PlayerPotions + Environment.NewLine;
            difflevel = "" + shopPlayer.GameDiff + Environment.NewLine;
            CompileStats();
        }

        private void btnBuyArmor_Click(object sender, EventArgs e)
        {
            shopPlayer.PlayerArmor++;
            GetStats();

        }

        private void btnBuyWeapon_Click(object sender, EventArgs e)
        {
            shopPlayer.PlayerAttack++;
            GetStats();
        }

        private void btnBuyHealth_Click(object sender, EventArgs e)
        {
            shopPlayer.PlayerHealth++;
            GetStats();
        }

        private void btnBuyPotion_Click(object sender, EventArgs e)
        {
            shopPlayer.PlayerPotions++;
            GetStats();
        }

        private void btnBuyDiff_Click(object sender, EventArgs e)
        {
            shopPlayer.GameDiff++;
            GetStats();
        }
        private void CompileStats()
        {
            txtShopPlayerStats.Text = weapons + armor + maxhealth + numpotions + difflevel;
        }
    }
}
