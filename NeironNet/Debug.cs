using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NeironNet
{
    public static class Dubug
    {
        public static TextBox console;

        public static void Log(string _message)
        {
            console.Text += (_message + "\r\n");
        }
    }
}
