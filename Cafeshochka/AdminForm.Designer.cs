namespace Cafeshochka
{
    partial class AdminForm : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonEmployee = new Button();
            buttonOrder = new Button();
            buttonShift = new Button();
            buttonReports = new Button();
            SuspendLayout();
            // 
            // buttonEmployee
            // 
            buttonEmployee.Location = new Point(12, 12);
            buttonEmployee.Name = "buttonEmployee";
            buttonEmployee.Size = new Size(145, 41);
            buttonEmployee.TabIndex = 0;
            buttonEmployee.Text = "Сотрудники";
            buttonEmployee.UseVisualStyleBackColor = true;
            buttonEmployee.Click += button1_Click;
            // 
            // buttonOrder
            // 
            buttonOrder.Location = new Point(12, 59);
            buttonOrder.Name = "buttonOrder";
            buttonOrder.Size = new Size(145, 41);
            buttonOrder.TabIndex = 1;
            buttonOrder.Text = "Заказы";
            buttonOrder.UseVisualStyleBackColor = true;
            // 
            // buttonShift
            // 
            buttonShift.Location = new Point(12, 106);
            buttonShift.Name = "buttonShift";
            buttonShift.Size = new Size(145, 41);
            buttonShift.TabIndex = 2;
            buttonShift.Text = "Смены";
            buttonShift.UseVisualStyleBackColor = true;
            // 
            // buttonReports
            // 
            buttonReports.Location = new Point(12, 153);
            buttonReports.Name = "buttonReports";
            buttonReports.Size = new Size(145, 41);
            buttonReports.TabIndex = 3;
            buttonReports.Text = "Отчеты";
            buttonReports.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 313);
            Controls.Add(buttonReports);
            Controls.Add(buttonShift);
            Controls.Add(buttonOrder);
            Controls.Add(buttonEmployee);
            Name = "AdminForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonEmployee;
        private Button buttonOrder;
        private Button buttonShift;
        private Button buttonReports;
    }
}
