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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("server=localhost;database=AccountingSystem;UID=sa;password=123456789");
                SqlCommand cmd = new SqlCommand("select * from UserLogins where UserName=@UserName and Password=@Password", con);
                cmd.Parameters.AddWithValue("@UserName", usernameBox.Text);
                cmd.Parameters.AddWithValue("@Password", passwordBox.Text);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                con.Open();
                con.Close();

                if (dt.Rows.Count > 0)
                {
                    Form2 WelcomePage = new Form2(dt.Rows[0][1].ToString());

                    Hide();
                    WelcomePage.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("wrong user info");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
