namespace MyKPI.JobKpiAssessment.GUI
{
    partial class JobKpiAssessmentManagementForm
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
            this.grcJobKpiAssessment = new DevExpress.XtraGrid.GridControl();
            this.grvJobKpiAssessment = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDeleteJobKpiAssessment = new System.Windows.Forms.Button();
            this.btnDUJobKpiAssessment = new System.Windows.Forms.Button();
            this.btnAddJobKpiAssessment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grcJobKpiAssessment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvJobKpiAssessment)).BeginInit();
            this.SuspendLayout();
            // 
            // grcJobKpiAssessment
            // 
            this.grcJobKpiAssessment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grcJobKpiAssessment.Location = new System.Drawing.Point(1, -1);
            this.grcJobKpiAssessment.MainView = this.grvJobKpiAssessment;
            this.grcJobKpiAssessment.Name = "grcJobKpiAssessment";
            this.grcJobKpiAssessment.Size = new System.Drawing.Size(1743, 642);
            this.grcJobKpiAssessment.TabIndex = 0;
            this.grcJobKpiAssessment.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvJobKpiAssessment});
            // 
            // grvJobKpiAssessment
            // 
            this.grvJobKpiAssessment.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.grvJobKpiAssessment.GridControl = this.grcJobKpiAssessment;
            this.grvJobKpiAssessment.Name = "grvJobKpiAssessment";
            this.grvJobKpiAssessment.OptionsBehavior.Editable = false;
            this.grvJobKpiAssessment.OptionsView.ShowDetailButtons = false;
            this.grvJobKpiAssessment.OptionsView.ShowGroupPanel = false;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExit.Location = new System.Drawing.Point(1146, 659);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(259, 42);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDeleteJobKpiAssessment
            // 
            this.btnDeleteJobKpiAssessment.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeleteJobKpiAssessment.Location = new System.Drawing.Point(866, 659);
            this.btnDeleteJobKpiAssessment.Name = "btnDeleteJobKpiAssessment";
            this.btnDeleteJobKpiAssessment.Size = new System.Drawing.Size(259, 42);
            this.btnDeleteJobKpiAssessment.TabIndex = 7;
            this.btnDeleteJobKpiAssessment.Text = "DELETE";
            this.btnDeleteJobKpiAssessment.UseVisualStyleBackColor = true;
            // 
            // btnDUJobKpiAssessment
            // 
            this.btnDUJobKpiAssessment.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDUJobKpiAssessment.Location = new System.Drawing.Point(586, 659);
            this.btnDUJobKpiAssessment.Name = "btnDUJobKpiAssessment";
            this.btnDUJobKpiAssessment.Size = new System.Drawing.Size(259, 42);
            this.btnDUJobKpiAssessment.TabIndex = 6;
            this.btnDUJobKpiAssessment.Text = "DETAIL / UPDATE";
            this.btnDUJobKpiAssessment.UseVisualStyleBackColor = true;
            // 
            // btnAddJobKpiAssessment
            // 
            this.btnAddJobKpiAssessment.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddJobKpiAssessment.Location = new System.Drawing.Point(303, 659);
            this.btnAddJobKpiAssessment.Name = "btnAddJobKpiAssessment";
            this.btnAddJobKpiAssessment.Size = new System.Drawing.Size(259, 42);
            this.btnAddJobKpiAssessment.TabIndex = 5;
            this.btnAddJobKpiAssessment.Text = "ADD";
            this.btnAddJobKpiAssessment.UseVisualStyleBackColor = true;
            this.btnAddJobKpiAssessment.Click += new System.EventHandler(this.btnAddJobKpiAssessment_Click);
            // 
            // JobKpiAssessmentManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1744, 713);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDeleteJobKpiAssessment);
            this.Controls.Add(this.btnDUJobKpiAssessment);
            this.Controls.Add(this.btnAddJobKpiAssessment);
            this.Controls.Add(this.grcJobKpiAssessment);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "JobKpiAssessmentManagementForm";
            this.Text = "Job KPI Assessment Management Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.grcJobKpiAssessment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvJobKpiAssessment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grcJobKpiAssessment;
        private DevExpress.XtraGrid.Views.Grid.GridView grvJobKpiAssessment;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDeleteJobKpiAssessment;
        private System.Windows.Forms.Button btnDUJobKpiAssessment;
        private System.Windows.Forms.Button btnAddJobKpiAssessment;
    }
}