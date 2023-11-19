using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.KorotchenkoDM.Sprint5.Task2.V7.Lib;

namespace Tyuiu.KorotchenkoDM.Sprint5.Task2.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Коротченко Д. М. | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл      *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Коротченко Данил Михайлович | ИСТНб-23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный с      *");
            Console.WriteLine("* клавиатуры. Заменить нечетные элементы массива на 0. Результат          *");
            Console.WriteLine("* сохранить в файл OutPutFileTask2.csv и вывести на консоль               *");
            Console.WriteLine("* 9; 2; 8                                                                 *");
            Console.WriteLine("* 7; 1; 2                                                                 *");
            Console.WriteLine("* 5; 5; 1                                                                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            int[,] matrix = new int[3, 3] { { 9, 2, 8 },
                                            { 7, 1, 2 }, 
                                            { 5, 5, 1 } };
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.GetUpperBound(1) + 1;

            Console.WriteLine("Массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(matrix);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан");

            using (StreamReader reader = new StreamReader(res))
            {
                string mtrx = reader.ReadToEnd();
                Console.WriteLine(mtrx);
            }
                Console.ReadKey();
        }
    }
}
