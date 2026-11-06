using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }
        

     

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "" && txtPassword.Text !="" )
            {
                mainForm main = new mainForm();
                DialogResult = DialogResult.OK; 
            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }
        }
    }
}
