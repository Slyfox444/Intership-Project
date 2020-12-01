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

namespace FamilyBudget
{
    public partial class Form1 : Form
    {
        BudgetManager bm = new BudgetManager();

        public Form1()
        {
            InitializeComponent();
        }

        private void ConstantIncome_Click(object sender, EventArgs e)
        {
            ConstantIncome constantIncome = new ConstantIncome();
            constantIncome.Show();


            BudgetManager manager = new BudgetManager();
            String date;

            date = DateTime.Now.ToString("yyyy-MM-dd");
            string message = "bla";
            int amount = 100;
            manager.AddConstantCost(date,message,amount);
        }

        private void CstCost_Click(object sender, EventArgs e)
        {
            ConstantCost constantCost = new ConstantCost();
            constantCost.Show();
        }

        private void Cst_Click(object sender, EventArgs e)
        {
            Cost cost = new Cost();
            cost.Show();
        }

        private void Incm_Click(object sender, EventArgs e)
        {
            Income income = new Income();
            income.Show();
        }

        public string sqlQRY { get; set; }

        private void label2_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Desktop\Intershit\Intership-Project\FamilyBudgetDB.mdf;Integrated Security=True";
            SqlConnection myDbconnection = new SqlConnection(connectionString);
            myDbconnection.Open();
            sqlQRY = "SELECT AMOUNT FROM UNITS";
            SqlCommand cmd = new SqlCommand(sqlQRY, myDbconnection);

            var value = (String)cmd.ExecuteScalar();

            if (!string.IsNullOrEmpty(value))
            {
                label2.Text = value;

            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
