using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domitus
{
    class Program
    {
        Actions actions = new Actions();
        public static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }

        public void Run()
        {
            //Kig hvor lang tid det tager at køre koden
            Stopwatch watch = new Stopwatch();
            watch.Start();

            Console.WriteLine("Trying to take screen..");
            actions.Screenshot();
            Console.WriteLine("Took screen");
            Console.WriteLine("Converting image to bytes..");
            Image img = Image.FromFile("Screenshot.png");
            Console.WriteLine("Converting image to bytes..");
            Console.WriteLine("Trying to save array as file..");
            saveByteArrayToFile(imageToByteArray(img));
            Console.WriteLine("Saved as bytes..");
            Console.WriteLine("Trying to convert bytes to image..");
            Image convertingImage = byteArrayToImage(getByteArrayFromFile("Temp.txt"));
            convertingImage.Save("Screenshot2.png");
            Console.WriteLine("Done");


            //Skriv hvor lang tid det har taget at køre koden
            watch.Stop();
            string time = watch.Elapsed.TotalSeconds.ToString();
            Console.WriteLine("Took: " + time);
            Console.ReadKey();
        }
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public void saveByteArrayToFile(byte[] array)
        {
            File.WriteAllBytes("Temp.txt", array);
        }

        public byte[] getByteArrayFromFile(string directory)
        {
            byte[] file = File.ReadAllBytes(directory);
            return file;
        }
    }
}
