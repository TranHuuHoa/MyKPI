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
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnProjectCancel = new System.Windows.Forms.Button();
            this.btnConfirmProject = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTask)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.groupBox3.Size = new System.Drawing.Size(1728, 325);
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
            this.grcTask.Location = new System.Drawing.Point(0, 27);
            this.grcTask.MainView = this.grvTask;
            this.grcTask.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grcTask.Name = "grcTask";
            this.grcTask.Size = new System.Drawing.Size(1728, 243);
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
            this.btnExit.Location = new System.Drawing.Point(1127, 278);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(217, 34);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeleteTask.Location = new System.Drawing.Point(883, 278);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(217, 34);
            this.btnDeleteTask.TabIndex = 3;
            this.btnDeleteTask.Text = "DELETE TASK";
            this.btnDeleteTask.UseVisualStyleBackColor = true;
            // 
            // btnDUTask
            // 
            this.btnDUTask.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDUTask.Location = new System.Drawing.Point(633, 279);
            this.btnDUTask.Name = "btnDUTask";
            this.btnDUTask.Size = new System.Drawing.Size(217, 34);
            this.btnDUTask.TabIndex = 2;
            this.btnDUTask.Text = "DETAILED/UPDATE TASK";
            this.btnDUTask.UseVisualStyleBackColor = true;
            // 
            // btnAddTask
            // 
            this.btnAddTask.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddTask.Location = new System.Drawing.Point(376, 279);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(217, 34);
            this.btnAddTask.TabIndex = 1;
            this.btnAddTask.Text = "ADD NEW TASK";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.dateTimePicker3);
            this.groupBox2.Controls.Add(this.dateTimePicker4);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.gridControl1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1728, 223);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Project member management";
            // 
            // comboBox3
            // 
            this.comboBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(135, 155);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(342, 28);
            this.comboBox3.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(83, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "Role:";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker3.Location = new System.Drawing.Point(135, 123);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(342, 26);
            this.dateTimePicker3.TabIndex = 15;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker4.Location = new System.Drawing.Point(135, 91);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(342, 26);
            this.dateTimePicker4.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "End Date:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Started Date:";
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(135, 57);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(342, 28);
            this.comboBox2.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Member Name:";
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(518, 140);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(217, 34);
            this.button5.TabIndex = 4;
            this.button5.Text = "ACTIVE/DEACTIVE";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(518, 100);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(217, 34);
            this.button4.TabIndex = 3;
            this.button4.Text = "EDIT INFORMATION";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(518, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(217, 34);
            this.button3.TabIndex = 2;
            this.button3.Text = "ADD NEW MEMBER";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.gridControl1.Location = new System.Drawing.Point(781, 22);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(944, 198);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnProjectCancel);
            this.groupBox1.Controls.Add(this.btnConfirmProject);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1728, 180);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Project general information:";
            // 
            // btnProjectCancel
            // 
            this.btnProjectCancel.Location = new System.Drawing.Point(898, 120);
            this.btnProjectCancel.Name = "btnProjectCancel";
            this.btnProjectCancel.Size = new System.Drawing.Size(190, 36);
            this.btnProjectCancel.TabIndex = 15;
            this.btnProjectCancel.Text = "CANCEL";
            this.btnProjectCancel.UseVisualStyleBackColor = true;
            // 
            // btnConfirmProject
            // 
            this.btnConfirmProject.Location = new System.Drawing.Point(570, 120);
            this.btnConfirmProject.Name = "btnConfirmProject";
            this.btnConfirmProject.Size = new System.Drawing.Size(307, 36);
            this.btnConfirmProject.TabIndex = 14;
            this.btnConfirmProject.Text = "CONFIRM";
            this.btnConfirmProject.UseVisualStyleBackColor = true;
            this.btnConfirmProject.Click += new System.EventHandler(this.btnConfirmProject_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1194, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(216, 28);
            this.comboBox1.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1074, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Project Status:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker2.Location = new System.Drawing.Point(763, 64);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(275, 26);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker1.Location = new System.Drawing.Point(363, 64);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(275, 26);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(676, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "End Date:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Started Date:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(839, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Customer Name:";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox4.Location = new System.Drawing.Point(973, 19);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(324, 26);
            this.textBox4.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1315, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Scope Man-Month:";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox3.Location = new System.Drawing.Point(1465, 19);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(148, 26);
            this.textBox3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Project Name:";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox2.Location = new System.Drawing.Point(492, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(324, 26);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Project Code:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Location = new System.Drawing.Point(213, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 26);
            this.textBox1.TabIndex = 0;
            // 
            // DetailedProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1728, 728);
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
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}