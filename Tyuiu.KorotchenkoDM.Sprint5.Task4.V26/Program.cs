using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.KorotchenkoDM.Sprint5.Task4.V26.Lib;

namespace Tyuiu.KorotchenkoDM.Sprint5.Task4.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Коротченко Д. М. | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Коротченко Данил Михайлович | ИСТНб-23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл C:/DataSprint5/InPutDataFileTask4V26.txt (файл взять из архива *");
            Console.WriteLine("* согласно вашему варианту. Создать папку вручную C:/DataSprint5/ и       *");
            Console.WriteLine("* скопировать в нее файл) в котором есть вещественное значение. Прочитать *");
            Console.WriteLine("* значение из файла и подставить вместо X в формуле y=(x^3 + sin(x))cos(x)*");
            Console.WriteLine("* Вычислить значение по формуле (Полученное значение округлить до трех    *");
            Console.WriteLine("* знаков после запятой) и вернуть полученный результат на консоль         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            string path = $@"C:\DataSprint5\InPutDataFileTask4V26.txt";
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
