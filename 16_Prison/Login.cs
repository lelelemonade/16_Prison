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

namespace _16_Prison
{
    public partial class Login : Form
    {
        public string connection = "server=localhost;database=16jail;user id=test;pwd=test";
        SqlConnection conn;
        Main main;

        public Login()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connection);
            conn.Open();
            if(conn.State.ToString()!="open")
            {
                new Warning("数据库连接不成功");
            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                Warning noaccount = new Warning("请输入账户");
                noaccount.Show();
            }
            else if(textBox2.Text=="")
            {
                Warning nopassword = new Warning("请输入密码");
                nopassword.Show();
            }
            else
            {
                main = new Main();
                main.Show();
                this.Hide();
            }
        }
    }
}
