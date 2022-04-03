using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection;

namespace Flappy_Bird
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name, password, repassword;
            name = textBox1.Text;
            password = textBox2.Text;
            repassword = textBox3.Text;
            if (password == repassword)//两次输入的密码一致
            {
                string myConn = @"Data Source=IBN5100\SQLEXPRESS;Initial Catalog=BIRD;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(myConn);  //实例化连接对象
                sqlConnection.Open();

                String sql = "INSERT INTO Up(name,password) VALUES('" + name + "','" + password + "')";//SQL语句向表中写入数据
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Success!");

            }
            else
            {
                MessageBox.Show("Password is not same.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
