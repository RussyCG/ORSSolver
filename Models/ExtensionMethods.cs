using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    internal static class ExtensionMethods
    {
        /// <summary>
        /// Gets the string representation of a Cell
        /// </summary>
        /// <param name="CharSpacing">Width of the cell</param>
        /// <param name="CellValue">Value to place inside the cell</param>
        /// <param name="EndCharacters">Characters to place at the end of the cell to sperate the cells</param>
        /// <returns>Formatted string cell</returns>
        internal static string GetCellValue(int CharSpacing, string CellValue, string EndCharacters = "|")
        {
            // Initiate the temp variable that will hold the end value
            string temp = "";

            // If the Given cell value is larger than the set cell width
            if (CellValue.Length > CharSpacing)
            {
                // Get the first characters of the cell value and add an eclipse
                temp = CellValue.Substring(0, CharSpacing - 3) + "...";
            }
            else
            {
                // Set the length difference
                int iLength = CharSpacing - CellValue.Length;
                for (int i = 0; i < iLength; i++)
                {
                    // Left pad the cell value with spaces
                    CellValue = " " + CellValue;
                }
                // set the temp variable
                temp = CellValue;
            }

            // return the formatted cell value with the end characters added
            return temp + EndCharacters;
        }
    }
}
