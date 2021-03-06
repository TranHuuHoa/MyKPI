﻿using System;
using System.Windows.Forms;
using MyKPI.ProjectManagement.GUI;
using MyKPI.EmployeeManagment.GUI;
using MyKPI.JobKpiAssessment.GUI;

namespace MyKPI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void btnProjectManagement_Click(object sender, EventArgs e)
        {
            ProjectManagementForm projectManagementForm = new ProjectManagementForm();
            projectManagementForm.ShowDialog();
        }

        private void btnEmployeeManagement_Click(object sender, EventArgs e)
        {
            EmployeeManagementForm employeeManagementForm = new EmployeeManagementForm();
            employeeManagementForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //  btnEmployeeManagement_Click(sender, e);
            //btnProjectManagement_Click(sender,e);
            //this.Close();
        }

        private void btnJobKpiAssessment_Click(object sender, EventArgs e)
        {
            JobKpiAssessmentManagementForm jobKpiAssessmentManagementForm = new JobKpiAssessmentManagementForm();
            jobKpiAssessmentManagementForm.ShowDialog();           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
