namespace MyKPI.ProjectManagement.GUI
{
    partial class DetailedProjectForm
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
            this.gbxProjectTaskManagement = new System.Windows.Forms.GroupBox();
            this.grcTask = new DevExpress.XtraGrid.GridControl();
            this.grvTask = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grcolID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcolTaskCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcolStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcolTaskName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcolAssigneeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcolReporterName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcolPriority = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcolTaskType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcolDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.btnDUTask = new System.Windows.Forms.Button();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.gbxProjectMemberManagement = new System.Windows.Forms.GroupBox();
            this.btnPECancel = new System.Windows.Forms.Button();
            this.cbxRole = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtmPMEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtmPMStartedDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxProjectMember = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnChangeActiveProjectMember = new System.Windows.Forms.Button();
            this.btnUpdateProjectMemberInformation = new System.Windows.Forms.Button();
            this.btnAddNewProjectMember = new System.Windows.Forms.Button();
            this.grcProjectMember = new DevExpress.XtraGrid.GridControl();
            this.grvProjectMember = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grColPEID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grColPEProjectID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grColPEEmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grColPEEmployeeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grColPEStartedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grColPEEndDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grColPERole = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grColPEActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gbxProjectGeneralnformation = new System.Windows.Forms.GroupBox();
            this.lblProjectCodeNotification = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirmProject = new System.Windows.Forms.Button();
            this.cbxProjectStatus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtmEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtmStartedDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblScopeMM = new System.Windows.Forms.Label();
            this.txtScopeMM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProjectCode = new System.Windows.Forms.TextBox();
            this.lblProjectNameNotification = new System.Windows.Forms.Label();
            this.lblCustomerNameNotification = new System.Windows.Forms.Label();
            this.lblScopeMMNotification = new System.Windows.Forms.Label();
            this.gbxProjectTaskManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTask)).BeginInit();
            this.gbxProjectMemberManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcProjectMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvProjectMember)).BeginInit();
            this.gbxProjectGeneralnformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxProjectTaskManagement
            // 
            this.gbxProjectTaskManagement.Controls.Add(this.grcTask);
            this.gbxProjectTaskManagement.Controls.Add(this.btnExit);
            this.gbxProjectTaskManagement.Controls.Add(this.btnDeleteTask);
            this.gbxProjectTaskManagement.Controls.Add(this.btnDUTask);
            this.gbxProjectTaskManagement.Controls.Add(this.btnAddTask);
            this.gbxProjectTaskManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxProjectTaskManagement.Location = new System.Drawing.Point(0, 334);
            this.gbxProjectTaskManagement.Margin = new System.Windows.Forms.Padding(2);
            this.gbxProjectTaskManagement.Name = "gbxProjectTaskManagement";
            this.gbxProjectTaskManagement.Padding = new System.Windows.Forms.Padding(2);
            this.gbxProjectTaskManagement.Size = new System.Drawing.Size(1185, 181);
            this.gbxProjectTaskManagement.TabIndex = 5;
            this.gbxProjectTaskManagement.TabStop = false;
            this.gbxProjectTaskManagement.Text = "Project task managment:";
            // 
            // grcTask
            // 
            this.grcTask.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grcTask.Location = new System.Drawing.Point(0, 32);
            this.grcTask.MainView = this.grvTask;
            this.grcTask.Name = "grcTask";
            this.grcTask.Size = new System.Drawing.Size(1185, 114);
            this.grcTask.TabIndex = 5;
            this.grcTask.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvTask});
            // 
            // grvTask
            // 
            this.grvTask.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grcolID,
            this.grcolTaskCode,
            this.grcolStatus,
            this.grcolTaskName,
            this.grcolAssigneeName,
            this.grcolReporterName,
            this.grcolPriority,
            this.grcolTaskType,
            this.grcolDescription});
            this.grvTask.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.grvTask.GridControl = this.grcTask;
            this.grvTask.Name = "grvTask";
            this.grvTask.OptionsBehavior.Editable = false;
            this.grvTask.OptionsView.ShowGroupPanel = false;
            this.grvTask.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.grvTask_CustomColumnDisplayText);
            // 
            // grcolID
            // 
            this.grcolID.Caption = "ID";
            this.grcolID.FieldName = "ID";
            this.grcolID.Name = "grcolID";
            // 
            // grcolTaskCode
            // 
            this.grcolTaskCode.Caption = "Task Code";
            this.grcolTaskCode.FieldName = "TaskCode";
            this.grcolTaskCode.Name = "grcolTaskCode";
            this.grcolTaskCode.Visible = true;
            this.grcolTaskCode.VisibleIndex = 0;
            // 
            // grcolStatus
            // 
            this.grcolStatus.Caption = "Status";
            this.grcolStatus.FieldName = "Status";
            this.grcolStatus.Name = "grcolStatus";
            this.grcolStatus.Visible = true;
            this.grcolStatus.VisibleIndex = 2;
            // 
            // grcolTaskName
            // 
            this.grcolTaskName.Caption = "Task Name";
            this.grcolTaskName.FieldName = "TaskName";
            this.grcolTaskName.Name = "grcolTaskName";
            this.grcolTaskName.Visible = true;
            this.grcolTaskName.VisibleIndex = 1;
            // 
            // grcolAssigneeName
            // 
            this.grcolAssigneeName.Caption = "Assignee";
            this.grcolAssigneeName.FieldName = "AssigneeName";
            this.grcolAssigneeName.Name = "grcolAssigneeName";
            this.grcolAssigneeName.Visible = true;
            this.grcolAssigneeName.VisibleIndex = 3;
            // 
            // grcolReporterName
            // 
            this.grcolReporterName.Caption = "Reporter";
            this.grcolReporterName.FieldName = "ReporterName";
            this.grcolReporterName.Name = "grcolReporterName";
            this.grcolReporterName.Visible = true;
            this.grcolReporterName.VisibleIndex = 4;
            // 
            // grcolPriority
            // 
            this.grcolPriority.Caption = "Priority";
            this.grcolPriority.FieldName = "Priority";
            this.grcolPriority.Name = "grcolPriority";
            this.grcolPriority.Visible = true;
            this.grcolPriority.VisibleIndex = 5;
            // 
            // grcolTaskType
            // 
            this.grcolTaskType.Caption = "TaskType";
            this.grcolTaskType.FieldName = "TaskType";
            this.grcolTaskType.Name = "grcolTaskType";
            this.grcolTaskType.Visible = true;
            this.grcolTaskType.VisibleIndex = 6;
            // 
            // grcolDescription
            // 
            this.grcolDescription.Caption = "Description";
            this.grcolDescription.FieldName = "Description";
            this.grcolDescription.Name = "grcolDescription";
            this.grcolDescription.Visible = true;
            this.grcolDescription.VisibleIndex = 7;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExit.Location = new System.Drawing.Point(767, 151);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(145, 22);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeleteTask.Location = new System.Drawing.Point(605, 151);
            this.btnDeleteTask.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(145, 22);
            this.btnDeleteTask.TabIndex = 3;
            this.btnDeleteTask.Text = "DELETE TASK";
            this.btnDeleteTask.UseVisualStyleBackColor = true;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // btnDUTask
            // 
            this.btnDUTask.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDUTask.Location = new System.Drawing.Point(438, 151);
            this.btnDUTask.Margin = new System.Windows.Forms.Padding(2);
            this.btnDUTask.Name = "btnDUTask";
            this.btnDUTask.Size = new System.Drawing.Size(145, 22);
            this.btnDUTask.TabIndex = 2;
            this.btnDUTask.Text = "DETAILED/UPDATE TASK";
            this.btnDUTask.UseVisualStyleBackColor = true;
            this.btnDUTask.Click += new System.EventHandler(this.btnDUTask_Click);
            // 
            // btnAddTask
            // 
            this.btnAddTask.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddTask.Location = new System.Drawing.Point(267, 151);
            this.btnAddTask.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(145, 22);
            this.btnAddTask.TabIndex = 1;
            this.btnAddTask.Text = "ADD NEW TASK";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // gbxProjectMemberManagement
            // 
            this.gbxProjectMemberManagement.Controls.Add(this.btnPECancel);
            this.gbxProjectMemberManagement.Controls.Add(this.cbxRole);
            this.gbxProjectMemberManagement.Controls.Add(this.label11);
            this.gbxProjectMemberManagement.Controls.Add(this.dtmPMEndDate);
            this.gbxProjectMemberManagement.Controls.Add(this.dtmPMStartedDate);
            this.gbxProjectMemberManagement.Controls.Add(this.label9);
            this.gbxProjectMemberManagement.Controls.Add(this.label10);
            this.gbxProjectMemberManagement.Controls.Add(this.cbxProjectMember);
            this.gbxProjectMemberManagement.Controls.Add(this.label8);
            this.gbxProjectMemberManagement.Controls.Add(this.btnChangeActiveProjectMember);
            this.gbxProjectMemberManagement.Controls.Add(this.btnUpdateProjectMemberInformation);
            this.gbxProjectMemberManagement.Controls.Add(this.btnAddNewProjectMember);
            this.gbxProjectMemberManagement.Controls.Add(this.grcProjectMember);
            this.gbxProjectMemberManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxProjectMemberManagement.Location = new System.Drawing.Point(0, 146);
            this.gbxProjectMemberManagement.Margin = new System.Windows.Forms.Padding(2);
            this.gbxProjectMemberManagement.Name = "gbxProjectMemberManagement";
            this.gbxProjectMemberManagement.Padding = new System.Windows.Forms.Padding(2);
            this.gbxProjectMemberManagement.Size = new System.Drawing.Size(1185, 188);
            this.gbxProjectMemberManagement.TabIndex = 4;
            this.gbxProjectMemberManagement.TabStop = false;
            this.gbxProjectMemberManagement.Text = "Project member management";
            // 
            // btnPECancel
            // 
            this.btnPECancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPECancel.Location = new System.Drawing.Point(378, 117);
            this.btnPECancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnPECancel.Name = "btnPECancel";
            this.btnPECancel.Size = new System.Drawing.Size(145, 22);
            this.btnPECancel.TabIndex = 19;
            this.btnPECancel.Text = "CANCEL";
            this.btnPECancel.UseVisualStyleBackColor = true;
            this.btnPECancel.Click += new System.EventHandler(this.btnPECancel_Click);
            // 
            // cbxRole
            // 
            this.cbxRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRole.FormattingEnabled = true;
            this.cbxRole.Location = new System.Drawing.Point(123, 101);
            this.cbxRole.Margin = new System.Windows.Forms.Padding(2);
            this.cbxRole.Name = "cbxRole";
            this.cbxRole.Size = new System.Drawing.Size(229, 21);
            this.cbxRole.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(88, 103);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Role:";
            // 
            // dtmPMEndDate
            // 
            this.dtmPMEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtmPMEndDate.Location = new System.Drawing.Point(123, 80);
            this.dtmPMEndDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtmPMEndDate.Name = "dtmPMEndDate";
            this.dtmPMEndDate.Size = new System.Drawing.Size(229, 20);
            this.dtmPMEndDate.TabIndex = 15;
            // 
            // dtmPMStartedDate
            // 
            this.dtmPMStartedDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtmPMStartedDate.Location = new System.Drawing.Point(123, 59);
            this.dtmPMStartedDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtmPMStartedDate.Name = "dtmPMStartedDate";
            this.dtmPMStartedDate.Size = new System.Drawing.Size(229, 20);
            this.dtmPMStartedDate.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(65, 83);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "End Date:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 60);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Started Date:";
            // 
            // cbxProjectMember
            // 
            this.cbxProjectMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxProjectMember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProjectMember.FormattingEnabled = true;
            this.cbxProjectMember.Location = new System.Drawing.Point(123, 37);
            this.cbxProjectMember.Margin = new System.Windows.Forms.Padding(2);
            this.cbxProjectMember.Name = "cbxProjectMember";
            this.cbxProjectMember.Size = new System.Drawing.Size(229, 21);
            this.cbxProjectMember.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 39);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Member Name:";
            // 
            // btnChangeActiveProjectMember
            // 
            this.btnChangeActiveProjectMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeActiveProjectMember.Location = new System.Drawing.Point(378, 91);
            this.btnChangeActiveProjectMember.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangeActiveProjectMember.Name = "btnChangeActiveProjectMember";
            this.btnChangeActiveProjectMember.Size = new System.Drawing.Size(145, 22);
            this.btnChangeActiveProjectMember.TabIndex = 4;
            this.btnChangeActiveProjectMember.Text = "ACTIVE/DEACTIVE";
            this.btnChangeActiveProjectMember.UseVisualStyleBackColor = true;
            this.btnChangeActiveProjectMember.Click += new System.EventHandler(this.btnChangeActiveProjectMember_Click);
            // 
            // btnUpdateProjectMemberInformation
            // 
            this.btnUpdateProjectMemberInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateProjectMemberInformation.Location = new System.Drawing.Point(378, 65);
            this.btnUpdateProjectMemberInformation.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateProjectMemberInformation.Name = "btnUpdateProjectMemberInformation";
            this.btnUpdateProjectMemberInformation.Size = new System.Drawing.Size(145, 22);
            this.btnUpdateProjectMemberInformation.TabIndex = 3;
            this.btnUpdateProjectMemberInformation.Text = "UPDATE INFORMATION";
            this.btnUpdateProjectMemberInformation.UseVisualStyleBackColor = true;
            this.btnUpdateProjectMemberInformation.Click += new System.EventHandler(this.btnUpdateProjectMemberInformation_Click);
            // 
            // btnAddNewProjectMember
            // 
            this.btnAddNewProjectMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewProjectMember.Location = new System.Drawing.Point(378, 39);
            this.btnAddNewProjectMember.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewProjectMember.Name = "btnAddNewProjectMember";
            this.btnAddNewProjectMember.Size = new System.Drawing.Size(145, 22);
            this.btnAddNewProjectMember.TabIndex = 2;
            this.btnAddNewProjectMember.Text = "ADD NEW MEMBER";
            this.btnAddNewProjectMember.UseVisualStyleBackColor = true;
            this.btnAddNewProjectMember.Click += new System.EventHandler(this.btnAddNewProjectMember_Click);
            // 
            // grcProjectMember
            // 
            this.grcProjectMember.Dock = System.Windows.Forms.DockStyle.Right;
            this.grcProjectMember.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.grcProjectMember.Location = new System.Drawing.Point(554, 15);
            this.grcProjectMember.MainView = this.grvProjectMember;
            this.grcProjectMember.Margin = new System.Windows.Forms.Padding(2);
            this.grcProjectMember.Name = "grcProjectMember";
            this.grcProjectMember.Size = new System.Drawing.Size(629, 171);
            this.grcProjectMember.TabIndex = 0;
            this.grcProjectMember.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvProjectMember});
            // 
            // grvProjectMember
            // 
            this.grvProjectMember.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grColPEID,
            this.grColPEProjectID,
            this.grColPEEmployeeID,
            this.grColPEEmployeeName,
            this.grColPEStartedDate,
            this.grColPEEndDate,
            this.grColPERole,
            this.grColPEActive});
            this.grvProjectMember.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.grvProjectMember.GridControl = this.grcProjectMember;
            this.grvProjectMember.Name = "grvProjectMember";
            this.grvProjectMember.OptionsBehavior.Editable = false;
            this.grvProjectMember.OptionsView.ShowGroupPanel = false;
            this.grvProjectMember.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grvProjectMember_FocusedRowChanged);
            this.grvProjectMember.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.grvProjectMember_CustomColumnDisplayText);
            // 
            // grColPEID
            // 
            this.grColPEID.Caption = "ID";
            this.grColPEID.FieldName = "ID";
            this.grColPEID.Name = "grColPEID";
            // 
            // grColPEProjectID
            // 
            this.grColPEProjectID.Caption = "ProjectID";
            this.grColPEProjectID.FieldName = "ProjectID";
            this.grColPEProjectID.Name = "grColPEProjectID";
            // 
            // grColPEEmployeeID
            // 
            this.grColPEEmployeeID.Caption = "EmployeeID";
            this.grColPEEmployeeID.FieldName = "EmployeeID";
            this.grColPEEmployeeID.Name = "grColPEEmployeeID";
            // 
            // grColPEEmployeeName
            // 
            this.grColPEEmployeeName.Caption = "Employee Name";
            this.grColPEEmployeeName.FieldName = "EmployeeName";
            this.grColPEEmployeeName.Name = "grColPEEmployeeName";
            this.grColPEEmployeeName.Visible = true;
            this.grColPEEmployeeName.VisibleIndex = 0;
            // 
            // grColPEStartedDate
            // 
            this.grColPEStartedDate.Caption = "Started Date";
            this.grColPEStartedDate.FieldName = "StartedDate";
            this.grColPEStartedDate.Name = "grColPEStartedDate";
            this.grColPEStartedDate.Visible = true;
            this.grColPEStartedDate.VisibleIndex = 1;
            // 
            // grColPEEndDate
            // 
            this.grColPEEndDate.Caption = "End Date";
            this.grColPEEndDate.FieldName = "EndDate";
            this.grColPEEndDate.Name = "grColPEEndDate";
            this.grColPEEndDate.Visible = true;
            this.grColPEEndDate.VisibleIndex = 2;
            // 
            // grColPERole
            // 
            this.grColPERole.Caption = "Role";
            this.grColPERole.FieldName = "Role";
            this.grColPERole.Name = "grColPERole";
            this.grColPERole.Visible = true;
            this.grColPERole.VisibleIndex = 3;
            // 
            // grColPEActive
            // 
            this.grColPEActive.Caption = "Active";
            this.grColPEActive.FieldName = "Active";
            this.grColPEActive.Name = "grColPEActive";
            this.grColPEActive.Visible = true;
            this.grColPEActive.VisibleIndex = 4;
            // 
            // gbxProjectGeneralnformation
            // 
            this.gbxProjectGeneralnformation.Controls.Add(this.lblScopeMMNotification);
            this.gbxProjectGeneralnformation.Controls.Add(this.lblCustomerNameNotification);
            this.gbxProjectGeneralnformation.Controls.Add(this.lblProjectNameNotification);
            this.gbxProjectGeneralnformation.Controls.Add(this.lblProjectCodeNotification);
            this.gbxProjectGeneralnformation.Controls.Add(this.btnCancel);
            this.gbxProjectGeneralnformation.Controls.Add(this.btnConfirmProject);
            this.gbxProjectGeneralnformation.Controls.Add(this.cbxProjectStatus);
            this.gbxProjectGeneralnformation.Controls.Add(this.label7);
            this.gbxProjectGeneralnformation.Controls.Add(this.dtmEndDate);
            this.gbxProjectGeneralnformation.Controls.Add(this.dtmStartedDate);
            this.gbxProjectGeneralnformation.Controls.Add(this.label6);
            this.gbxProjectGeneralnformation.Controls.Add(this.label5);
            this.gbxProjectGeneralnformation.Controls.Add(this.label4);
            this.gbxProjectGeneralnformation.Controls.Add(this.txtCustomerName);
            this.gbxProjectGeneralnformation.Controls.Add(this.lblScopeMM);
            this.gbxProjectGeneralnformation.Controls.Add(this.txtScopeMM);
            this.gbxProjectGeneralnformation.Controls.Add(this.label2);
            this.gbxProjectGeneralnformation.Controls.Add(this.txtProjectName);
            this.gbxProjectGeneralnformation.Controls.Add(this.label1);
            this.gbxProjectGeneralnformation.Controls.Add(this.txtProjectCode);
            this.gbxProjectGeneralnformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxProjectGeneralnformation.Location = new System.Drawing.Point(0, 0);
            this.gbxProjectGeneralnformation.Margin = new System.Windows.Forms.Padding(2);
            this.gbxProjectGeneralnformation.Name = "gbxProjectGeneralnformation";
            this.gbxProjectGeneralnformation.Padding = new System.Windows.Forms.Padding(2);
            this.gbxProjectGeneralnformation.Size = new System.Drawing.Size(1185, 146);
            this.gbxProjectGeneralnformation.TabIndex = 3;
            this.gbxProjectGeneralnformation.TabStop = false;
            this.gbxProjectGeneralnformation.Text = "Project general information:";
            // 
            // lblProjectCodeNotification
            // 
            this.lblProjectCodeNotification.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblProjectCodeNotification.AutoSize = true;
            this.lblProjectCodeNotification.ForeColor = System.Drawing.Color.Red;
            this.lblProjectCodeNotification.Location = new System.Drawing.Point(168, 34);
            this.lblProjectCodeNotification.Name = "lblProjectCodeNotification";
            this.lblProjectCodeNotification.Size = new System.Drawing.Size(70, 13);
            this.lblProjectCodeNotification.TabIndex = 39;
            this.lblProjectCodeNotification.Text = "*Please Input";
            this.lblProjectCodeNotification.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(589, 96);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(152, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirmProject
            // 
            this.btnConfirmProject.Location = new System.Drawing.Point(378, 96);
            this.btnConfirmProject.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmProject.Name = "btnConfirmProject";
            this.btnConfirmProject.Size = new System.Drawing.Size(205, 23);
            this.btnConfirmProject.TabIndex = 14;
            this.btnConfirmProject.Text = "CONFIRM";
            this.btnConfirmProject.UseVisualStyleBackColor = true;
            this.btnConfirmProject.Click += new System.EventHandler(this.btnConfirmProject_Click);
            // 
            // cbxProjectStatus
            // 
            this.cbxProjectStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbxProjectStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProjectStatus.FormattingEnabled = true;
            this.cbxProjectStatus.Location = new System.Drawing.Point(810, 58);
            this.cbxProjectStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cbxProjectStatus.Name = "cbxProjectStatus";
            this.cbxProjectStatus.Size = new System.Drawing.Size(145, 21);
            this.cbxProjectStatus.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(730, 60);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Project Status:";
            // 
            // dtmEndDate
            // 
            this.dtmEndDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtmEndDate.Location = new System.Drawing.Point(523, 60);
            this.dtmEndDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtmEndDate.Name = "dtmEndDate";
            this.dtmEndDate.Size = new System.Drawing.Size(185, 20);
            this.dtmEndDate.TabIndex = 11;
            // 
            // dtmStartedDate
            // 
            this.dtmStartedDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtmStartedDate.Location = new System.Drawing.Point(256, 60);
            this.dtmStartedDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtmStartedDate.Name = "dtmStartedDate";
            this.dtmStartedDate.Size = new System.Drawing.Size(185, 20);
            this.dtmStartedDate.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(465, 60);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "End Date:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 61);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Started Date:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(575, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Customer Name:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCustomerName.Location = new System.Drawing.Point(665, 12);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(217, 20);
            this.txtCustomerName.TabIndex = 6;
            // 
            // lblScopeMM
            // 
            this.lblScopeMM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblScopeMM.AutoSize = true;
            this.lblScopeMM.Location = new System.Drawing.Point(893, 14);
            this.lblScopeMM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScopeMM.Name = "lblScopeMM";
            this.lblScopeMM.Size = new System.Drawing.Size(98, 13);
            this.lblScopeMM.TabIndex = 5;
            this.lblScopeMM.Text = "Scope Man-Month:";
            // 
            // txtScopeMM
            // 
            this.txtScopeMM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtScopeMM.Location = new System.Drawing.Point(993, 12);
            this.txtScopeMM.Margin = new System.Windows.Forms.Padding(2);
            this.txtScopeMM.Name = "txtScopeMM";
            this.txtScopeMM.Size = new System.Drawing.Size(100, 20);
            this.txtScopeMM.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Project Name:";
            // 
            // txtProjectName
            // 
            this.txtProjectName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtProjectName.Location = new System.Drawing.Point(344, 12);
            this.txtProjectName.Margin = new System.Windows.Forms.Padding(2);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(217, 20);
            this.txtProjectName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Project Code:";
            // 
            // txtProjectCode
            // 
            this.txtProjectCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtProjectCode.Location = new System.Drawing.Point(158, 12);
            this.txtProjectCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtProjectCode.Name = "txtProjectCode";
            this.txtProjectCode.Size = new System.Drawing.Size(97, 20);
            this.txtProjectCode.TabIndex = 0;
            // 
            // lblProjectNameNotification
            // 
            this.lblProjectNameNotification.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblProjectNameNotification.AutoSize = true;
            this.lblProjectNameNotification.ForeColor = System.Drawing.Color.Red;
            this.lblProjectNameNotification.Location = new System.Drawing.Point(411, 34);
            this.lblProjectNameNotification.Name = "lblProjectNameNotification";
            this.lblProjectNameNotification.Size = new System.Drawing.Size(70, 13);
            this.lblProjectNameNotification.TabIndex = 39;
            this.lblProjectNameNotification.Text = "*Please Input";
            this.lblProjectNameNotification.Visible = false;
            // 
            // lblCustomerNameNotification
            // 
            this.lblCustomerNameNotification.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCustomerNameNotification.AutoSize = true;
            this.lblCustomerNameNotification.ForeColor = System.Drawing.Color.Red;
            this.lblCustomerNameNotification.Location = new System.Drawing.Point(730, 34);
            this.lblCustomerNameNotification.Name = "lblCustomerNameNotification";
            this.lblCustomerNameNotification.Size = new System.Drawing.Size(70, 13);
            this.lblCustomerNameNotification.TabIndex = 39;
            this.lblCustomerNameNotification.Text = "*Please Input";
            this.lblCustomerNameNotification.Visible = false;
            // 
            // lblScopeMMNotification
            // 
            this.lblScopeMMNotification.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblScopeMMNotification.AutoSize = true;
            this.lblScopeMMNotification.ForeColor = System.Drawing.Color.Red;
            this.lblScopeMMNotification.Location = new System.Drawing.Point(1007, 34);
            this.lblScopeMMNotification.Name = "lblScopeMMNotification";
            this.lblScopeMMNotification.Size = new System.Drawing.Size(70, 13);
            this.lblScopeMMNotification.TabIndex = 39;
            this.lblScopeMMNotification.Text = "*Please Input";
            this.lblScopeMMNotification.Visible = false;
            // 
            // DetailedProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 515);
            this.Controls.Add(this.gbxProjectTaskManagement);
            this.Controls.Add(this.gbxProjectMemberManagement);
            this.Controls.Add(this.gbxProjectGeneralnformation);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DetailedProjectForm";
            this.Text = "Detailed Project Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DetailedProjectForm_Load);
            this.gbxProjectTaskManagement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTask)).EndInit();
            this.gbxProjectMemberManagement.ResumeLayout(false);
            this.gbxProjectMemberManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcProjectMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvProjectMember)).EndInit();
            this.gbxProjectGeneralnformation.ResumeLayout(false);
            this.gbxProjectGeneralnformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxProjectTaskManagement;
        private System.Windows.Forms.GroupBox gbxProjectMemberManagement;
        private System.Windows.Forms.GroupBox gbxProjectGeneralnformation;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.Button btnDUTask;
        private System.Windows.Forms.Button btnAddTask;
        private DevExpress.XtraGrid.GridControl grcTask;
        private DevExpress.XtraGrid.Views.Grid.GridView grvTask;
        private DevExpress.XtraGrid.Columns.GridColumn grcolID;
        private DevExpress.XtraGrid.Columns.GridColumn grcolTaskCode;
        private DevExpress.XtraGrid.Columns.GridColumn grcolStatus;
        private DevExpress.XtraGrid.Columns.GridColumn grcolTaskName;
        private DevExpress.XtraGrid.Columns.GridColumn grcolAssigneeName;
        private DevExpress.XtraGrid.Columns.GridColumn grcolReporterName;
        private DevExpress.XtraGrid.Columns.GridColumn grcolPriority;
        private DevExpress.XtraGrid.Columns.GridColumn grcolTaskType;
        private DevExpress.XtraGrid.Columns.GridColumn grcolDescription;
        private System.Windows.Forms.Button btnConfirmProject;
        private System.Windows.Forms.ComboBox cbxProjectStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtmEndDate;
        private System.Windows.Forms.DateTimePicker dtmStartedDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblScopeMM;
        private System.Windows.Forms.TextBox txtScopeMM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProjectCode;
        private System.Windows.Forms.ComboBox cbxRole;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtmPMEndDate;
        private System.Windows.Forms.DateTimePicker dtmPMStartedDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxProjectMember;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnChangeActiveProjectMember;
        private System.Windows.Forms.Button btnUpdateProjectMemberInformation;
        private System.Windows.Forms.Button btnAddNewProjectMember;
        private DevExpress.XtraGrid.GridControl grcProjectMember;
        private DevExpress.XtraGrid.Views.Grid.GridView grvProjectMember;
        private DevExpress.XtraGrid.Columns.GridColumn grColPEID;
        private System.Windows.Forms.Button btnCancel;
        private DevExpress.XtraGrid.Columns.GridColumn grColPEProjectID;
        private DevExpress.XtraGrid.Columns.GridColumn grColPEEmployeeID;
        private DevExpress.XtraGrid.Columns.GridColumn grColPEStartedDate;
        private DevExpress.XtraGrid.Columns.GridColumn grColPEEndDate;
        private DevExpress.XtraGrid.Columns.GridColumn grColPERole;
        private DevExpress.XtraGrid.Columns.GridColumn grColPEActive;
        private DevExpress.XtraGrid.Columns.GridColumn grColPEEmployeeName;
        private System.Windows.Forms.Button btnPECancel;
        private System.Windows.Forms.Label lblProjectCodeNotification;
        private System.Windows.Forms.Label lblScopeMMNotification;
        private System.Windows.Forms.Label lblCustomerNameNotification;
        private System.Windows.Forms.Label lblProjectNameNotification;
    }
}