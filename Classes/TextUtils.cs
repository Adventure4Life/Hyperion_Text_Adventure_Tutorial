using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyperion.Classes
{
    class TextUtils
    {
        public static string ExtractCommand(string line)
        {
            int index = line.IndexOf(' ');
            if (index == -1)
                return line;
            else
                return line.Substring(0, index);
        }

        public static string ExtractArgument(string line)
        {
            int index = line.IndexOf(' ');
            if (index == -1)
                return "";
            else
                return line.Substring(index + 1, line.Length - index - 1);
        }

        public static string WordWrap(string text, int bufferWidth)
        {
            string result = "";
            string[] lines = text.Split('\n');

            foreach (string line in lines)
            {
                int linelength = 0;
                string[] words = line.Split(' ');

                foreach (string word in words)
                {
                    if (word.Length + linelength >= bufferWidth - 1)
                    {
                        result += "\n";
                        linelength = 0;
                    }
                    result += word + " ";
                    linelength += word.Length + 1;
                }
                result += "\n";
            }
            return result;
        }
    }
}