using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Login_and_Regsitration_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_Users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string login = "SELECT * FROM tb_Users WHERE Username = '" + txtUsername.Text + "'and Password = '" + txtpassword.Text + "'";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                new dashboard().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or Password was incorrect,Please try again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Text = "";
                txtpassword.Text = "";
                txtUsername.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtpassword.Text = "";
            txtUsername.Focus();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtpassword.PasswordChar = '\0';
        
            }
            else
            {
                txtpassword.PasswordChar = '*';
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
    
}
