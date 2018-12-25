using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyperion.Classes
{
    static class CommandProcessor
    {
        public static void ProcessCommand(string line)
        {
            string command = TextUtils.ExtractCommand(line.Trim()).Trim().ToLower();
            string arguments = TextUtils.ExtractArgument(line.Trim()).Trim().ToLower();

            if (Direction.IsValidDirection(command))
            {
                Player.Move(command);
            }
            else
            {

                switch (command)
                {
                    case "quit":
                        Program.quit = true;
                        return;
                    case "help":
                        ShowHelp();
                        break;
                    case "move":
                        Player.Move(arguments);
                        break;
                    case "look":
                        Player.GetCurrentRoom().Describe();
                        break;
                    case "get":
                        Player.PickupItem(arguments);
                        break;
                    case "drop":
                        Player.DropItem(arguments);
                        break;
                    case "inventory":
                        Player.DisplayInventory();
                        break;
                    case "where":
                        Player.GetCurrentRoom().ShowTitle();
                        break;
                    default:
                        //EasterEggs.inputEggs(command);
                        break;
                }
            }
            GameManager.ApplyRules();
            TextBuffer.Display();
        }

        public static void ShowHelp()
        {
            TextBuffer.Add("       Available Commands:");
            TextBuffer.Add("----------------------------------");
            TextBuffer.Add("   Help");
            TextBuffer.Add("   Quit");
            TextBuffer.Add("   Move (North, South, East, West)");
            TextBuffer.Add("   Look");
            TextBuffer.Add("   Get");
            TextBuffer.Add("   Drop");
            TextBuffer.Add("   Inventory");
            TextBuffer.Add("   Where");
            TextBuffer.Add("This program takes 2 word commands like \"get ball\" and \"move east\"");
        }
    }
}