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
    public partial class Form3 : Form
    {
        public string hightestscore;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name, password;
            name = textBox1.Text;
            password = textBox2.Text;
            String myconn = @"Data Source=IBN5100\SQLEXPRESS;Initial Catalog=BIRD;Integrated Security=True";//数据库实例连接字符串
            SqlConnection sqlConnection = new SqlConnection(myconn);//新建数据库连接实例
            sqlConnection.Open();//打开数据库连接
            String sql = "select name,password from Up where name='" + name + "'and password='" + password + "'";//SQL语句实现表数据的读取
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, myconn);
            adapter.Fill(ds, "hightest");
            hightestscore = "30";//ds.Tables[0].ToString();


            try
            {
            if (sqlDataReader.HasRows)//满足用户名与密码一致，进入下一个界面
                {
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Hide();
                }
                else//如果登录失败，询问是否注册新用户
                {
                    DialogResult dr = MessageBox.Show("Sign up？", "Failed in.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)//打开注册界面
                    {
                        Form4 form4 = new Form4();
                        form4.Show();
                        this.Hide();
                    }
                    else
                    {
                        this.Show();
                    }
                }
            }catch (Exception msg)
                {
                    throw new Exception(msg.ToString());  //处理异常信息
                }
           }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
