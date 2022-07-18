using System;
using System.Drawing;
using System.Windows.Forms;

namespace Screenshot_Tool
{
    /// <summary>
    /// This form handles everything the user sees and interacts with.
    /// 
    /// Michael Hadorn
    /// </summary>
    public partial class FrmMain : Form
    {
        private Bitmap screenshot;
        private string screenshotName;
        private string screenshotPath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
        /// <summary>
        /// Prepares all the elements in the form and populates the comboboxes
        /// </summary>
        public FrmMain()
        {
            InitializeComponent();
            PopulateCombobox();
        }
        private void BtnScreenshot_Click(object sender, EventArgs e)
        {
            TakeScreenshot takeScreenshot = new TakeScreenshot();
            this.WindowState = FormWindowState.Minimized;
            System.Threading.Thread.Sleep(1000);
            if(CbxScreens.SelectedItem.ToString() == "Alle Monitore")
            {
                screenshot = takeScreenshot.CaptureAllScreens();
            }
            else
            {
                screenshot = takeScreenshot.CaptureScreen(CbxScreens.SelectedIndex);
            }
            this.WindowState = FormWindowState.Normal;
            ShowScreenshot();
            BtnSave.Visible = true;
        }
        /// <summary>
        /// Sets the image of the picturebox to the captured screenshot
        /// </summary>
        public void ShowScreenshot()
        {
            PbPreview.Image = screenshot;
        }
        /// <summary>
        /// Calls the class SavesScreenshot and saves the screenshot with the given values
        /// </summary>
        /// <param name="name">generated name of screenshot</param>
        /// <param name="screenshot">screenshot itself</param>
        /// <param name="path">path to store screenshot</param>
        /// <param name="dataType">selected datatype</param>
        public static void SaveCurrentScreenshot(string name, Bitmap screenshot, string path, string dataType)
        {
                SaveScreenshot.SaveScreenshotFromValues(name, screenshot, path, dataType);
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
                screenshotName = ScreenshotName.GenerateScreenshotName();
                SaveCurrentScreenshot(screenshotName, screenshot, screenshotPath, Convert.ToString(CbxDataType.SelectedItem));
        }
        /// <summary>
        /// Calls class Datatypes and receives its list to populate comboboxes
        /// </summary>
        public void PopulateCombobox()
        {
            CbxDataType.DataSource = Datatypes.GenerateDataTypeList();
            CbxScreens.DataSource = GetScreens.GetAllScreens();
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            TxtSaveLocation.Text = GetStoragePath();
        }
        /// <summary>
        /// Calls class StoragePath and gets the selected path in return
        /// </summary>
        /// <returns>path selected from user</returns>
        public string GetStoragePath()
        {
            screenshotPath = StoragePath.GenerateStoragePath();
            return screenshotPath;
        }
    }
}