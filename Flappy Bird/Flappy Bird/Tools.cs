using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Flappy_Bird
{
    public class Tools
    {
        public static bool isOverLap(Control c1, Control c2)
        {
            return c1.Location.X + c1.Width > c2.Location.X && c1.Location.Y + c1.Height > c2.Location.Y && c2.Location.X + c2.Width > c1.Location.X && c2.Location.Y + c2.Height > c1.Location.Y;
        }

        public static bool isOverLapC1(Control c1, Control c2)
        {
            return c1.Location.X + c1.Parent.Location.X + c1.Width > c2.Location.X && c1.Location.Y + c1.Parent.Location.Y + c1.Height > c2.Location.Y && c2.Location.X + c2.Width > c1.Location.X + c1.Parent.Location.X && c2.Location.Y + c2.Height > c1.Location.Y + c1.Parent.Location.Y;
        }
    }
}
