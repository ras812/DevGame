using System;
using System.Collections.Generic;
using System.Reflection;

namespace TypesInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //MainMenu m = new MainMenu();
            //m.StartMainMenu();

            ShowAllTypeInfo saati = new ShowAllTypeInfo();
            saati.StartShowAllTypeInfo(new AssemblyInfo());

        }
    }
}

