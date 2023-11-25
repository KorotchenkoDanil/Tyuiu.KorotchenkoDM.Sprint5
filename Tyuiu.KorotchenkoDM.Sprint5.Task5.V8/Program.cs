using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KorotchenkoDM.Sprint5.Task5.V8.Lib;

namespace Tyuiu.KorotchenkoDM.Sprint5.Task5.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Коротченко Д. М. | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Коротченко Данил Михайлович | ИСТНб-23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл C:/DataSprint5/InPutDataFileTask5V8.txt (файл взять из архива  *");
            Console.WriteLine("* согласно вашему варианту) Создать папку вручную С:/DataSprint5/ и       *");
            Console.WriteLine("* скопировать в нее файл в котором есть набор значений. Найти минимальное *");
            Console.WriteLine("* вещественное число в файле. Полученный результат вывести на консоль. У  *");
            Console.WriteLine("* вещественных значений округлить до трех знаков после запятой            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask5V8.txt";
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Минимальное вещественное число: " + res);
            Console.ReadKey();
        }
    }
}
