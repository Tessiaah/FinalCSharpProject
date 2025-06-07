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

        public static void FillParentTable(ref DataTable parentTable, ref DataGridView dgvParents, ref OleDbDataAdapter adapter, ref OleDbCommandBuilder builder, ref OleDbConnection conn)
        {
            string query = "SELECT * FROM EncEdu";
            try
            {
                conn = new OleDbConnection(connString);
                conn.Open();
                adapter = new OleDbDataAdapter(query, conn);
                builder = new OleDbCommandBuilder(adapter);
                adapter.Fill(parentTable);
                dgvParents.DataSource = parentTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void FillCourseTable(ref DataTable courseTable, ref DataGridView dgvCourses, ref OleDbDataAdapter adapter, ref OleDbCommandBuilder builder, ref OleDbConnection conn)
        {
            string query = "SELECT * FROM Cursos";
            try
            {
                conn = new OleDbConnection(connString);
                conn.Open();
                adapter = new OleDbDataAdapter(query, conn);
                builder = new OleDbCommandBuilder(adapter);
                adapter.Fill(courseTable);
                dgvCourses.DataSource = courseTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        public static void FilterTable(DataTable dataTable, string filterText, DataGridView dgvGridView, ref DataView dv)
        {
            dv = new DataView(dataTable);
            if (filterText != null)
            {
                dv.RowFilter = $"Nome LIKE '{filterText}%'";            
            }
            dgvGridView.DataSource = dv;
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

        public static void UpdateStudentsOnParentDeletion(DataTable parentTable, OleDbConnection conn)
        {
            string query = "UPDATE Alunos SET CodEE = NULL WHERE CodEE = ?";

            foreach (DataRow row in parentTable.Rows)
            {
                if (row.RowState == DataRowState.Deleted)
                {
                    var deletedCode = row["CodEE", DataRowVersion.Original];
                    using (OleDbCommand cmd =  new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CodEE", deletedCode);
                        cmd.ExecuteNonQuery();
                    }

                }
            }
        }

        public static void UpdateStudentsOnCourseDeletion(DataTable courseTable, OleDbConnection conn)
        {
            string query = "UPDATE Alunos SET CodCurso = NULL WHERE CodCurso = ?";

            foreach (DataRow row in courseTable.Rows)
            {
                if (row.RowState == DataRowState.Deleted)
                {
                    var deletedCode = row["CodCurso", DataRowVersion.Original];
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CodCurso", deletedCode);
                        cmd.ExecuteNonQuery();
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
