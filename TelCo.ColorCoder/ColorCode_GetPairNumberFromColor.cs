using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    partial class Program
    {
        /// <summary>
        /// Given the two colors the function returns the pair number corresponding to them
        /// </summary>
        /// <param name="pair">Color pair with major and minor color</param>
        /// <returns></returns>
        private static int GetPairNumberFromColor(ColorPair pair)
        {
            //as colorMapMajor.Length = colorMapMinor.Length = 5
            int maxIndexOfColorMap = colorMapMajor.Length;

            // Find the major and minor color in the array and get the index
            int majorIndex = -1, minorIndex = -1;
            bool isMajorIndexNotFound = true, isMinorIndexNotFound = true;

            for (int i = 0; i < maxIndexOfColorMap ; i++)
            {
                if (isMajorIndexNotFound)
                {
                    if (colorMapMajor[i] == pair.majorColor)
                    {
                        majorIndex = i;
                        isMajorIndexNotFound = false;
                        break;
                    }
                }

                if (isMinorIndexNotFound)
                {
                    if (colorMapMinor[i] == pair.minorColor)
                    {
                        minorIndex = i;
                        isMinorIndexNotFound = false;
                    }
                }
            }

            // If colors can not be found throw an exception
            if (majorIndex == -1 || minorIndex == -1)
            {
                throw new ArgumentException(
                    string.Format("Unknown Colors: {0}", pair.ToString()));
            }

            // Compute pair number and Return  
            // (Note: +1 in compute is because pair number is 1 based, not zero)
            return (majorIndex * colorMapMinor.Length) + (minorIndex + 1);
        }

    }

}