using System;
using System.IO;

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
    
      public static void ReadFiles(string fileName, int[] arr) //ФУНКЦИЯ КОТОРАЯ ЧИТАЕТ ФАЙЛ
        {
        BinaryReader br = new BinaryReader(File.Open(fileName, FileMode.Open));
        int len = br.ReadInt32();   
        arr = new int[len];
            for (int c = 0; c < len; c++)
            {
                arr[c] = br.ReadInt32();
            }
        br.Close();

            foreach (var v in arr)
            {
                Console.WriteLine(v + "  ");
            }
        
        }
    
    
    }
}
