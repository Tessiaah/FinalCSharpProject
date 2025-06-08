using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class HomeScreenBasic : Form
    {
        public HomeScreenBasic()
        {
            InitializeComponent();
        }

        private void HomeScreenBasic_Load(object sender, EventArgs e)
        {
            GC.Collect();
            this.MdiParent = Globals.parentForm;
            this.Dock = DockStyle.Fill;
        }

        private void btnAlunos_Click(object sender, EventArgs e)
        {
            StudentManager stdManager = new StudentManager();
            stdManager.Show();
            this.Close();
        }

        private void btnEE_Click(object sender, EventArgs e)
        {
            ParentManager parentManager = new ParentManager();
            parentManager.Show();
            this.Close();
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            CourseManager courseManager = new CourseManager();
            courseManager.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormHelper.LoginBackChanger(this);
        }
    }
}
