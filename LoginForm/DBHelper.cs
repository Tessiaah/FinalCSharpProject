using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LoginForm
{
    internal class DBHelper
    {
        private static string connString = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source=C:\\Users\\ivand\\Folders\\School\\Coding\\FinalC#Project\\LoginForm\\TPProjectDB.accdb;Persist Security Info=False";

        public static bool CheckLogin(string username, string password)
        {
            string query = "SELECT * FROM Logins WHERE Username = ?  AND Password = ?";

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                conn.Open();
                using (OleDbCommand command = new OleDbCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        return reader.HasRows;
                    }
                }
            }
        }


        public static void FillTable(ref DataTable studentTable, ref DataGridView dgvStudents, ref OleDbDataAdapter adapter, ref OleDbCommandBuilder builder, ref OleDbConnection conn)
        {
            string query = "SELECT * FROM Alunos";
            try
            {
                conn = new OleDbConnection(connString);
                conn.Open();
                adapter = new OleDbDataAdapter(query, conn);
                builder = new OleDbCommandBuilder(adapter);
                adapter.Fill(studentTable);
                dgvStudents.DataSource = studentTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public static void FilterTable(DataTable studentTable, string filterText, DataGridView dgvStudents, ref DataView dv)
        {
            dv = new DataView(studentTable);
            if (filterText != null)
            {
                dv.RowFilter = $"Nome LIKE '{filterText}%'";            
            }
            dgvStudents.DataSource = dv;
        }


        public static bool CheckIfExistsParent(int value)
        {
            string query = "SELECT * FROM EncEdu WHERE CodEE = ?";

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                conn.Open();
                using (OleDbCommand command = new OleDbCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@CodEE", value);
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        return reader.HasRows;
                    }
                }
            }
        }

        public static bool CheckIfExistsCourse(int value)
        {
            string query = "SELECT * FROM Cursos WHERE CodCurso = ?";

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                conn.Open();
                using (OleDbCommand command = new OleDbCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@CodCurso", value);
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        return reader.HasRows;
                    }
                }
            }
        }


        



        //public static void UpdateStudentTable(DataTable studentTable, OleDbDataAdapter adapter)
        //{
        //    using (OleDbConnection conn = new OleDbConnection(connString))
        //    {
        //        conn.Open();

        //        adapter.SelectCommand.Connection = conn;
        //        adapter.InsertCommand.Connection = conn;
        //        adapter.UpdateCommand.Connection = conn;
        //        adapter.DeleteCommand.Connection = conn;

        //        adapter.Update(studentTable);
        //    }
        //}

    }
}
