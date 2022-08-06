using System;
using System.Collections.Generic;

namespace WarGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // МОЖНО ВОСПОЛЬЗОВАТЬСЯ ВСТРОЕННЫМ МЕТОДОМ
            // Char.IsLetter();

            // Exp #1
            string text = "цифры";

            bool b = true;
            for (int i = 0; i < text.Length; i++)
            {
                b = Char.IsLetter(text[i]);
                if (b == false)
                {
                    break;
                }
            }
            Console.WriteLine($"Is TEXT [{text}] contain only letters? [{b}].");


            // Exp #2
            text = "ци1фры";

            b = true;
            for (int i = 0; i < text.Length; i++)
            {
                b = Char.IsLetter(text[i]);
                if (b == false)
                {
                    break;
                }
            }
            Console.WriteLine($"Is TEXT [{text}] contain only letters? [{b}].");

            // Сделай из этого примера статическую функцию и помести ее в новый класс Handlers 
            // там будем хранить разные обработчики

            //bool test = IsDigit(text);
            //Console.WriteLine(test);




        }

        public static bool IsDigit(string text)
        {
            bool test = true;

            foreach (char x in text)
            {
              if(char.IsDigit(x))
                test = false;
                
            }
           return test;
        }
    
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
