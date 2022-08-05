using System;
using System.Collections.Generic;

namespace WarGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "цифры";
            bool test = IsDiggit(text);
            Console.WriteLine(test);

            
            
            
            //Console.WriteLine("WarGame");
            //Warrior obj = new Warrior();
            //Console.WriteLine("Victory!");
            //Weapon sword = new Weapon();
            //Weapon mace = new Weapon();
            //Console.WriteLine("TrimBim!");
        }
    
       public static bool IsDiggit(string text)
        {
            bool test = true;

            foreach (char x in text)
            {
              if(char.IsDigit(x))
                test = false;
                
            }
           return test;
        }
    
    }



}
