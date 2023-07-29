namespace EmployeeAccountingApplication.Forms
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
            CancelButton = new System.Windows.Forms.Button();
            SaveButton = new System.Windows.Forms.Button();
            RecordStatusComboBox = new System.Windows.Forms.ComboBox();
            DismissalDateTimePicker = new System.Windows.Forms.DateTimePicker();
            EmploymentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            DepartmentComboBox = new System.Windows.Forms.ComboBox();
            PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            EmailTextBox = new System.Windows.Forms.TextBox();
            PositionTextBox = new System.Windows.Forms.TextBox();
            PersonnelNumberTextBox = new System.Windows.Forms.TextBox();
            FullNameTextBox = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // CancelButton
            // 
            CancelButton.Location = new System.Drawing.Point(279, 345);
            CancelButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new System.Drawing.Size(75, 23);
            CancelButton.TabIndex = 39;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new System.Drawing.Point(196, 345);
            SaveButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new System.Drawing.Size(75, 23);
            SaveButton.TabIndex = 38;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // RecordStatusComboBox
            // 
            RecordStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            RecordStatusComboBox.FormattingEnabled = true;
            RecordStatusComboBox.Location = new System.Drawing.Point(142, 250);
            RecordStatusComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            RecordStatusComboBox.Name = "RecordStatusComboBox";
            RecordStatusComboBox.Size = new System.Drawing.Size(212, 23);
            RecordStatusComboBox.TabIndex = 37;
            RecordStatusComboBox.SelectedIndexChanged += RecordStatusComboBox_SelectedIndexChanged;
            // 
            // DismissalDateTimePicker
            // 
            DismissalDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            DismissalDateTimePicker.Location = new System.Drawing.Point(142, 279);
            DismissalDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            DismissalDateTimePicker.Name = "DismissalDateTimePicker";
            DismissalDateTimePicker.Size = new System.Drawing.Size(108, 23);
            DismissalDateTimePicker.TabIndex = 36;
            // 
            // EmploymentDateTimePicker
            // 
            EmploymentDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            EmploymentDateTimePicker.Location = new System.Drawing.Point(142, 198);
            EmploymentDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            EmploymentDateTimePicker.Name = "EmploymentDateTimePicker";
            EmploymentDateTimePicker.Size = new System.Drawing.Size(108, 23);
            EmploymentDateTimePicker.TabIndex = 35;
            // 
            // DepartmentComboBox
            // 
            DepartmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            DepartmentComboBox.FormattingEnabled = true;
            DepartmentComboBox.Location = new System.Drawing.Point(142, 111);
            DepartmentComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            DepartmentComboBox.Name = "DepartmentComboBox";
            DepartmentComboBox.Size = new System.Drawing.Size(212, 23);
            DepartmentComboBox.TabIndex = 34;
            // 
            // PhoneNumberTextBox
            // 
            PhoneNumberTextBox.Location = new System.Drawing.Point(142, 169);
            PhoneNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            PhoneNumberTextBox.Size = new System.Drawing.Size(174, 23);
            PhoneNumberTextBox.TabIndex = 33;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new System.Drawing.Point(142, 140);
            EmailTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new System.Drawing.Size(174, 23);
            EmailTextBox.TabIndex = 32;
            // 
            // PositionTextBox
            // 
            PositionTextBox.Location = new System.Drawing.Point(142, 82);
            PositionTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            PositionTextBox.Name = "PositionTextBox";
            PositionTextBox.Size = new System.Drawing.Size(212, 23);
            PositionTextBox.TabIndex = 31;
            // 
            // PersonnelNumberTextBox
            // 
            PersonnelNumberTextBox.Location = new System.Drawing.Point(142, 53);
            PersonnelNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            PersonnelNumberTextBox.Name = "PersonnelNumberTextBox";
            PersonnelNumberTextBox.Size = new System.Drawing.Size(108, 23);
            PersonnelNumberTextBox.TabIndex = 30;
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Location = new System.Drawing.Point(142, 24);
            FullNameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new System.Drawing.Size(212, 23);
            FullNameTextBox.TabIndex = 29;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(24, 253);
            label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(69, 15);
            label9.TabIndex = 28;
            label9.Text = "Состояние:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(24, 285);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(103, 15);
            label8.TabIndex = 27;
            label8.Text = "Дата увольнения:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(24, 204);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(80, 15);
            label7.TabIndex = 26;
            label7.Text = "Дата приёма:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(24, 172);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(58, 15);
            label6.TabIndex = 25;
            label6.Text = "Телефон:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(24, 143);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(39, 15);
            label5.TabIndex = 24;
            label5.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(24, 114);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(95, 15);
            label4.TabIndex = 23;
            label4.Text = "Подразделение:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(24, 85);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(72, 15);
            label3.TabIndex = 22;
            label3.Text = "Должность:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(24, 56);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(110, 15);
            label2.TabIndex = 21;
            label2.Text = "Табельный номер:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(24, 27);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(37, 15);
            label1.TabIndex = 20;
            label1.Text = "ФИО:";
            // 
            // EditEmployeeForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(386, 380);
            Controls.Add(CancelButton);
            Controls.Add(SaveButton);
            Controls.Add(RecordStatusComboBox);
            Controls.Add(DismissalDateTimePicker);
            Controls.Add(EmploymentDateTimePicker);
            Controls.Add(DepartmentComboBox);
            Controls.Add(PhoneNumberTextBox);
            Controls.Add(EmailTextBox);
            Controls.Add(PositionTextBox);
            Controls.Add(PersonnelNumberTextBox);
            Controls.Add(FullNameTextBox);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "EditEmployeeForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Редактирование сотрудника";
            Load += EditEmployeeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ComboBox RecordStatusComboBox;
        private System.Windows.Forms.DateTimePicker DismissalDateTimePicker;
        private System.Windows.Forms.DateTimePicker EmploymentDateTimePicker;
        private System.Windows.Forms.ComboBox DepartmentComboBox;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox PositionTextBox;
        private System.Windows.Forms.TextBox PersonnelNumberTextBox;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}