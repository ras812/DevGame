using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12
{
    public class SelectColor
    {
     public SelectColor()
        {

        }

        public  void ChangeConsoleColor(int colBack, int colText)
        {
            Console.BackgroundColor = (ConsoleColor)colBack;
            Console.ForegroundColor = (ConsoleColor)colText;
            Console.WriteLine("Hello, Cat");
        }




        public void DisplayColor()
        {
            Console.WriteLine("Select color of backround from 0 to 15: \n" +
                      "  Black: 0 \n" +
                      "  DarkBlue: 1 \n" +
                      "  DarkGreen: 2 \n" +
                      "  DarkCyan: 3 \n" +
                      "  DarkRed: 4 \n" +
                      "  DarkMagenta: 5 \n" +
                      "  DarkYellow: 6 \n" +
                      "  Gray: 7 \n" +
                      "  DarkGray: 8 \n" +
                      "  Blue: 9 \n" +
                      "  Green: 10 \n" +
                      "  Cyan: 11 \n" +
                      "  Red: 12 \n" +
                      "  Magenta: 13 \n" +
                      "  Yellow: 14 \n" +
                      "  White: 15 \n");
            int c = Handlers.ReadNum();

            Console.WriteLine("Select color of text from 0 to 15: \n " +
                      "  Black: 0,\n" +
                      "  DarkBlue: 1\n" +
                      "  DarkGreen: 2\n" +
                      "  DarkCyan: 3\n" +
                      "  DarkRed: 4\n" +
                      "  DarkMagenta: 5\n" +
                      "  DarkYellow: 6\n" +
                      "  Gray: 7\n" +
                      "  DarkGray: 8\n" +
                      "  Blue: 9\n" +
                      "  Green: 10\n" +
                      "  Cyan: 11\n" +
                      "  Red: 12\n" +
                      "  Magenta: 13\n" +
                      "  Yellow: 14\n" +
                      "  White: 15 ");
            int b = Handlers.ReadNum();

            ChangeConsoleColor(c, b);

            MainMenu m = new MainMenu();
            m.StartMainMenu();
        }

    }
}
