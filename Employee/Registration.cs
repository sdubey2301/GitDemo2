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
using System.Data.SqlClient;
using System.Configuration;
using conn.Entities;
using conn.Operations;

namespace Employee
{
    public partial class Registration : Form
    {
        Class1 obj = new Class1();
        EEmployee ee = new EEmployee();
        OEmployee oo = new OEmployee();


        public Registration()
        {
            InitializeComponent();
        }
        private void Registration_Load(object sender, EventArgs e)
        {
                  
            string query;
            query = "select *from Emp";
            dataGridView1.DataSource = obj.Print(query);
            btnDelete.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Add add = new Add();
                add.Show();
                //dataGridView1.DataSource = obj.Print(query);
                //this.Hide();
                //Registration reg = new Registration();
                //reg.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            //MessageBox.Show("Data Inserted");

        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Update update = new Update();
                update.Show();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            //MessageBox.Show("Data Updated");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // int ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            // /*txtEmpID*/.Text = ID.ToString();
            // /*txtName*/.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            ///* txtAge.*/Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            ///* txtcontact*/.Text =dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                oo.Delete(ee);

                string query;
                query = "select *from Emp";
                dataGridView1.DataSource = obj.Print(query);
                MessageBox.Show("Record Deleted");
                btnDelete.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            

            string valueToSearch = txtValueToSearch.Text.ToString();
            

            EEmployee empl = new EEmployee();
            OEmployee empOP = new OEmployee();

            empl.Property = cmbproperty.Text;
            empl.EnterValue = txtValueToSearch.Text;


            
            //empl.ValueToSearch = valueToSearch;
            //empOP.Searc);

            dataGridView1.DataSource = empOP.Search(empl);


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtValueToSearch.Text = String.Empty;
            string query;
            query = "select *from Emp";
            dataGridView1.DataSource = obj.Print(query);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            ee.EmpID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            btnDelete.Enabled = true;
        }
    }
}
    
    

