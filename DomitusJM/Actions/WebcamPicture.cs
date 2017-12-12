using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu; //Til webcam
using Emgu.CV;
using Emgu.CV.UI;
using Emgu.CV.Structure;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Threading;

namespace DomitusJM.Actions
{
    public class WebcamPicture
    {
        public static void TakePicture()
        {
            try
            {
                VideoCapture _capture = new VideoCapture(0); //Capture den første frame web'cammet registrerer
                Image<Bgr, Byte> image = _capture.QueryFrame().ToImage<Bgr, Byte>(); //Gem "capture"'d frame som billede
                image.ToBitmap(); //Konverter til Bitmap - da det er nemmere at sende over server?
                image.Save(@"Webcam.png");
                image.Dispose(); //Dispose så billedet ikke er gemt i memory
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
