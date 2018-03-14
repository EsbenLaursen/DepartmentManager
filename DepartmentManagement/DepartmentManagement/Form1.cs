using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DepartmentManagement.Entities;

namespace DepartmentManagement
{
    public partial class Form1 : Form
    {
        Database db = new Database();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            var departments = db.ReadAllDepartments();
            int i = 0;
            foreach (var department in departments)
            {
                i++;
                string departmentString = string.Format(
                    "Department name: {0}, number: {1}, managerSSN: {2}, start date: {3}", department.DName,
                    department.DNumber, department
                        .MgrSSN, department.MgrStartDate);
                ListViewItem item = new ListViewItem(departmentString, i)
                {
                    Tag = department.DNumber
                };
                listBox1.Items.Add(item.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var department = addDepartmentTxt.Text;
                var mgr = Convert.ToDecimal(managerSSNTxt.Text);
                db.CreateTask(department, mgr);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid fields");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (listBox1.SelectedItem is ListViewItem selected)
            {
                id = Convert.ToInt32(selected.Tag);
            }
            db.DeleteDepartment(id);
        }

        private void getDepartmentBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int id = Convert.ToInt32(departmentTxt.Text);
            var department = db.ReadDepartment(id);
            if (department != null)
            {
                string departmentString = string.Format(
                    "Department name: {0}, number: {1}, managerSSN: {2}, start date: {3}", department.DName,
                    department.DNumber, department
                        .MgrSSN, department.MgrStartDate);
                ListViewItem item = new ListViewItem(departmentString, 1);
                item.Tag = department.DNumber;
                listBox1.Items.Add(item.Text);
            }
            else
            {
                MessageBox.Show("No department found");
            }
        }

        private void updateDepBtn_Click(object sender, EventArgs e)
        {
            int deptnum = Convert.ToInt32(UpdateDeptNum.Text);
            decimal ssn = Convert.ToDecimal(UpdateDeptmanagerSSN.Text);
            db.UpdateManagerForDepartment(deptnum, ssn);
        }

        private void button4_Click(object sender, EventArgs e)
        {
             int deptnum = Convert.ToInt32(updateDeptNameNumTxt.Text);
              string deptName = updateDeptName.Text;

            db.UpdateDepartmentName(deptnum, deptName);

        }
    }
}
