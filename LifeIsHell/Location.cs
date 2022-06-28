using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeIsHell
{
    public class Location
    {
        Random rand = new Random();

        public frmStartGame frmStartGame;

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
                else if (currentPlayer.CraneOneInteract == true)
                {
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText(Environment.NewLine +
                        "There is a crane with a person in a cage over a lake of lava."
                        + Environment.NewLine
                        + "There is a lake of fire to your East.");

                }

            }
            else if (currentPlayer.PlayerLocX == 1 && currentPlayer.PlayerLocY == 1)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in central Hell."
                    + Environment.NewLine
                    + "There is a lake of fire to your Southeast.");

            }
            else if (currentPlayer.PlayerLocX == 0 && currentPlayer.PlayerLocY == 1)
            {

                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are near the center of Hell."
                    + Environment.NewLine
                    + "Tom's Gift Shop is to your South.");

            }
            else if (currentPlayer.PlayerLocX == -1 && currentPlayer.PlayerLocY == 0)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You stand on the edge of a bottomless pit."
                        + Environment.NewLine
                        + "Far above you people are being dropped into the pit."
                        + Environment.NewLine
                        + "They scream as the going falling by into the pit."
                        + Environment.NewLine
                        + "Tom's Gift Shop is to your East");
            }
            else if (currentPlayer.PlayerLocX == -1 && currentPlayer.PlayerLocY == -1)
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
            else if (currentPlayer.PlayerLocX == 0 && currentPlayer.PlayerLocY == -1)
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
            else if (currentPlayer.PlayerLocX == -1 && currentPlayer.PlayerLocY == 1)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in central Hell."
                    + Environment.NewLine
                    + "You can hear screams coming from your Southwest.");

            }
            else if (currentPlayer.PlayerLocX == 1 && currentPlayer.PlayerLocY == -1)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in central Hell." + Environment.NewLine + "There is a lake of fire to your East.");

            }
            else if (currentPlayer.PlayerLocX == 0 && currentPlayer.PlayerLocY == -2)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                if (currentPlayer.ChestOneOpen == false && currentPlayer.KeyOne == false)
                {
                    mainScreen.AppendText("There is a bronze chest just sitting on the ground here."
                        + Environment.NewLine
                        + "The key must be somewhere nearby.");
                }
                else if (currentPlayer.ChestOneOpen == true)
                {
                    mainScreen.AppendText("There is an open chest just sitting on the ground here.");
                }
                else if (currentPlayer.ChestOneOpen == false && currentPlayer.KeyOne == true)
                {
                    mainScreen.AppendText("There is a bronze chest just sitting on the ground.");

                }
            }
            else if (currentPlayer.PlayerLocX == -2 && currentPlayer.PlayerLocY == 1)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in central Hell."
                    + Environment.NewLine
                    + "There is a bottomless pit to your South."
                    + Environment.NewLine
                    + "People are being dropped into the pit from above.");
            }
            else if (currentPlayer.PlayerLocX == 1 && currentPlayer.PlayerLocY == 2)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in central Hell.");
            }
            else if (currentPlayer.PlayerLocX == 2 && currentPlayer.PlayerLocY == 2)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in central Hell.");
            }
            else if (currentPlayer.PlayerLocX == 3 && currentPlayer.PlayerLocY == 2)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in central Hell."
                    + Environment.NewLine
                    + "You stand tall above a forest of dancing pickles."
                    + Environment.NewLine
                    + "You are not sure what this has to do with Hell"
                    + Environment.NewLine
                    + "Probably some newbie programmer's kid asked them to put it in.");
            }
            else if (currentPlayer.PlayerLocX == 4 && currentPlayer.PlayerLocY == 2)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in central Hell.");
            }
            else if (currentPlayer.PlayerLocX == 2 && currentPlayer.PlayerLocY == 1)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in central Hell." +
                    Environment.NewLine
                    + "There is a lake of fire to your South.");
            }
            else if (currentPlayer.PlayerLocX == 3 && currentPlayer.PlayerLocY == 1)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in central Hell."
                    + Environment.NewLine
                    + "There is a small beach along the lake of fire."
                    + Environment.NewLine
                    + "You can walk all the way down to the lake.");
            }
            else if (currentPlayer.PlayerLocX == 4 && currentPlayer.PlayerLocY == 1)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in central Hell.");
            }
            else if (currentPlayer.PlayerLocX == 4 && currentPlayer.PlayerLocY == 0)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in central Hell." + Environment.NewLine + "There is a lake of fire to your West.");
            }
            else if (currentPlayer.PlayerLocX == 4 && currentPlayer.PlayerLocY == 0)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in central Hell." + Environment.NewLine + "There is a lake of fire to your West.");
            }
            else if (currentPlayer.PlayerLocX == 4 && currentPlayer.PlayerLocY == -2)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in central Hell.");
            }
            else if (currentPlayer.PlayerLocX == 4 && currentPlayer.PlayerLocY == -3)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in central Hell."
                    + Environment.NewLine
                    + "You see a fair of some sort far to your South.");
            }
            else if (currentPlayer.PlayerLocX == 3 && currentPlayer.PlayerLocY == -3)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in central Hell.");
            }
            else if (currentPlayer.PlayerLocX == 2 && currentPlayer.PlayerLocY == -2)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in central Hell."
                    + Environment.NewLine
                    + "There is a lake of fire to your North.");
            }
            else if (currentPlayer.PlayerLocX == 3 && currentPlayer.PlayerLocY == -2)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in central Hell."
                    + Environment.NewLine
                    + "There is a lake of fire to your North.");
            }
            else if (currentPlayer.PlayerLocX == 4 && currentPlayer.PlayerLocY == -1)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in central Hell."
                    + Environment.NewLine
                    + "There is a lake of fire to your West");
            }
            else if (currentPlayer.PlayerLocX == 2 && currentPlayer.PlayerLocY == -3)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in central Hell.");
            }
            else if (currentPlayer.PlayerLocX == 1 && currentPlayer.PlayerLocY == -3)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in central Hell.");
            }
            else if (currentPlayer.PlayerLocX == 1 && currentPlayer.PlayerLocY == -2)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in central Hell."
                    + Environment.NewLine
                    + "You see something glinting in the firelight to your West.");
            }
            else if (currentPlayer.PlayerLocX == -1 && currentPlayer.PlayerLocY == -2)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in central Hell."
                    + Environment.NewLine
                    + "You see something glinting in the firelight to your East.");
            }
            else if (currentPlayer.PlayerLocX == 0 && currentPlayer.PlayerLocY == -3)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in central Hell.");
            }
            else if (currentPlayer.PlayerLocX == -1 && currentPlayer.PlayerLocY == -3)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in central Hell.");
            }
            else if (currentPlayer.PlayerLocX == -2 && currentPlayer.PlayerLocY == -3)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in central Hell."
                    + Environment.NewLine
                    + "You see a tower rising above the horizon to your Southwest.");
            }
            else if (currentPlayer.PlayerLocX == -3 && currentPlayer.PlayerLocY == -3)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in central Hell."
                    + Environment.NewLine
                    + "You see a tower rising above the horizon to your South.");
            }
            else if (currentPlayer.PlayerLocX == -4 && currentPlayer.PlayerLocY == -3)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in central Hell."
                    + Environment.NewLine
                    + "You see a tower rising above the horizon to your Southeast."
                    + Environment.NewLine
                    + "There is a stone wall to your North.");
            }
            else if (currentPlayer.PlayerLocX == -4 && currentPlayer.PlayerLocY == -4)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in southern Hell."
                    + Environment.NewLine
                    + "You see a tower rising above the horizon to your East.");
            }
            else if (currentPlayer.PlayerLocX == -4 && currentPlayer.PlayerLocY == -5)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in southern Hell."
                    + Environment.NewLine
                    + "You see a tower rising above the horizon to your Northeast.");
            }
            else if (currentPlayer.PlayerLocX == -3 && currentPlayer.PlayerLocY == -5)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in southern Hell."
                    + Environment.NewLine
                    + "You see a tower rising above the horizon to your North.");
            }
            else if (currentPlayer.PlayerLocX == -2 && currentPlayer.PlayerLocY == -5)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in southern Hell."
                    + Environment.NewLine
                    + "You see a tower rising above the horizon to your Northwest.");
            }
            else if (currentPlayer.PlayerLocX == -2 && currentPlayer.PlayerLocY == -4)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in central Hell."
                    + Environment.NewLine
                    + "You see a tower rising above the horizon to your West."
                    + Environment.NewLine
                    + "There is a river of fire to your East.");
            }
            else if (currentPlayer.PlayerLocX == -2 && currentPlayer.PlayerLocY == -2)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in central Hell.");
            }
            else if (currentPlayer.PlayerLocX == -3 && currentPlayer.PlayerLocY == -2)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in central Hell."
                    + Environment.NewLine
                    + "There is a sign to your North."
                    + Environment.NewLine
                    + "There is a stone wall to your West.");
            }
            else if (currentPlayer.PlayerLocX == -3 && currentPlayer.PlayerLocY == -1)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in central Hell."
                    + Environment.NewLine
                    + "There is a sign that says 'Petting Zoo' and an arrow points West.");
            }
            else if (currentPlayer.PlayerLocX == -2 && currentPlayer.PlayerLocY == -1)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in central Hell."
                    + Environment.NewLine
                    + "There is a bottomless pit to your North."
                    + Environment.NewLine
                    + "There is a sign to your West.");
            }
            else if (currentPlayer.PlayerLocX == -3 && currentPlayer.PlayerLocY == 0)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in central Hell."
                    + Environment.NewLine
                    + "There is a bottomless pit to your East."
                    + Environment.NewLine
                    + "There is a stone wall to your West.");
            }
            else if (currentPlayer.PlayerLocX == -4 && currentPlayer.PlayerLocY == 0)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in the petting zoo."
                    + Environment.NewLine
                    + "There is a stone wall to your North and East.");
            }
            else if (currentPlayer.PlayerLocX == -5 && currentPlayer.PlayerLocY == 0)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in the petting zoo."
                    + Environment.NewLine
                    + "There is a stone wall to your North.");
            }
            else if (currentPlayer.PlayerLocX == -6 && currentPlayer.PlayerLocY == 0)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in the petting zoo."
                    + Environment.NewLine
                    + "There are people tied to posts scattered through the area."
                    + Environment.NewLine
                    + "Monkeys with swords hop around decapating people."
                    + Environment.NewLine
                    + "The people are then reborn for the process to repeat itself."
                    + Environment.NewLine
                    + "There is a stone wall to your North and West.");
            }
            else if (currentPlayer.PlayerLocX == -4 && currentPlayer.PlayerLocY == -1)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in the petting zoo."
                    + Environment.NewLine
                    + "There are people tied to posts scattered through the area."
                    + Environment.NewLine
                    + "Undying killer bees swarm all over the people, stinging them to death."
                    + Environment.NewLine
                    + "The people are then reborn for the process to repeat itself."
                    + Environment.NewLine);
            }
            else if (currentPlayer.PlayerLocX == -5 && currentPlayer.PlayerLocY == -1)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in the petting zoo."
                    + Environment.NewLine
                    + "There are people tied to posts scattered through the area."
                    + Environment.NewLine
                    + "Roaches crawl all over the people, entering their mouths and suffocating them."
                    + Environment.NewLine
                    + "The people are then reborn for the process to repeat itself.");
            }
            else if (currentPlayer.PlayerLocX == -6 && currentPlayer.PlayerLocY == -1)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in the petting zoo."
                    + Environment.NewLine
                    + "There are people tied to posts scattered through the area."
                    + Environment.NewLine
                    + "Snakes crawl all over the people, biting them repeatedly until they die."
                    + Environment.NewLine
                    + "The people are then reborn for the process to repeat itself."
                    + Environment.NewLine
                    + "There is a stone wall to your West.");
            }
            else if (currentPlayer.PlayerLocX == -6 && currentPlayer.PlayerLocY == -2)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in the petting zoo."
                    + Environment.NewLine
                    + "There is a stone wall to your South and West.");
            }
            else if (currentPlayer.PlayerLocX == -5 && currentPlayer.PlayerLocY == -2)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in the petting zoo."
                    + Environment.NewLine
                    + "There are people tied to posts scattered through the area."
                    + Environment.NewLine
                    + "Spiders cover the skin of their victims while biting them to death."
                    + Environment.NewLine
                    + "The people are then reborn for the process to repeat itself."
                    + Environment.NewLine
                    + "There is a stone wall to your South.");
            }
            else if (currentPlayer.PlayerLocX == -4 && currentPlayer.PlayerLocY == -2)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in the petting zoo."
                    + Environment.NewLine
                    + "There are people tied to posts scattered through the area."
                    + Environment.NewLine
                    + "Ants swarm over the people, slowly biting them to death."
                    + Environment.NewLine
                    + "The people are then reborn for the process to repeat itself."
                    + Environment.NewLine
                    + "There is a stone wall to your South and East.");
            }
            else if (currentPlayer.PlayerLocX == -2 && currentPlayer.PlayerLocY == 2)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in central Hell.");
            }
            else if (currentPlayer.PlayerLocX == -1 && currentPlayer.PlayerLocY == 2)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in central Hell.");
            }
            else if (currentPlayer.PlayerLocX == -2 && currentPlayer.PlayerLocY == 2)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in central Hell.");
            }
            else if (currentPlayer.PlayerLocX == -2 && currentPlayer.PlayerLocY == 3)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in northern Hell.");
            }
            else if (currentPlayer.PlayerLocX == -1 && currentPlayer.PlayerLocY == 3)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in northern Hell.");
            }
            else if (currentPlayer.PlayerLocX == 0 && currentPlayer.PlayerLocY == 3)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in northern Hell.");
            }
            else if (currentPlayer.PlayerLocX == 0 && currentPlayer.PlayerLocY == 2)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in central Hell.");
            }
            else if (currentPlayer.PlayerLocX == 5 && currentPlayer.PlayerLocY == 2)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in central Hell."
                    + Environment.NewLine
                    + "There see large spikes sticking out of the ground to your East.");
            }
            else if (currentPlayer.PlayerLocX == 5 && currentPlayer.PlayerLocY == 1)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in central Hell."
                    + Environment.NewLine
                    + "There see large spikes sticking out of the ground to your East.");
            }
            else if (currentPlayer.PlayerLocX == 5 && currentPlayer.PlayerLocY == 0)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in central Hell."
                    + Environment.NewLine
                    + "There see large spikes sticking out of the ground to your East.");
            }
            else if (currentPlayer.PlayerLocX == 5 && currentPlayer.PlayerLocY == -1)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in central Hell."
                    + Environment.NewLine
                    + "There see large spikes sticking out of the ground to your East.");
            }
            else if (currentPlayer.PlayerLocX == 5 && currentPlayer.PlayerLocY == -2)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in central Hell.");
            }
            else if (currentPlayer.PlayerLocX == 5 && currentPlayer.PlayerLocY == -3)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in central Hell.");
            }
            else if (currentPlayer.PlayerLocX == 5 && currentPlayer.PlayerLocY == -3)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in the Spike Fields."
                    + Environment.NewLine
                    + "There are bodies impaled on large spikes all around you.");
            }
            else if (currentPlayer.PlayerLocX == 6 && currentPlayer.PlayerLocY == 3)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in the Spike Fields."
                    + Environment.NewLine
                    + "There are bodies impaled on large spikes all around you.");
            }
            else if (currentPlayer.PlayerLocX == 7 && currentPlayer.PlayerLocY == 3)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in the Spike Fields."
                    + Environment.NewLine
                    + "There are bodies impaled on large spikes all around you.");
            }
            else if (currentPlayer.PlayerLocX == 8 && currentPlayer.PlayerLocY == 3)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in the Spike Fields."
                    + Environment.NewLine
                    + "There are bodies impaled on large spikes all around you.");
            }
            else if (currentPlayer.PlayerLocX == 9 && currentPlayer.PlayerLocY == 3)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in the Spike Fields."
                    + Environment.NewLine
                    + "There are bodies impaled on large spikes all around you.");
            }
            else if (currentPlayer.PlayerLocX == 10 && currentPlayer.PlayerLocY == 3)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);
                if (currentPlayer.HealthElixerUp == false)
                {
                    
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText("You are in the Spike Fields."
                        + Environment.NewLine
                        + "There are bodies impaled on large spikes all around you."
                        + Environment.NewLine
                        + "There is a small bottle of red liquid at your feet.");
                }
                else
                {
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText("You are in the Spike Fields."
                        + Environment.NewLine
                        + "There are bodies impaled on large spikes all around you.");
                }
            }
            else if (currentPlayer.PlayerLocX == 6 && currentPlayer.PlayerLocY == 2)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in the Spike Fields."
                    + Environment.NewLine
                    + "There are bodies impaled on large spikes all around you.");
            }
            else if (currentPlayer.PlayerLocX == 7 && currentPlayer.PlayerLocY == 2)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in the Spike Fields."
                    + Environment.NewLine
                    + "There are bodies impaled on large spikes all around you.");
            }
            else if (currentPlayer.PlayerLocX == 8 && currentPlayer.PlayerLocY == 2)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in the Spike Fields."
                    + Environment.NewLine
                    + "There are bodies impaled on large spikes all around you.");
            }
            else if (currentPlayer.PlayerLocX == 9 && currentPlayer.PlayerLocY == 2)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in the Spike Fields."
                    + Environment.NewLine
                    + "There are bodies impaled on large spikes all around you.");
            }
            else if (currentPlayer.PlayerLocX == 10 && currentPlayer.PlayerLocY == 2)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in the Spike Fields."
                    + Environment.NewLine
                    + "There are bodies impaled on large spikes all around you.");
            }
            else if (currentPlayer.PlayerLocX == 6 && currentPlayer.PlayerLocY == 1)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in the Spike Fields."
                    + Environment.NewLine
                    + "There are bodies impaled on large spikes all around you.");
            }
            else if (currentPlayer.PlayerLocX == 7 && currentPlayer.PlayerLocY == 1)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in the Spike Fields."
                    + Environment.NewLine
                    + "There are bodies impaled on large spikes all around you.");
            }
            else if (currentPlayer.PlayerLocX == 8 && currentPlayer.PlayerLocY == 1)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in the Spike Fields."
                    + Environment.NewLine
                    + "There are bodies impaled on large spikes all around you.");
            }
            else if (currentPlayer.PlayerLocX == 9 && currentPlayer.PlayerLocY == 1)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in the Spike Fields."
                    + Environment.NewLine
                    + "There are bodies impaled on large spikes all around you.");
            }
            else if (currentPlayer.PlayerLocX == 10 && currentPlayer.PlayerLocY == 1)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in the Spike Fields."
                    + Environment.NewLine
                    + "There are bodies impaled on large spikes all around you.");
            }
            else if (currentPlayer.PlayerLocX == 6 && currentPlayer.PlayerLocY == 0)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in the Spike Fields."
                    + Environment.NewLine
                    + "There are bodies impaled on large spikes all around you.");
            }
            else if (currentPlayer.PlayerLocX == 7 && currentPlayer.PlayerLocY == 0)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in the Spike Fields."
                    + Environment.NewLine
                    + "There are bodies impaled on large spikes all around you.");
            }
            else if (currentPlayer.PlayerLocX == 8 && currentPlayer.PlayerLocY == 0)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);
                if (currentPlayer.SwordofDestiny == false)
                {
                    

                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText("You are in the Spike Fields."
                        + Environment.NewLine
                        + "There are bodies impaled on large spikes all around you."
                        + Environment.NewLine
                        + "There is a sword hilt sticking out of the ground.");
                }
                else
                {
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText("You are in the Spike Fields."
                        + Environment.NewLine
                        + "There are bodies impaled on large spikes all around you."
                        + Environment.NewLine
                        + "Your old sword is laying on the ground.");
                }
            }
            else if (currentPlayer.PlayerLocX == 9 && currentPlayer.PlayerLocY == 0)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in the Spike Fields."
                    + Environment.NewLine
                    + "There are bodies impaled on large spikes all around you.");
            }
            else if (currentPlayer.PlayerLocX == 10 && currentPlayer.PlayerLocY == 0)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in the Spike Fields."
                    + Environment.NewLine
                    + "There are bodies impaled on large spikes all around you.");
            }
            else if (currentPlayer.PlayerLocX == 6 && currentPlayer.PlayerLocY == -1)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in the Spike Fields."
                    + Environment.NewLine
                    + "There are bodies impaled on large spikes all around you.");
            }
            else if (currentPlayer.PlayerLocX == 7 && currentPlayer.PlayerLocY == -1)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in the Spike Fields."
                    + Environment.NewLine
                    + "There are bodies impaled on large spikes all around you.");
            }
            else if (currentPlayer.PlayerLocX == 8 && currentPlayer.PlayerLocY == -1)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in the Spike Fields."
                    + Environment.NewLine
                    + "There are bodies impaled on large spikes all around you.");
            }
            else if (currentPlayer.PlayerLocX == 9 && currentPlayer.PlayerLocY == -1)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);

                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in the Spike Fields."
                    + Environment.NewLine
                    + "There are bodies impaled on large spikes all around you.");
            }
            else if (currentPlayer.PlayerLocX == 10 && currentPlayer.PlayerLocY == -1)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in the Spike Fields."
                    + Environment.NewLine
                    + "There are bodies impaled on large spikes all around you.");
            }
            else if (currentPlayer.PlayerLocX == 5 && currentPlayer.PlayerLocY == -4)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in Southern Hell."
                    + Environment.NewLine
                    + "There is a poster marked 'PUNishment Poster' on a wall to your South."
                    + Environment.NewLine
                    + "There is a smiling face on the poster that looks lifelike.");
            }
            else if (currentPlayer.PlayerLocX == 5 && currentPlayer.PlayerLocY == -5)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in Medival Fun Land"
                    + Environment.NewLine
                    + "There are people chained to the wall being disembowled."
                    + Environment.NewLine
                    + "After their agonziing death they are reborn to experience it again.");
            }
            else if (currentPlayer.PlayerLocX == 1 && currentPlayer.PlayerLocY == -4)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in Southern Hell"
                    + Environment.NewLine
                    + "There is a river of fire to your South.");
            }
            else if (currentPlayer.PlayerLocX == 2 && currentPlayer.PlayerLocY == -4)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in Southern Hell"
                    + Environment.NewLine
                    + "There is a river of fire to your South");
            }
            else if (currentPlayer.PlayerLocX == 3 && currentPlayer.PlayerLocY == -4)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in Southern Hell"
                    + Environment.NewLine
                    + "There is a sign to your East."
                    + Environment.NewLine
                    + "There is a stone wall to your South.");
            }
            else if (currentPlayer.PlayerLocX == 4 && currentPlayer.PlayerLocY == -4)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("There is a sign that says 'Meidval Fun Land'"
                    + Environment.NewLine
                    + "The arrow on the sign points to the South.");
            }
            else if (currentPlayer.PlayerLocX == 4 && currentPlayer.PlayerLocY == -5)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in Medival Fun Land"
                    + Environment.NewLine
                    + "There are people being quartered by pullys and ropes."
                    + Environment.NewLine
                    + "After being ripped apart they are reborn to be torn apart again.");
            }
            else if (currentPlayer.PlayerLocX == 3 && currentPlayer.PlayerLocY == -5)
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You are in Medival Fun Land"
                    + Environment.NewLine
                    + "There is a stone wall to your North and West.");
            }
            else
            {
                Getbuttons(currentPlayer.PlayerLocX, currentPlayer.PlayerLocY);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("I haven't programmed this square yet.");
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
            else if (currentPlayer.PlayerLocX == 3 && currentPlayer.PlayerLocY == 2)
            {
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("A forest of dancing pickles."
                    + Environment.NewLine
                    + "Something about the way they move is a little nauseating.");
            }
            else if (currentPlayer.PlayerLocX == 4 && currentPlayer.PlayerLocY == -1)
            {
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You find the Chalice of Endless Fire!"
                    + Environment.NewLine
                    + "Despite the name, the cup is empty.");
                currentPlayer.FireChaliceOwn = true;
            }
            else if (currentPlayer.PlayerLocX == 2 && currentPlayer.PlayerLocY == -2)
            {
                if (currentPlayer.RedOrbUp == false && currentPlayer.RedOrbInserted == false)
                {
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText("You find a red orb laying on the ground."
                        + Environment.NewLine
                        + "It is roughly the size of a golfball."
                        + Environment.NewLine
                        + "You pick it up.");
                    currentPlayer.RedOrbUp = true;
                }
                else
                {
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText(GetSearchText());
                }
            }
            else if (currentPlayer.PlayerLocX == -1 && currentPlayer.PlayerLocY == 2)
            {
                if (currentPlayer.BlueOrbUp == false && currentPlayer.BlueOrbInserted == false)
                {
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText("You find a blue orb laying on the ground."
                        + Environment.NewLine
                        + "It is roughly the size of a golfball."
                        + Environment.NewLine
                        + "You pick it up.");
                    currentPlayer.BlueOrbUp = true;
                }
                else
                {
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText(GetSearchText());
                }
            }
            else if (currentPlayer.PlayerLocX == -5 && currentPlayer.PlayerLocY == 0)
            {
                if (currentPlayer.PurpleOrbUp == false && currentPlayer.PurpleOrbInserted == false)
                {
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText("You find a purple orb laying on the ground."
                        + Environment.NewLine
                        + "It is roughly the size of a golfball."
                        + Environment.NewLine
                        + "You pick it up.");
                    currentPlayer.PurpleOrbUp = true;
                }
                else
                {
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText(GetSearchText());
                }
            }
            else if (currentPlayer.PlayerLocX == -5 && currentPlayer.PlayerLocY == 0)
            {
                if (currentPlayer.GreenOrbUp == false && currentPlayer.GreenOrbInserted == false)
                {
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText("You find a green orb laying on the ground."
                        + Environment.NewLine
                        + "It is roughly the size of a golfball."
                        + Environment.NewLine
                        + "You pick it up.");
                    currentPlayer.GreenOrbUp = true;
                }
                else
                {
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText(GetSearchText());
                }
            }
            else if (currentPlayer.PlayerLocX == 10 && currentPlayer.PlayerLocY == 3)
            {
                if (currentPlayer.HealthElixerUp == false)
                {
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText("You see a vial of req liquid on the ground.");
                }
                else
                {
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText(GetSearchText());
                }
            }
            else if (currentPlayer.PlayerLocX == 9 && currentPlayer.PlayerLocY == 2)
            {
                if (currentPlayer.KeyOne == false)
                {
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText("You find a small bronze key laying on the ground."
                        + Environment.NewLine
                        + "You pick the key up.");
                    currentPlayer.KeyOne = true;
                }
                else
                {
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText(GetSearchText());
                }
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
            else if ((currentPlayer.PlayerLocX == 6 || 
                currentPlayer.PlayerLocX == 7 || 
                currentPlayer.PlayerLocX == 8 || 
                currentPlayer.PlayerLocX == 9 || 
                currentPlayer.PlayerLocX == 10) &&
                (currentPlayer.PlayerLocY == 3 ||
                currentPlayer.PlayerLocY == 2 ||
                currentPlayer.PlayerLocY == 1 ||
                currentPlayer.PlayerLocY == 0 ||
                currentPlayer.PlayerLocY == -1))
            {
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(SpikeFieldTalk());
            }
            else if (currentPlayer.PlayerLocX == 5 && currentPlayer.PlayerLocY == -4)
            {
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(PunishmentPoster());
            }
            else
            {
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine); 
                mainScreen.AppendText(GetTalkText());
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
            else if (currentPlayer.PlayerLocX == 0 && currentPlayer.PlayerLocY == -2)
            {
                if (currentPlayer.ChestOneOpen == false && currentPlayer.KeyOne == true)
                {
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText("You open the chest and find 500 coins!");
                    currentPlayer.PlayerCoin += 500;
                    currentPlayer.ChestOneOpen = true;
                    
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
            else if (currentPlayer.PlayerLocX == 3 && currentPlayer.PlayerLocY == 2)
            {
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText(Environment.NewLine);
                mainScreen.AppendText("You try to grab a pickle"
                    + Environment.NewLine
                    + "'Hands off weirdo!'");
            }
            else if (currentPlayer.PlayerLocX == 3 && currentPlayer.PlayerLocY == 1)
            {
                if (currentPlayer.FireChaliceOwn == true && currentPlayer.FireChaliceFull == false)
                {
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText("You dip the Chalice of Endless Fire into the fire lake."
                        + Environment.NewLine
                        + "The chalice is now full of liquid fire."
                        + Environment.NewLine
                        + "Words begin to glow on the sides."
                        + Environment.NewLine
                        + "'Caution: Contents Hot'");

                }
                else if (currentPlayer.FireChaliceOwn == false)
                {
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText("You have no cup to fill.");
                }
                else if (currentPlayer.FireChaliceOwn == true && currentPlayer.FireChaliceFull == true)
                {
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText("The chalice is full.");
                }
                else if (currentPlayer.FireChalicePour == true)
                {
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText("You don't think you need any more liquid fire.");
                }
            }
            else if (currentPlayer.PlayerLocX == 10 && currentPlayer.PlayerLocY == 3)
            {
                if (currentPlayer.HealthElixerUp == false)
                {
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText("You drink the red liquid. It tastes pretty good.");
                    currentPlayer.PlayerHealth = currentPlayer.PlayerHealth + 10;
                }
                else
                {
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText(GetInteractText());
                }
            }
            else if (currentPlayer.PlayerLocX == 8 && currentPlayer.PlayerLocY == 0)
            {
                if (currentPlayer.SwordofDestiny == false)
                {
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText(Environment.NewLine);
                    mainScreen.AppendText("You take the Sword of Destiny."
                        + Environment.NewLine
                        + "It makes you feel kind of like a bad ass.");
                    currentPlayer.SwordofDestiny = true;
                    currentPlayer.PlayerAttack = currentPlayer.PlayerAttack + 5;
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
            else if (x == 1 && y == 2)
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
                    oForm1.btnNorth.Visible = false;
                }
                foreach (frmStartGame oForm1 in Application.OpenForms.OfType<frmStartGame>())
                {
                    oForm1.btnSouth.Visible = true;
                }
            }
            else if (x == 2 && y == 2)
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
                    oForm1.btnNorth.Visible = false;
                }
                foreach (frmStartGame oForm1 in Application.OpenForms.OfType<frmStartGame>())
                {
                    oForm1.btnSouth.Visible = true;
                }
            }
            else if (x == 3 && y == 2)
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
                    oForm1.btnNorth.Visible = false;
                }
                foreach (frmStartGame oForm1 in Application.OpenForms.OfType<frmStartGame>())
                {
                    oForm1.btnSouth.Visible = true;
                }
            }
            else if (x == 4 && y == 2)
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
                    oForm1.btnNorth.Visible = false;
                }
                foreach (frmStartGame oForm1 in Application.OpenForms.OfType<frmStartGame>())
                {
                    oForm1.btnSouth.Visible = true;
                }
            }
            else if (x == 2 && y == 1)
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
                    oForm1.btnSouth.Visible = false;
                }
            }
            else if (x == 3 && y == 1)
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
                    oForm1.btnSouth.Visible = false;
                }
            }
            else if (x == 4 && y == 0)
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
            else if (x == 4 && y == -1)
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
            else if (x == 2 && y == -2)
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
                    oForm1.btnNorth.Visible = false;
                }
                foreach (frmStartGame oForm1 in Application.OpenForms.OfType<frmStartGame>())
                {
                    oForm1.btnSouth.Visible = true;
                }
            }
            else if (x == 3 && y == -2)
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
                    oForm1.btnNorth.Visible = false;
                }
                foreach (frmStartGame oForm1 in Application.OpenForms.OfType<frmStartGame>())
                {
                    oForm1.btnSouth.Visible = true;
                }
            }
            else if (x == 0 && y == -3)
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
                    oForm1.btnSouth.Visible = false;
                }
            }
            else if (x == -1 && y == -3)
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
                    oForm1.btnSouth.Visible = false;
                }
            }
            else if (x == -4 && y == -3)
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
                    oForm1.btnNorth.Visible = false;
                }
                foreach (frmStartGame oForm1 in Application.OpenForms.OfType<frmStartGame>())
                {
                    oForm1.btnSouth.Visible = true;
                }
            }
            else if (x == -4 && y == -4)
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
            else if (x == -4 && y == -5)
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
                    oForm1.btnNorth.Visible = false;
                }
                foreach (frmStartGame oForm1 in Application.OpenForms.OfType<frmStartGame>())
                {
                    oForm1.btnSouth.Visible = false;
                }
            }
            else if (x == -3 && y == -5)
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
                    oForm1.btnNorth.Visible = false;
                }
                foreach (frmStartGame oForm1 in Application.OpenForms.OfType<frmStartGame>())
                {
                    oForm1.btnSouth.Visible = true;
                }
            }
            else if (x == -2 && y == -4)
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
            else if (x == -3 && y == -2)
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
            else if (x == -6 && y == -1)
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
            else if (x == -6 && y == 0)
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
                    oForm1.btnNorth.Visible = false;
                }
                foreach (frmStartGame oForm1 in Application.OpenForms.OfType<frmStartGame>())
                {
                    oForm1.btnSouth.Visible = true;
                }
            }
            else if (x == -5 && y == 0)
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
                    oForm1.btnNorth.Visible = false;
                }
                foreach (frmStartGame oForm1 in Application.OpenForms.OfType<frmStartGame>())
                {
                    oForm1.btnSouth.Visible = true;
                }
            }
            else if (x == -4 && y == 0)
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
                    oForm1.btnNorth.Visible = false;
                }
                foreach (frmStartGame oForm1 in Application.OpenForms.OfType<frmStartGame>())
                {
                    oForm1.btnSouth.Visible = true;
                }
            }
            else if (x == -6 && y == -2)
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
            else if (x == -5 && y == -2)
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
                    oForm1.btnSouth.Visible = false;
                }
            }
            else if (x == -4 && y == -2)
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
                    oForm1.btnSouth.Visible = false;
                }
            }
            else if (x == -2 && y == -1)
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
                    oForm1.btnNorth.Visible = false;
                }
                foreach (frmStartGame oForm1 in Application.OpenForms.OfType<frmStartGame>())
                {
                    oForm1.btnSouth.Visible = true;
                }
            }
            else if (x == -2 && y == 2)
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
            else if (x == -2 && y == 3)
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
            else if (x == -3 && y == 0)
            {
                foreach (frmStartGame oForm1 in Application.OpenForms.OfType<frmStartGame>())
                {
                    oForm1.btnEast.Visible = false;
                }
                foreach (frmStartGame oForm1 in Application.OpenForms.OfType<frmStartGame>())
                {
                    oForm1.btnWest.Visible = false;
                }
                foreach (frmStartGame oForm1 in Application.OpenForms.OfType<frmStartGame>())
                {
                    oForm1.btnNorth.Visible = false;
                }
                foreach (frmStartGame oForm1 in Application.OpenForms.OfType<frmStartGame>())
                {
                    oForm1.btnSouth.Visible = true;
                }
            }
            else if (x == 6 && y == 3)
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
                    oForm1.btnNorth.Visible = false;
                }
                foreach (frmStartGame oForm1 in Application.OpenForms.OfType<frmStartGame>())
                {
                    oForm1.btnSouth.Visible = true;
                }
            }
            else if (x == 7 && y == 3)
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
                    oForm1.btnNorth.Visible = false;
                }
                foreach (frmStartGame oForm1 in Application.OpenForms.OfType<frmStartGame>())
                {
                    oForm1.btnSouth.Visible = true;
                }
            }
            else if (x == 8 && y == 3)
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
                    oForm1.btnNorth.Visible = false;
                }
                foreach (frmStartGame oForm1 in Application.OpenForms.OfType<frmStartGame>())
                {
                    oForm1.btnSouth.Visible = true;
                }
            }
            else if (x == 9 && y == 3)
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
                    oForm1.btnNorth.Visible = false;
                }
                foreach (frmStartGame oForm1 in Application.OpenForms.OfType<frmStartGame>())
                {
                    oForm1.btnSouth.Visible = true;
                }
            }
            else if (x == 10 && y == 3)
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
                    oForm1.btnNorth.Visible = false;
                }
                foreach (frmStartGame oForm1 in Application.OpenForms.OfType<frmStartGame>())
                {
                    oForm1.btnSouth.Visible = true;
                }
            }
            else if (x == 10 && y == 2)
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
            else if (x == 10 && y == 2)
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
            else if (x == 10 && y == 1)
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
            else if (x == 10 && y == 0)
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
            else if (x == 10 && y == -1)
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
                    oForm1.btnSouth.Visible = false;
                }
            }
            else if (x == 9 && y == -1)
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
                    oForm1.btnSouth.Visible = false;
                }
            }
            else if (x == 8 && y == -1)
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
                    oForm1.btnSouth.Visible = false;
                }
            }
            else if (x == 7 && y == -1)
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
                    oForm1.btnSouth.Visible = false;
                }
            }
            else if (x == 6 && y == -1)
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
                    oForm1.btnSouth.Visible = false;
                }
            }
            else if (x == 5 && y == -2)
            {
                foreach (frmStartGame oForm1 in Application.OpenForms.OfType<frmStartGame>())
                {
                    oForm1.btnEast.Visible =false;
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
            else if (x == 5 && y == -3)
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
            else if (x == 5 && y == -4)
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
                    oForm1.btnSouth.Visible = false;
                }
            }
            else if (x == 5 && y == -5)
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
                    oForm1.btnNorth.Visible = false;
                }
                foreach (frmStartGame oForm1 in Application.OpenForms.OfType<frmStartGame>())
                {
                    oForm1.btnSouth.Visible = true;
                }
            }
            else if (x == 1 && y == -4)
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
            else if (x == 2 && y == -4)
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
                    oForm1.btnSouth.Visible = false;
                }
            }
            else if (x == 3 && y == -4)
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
                    oForm1.btnSouth.Visible = false;
                }
            }
            else if (x == 3 && y == -5)
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
                    oForm1.btnNorth.Visible = false;
                }
                foreach (frmStartGame oForm1 in Application.OpenForms.OfType<frmStartGame>())
                {
                    oForm1.btnSouth.Visible = true;
                }
            }
            else if (x == -1 && y == -5)
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
                    oForm1.btnNorth.Visible = false;
                }
                foreach (frmStartGame oForm1 in Application.OpenForms.OfType<frmStartGame>())
                {
                    oForm1.btnSouth.Visible = true;
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
        public static string SpikeFieldTalk()
        {
            Random rand = new Random();
            string[] statement =
            {
                "Please help me.",
                "Kill me please.",
                "I just want to die.",
                "Arrrgh!",
                "Ahhhhhh!",
                "It hurts so bad.",
                "So. Much. Pain.",
                "Help me.",
                "Help me, please.",
                "Kill me!",
                "Water...I need water...",
                "*cries softly*",
                "Help! Please help!",
                "Just kill me.",
                "Just kill me please.",
                "Why...why...",
                "Water...please...",
                "I don't deserve this.",
                "*whimpers quietly*",
                "99 bottles of beer on the wall, 99 bottles of beer!"

            };
            return statement[rand.Next(0, 20)];
        }
        public string PunishmentPoster()
        {
            Random rand = new Random();
            List<string> statement = new List<string>()
            {
                Environment.NewLine
                + "Why do chicken coops have two doors?"
                + Environment.NewLine
                + "Because if they had four doors they would be chicken sedans!",

                Environment.NewLine
                + "I don't trust stairs."
                + Environment.NewLine
                + "They're always up to something.",

                Environment.NewLine
                + "Why couldn't the bicycle stand on its own?"
                + Environment.NewLine
                + "Because it was too tired.",

                Environment.NewLine
                + "Why can't a nose be twelve inches long?"
                + Environment.NewLine
                +"Because then it would be a foot.",

                Environment.NewLine
                + "How do you get a squirrel to like you?"
                + Environment.NewLine
                + "Act like you are nuts.",
                //5

                Environment.NewLine
                + "Did you hear about the circus fire?"
                + Environment.NewLine
                + "It was in tents.",

                Environment.NewLine
                + "I hate Russian dolls."
                + Environment.NewLine
                + "They're so full of themselves.",

                Environment.NewLine
                + "What do you call a boomerang that never comes back?"
                + Environment.NewLine
                + "A stick.",

                Environment.NewLine
                + "What did ythe pirate say on his 80th birthday?"
                + Environment.NewLine
                + "Aye matey!",

                Environment.NewLine
                + "I made a pencil with two erasers."
                + Environment.NewLine
                + "It was pointless.",
                //10

                Environment.NewLine
                + "What's an astronaut's favorite part of a computer?"
                + Environment.NewLine
                + "The space bar.",

                Environment.NewLine
                + "Two cannibals are eating a clown."
                + Environment.NewLine
                + "One says to the other, 'Does this taste funny to you?'",

                Environment.NewLine
                + "What did the drummer call his two twin daughters?"
                + Environment.NewLine
                + "Anna one, anna two.",

                Environment.NewLine
                + "What do you call a crab that plays baseball?"
                + Environment.NewLine
                + "A pinch hitter.",

                Environment.NewLine
                + "What does a nosy pepper do?"
                + Environment.NewLine
                + "It gets jalapeno buisness.",
                //15

                Environment.NewLine
                + "How do you make a tissue dance?"
                + Environment.NewLine
                + "Put a little boogey in it.",

                Environment.NewLine
                + "Why are there gates around cemetaries?"
                + Environment.NewLine
                + "People are dying to get in.",

                Environment.NewLine
                + "I just went to an emotional wedding."
                + Environment.NewLine
                + "Even the cake was in tiers.",

                Environment.NewLine
                + "Two peanuts were walking down the street."
                + Environment.NewLine
                + "One of them was a salted.",

                Environment.NewLine
                + "What is a ninja's favorite type of shoe?"
                + Environment.NewLine
                + "Sneakers.",
                //20

                Environment.NewLine
                + "What did the fish say when it swam into a wall?"
                + Environment.NewLine
                + "Dam.",

                Environment.NewLine
                + "When's the best time to go to the dentist?"
                + Environment.NewLine
                + "Tooth-hurtie.",

                Environment.NewLine
                + "Did you hear the rumor about butter?"
                + Environment.NewLine
                + "Never mind. I shouldn't spread it.",

                Environment.NewLine
                + "What does a baby computer call its father?"
                + Environment.NewLine
                + "Data.",

                Environment.NewLine
                + "Last night I dreamed I was a muffler."
                + Environment.NewLine
                + "I woke up exhausted.",
                //25

                Environment.NewLine
                + "I was sitting in traffic the other day."
                + Environment.NewLine
                + "It's probably why I got run over.",

                Environment.NewLine
                + "How do you cathc a bra?"
                + Environment.NewLine
                + "With a booby trap.",

                Environment.NewLine
                + "Why did the crab refuse to donate to charity?"
                + Environment.NewLine
                + "He's shellfish.",

                Environment.NewLine
                + "If you have a bladder infection, urine trouble.",

                Environment.NewLine
                + "What did one plate say to the other?"
                + Environment.NewLine
                + "Lunch is on me.",
                //30

                Environment.NewLine
                + "Why did the scarecrow win an award?"
                + Environment.NewLine
                + "He was outstanding in his field.",

                Environment.NewLine
                + "What did the clock do when it was hungry?"
                + Environment.NewLine
                + "It went back four seconds.",

                Environment.NewLine
                + "Why do fish live in saltwater?"
                + Environment.NewLine
                + "Pepper makes them sneeze.",

                Environment.NewLine
                + "How many ears does spock have?"
                + Environment.NewLine
                + "Three: left ear, right ear and the final front-ear.",

                Environment.NewLine
                + "I sold my vacuum the other day."
                + Environment.NewLine
                + "It was just collecting dust.",
                //35

                Environment.NewLine
                + "Why did the tomatoe blush?"
                + Environment.NewLine
                + "It saw the salad dressing.",

                Environment.NewLine
                + "What does a martial arts expert drink?"
                + Environment.NewLine
                + "Kara-tea",

                Environment.NewLine
                + "A ham sandwich walks into a bar and orders a beer."
                + Environment.NewLine
                + "The bartender says 'Sorry, we don't serve food here.'",

                Environment.NewLine
                + "Why do ghosts love elevators?"
                + Environment.NewLine
                + "They lift their spirits.",

                Environment.NewLine
                + "What type of music do mummies listen to?"
                + Environment.NewLine
                + "Wrap music."
                //40



            };
            return statement[rand.Next(0, 2)];

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
            return statement[rand.Next(0, 10)];
        }




    }
}
