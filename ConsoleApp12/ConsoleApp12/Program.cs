using System;
using System.Collections.Generic;
using System.Reflection;

namespace ConsoleApp12
{
    public class Program
    {
        static void Main(string[] args)
        {
            MainMenu m = new MainMenu();
            m.StartMainMenu();


            //var s = AppDomain.CurrentDomain.GetAssemblies();
            //int num = s.Length;
            //Console.WriteLine($"Количествo сборок: {num}");





            //var v = typeof(TypeInfo).GetProperties();  ЭТО НЕ ОТНОСИТСЯ К ПРОЕКТУ
            //foreach (var item in v)
            //{
            //    Console.WriteLine(item.Name);
            //}
            //var n = typeof(char).GetMethods();
            //foreach (var method in n)
            //    Console.WriteLine(method.Name);



        }



    }



}
