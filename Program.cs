using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axro_domashka_4_2____this
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество чисел в последовательности:\t");
            int elementsCount = int.Parse(Console.ReadLine()); //назначаем переменную
            int[] psld = new int[elementsCount]; //задаем массив из количества элементов, которые ввел пользователь


            for (int i = 0; i < psld.Length; i++)
            {
                Console.Write($"Введите число {i}:\t");
                psld[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nПоследовательность чисел:");
            for (int i = 0; i < psld.Length; i++)
            {
                Console.WriteLine(psld[i]);
            }
            Console.WriteLine("\nЧтобы узнать самое большое и самое маленькое число нажмите ENTER");
            Console.ReadLine();
           
            Console.WriteLine("\nНаименьшее число в последовательности:" + psld.Min());
            Console.WriteLine("\nНаибольшее число в последовательности:" + psld.Max());
            Console.ReadLine();
        }
    }
}
