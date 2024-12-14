using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace Cafeshochka
{
    public partial class ManageEmployee : Form
    {
        private string connectionString = "Host=localhost;Username=postgres;Password=postgres;Database=postgres";

        public ManageEmployee()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT UserId, Username, UserPassword, UserRole, UserStatus FROM Users";
                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        var dataTable = new DataTable();
                        dataTable.Load(reader);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            var addEmployee = new AddEmployeeForm();
            addEmployee.Show();
        }

        private void buttonEditEmployee_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Получение данных из выбранной строки
                int id = (int)selectedRow.Cells["UserId"].Value;
                string name = selectedRow.Cells["Username"].Value.ToString();
                string password = selectedRow.Cells["UserPassword"].Value.ToString();
                string role = selectedRow.Cells["UserRole"].Value.ToString();
                string status = selectedRow.Cells["UserStatus"].Value.ToString();

                // Открытие формы редактирования с данными выбранной строки
                using (var editForm = new EditEmployeeForm(id, name, password, role, status))
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        // Обновление данных в DataGridView
                        selectedRow.Cells["Username"].Value = editForm.Username;
                        selectedRow.Cells["UserPassword"].Value = editForm.UserPassword;
                        selectedRow.Cells["UserRole"].Value = editForm.UserRole;
                        selectedRow.Cells["UserStatus"].Value = editForm.UserStatus;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to edit.");
            }
        }

    }
}
