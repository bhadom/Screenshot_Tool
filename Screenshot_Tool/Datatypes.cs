using System.Collections.Generic;

namespace Screenshot_Tool
{
    /// <summary>
    /// Creats a list of datatypes
    /// 
    /// Michael Hadorn
    /// </summary>
    public class Datatypes
    {
        /// <summary>
        /// Creats a list of Datatypes for the combobox
        /// </summary>
        /// <returns>said list for the combobox</returns>
        public static List<string> GenerateDataTypeList()
        {
            List<string> comboBoxContent = new List<string> { "Png", "Jpeg", "Gif", "Icon", "Bmp", "Tiff"};
            return comboBoxContent;
        }
    }
}