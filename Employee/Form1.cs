using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;

            if(username == "Saumya" && password == "123")
            {
                //MessageBox.Show("correct username and password");

                this.Hide();
                Registration reg = new Registration();
                reg.Show();
            }
            else
            {
                MessageBox.Show("wrong details!");
            }
            
        }
    }
}
