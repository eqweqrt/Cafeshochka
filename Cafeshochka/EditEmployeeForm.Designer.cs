namespace Cafeshochka
{
    partial class EditEmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            SaveEditEmployeeButton = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(56, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(56, 80);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(56, 110);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(56, 139);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 2;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(56, 22);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 4;
            // 
            // SaveEditEmployeeButton
            // 
            SaveEditEmployeeButton.Location = new Point(56, 183);
            SaveEditEmployeeButton.Name = "SaveEditEmployeeButton";
            SaveEditEmployeeButton.Size = new Size(100, 33);
            SaveEditEmployeeButton.TabIndex = 5;
            SaveEditEmployeeButton.Text = "Сохранить";
            SaveEditEmployeeButton.UseVisualStyleBackColor = true;
            SaveEditEmployeeButton.Click += SaveEditEmployeeButton_Click;
            // 
            // EditEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SaveEditEmployeeButton);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "EditEmployeeForm";
            Text = "EditEmployeeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button SaveEditEmployeeButton;
    }
}