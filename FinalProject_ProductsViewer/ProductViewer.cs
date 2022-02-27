using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;

namespace FinalProject_ProductsViewer
{
    public partial class ProductViewer : Form
    {
        private NorthwindEntities1 northwindContext;
        public ProductViewer()
        {
            InitializeComponent();
        }

        private void ProductViewer_Load(object sender, EventArgs e)
        {
            northwindContext = new NorthwindEntities1();

            List<Category> categories = northwindContext.Categories.Include(c => c.Products).ToList();
            this.categoryList.DisplayMember = "CategoryName";
            this.categoryList.DataSource = categories;

            List<Supplier> suppliers = northwindContext.Suppliers.ToList();
            this.supplierList.DisplayMember = "CompanyName";
            this.supplierList.DataSource = suppliers;
        }

        private void categoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category category = (Category)this.categoryList.SelectedItem;
            List<Product> products = category.Products.ToList();
            dataGridView.DataSource = products;

            dataGridView.Columns["Category"].Visible = false;
            dataGridView.Columns["Supplier"].Visible = false;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            { 
                Supplier supplier = (Supplier)this.supplierList.SelectedItem;
                Category category = (Category)this.categoryList.SelectedItem;

                Product product = new Product
                {
                    ProductName = this.productNameTextBox.Text,
                    QuantityPerUnit = this.quantityTextBox.Text,
                    UnitPrice = decimal.Parse(this.unitPriceTextBox.Text),
                    UnitsInStock = short.Parse(this.unitsInStockTextBox.Text),
                    Discontinued = false,
                    SupplierID = supplier.SupplierID,
                    CategoryID = category.CategoryID
                };
                northwindContext.Products.Add(product);
                northwindContext.SaveChanges();

                List<Product> products = category.Products.ToList();
                dataGridView.DataSource = products;

                //Output();
                //this.Refresh();

                productNameTextBox.Text = String.Empty;
                quantityTextBox.Text = String.Empty;
                unitPriceTextBox.Text = String.Empty;
                unitsInStockTextBox.Text = String.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Output()
        {
            dataGridView.DataSource = northwindContext.Products.ToList();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                northwindContext.SaveChanges();
                MessageBox.Show("Changes saved to the database.");
                this.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Product product = (Product)dataGridView.CurrentRow.DataBoundItem;
            northwindContext.Entry(product).State = System.Data.Entity.EntityState.Deleted;
            northwindContext.SaveChanges();
            Output();
            MessageBox.Show($"{product.ProductName} has been removed");
        }
    }
}
