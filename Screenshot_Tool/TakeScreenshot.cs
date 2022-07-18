using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Screenshot_Tool
{
    /// <summary>
    /// Gets the bounds of all screens and creats a screenshot accordingly
    /// 
    /// Michael Hadorn
    /// </summary>
    public class TakeScreenshot
    {
        private readonly int screenTop = SystemInformation.VirtualScreen.Top;
        private readonly int screenLeft = SystemInformation.VirtualScreen.Left;
        private readonly int screenWidth= SystemInformation.VirtualScreen.Width;
        private readonly int screenHeight = SystemInformation.VirtualScreen.Height;
        /// <summary>
        /// Creats a screenshot of the selected monitor
        /// <param name="monitor">selected monitor</param>
        /// <returns>taken screenshot</returns>
        public Bitmap CaptureScreen(int monitor)
        {
            Screen[] screens = Screen.AllScreens;
            Bitmap screenshot = new Bitmap(screens[monitor].Bounds.Width, screens[monitor].Bounds.Height, PixelFormat.Format32bppArgb);
            Graphics createGraphic = Graphics.FromImage(screenshot);
            createGraphic.CopyFromScreen(screens[monitor].Bounds.X, screens[monitor].Bounds.Y, 0, 0, screens[monitor].Bounds.Size);
            return screenshot;
        }
        /// <summary>
        /// Creats a screenshot of all monitors
        /// </summary>
        /// <returns>taken screenshot</returns>
        public Bitmap CaptureAllScreens()
        {
            Bitmap screenshot = new Bitmap(screenWidth, screenHeight, PixelFormat.Format32bppArgb);
            Graphics createGraphic = Graphics.FromImage(screenshot);
            createGraphic.CopyFromScreen(screenLeft, screenTop, 0, 0, screenshot.Size);
            return screenshot;
        }
    }
}