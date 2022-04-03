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
    public partial class JiFenBan : UserControl
    {

        int value = 0;

        public int Value
        {
            get => value;
            set
            {
                this.value = value;
                SetValue(value);
            }
        }

        public JiFenBan()
        {
            InitializeComponent();
        }

        public void SetValue(int v)
        {
            string vv;
            if(v < 10)
            {
                vv = "0" + v.ToString();
            }
            else
            {
                vv = v.ToString();
            }
            label1.Text = vv;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
