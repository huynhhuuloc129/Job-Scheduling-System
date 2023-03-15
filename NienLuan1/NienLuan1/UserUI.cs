using MetroSet_UI.Controls;
using MetroSet_UI.Forms;
using NienLuan1.Models;
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
    public partial class UserUI : MetroSetForm
    {
        public string username;
        public CheckBox[] cbMonday = new CheckBox[10],
                cbTuesday = new CheckBox[10],
                cbWednesday = new CheckBox[10],
                cbThursday = new CheckBox[10],
                cbFriday = new CheckBox[10],
                cbSaturday = new CheckBox[10],
                cbSunday = new CheckBox[10];
        public UserUI()
        {
            InitializeComponent();
        }

        private void UserUI_Load(object sender, EventArgs e)
        {
            string pathShift = Path.Combine(Environment.CurrentDirectory, @"..\..\..\Data\Shifts.json");
            string jsonStringShift = System.IO.File.ReadAllText(pathShift);
            List<Shift> shiftList = (List<Shift>)Newtonsoft.Json.JsonConvert.DeserializeObject(jsonStringShift, typeof(List<Shift>));


            string path = Path.Combine(Environment.CurrentDirectory, @"..\..\..\Data\Accounts.json");
            string accountsString = System.IO.File.ReadAllText(path);
            List<Account> accountList = (List<Account>)Newtonsoft.Json.JsonConvert.DeserializeObject(accountsString, typeof(List<Account>));
            Account thisAccount = new Account();
            foreach (Account account in accountList)
            {
                if (account.username == username)
                {
                    personalInformation.Text = "Personal Information: " + account.username;
                    personalInformation.AutoSize = true;
                    txtFullname.Text = account.name;
                    txtDob.Text = account.dob.ToShortDateString();
                    createdAtLabel.Text = "Created at: " + account.createdAt;
                    createdAtLabel.AutoSize = true;
                    thisAccount = new Account(account);
                    break;
                }
            }

            int i = -1;
            
            foreach (Shift shift in shiftList)
            {
                i++;
                cbMonday[i] = new CheckBox();
                cbMonday[i].Text = (i + 1).ToString();
                cbMonday[i].AutoSize = true;
                if (Array.IndexOf(thisAccount.shiftMonday, i+1) > -1)
                {
                    cbMonday[i].Checked = true;
                }
                cbTuesday[i] = new CheckBox();
                cbTuesday[i].Text = (i + 1).ToString();
                cbTuesday[i].AutoSize = true;
                if (Array.IndexOf(thisAccount.shiftTuesday, i + 1) > -1)
                {
                    cbTuesday[i].Checked = true;
                }
                cbWednesday[i] = new CheckBox();
                cbWednesday[i].Text = (i + 1).ToString();
                cbWednesday[i].AutoSize = true;
                if (Array.IndexOf(thisAccount.shiftWednesday, i + 1) > -1)
                {
                    cbWednesday[i].Checked = true;
                }
                cbThursday[i] = new CheckBox();
                cbThursday[i].Text = (i + 1).ToString();
                cbThursday[i].AutoSize = true;
                if (Array.IndexOf(thisAccount.shiftThursday, i + 1) > -1)
                {
                    cbThursday[i].Checked = true;
                }
                cbFriday[i] = new CheckBox();
                cbFriday[i].Text = (i + 1).ToString();
                cbFriday[i].AutoSize = true;
                if (Array.IndexOf(thisAccount.shiftFriday, i + 1) > -1)
                {
                    cbFriday[i].Checked = true;
                }
                cbSaturday[i] = new CheckBox();
                cbSaturday[i].Text = (i + 1).ToString();
                cbSaturday[i].AutoSize = true;
                if (Array.IndexOf(thisAccount.shiftSaturday, i + 1) > -1)
                {
                    cbSaturday[i].Checked = true;
                }
                cbSunday[i] = new CheckBox();
                cbSunday[i].Text = (i + 1).ToString();
                cbSunday[i].AutoSize = true;
                if (Array.IndexOf(thisAccount.shiftSunday, i + 1) > -1)
                {
                    cbSunday[i].Checked = true;
                }
                cbMonday[i].Location = new System.Drawing.Point(409, 134 + 26 * i);
                cbTuesday[i].Location = new System.Drawing.Point(488, 134 + 26 * i);
                cbWednesday[i].Location = new System.Drawing.Point(575, 134 + 26 * i);
                cbThursday[i].Location = new System.Drawing.Point(665, 134 + 26 * i);
                cbFriday[i].Location = new System.Drawing.Point(744, 134 + 26 * i);
                cbSaturday[i].Location = new System.Drawing.Point(817, 134 + 26 * i);
                cbSunday[i].Location = new System.Drawing.Point(887, 134 + 26 * i);

                this.Controls.Add(cbMonday[i]);
                this.Controls.Add(cbTuesday[i]);
                this.Controls.Add(cbWednesday[i]);
                this.Controls.Add(cbThursday[i]);
                this.Controls.Add(cbFriday[i]);
                this.Controls.Add(cbSaturday[i]);
                this.Controls.Add(cbSunday[i]);

                cbMonday[i].Show();
                cbTuesday[i].Show();
                cbWednesday[i].Show();
                cbThursday[i].Show();
                cbFriday[i].Show();
                cbSaturday[i].Show();
                cbSunday[i].Show();
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string pathShift = Path.Combine(Environment.CurrentDirectory, @"..\..\..\Data\Shifts.json");
            string jsonStringShift = System.IO.File.ReadAllText(pathShift);
            List<Shift> shiftList = (List<Shift>)Newtonsoft.Json.JsonConvert.DeserializeObject(jsonStringShift, typeof(List<Shift>));


            string path = Path.Combine(Environment.CurrentDirectory, @"..\..\..\Data\Accounts.json");
            string accountsString = System.IO.File.ReadAllText(path);
            List<Account> accountList = (List<Account>)Newtonsoft.Json.JsonConvert.DeserializeObject(accountsString, typeof(List<Account>));
            int positionAcc = -1;
            foreach (Account account in accountList)
            {
                positionAcc++;
                if (account.username == username)
                {
                    accountList[positionAcc].shiftMonday = new int[shiftList.Count+1];
                    accountList[positionAcc].shiftTuesday = new int[shiftList.Count + 1];
                    accountList[positionAcc].shiftWednesday = new int[shiftList.Count + 1];
                    accountList[positionAcc].shiftThursday = new int[shiftList.Count + 1];
                    accountList[positionAcc].shiftFriday = new int[shiftList.Count + 1];
                    accountList[positionAcc].shiftSaturday = new int[shiftList.Count + 1];
                    accountList[positionAcc].shiftSunday = new int[shiftList.Count + 1];
                    break;
                }
            }
            int i = -1, countChecked = 0;
            foreach (Shift shift in shiftList)
            {
                i++;
                if (cbMonday[i].Checked)
                {
                    accountList[positionAcc].shiftMonday[i] = i + 1;
                    countChecked++;
                }
                if (cbTuesday[i].Checked)
                {
                    accountList[positionAcc].shiftTuesday[i] = i + 1;
                    countChecked++;
                }
                if (cbWednesday[i].Checked)
                {
                    accountList[positionAcc].shiftWednesday[i] = i + 1;
                    countChecked++;
                }
                if (cbThursday[i].Checked)
                {
                    accountList[positionAcc].shiftThursday[i] = i + 1;
                    countChecked++;
                }
                if (cbFriday[i].Checked)
                {   
                    accountList[positionAcc].shiftFriday[i] = i + 1;
                    countChecked++;
                }
                if (cbSaturday[i].Checked)
                {
                    accountList[positionAcc].shiftSaturday[i] = i + 1;
                    countChecked++;
                }
                if (cbSunday[i].Checked)
                {   
                    accountList[positionAcc].shiftSunday[i] = i + 1;
                    countChecked++;
                }
            }
            if (txtFullname.Text == "")
            {
                MessageBox.Show("Your name cannot be empty");
                return;
            } else
            {
                accountList[positionAcc].name = txtFullname.Text;
            }
            if (countChecked == 0)
            {
                MessageBox.Show("Please select atleast 1 shift");
                return;
            }
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(accountList);
            File.WriteAllText(path, json);
            UserUI_Load(null, EventArgs.Empty);
        }
    }
}
