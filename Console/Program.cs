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

            actions.Screenshot();
            
            //Skriv hvor lang tid det har taget at køre koden
            watch.Stop();
            string time = watch.Elapsed.TotalSeconds.ToString();
            Console.WriteLine("Took: " + time);
            Console.ReadKey();
        }

    }
}
