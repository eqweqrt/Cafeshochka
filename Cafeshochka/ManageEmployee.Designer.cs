using System.Data;

namespace Cafeshochka
{
    partial class ManageEmployee
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            buttonAddEmployee = new Button();
            buttonEditEmployee = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 14);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(905, 193);
            dataGridView1.TabIndex = 0;
            // 
            // buttonAddEmployee
            // 
            buttonAddEmployee.Location = new Point(14, 234);
            buttonAddEmployee.Name = "buttonAddEmployee";
            buttonAddEmployee.Size = new Size(154, 55);
            buttonAddEmployee.TabIndex = 1;
            buttonAddEmployee.Text = "Добавить";
            buttonAddEmployee.UseVisualStyleBackColor = true;
            buttonAddEmployee.Click += buttonAddEmployee_Click;
            // 
            // buttonEditEmployee
            // 
            buttonEditEmployee.Location = new Point(174, 234);
            buttonEditEmployee.Name = "buttonEditEmployee";
            buttonEditEmployee.Size = new Size(154, 55);
            buttonEditEmployee.TabIndex = 0;
            buttonEditEmployee.Text = "Изменить";
            buttonEditEmployee.Click += buttonEditEmployee_Click;
            // 
            // ManageEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(buttonEditEmployee);
            Controls.Add(buttonAddEmployee);
            Controls.Add(dataGridView1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ManageEmployee";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        private Button buttonAddEmployee;
        private Button buttonEditEmployee;
    }
}