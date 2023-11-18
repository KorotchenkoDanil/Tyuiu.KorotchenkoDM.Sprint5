using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KorotchenkoDM.Sprint5.Task1.V10.Lib
{
    public class DataService : ISprint5Task1V10
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            if (fileExists)
                File.Delete(path);

            for (int x = startValue; x <= stopValue; x++)
            {            
                double y = Math.Round((2 * Math.Cos(x) + 2) / (2 * x - 1) + Math.Cos(x) - 5 * x + 3, 2);
                string strY = Convert.ToString(y);

                if (x != stopValue)
                    File.AppendAllText(path, strY + Environment.NewLine);
                else
                    File.AppendAllText(path, strY);


            }
            return path;
            
        }

        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue + 1);
            valueArray = new double[len];
            int i = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (2 * x - 1 == 0)
                {
                    valueArray[i] = 0;
                    continue;
                }
                double y = Math.Round((2 * Math.Cos(x) + 2) / (2 * x - 1) + Math.Cos(x) - 5 * x + 3, 2);
                valueArray[i] = y;
                i++;
            }
            return valueArray;
        }
    }
}
