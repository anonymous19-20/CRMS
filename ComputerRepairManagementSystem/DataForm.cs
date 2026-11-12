using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;


namespace ComputerRepairManagementSystem
{
    public partial class DataForm : Form
    {
        public DataForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
           
        }

        private void txtModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void PanData_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbName_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPhone.Clear();
            txtModel.Clear();
            txtEmail.Clear();
            txtDescription.Clear();
            dbCatogory.ResetText();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string phone = txtPhone.Text;
            string category = dbCatogory.Text;
            string model = txtModel.Text;
            string email = txtEmail.Text;
            string description = txtDescription.Text;

            string dbPath = Path.Combine(Application.StartupPath, "Database", "CRMSdb.db");

            try
            {
                using (SQLiteConnection con = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
                {
                    con.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand(con))
                    {
                        cmd.CommandText = @"INSERT INTO CustomerData
                                    (Name, Phone, Catagory, Model, Email, Description)
                                    VALUES (@name, @phone, @category, @model, @email, @description)";
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@category", category);
                        cmd.Parameters.AddWithValue("@model", model);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@description", description);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Data Entered Successfully");
                    }
                }
                btnReset_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }
    }
}
