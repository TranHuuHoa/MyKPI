namespace MyKPI.EmployeeManagment.GUI
{
    partial class DetailedEmployeeForm
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
            this.cbxSex = new System.Windows.Forms.ComboBox();
            this.cbxJobRankType = new System.Windows.Forms.ComboBox();
            this.txtEmployeeLastName = new System.Windows.Forms.TextBox();
            this.txtEmployeeFirstName = new System.Windows.Forms.TextBox();
            this.txtEmployeeNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSalarySubLevel = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtIdCard = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.cbxJobRankLevel = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxSalaryLevel = new System.Windows.Forms.ComboBox();
            this.lblEmployeeNumberNotification = new System.Windows.Forms.Label();
            this.lblEmployeeFirstNameNotification = new System.Windows.Forms.Label();
            this.lblEmployeeLastNameNotification = new System.Windows.Forms.Label();
            this.lblAddressNotification = new System.Windows.Forms.Label();
            this.lblIDCardNotification = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxSex
            // 
            this.cbxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSex.FormattingEnabled = true;
            this.cbxSex.Location = new System.Drawing.Point(116, 182);
            this.cbxSex.Name = "cbxSex";
            this.cbxSex.Size = new System.Drawing.Size(240, 21);
            this.cbxSex.TabIndex = 24;
            // 
            // cbxJobRankType
            // 
            this.cbxJobRankType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxJobRankType.FormattingEnabled = true;
            this.cbxJobRankType.Location = new System.Drawing.Point(116, 209);
            this.cbxJobRankType.Name = "cbxJobRankType";
            this.cbxJobRankType.Size = new System.Drawing.Size(240, 21);
            this.cbxJobRankType.TabIndex = 25;
            // 
            // txtEmployeeLastName
            // 
            this.txtEmployeeLastName.Location = new System.Drawing.Point(116, 58);
            this.txtEmployeeLastName.Name = "txtEmployeeLastName";
            this.txtEmployeeLastName.Size = new System.Drawing.Size(240, 20);
            this.txtEmployeeLastName.TabIndex = 20;
            // 
            // txtEmployeeFirstName
            // 
            this.txtEmployeeFirstName.Location = new System.Drawing.Point(116, 34);
            this.txtEmployeeFirstName.Name = "txtEmployeeFirstName";
            this.txtEmployeeFirstName.Size = new System.Drawing.Size(240, 20);
            this.txtEmployeeFirstName.TabIndex = 13;
            // 
            // txtEmployeeNumber
            // 
            this.txtEmployeeNumber.Location = new System.Drawing.Point(116, 11);
            this.txtEmployeeNumber.Name = "txtEmployeeNumber";
            this.txtEmployeeNumber.Size = new System.Drawing.Size(240, 20);
            this.txtEmployeeNumber.TabIndex = 10;
            this.txtEmployeeNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmployeeNumber_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(82, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Sex:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Job Rank Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Date Of Birth:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "ID Card:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Employee Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Employee First Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Employee Number:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(240, 328);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 26);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(12, 328);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(201, 26);
            this.btnConfirm.TabIndex = 26;
            this.btnConfirm.Text = "CONFIRM";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Salary Sub Level:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Salary Level:";
            // 
            // txtSalarySubLevel
            // 
            this.txtSalarySubLevel.Location = new System.Drawing.Point(116, 289);
            this.txtSalarySubLevel.Name = "txtSalarySubLevel";
            this.txtSalarySubLevel.Size = new System.Drawing.Size(240, 20);
            this.txtSalarySubLevel.TabIndex = 31;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(116, 84);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(240, 39);
            this.txtAddress.TabIndex = 32;
            // 
            // txtIdCard
            // 
            this.txtIdCard.Location = new System.Drawing.Point(116, 129);
            this.txtIdCard.Name = "txtIdCard";
            this.txtIdCard.Size = new System.Drawing.Size(240, 20);
            this.txtIdCard.TabIndex = 33;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(117, 156);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(239, 20);
            this.dtpDOB.TabIndex = 34;
            // 
            // cbxJobRankLevel
            // 
            this.cbxJobRankLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxJobRankLevel.FormattingEnabled = true;
            this.cbxJobRankLevel.Location = new System.Drawing.Point(116, 236);
            this.cbxJobRankLevel.Name = "cbxJobRankLevel";
            this.cbxJobRankLevel.Size = new System.Drawing.Size(240, 21);
            this.cbxJobRankLevel.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 239);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Job Rank Level:";
            // 
            // cbxSalaryLevel
            // 
            this.cbxSalaryLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSalaryLevel.FormattingEnabled = true;
            this.cbxSalaryLevel.Location = new System.Drawing.Point(116, 266);
            this.cbxSalaryLevel.Name = "cbxSalaryLevel";
            this.cbxSalaryLevel.Size = new System.Drawing.Size(240, 21);
            this.cbxSalaryLevel.TabIndex = 37;
            // 
            // lblEmployeeNumberNotification
            // 
            this.lblEmployeeNumberNotification.AutoSize = true;
            this.lblEmployeeNumberNotification.ForeColor = System.Drawing.Color.Red;
            this.lblEmployeeNumberNotification.Location = new System.Drawing.Point(362, 14);
            this.lblEmployeeNumberNotification.Name = "lblEmployeeNumberNotification";
            this.lblEmployeeNumberNotification.Size = new System.Drawing.Size(70, 13);
            this.lblEmployeeNumberNotification.TabIndex = 38;
            this.lblEmployeeNumberNotification.Text = "*Please Input";
            this.lblEmployeeNumberNotification.Visible = false;
            // 
            // lblEmployeeFirstNameNotification
            // 
            this.lblEmployeeFirstNameNotification.AutoSize = true;
            this.lblEmployeeFirstNameNotification.ForeColor = System.Drawing.Color.Red;
            this.lblEmployeeFirstNameNotification.Location = new System.Drawing.Point(362, 37);
            this.lblEmployeeFirstNameNotification.Name = "lblEmployeeFirstNameNotification";
            this.lblEmployeeFirstNameNotification.Size = new System.Drawing.Size(70, 13);
            this.lblEmployeeFirstNameNotification.TabIndex = 39;
            this.lblEmployeeFirstNameNotification.Text = "*Please Input";
            this.lblEmployeeFirstNameNotification.Visible = false;
            // 
            // lblEmployeeLastNameNotification
            // 
            this.lblEmployeeLastNameNotification.AutoSize = true;
            this.lblEmployeeLastNameNotification.ForeColor = System.Drawing.Color.Red;
            this.lblEmployeeLastNameNotification.Location = new System.Drawing.Point(362, 61);
            this.lblEmployeeLastNameNotification.Name = "lblEmployeeLastNameNotification";
            this.lblEmployeeLastNameNotification.Size = new System.Drawing.Size(70, 13);
            this.lblEmployeeLastNameNotification.TabIndex = 40;
            this.lblEmployeeLastNameNotification.Text = "*Please Input";
            this.lblEmployeeLastNameNotification.Visible = false;
            // 
            // lblAddressNotification
            // 
            this.lblAddressNotification.AutoSize = true;
            this.lblAddressNotification.ForeColor = System.Drawing.Color.Red;
            this.lblAddressNotification.Location = new System.Drawing.Point(362, 87);
            this.lblAddressNotification.Name = "lblAddressNotification";
            this.lblAddressNotification.Size = new System.Drawing.Size(70, 13);
            this.lblAddressNotification.TabIndex = 41;
            this.lblAddressNotification.Text = "*Please Input";
            this.lblAddressNotification.Visible = false;
            // 
            // lblIDCardNotification
            // 
            this.lblIDCardNotification.AutoSize = true;
            this.lblIDCardNotification.ForeColor = System.Drawing.Color.Red;
            this.lblIDCardNotification.Location = new System.Drawing.Point(362, 132);
            this.lblIDCardNotification.Name = "lblIDCardNotification";
            this.lblIDCardNotification.Size = new System.Drawing.Size(70, 13);
            this.lblIDCardNotification.TabIndex = 42;
            this.lblIDCardNotification.Text = "*Please Input";
            this.lblIDCardNotification.Visible = false;
            // 
            // DetailedEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 395);
            this.Controls.Add(this.lblIDCardNotification);
            this.Controls.Add(this.lblAddressNotification);
            this.Controls.Add(this.lblEmployeeLastNameNotification);
            this.Controls.Add(this.lblEmployeeFirstNameNotification);
            this.Controls.Add(this.lblEmployeeNumberNotification);
            this.Controls.Add(this.cbxSalaryLevel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbxJobRankLevel);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.txtIdCard);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtSalarySubLevel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbxSex);
            this.Controls.Add(this.cbxJobRankType);
            this.Controls.Add(this.txtEmployeeLastName);
            this.Controls.Add(this.txtEmployeeFirstName);
            this.Controls.Add(this.txtEmployeeNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Name = "DetailedEmployeeForm";
            this.Text = "DetailedEmployeeForm";
            this.Load += new System.EventHandler(this.DetailedEmployeeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxSex;
        private System.Windows.Forms.ComboBox cbxJobRankType;
        private System.Windows.Forms.TextBox txtEmployeeLastName;
        private System.Windows.Forms.TextBox txtEmployeeFirstName;
        private System.Windows.Forms.TextBox txtEmployeeNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSalarySubLevel;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtIdCard;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.ComboBox cbxJobRankLevel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbxSalaryLevel;
        private System.Windows.Forms.Label lblEmployeeNumberNotification;
        private System.Windows.Forms.Label lblEmployeeFirstNameNotification;
        private System.Windows.Forms.Label lblEmployeeLastNameNotification;
        private System.Windows.Forms.Label lblAddressNotification;
        private System.Windows.Forms.Label lblIDCardNotification;
    }
}