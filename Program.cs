using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hyperion.Classes;

namespace Hyperion
{
    class Program
    {
        public static Boolean quit = false;

        static void Main(string[] args)
        {
            GameManager.ShowTitleScreen();
            Level.Initialize();
            GameManager.StartGame();

            while (!quit)
            {
                CommandProcessor.ProcessCommand(Console.ReadLine());
            }
        }
    }
}