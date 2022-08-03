using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num;
            //int power;
            //double result = 1;
            //Console.WriteLine("Введите число!");
            //num = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите степень!");
            //power = int.Parse(Console.ReadLine());

            //for (int c = 1; c <= Math.Abs(power); c++)
            //    result = result * num;

            //if (power < 0) result = 1 / result;

            //Console.WriteLine($"Результ равен: {result}");

            //int age1 = 0, age2;
            //int count = 0, max = 0;

            //while(true)
            //{
            //    Console.WriteLine("Введите возраст");
            //    age2 = int.Parse(Console.ReadLine());
            //    if (age2 == 0) break;
            //    if(age1 == age2)
            //        count++;
            //    else
            //    {
            //        if(count > max) max = count;
            //        count = 1;
            //    }
            //       age1 = age2; 

            //}

            // if(count > max) max=count;
            //Console.WriteLine($"Максимальное количество студентов в группе: {max}");

            //string line = "";
            //int num;
            //Console.WriteLine("Введите число строк:");
            //num = int.Parse(Console.ReadLine());

            //for (int c = 1; c <= num; c++)
            //{
            //    line += c + " ";
            //    Console.WriteLine(line);
            //}

            int[] cats = { 35, 40, 80, 100 };
            int sum = 0;

            foreach (int x in cats)
                sum = sum + x;
            Console.WriteLine($"Сумма чисел массива равна: {sum}");
        
        }
    
    
    
    }



}
