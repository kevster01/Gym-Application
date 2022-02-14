using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cst150Project
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void LogInFormExit_lbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogIn_btn_Click(object sender, EventArgs e)
        {
            if (Username_txt.Text == "Admin" && Password_txt.Text == "Password")
            {
                new AdminPortal().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please Enter Valid Username and Password");
                Username_txt.Clear();
                Password_txt.Clear();
                Username_txt.Focus();
            }
        }

        private void Clear_lbl_Click(object sender, EventArgs e)
        {
            Username_txt.Clear();
            Password_txt.Clear();
            Username_txt.Focus();
        }

        private void Help_lbl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Refer to LoginForm.cs file for Username/Password");

        }
    }
}
