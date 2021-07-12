using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    partial class Program
    {
        //This Program prints the list of all 25 Pairs, 
        //along with their Corresponding Colors.

        private static void PrintAllPairNumbersAndColorNames()
        {

            Console.WriteLine("List of all Pair Numbers and their Corresponding Colors:\n");

            for (int currentPairNumber = 1; currentPairNumber <= 25; currentPairNumber++)
            {
                ColorPair currentPairColor = Program.GetColorFromPairNumber(currentPairNumber);
                /// Given a pair number as input to the function,
                //and returns the major and minor colors in that order.

                Console.WriteLine("Pair Number: {0}, Colors: {1}\n", currentPairNumber, currentPairColor);
            }
        }
    }
}