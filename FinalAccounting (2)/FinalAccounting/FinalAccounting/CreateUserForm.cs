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
    public partial class CreateUserForm : Form
    {
        public CreateUserForm()
        {
            InitializeComponent();
        }
        sqlQueries queries = new sqlQueries();
        private void CreateUserBtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (queries.SelectUser(userNameBox.Text))
                {
                    MessageBox.Show("UserName already taken");
                }

                else
                {
                    try
                    {
                        queries.InsertInto(userNameBox.Text, passBox.Text,firstNameBox.Text,lastNameBox.Text);

                        MessageBox.Show("User Created Succesfully");

                    }catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        //con.Close();
                        Close();
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backMainBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
