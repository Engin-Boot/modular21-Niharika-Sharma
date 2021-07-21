using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    partial class Program
    {
        //This Program prints the list of all 25 Pairs, 
        //along with their Corresponding Colors.
         static void PrintManual(IManualOutput destination)
        {
            int totalNumberOfPairs = colorMapMinor.Length * colorMapMajor.Length;
            string rowEntryToPrint = "";

            for (int currentPairNumber = 1; currentPairNumber <= totalNumberOfPairs; currentPairNumber++)
            {
                ColorPair currentPairColor = Program.GetColorFromPairNumber(currentPairNumber);
                /// Given a pair number as input to the function,
                //and returns the major and minor colors in that order.
                rowEntryToPrint = "Pair Number: " + currentPairNumber + ", colors: MajorColor:" + currentPairColor.majorColor + ", MinorColor:" + currentPairColor.minorColor;
                //Injection
                destination.printALine(rowEntryToPrint);                

            }
        }    


    }
}