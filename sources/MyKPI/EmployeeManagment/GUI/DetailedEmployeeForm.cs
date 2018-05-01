using System;
using System.Windows.Forms;
using MyKPI.EmployeeManagment.BLL;
using MyKPI.Entities;
using MyKPI.Common;

namespace MyKPI.EmployeeManagment.GUI
{
    public partial class DetailedEmployeeForm : Form
    {
        EmployeeBLL employeeBLL = new EmployeeBLL();
        int mode = 0;
        int ID = 0;
        public DetailedEmployeeForm()
        {
            InitializeComponent();
            InitComboBox();
            mode = 0;
            txtSalarySubLevel.Text = "1";
        }

        public DetailedEmployeeForm(EmployeeEntity _employeeEntity)
        {
            InitializeComponent();
            InitComboBox();
            mode = 1;
            ID = _employeeEntity.ID;
            txtEmployeeNumber.Text = _employeeEntity.EmployeeNumber;
            txtEmployeeFirstName.Text = _employeeEntity.EmployeeFirstName;
            txtEmployeeLastName.Text = _employeeEntity.EmployeeLastName;
            txtAddress.Text = _employeeEntity.Address;
            txtIdCard.Text = _employeeEntity.IDCard;
            dtpDOB.Value = _employeeEntity.DOB;
            cbxJobRankType.SelectedItem = _employeeEntity.JobRankType;
            cbxJobRankLevel.SelectedItem = _employeeEntity.JobRankLevel;
            cbxSalaryLevel.SelectedItem = _employeeEntity.SalaryLevel;
            txtSalarySubLevel.Text = _employeeEntity.SalarySubLevel.ToString();

        }

        private void InitComboBox()
        {
            cbxSex.Items.Clear();
            cbxSex.Items.Add(SexValue.Male);
            cbxSex.Items.Add(SexValue.Female);
            cbxSex.Items.Add(SexValue.Others);
            cbxSex.SelectedIndex = 0;

            cbxJobRankType.Items.Clear();
            cbxJobRankType.Items.Add(JobRankValue.ProjectManager);
            cbxJobRankType.Items.Add(JobRankValue.Developer);
            cbxJobRankType.Items.Add(JobRankValue.Tester);
            cbxJobRankType.Items.Add(JobRankValue.SolutionArchitect);
            cbxJobRankType.Items.Add(JobRankValue.BussinessAnalyst);
            cbxJobRankType.SelectedIndex = 0;

            cbxJobRankLevel.Items.Clear();
            cbxJobRankLevel.Items.Add(JobRankLevelValue.Level1);
            cbxJobRankLevel.Items.Add(JobRankLevelValue.Level2);
            cbxJobRankLevel.Items.Add(JobRankLevelValue.Level3);
            cbxJobRankLevel.Items.Add(JobRankLevelValue.Level4);
            cbxJobRankLevel.Items.Add(JobRankLevelValue.Level5);
            cbxJobRankLevel.Items.Add(JobRankLevelValue.Level6);
            cbxJobRankLevel.SelectedIndex = 0;

            cbxSalaryLevel.Items.Clear();
            cbxSalaryLevel.Items.Add(SalaryLevelValue.Level1);
            cbxSalaryLevel.Items.Add(SalaryLevelValue.Level2);
            cbxSalaryLevel.Items.Add(SalaryLevelValue.Level3);
            cbxSalaryLevel.Items.Add(SalaryLevelValue.Level4);
            cbxSalaryLevel.Items.Add(SalaryLevelValue.Level5);
            cbxSalaryLevel.Items.Add(SalaryLevelValue.Level6);
            cbxSalaryLevel.Items.Add(SalaryLevelValue.Level7);
            cbxSalaryLevel.Items.Add(SalaryLevelValue.Level8);
            cbxSalaryLevel.Items.Add(SalaryLevelValue.Level9);
            cbxSalaryLevel.SelectedIndex = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            EmployeeEntity employeeEntity = new EmployeeEntity();
            employeeEntity.EmployeeNumber = txtEmployeeNumber.Text;
            employeeEntity.EmployeeFirstName = txtEmployeeFirstName.Text;
            employeeEntity.EmployeeLastName = txtEmployeeLastName.Text;
            employeeEntity.Address = txtAddress.Text;
            employeeEntity.IDCard = txtIdCard.Text;
            employeeEntity.DOB = dtpDOB.Value;
            employeeEntity.Sex = (SexValue)cbxSex.SelectedItem;
            employeeEntity.JobRankType = (JobRankValue) cbxJobRankType.SelectedItem;
            employeeEntity.JobRankLevel = (JobRankLevelValue) cbxJobRankLevel.SelectedItem;
            employeeEntity.SalaryLevel = (SalaryLevelValue)cbxSalaryLevel.SelectedItem;
            employeeEntity.SalarySubLevel = Convert.ToInt32(txtSalarySubLevel.Text);

            if(mode == 0)
            {
                employeeBLL.AddEmployee(employeeEntity);
            }
            if(mode == 1)
            {
                employeeBLL.EditEmployee(employeeEntity, ID);
            }
            this.Close();

        }

        private void DetailedEmployeeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
