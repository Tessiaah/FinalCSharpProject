using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class CourseManager : Form
    {
        private DataTable courseTable = new DataTable();
        private OleDbDataAdapter adapter;
        private OleDbCommandBuilder builder;
        private OleDbConnection connection;
        private DataView dv;

        public CourseManager()
        {
            InitializeComponent();
        }

        private void CourseManager_Load(object sender, EventArgs e)
        {
            GC.Collect();
            this.MdiParent = Globals.parentForm;
            this.Dock = DockStyle.Fill;

            DBHelper.FillCourseTable(ref courseTable, ref dgvCourses, ref adapter, ref builder, ref connection);
            dgvCourses.Columns[0].ReadOnly = true;
            dgvCourses.DataError += dgvCourses_DataError;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                //Ensures there are no referential integrity issues with the student table
                DBHelper.UpdateStudentsOnCourseDeletion(courseTable, connection);

                //Sends the Updates to the database
                adapter.Update(courseTable);

                //Refreshes the view for the user
                courseTable.Clear();
                adapter.Fill(courseTable);
                dgvCourses.DataSource = courseTable;
                MessageBox.Show("Sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string filterText = txtFilter.Text;
            DBHelper.FilterTable(courseTable, filterText, dgvCourses, ref dv);
        }

        private void dgvCourses_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null)
            {
                MessageBox.Show("Tipo de Dados Inválido Introduzido!", "Formato Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomeScreen homeScreen = new HomeScreen();
            homeScreen.Show();
            this.Close();
        }
    }
}
