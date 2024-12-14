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
    public partial class ManageEmployee : Form
    {
        public ManageEmployee()
        {
            InitializeComponent();
            LoadData();
        }

        private string connectionString = "Host=localhost;Username=postgres;Password=postgres;Database=postgres";

        private void LoadData()
        {
            // Создаем DataTable
            /*DataTable dataTable = new DataTable();

            // Добавляем столбцы
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Age", typeof(int));

            // Добавляем строки
            dataTable.Rows.Add(1, "John Doe", 30);
            dataTable.Rows.Add(2, "Jane Smith", 25);
            dataTable.Rows.Add(3, "Sam Brown", 35);

            // Привязываем DataTable к DataGridView
            dataGridView1.DataSource = dataTable;*/

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
            var inputForm = new InputFormEmployee();
            inputForm.Show();
        }

    }
}
