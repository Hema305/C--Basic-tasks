using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmpInfo;
namespace EmployeeInformation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                Employee emp = new Employee();
                emp.employeeName = txtEmployeeName.Text;
                emp.employeeId = txtEmployeeeId.Text;
                emp.employeePhone = txtemployeePhone.Text;
                emp.employeeAddress = txtEmployeeAddresss.Text;


           try
                {
                    emp.empolyeeTweetId = txtTweetId.Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
}
