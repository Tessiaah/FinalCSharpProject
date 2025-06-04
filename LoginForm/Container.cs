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
    public partial class Container : Form
    {
        public Container()
        {
            InitializeComponent();
        }

        private void Container_Load(object sender, EventArgs e)
        {
            Globals.parentForm = this;
            Form1 child = new Form1();
            child.MdiParent = this;
            child.Dock = DockStyle.Fill;

            child.Show();
            
        }
    }
}
