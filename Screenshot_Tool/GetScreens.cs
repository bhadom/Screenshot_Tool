using System.Collections.Generic;
using System.Windows.Forms;

namespace Screenshot_Tool
{
    /// <summary>
    /// This class gets all screens and creats a list for the combobox
    /// 
    /// Michael Hadorn
    /// </summary>
    public class GetScreens
    {
        /// <summary>
        /// This method returns a list with all the devicenames of the screens
        /// </summary>
        /// <returns>list with all screens including all screens</returns>
        public static List<string> GetAllScreens()
        {
            List<string> screens = new List<string>();
            Screen[] allScreens = Screen.AllScreens;
            foreach(Screen s in allScreens)
            {
                screens.Add(s.DeviceName.Replace(@"\", "").Replace(".",""));
            }
            screens.Add("Alle Monitore");
            return screens;
        }
    }
}
