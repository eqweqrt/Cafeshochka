namespace Cafeshochka
{
    partial class InputFormEmployee
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
            RoleComboBox = new ComboBox();
            RoleUser = new TextBox();
            PasswordUser = new TextBox();
            UserStatus = new TextBox();
            UserContacts = new TextBox();
            PasswordUserTextBox = new TextBox();
            UserStatusComboBox = new ComboBox();
            UserContactsTextBox = new TextBox();
            SaveEmployee = new Button();
            Username = new TextBox();
            UsernameTextBox = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // RoleComboBox
            // 
            RoleComboBox.FormattingEnabled = true;
            RoleComboBox.Items.AddRange(new object[] { "Официант", "Повар", "Администратор" });
            RoleComboBox.Location = new Point(142, 55);
            RoleComboBox.Name = "RoleComboBox";
            RoleComboBox.Size = new Size(121, 23);
            RoleComboBox.TabIndex = 0;
            // 
            // RoleUser
            // 
            RoleUser.Location = new Point(26, 55);
            RoleUser.Name = "RoleUser";
            RoleUser.Size = new Size(100, 23);
            RoleUser.TabIndex = 1;
            RoleUser.Text = "Роль";
            // 
            // PasswordUser
            // 
            PasswordUser.Location = new Point(26, 84);
            PasswordUser.Name = "PasswordUser";
            PasswordUser.Size = new Size(100, 23);
            PasswordUser.TabIndex = 2;
            PasswordUser.Text = "Пароль";
            PasswordUser.TextChanged += textBox1_TextChanged;
            // 
            // UserStatus
            // 
            UserStatus.Location = new Point(26, 113);
            UserStatus.Name = "UserStatus";
            UserStatus.Size = new Size(100, 23);
            UserStatus.TabIndex = 3;
            UserStatus.Text = "Статус";
            UserStatus.TextChanged += UserStatusTextBox_TextChanged;
            // 
            // UserContacts
            // 
            UserContacts.Location = new Point(26, 142);
            UserContacts.Name = "UserContacts";
            UserContacts.Size = new Size(100, 23);
            UserContacts.TabIndex = 4;
            UserContacts.Text = "Контакты";
            // 
            // PasswordUserTextBox
            // 
            PasswordUserTextBox.Location = new Point(142, 84);
            PasswordUserTextBox.Name = "PasswordUserTextBox";
            PasswordUserTextBox.Size = new Size(121, 23);
            PasswordUserTextBox.TabIndex = 6;
            PasswordUserTextBox.TextChanged += PasswordUserTextBox_TextChanged;
            // 
            // UserStatusComboBox
            // 
            UserStatusComboBox.FormattingEnabled = true;
            UserStatusComboBox.Items.AddRange(new object[] { "Работает", "Уволен" });
            UserStatusComboBox.Location = new Point(142, 113);
            UserStatusComboBox.Name = "UserStatusComboBox";
            UserStatusComboBox.Size = new Size(121, 23);
            UserStatusComboBox.TabIndex = 7;
            // 
            // UserContactsTextBox
            // 
            UserContactsTextBox.Location = new Point(142, 142);
            UserContactsTextBox.Name = "UserContactsTextBox";
            UserContactsTextBox.Size = new Size(121, 23);
            UserContactsTextBox.TabIndex = 8;
            // 
            // SaveEmployee
            // 
            SaveEmployee.Location = new Point(86, 174);
            SaveEmployee.Name = "SaveEmployee";
            SaveEmployee.Size = new Size(109, 37);
            SaveEmployee.TabIndex = 9;
            SaveEmployee.Text = "Сохранить";
            SaveEmployee.UseVisualStyleBackColor = true;
            SaveEmployee.Click += SaveEmployee_Click;
            // 
            // Username
            // 
            Username.Location = new Point(26, 26);
            Username.Name = "Username";
            Username.Size = new Size(100, 23);
            Username.TabIndex = 10;
            Username.Text = "ФИО";
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Location = new Point(142, 26);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(121, 23);
            UsernameTextBox.TabIndex = 11;
            UsernameTextBox.Text = "ФИО";
            // 
            // button1
            // 
            button1.Location = new Point(223, 188);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // InputFormEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 248);
            Controls.Add(button1);
            Controls.Add(UsernameTextBox);
            Controls.Add(Username);
            Controls.Add(SaveEmployee);
            Controls.Add(UserContactsTextBox);
            Controls.Add(UserStatusComboBox);
            Controls.Add(PasswordUserTextBox);
            Controls.Add(UserContacts);
            Controls.Add(UserStatus);
            Controls.Add(PasswordUser);
            Controls.Add(RoleUser);
            Controls.Add(RoleComboBox);
            Name = "InputFormEmployee";
            Text = "InputFormEmployee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox RoleComboBox;
        private TextBox RoleUser;
        private TextBox PasswordUser;
        private TextBox UserStatus;
        private TextBox UserContacts;
        private TextBox PasswordUserTextBox;
        private ComboBox UserStatusComboBox;
        private TextBox UserContactsTextBox;
        private Button SaveEmployee;
        private TextBox Username;
        private TextBox UsernameTextBox;
        private Button button1;
    }
}