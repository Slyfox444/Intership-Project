using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilyBudget
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BudgetManager manager = new BudgetManager();
            String date;

            date = DateTime.Now.ToString("yyyy-MM-dd");
            string message = "bla";
            int amount = 100;
            manager.AddConstantCost(date,message,amount);
        }
    }
}
