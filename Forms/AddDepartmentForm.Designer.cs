namespace EmployeeAccountingApplication.Forms
{
    partial class AddDepartmentForm
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            NameTextBox = new System.Windows.Forms.TextBox();
            MainDepartmentComboBox = new System.Windows.Forms.ComboBox();
            DirectorComboBox = new System.Windows.Forms.ComboBox();
            RecordStatusComboBox = new System.Windows.Forms.ComboBox();
            CancelButton = new System.Windows.Forms.Button();
            SaveButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(22, 25);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(90, 15);
            label1.TabIndex = 0;
            label1.Text = "Наименование";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(22, 54);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(146, 15);
            label2.TabIndex = 1;
            label2.Text = "Головное подразделение";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(22, 83);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(83, 15);
            label3.TabIndex = 2;
            label3.Text = "Руководитель";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(22, 112);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(107, 15);
            label4.TabIndex = 3;
            label4.Text = "Состояние записи";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new System.Drawing.Point(174, 22);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new System.Drawing.Size(223, 23);
            NameTextBox.TabIndex = 4;
            // 
            // MainDepartmentComboBox
            // 
            MainDepartmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            MainDepartmentComboBox.FormattingEnabled = true;
            MainDepartmentComboBox.Location = new System.Drawing.Point(174, 51);
            MainDepartmentComboBox.Name = "MainDepartmentComboBox";
            MainDepartmentComboBox.Size = new System.Drawing.Size(223, 23);
            MainDepartmentComboBox.TabIndex = 5;
            // 
            // DirectorComboBox
            // 
            DirectorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            DirectorComboBox.FormattingEnabled = true;
            DirectorComboBox.Location = new System.Drawing.Point(174, 80);
            DirectorComboBox.Name = "DirectorComboBox";
            DirectorComboBox.Size = new System.Drawing.Size(223, 23);
            DirectorComboBox.TabIndex = 6;
            // 
            // RecordStatusComboBox
            // 
            RecordStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            RecordStatusComboBox.FormattingEnabled = true;
            RecordStatusComboBox.Location = new System.Drawing.Point(174, 109);
            RecordStatusComboBox.Name = "RecordStatusComboBox";
            RecordStatusComboBox.Size = new System.Drawing.Size(223, 23);
            RecordStatusComboBox.TabIndex = 7;
            RecordStatusComboBox.SelectedIndexChanged += RecordStatusComboBox_SelectedIndexChanged;
            // 
            // CancelButton
            // 
            CancelButton.Location = new System.Drawing.Point(322, 171);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new System.Drawing.Size(75, 23);
            CancelButton.TabIndex = 21;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new System.Drawing.Point(241, 171);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new System.Drawing.Size(75, 23);
            SaveButton.TabIndex = 20;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // AddDepartmentForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(422, 216);
            Controls.Add(CancelButton);
            Controls.Add(SaveButton);
            Controls.Add(RecordStatusComboBox);
            Controls.Add(DirectorComboBox);
            Controls.Add(MainDepartmentComboBox);
            Controls.Add(NameTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddDepartmentForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Добавление подразделения";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.ComboBox MainDepartmentComboBox;
        private System.Windows.Forms.ComboBox DirectorComboBox;
        private System.Windows.Forms.ComboBox RecordStatusComboBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
    }
}