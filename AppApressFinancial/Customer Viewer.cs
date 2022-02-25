using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace AppApressFinancial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string GetConnectionStringByName(string name)
        {
            string returnValue = null;
            ConnectionStringSettings settings =
                ConfigurationManager.ConnectionStrings[name];
            if (settings != null)
                returnValue = settings.ConnectionString;
            return returnValue;
        }
        
        private SqlConnection ApressFinancialConnection = new SqlConnection(GetConnectionStringByName("DBConnect.ApressFinancialConnectionString"));
        private SqlDataAdapter sqlAdapter1;
        private DataSet ApressFinancialDataSet = new DataSet("ApressFinancial");
        private DataTable CustomersTable = new DataTable("Customers");

        

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlAdapter1 = new SqlDataAdapter("SELECT * FROM CustomerDetails.Customers", ApressFinancialConnection);
            ApressFinancialDataSet.Tables.Add(CustomersTable);
            sqlAdapter1.Fill(ApressFinancialDataSet.Tables["Customers"]);
            dataGridView1.DataSource = ApressFinancialDataSet.Tables["Customers"];
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            sqlAdapter1.Update(ApressFinancialDataSet, "Customers");
            ApressFinancialDataSet.Tables["Customers"].Clear();
            sqlAdapter1.Fill(ApressFinancialDataSet.Tables["Customers"]);
        }


    }
}
