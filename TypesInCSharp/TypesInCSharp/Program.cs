using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Intrinsics.X86;

namespace TypesInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //MainMenu m = new MainMenu();
            //m.StartMainMenu();

            AssemblyInfo ai = new AssemblyInfo(typeof(Int32));
            Console.WriteLine(ai.ToString());
            ai.DisplayInfo();

            foreach (var item in typeof(Int32).GetMethods())
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine(typeof(Int32).IsClass);
            //System.Console
        }
    }
}

