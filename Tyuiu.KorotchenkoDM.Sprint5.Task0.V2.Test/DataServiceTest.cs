using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KorotchenkoDM.Sprint5.Task0.V2.Lib;

namespace Tyuiu.KorotchenkoDM.Sprint5.Task0.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\ДАНИЛ\source\repos\Tyuiu.KorotchenkoDM.Sprint5\Tyuiu.KorotchenkoDM.Sprint5.Task0.V2\bin\Debug\OutPutFileTask0.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
