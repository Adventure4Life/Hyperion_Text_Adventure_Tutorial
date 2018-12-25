using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyperion.Classes
{
    class GameManager
    {
        public static void ShowTitleScreen()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(TextUtils.WordWrap("Text Adventure C# Tutorial I found on uTube\n(Search uTube for [c# starter 3dbuzz playlist])\nBig Thanks to Logan of 3DBuzz\n\n",
                                                
                Console.WindowWidth));
            Console.WriteLine("\nType Help to get the Command List");
            Console.WriteLine("\nPress a key to begin");

            Console.CursorVisible = false;
            Console.ReadKey();
            Console.CursorVisible = true;
            Console.Clear();
        }

        public static void StartGame()
        {
            Player.GetCurrentRoom().Describe();
            TextBuffer.Display();
        }

        public static void EndGame(string endingText)
        {
            Program.quit = true;

            Console.Clear();

            Console.WriteLine(TextUtils.WordWrap(endingText, Console.WindowWidth));
            Console.Write("\nYou may now close this window.");
            Console.CursorVisible = false;

            while (true)
            {
                Console.ReadKey(true);
            }
        }

        public static void ApplyRules()
        {

        }
    }
}
