using System;
using System.Windows.Forms;
using Npgsql;

namespace Cafeshochka
{
    public partial class EditEmployeeForm : Form
    {
        private string connectionString = "Host=localhost;Username=postgres;Password=postgres;Database=postgres";

        public int UserID { get; private set; }
        public string Username { get; private set; }
        public string UserPassword { get; private set; }
        public string UserRole { get; private set; }
        public string UserStatus { get; private set; }

        public EditEmployeeForm(int id, string name, string password, string role, string status)
        {
            InitializeComponent();

            UserID = id;
            Username = name;
            UserPassword = password;
            UserRole = role;
            UserStatus = status;

            textBox5.Text = id.ToString();
            textBox1.Text = name;
            textBox2.Text = password;
            textBox3.Text = role;
            textBox4.Text = status;
        }

        private void SaveEditEmployeeButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox5.Text, out int id))
            {
                UserID = id;
                Username = textBox1.Text;
                UserPassword = textBox2.Text;
                UserRole = textBox3.Text;
                UserStatus = textBox4.Text;

                // Сохранение данных в базе данных
                if (UpdateEmployeeInDatabase(UserID, Username, UserPassword, UserRole, UserStatus))
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to save changes to the database.");
                }
            }
            else
            {
                MessageBox.Show("Invalid ID.");
            }
        }

        private bool UpdateEmployeeInDatabase(int id, string username, string userPassword, string userRole, string userStatus)
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE users SET username = @username, userpassword = @userpassword, userrole = @userrole, userstatus = @userstatus WHERE userid = @id";
                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@userid", id);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@userpassword", userPassword);
                        cmd.Parameters.AddWithValue("@userrole", userRole);
                        cmd.Parameters.AddWithValue("@userstatus", userStatus);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating employee: {ex.Message}");
                return false;
            }
        }
    }
}
