namespace EmployeeAccountingApplication
{
    partial class MainForm
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
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            panel3 = new System.Windows.Forms.Panel();
            EmployeeResetButton = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            EmployeeSearchButton = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            DepartmentComboBox = new System.Windows.Forms.ComboBox();
            EmployeeIdTextBox = new System.Windows.Forms.TextBox();
            FullNameTextBox = new System.Windows.Forms.TextBox();
            PersonnelNumberTextBox = new System.Windows.Forms.TextBox();
            ImportButton = new System.Windows.Forms.Button();
            EditEmployeeButton = new System.Windows.Forms.Button();
            DeleteEmployeeButton = new System.Windows.Forms.Button();
            AddEmployeeButton = new System.Windows.Forms.Button();
            EmployeesDataGridView = new System.Windows.Forms.DataGridView();
            tabPage2 = new System.Windows.Forms.TabPage();
            panel4 = new System.Windows.Forms.Panel();
            label6 = new System.Windows.Forms.Label();
            DepartmentResetButton = new System.Windows.Forms.Button();
            DepartmentIdTextBox = new System.Windows.Forms.TextBox();
            DepartmentSearchButton = new System.Windows.Forms.Button();
            EditDepartmentButton = new System.Windows.Forms.Button();
            DeleteDepartmentButton = new System.Windows.Forms.Button();
            AddDepartmentButton = new System.Windows.Forms.Button();
            DepartmentDataGridView = new System.Windows.Forms.DataGridView();
            tabPage3 = new System.Windows.Forms.TabPage();
            panel1 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            DismissedNumberTextBox = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            RecruitedNumberTextBox = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            ResetStatButton = new System.Windows.Forms.Button();
            StartPeriodDateTimePicker = new System.Windows.Forms.DateTimePicker();
            EndPeriodDateTimePicker = new System.Windows.Forms.DateTimePicker();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            StatDepartmentsComboBox = new System.Windows.Forms.ComboBox();
            ApplyButton = new System.Windows.Forms.Button();
            ImportOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EmployeesDataGridView).BeginInit();
            tabPage2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DepartmentDataGridView).BeginInit();
            tabPage3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new System.Drawing.Point(6, 12);
            tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(1227, 536);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = System.Drawing.Color.White;
            tabPage1.Controls.Add(panel3);
            tabPage1.Controls.Add(ImportButton);
            tabPage1.Controls.Add(EditEmployeeButton);
            tabPage1.Controls.Add(DeleteEmployeeButton);
            tabPage1.Controls.Add(AddEmployeeButton);
            tabPage1.Controls.Add(EmployeesDataGridView);
            tabPage1.Location = new System.Drawing.Point(4, 24);
            tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage1.Size = new System.Drawing.Size(1219, 508);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Сотрудники";
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            panel3.Controls.Add(EmployeeResetButton);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(EmployeeSearchButton);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(DepartmentComboBox);
            panel3.Controls.Add(EmployeeIdTextBox);
            panel3.Controls.Add(FullNameTextBox);
            panel3.Controls.Add(PersonnelNumberTextBox);
            panel3.Location = new System.Drawing.Point(597, 19);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(615, 87);
            panel3.TabIndex = 15;
            // 
            // EmployeeResetButton
            // 
            EmployeeResetButton.Location = new System.Drawing.Point(518, 47);
            EmployeeResetButton.Name = "EmployeeResetButton";
            EmployeeResetButton.Size = new System.Drawing.Size(75, 23);
            EmployeeResetButton.TabIndex = 13;
            EmployeeResetButton.Text = "Сброс";
            EmployeeResetButton.UseVisualStyleBackColor = true;
            EmployeeResetButton.Click += EmployeeResetButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(19, 19);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(37, 15);
            label1.TabIndex = 3;
            label1.Text = "ФИО:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(217, 51);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(110, 15);
            label2.TabIndex = 4;
            label2.Text = "Табельный номер:";
            // 
            // EmployeeSearchButton
            // 
            EmployeeSearchButton.Location = new System.Drawing.Point(441, 48);
            EmployeeSearchButton.Name = "EmployeeSearchButton";
            EmployeeSearchButton.Size = new System.Drawing.Size(71, 23);
            EmployeeSearchButton.TabIndex = 12;
            EmployeeSearchButton.Text = "Найти";
            EmployeeSearchButton.UseVisualStyleBackColor = true;
            EmployeeSearchButton.Click += EmployeeSearchButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(19, 51);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(97, 15);
            label3.TabIndex = 5;
            label3.Text = "Идентификатор:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(312, 19);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(95, 15);
            label4.TabIndex = 6;
            label4.Text = "Подразделение:";
            // 
            // DepartmentComboBox
            // 
            DepartmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            DepartmentComboBox.FormattingEnabled = true;
            DepartmentComboBox.Location = new System.Drawing.Point(415, 16);
            DepartmentComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            DepartmentComboBox.Name = "DepartmentComboBox";
            DepartmentComboBox.Size = new System.Drawing.Size(178, 23);
            DepartmentComboBox.TabIndex = 10;
            // 
            // EmployeeIdTextBox
            // 
            EmployeeIdTextBox.Location = new System.Drawing.Point(124, 48);
            EmployeeIdTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            EmployeeIdTextBox.Name = "EmployeeIdTextBox";
            EmployeeIdTextBox.Size = new System.Drawing.Size(72, 23);
            EmployeeIdTextBox.TabIndex = 7;
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Location = new System.Drawing.Point(64, 16);
            FullNameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new System.Drawing.Size(236, 23);
            FullNameTextBox.TabIndex = 9;
            // 
            // PersonnelNumberTextBox
            // 
            PersonnelNumberTextBox.Location = new System.Drawing.Point(335, 47);
            PersonnelNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            PersonnelNumberTextBox.Name = "PersonnelNumberTextBox";
            PersonnelNumberTextBox.Size = new System.Drawing.Size(72, 23);
            PersonnelNumberTextBox.TabIndex = 8;
            // 
            // ImportButton
            // 
            ImportButton.Location = new System.Drawing.Point(331, 83);
            ImportButton.Name = "ImportButton";
            ImportButton.Size = new System.Drawing.Size(75, 23);
            ImportButton.TabIndex = 14;
            ImportButton.Text = "Импорт";
            ImportButton.UseVisualStyleBackColor = true;
            ImportButton.Click += ImportButton_Click;
            // 
            // EditEmployeeButton
            // 
            EditEmployeeButton.Location = new System.Drawing.Point(88, 83);
            EditEmployeeButton.Name = "EditEmployeeButton";
            EditEmployeeButton.Size = new System.Drawing.Size(108, 23);
            EditEmployeeButton.TabIndex = 11;
            EditEmployeeButton.Text = "Редактировать";
            EditEmployeeButton.UseVisualStyleBackColor = true;
            EditEmployeeButton.Click += EditEmployeeButton_Click;
            // 
            // DeleteEmployeeButton
            // 
            DeleteEmployeeButton.Location = new System.Drawing.Point(203, 83);
            DeleteEmployeeButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            DeleteEmployeeButton.Name = "DeleteEmployeeButton";
            DeleteEmployeeButton.Size = new System.Drawing.Size(75, 23);
            DeleteEmployeeButton.TabIndex = 2;
            DeleteEmployeeButton.Text = "Удалить";
            DeleteEmployeeButton.UseVisualStyleBackColor = true;
            DeleteEmployeeButton.Click += DeleteEmployeeButton_Click;
            // 
            // AddEmployeeButton
            // 
            AddEmployeeButton.Location = new System.Drawing.Point(6, 83);
            AddEmployeeButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            AddEmployeeButton.Name = "AddEmployeeButton";
            AddEmployeeButton.Size = new System.Drawing.Size(75, 23);
            AddEmployeeButton.TabIndex = 1;
            AddEmployeeButton.Text = "Добавить";
            AddEmployeeButton.UseVisualStyleBackColor = true;
            AddEmployeeButton.Click += AddEmployeeButton_Click;
            // 
            // EmployeesDataGridView
            // 
            EmployeesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            EmployeesDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            EmployeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmployeesDataGridView.Location = new System.Drawing.Point(6, 112);
            EmployeesDataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            EmployeesDataGridView.MultiSelect = false;
            EmployeesDataGridView.Name = "EmployeesDataGridView";
            EmployeesDataGridView.ReadOnly = true;
            EmployeesDataGridView.RowTemplate.Height = 25;
            EmployeesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            EmployeesDataGridView.Size = new System.Drawing.Size(1208, 390);
            EmployeesDataGridView.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel4);
            tabPage2.Controls.Add(EditDepartmentButton);
            tabPage2.Controls.Add(DeleteDepartmentButton);
            tabPage2.Controls.Add(AddDepartmentButton);
            tabPage2.Controls.Add(DepartmentDataGridView);
            tabPage2.Location = new System.Drawing.Point(4, 24);
            tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage2.Size = new System.Drawing.Size(1219, 508);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Подразделения";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            panel4.Controls.Add(label6);
            panel4.Controls.Add(DepartmentResetButton);
            panel4.Controls.Add(DepartmentIdTextBox);
            panel4.Controls.Add(DepartmentSearchButton);
            panel4.Location = new System.Drawing.Point(825, 55);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(386, 51);
            panel4.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(17, 17);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(97, 15);
            label6.TabIndex = 16;
            label6.Text = "Идентификатор:";
            // 
            // DepartmentResetButton
            // 
            DepartmentResetButton.Location = new System.Drawing.Point(297, 14);
            DepartmentResetButton.Name = "DepartmentResetButton";
            DepartmentResetButton.Size = new System.Drawing.Size(75, 23);
            DepartmentResetButton.TabIndex = 21;
            DepartmentResetButton.Text = "Сброс";
            DepartmentResetButton.UseVisualStyleBackColor = true;
            DepartmentResetButton.Click += DepartmentResetButton_Click;
            // 
            // DepartmentIdTextBox
            // 
            DepartmentIdTextBox.Location = new System.Drawing.Point(122, 14);
            DepartmentIdTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            DepartmentIdTextBox.Name = "DepartmentIdTextBox";
            DepartmentIdTextBox.Size = new System.Drawing.Size(72, 23);
            DepartmentIdTextBox.TabIndex = 18;
            // 
            // DepartmentSearchButton
            // 
            DepartmentSearchButton.Location = new System.Drawing.Point(219, 14);
            DepartmentSearchButton.Name = "DepartmentSearchButton";
            DepartmentSearchButton.Size = new System.Drawing.Size(72, 23);
            DepartmentSearchButton.TabIndex = 20;
            DepartmentSearchButton.Text = "Найти";
            DepartmentSearchButton.UseVisualStyleBackColor = true;
            DepartmentSearchButton.Click += DepartmentSearchButton_Click;
            // 
            // EditDepartmentButton
            // 
            EditDepartmentButton.Location = new System.Drawing.Point(87, 83);
            EditDepartmentButton.Name = "EditDepartmentButton";
            EditDepartmentButton.Size = new System.Drawing.Size(108, 23);
            EditDepartmentButton.TabIndex = 19;
            EditDepartmentButton.Text = "Редактировать";
            EditDepartmentButton.UseVisualStyleBackColor = true;
            EditDepartmentButton.Click += EditDepartmentButton_Click;
            // 
            // DeleteDepartmentButton
            // 
            DeleteDepartmentButton.Location = new System.Drawing.Point(202, 83);
            DeleteDepartmentButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            DeleteDepartmentButton.Name = "DeleteDepartmentButton";
            DeleteDepartmentButton.Size = new System.Drawing.Size(75, 23);
            DeleteDepartmentButton.TabIndex = 13;
            DeleteDepartmentButton.Text = "Удалить";
            DeleteDepartmentButton.UseVisualStyleBackColor = true;
            DeleteDepartmentButton.Click += DeleteDepartmentButton_Click;
            // 
            // AddDepartmentButton
            // 
            AddDepartmentButton.Location = new System.Drawing.Point(5, 83);
            AddDepartmentButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            AddDepartmentButton.Name = "AddDepartmentButton";
            AddDepartmentButton.Size = new System.Drawing.Size(75, 23);
            AddDepartmentButton.TabIndex = 12;
            AddDepartmentButton.Text = "Добавить";
            AddDepartmentButton.UseVisualStyleBackColor = true;
            AddDepartmentButton.Click += AddDepartmentbutton_Click;
            // 
            // DepartmentDataGridView
            // 
            DepartmentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            DepartmentDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            DepartmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DepartmentDataGridView.Location = new System.Drawing.Point(5, 112);
            DepartmentDataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            DepartmentDataGridView.MultiSelect = false;
            DepartmentDataGridView.Name = "DepartmentDataGridView";
            DepartmentDataGridView.ReadOnly = true;
            DepartmentDataGridView.RowTemplate.Height = 25;
            DepartmentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            DepartmentDataGridView.Size = new System.Drawing.Size(1206, 390);
            DepartmentDataGridView.TabIndex = 11;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(panel1);
            tabPage3.Location = new System.Drawing.Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new System.Drawing.Size(1219, 508);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Статистика";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(ResetStatButton);
            panel1.Controls.Add(StartPeriodDateTimePicker);
            panel1.Controls.Add(EndPeriodDateTimePicker);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(StatDepartmentsComboBox);
            panel1.Controls.Add(ApplyButton);
            panel1.Location = new System.Drawing.Point(13, 14);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(373, 285);
            panel1.TabIndex = 18;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel2.Controls.Add(DismissedNumberTextBox);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(RecruitedNumberTextBox);
            panel2.Location = new System.Drawing.Point(30, 186);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(156, 83);
            panel2.TabIndex = 18;
            // 
            // DismissedNumberTextBox
            // 
            DismissedNumberTextBox.Location = new System.Drawing.Point(83, 47);
            DismissedNumberTextBox.Name = "DismissedNumberTextBox";
            DismissedNumberTextBox.ReadOnly = true;
            DismissedNumberTextBox.Size = new System.Drawing.Size(49, 23);
            DismissedNumberTextBox.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(22, 20);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(55, 15);
            label9.TabIndex = 13;
            label9.Text = "Принято";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(22, 50);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(54, 15);
            label10.TabIndex = 14;
            label10.Text = "Уволено";
            // 
            // RecruitedNumberTextBox
            // 
            RecruitedNumberTextBox.Location = new System.Drawing.Point(83, 17);
            RecruitedNumberTextBox.Name = "RecruitedNumberTextBox";
            RecruitedNumberTextBox.ReadOnly = true;
            RecruitedNumberTextBox.Size = new System.Drawing.Size(49, 23);
            RecruitedNumberTextBox.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(30, 28);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(101, 15);
            label5.TabIndex = 2;
            label5.Text = "Начало периода:";
            // 
            // ResetStatButton
            // 
            ResetStatButton.Location = new System.Drawing.Point(262, 142);
            ResetStatButton.Name = "ResetStatButton";
            ResetStatButton.Size = new System.Drawing.Size(75, 23);
            ResetStatButton.TabIndex = 17;
            ResetStatButton.Text = "Сбросить";
            ResetStatButton.UseVisualStyleBackColor = true;
            ResetStatButton.Click += ResetStatButton_Click;
            // 
            // StartPeriodDateTimePicker
            // 
            StartPeriodDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            StartPeriodDateTimePicker.Location = new System.Drawing.Point(137, 27);
            StartPeriodDateTimePicker.Name = "StartPeriodDateTimePicker";
            StartPeriodDateTimePicker.Size = new System.Drawing.Size(106, 23);
            StartPeriodDateTimePicker.TabIndex = 0;
            // 
            // EndPeriodDateTimePicker
            // 
            EndPeriodDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            EndPeriodDateTimePicker.Location = new System.Drawing.Point(137, 66);
            EndPeriodDateTimePicker.Name = "EndPeriodDateTimePicker";
            EndPeriodDateTimePicker.Size = new System.Drawing.Size(106, 23);
            EndPeriodDateTimePicker.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(30, 66);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(93, 15);
            label7.TabIndex = 3;
            label7.Text = "Конец периода:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(30, 103);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(95, 15);
            label8.TabIndex = 7;
            label8.Text = "Подразделение:";
            // 
            // StatDepartmentsComboBox
            // 
            StatDepartmentsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            StatDepartmentsComboBox.FormattingEnabled = true;
            StatDepartmentsComboBox.Location = new System.Drawing.Point(137, 100);
            StatDepartmentsComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            StatDepartmentsComboBox.Name = "StatDepartmentsComboBox";
            StatDepartmentsComboBox.Size = new System.Drawing.Size(200, 23);
            StatDepartmentsComboBox.TabIndex = 11;
            // 
            // ApplyButton
            // 
            ApplyButton.Location = new System.Drawing.Point(172, 142);
            ApplyButton.Name = "ApplyButton";
            ApplyButton.Size = new System.Drawing.Size(84, 23);
            ApplyButton.TabIndex = 12;
            ApplyButton.Text = "Применить";
            ApplyButton.UseVisualStyleBackColor = true;
            ApplyButton.Click += ApplyButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1237, 551);
            Controls.Add(tabControl1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Учет сотрудников";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EmployeesDataGridView).EndInit();
            tabPage2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DepartmentDataGridView).EndInit();
            tabPage3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox DepartmentComboBox;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.TextBox PersonnelNumberTextBox;
        private System.Windows.Forms.TextBox EmployeeIdTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteEmployeeButton;
        private System.Windows.Forms.Button AddEmployeeButton;
        private System.Windows.Forms.DataGridView EmployeesDataGridView;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox DepartmentIdTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button DeleteDepartmentButton;
        private System.Windows.Forms.Button AddDepartmentButton;
        private System.Windows.Forms.DataGridView DepartmentDataGridView;
        private System.Windows.Forms.Button EditEmployeeButton;
        private System.Windows.Forms.Button EditDepartmentButton;
        private System.Windows.Forms.Button EmployeeSearchButton;
        private System.Windows.Forms.Button DepartmentSearchButton;
        private System.Windows.Forms.Button EmployeeResetButton;
        private System.Windows.Forms.Button DepartmentResetButton;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker EndPeriodDateTimePicker;
        private System.Windows.Forms.DateTimePicker StartPeriodDateTimePicker;
        private System.Windows.Forms.TextBox DismissedNumberTextBox;
        private System.Windows.Forms.TextBox RecruitedNumberTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.ComboBox StatDepartmentsComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ResetStatButton;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.OpenFileDialog ImportOpenFileDialog;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
    }
}

