using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axro_domashka_block_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0; //сумма всех элементов
            Random rand = new Random();
            Console.Write("Введите количество строк: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов: ");
            int col = int.Parse(Console.ReadLine());

            int[,] matrix = new int[row, col]; //массив задан
            for (int i = 0; i < row; i++) //строки
            {
                for (int j = 0; j < col; j++) //столбцы
                {
                    matrix[i, j] = rand.Next(100);
                    Console.Write(matrix[i, j] + "\t");
                    sum += matrix[i, j]; //считаем сумму 
                }
                Console.WriteLine();

            }
            Console.Write("Сумма элементов матрицы: " + sum);
            Console.ReadLine();
        }
    }
}
