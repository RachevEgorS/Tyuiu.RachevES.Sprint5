using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.RachevES.Sprint5.Task0.V27.Lib;

namespace Tyuiu.RachevES.Sprint5.Task0.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\buratino\source\repos\Tyuiu.RachevES.Sprint5\Tyuiu.RachevES.Sprint5.Task0.V27\bin\debug\OutputFileTask0.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
