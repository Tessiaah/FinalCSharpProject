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
    public partial class StudentManager : Form
    {
        private DataTable studentTable = new DataTable();
        private OleDbDataAdapter adapter;
        private OleDbCommandBuilder builder;
        private OleDbConnection connection;
        private DataView dv;

        public StudentManager()
        {
            InitializeComponent();
        }

        private void StudentManager_Load(object sender, EventArgs e)
        {
            GC.Collect();
            this.MdiParent = Globals.parentForm;
            this.Dock = DockStyle.Fill;

            DBHelper.FillTable(studentTable, ref dgvStudents, ref adapter,ref builder, ref connection);
            dgvStudents.Columns[0].ReadOnly = true;
            dgvStudents.DataError += dgvStudents_DataError;
            dgvStudents.CellValidating += dgvStudents_CellValidating;
           
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                //Sends the Updates to the database
                adapter.Update(studentTable);

                //Refreshes the view for the user
                studentTable.Clear();
                adapter.Fill(studentTable);
                dgvStudents.DataSource = studentTable;
                MessageBox.Show("Sucesso!");

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Impede Utilizador de introduzir dados invalidos
        private void dgvStudents_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if(e.Exception != null)
            {
                MessageBox.Show("Tipo de Dados Inválido Introduzido!", "Formato Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }            
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string filterText = txtFilter.Text;
            DBHelper.FilterTable(studentTable, filterText, dgvStudents, ref dv);
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string filterText = txtFilter.Text;
            DBHelper.FilterTable(studentTable, filterText, dgvStudents, ref dv);
        }


        //Used to  check if certain codes exist or not
        private void dgvStudents_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            const int columnIndex1 = 3;
            const int columnIndex2 = 12;

           if (e.ColumnIndex == columnIndex1  || e.ColumnIndex == columnIndex2)
           {
                string indexValue = e.FormattedValue.ToString();

                if (string.IsNullOrWhiteSpace(indexValue))
                {
                    return;
                                         
                }
                    
                switch (e.ColumnIndex)
                {
                    case columnIndex1:

                        if (!DBHelper.CheckIfExistsParent(indexValue))
                        {
                            MessageBox.Show("Código de Encarregado de Educação não existente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            e.Cancel = true;
                        }
                        break;

                    case columnIndex2:

                        if (!DBHelper.CheckIfExistsCourse(indexValue))
                        {
                            MessageBox.Show("Código de Curso não existente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            e.Cancel = true;
                        }
                        break;

                }
           }

            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormHelper.BackFormChanger(this);
        }
    }


}
