using System;

namespace WarGame
{
    public class Handlers
    {
        public static bool IsString(string text)
        {
            bool b = true;
            int txtLen = text.Length;
            for (int i = 0; i < txtLen; i++)
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
