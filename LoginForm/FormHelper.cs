using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    internal class FormHelper
    {
        public static void BackFormChanger(Form form)
        {
            if (Globals.UserType == "Kernel")
            {
                HomeScreen homeScreen = new HomeScreen();
                homeScreen.Show();
                form.Close();
            }
            if (Globals.UserType == "Basic")
            {
                HomeScreenBasic homeScreenBasic = new HomeScreenBasic();
                homeScreenBasic.Show();
                form.Close();
            }
        }

        public static void LoginBackChanger(Form form)
        {
            Form1 frm = new Form1();
            frm.Show();
            form.Close();
        }
    }
}
