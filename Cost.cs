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
    public partial class Cost : Form
    {
        BudgetManager bm = new BudgetManager();
        public Cost()
        {
            InitializeComponent();
        }

        private void AddBT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DescriptionTB.Text) && string.IsNullOrEmpty(ValueTB.Text))
            {
                MessageBox.Show("You need to fill the boxes!");
            }
            else
            {
                float value = float.Parse(ValueTB.Text);
                string date = this.dateTimePicker1.Value.ToString();
                string description = DescriptionTB.Text;
                bm.AddCost(date, description, value);
                MessageBox.Show("Cost is added!");
                DescriptionTB.Text = "";
                ValueTB.Text = "";
            }
        }

        private void ClearBT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DescriptionTB.Text) && string.IsNullOrEmpty(ValueTB.Text))
            {
                MessageBox.Show("Boxes are already empty!");
            }
            else
            {
                DescriptionTB.Text = "";
                ValueTB.Text = "";
            }

        }
        private void ValueTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && ValueTB.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(ch) && !Char.IsControl(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
