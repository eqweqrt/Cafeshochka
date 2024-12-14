using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafeshochka
{
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private string connectionString = "Host=localhost;Username=postgres;Password=postgres;Database=postgres";

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserStatusTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordUserTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Users (Username, UserPassword, UserRole, UserStatus) VALUES (@Username, @UserPassword, @UserRole, @UserStatus)";

                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Username", UsernameTextBox.Text);
                        cmd.Parameters.AddWithValue("@UserPassword", PasswordUserTextBox.Text);
                        cmd.Parameters.AddWithValue("@UserRole", RoleComboBox.Text);
                        cmd.Parameters.AddWithValue("@UserStatus", UserStatusComboBox.Text);

                        // Выполнение команды
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Employee saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving employee: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
