using System;
using System.Collections.Generic;
using System.Reflection;

namespace TypesInCSharp
{
    class Program
    {

        static void Main(string[] args)
        {
            SelectTypeInfo appStart = new SelectTypeInfo();
            appStart.StartSelectTypeInfo();

            //Type t = typeof(string);
            //var arrMethods = t.GetMethods();

            //foreach (var item in arrMethods)
            //{
            //    Console.WriteLine($"Method: {item.Name}, Parameter: {item.GetParameters().Length}");
            //}

            //Dictionary<string, int[]> DictMethodInfoByType = new Dictionary<string, int[]>();
            //for (int i = 0; i < arrMethods.Length; i++)
            //{
            //    if (DictMethodInfoByType.ContainsKey(arrMethods[i].Name))
            //    {
            //        DictMethodInfoByType[arrMethods[i].Name][0]++; //overloadsCount
            //        if (arrMethods[i].GetParameters().Length >= DictMethodInfoByType[arrMethods[i].Name][2])
            //        {
            //            DictMethodInfoByType[arrMethods[i].Name][2] = arrMethods[i].GetParameters().Length;
            //        }
            //    }
            //    else
            //    {
            //        DictMethodInfoByType.Add(arrMethods[i].Name, new int[3]);
            //        DictMethodInfoByType[arrMethods[i].Name][0]++; //overloadsCount
            //        DictMethodInfoByType[arrMethods[i].Name][1] = arrMethods[i].GetParameters().Length;
            //        DictMethodInfoByType[arrMethods[i].Name][2] = arrMethods[i].GetParameters().Length;
            //    }
            //}

            //foreach (var item in DictMethodInfoByType)
            //{
            //    Console.WriteLine($"Method: {item.Key} "+
            //                      $"Overloads count: {item.Value[0]} "+
            //                      $"Min parameters: {item.Value[1]} "+
            //                      $"Max parameters: {item.Value[2]} "
            //                      );
            //}

        }
    }
    
}

