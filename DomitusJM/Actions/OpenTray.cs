using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DomitusJM.Actions
{
    public static class OpenTray
    {

        [DllImport("winmm.dll", EntryPoint = "mciSendString")]
        public static extern int mciSendStringA(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);

        public static void Open()
        {
            string returnString1 = "";
            mciSendStringA("open " + "E" + ": type CDaudio alias drive" + "E", returnString1, 0, 0);
            mciSendStringA("set drive" + "E" + " door open", returnString1, 0, 0);
        }
    }
}
