using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;

namespace TelCo.ColorCoder
{
    interface IManualOutput
    {
        void printALine(string line);
    }

    class PrintManualOnConsole : IManualOutput
    {
        public void printALine(string line)
        {
            Console.WriteLine(line);
        }
    }

    class ManualContentGrabber : IManualOutput
    {
        static List<string> rowsOfEntry = Manual.creatingManual();
        static int index = 0;
        public void printALine(string line)
        {
            Console.WriteLine(line.Equals(rowsOfEntry[index]));
            index++;
        }        
    }

    public static class Manual
    {               
        public static List<string> creatingManual()
        {
            List<string> list = new List<string>();

            string line;
            int counter = 0;
            System.IO.StreamReader file = new System.IO.StreamReader("PrintManual1.txt");
            while ((line = file.ReadLine()) != null)
            {
                
                list.Add(line);
                counter++;
            }

            file.Close();            
            return list;

        }
    }

        
}