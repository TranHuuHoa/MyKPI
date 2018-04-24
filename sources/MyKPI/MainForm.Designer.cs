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
            this.button2 = new System.Windows.Forms.Button();
            this.btnEmployeeManagement = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProjectManagement
            // 
            this.btnProjectManagement.Location = new System.Drawing.Point(39, 21);
            this.btnProjectManagement.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProjectManagement.Name = "btnProjectManagement";
            this.btnProjectManagement.Size = new System.Drawing.Size(331, 45);
            this.btnProjectManagement.TabIndex = 0;
            this.btnProjectManagement.Text = "PROJECT MANAGEMENT";
            this.btnProjectManagement.UseVisualStyleBackColor = true;
            this.btnProjectManagement.Click += new System.EventHandler(this.btnProjectManagement_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(39, 81);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(331, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "JOB KPI ASSESSMENT";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnEmployeeManagement
            // 
            this.btnEmployeeManagement.Location = new System.Drawing.Point(39, 138);
            this.btnEmployeeManagement.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEmployeeManagement.Name = "btnEmployeeManagement";
            this.btnEmployeeManagement.Size = new System.Drawing.Size(331, 45);
            this.btnEmployeeManagement.TabIndex = 2;
            this.btnEmployeeManagement.Text = "EMPLOYEE MANAGEMENT";
            this.btnEmployeeManagement.UseVisualStyleBackColor = true;
            this.btnEmployeeManagement.Click += new System.EventHandler(this.btnEmployeeManagement_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(39, 331);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(331, 45);
            this.button4.TabIndex = 3;
            this.button4.Text = "EXIT";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 396);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnEmployeeManagement);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnProjectManagement);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnEmployeeManagement;
        private System.Windows.Forms.Button button4;
    }
}

