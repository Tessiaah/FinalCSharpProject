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
    public partial class AdminManager : Form
    {
        private DataTable adminTable = new DataTable();
        private OleDbDataAdapter adapter;
        private OleDbCommandBuilder builder;
        private OleDbConnection connection;
        private DataView dv;

        public AdminManager()
        {
            InitializeComponent();
        }

        private void AdminManager_Load(object sender, EventArgs e)
        {
            GC.Collect();
            this.MdiParent = Globals.parentForm;
            this.Dock = DockStyle.Fill;

            DBHelper.FillAdminTable(adminTable, ref dgvAdmins, ref adapter, ref builder, ref connection);
            dgvAdmins.Columns[0].ReadOnly = true;
           
            dgvAdmins.DataError += dgvAdmins_DataError;
            dgvAdmins.CellValidating += dgvAdmins_CellValidating;
            dgvAdmins.CellBeginEdit += dgvAdmins_CellBeginEdit;
            dgvAdmins.UserDeletingRow += dgvAdmins_UserDeletingRow;
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string filterText = txtFilter.Text;
            DBHelper.FilterTable(adminTable, filterText, dgvAdmins, ref dv);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                //Sends the Updates to the database
                adapter.Update(adminTable);

                //Refreshes the view for the user
                adminTable.Clear();
                adapter.Fill(adminTable);
                dgvAdmins.DataSource = adminTable;
                MessageBox.Show("Sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormHelper.BackFormChanger(this);
        }
        private void dgvAdmins_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null)
            {
                MessageBox.Show("Tipo de Dados Inválido Introduzido!", "Formato Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvAdmins_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            const int columnIndex1 = 3;
            const int columnIndex2 = 1;
            string indexValue;

            if (e.ColumnIndex == columnIndex1)
            {
                indexValue = e.FormattedValue.ToString();
                if (indexValue != "Basic" &&  indexValue != "Kernel")
                {
                    MessageBox.Show("Valores Aceites: Basic ou Kernel", "Permissão não existente!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                }
                
            }
            else
            {
                //Makes it be able to not give issues when not altering anything
                if (e.ColumnIndex == columnIndex2)
                {
                    indexValue = e.FormattedValue?.ToString() ?? "";

                    string currentValue = dgvAdmins.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString() ?? "";

                    if (indexValue == currentValue)
                    {
                        return;
                    }

                    if (DBHelper.CheckUsernameExists(indexValue))
                    {
                        MessageBox.Show("Utilizador já existente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        e.Cancel = true;
                    }
                }
            }
        }

        private void dgvAdmins_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            //Prevent edtiting on the ultimate admin
            var idValue = dgvAdmins.Rows[e.RowIndex].Cells["ID"].Value?.ToString();

            if (idValue != null && idValue == "1")
            {
                e.Cancel = true; 
            }
        }

        private void dgvAdmins_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            //Prevents the ultimate admin from being deleted
            var idValue = e.Row.Cells["ID"].Value?.ToString();

            if (idValue != null && idValue.StartsWith("1"))
            {
                MessageBox.Show("Não é possível eliminar este administrador!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true; 
            }
        }
    }
}
