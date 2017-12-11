using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//AFORGE TIL WEBCAM PICTURES´FJERN HVIS UNÆDVENDIG! I TOOLS AND PACKAGES TIL SLN
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge;
using Emgu;
using Emgu.CV;
using Emgu.CV.UI;
using Emgu.CV.Structure;
using System.Drawing;
using System.Windows.Forms;

namespace DomitusJM.Actions
{
    public class WebcamPicture
    {
        VideoCapture capture;
        public void TakePicture()
        {
            try
            {
                capture = new VideoCapture(0);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
