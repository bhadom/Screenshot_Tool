using System.Drawing.Imaging;
using System.Reflection;

namespace Screenshot_Tool
{
    /// <summary>
    /// Converts the string datatype into a format that is readable for the ImageFormat Class
    /// 
    /// Michael Hadorn
    /// </summary>
    public class ConvertImageFormat
    {
        /// <summary>
        /// Converts the string dataType into an ImageFormat
        /// </summary>
        /// <param name="dataType">datatype selected from the combobox</param>
        /// <returns>the datatype as an ImageFormat</returns>
        public static ImageFormat ParseImageFormat(string dataType)
        {
            return (ImageFormat)typeof(ImageFormat)
                .GetProperty(dataType, BindingFlags.Public | BindingFlags.Static | BindingFlags.IgnoreCase)
                .GetValue(dataType, null);
        }
    }
}