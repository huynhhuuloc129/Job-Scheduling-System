using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NienLuan1
{
    public partial class LoginUI : MetroSetForm
    {
        public int LoginSuccessful;
        public LoginUI()
        {
            InitializeComponent();
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
        private void LoginUI_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Please input Username");
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Please input Password");
                return;
            }

            this.LoginSuccessful = 0;
            string path = Path.Combine(Environment.CurrentDirectory, @"..\..\..\Accounts.txt");
            string[] text = System.IO.File.ReadAllText(path).Split('\n');

            for (int i = 0; i < text.Length - 1; i += 2)
            {
                if (txtUsername.Text == text[i].Trim() && txtPassword.Text == text[i + 1].Trim())
                {
                    this.LoginSuccessful = 1;
                    this.Close();
                }
            }
            MessageBox.Show("Invalid Username or Password");
            return;
        }
    }
}
