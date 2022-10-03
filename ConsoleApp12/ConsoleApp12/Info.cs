using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12
{
    internal class Info
    {

        public void DisplayInfo()
        {
            Console.Clear();
            Console.WriteLine($"Common information of types:\n" +
                                              $"================\n" +
                                              $" [ Подключенные сборки:  ]\n" +
                                              $" [ Всего типов по всем подключенным сборкам: ]\n" +
                                              $" [ Ссылочные типы: ]\n" +
                                              $" [ Значимые типы: ]\n" +
                                              $" [ Типы-интерфейсы: ]\n"  +
                                              $" [ Тип с максимальным числом методов:  ]\n" +
                                              $" [ Самое длинное название метода:  ]\n" +
                                              $" [ Метод с наибольшим числом аргументов:   ]\n" +
                                              $" [ Нажмите 0, чтобы вернуться в главное меню   ]\n" 
                                             );
        }



    }
}
