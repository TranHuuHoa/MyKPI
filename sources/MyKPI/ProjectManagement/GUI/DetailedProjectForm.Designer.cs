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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxRole = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtmPMEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtmPMStartedDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxProjectMember = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnProjectCancel = new System.Windows.Forms.Button();
            this.btnConfirmProject = new System.Windows.Forms.Button();
            this.cbxProjectStatus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtmEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtmStartedDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtScopeMM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProjectCode = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTask)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcProjectMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvProjectMember)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.grcTask);
            this.groupBox3.Controls.Add(this.btnExit);
            this.groupBox3.Controls.Add(this.btnDeleteTask);
            this.groupBox3.Controls.Add(this.btnDUTask);
            this.groupBox3.Controls.Add(this.btnAddTask);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 403);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1734, 443);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Project task managment:";
            // 
            // grcTask
            // 
            this.grcTask.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grcTask.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grcTask.Location = new System.Drawing.Point(0, 28);
            this.grcTask.MainView = this.grvTask;
            this.grcTask.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grcTask.Name = "grcTask";
            this.grcTask.Size = new System.Drawing.Size(1734, 362);
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
            this.btnExit.Location = new System.Drawing.Point(1130, 397);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(218, 34);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeleteTask.Location = new System.Drawing.Point(886, 397);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(218, 34);
            this.btnDeleteTask.TabIndex = 3;
            this.btnDeleteTask.Text = "DELETE TASK";
            this.btnDeleteTask.UseVisualStyleBackColor = true;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // btnDUTask
            // 
            this.btnDUTask.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDUTask.Location = new System.Drawing.Point(636, 397);
            this.btnDUTask.Name = "btnDUTask";
            this.btnDUTask.Size = new System.Drawing.Size(218, 34);
            this.btnDUTask.TabIndex = 2;
            this.btnDUTask.Text = "DETAILED/UPDATE TASK";
            this.btnDUTask.UseVisualStyleBackColor = true;
            this.btnDUTask.Click += new System.EventHandler(this.btnDUTask_Click);
            // 
            // btnAddTask
            // 
            this.btnAddTask.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddTask.Location = new System.Drawing.Point(380, 397);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(218, 34);
            this.btnAddTask.TabIndex = 1;
            this.btnAddTask.Text = "ADD NEW TASK";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxRole);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.dtmPMEndDate);
            this.groupBox2.Controls.Add(this.dtmPMStartedDate);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cbxProjectMember);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.grcProjectMember);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1734, 223);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Project member management";
            // 
            // cbxRole
            // 
            this.cbxRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRole.FormattingEnabled = true;
            this.cbxRole.Location = new System.Drawing.Point(141, 155);
            this.cbxRole.Name = "cbxRole";
            this.cbxRole.Size = new System.Drawing.Size(342, 28);
            this.cbxRole.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(88, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "Role:";
            // 
            // dtmPMEndDate
            // 
            this.dtmPMEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtmPMEndDate.Location = new System.Drawing.Point(141, 123);
            this.dtmPMEndDate.Name = "dtmPMEndDate";
            this.dtmPMEndDate.Size = new System.Drawing.Size(342, 26);
            this.dtmPMEndDate.TabIndex = 15;
            // 
            // dtmPMStartedDate
            // 
            this.dtmPMStartedDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtmPMStartedDate.Location = new System.Drawing.Point(141, 91);
            this.dtmPMStartedDate.Name = "dtmPMStartedDate";
            this.dtmPMStartedDate.Size = new System.Drawing.Size(342, 26);
            this.dtmPMStartedDate.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(54, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "End Date:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Started Date:";
            // 
            // cbxProjectMember
            // 
            this.cbxProjectMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxProjectMember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProjectMember.FormattingEnabled = true;
            this.cbxProjectMember.Location = new System.Drawing.Point(141, 57);
            this.cbxProjectMember.Name = "cbxProjectMember";
            this.cbxProjectMember.Size = new System.Drawing.Size(342, 28);
            this.cbxProjectMember.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Member Name:";
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(524, 140);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(218, 34);
            this.button5.TabIndex = 4;
            this.button5.Text = "ACTIVE/DEACTIVE";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(524, 100);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(218, 34);
            this.button4.TabIndex = 3;
            this.button4.Text = "EDIT INFORMATION";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(524, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(218, 34);
            this.button3.TabIndex = 2;
            this.button3.Text = "ADD NEW MEMBER";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // grcProjectMember
            // 
            this.grcProjectMember.Dock = System.Windows.Forms.DockStyle.Right;
            this.grcProjectMember.Location = new System.Drawing.Point(787, 22);
            this.grcProjectMember.MainView = this.grvProjectMember;
            this.grcProjectMember.Name = "grcProjectMember";
            this.grcProjectMember.Size = new System.Drawing.Size(944, 198);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnProjectCancel);
            this.groupBox1.Controls.Add(this.btnConfirmProject);
            this.groupBox1.Controls.Add(this.cbxProjectStatus);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtmEndDate);
            this.groupBox1.Controls.Add(this.dtmStartedDate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtScopeMM);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtProjectName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtProjectCode);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1734, 180);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Project general information:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(886, 120);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(228, 35);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnProjectCancel
            // 
            this.btnProjectCancel.Location = new System.Drawing.Point(1347, 185);
            this.btnProjectCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProjectCancel.Name = "btnProjectCancel";
            this.btnProjectCancel.Size = new System.Drawing.Size(190, 35);
            this.btnProjectCancel.TabIndex = 15;
            this.btnProjectCancel.Text = "CANCEL";
            this.btnProjectCancel.UseVisualStyleBackColor = true;
            // 
            // btnConfirmProject
            // 
            this.btnConfirmProject.Location = new System.Drawing.Point(570, 120);
            this.btnConfirmProject.Name = "btnConfirmProject";
            this.btnConfirmProject.Size = new System.Drawing.Size(308, 35);
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
            this.cbxProjectStatus.Location = new System.Drawing.Point(1197, 62);
            this.cbxProjectStatus.Name = "cbxProjectStatus";
            this.cbxProjectStatus.Size = new System.Drawing.Size(216, 28);
            this.cbxProjectStatus.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1077, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Project Status:";
            // 
            // dtmEndDate
            // 
            this.dtmEndDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtmEndDate.Location = new System.Drawing.Point(766, 65);
            this.dtmEndDate.Name = "dtmEndDate";
            this.dtmEndDate.Size = new System.Drawing.Size(276, 26);
            this.dtmEndDate.TabIndex = 11;
            // 
            // dtmStartedDate
            // 
            this.dtmStartedDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtmStartedDate.Location = new System.Drawing.Point(366, 65);
            this.dtmStartedDate.Name = "dtmStartedDate";
            this.dtmStartedDate.Size = new System.Drawing.Size(276, 26);
            this.dtmStartedDate.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(680, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "End Date:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Started Date:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(842, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Customer Name:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCustomerName.Location = new System.Drawing.Point(976, 18);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(324, 26);
            this.txtCustomerName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1318, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Scope Man-Month:";
            // 
            // txtScopeMM
            // 
            this.txtScopeMM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtScopeMM.Location = new System.Drawing.Point(1468, 18);
            this.txtScopeMM.Name = "txtScopeMM";
            this.txtScopeMM.Size = new System.Drawing.Size(148, 26);
            this.txtScopeMM.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Project Name:";
            // 
            // txtProjectName
            // 
            this.txtProjectName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtProjectName.Location = new System.Drawing.Point(495, 18);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(324, 26);
            this.txtProjectName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Project Code:";
            // 
            // txtProjectCode
            // 
            this.txtProjectCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtProjectCode.Location = new System.Drawing.Point(216, 18);
            this.txtProjectCode.Name = "txtProjectCode";
            this.txtProjectCode.Size = new System.Drawing.Size(144, 26);
            this.txtProjectCode.TabIndex = 0;
            // 
            // DetailedProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1734, 846);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DetailedProjectForm";
            this.Text = "Detailed Project Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DetailedProjectForm_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTask)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcProjectMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvProjectMember)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.Button btnProjectCancel;
        private System.Windows.Forms.Button btnConfirmProject;
        private System.Windows.Forms.ComboBox cbxProjectStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtmEndDate;
        private System.Windows.Forms.DateTimePicker dtmStartedDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label3;
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
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
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
    }
}