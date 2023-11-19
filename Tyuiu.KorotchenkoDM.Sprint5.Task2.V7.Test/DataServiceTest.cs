using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KorotchenkoDM.Sprint5.Task2.V7.Lib;

namespace Tyuiu.KorotchenkoDM.Sprint5.Task2.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedSaveToFileTextData()
        {
            string path = @"C:\Users\ДАНИЛ\source\repos\Tyuiu.KorotchenkoDM.Sprint5\Tyuiu.KorotchenkoDM.Sprint5.Task2.V7\bin\Debug\OutPutFileTask2.scv";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
