namespace MyKPI.ProjectManagement.GUI
{
    partial class DetailedTaskForm
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTaskCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.cbxAssignee = new System.Windows.Forms.ComboBox();
            this.cbxReporter = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.cbxTaskType = new System.Windows.Forms.ComboBox();
            this.cbxPriority = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(13, 375);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(302, 40);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "CONFIRM";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Task Code:";
            // 
            // txtTaskCode
            // 
            this.txtTaskCode.Location = new System.Drawing.Point(110, 6);
            this.txtTaskCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTaskCode.Name = "txtTaskCode";
            this.txtTaskCode.Size = new System.Drawing.Size(358, 26);
            this.txtTaskCode.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Task Name:";
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(110, 42);
            this.txtTaskName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(358, 26);
            this.txtTaskName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(110, 78);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(358, 99);
            this.txtDescription.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 190);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Assignee:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 228);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Reporter:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 266);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Status:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 342);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Task Type:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(321, 375);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(176, 40);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "CANCEL";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cbxAssignee
            // 
            this.cbxAssignee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAssignee.FormattingEnabled = true;
            this.cbxAssignee.Location = new System.Drawing.Point(110, 187);
            this.cbxAssignee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxAssignee.Name = "cbxAssignee";
            this.cbxAssignee.Size = new System.Drawing.Size(358, 28);
            this.cbxAssignee.TabIndex = 3;
            // 
            // cbxReporter
            // 
            this.cbxReporter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxReporter.FormattingEnabled = true;
            this.cbxReporter.Location = new System.Drawing.Point(110, 225);
            this.cbxReporter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxReporter.Name = "cbxReporter";
            this.cbxReporter.Size = new System.Drawing.Size(358, 28);
            this.cbxReporter.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 304);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Priority:";
            // 
            // cbxStatus
            // 
            this.cbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Location = new System.Drawing.Point(110, 263);
            this.cbxStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(358, 28);
            this.cbxStatus.TabIndex = 5;
            // 
            // cbxTaskType
            // 
            this.cbxTaskType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTaskType.FormattingEnabled = true;
            this.cbxTaskType.Location = new System.Drawing.Point(110, 339);
            this.cbxTaskType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxTaskType.Name = "cbxTaskType";
            this.cbxTaskType.Size = new System.Drawing.Size(358, 28);
            this.cbxTaskType.TabIndex = 7;
            // 
            // cbxPriority
            // 
            this.cbxPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPriority.FormattingEnabled = true;
            this.cbxPriority.Location = new System.Drawing.Point(110, 301);
            this.cbxPriority.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxPriority.Name = "cbxPriority";
            this.cbxPriority.Size = new System.Drawing.Size(358, 28);
            this.cbxPriority.TabIndex = 6;
            // 
            // DetailedTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 428);
            this.Controls.Add(this.cbxPriority);
            this.Controls.Add(this.cbxTaskType);
            this.Controls.Add(this.cbxStatus);
            this.Controls.Add(this.cbxReporter);
            this.Controls.Add(this.cbxAssignee);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTaskName);
            this.Controls.Add(this.txtTaskCode);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConfirm);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DetailedTaskForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detailed Task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTaskCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cbxAssignee;
        private System.Windows.Forms.ComboBox cbxReporter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.ComboBox cbxTaskType;
        private System.Windows.Forms.ComboBox cbxPriority;
    }
}