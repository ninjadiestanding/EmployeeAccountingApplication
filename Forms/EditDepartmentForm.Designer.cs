namespace EmployeeAccountingApplication.Forms
{
    partial class EditDepartmentForm
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
            DirectorComboBox = new System.Windows.Forms.ComboBox();
            MainDepartmentComboBox = new System.Windows.Forms.ComboBox();
            NameTextBox = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // CancelButton
            // 
            CancelButton.Location = new System.Drawing.Point(321, 168);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new System.Drawing.Size(75, 23);
            CancelButton.TabIndex = 31;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new System.Drawing.Point(240, 168);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new System.Drawing.Size(75, 23);
            SaveButton.TabIndex = 30;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // RecordStatusComboBox
            // 
            RecordStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            RecordStatusComboBox.FormattingEnabled = true;
            RecordStatusComboBox.Location = new System.Drawing.Point(173, 111);
            RecordStatusComboBox.Name = "RecordStatusComboBox";
            RecordStatusComboBox.Size = new System.Drawing.Size(223, 23);
            RecordStatusComboBox.TabIndex = 29;
            RecordStatusComboBox.SelectedIndexChanged += RecordStatusComboBox_SelectedIndexChanged;
            // 
            // DirectorComboBox
            // 
            DirectorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            DirectorComboBox.FormattingEnabled = true;
            DirectorComboBox.Location = new System.Drawing.Point(173, 82);
            DirectorComboBox.Name = "DirectorComboBox";
            DirectorComboBox.Size = new System.Drawing.Size(223, 23);
            DirectorComboBox.TabIndex = 28;
            // 
            // MainDepartmentComboBox
            // 
            MainDepartmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            MainDepartmentComboBox.FormattingEnabled = true;
            MainDepartmentComboBox.Location = new System.Drawing.Point(173, 53);
            MainDepartmentComboBox.Name = "MainDepartmentComboBox";
            MainDepartmentComboBox.Size = new System.Drawing.Size(223, 23);
            MainDepartmentComboBox.TabIndex = 27;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new System.Drawing.Point(173, 24);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new System.Drawing.Size(223, 23);
            NameTextBox.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(21, 114);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(107, 15);
            label4.TabIndex = 25;
            label4.Text = "Состояние записи";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(21, 85);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(83, 15);
            label3.TabIndex = 24;
            label3.Text = "Руководитель";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(21, 56);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(146, 15);
            label2.TabIndex = 23;
            label2.Text = "Головное подразделение";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(21, 27);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(90, 15);
            label1.TabIndex = 22;
            label1.Text = "Наименование";
            // 
            // EditDepartmentForm
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
            Name = "EditDepartmentForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Редактирование подразделения";
            Load += EditDepartmentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ComboBox RecordStatusComboBox;
        private System.Windows.Forms.ComboBox DirectorComboBox;
        private System.Windows.Forms.ComboBox MainDepartmentComboBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}