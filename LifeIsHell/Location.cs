﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeIsHell
{
    public class Location
    {
        Random rand = new Random();

        private frmStartGame frmStartGame;


        public void PlayerLocation(Player currentPlayer, TextBox mainScreen, PictureBox mainPicture) //this function will load the text and pictures for each block location
        {
            if (currentPlayer.PlayerLocX == 0 && currentPlayer.PlayerLocY == 0)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are standing at the center of Hell." + Environment.NewLine);
                mainScreen.AppendText("The screams of agony and pain echo in the distance." + Environment.NewLine);
                mainScreen.AppendText("You can see Tom's Gift Shop nearby.");

            }
            else if (currentPlayer.PlayerLocX == 1 && currentPlayer.PlayerLocY == 0)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);
                if (currentPlayer.CraneOneInteract == false)
                {
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText("You see a giant crane with a person in a cage over a lake of fire."
                        + Environment.NewLine +
                        "The crane lowers the person into the fire so they burn to death." +
                        Environment.NewLine +
                        "The crane lifts the cage back out of the fire and the person is reborn" +
                        Environment.NewLine +
                        "The process is then repeated over and over again." + Environment.NewLine +
                        "There is a lake of fire to your East.");

                }
                else if (currentPlayer.CraneOneInteract == true && currentPlayer.CraneGuyOne == false)
                {
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText(Environment.NewLine +
                        "There is a crane with a person in a cage over a lake of lava." + Environment.NewLine +
                        "There is a lake of fire to your East.");

                }

            }
            if (currentPlayer.PlayerLocX == 1 && currentPlayer.PlayerLocY == 1)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are near the center of Hell" + Environment.NewLine + "There is a lake of fire to your Southeast.");

            }
            if (currentPlayer.PlayerLocX == 0 && currentPlayer.PlayerLocY == 1)
            {

                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are near the center of Hell."
                    + Environment.NewLine
                    + "Tom's Gift Shop is to your South.");

            }
            if (currentPlayer.PlayerLocX == -1 && currentPlayer.PlayerLocY == 0)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You stand on the edge of a bottomless pit."
                        + Environment.NewLine
                        + "Far above you people are being dropped into the pit."
                        + Environment.NewLine
                        + "They scream as the going falling by into the pit.");



            }
            if (currentPlayer.PlayerLocX == -1 && currentPlayer.PlayerLocY == -1)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are near the center of Hell"
                    + Environment.NewLine
                    + "There is a sign in the distance to your West."
                    + Environment.NewLine
                    + "It is too far away to read.");

            }
            if (currentPlayer.PlayerLocX == 0 && currentPlayer.PlayerLocY == -1)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are near the center of Hell"
                    + Environment.NewLine
                    + "Tom's Gift Shop is to your North"
                    + Environment.NewLine
                    + "You see somthing glinting in the firelight to your South.");


            }
            if (currentPlayer.PlayerLocX == -1 && currentPlayer.PlayerLocY == 1)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are near the center of Hell."
                    + Environment.NewLine
                    + "You can hear screams coming from your Southwest.");

            }
            if (currentPlayer.PlayerLocX == 1 && currentPlayer.PlayerLocY == -1)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are near the center of Hell." + Environment.NewLine + "There is a lake of fire to your East.");

            }
            if (currentPlayer.PlayerLocX == 0 && currentPlayer.PlayerLocY == -2)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                if (currentPlayer.ChestOneOpen == false && currentPlayer.KeyOne == false)
                {
                    mainScreen.AppendText("There is a chest just sitting on the ground here."
                        + Environment.NewLine
                        + "The key must be around here somewhere.");
                }
                else if (currentPlayer.ChestOneOpen == true)
                {
                    mainScreen.AppendText("There is an open chest just sitting on the ground here.");
                }
                else if (currentPlayer.ChestOneOpen == false && currentPlayer.KeyOne == true)
                {
                    mainScreen.AppendText("There is a chest just sitting on the ground.");
                        
                }
            }
            if (currentPlayer.PlayerLocX == -2 && currentPlayer.PlayerLocY == 1)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are near the center of Hell."
                    + Environment.NewLine
                    + "There is a bottomless pit to your South."
                    + Environment.NewLine
                    + "People are being dropped into the pit from above.");
            }


        }
        public void SearchLocation(Player currentPlayer, TextBox mainScreen) //this function will check the square and return text when using the search button
        {
            if (currentPlayer.PlayerLocY == 0 && currentPlayer.PlayerLocX == 0)
            {
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(GetSearchText());
            }
            else if (currentPlayer.PlayerLocX == 1 && currentPlayer.PlayerLocY == 0)
            {
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(GetSearchText());
            }
            else
            {
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(GetSearchText());
            }
        }
        public void TalkLocation(Player currentPlayer, TextBox mainScreen) //this function will check the square and return text applicable to the talk button
        {

            if (currentPlayer.PlayerLocX == 1 && currentPlayer.PlayerLocY == 0)
            {
                if (currentPlayer.CraneOneInteract == false && currentPlayer.CraneGuyOne == false)
                {
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText("That person is busy dying repeatedly right now.");
                }
                else if (currentPlayer.CraneOneInteract == true)
                {
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText(Environment.NewLine +
                        "'Thanks for stopping the crane.'" +
                        Environment.NewLine +
                        "'I suppose now I just die of boredom over and over.'" +
                        Environment.NewLine +
                        "'That is waaaaaaaaay better.'");
                    currentPlayer.CraneGuyOne = true;
                }
                else if (currentPlayer.CraneGuyOne == true && currentPlayer.CraneOneInteract == false)
                {
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText("'You are one sick sick puppy!'");
                }
                else if (currentPlayer.PlayerLocX == -1 && currentPlayer.PlayerLocY == 0)
                {
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText("'HELLO...hello...h e l l o'"
                        + Environment.NewLine
                        + "You voice echoes off the sides of the pit, mixing with the screams of the dying.");
                }
            }
            else
            {
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine); mainScreen.AppendText(GetTalkText());
            }

        }
        public void InteractLocation(Player currentPlayer, TextBox mainScreen) //this function will check the square and return text applicable to the Interact button
        {
            if (currentPlayer.PlayerLocX == 0 && currentPlayer.PlayerLocY == 0)
            {
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("This is not the place for that.");
            }
            else if (currentPlayer.PlayerLocX == 1 && currentPlayer.PlayerLocY == 0)
            {
                if (currentPlayer.CraneOneInteract == false)
                {
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText("You turn the crane off." +
                        Environment.NewLine +
                        "'Thank you so much!'");
                    currentPlayer.CraneOneInteract = true;
                }
                else if (currentPlayer.CraneOneInteract == true)
                {
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText("You turn the crane on." +
                        Environment.NewLine +
                        "'AAAAHAHAHHAHHHHHHH'" +
                        Environment.NewLine +
                        "'WHY!?");
                    currentPlayer.CraneOneInteract = false;
                }
            }
            else if (currentPlayer.PlayerLocX == 1 && currentPlayer.PlayerLocY == 1)
            {
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You find a shovel and begin filling in the hole."
                    + Environment.NewLine
                    + "This could take a while.");
            }
            else if (currentPlayer.PlayerLocX == 1 && currentPlayer.PlayerLocY == 1)
            {
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You do not see anything to interact with.");
            }
            if (currentPlayer.PlayerLocX == 0 && currentPlayer.PlayerLocY == -2)
            {
                if (currentPlayer.ChestOneOpen == false && currentPlayer.KeyOne == true)
                {
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText("You open the chest and find 500 coins!");
                    currentPlayer.PlayerCoin += 500;
                    currentPlayer.ChestOneOpen = true;
                    currentPlayer.KeyOne = false;
                }
                if (currentPlayer.ChestOneOpen == false && currentPlayer.KeyOne == false)
                {
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText("It looks like it needs a key to open.");
                }
                else
                {
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText(GetInteractText());
                }
            }
            else
            {
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(GetInteractText());
            }
        }
        public void Getbuttons(int x, int y) //derived from https://social.msdn.microsoft.com/profile/barry%20wang
        {

            if (x == 1 && y == 0)
            {
                foreach (frmStartGame oForm1 in Application.OpenForms.OfType<frmStartGame>())
                {
                    oForm1.btnEast.Visible = false;
                }
                foreach (frmStartGame oForm1 in Application.OpenForms.OfType<frmStartGame>())
                {
                    oForm1.btnWest.Visible = true;
                }
                foreach (frmStartGame oForm1 in Application.OpenForms.OfType<frmStartGame>())
                {
                    oForm1.btnNorth.Visible = true;
                }
                foreach (frmStartGame oForm1 in Application.OpenForms.OfType<frmStartGame>())
                {
                    oForm1.btnSouth.Visible = true;
                }
            }
            else if (x == 1 && y == -1)
            {
                foreach (frmStartGame oForm1 in Application.OpenForms.OfType<frmStartGame>())
                {
                    oForm1.btnEast.Visible = false;
                }
                foreach (frmStartGame oForm1 in Application.OpenForms.OfType<frmStartGame>())
                {
                    oForm1.btnWest.Visible = true;
                }
                foreach (frmStartGame oForm1 in Application.OpenForms.OfType<frmStartGame>())
                {
                    oForm1.btnNorth.Visible = true;
                }
                foreach (frmStartGame oForm1 in Application.OpenForms.OfType<frmStartGame>())
                {
                    oForm1.btnSouth.Visible = true;
                }
            }
            else if (x == -1 && y == 0)
            {
                foreach (frmStartGame oForm1 in Application.OpenForms.OfType<frmStartGame>())
                {
                    oForm1.btnEast.Visible = true;
                }
                foreach (frmStartGame oForm1 in Application.OpenForms.OfType<frmStartGame>())
                {
                    oForm1.btnWest.Visible = false;
                }
                foreach (frmStartGame oForm1 in Application.OpenForms.OfType<frmStartGame>())
                {
                    oForm1.btnNorth.Visible = true;
                }
                foreach (frmStartGame oForm1 in Application.OpenForms.OfType<frmStartGame>())
                {
                    oForm1.btnSouth.Visible = true;
                }
            }
            else if (x == -2 && y == 1)
            {
                foreach (frmStartGame oForm1 in Application.OpenForms.OfType<frmStartGame>())
                {
                    oForm1.btnEast.Visible = true;
                }
                foreach (frmStartGame oForm1 in Application.OpenForms.OfType<frmStartGame>())
                {
                    oForm1.btnWest.Visible = false;
                }
                foreach (frmStartGame oForm1 in Application.OpenForms.OfType<frmStartGame>())
                {
                    oForm1.btnNorth.Visible = true;
                }
                foreach (frmStartGame oForm1 in Application.OpenForms.OfType<frmStartGame>())
                {
                    oForm1.btnSouth.Visible = false;
                }
            }
            else
            {
                foreach (frmStartGame oForm1 in Application.OpenForms.OfType<frmStartGame>())
                {
                    oForm1.btnEast.Visible = true;
                }
                foreach (frmStartGame oForm1 in Application.OpenForms.OfType<frmStartGame>())
                {
                    oForm1.btnWest.Visible = true;
                }
                foreach (frmStartGame oForm1 in Application.OpenForms.OfType<frmStartGame>())
                {
                    oForm1.btnNorth.Visible = true;
                }
                foreach (frmStartGame oForm1 in Application.OpenForms.OfType<frmStartGame>())
                {
                    oForm1.btnSouth.Visible = true;
                }
            }
        }
        public static string GetSearchText()
        {
            Random rand = new Random();
            string[] statement =
            {
                "You find nothing of interest.",
                "Nada.",
                "Zilch.",
                "Nothing here.",
                "Nothing to find.",
                "Not alot going on here.",
                "You find some lint in your bellybutton",
                "You found something!" + Environment.NewLine + "Oh wait. It's nothing.",
                "Nothing of note."
            };
            return statement[rand.Next(0, 9)];
        }
        public static string GetTalkText()
        {
            Random rand = new Random();
            string[] statement =
            {
                "There is no one to talk to.",
                "You are alone.",
                "I guess you could talk to yourself.",
                "You say something to yourself, because you are the only person here.",
                "'Hello World'",
                "Crickets.",
                "ECHO, echo, e c h o.",
                "Talking to yourself is a sign of dementia.",
                "Talk to who?."
            };
            return statement[rand.Next(0, 9)];
        }
        public static string GetInteractText()
        {
            Random rand = new Random();
            string[] statement =
            {
                "Don't interact with yourself in public.",
                "You tap your foot.",
                "You look for something to push over and find nothing.",
                "There is nothing to interact with.",
                "Nothing is nearby.",
                "Not going to happen.",
                "You look for a button to push and find none.",
                "You look for a knob to twist and find none.",
                "There has to be on switch somewhere....",
                "You look around. Nothing is nearby."

            };
            return statement[rand.Next(0,10)];
        }




    }
}
