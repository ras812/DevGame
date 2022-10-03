using ConsoleApp12.TypesInCSharp;
using System;
using System.Collections.Generic;
using System.Text;
using static ConsoleApp12.Program;

namespace ConsoleApp12
{
   public class MainMenu
    {
        public MainMenu()
        {
                
        }
        public void DisplayMainMenu()
        {
            Console.Clear();
            Console.WriteLine($"Select type info:\n" +
                                              $"================\n" +
                                              $"[1] - [ Общая информация по типам ]\n" +
                                              $"[2] - [ Выбрать тип из списка ]\n" +
                                              $"[3] - [ Параменты консоли ]\n" +
                                              $"[0] - [ Выход из программы ]\n"

                                             );
        }
    
    
       public void StartMainMenu()
        {
            DisplayMainMenu();

            while(true)
            {
                int ret = Handlers.ReadNum();
                if(ret == 1)
                {
                    ShowAllTypeInfo sati = new ShowAllTypeInfo();
                    sati.StartShowAllTypeInfo();
                    break;
                }
            
                if(ret == 2)
                {
                    SelectTypeInfo appStart = new SelectTypeInfo();
                    appStart.StartSelectTypeInfo();
                    break;
                }

                if (ret == 3)
                {
                    SelectColor s = new SelectColor();
                    s.DisplayColor();
                    break;
                }
                 if(ret == 0)
                {
                    Environment.Exit(0);
                }

            }
        }
    
    }
}
