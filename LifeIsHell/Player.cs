using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LifeIsHell
{

    public class Player
   
    {
        Random random = new Random();
        public string PlayerName = "";
        public int SaveCounter = 0;
        public int PlayerCoin = 0;
        public int PlayerLocX = 0;
        public int PlayerLocY = 0;
        public int PlayerAttack = 1;
        public int PlayerHealth = 10;
        public int PlayerArmor = 1;
        public int GameDiff = 1;
        public int FormerPlayerLocX = 0;
        public int FormerPlayerLocY = 0;
        public int PlayerPotions = 5;
        public int EnemyPower()
        {
            Random rand = new Random();
            int upper = (2 * GameDiff + 2);
            int lower = (1 * GameDiff + GameDiff / 2);
            return rand.Next(lower, upper);
        }
        public int EnemyHealth()
        {
            Random rand = new Random();
            int upper = (4 * GameDiff + 5);
            int lower = (2 * GameDiff);
            return rand.Next(lower, upper);
        }
        public int WinCoins()
        {
            Random rand = new Random();
            int upper = (5 * GameDiff + 9);
            int lower = (2 * GameDiff + 3);
            return rand.Next(lower, upper);
        }
        public int AttackCalc()
        {
            Random random = new Random();
            int upper = (PlayerAttack + 3);
            int lower = (PlayerAttack);
            return random.Next(lower, upper);
        }
        public int DefendCalc()
        {
            Random random = new Random();
            int upper = (PlayerAttack / 2);
            int lower = (PlayerAttack / 3);
            return random.Next(lower, upper);
        }
            
    }


}
