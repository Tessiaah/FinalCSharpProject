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
    public partial class ParentManager : Form
    {
        private DataTable parentTable = new DataTable();
        private OleDbDataAdapter adapter;
        private OleDbCommandBuilder builder;
        private OleDbConnection connection;
        private DataView dv;

        public ParentManager()
        {
            InitializeComponent();
        }

        private void ParentManager_Load(object sender, EventArgs e)
        {
            GC.Collect();
            this.MdiParent = Globals.parentForm;
            this.Dock = DockStyle.Fill;

            DBHelper.FillParentTable(parentTable, ref dgvParents, ref adapter, ref builder, ref connection);
            dgvParents.Columns[0].ReadOnly = true;
            dgvParents.DataError += dgvParents_DataError;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                //Ensures there are no referential integrity issues with the student table
                DBHelper.UpdateStudentsOnParentDeletion(parentTable, connection);

                //Sends the Updates to the database
                adapter.Update(parentTable);

                //Refreshes the view for the user
                parentTable.Clear();
                adapter.Fill(parentTable);
                dgvParents.DataSource = parentTable;
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
            DBHelper.FilterTable(parentTable, filterText, dgvParents, ref dv);
        }

        private void dgvParents_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null)
            {
                MessageBox.Show("Tipo de Dados Inválido Introduzido!", "Formato Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormHelper.BackFormChanger(this);
        }
    }


}
