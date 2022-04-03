using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird
{
    public partial class Form2 : Form
    {

        public int score = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        public void ChangeScore()
        {
            Hide();
            label1.Text = score.ToString();
            if(score < 30)
            {
                label4.Text = "30";
            }
            else
            {
                label4.Text = score.ToString();
            }
            if (score >= 0 && score < 10)
            {
                pictureBox1.Image = Image.FromFile("10.png");
            }
            if (score >= 10 && score < 20)
            {
                pictureBox1.Image = Image.FromFile("20.png");
            }
            if (score >= 20 && score < 30)
            {
                pictureBox1.Image = Image.FromFile("30.png");
            }
            if (score >= 30 && score < 40)
            {
                pictureBox1.Image = Image.FromFile("40.png");
            }
            if (score >= 40)
            {
                pictureBox1.Image = Image.FromFile("50.jpg");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
