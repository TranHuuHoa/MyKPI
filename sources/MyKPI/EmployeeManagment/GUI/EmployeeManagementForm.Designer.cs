namespace MyKPI.EmployeeManagment.GUI
{
    partial class EmployeeManagementForm
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
            this.grcEmployee = new DevExpress.XtraGrid.GridControl();
            this.grvEmployee = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grColID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grColEmployeeNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grColEmployeeName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grColAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grColDOB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grColIDCard = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grColSex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grColJobRankType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grColJobRankLevel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grColSalaryLevel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grColSalarySubLevel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grColEmployeeFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grColEmployeeLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grColJobRank = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grColSalary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnDUEmployee = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grcEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // grcEmployee
            // 
            this.grcEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grcEmployee.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grcEmployee.Location = new System.Drawing.Point(0, 0);
            this.grcEmployee.MainView = this.grvEmployee;
            this.grcEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grcEmployee.Name = "grcEmployee";
            this.grcEmployee.Size = new System.Drawing.Size(1324, 712);
            this.grcEmployee.TabIndex = 0;
            this.grcEmployee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvEmployee});
            // 
            // grvEmployee
            // 
            this.grvEmployee.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grColID,
            this.grColEmployeeNumber,
            this.grColEmployeeName1,
            this.grColAddress,
            this.grColDOB,
            this.grColIDCard,
            this.grColSex,
            this.grColJobRankType,
            this.grColJobRankLevel,
            this.grColSalaryLevel,
            this.grColSalarySubLevel,
            this.grColEmployeeFirstName,
            this.grColEmployeeLastName,
            this.grColJobRank,
            this.grColSalary});
            this.grvEmployee.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.grvEmployee.GridControl = this.grcEmployee;
            this.grvEmployee.Name = "grvEmployee";
            this.grvEmployee.OptionsBehavior.Editable = false;
            this.grvEmployee.OptionsView.ShowGroupPanel = false;
            this.grvEmployee.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.grvEmployee_CustomColumnDisplayText);
            // 
            // grColID
            // 
            this.grColID.Caption = "ID";
            this.grColID.FieldName = "ID";
            this.grColID.Name = "grColID";
            // 
            // grColEmployeeNumber
            // 
            this.grColEmployeeNumber.Caption = "Employee Number";
            this.grColEmployeeNumber.FieldName = "EmployeeNumber";
            this.grColEmployeeNumber.Name = "grColEmployeeNumber";
            this.grColEmployeeNumber.Visible = true;
            this.grColEmployeeNumber.VisibleIndex = 0;
            // 
            // grColEmployeeName1
            // 
            this.grColEmployeeName1.Caption = "Employee Name";
            this.grColEmployeeName1.FieldName = "EmployeeName";
            this.grColEmployeeName1.Name = "grColEmployeeName1";
            this.grColEmployeeName1.Visible = true;
            this.grColEmployeeName1.VisibleIndex = 1;
            // 
            // grColAddress
            // 
            this.grColAddress.Caption = "Address";
            this.grColAddress.FieldName = "Address";
            this.grColAddress.Name = "grColAddress";
            // 
            // grColDOB
            // 
            this.grColDOB.Caption = "Date Of Birth";
            this.grColDOB.FieldName = "DOB";
            this.grColDOB.Name = "grColDOB";
            this.grColDOB.Visible = true;
            this.grColDOB.VisibleIndex = 2;
            // 
            // grColIDCard
            // 
            this.grColIDCard.Caption = "ID Card";
            this.grColIDCard.FieldName = "IDCard";
            this.grColIDCard.Name = "grColIDCard";
            // 
            // grColSex
            // 
            this.grColSex.Caption = "Sex";
            this.grColSex.FieldName = "Sex";
            this.grColSex.Name = "grColSex";
            this.grColSex.Visible = true;
            this.grColSex.VisibleIndex = 3;
            // 
            // grColJobRankType
            // 
            this.grColJobRankType.Caption = "Job Rank Type";
            this.grColJobRankType.FieldName = "JobRankType";
            this.grColJobRankType.Name = "grColJobRankType";
            // 
            // grColJobRankLevel
            // 
            this.grColJobRankLevel.Caption = "Job Rank Level";
            this.grColJobRankLevel.FieldName = "JobRankLevel";
            this.grColJobRankLevel.Name = "grColJobRankLevel";
            // 
            // grColSalaryLevel
            // 
            this.grColSalaryLevel.Caption = "Salary Level";
            this.grColSalaryLevel.FieldName = "SalaryLevel";
            this.grColSalaryLevel.Name = "grColSalaryLevel";
            // 
            // grColSalarySubLevel
            // 
            this.grColSalarySubLevel.Caption = "Salary Sub Level";
            this.grColSalarySubLevel.FieldName = "SalarySubLevel";
            this.grColSalarySubLevel.Name = "grColSalarySubLevel";
            // 
            // grColEmployeeFirstName
            // 
            this.grColEmployeeFirstName.Caption = "Employee First Name";
            this.grColEmployeeFirstName.FieldName = "EmployeeFirstName";
            this.grColEmployeeFirstName.Name = "grColEmployeeFirstName";
            // 
            // grColEmployeeLastName
            // 
            this.grColEmployeeLastName.Caption = "Employee Last Name";
            this.grColEmployeeLastName.FieldName = "EmployeeLastName";
            this.grColEmployeeLastName.Name = "grColEmployeeLastName";
            // 
            // grColJobRank
            // 
            this.grColJobRank.Caption = "Job Rank";
            this.grColJobRank.FieldName = "JobRank";
            this.grColJobRank.Name = "grColJobRank";
            this.grColJobRank.Visible = true;
            this.grColJobRank.VisibleIndex = 4;
            // 
            // grColSalary
            // 
            this.grColSalary.Caption = "Salary";
            this.grColSalary.FieldName = "Salary";
            this.grColSalary.Name = "grColSalary";
            this.grColSalary.Visible = true;
            this.grColSalary.VisibleIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExit.Location = new System.Drawing.Point(918, 726);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(218, 34);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeleteEmployee.Location = new System.Drawing.Point(675, 726);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(218, 34);
            this.btnDeleteEmployee.TabIndex = 7;
            this.btnDeleteEmployee.Text = "DELETE EMPLOYEE";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // btnDUEmployee
            // 
            this.btnDUEmployee.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDUEmployee.Location = new System.Drawing.Point(424, 726);
            this.btnDUEmployee.Name = "btnDUEmployee";
            this.btnDUEmployee.Size = new System.Drawing.Size(218, 34);
            this.btnDUEmployee.TabIndex = 6;
            this.btnDUEmployee.Text = "DETAILED/UPDATE EMPLOYEE";
            this.btnDUEmployee.UseVisualStyleBackColor = true;
            this.btnDUEmployee.Click += new System.EventHandler(this.btnDUEmployee_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddEmployee.Location = new System.Drawing.Point(168, 726);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(218, 34);
            this.btnAddEmployee.TabIndex = 5;
            this.btnAddEmployee.Text = "ADD NEW EMPLOYEE";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // EmployeeManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 777);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDeleteEmployee);
            this.Controls.Add(this.btnDUEmployee);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.grcEmployee);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmployeeManagementForm";
            this.Text = "Employee Management Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EmployeeManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grcEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grcEmployee;
        private DevExpress.XtraGrid.Views.Grid.GridView grvEmployee;
        private DevExpress.XtraGrid.Columns.GridColumn grColID;
        private DevExpress.XtraGrid.Columns.GridColumn grColEmployeeNumber;
        private DevExpress.XtraGrid.Columns.GridColumn grColEmployeeName;
        private DevExpress.XtraGrid.Columns.GridColumn grColAddress;
        private DevExpress.XtraGrid.Columns.GridColumn grColDOB;
        private DevExpress.XtraGrid.Columns.GridColumn grColIDCard;
        private DevExpress.XtraGrid.Columns.GridColumn grColSex;
        private DevExpress.XtraGrid.Columns.GridColumn grColJobRankType;
        private DevExpress.XtraGrid.Columns.GridColumn grColJobRankLevel;
        private DevExpress.XtraGrid.Columns.GridColumn grColSalaryLevel;
        private DevExpress.XtraGrid.Columns.GridColumn grColSalarySubLevel;
        private DevExpress.XtraGrid.Columns.GridColumn grColEmployeeFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn grColEmployeeLastName;
        private DevExpress.XtraGrid.Columns.GridColumn grColJobRank;
        private DevExpress.XtraGrid.Columns.GridColumn grColSalary;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnDUEmployee;
        private System.Windows.Forms.Button btnAddEmployee;
        private DevExpress.XtraGrid.Columns.GridColumn grColEmployeeName1;
    }
}