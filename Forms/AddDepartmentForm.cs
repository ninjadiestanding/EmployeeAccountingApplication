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
    public partial class AddDepartmentForm : Form
    {
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly RecordStatusEnumHelper _enumHelper;
        public AddDepartmentForm(IDepartmentRepository departmentRepository, IEmployeeRepository employeeRepository)
        {
            _departmentRepository = departmentRepository;
            _employeeRepository = employeeRepository;
            _enumHelper = new RecordStatusEnumHelper();

            InitializeComponent();
            RecordStatusLoadComboBox();

            DirectorComboBox.DataSource = _employeeRepository.GetEmployees();
            DirectorComboBox.DisplayMember = "FullName";
            DirectorComboBox.ValueMember = "Id";
            DirectorComboBox.SelectedItem = null;

            MainDepartmentComboBox.DataSource = _departmentRepository.GetDepartments();
            MainDepartmentComboBox.DisplayMember = "Name";
            MainDepartmentComboBox.ValueMember = "Id";
            MainDepartmentComboBox.SelectedItem = null;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(NameTextBox.Text)))
            {
                var department = new Department();

                department.Name = NameTextBox.Text;

                if (MainDepartmentComboBox.SelectedItem != null)
                    department.MainDepartmentId = Convert.ToInt32(MainDepartmentComboBox.SelectedValue);
                else
                    department.MainDepartmentId = null;

                if (DirectorComboBox.SelectedItem != null)
                    department.DirectorId = Convert.ToInt32(DirectorComboBox.SelectedValue);
                else
                    department.DirectorId = null;

                department.RecordStatus = _enumHelper.GetEnumFromDescription(RecordStatusComboBox.SelectedItem.ToString());

                _departmentRepository.AddDepartment(department);

                this.Close();
            }
            else
            {
                MessageBox.Show("Поле \"Наименование\" обязательно для заполнения.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                NameTextBox.Enabled = false;
                MainDepartmentComboBox.Enabled = false;
                DirectorComboBox.Enabled = false;
            }
            else
            {
                NameTextBox.Enabled = true;
                MainDepartmentComboBox.Enabled = true;
                DirectorComboBox.Enabled = true;
            }
        }
    }
}
