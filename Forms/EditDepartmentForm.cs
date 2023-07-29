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
    public partial class EditDepartmentForm : Form
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IDepartmentRepository _departmentRepository;

        private readonly RecordStatusEnumHelper _enumHelper;
        private readonly int _departmentId;

        public EditDepartmentForm(IEmployeeRepository employeeRepository, IDepartmentRepository departmentRepository,
            int departmentId)
        {
            _employeeRepository = employeeRepository;
            _departmentRepository = departmentRepository;
            _enumHelper = new RecordStatusEnumHelper();
            _departmentId = departmentId;

            InitializeComponent();
            RecordStatusLoadComboBox();


            MainDepartmentComboBox.DataSource = _departmentRepository.GetDepartments();
            MainDepartmentComboBox.DisplayMember = "Name";
            MainDepartmentComboBox.ValueMember = "Id";

            DirectorComboBox.DataSource = _employeeRepository.GetEmployees();
            DirectorComboBox.DisplayMember = "FullName";
            DirectorComboBox.ValueMember = "Id";
        }

        private void EditDepartmentForm_Load(object sender, EventArgs e)
        {
            var departmentToUpdate = _departmentRepository.GetDepartment(_departmentId);

            NameTextBox.Text = departmentToUpdate.Name;

            if (departmentToUpdate.MainDepartmentId == null)
                MainDepartmentComboBox.SelectedItem = null;
            else
                MainDepartmentComboBox.SelectedItem = departmentToUpdate.MainDepartment;

            if (departmentToUpdate.DirectorId == null)
                DirectorComboBox.SelectedItem = null;
            else
                DirectorComboBox.SelectedItem = departmentToUpdate.Director;

            RecordStatusComboBox.SelectedItem = _enumHelper.GetDescriptionFromEnum(departmentToUpdate.RecordStatus);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(NameTextBox.Text)))
            {
                var departmentToUpdate = _departmentRepository.GetDepartment(_departmentId);
                departmentToUpdate.Name = NameTextBox.Text;

                if (MainDepartmentComboBox.SelectedItem != null)
                    departmentToUpdate.MainDepartmentId = Convert.ToInt32(MainDepartmentComboBox.SelectedValue);
                else
                    departmentToUpdate.MainDepartmentId = null;

                if (DirectorComboBox.SelectedItem != null)
                    departmentToUpdate.DirectorId = Convert.ToInt32(DirectorComboBox.SelectedValue);
                else
                    departmentToUpdate.DirectorId = null;

                departmentToUpdate.RecordStatus = _enumHelper.GetEnumFromDescription(RecordStatusComboBox.SelectedItem.ToString());

                _departmentRepository.UpdateDepartment(departmentToUpdate);

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
