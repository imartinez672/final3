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
    public partial class IncomeForm : Form
    {
        public int UserId;
        sqlQueries queries = new sqlQueries();
        public IncomeForm(string userid)
        {
            InitializeComponent();
            UserId = Convert.ToInt32(userid);
        }

        private void IncomeForm_Load(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            queries.DepositInsert()
        }
    }
}
