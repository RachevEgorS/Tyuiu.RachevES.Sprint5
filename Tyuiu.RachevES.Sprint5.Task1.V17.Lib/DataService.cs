﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.RachevES.Sprint5.Task1.V17.Lib
{
    public class DataService : ISprint5Task1V17
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            double y;
            string strY;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = (((2 * x) - 4 + ((2 * x - 1) / (Math.Sin(x) + 1))));
                y = Math.Round(y, 2);
                strY = Convert.ToString(y);
                if (x == 0)
                {
                    y = 0;
                }
                if (x != stopValue)
                { File.AppendAllText(path, strY + Environment.NewLine); }
                else { File.AppendAllText(path, strY); }
            }
            
            return path;

        }
    }
}
