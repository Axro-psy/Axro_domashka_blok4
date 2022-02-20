using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ugadai_chislo_666
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Введите самое большое число диапазона");
            int maxnum = int.Parse(Console.ReadLine());
            int correctnum = random.Next(0, maxnum);
            int count = 0;
            int usernum = 1;

            while (true)
            {
                Console.WriteLine("Введите число: ");
                count++;
                String input0 = Console.ReadLine();
                if (input0 == "")
                {
                    Console.WriteLine("Жаль, что вы так быстро сдались. Правильное число: " + correctnum);
                    break;
                }
                else if (input0 != "")
                {
                    usernum = Convert.ToInt32(input0);
                    if (usernum > correctnum)
                    {
                        Console.WriteLine("загаданное число меньше");
                    }
                    else if (usernum < correctnum)
                    {
                        Console.WriteLine("загаданное число больше");
                    }
                    else
                    {
                        Console.WriteLine("Число " + correctnum + " правильное! Количество попыток: " + count);
                        break;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}


