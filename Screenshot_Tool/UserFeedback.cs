using System;
using System.Windows.Forms;

namespace Screenshot_Tool
{
    /// <summary>
    /// This class handles the userfeedback according to the situation
    /// 
    /// Michael Hadorn
    /// </summary>
    public class UserFeedback
    {
        /// <summary>
        /// This method gets called when the saving was successful.
        /// </summary>
        /// <param name="name">name of the screenshot</param>
        /// <param name="path">storage path of the screenshot</param>
        public static void ShowSuccess(string name, string path)
        {
            MessageBox.Show(String.Format("Der Screenshot mit dem Namen {0} wurde erfolgreich unter dem Pfad {1} gespeichert.", name, path), "Speichern erfolgreich");
        }
        /// <summary>
        /// This method gets called when there was an error in saving the screenshot.
        /// </summary>
        public static void ShowError()
        {
            MessageBox.Show("Der Screenshot konnte nicht gespeichert werden.", "Speichern fehlgeschalgen");
        }
    }
}