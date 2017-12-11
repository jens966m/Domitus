using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Domitus
{
    public static class Screenshot
    {
        public static void TakeScreenshot()
        {
            //Create a new bitmap.
            var bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                                           Screen.PrimaryScreen.Bounds.Height,
                                           PixelFormat.Format32bppArgb);

            // Create a graphics object from the bitmap.
            var gfxScreenshot = Graphics.FromImage(bmpScreenshot);

            // Take the screenshot from the upper left corner to the right bottom corner.
            gfxScreenshot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
                                        Screen.PrimaryScreen.Bounds.Y,
                                            0,
                                            0,
                                            Screen.PrimaryScreen.Bounds.Size,
                                            CopyPixelOperation.SourceCopy);

            // Save the screenshot to the specified path that the user has chosen.
            bmpScreenshot.Save("Screenshot.png", ImageFormat.Png);

            //Converting image to bytes
            Image img = Image.FromFile("Screenshot.png");

            //Saving to byte array
            saveByteArrayToFile(imageToByteArray(img));

            //Converting bytes to image
            Image convertingImage = byteArrayToImage(getByteArrayFromFile("Temp.txt"));

            //Save new converted image
            convertingImage.Save("Screenshot2.png");
        }

        public static byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();

        }

        public static Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public static void saveByteArrayToFile(byte[] array)
        {
            File.WriteAllBytes("Temp.txt", array);
        }

        public static byte[] getByteArrayFromFile(string directory)
        {
            byte[] file = File.ReadAllBytes(directory);
            return file;
        }
    }
}
