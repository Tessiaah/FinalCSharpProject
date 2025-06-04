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
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            this.MdiParent = Globals.parentForm;
            this.Dock = DockStyle.Fill;
        }

        private void btnAlunos_Click(object sender, EventArgs e)
        {
            StudentManager stdManager = new StudentManager();
            stdManager.Show();
            this.Close();
        }
    }
}
