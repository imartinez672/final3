using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalAccounting
{
    public partial class ExpenseForm : Form
    {

        sqlQueries queries = new sqlQueries();
        public int UserId;
        public ExpenseForm(string id)
        {
            InitializeComponent();
            UserId = Convert.ToInt32(id);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if(amountBox.Text =="" && descriptionBox.Text == "" && comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Required fields missing");
            }
            else
            {
                try
                {
                    double amount = Convert.ToDouble(amountBox.Text);
                    queries.ExpenseInsert(amount, dateTimePicker1.Value, descriptionBox.Text, comboBox1.Text, UserId);
                    MessageBox.Show("Expense Captured");
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }

        }

        private void amountBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExpenseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
