namespace MyKPI
{
    partial class MainForm
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
            this.btnProjectManagement = new System.Windows.Forms.Button();
            this.btnJobKpiAssessment = new System.Windows.Forms.Button();
            this.btnEmployeeManagement = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProjectManagement
            // 
            this.btnProjectManagement.Location = new System.Drawing.Point(58, 32);
            this.btnProjectManagement.Name = "btnProjectManagement";
            this.btnProjectManagement.Size = new System.Drawing.Size(496, 69);
            this.btnProjectManagement.TabIndex = 0;
            this.btnProjectManagement.Text = "PROJECT MANAGEMENT";
            this.btnProjectManagement.UseVisualStyleBackColor = true;
            this.btnProjectManagement.Click += new System.EventHandler(this.btnProjectManagement_Click);
            // 
            // btnJobKpiAssessment
            // 
            this.btnJobKpiAssessment.Location = new System.Drawing.Point(58, 125);
            this.btnJobKpiAssessment.Name = "btnJobKpiAssessment";
            this.btnJobKpiAssessment.Size = new System.Drawing.Size(496, 69);
            this.btnJobKpiAssessment.TabIndex = 1;
            this.btnJobKpiAssessment.Text = "JOB KPI ASSESSMENT";
            this.btnJobKpiAssessment.UseVisualStyleBackColor = true;
            this.btnJobKpiAssessment.Click += new System.EventHandler(this.btnJobKpiAssessment_Click);
            // 
            // btnEmployeeManagement
            // 
            this.btnEmployeeManagement.Location = new System.Drawing.Point(58, 212);
            this.btnEmployeeManagement.Name = "btnEmployeeManagement";
            this.btnEmployeeManagement.Size = new System.Drawing.Size(496, 69);
            this.btnEmployeeManagement.TabIndex = 2;
            this.btnEmployeeManagement.Text = "EMPLOYEE MANAGEMENT";
            this.btnEmployeeManagement.UseVisualStyleBackColor = true;
            this.btnEmployeeManagement.Click += new System.EventHandler(this.btnEmployeeManagement_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(58, 509);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(496, 69);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 609);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEmployeeManagement);
            this.Controls.Add(this.btnJobKpiAssessment);
            this.Controls.Add(this.btnProjectManagement);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProjectManagement;
        private System.Windows.Forms.Button btnJobKpiAssessment;
        private System.Windows.Forms.Button btnEmployeeManagement;
        private System.Windows.Forms.Button btnExit;
    }
}

