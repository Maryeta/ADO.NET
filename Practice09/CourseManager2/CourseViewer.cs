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
using System.Data.Entity.Infrastructure;
using System.Data.Objects;
using System.Data.Objects.DataClasses;


namespace CourseManager2
{
    public partial class CourseViewer : Form
    {
        private SchoolEntities schoolContext;
        public CourseViewer()
        {
            InitializeComponent();
            schoolContext = new SchoolEntities();
        }

        private void CourseViewer_Load(object sender, EventArgs e)
        {
            schoolContext = new SchoolEntities();
            List<Department> departments = schoolContext.Departments.Include(d => d.Courses).ToList();
            //courseGridView.DataSource = departments;
            this.departmentList.DisplayMember = "Name";
            this.departmentList.DataSource = departments;
        }

        private void departmentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Department department = (Department)this.departmentList.SelectedItem;
            List<Course> courses = department.Courses.ToList();
            dataGridView1.DataSource = courses;

            dataGridView1.Columns["Department"].Visible = false;
            dataGridView1.Columns["StudentGrades"].Visible = false;
            dataGridView1.Columns["OnlineCourse"].Visible = false;
            dataGridView1.Columns["OnsiteCourse"].Visible = false;
            dataGridView1.Columns["People"].Visible = false;
            dataGridView1.Columns["DepartmentId"].Visible = false;

            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }

        private void saveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                schoolContext.SaveChanges();
                MessageBox.Show("Changes saved to the database.");
                this.Refresh();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            this.Close();
            schoolContext.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }
    }
}
