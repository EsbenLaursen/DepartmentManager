namespace DepartmentManagement
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.addDepartmentTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.managerSSNTxt = new System.Windows.Forms.TextBox();
            this.ligemeget = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.getDepartmentBtn = new System.Windows.Forms.Button();
            this.departmentTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UpdateDeptmanagerSSN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UpdateDeptNum = new System.Windows.Forms.TextBox();
            this.updateDepBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.updateDeptName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.updateDeptNameNumTxt = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(24, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(506, 251);
            this.listBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Get all departments";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(177, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Add department";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addDepartmentTxt
            // 
            this.addDepartmentTxt.Location = new System.Drawing.Point(170, 13);
            this.addDepartmentTxt.Name = "addDepartmentTxt";
            this.addDepartmentTxt.Size = new System.Drawing.Size(100, 20);
            this.addDepartmentTxt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.managerSSNTxt);
            this.panel1.Controls.Add(this.ligemeget);
            this.panel1.Controls.Add(this.addDepartmentTxt);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(545, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 103);
            this.panel1.TabIndex = 6;
            // 
            // managerSSNTxt
            // 
            this.managerSSNTxt.Location = new System.Drawing.Point(170, 46);
            this.managerSSNTxt.Name = "managerSSNTxt";
            this.managerSSNTxt.Size = new System.Drawing.Size(100, 20);
            this.managerSSNTxt.TabIndex = 7;
            // 
            // ligemeget
            // 
            this.ligemeget.AutoSize = true;
            this.ligemeget.Location = new System.Drawing.Point(16, 46);
            this.ligemeget.Name = "ligemeget";
            this.ligemeget.Size = new System.Drawing.Size(68, 13);
            this.ligemeget.TabIndex = 6;
            this.ligemeget.Text = "Manager ssn";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(129, 291);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Delete department";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // getDepartmentBtn
            // 
            this.getDepartmentBtn.Location = new System.Drawing.Point(279, 291);
            this.getDepartmentBtn.Name = "getDepartmentBtn";
            this.getDepartmentBtn.Size = new System.Drawing.Size(93, 23);
            this.getDepartmentBtn.TabIndex = 8;
            this.getDepartmentBtn.Text = "Get department";
            this.getDepartmentBtn.UseVisualStyleBackColor = true;
            this.getDepartmentBtn.Click += new System.EventHandler(this.getDepartmentBtn_Click);
            // 
            // departmentTxt
            // 
            this.departmentTxt.Location = new System.Drawing.Point(410, 294);
            this.departmentTxt.Name = "departmentTxt";
            this.departmentTxt.Size = new System.Drawing.Size(100, 20);
            this.departmentTxt.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Id";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Controls.Add(this.UpdateDeptmanagerSSN);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.UpdateDeptNum);
            this.panel2.Controls.Add(this.updateDepBtn);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(545, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 99);
            this.panel2.TabIndex = 8;
            // 
            // UpdateDeptmanagerSSN
            // 
            this.UpdateDeptmanagerSSN.Location = new System.Drawing.Point(170, 46);
            this.UpdateDeptmanagerSSN.Name = "UpdateDeptmanagerSSN";
            this.UpdateDeptmanagerSSN.Size = new System.Drawing.Size(100, 20);
            this.UpdateDeptmanagerSSN.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Manager ssn";
            // 
            // UpdateDeptNum
            // 
            this.UpdateDeptNum.Location = new System.Drawing.Point(170, 13);
            this.UpdateDeptNum.Name = "UpdateDeptNum";
            this.UpdateDeptNum.Size = new System.Drawing.Size(100, 20);
            this.UpdateDeptNum.TabIndex = 4;
            // 
            // updateDepBtn
            // 
            this.updateDepBtn.Location = new System.Drawing.Point(114, 72);
            this.updateDepBtn.Name = "updateDepBtn";
            this.updateDepBtn.Size = new System.Drawing.Size(156, 23);
            this.updateDepBtn.TabIndex = 3;
            this.updateDepBtn.Text = "Update department manager";
            this.updateDepBtn.UseVisualStyleBackColor = true;
            this.updateDepBtn.Click += new System.EventHandler(this.updateDepBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Department number";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel3.Controls.Add(this.updateDeptName);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.updateDeptNameNumTxt);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(545, 226);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(282, 99);
            this.panel3.TabIndex = 9;
            // 
            // updateDeptName
            // 
            this.updateDeptName.Location = new System.Drawing.Point(170, 46);
            this.updateDeptName.Name = "updateDeptName";
            this.updateDeptName.Size = new System.Drawing.Size(100, 20);
            this.updateDeptName.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "New name";
            // 
            // updateDeptNameNumTxt
            // 
            this.updateDeptNameNumTxt.Location = new System.Drawing.Point(170, 13);
            this.updateDeptNameNumTxt.Name = "updateDeptNameNumTxt";
            this.updateDeptNameNumTxt.Size = new System.Drawing.Size(100, 20);
            this.updateDeptNameNumTxt.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(114, 72);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(156, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Update department name";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Department number";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 418);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.departmentTxt);
            this.Controls.Add(this.getDepartmentBtn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Department manager";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox addDepartmentTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox managerSSNTxt;
        private System.Windows.Forms.Label ligemeget;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button getDepartmentBtn;
        private System.Windows.Forms.TextBox departmentTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox UpdateDeptmanagerSSN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UpdateDeptNum;
        private System.Windows.Forms.Button updateDepBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox updateDeptName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox updateDeptNameNumTxt;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
    }
}

