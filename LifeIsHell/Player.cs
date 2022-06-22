using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


namespace LifeIsHell
{  
    public class Player   
    {
        public Random rand = new Random();
        public string PlayerName = "";
        public int SaveCounter = 0;
        public int PlayerCoin = 1000;
        public int PlayerLocX = 0;
        public int PlayerLocY = 0;
        public int PlayerAttack = 2;
        public int PlayerHealth = 10;
        public int PlayerArmor = 1;
        public int GameDiff = 1;
        public int FormerPlayerLocX = 0;
        public int FormerPlayerLocY = 0;
        public int PlayerPotions = 5;
        public int PlayerMaxHealth = 10;
        public bool CraneOneInteract = false;
        public bool CraneGuyOne = false;
        public bool ChestOneOpen = false;
        public bool KeyOne = false;
        public bool FireChaliceOwn = false;
        public bool FireChaliceFull = false;
        public bool FireChalicePour = false;
        public bool RedOrbUp = false;
        public bool RedOrbInserted = false;

        public int EnemyPower()
        {
            int upper = (2 * GameDiff + 2);
            int lower = (1 * GameDiff + GameDiff / 2);
            return rand.Next(lower, upper);
        }
        public int EnemyHealth()
        {
            int upper = (4 * GameDiff + 5);
            int lower = (2 * GameDiff);
            return rand.Next(lower, upper);
        }
        public int WinCoins()
        {
            int upper = (5 * GameDiff + 9);
            int lower = (2 * GameDiff + 3);
            return rand.Next(lower, upper);
        }
        public int AttackCalc()
        {
            int upper = (PlayerAttack + 3);
            int lower = (PlayerAttack);
            return rand.Next(lower, upper);
        }
        public int DefendCalc()
        {
            int upper = (PlayerAttack / 2);
            int lower = (PlayerAttack / 3);
            return rand.Next(lower, upper);
        }
            
    }

    class Player2
    {
        string PlayerName { get; set; }
        public int SaveCounter = 0;
        int PlayerCoin = 10;

        int PlayerLocX = 0;
        int PlayerLocY = 0;

        int PlayerAttack = 1;
        int PlayerHealth = 10;
        int PlayerArmor = 1;
        int GameDiff = 1;

        int FormerPlayerLocX = 0;
        int FormerPlayerLocY = 0;

        int PlayerPotions = 5;
        int PlayerMaxHealth = 10;

        int PlayerFear = 0;
        int playerAnxi = 0;
        int PlayerStress = 0;

        public Player2(string name)
        {
            this.PlayerName = name;
        }

        public int PlayerHealthChange(int hp) //Everything that changes player's hp
        {
            return (PlayerHealth + hp);
        }

        public int PlayerCoinChange(int coin) //Everything that changes player's coin
        {
            return (this.PlayerCoin + coin);
        }

        public void CoordChange(int x, int y) //Everything that changes player's position
        {
            this.PlayerLocX += x;
            this.PlayerLocY += y;
        }

        public void PlayerMood(int fear, int anxi, int stress)//player's mood change
        {
            this.PlayerFear += fear;
            this.playerAnxi += anxi;
            this.PlayerStress += stress;
        }

        public void PotionChange(int potion)
        {
            this.PlayerPotions += potion;
        }





        public Random rand = new Random();

        public int EnemyPower()
        {
            int upper = (2 * GameDiff + 2);
            int lower = (1 * GameDiff + GameDiff / 2);
            return rand.Next(lower, upper);
        }
        public int EnemyHealth()
        {
            int upper = (4 * GameDiff + 5);
            int lower = (2 * GameDiff);
            return rand.Next(lower, upper);
        }
        public int WinCoins()
        {
            int upper = (5 * GameDiff + 9);
            int lower = (2 * GameDiff + 3);
            return rand.Next(lower, upper);
        }
        public int AttackCalc()
        {
            int upper = (PlayerAttack + 3);
            int lower = (PlayerAttack);
            return rand.Next(lower, upper);
        }
        public int DefendCalc()
        {
            int upper = (PlayerAttack / 2);
            int lower = (PlayerAttack / 3);
            return rand.Next(lower, upper);
        }

    }

}
