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

namespace FinalAccounting
{
    public partial class loginForm : Form
    {
        sqlQueries queries = new sqlQueries();
        public loginForm()
        {
            InitializeComponent();
            
        }
        

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = queries.IdentifierUser(userNameBox.Text, passworBox.Text);  

                if(dt.Rows.Count >0)
                {
                    this.Hide();
                    MainForm startMain = new MainForm(dt.Rows[0][0].ToString(), dt.Rows[0][3].ToString());
                    startMain.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void newAccBtn_Click(object sender, EventArgs e)
        {
            CreateUserForm newUser = new CreateUserForm();
            newUser.ShowDialog();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
