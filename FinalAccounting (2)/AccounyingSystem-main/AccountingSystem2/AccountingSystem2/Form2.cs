using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingSystem2
{
    public partial class Form2 : Form
    {
        public Form2(string username)
        {

            
            InitializeComponent();
            label2.Text = username;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=localhost;database=AccountingSystem;UID=sa;password=123456789");
            SqlCommand cmd = new SqlCommand("select * from UserLogins where UserName=@UserName and Password=@Password", con);
           
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            con.Open();

            con.Close();
            dataGridView1.DataSource = dt;

        }
    }
}
