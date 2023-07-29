using EmployeeAccountingApplication.Enums;
using EmployeeAccountingApplication.Models;
using EmployeeAccountingApplication.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeAccountingApplication.Forms
{
    public partial class EditEmployeeForm : Form
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IDepartmentRepository _departmentRepository;

        private readonly RecordStatusEnumHelper _enumHelper;
        private readonly int _employeeId;

        public EditEmployeeForm(IEmployeeRepository employeeRepository, IDepartmentRepository departmentRepository,
            int employeeId)
        {
            _employeeRepository = employeeRepository;
            _departmentRepository = departmentRepository;
            _enumHelper = new RecordStatusEnumHelper();
            _employeeId = employeeId;

            InitializeComponent();
            RecordStatusLoadComboBox();

            var departments = _departmentRepository.GetDepartments();
            DepartmentComboBox.DataSource = departments;
            DepartmentComboBox.DisplayMember = "Name";
            DepartmentComboBox.ValueMember = "Id";
        }

        private void EditEmployeeForm_Load(object sender, EventArgs e)
        {
            var employeeToUpdate = _employeeRepository.GetEmployee(_employeeId);

            FullNameTextBox.Text = employeeToUpdate.FullName;
            PersonnelNumberTextBox.Text = employeeToUpdate.PersonnelNumber;
            PositionTextBox.Text = employeeToUpdate.Position;

            if (employeeToUpdate.DepartmentId == null)
                DepartmentComboBox.SelectedItem = null;
            else
                DepartmentComboBox.SelectedItem = employeeToUpdate.Department;

            EmailTextBox.Text = employeeToUpdate.Email;
            PhoneNumberTextBox.Text = employeeToUpdate.PhoneNumber;
            EmploymentDateTimePicker.Value = employeeToUpdate.EmploymentDate;
            RecordStatusComboBox.SelectedItem = _enumHelper.GetDescriptionFromEnum(employeeToUpdate.RecordStatus);

            if (RecordStatusComboBox.SelectedItem.ToString() == _enumHelper.GetDescriptionFromEnum(RecordStatusEnum.Closed))
            {
                DismissalDateTimePicker.Visible = true;
                DismissalDateTimePicker.Value = (DateTime)employeeToUpdate.DateOfDismissal;
            }
            else
            {
                DismissalDateTimePicker.Visible = false;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(FullNameTextBox.Text)) && !(string.IsNullOrWhiteSpace(PersonnelNumberTextBox.Text))
                && !(string.IsNullOrWhiteSpace(PositionTextBox.Text)))
            {
                var employeeToUpdate = _employeeRepository.GetEmployee(_employeeId);

                employeeToUpdate.FullName = FullNameTextBox.Text;
                employeeToUpdate.PersonnelNumber = PersonnelNumberTextBox.Text;
                employeeToUpdate.Position = PositionTextBox.Text;

                if (DepartmentComboBox.SelectedItem != null)
                    employeeToUpdate.DepartmentId = Convert.ToInt32(DepartmentComboBox.SelectedValue);
                else
                    employeeToUpdate.DepartmentId = null;

                employeeToUpdate.Email = EmailTextBox.Text;
                employeeToUpdate.PhoneNumber = PhoneNumberTextBox.Text;
                employeeToUpdate.EmploymentDate = EmploymentDateTimePicker.Value;
                employeeToUpdate.RecordStatus = _enumHelper.GetEnumFromDescription(RecordStatusComboBox.SelectedItem.ToString());

                if (employeeToUpdate.RecordStatus == RecordStatusEnum.Closed)
                    employeeToUpdate.DateOfDismissal = DismissalDateTimePicker.Value;
                else
                    employeeToUpdate.DateOfDismissal = null;

                _employeeRepository.UpdateEmployee(employeeToUpdate);

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
