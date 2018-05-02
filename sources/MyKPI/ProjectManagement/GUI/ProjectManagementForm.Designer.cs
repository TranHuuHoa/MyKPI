namespace MyKPI.ProjectManagement.GUI
{
    partial class ProjectManagementForm
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
            this.grcProject = new DevExpress.XtraGrid.GridControl();
            this.grvProject = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grColID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grColProjectCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grColProjectName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grColStartedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grColEndDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grColScopeMM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grColCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grColStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAddProject = new System.Windows.Forms.Button();
            this.btnDUProject = new System.Windows.Forms.Button();
            this.btnDeleteProject = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grcProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvProject)).BeginInit();
            this.SuspendLayout();
            // 
            // grcProject
            // 
            this.grcProject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grcProject.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.grcProject.Location = new System.Drawing.Point(0, 1);
            this.grcProject.MainView = this.grvProject;
            this.grcProject.Margin = new System.Windows.Forms.Padding(2);
            this.grcProject.Name = "grcProject";
            this.grcProject.Size = new System.Drawing.Size(1185, 451);
            this.grcProject.TabIndex = 0;
            this.grcProject.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvProject});
            // 
            // grvProject
            // 
            this.grvProject.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grColID,
            this.grColProjectCode,
            this.grColProjectName,
            this.grColStartedDate,
            this.grColEndDate,
            this.grColScopeMM,
            this.grColCustomerName,
            this.grColStatus});
            this.grvProject.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.grvProject.GridControl = this.grcProject;
            this.grvProject.Name = "grvProject";
            this.grvProject.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.grvProject.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.grvProject.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
            this.grvProject.OptionsBehavior.Editable = false;
            this.grvProject.OptionsSelection.MultiSelect = true;
            this.grvProject.OptionsView.ShowGroupPanel = false;
            this.grvProject.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.grvProject_CustomColumnDisplayText);
            // 
            // grColID
            // 
            this.grColID.Caption = "ID";
            this.grColID.FieldName = "ID";
            this.grColID.Name = "grColID";
            // 
            // grColProjectCode
            // 
            this.grColProjectCode.Caption = "Project Code";
            this.grColProjectCode.FieldName = "ProjectCode";
            this.grColProjectCode.Name = "grColProjectCode";
            this.grColProjectCode.Visible = true;
            this.grColProjectCode.VisibleIndex = 0;
            // 
            // grColProjectName
            // 
            this.grColProjectName.Caption = "Project Name";
            this.grColProjectName.FieldName = "ProjectName";
            this.grColProjectName.Name = "grColProjectName";
            this.grColProjectName.Visible = true;
            this.grColProjectName.VisibleIndex = 1;
            // 
            // grColStartedDate
            // 
            this.grColStartedDate.Caption = "Started Date";
            this.grColStartedDate.FieldName = "StartedDate";
            this.grColStartedDate.Name = "grColStartedDate";
            this.grColStartedDate.Visible = true;
            this.grColStartedDate.VisibleIndex = 2;
            // 
            // grColEndDate
            // 
            this.grColEndDate.Caption = "End Date";
            this.grColEndDate.FieldName = "EndDate";
            this.grColEndDate.Name = "grColEndDate";
            this.grColEndDate.Visible = true;
            this.grColEndDate.VisibleIndex = 3;
            // 
            // grColScopeMM
            // 
            this.grColScopeMM.Caption = "Scope Man-Month";
            this.grColScopeMM.FieldName = "ScopeMM";
            this.grColScopeMM.Name = "grColScopeMM";
            this.grColScopeMM.Visible = true;
            this.grColScopeMM.VisibleIndex = 4;
            // 
            // grColCustomerName
            // 
            this.grColCustomerName.Caption = "Customer Name";
            this.grColCustomerName.FieldName = "CustomerName";
            this.grColCustomerName.Name = "grColCustomerName";
            this.grColCustomerName.Visible = true;
            this.grColCustomerName.VisibleIndex = 5;
            // 
            // grColStatus
            // 
            this.grColStatus.Caption = "Status";
            this.grColStatus.FieldName = "Status";
            this.grColStatus.Name = "grColStatus";
            this.grColStatus.Visible = true;
            this.grColStatus.VisibleIndex = 6;
            // 
            // btnAddProject
            // 
            this.btnAddProject.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddProject.Location = new System.Drawing.Point(278, 465);
            this.btnAddProject.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(173, 27);
            this.btnAddProject.TabIndex = 1;
            this.btnAddProject.Text = "ADD";
            this.btnAddProject.UseVisualStyleBackColor = true;
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // btnDUProject
            // 
            this.btnDUProject.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDUProject.Location = new System.Drawing.Point(466, 465);
            this.btnDUProject.Margin = new System.Windows.Forms.Padding(2);
            this.btnDUProject.Name = "btnDUProject";
            this.btnDUProject.Size = new System.Drawing.Size(173, 27);
            this.btnDUProject.TabIndex = 2;
            this.btnDUProject.Text = "DETAIL / UPDATE";
            this.btnDUProject.UseVisualStyleBackColor = true;
            this.btnDUProject.Click += new System.EventHandler(this.btnDUProject_Click);
            // 
            // btnDeleteProject
            // 
            this.btnDeleteProject.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeleteProject.Enabled = false;
            this.btnDeleteProject.Location = new System.Drawing.Point(653, 465);
            this.btnDeleteProject.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteProject.Name = "btnDeleteProject";
            this.btnDeleteProject.Size = new System.Drawing.Size(173, 27);
            this.btnDeleteProject.TabIndex = 3;
            this.btnDeleteProject.Text = "DELETE";
            this.btnDeleteProject.UseVisualStyleBackColor = true;
            this.btnDeleteProject.Click += new System.EventHandler(this.btnDeleteProject_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExit.Location = new System.Drawing.Point(840, 465);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(173, 27);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ProjectManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 500);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDeleteProject);
            this.Controls.Add(this.btnDUProject);
            this.Controls.Add(this.btnAddProject);
            this.Controls.Add(this.grcProject);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProjectManagementForm";
            this.Text = "ProjectManagementForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ProjectManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grcProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvProject)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grcProject;
        private DevExpress.XtraGrid.Views.Grid.GridView grvProject;
        private System.Windows.Forms.Button btnAddProject;
        private System.Windows.Forms.Button btnDUProject;
        private System.Windows.Forms.Button btnDeleteProject;
        private System.Windows.Forms.Button btnExit;
        private DevExpress.XtraGrid.Columns.GridColumn grColID;
        private DevExpress.XtraGrid.Columns.GridColumn grColProjectCode;
        private DevExpress.XtraGrid.Columns.GridColumn grColProjectName;
        private DevExpress.XtraGrid.Columns.GridColumn grColStartedDate;
        private DevExpress.XtraGrid.Columns.GridColumn grColEndDate;
        private DevExpress.XtraGrid.Columns.GridColumn grColScopeMM;
        private DevExpress.XtraGrid.Columns.GridColumn grColCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn grColStatus;
    }
}