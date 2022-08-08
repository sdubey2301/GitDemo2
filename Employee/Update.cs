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
    public partial class Update : Form
    {
        Class1 obj = new Class1();
        public Update()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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
                string EmpID = txtEmpID.Text;
                string Name = txtName.Text;
                string age = txtAge.Text;
                string contactno = txtcontact.Text;

                EEmployee empl = new EEmployee();
                OEmployee empOP = new OEmployee();

                empl.EmpID =Convert.ToInt32(EmpID);
                empl.Name = Name;
                empl.age = Convert.ToInt32(age);
                empl.contactno = contactno;

                int effectedRows = empOP.Update(empl);
                if (effectedRows >= 0)
                {
                    MessageBox.Show("Record Updated");

                }
                txtEmpID.Text = String.Empty;
                txtName.Text = String.Empty;
                txtAge.Text = String.Empty;
                txtcontact.Text = String.Empty;

                btnUpdate.Enabled = false;
               // this.Hide();
               //Update update = new Update();
               //update.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occurred");

            }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Update_Load(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            grid_Update.DataSource = obj.Print("Select * from Emp");
        }

        private void grid_Update_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = int.Parse(grid_Update.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtEmpID.Text = ID.ToString();
            txtName.Text = grid_Update.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtAge.Text = grid_Update.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtcontact.Text = grid_Update.Rows[e.RowIndex].Cells[0].Value.ToString();

            btnUpdate.Enabled = true;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Registration reg = new Registration();
            reg.Show();
        }
    }  
        }
    

