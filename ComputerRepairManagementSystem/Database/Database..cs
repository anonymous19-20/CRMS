
using System.Data;
using System.Data.SQLite;

namespace ComputerRepairManagementSystem
{
    public class Database
    {
        public static SQLiteConnection GetConnection()
        {
            string connectionString =
                "Data Source=ComputerRepair.db;Version=3;";

            return new SQLiteConnection(connectionString);
        }

        // Create Customers Table
        public static void CreateTable()
        {
            using (SQLiteConnection con = GetConnection())
            {
                con.Open();

                string query = @"CREATE TABLE IF NOT EXISTS Customers
                (
                    CustomerId INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Phone TEXT,
                    Email TEXT
                )";

                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Insert Customer
        public static void InsertCustomer(string name, string phone, string email)
        {
            using (SQLiteConnection con = GetConnection())
            {
                con.Open();

                string query = @"INSERT INTO Customers
                (Name, Phone, Email)
                VALUES (@Name, @Phone, @Email)";

                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Email", email);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Retrieve Customers
        public static DataTable GetCustomers()
        {
            DataTable dt = new DataTable();

            using (SQLiteConnection con = GetConnection())
            {
                con.Open();

                string query = "SELECT * FROM Customers";

                using (SQLiteDataAdapter adapter =
                    new SQLiteDataAdapter(query, con))
                {
                    adapter.Fill(dt);
                }
            }

            return dt;
        }

        // Update Customer
        public static void UpdateCustomer(
            int id, string name, string phone, string email)
        {
            using (SQLiteConnection con = GetConnection())
            {
                con.Open();

                string query = @"UPDATE Customers
                SET Name=@Name, Phone=@Phone, Email=@Email
                WHERE CustomerId=@Id";

                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Email", email);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Delete Customer
        public static void DeleteCustomer(int id)
        {
            using (SQLiteConnection con = GetConnection())
            {
                con.Open();

                string query =
                    "DELETE FROM Customers WHERE CustomerId=@Id";

                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", id);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
