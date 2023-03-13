using MetroSet_UI.Forms;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using NienLuan1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NienLuan1
{
    public partial class LoginUI : MetroSetForm
    {
        public int LoginSuccessful;
        public string username;
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
            string path = Path.Combine(Environment.CurrentDirectory, @"..\..\..\Data\Accounts.json");
            string jsonString = System.IO.File.ReadAllText(path);

            List<Account> accountList = (List<Account>)Newtonsoft.Json.JsonConvert.DeserializeObject(jsonString, typeof(List<Account>));

            foreach (var account in accountList)
            {
                if (txtUsername.Text == account.username && txtPassword.Text == account.password && txtUsername.Text != "admin")
                {
                    this.LoginSuccessful = 2;
                    this.username = account.username;
                    this.Close();
                }
                if (txtUsername.Text == account.username && txtPassword.Text == account.password && txtUsername.Text == "admin")
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
