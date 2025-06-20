﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.OleDb;


namespace LoginForm
{
    public partial class Form1 : Form
    {
        private string username;
        private string password;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GC.Collect();
            this.MdiParent = Globals.parentForm;
            this.Dock = DockStyle.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtUsername.Text != null && txtPassword != null)
            {
                username = txtUsername.Text;
                password = txtPassword.Text;
            }

            try
            {
                Globals.UserType = DBHelper.CheckLogin(username, password);
                if(Globals.UserType == "Kernel")
                {
                    HomeScreen homeScreen = new HomeScreen();
                    homeScreen.Show();
                    this.Close();
                }
                else
                {
                    if(Globals.UserType == "Basic")
                    {
                        HomeScreenBasic homeScreenBasic = new HomeScreenBasic();
                        homeScreenBasic.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Utilizador não existente!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
