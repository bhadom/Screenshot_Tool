using System;
using System.Windows.Forms;

namespace Screenshot_Tool
{
    /// <summary>
    /// Opens an explorer menu and returns the path
    /// 
    /// Michael Hadorn
    /// </summary>
    public class StoragePath
    {
        /// <summary>
        /// Opens an explorer menu for the user to select the folder where the screenshot is supposed to be saved.
        /// </summary>
        /// <returns>either the selected path or MyPictures</returns>
        public static string GenerateStoragePath()
        {
            var folderBrowserDialog = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog.ShowDialog();
            if(result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
            {
                return folderBrowserDialog.SelectedPath;
            }
            else
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            }
        }
    }
}