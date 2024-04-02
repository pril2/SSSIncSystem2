using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSSIncSystem
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {

            DialogResult check = MessageBox.Show("Are you sure you want to logout?"
              , "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
            }

        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            dashboard2.Visible = true;
            addEmployee2.Visible = false;

            Dashboard dashForm = dashboard2 as Dashboard;

            if (dashForm != null)
            {
                dashForm.RefreshData();
            }
        }

        private void addEmployee_btn_Click(object sender, EventArgs e)
        {
            dashboard2.Visible = false;
            addEmployee2.Visible = true;

            AddEmployee addEmForm = addEmployee2 as AddEmployee;

            if (addEmForm != null)
            {
                addEmForm.RefreshData();
            }
        }
    }
}
    
