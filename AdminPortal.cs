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
    public partial class AdminPortal : Form
    {
        public AdminPortal()
        {
            InitializeComponent();
        }

        private void AdminPortalExit_lbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminPortalLogout_btn_Click(object sender, EventArgs e)
        {
            new LogInForm().Show();
            this.Hide();
        }

        private void ModifyItems_btn_Click(object sender, EventArgs e)
        {
            new ItemsPortal().Show();
            this.Hide(); 
        }

        private void ModifyMembers_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new members().Show();
        }
    }
}
