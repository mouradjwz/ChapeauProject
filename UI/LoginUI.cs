using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Service;
using Model;

namespace UI
{
    public partial class LoginUI : Form
    {
        public LoginUI()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            StaffService staffService = new StaffService();
            Staff staff = staffService.LoginStaff(txtUsername.Text, int.Parse(txtPassword.Text));

            if (staff != null)
            {
                MessageBox.Show("Workss");
            }
            else
            {
                MessageBox.Show("Incorrect username or password!!!");

            }

        }
    }
}
