using EFSample.Models;
using EFSample.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFSample.Forms
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Name= txtName.Text;
            employee.Surname = txtSurname.Text;
            employee.BirthDate = dateTimeBirthDate.Value;

           bool result = EmployeeServices.Add(employee);

            if (result)
            {
                MessageBox.Show("Islem basarili");
            }
            else
            {
                MessageBox.Show("HATA!");
            }

        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        void LoadData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = EmployeeServices.GetAll();
        }
    }
}
