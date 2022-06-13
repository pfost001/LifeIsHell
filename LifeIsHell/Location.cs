﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeIsHell
{
    public class Location
    {
      
        public void PlayerLocation(Player currentPlayer, TextBox mainScreen, PictureBox mainPicture) //this function will load the text and pictures for each block location
        {
            if (currentPlayer.PlayerLocX == 0 && currentPlayer.PlayerLocY == 0)
            {
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("This is the location 0, 0.");
                
            }
            
        }
        public void SearchLocation(Player currentPlayer, TextBox mainScreen) //this function will check the square and return text when using the search button
        {
            if (currentPlayer.PlayerLocY == 0 && currentPlayer.PlayerLocX == 0)
            {
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("There is nothing to find here.");
            }
        }
        public void TalkLocation(Player currentPlayer, TextBox mainScreen) //this function will check the square and return text applicable to the talk button
        {
            if (currentPlayer.PlayerLocX == 0 && currentPlayer.PlayerLocY == 0)
            {
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("There is no one to talk to.");
            }

        }
        public void InteractLocation(Player currentPlayer, TextBox mainScreen) //this function will check the square and return text applicable to the Interact button
        {
            if (currentPlayer.PlayerLocX == 0 && currentPlayer.PlayerLocY == 0)
            {
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("Don't interact with yourself in public.");
            }
        }
            
    }
}