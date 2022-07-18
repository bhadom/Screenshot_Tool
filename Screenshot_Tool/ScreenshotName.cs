using System;
using System.Text.RegularExpressions;

namespace Screenshot_Tool
{
    /// <summary>
    /// Generates a name for a screenshot
    /// 
    /// Michael Hadorn
    /// </summary>
    public class ScreenshotName
    {
        /// <summary>
        /// Generates a name called "Screenshot" combined with the current Date and time. colons and spaces are getting replaced by underscores
        /// </summary>
        /// <returns>the generated name</returns>
        public static string GenerateScreenshotName()
        {
            Regex pattern = new Regex("[: ]");
            string name = "Screenshot_" + DateTime.Now;
            name = pattern.Replace(name, "_");
            return name;
        }
    }
}