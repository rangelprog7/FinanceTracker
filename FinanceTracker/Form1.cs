using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private ListViewItem selectedIncomeItem = null;
        private ListViewItem selectedExpensesItem = null;


        private void Form1_Load(object sender, EventArgs e)
        {
            lv_income.View = View.Details;
            lv_income.Columns.Add("Name", 150);
            lv_income.Columns.Add("Money", 100);

            lv_expenses.View = View.Details;
            lv_expenses.Columns.Add("Name", 150);
            lv_expenses.Columns.Add("Money", 100);

            lv_income.SelectedIndexChanged += lv_income_SelectedIndexChanged;
            lv_expenses.SelectedIndexChanged += lv_expenses_SelectedIndexChanged;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_income_name.Text))
            {
                if (string.IsNullOrWhiteSpace(tb_income_money.Text))
                {
                    if (selectedIncomeItem != null)
                    {
                        lv_income.Items.Remove(selectedIncomeItem);
                        selectedIncomeItem = null;
                    }
                }
                else
                {
                    MessageBox.Show("Please provide a name for the income item.");
                    return;
                }
            }
            else
            {
                if (!double.TryParse(tb_income_money.Text, out double money))
                {
                    MessageBox.Show($"The value '{tb_income_money.Text}' is NOT a number.");
                    return;
                }
                else
                {
                    if (selectedIncomeItem == null)
                    {
                        lv_income.Items.Add(new ListViewItem(tb_income_name.Text)
                        {
                            SubItems = { money.ToString() }
                        });
                    }
                    else
                    {
                        selectedIncomeItem.SubItems[0].Text = tb_income_name.Text;
                        selectedIncomeItem.SubItems[1].Text = money.ToString();
                        selectedIncomeItem = null;
                    }
                }
            }

            tb_income_name.Text = "";
            tb_income_money.Text = "";

            UpdateDifferenceLabel();
        }

        private void b_expenses_submit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_expenses_name.Text))
            {
                if (string.IsNullOrWhiteSpace(tb_expenses_money.Text))
                {
                    if (selectedExpensesItem != null)
                    {
                        lv_expenses.Items.Remove(selectedExpensesItem);
                        selectedExpensesItem = null;
                    }
                }
                else
                {
                    MessageBox.Show("Please provide a name for the income item.");
                    return;
                }
            }
            else
            {
                if (!double.TryParse(tb_expenses_money.Text, out double money))
                {
                    MessageBox.Show($"The value '{tb_expenses_money.Text}' is NOT a number.");
                    return;
                }
                else
                {
                    if (selectedExpensesItem == null)
                    {
                        lv_expenses.Items.Add(new ListViewItem(tb_expenses_name.Text)
                        {
                            SubItems = { money.ToString() }
                        });
                    }
                    else
                    {
                        selectedExpensesItem.SubItems[0].Text = tb_expenses_name.Text;
                        selectedExpensesItem.SubItems[1].Text = money.ToString();
                        selectedExpensesItem = null;
                    }
                }
            }

            tb_expenses_name.Text = "";
            tb_expenses_money.Text = "";

            UpdateDifferenceLabel();
        }

        private void b_income_edit_Click(object sender, EventArgs e)
        {
            if (selectedIncomeItem == null)
            {
                MessageBox.Show("Please select an income item to edit.");
                return;
            }

            if (!double.TryParse(tb_income_money.Text, out double money))
            {
                MessageBox.Show($"The value '{tb_income_money.Text}' is NOT a number.");
                return;
            }

            selectedIncomeItem.SubItems[0].Text = tb_income_name.Text;
            selectedIncomeItem.SubItems[1].Text = money.ToString();

            tb_income_name.Text = "";
            tb_income_money.Text = "";
            selectedIncomeItem = null;

            UpdateDifferenceLabel();
        }

        private void b_expenses_edit_Click(object sender, EventArgs e)
        {
            if (selectedExpensesItem == null)
            {
                MessageBox.Show("Please select an expense item to edit.");
                return;
            }

            if (!double.TryParse(tb_expenses_money.Text, out double money))
            {
                MessageBox.Show($"The value '{tb_expenses_money.Text}' is NOT a number.");
                return;
            }

            selectedExpensesItem.SubItems[0].Text = tb_expenses_name.Text;
            selectedExpensesItem.SubItems[1].Text = money.ToString();

            tb_expenses_name.Text = "";
            tb_expenses_money.Text = "";
            selectedExpensesItem = null;

            UpdateDifferenceLabel();
        }

        private double CalculateTotal(ListView listView)
        {
            double total = 0;
            foreach (ListViewItem item in listView.Items)
            {
                if (double.TryParse(item.SubItems[1].Text, out double value))
                {
                    total += value;
                }
            }
            return total;
        }

        private void UpdateDifferenceLabel()
        {
            double totalIncome = CalculateTotal(lv_income);
            double totalExpenses = CalculateTotal(lv_expenses);
            double difference = totalIncome - totalExpenses;

            lbl_difference.Text = $"Difference: {difference}";
        }

        private void b_load_Click(object sender, EventArgs e)
        {
            ListViewHelper.LoadListViewFromJSON(lv_income, "income.json");
            ListViewHelper.LoadListViewFromJSON(lv_expenses, "expenses.json");
            UpdateDifferenceLabel();
            MessageBox.Show("Data loaded successfully!");
        }

        private void b_save_Click(object sender, EventArgs e)
        {
            ListViewHelper.SaveListViewToJSON(lv_income, "income.json");
            ListViewHelper.SaveListViewToJSON(lv_expenses, "expenses.json");
            MessageBox.Show("Data saved successfully!");
        }

        private void lv_income_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_income.SelectedItems.Count > 0)
            {
                selectedIncomeItem = lv_income.SelectedItems[0];
                tb_income_name.Text = selectedIncomeItem.SubItems[0].Text;
                tb_income_money.Text = selectedIncomeItem.SubItems[1].Text;
            }
        }

        private void lv_expenses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_expenses.SelectedItems.Count > 0)
            {
                selectedExpensesItem = lv_expenses.SelectedItems[0];
                tb_expenses_name.Text = selectedExpensesItem.SubItems[0].Text;
                tb_expenses_money.Text = selectedExpensesItem.SubItems[1].Text;
            }
        }
    }
}
