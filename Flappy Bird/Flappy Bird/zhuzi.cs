using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird
{
    public partial class zhuzi : UserControl
    {

        int speed = 3;
        public zhuzi()
        {
            InitializeComponent();
        }

        public bool isScore = false;

        private void Movetimer_Tick(object sender, EventArgs e)
        {
            if (Form1.f1.isOver)
            {
                Form1.zhuzis.Clear();
                Dispose();
                return;
            }
            if(Location.X < -Width)
            {
                int[] dx = new int[3];
                int index = 0;
                foreach(zhuzi zz in Form1.zhuzis)
                {
                    dx[index] = zz.Location.X;
                    index++;
                }
                int max = dx.Max();
                Location = new Point(max + Form1.zhuzijianju, Form1.random.Next(-200, -1));
            }
            Point p = Location;
            p.Offset(-speed, 0);
            Location = p;


            if(Tools.isOverLapC1(TriggerMid, Form1.f1.Player))
            {
                if (!isScore)
                {
                    Form1.f1.score++;
                    Form1.f1.jiFenBan1.Value = Form1.f1.score;
                    isScore = true;
                }
            }
            else
            {
                isScore = false;
            }

            if (Tools.isOverLapC1(up, Form1.f1.Player))
            {
                Form1.f1.GameOver();
            }
            if (Tools.isOverLapC1(down, Form1.f1.Player))
            {
                Form1.f1.GameOver();
            }
        }

        private void up_Click(object sender, EventArgs e)
        {

        }
    }
}
