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
    public partial class MainForm : Form
    {
        public string UserId;
        sqlQueries queries = new sqlQueries();
        public MainForm(string userId, string userName)
        {
            InitializeComponent();
             UserId = userId;
            nameLabel.Text = userName;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(UserId);
            try
            {
                DataTable dt = new DataTable();
            
                dt = queries.GetExpenses(id);

                ExpenseViewGrid.DataSource = dt;
                ExpenseViewGrid.Columns[2].DisplayIndex = 3;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ExpenseForm newExpense = new ExpenseForm(UserId);
            newExpense.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            IncomeForm newIncome = new IncomeForm(UserId);
            newIncome.ShowDialog();
        }

        private void ExpenseViewGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
