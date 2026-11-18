using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerRepairManagementSystem
{
    public partial class DashBForm : Form
    {
        public DashBForm()
        {
            InitializeComponent();
            LoadData();

        }
        
        private string dbPath = Path.Combine(Application.StartupPath, "Database", "CRMSdb.db");
        private DataTable table;


        private void LoadData()
        {
           using(var con = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                con.Open();
                string query = "SELECT * FROM CustomerData";
                using (var cmd = new SQLiteCommand(query, con))
                using (var reader = cmd.ExecuteReader())
                {
                    table = new DataTable();
                    table.Load(reader);
                    DataView.DataSource = null;
                    DataView.Columns.Clear();
                    DataView.AutoGenerateColumns = true;

                    DataView.DataSource = table;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           
        }

        private void DashBForm_Load(object sender, EventArgs e)
        {

        }

        private void dgView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataForm df = new DataForm();
            df.Show();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            using (var con = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                con.Open();
                string query = $"SELECT * FROM CustomerData WHERE Name LIKE '%{txtSearch.Text}%'";
                using (var cmd = new SQLiteCommand(query, con))
                using (var reader = cmd.ExecuteReader())
                {
                    table = new DataTable();
                    table.Load(reader);
                    DataView.DataSource = table;
                }
            }
        }

        private void txtSearch_RightToLeftChanged(object sender, EventArgs e)
        {

        }
    }
}
