using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using conn;
using conn.Entities;
using conn.Operations;

namespace Employee
{
    public partial class Add : Form
    {
        Class1 obj = new Class1();
        public Add()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(txtName.Text.Trim()))
                {
                    errorProvider1.SetError(txtName, "Name is required");
                    return;
                }
                else
                {
                    errorProvider1.SetError(txtName, string.Empty);
                }

                if (string.IsNullOrEmpty(txtAge.Text.Trim()))
                {
                    errorProvider1.SetError(txtAge, " Age is required");
                    return;
                }
                else
                {
                    errorProvider1.SetError(txtAge, string.Empty);
                }

                if (string.IsNullOrEmpty(txtcontact.Text.Trim()))
                {
                    errorProvider1.SetError(txtcontact, " Contact no is required");
                    return;
                }
                else
                {
                    errorProvider1.SetError(txtcontact, string.Empty);
                }
                //    string EmpID = txtEmpID.Text;
                string Name = txtName.Text;
                string age = txtAge.Text;
                string contactno = txtcontact.Text;

                EEmployee empl = new EEmployee();
                OEmployee empOP = new OEmployee();

                empl.Name = Name;
                empl.age =Convert.ToInt32(age);
                empl.contactno = contactno;

                int effectedRows = empOP.Add(empl);
                if (effectedRows >= 0)
                {
                    MessageBox.Show("Record Inserted");
                    
                }

                this.Hide();
                Add add = new Add();
                add.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occurred");

            }
            ;

        }

        private void Add_Load(object sender, EventArgs e)
        {
            grid_Add.DataSource = obj.Print("Select * from Emp");

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Registration reg = new Registration();
            reg.Show();
        }
    }
    }

