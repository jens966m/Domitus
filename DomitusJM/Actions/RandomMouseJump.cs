using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DomitusJM.Actions
{
    public static class RandomMouseJump
    {
        public static void doJump()
        {
            // Set the Current cursor, move the cursor's Position,
            // and set its clipping rectangle to the form. 
            Random rnd = new Random();
            Control control = new Control();
            Point coordinate = new Point();
            int random1 = rnd.Next(0, 1920);
            int random2 = rnd.Next(0, 1080);
            coordinate = new Point(random1, random2);
            System.Windows.Forms.Cursor.Position = control.PointToScreen(coordinate);
        }
    }
}
