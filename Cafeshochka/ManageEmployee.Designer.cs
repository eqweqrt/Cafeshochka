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
            buttonEditEmploye = new Button();
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
            // buttonEditEmploye
            // 
            buttonEditEmploye.Location = new Point(174, 234);
            buttonEditEmploye.Name = "buttonEditEmploye";
            buttonEditEmploye.Size = new Size(154, 55);
            buttonEditEmploye.TabIndex = 2;
            buttonEditEmploye.Text = "Изменить";
            buttonEditEmploye.UseVisualStyleBackColor = true;
            // 
            // ManageEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(buttonEditEmploye);
            Controls.Add(buttonAddEmployee);
            Controls.Add(dataGridView1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ManageEmployee";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        private Button buttonAddEmployee;
        private Button buttonEditEmploye;
    }
}