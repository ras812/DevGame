using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12
{
    public class Handlers
    {
        public static char InPutHandler()
        {
            return char.ToLower(Console.ReadKey(true).KeyChar);
        }



        public static int ReadNum()
        {
            return int.Parse(Console.ReadLine());

        }

        
    
    }
}
