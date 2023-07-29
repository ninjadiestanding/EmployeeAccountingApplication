using EmployeeAccountingApplication.Database;
using EmployeeAccountingApplication.Enums;
using EmployeeAccountingApplication.Forms;
using EmployeeAccountingApplication.Models;
using EmployeeAccountingApplication.Services;
using EmployeeAccountingApplication.ViewModels;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace EmployeeAccountingApplication
{
    public partial class MainForm : Form
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IDepartmentRepository _departmentRepository;

        private readonly RecordStatusEnumHelper _enumHelper;

        public MainForm(IEmployeeRepository employeeRepository, IDepartmentRepository departmentRepository)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            InitializeComponent();
            _employeeRepository = employeeRepository;
            _departmentRepository = departmentRepository;
            _enumHelper = new RecordStatusEnumHelper();

            EmployeesDataGridView.DataSource = EmployeesDataGridInitialize();
            DepartmentDataGridView.DataSource = DepartmentsDataGridInitialize();

            DepartmentComboBox.DataSource = _departmentRepository.GetDepartments();
            DepartmentComboBox.DisplayMember = "Name";
            DepartmentComboBox.ValueMember = "Id";
            DepartmentComboBox.SelectedItem = null;

            StatDepartmentsComboBox.DataSource = _departmentRepository.GetDepartments();
            StatDepartmentsComboBox.DisplayMember = "Name";
            StatDepartmentsComboBox.ValueMember = "Id";
            StatDepartmentsComboBox.SelectedItem = null;
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm(_employeeRepository, _departmentRepository);
            addEmployeeForm.FormClosing += AddEmployeeForm_FormClosing;

            addEmployeeForm.ShowDialog();
        }

        private void AddEmployeeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            EmployeesDataGridView.DataSource = EmployeesDataGridInitialize();
            DepartmentDataGridView.DataSource = DepartmentsDataGridInitialize();
        }

        private void EditEmployeeButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedEmployee = EmployeesDataGridView.SelectedRows[0];
            int selectedEmployeeId = Convert.ToInt32(selectedEmployee.Cells[0].Value);

            EditEmployeeForm editEmployeeForm = new EditEmployeeForm(_employeeRepository, _departmentRepository,
                selectedEmployeeId);

            editEmployeeForm.FormClosing += EditEmployeeForm_FormClosing;

            editEmployeeForm.ShowDialog();
        }

        private void EditEmployeeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            EmployeesDataGridView.DataSource = EmployeesDataGridInitialize();
            DepartmentDataGridView.DataSource = DepartmentsDataGridInitialize();
        }

        private void DeleteEmployeeButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedEmployee = EmployeesDataGridView.SelectedRows[0];
            _employeeRepository.DeleteEmployee(Convert.ToInt32(selectedEmployee.Cells[0].Value));

            EmployeesDataGridView.DataSource = EmployeesDataGridInitialize();
            DepartmentDataGridView.DataSource = DepartmentsDataGridInitialize();
        }

        private void EmployeeSearchButton_Click(object sender, EventArgs e)
        {
            int? employeeId = int.TryParse(EmployeeIdTextBox.Text, out int id) ? (int?)id : null;

            int? departmentId = DepartmentComboBox.SelectedItem != null ? Convert.ToInt32(DepartmentComboBox.SelectedValue) : null;

            var filteredEmployees = _employeeRepository.GetFilteredEmployeesWithDepartments(employeeId, departmentId,
                FullNameTextBox.Text, PersonnelNumberTextBox.Text);

            EmployeesDataGridView.DataSource = filteredEmployees.Select(e => new EmployeeViewModel
            {
                Id = e.Id,
                FullName = e.FullName,
                PersonnelNumber = e.PersonnelNumber,
                Position = e.Position,
                DepartmentName = e.Department?.Name,
                Email = e.Email,
                PhoneNumber = e.PhoneNumber,
                EmploymentDate = e.EmploymentDate,
                RecordStatus = _enumHelper.GetDescriptionFromEnum(e.RecordStatus),
                DateOfDismissal = e.DateOfDismissal
            }).ToList();
        }

        private void EmployeeResetButton_Click(object sender, EventArgs e)
        {
            EmployeeIdTextBox.Text = string.Empty;
            FullNameTextBox.Text = string.Empty;
            PersonnelNumberTextBox.Text = string.Empty;
            DepartmentComboBox.SelectedItem = null;

            EmployeesDataGridView.DataSource = EmployeesDataGridInitialize();
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            ImportOpenFileDialog.Filter = "Excel Files|*.xlsx;*.xls|All Files|*.*";

            if (ImportOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = ImportOpenFileDialog.FileName;

                using (var package = new ExcelPackage(new FileInfo(filePath)))
                {
                    var worksheet = package.Workbook.Worksheets[0];
                    var rowCount = worksheet.Dimension.Rows;

                    var departments = _departmentRepository.GetDepartments();
                    var AddedRecordsCounter = 0;

                    for (int row = 2; row <= rowCount; row++)
                    {
                        var employee = new Employee();

                        employee.FullName = worksheet.Cells[row, 2].Value?.ToString();
                        employee.PersonnelNumber = worksheet.Cells[row, 3].Value?.ToString();
                        employee.Position = worksheet.Cells[row, 4].Value?.ToString();

                        if (worksheet.Cells[row, 5].Value?.ToString() != null)
                        {
                            var department = departments.FirstOrDefault(d => d.Name == worksheet.Cells[row, 5].Value?.ToString());

                            if (department != null)
                            {
                                employee.DepartmentId = department.Id;
                            }
                            else
                            {
                                employee.DepartmentId = null;
                                MessageBox.Show($"Подразделение \"{worksheet.Cells[row, 5].Value?.ToString()}\" (строка {row}) из " +
                                    $"импортируемого файла \"{Path.GetFileName(ImportOpenFileDialog.FileName)}\" не существует в базе данных."
                                    , "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            employee.DepartmentId = null;
                        }

                        employee.Email = worksheet.Cells[row, 6].Value?.ToString();
                        employee.PhoneNumber = worksheet.Cells[row, 7].Value?.ToString();
                        employee.EmploymentDate = DateTime.Parse(worksheet.Cells[row, 8].Value.ToString());

                        if (worksheet.Cells[row, 9].Value != null)
                        {
                            employee.DateOfDismissal = DateTime.Parse(worksheet.Cells[row, 9].Value.ToString());
                            employee.RecordStatus = RecordStatusEnum.Closed;
                        }
                        else
                        {
                            employee.RecordStatus = RecordStatusEnum.Current;
                        }

                        _employeeRepository.AddEmployee(employee);
                        AddedRecordsCounter++;
                    }

                    EmployeesDataGridView.DataSource = EmployeesDataGridInitialize();
                    MessageBox.Show($"Количество успешно добавленных записей: {AddedRecordsCounter}.");
                }
            }
        }

        private void AddDepartmentbutton_Click(object sender, EventArgs e)
        {
            AddDepartmentForm addDepartmentForm = new AddDepartmentForm(_departmentRepository, _employeeRepository);
            addDepartmentForm.FormClosing += AddDepartmentForm_FormClosing;

            addDepartmentForm.ShowDialog();
        }

        private void AddDepartmentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DepartmentDataGridView.DataSource = DepartmentsDataGridInitialize();
            EmployeesDataGridView.DataSource = EmployeesDataGridInitialize();
            DepartmentComboBox.DataSource = _departmentRepository.GetDepartments();
        }

        private void EditDepartmentButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedDepartment = DepartmentDataGridView.SelectedRows[0];
            int selectedDepartmentId = Convert.ToInt32(selectedDepartment.Cells[0].Value);

            EditDepartmentForm editDepartmentForm = new EditDepartmentForm(_employeeRepository, _departmentRepository,
                selectedDepartmentId);

            editDepartmentForm.FormClosing += EditDepartmentForm_FormClosing;

            editDepartmentForm.ShowDialog();
        }

        private void EditDepartmentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DepartmentDataGridView.DataSource = DepartmentsDataGridInitialize();
            EmployeesDataGridView.DataSource = EmployeesDataGridInitialize();
            DepartmentComboBox.DataSource = _departmentRepository.GetDepartments();
        }

        private void DeleteDepartmentButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedDepartment = DepartmentDataGridView.SelectedRows[0];
            _departmentRepository.DeleteDepartment(Convert.ToInt32(selectedDepartment.Cells[0].Value));

            DepartmentDataGridView.DataSource = DepartmentsDataGridInitialize();
            EmployeesDataGridView.DataSource = EmployeesDataGridInitialize();
            DepartmentComboBox.DataSource = _departmentRepository.GetDepartments();
        }

        private void DepartmentSearchButton_Click(object sender, EventArgs e)
        {
            int? departmentId = int.TryParse(DepartmentIdTextBox.Text, out int id) ? (int?)id : null;

            var filteredDepartments = _departmentRepository.GetFilteredDepartmentsWithEmployees(departmentId);

            DepartmentDataGridView.DataSource = filteredDepartments.Select(d => new DepartmentViewModel
            {
                Id = d.Id,
                Name = d.Name,
                MainDepartmentName = d.MainDepartment?.Name,
                DirectorFullName = d.Director?.FullName,
                RecordStatus = _enumHelper.GetDescriptionFromEnum(d.RecordStatus)
            }).ToList();
        }

        private void DepartmentResetButton_Click(object sender, EventArgs e)
        {
            DepartmentIdTextBox.Text = string.Empty;

            DepartmentDataGridView.DataSource = DepartmentsDataGridInitialize();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            var startPeriod = StartPeriodDateTimePicker.Value;
            var endPeriod = EndPeriodDateTimePicker.Value;
            int? departmentId = StatDepartmentsComboBox.SelectedItem != null ? Convert.ToInt32(StatDepartmentsComboBox.SelectedValue) : null;

            RecruitedNumberTextBox.Text = _employeeRepository.GetHiredEmployeesNumber(startPeriod, endPeriod, departmentId).ToString();
            DismissedNumberTextBox.Text = _employeeRepository.GetFiredEmployeesNumber(startPeriod, endPeriod, departmentId).ToString();
        }

        private void ResetStatButton_Click(object sender, EventArgs e)
        {
            StartPeriodDateTimePicker.Value = DateTime.Now;
            EndPeriodDateTimePicker.Value = DateTime.Now;
            StatDepartmentsComboBox.SelectedItem = null;

            RecruitedNumberTextBox.Text = string.Empty;
            DismissedNumberTextBox.Text = string.Empty;
        }

        private List<EmployeeViewModel> EmployeesDataGridInitialize()
        {
            return _employeeRepository.GetEmployeesWithDepartments().Select(e => new EmployeeViewModel
            {
                Id = e.Id,
                FullName = e.FullName,
                PersonnelNumber = e.PersonnelNumber,
                Position = e.Position,
                DepartmentName = e.Department?.Name,
                Email = e.Email,
                PhoneNumber = e.PhoneNumber,
                EmploymentDate = e.EmploymentDate,
                RecordStatus = _enumHelper.GetDescriptionFromEnum(e.RecordStatus),
                DateOfDismissal = e.DateOfDismissal
            }).ToList();
        }

        private List<DepartmentViewModel> DepartmentsDataGridInitialize()
        {
            return _departmentRepository.GetDepartmentsWithEmployees().Select(d => new DepartmentViewModel
            {
                Id = d.Id,
                Name = d.Name,
                MainDepartmentName = d.MainDepartment?.Name,
                DirectorFullName = d.Director?.FullName,
                RecordStatus = _enumHelper.GetDescriptionFromEnum(d.RecordStatus),
            }).ToList();
        }
    }
}
