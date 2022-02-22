using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQsqlSproc
{
    public partial class Form1 : Form
    {
        Northwnd db = new Northwnd(@"C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\northwnd.mdf");
        public Form1()
        {
            InitializeComponent();
        }

        private void orderDetailsButton_Click(object sender, EventArgs e)
        {
            string param = orderTextBox.Text;
            var custquery = db.CustOrdersDetail(Convert.ToInt32(param));
            string msg = "";
            foreach (CustOrdersDetailResult custOrdersDetail in custquery)
            {
                msg = msg + custOrdersDetail.ProductName + "\n";
            }
            if (msg == "")
                msg = "No results.";
            MessageBox.Show(msg);

            param = "";
            orderTextBox.Text = "";
        }

        private void orderHistoryButton_Click(object sender, EventArgs e)
        {
            string param = CustomerTextBox.Text;
            var custquery = db.CustOrderHist(param);
            string msg = "";
            foreach (CustOrderHistResult custOrdHist in custquery)
            {
                msg = msg + custOrdHist.ProductName + "\n";
            }
            MessageBox.Show(msg);
            param = "";
            CustomerTextBox.Text = "";
        }
    }
}
