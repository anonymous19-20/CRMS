using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace ComputerRepairManagementSystem
{
    public class Database
    {
        public static string connectionString = @"Data Source=ComputerRepair.db;Version=3;";

        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connectionString);
        }

        public static bool TestConnection()
        {
            try
            {
                using (SQLiteConnection conn = GetConnection())
                {
                    conn.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}