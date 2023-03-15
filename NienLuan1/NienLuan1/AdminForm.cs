using MetroSet_UI.Controls;
using MetroSet_UI.Forms;
using System.Collections;
using System.Diagnostics;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using NienLuan1.Models;
using static NienLuan1.AdminForm;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.LinkLabel;

namespace NienLuan1
{


    public partial class AdminForm : MetroSetForm
    {
        public AdminForm()
        {
            InitializeComponent();
        }
        public class Shift
        {
            public int TimeStart;
            public int TimeEnd;
        }

        public class GridData
        {
            public string[] Monday;
            public string[] Tuesday;
            public string[] Wednesday;
            public string[] Mouth;
            public string[] Thursday;
            public string[] Friday;
            public string[] Saturday;
            public string[] Sunday;
            public Shift[] Shifts;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            GridData[] gridData;
            Account[] accounts;
            Shift[] shifts;
            this.AutoScroll = true;
            this.AutoSize = true;
            string path = Path.Combine(Environment.CurrentDirectory, @"..\..\..\Data\Accounts.json");
            string accountsString = System.IO.File.ReadAllText(path);
            List<Account> accountList = (List<Account>)Newtonsoft.Json.JsonConvert.DeserializeObject(accountsString, typeof(List<Account>));

            string pathShift = Path.Combine(Environment.CurrentDirectory, @"..\..\..\Data\Shifts.json");
            string shiftsString = System.IO.File.ReadAllText(pathShift).Replace("\n\r", "").Replace("\n", "").Replace("\r", " ");
            //List<Shift> shiftList = (List<Shift>)Newtonsoft.Json.JsonConvert.DeserializeObject(shiftsString, typeof(List<Shift>));


            //shifts = initShifts(shiftsString);
            initAccounts(accountList);
            //gridData = initGridData(accounts, shifts);
        }

        private Shift[] initShifts(string shiftsString)
        {
            Shift[] shifts = new Shift[100];
            int i, lenShifts = 0;
            string[] shiftsText = shiftsString.Split(" ");
            for (i = 0; i < shiftsText.Length - 1; i += 2)
            {
                shifts[lenShifts] = new Shift();
                shifts[lenShifts].TimeStart = Int32.Parse(shiftsText[i]);
                shifts[lenShifts].TimeEnd = Int32.Parse(shiftsText[i + 1]);
                lenShifts++;
            }
            return shifts;
        }
        private void initAccounts(List<Account> accounts)
        {
            var i = -1;
            foreach (Account account in accounts)
            {
                i += 2;
                var tempUsername = new MetroSetLabel();
                var tempPassword = new MetroSetLabel();

                tempUsername.Location = new Point(10, 150 + i * 20);
                tempUsername.Text = "Username: " + account.username;
                tempUsername.AutoSize = true;

                tempPassword.Location = new Point(10, 170 + i * 20);
                tempPassword.Text = "Password: " + account.password;
                tempPassword.AutoSize = true;

                this.Controls.Add(tempUsername);
                this.Controls.Add(tempPassword);
                tempPassword.Show();
                tempUsername.Show();
            }
            i += 2;
            newUsername.Location = new Point(10, 170 + i * 20);
            newPassword.Location = new Point(10, 210 + i * 20);

            txtNewUsername.Location = new Point(110, 170 + i * 20);
            txtNewPassword.Location = new Point(110, 210 + i * 20);
            txtNewPassword.PasswordChar = '*';

            plusAccountBtn.Location = new Point(10, 250 + i * 20);

            this.Controls.Add(newUsername);
            this.Controls.Add(newPassword);

            newPassword.Show();
            newUsername.Show();
        }

        private GridData[] initGridData(Account[] accounts, Shift[] shifts)
        {
            GridData[] gridData = new GridData[100];
            for (int i = 0; i < shifts.Length - 1; i += 2)
            {
                gridData[i] = new GridData();
            }
            return gridData;
        }

        private void plusAccountBtn_Click(object sender, EventArgs e)
        {
            if (txtNewUsername.Text == "")
            {
                MessageBox.Show("Please input new username");
                return;
            }
            if (txtNewPassword.Text == "")
            {
                MessageBox.Show("Please input new password");
                return;
            }

            string path = Path.Combine(Environment.CurrentDirectory, @"..\..\..\Data\Accounts.json");
            string accountsString = System.IO.File.ReadAllText(path);
            List<Account> accountList = (List<Account>)Newtonsoft.Json.JsonConvert.DeserializeObject(accountsString, typeof(List<Account>));


            foreach (Account account in accountList)
            {
                if (account.username == txtNewUsername.Text.Trim())
                {
                    MessageBox.Show("Please input new username, duplicate username");
                    return;
                }
            }

            Account newAccount = new Account();
            newAccount.username = txtNewUsername.Text;
            newAccount.password = txtNewPassword.Text;
            newAccount.createdAt = DateTime.Now;
            accountList.Add(newAccount);

            string json = Newtonsoft.Json.JsonConvert.SerializeObject(accountList);
            File.WriteAllText(path, json);
            txtNewUsername.Clear();
            txtNewPassword.Clear();

            // Reload the site when add user success
            AdminForm_Load(null, EventArgs.Empty);
        }

        private void txtNewUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                plusAccountBtn_Click(sender, e);
            }
        }

        private void txtNewPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                plusAccountBtn_Click(sender, e);
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
