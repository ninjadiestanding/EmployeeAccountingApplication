using EmployeeAccountingApplication.Enums;
using EmployeeAccountingApplication.Models;
using EmployeeAccountingApplication.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace EmployeeAccountingApplication.Forms
{
    public partial class AddEmployeeForm : Form
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IDepartmentRepository _departmentRepository;

        private readonly RecordStatusEnumHelper _enumHelper;

        public AddEmployeeForm(IEmployeeRepository employeeRepository, IDepartmentRepository departmentRepository)
        {
            _employeeRepository = employeeRepository;
            _departmentRepository = departmentRepository;
            _enumHelper = new RecordStatusEnumHelper();

            InitializeComponent();
            RecordStatusLoadComboBox();
            DepartmentComboBox.DataSource = _departmentRepository.GetDepartments();
            DepartmentComboBox.DisplayMember = "Name";
            DepartmentComboBox.ValueMember = "Id";
            DepartmentComboBox.SelectedItem = null;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(FullNameTextBox.Text)) && !(string.IsNullOrWhiteSpace(PersonnelNumberTextBox.Text))
                && !(string.IsNullOrWhiteSpace(PositionTextBox.Text)))
            {
                var employeeToAdd = new Employee();

                employeeToAdd.FullName = FullNameTextBox.Text;
                employeeToAdd.PersonnelNumber = PersonnelNumberTextBox.Text;
                employeeToAdd.Position = PositionTextBox.Text;

                if (DepartmentComboBox.SelectedItem != null)
                    employeeToAdd.DepartmentId = Convert.ToInt32(DepartmentComboBox.SelectedValue);
                else
                    employeeToAdd.DepartmentId = null;

                employeeToAdd.Email = EmailTextBox.Text;
                employeeToAdd.PhoneNumber = PhoneNumberTextBox.Text;
                employeeToAdd.EmploymentDate = EmploymentDateTimePicker.Value;
                employeeToAdd.RecordStatus = _enumHelper.GetEnumFromDescription(RecordStatusComboBox.SelectedItem.ToString());

                if (employeeToAdd.RecordStatus == RecordStatusEnum.Closed)
                    employeeToAdd.DateOfDismissal = DismissalDateTimePicker.Value;
                else
                    employeeToAdd.DateOfDismissal = null;

                _employeeRepository.AddEmployee(employeeToAdd);

                this.Close();
            }
            else
            {
                MessageBox.Show("Поля \"ФИО\", \"Табельный номер\" и \"Должность\" обязательны для заполнения.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RecordStatusLoadComboBox()
        {
            foreach (RecordStatusEnum status in Enum.GetValues(typeof(RecordStatusEnum)))
            {
                RecordStatusComboBox.Items.Add(_enumHelper.GetDescriptionFromEnum(status));
            }

            RecordStatusComboBox.SelectedItem = _enumHelper.GetDescriptionFromEnum(RecordStatusEnum.Current);
        }

        private void RecordStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RecordStatusComboBox.SelectedItem.ToString() == _enumHelper.GetDescriptionFromEnum(RecordStatusEnum.Closed))
            {
                DismissalDateTimePicker.Visible = true;

                FullNameTextBox.Enabled = false;
                PersonnelNumberTextBox.Enabled = false;
                PositionTextBox.Enabled = false;
                DepartmentComboBox.Enabled = false;
                EmailTextBox.Enabled = false;
                PhoneNumberTextBox.Enabled = false;
                EmploymentDateTimePicker.Enabled = false;
            }
            else
            {
                DismissalDateTimePicker.Visible = false;

                FullNameTextBox.Enabled = true;
                PersonnelNumberTextBox.Enabled = true;
                PositionTextBox.Enabled = true;
                DepartmentComboBox.Enabled = true;
                EmailTextBox.Enabled = true;
                PhoneNumberTextBox.Enabled = true;
                EmploymentDateTimePicker.Enabled = true;
            }
        }
    }
}
