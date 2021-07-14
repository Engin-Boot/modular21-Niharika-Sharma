using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    partial class Program
    {
        //This Program prints the list of all 25 Pairs, 
        //along with their Corresponding Colors.

        private static int PrintAllPairNumbersAndColorNames()
        {
            //As there are 5 possibilities in colorMapMinor and 5 possibilities in colorMapMajor
            //hence the total no of combinations are 5*5 = 25
            int totalNumberOfPairs = colorMapMinor.Length * colorMapMajor.Length;
            Console.WriteLine("List of all Pair Numbers and their Corresponding Colors:\n");

            int  numberOfPairsPrinted = 0;

            for (int currentPairNumber = 1; currentPairNumber <= totalNumberOfPairs; currentPairNumber++)
            {
                ColorPair currentPairColor = Program.GetColorFromPairNumber(currentPairNumber);
                /// Given a pair number as input to the function,
                //and returns the major and minor colors in that order.
                numberOfPairsPrinted ++;
                Console.WriteLine("Pair Number: {0}, Colors: {1}\n", currentPairNumber, currentPairColor);
                               
            }
            return numberOfPairsPrinted;
        }
    }
}