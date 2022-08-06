using System;
using System.Collections.Generic;
using System.Text;

namespace WarGame.Model.Class
{
    internal class Handlers
    {

        public static bool IsString(string text)
        {

            bool b = true;
            for (int i = 0; i < text.Length; i++)
            {
                b = Char.IsLetter(text[i]);
                if (b == false)
                {
                    break;
                }

            }

            return b;

        }

    }
}
