using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerRepairManagementSystem
{
    public partial class LoginForm : Form
    {
        public object MessegeBox { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
        }


        private void btnPassword_Click(object sender, EventArgs e)
        {
            string pass = txtPassword.Text;

            if(pass == "123")
            {
                MessageBox.Show("Login_Succesfull");
                txtPassword.Clear();
                DashBForm dbf = new DashBForm();
                dbf.Show();
            }
            else
            {
                MessageBox.Show("Wrong PAssword");
                txtPassword.Clear();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
