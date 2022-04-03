using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Flappy_Bird
{

    public partial class Form1 : Form
    {
        public static int zhuzijianju = 240;

        bool GameStart = false;

        public static ArrayList zhuzis = new ArrayList();
        int speed = -12;

        public static Random random = new Random();

        public int score = 0;

        public bool isScore = false;

        public static Form1 f1;

        public bool isOver = false;

        public Form1()
        {
            InitializeComponent();
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (isOver)
            {
                Player.Dispose();
                return;
            }
            if (Player.Location.Y + speed < 0)
            {
                speed++;
                return;
            }
            PlayerMove(Player, 0, speed);
            speed++;

            if(Player.Location.Y > panel1.Height)
            {
                GameOver();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!GameStart)
            {
                ChuShiHuaZhuZi();
                GameStart = true;
            }
            timer1.Enabled = true;
            speed = -12;
        }

        public void PlayerMove(Control c,int dx,int dy)
        {
            Point p = c.Location;
            p.Offset(dx, dy);
            c.Location = p;
        }

        public void ChuShiHuaZhuZi()
        {
            zhuzis = new ArrayList();
            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    zhuzi zz = new zhuzi();
                    zz.Location = new Point(panel1.Width, 0);
                    zz.Location = new Point(zz.Location.X, random.Next(-200, -1));
                    panel1.Controls.Add(zz);
                    zhuzis.Add(zz);
                }
                else
                {
                    zhuzi before = (zhuzi)zhuzis[i - 1];
                    zhuzi zz = new zhuzi();
                    zz.Location = new Point(before.Location.X + zhuzijianju, 0);
                    zz.Location = new Point(zz.Location.X, random.Next(-200, -1));
                    panel1.Controls.Add(zz);
                    zhuzis.Add(zz);
                }
                

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            f1 = this;
            label5.Text = "30";
        }

        public void GameOver()
        {
            isOver = true;
            Hide();
            Form2 f2 = new Form2();
            f2.score = score;
            f2.ChangeScore();
            f2.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void jiFenBan1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void jiFenBan2_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
