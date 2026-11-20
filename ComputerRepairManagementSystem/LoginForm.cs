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
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string pass = txtPassword.Text;

            if (pass == "")
            {
                txtPassword.Clear();
                DashBForm dbf = new DashBForm();
                dbf.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong PAssword");
                txtPassword.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            txtPassword.Focus();
        }
    }
}
