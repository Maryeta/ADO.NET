using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApressFinancialApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            customersTableAdapter1.Fill(apressFinancialDataSet.Customers);
            gridView1.DataSource = apressFinancialDataSet.Customers;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            customersTableAdapter1.Update(apressFinancialDataSet);
        }
    }
}
