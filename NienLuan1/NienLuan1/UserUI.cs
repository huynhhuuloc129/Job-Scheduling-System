﻿using MetroSet_UI.Controls;
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
                    txtFullname.SelectionLength = 0;
                    txtDob.Text = account.dob.ToShortDateString();
                    createdAtLabel.Text = "Created at: " + account.createdAt;
                    createdAtLabel.AutoSize = true;
                    thisAccount = new Account(account);
                    break;
                }
            }

            int i;
            for (i = 0; i < shiftList.Count; i++)
            {
                cbMonday[i] = new CheckBox();
                cbMonday[i].Text = (i + 1).ToString();
                cbMonday[i].AutoSize = true;
                cbMonday[i].BackColor = Color.White;
                cbMonday[i].ForeColor = Color.Black;
                if (Array.IndexOf(thisAccount.shiftMonday, i + 1) > -1)
                {
                    cbMonday[i].Checked = true;
                }
                cbTuesday[i] = new CheckBox();
                cbTuesday[i].Text = (i + 1).ToString();
                cbTuesday[i].AutoSize = true;
                cbTuesday[i].BackColor = Color.White;
                cbTuesday[i].ForeColor = Color.Black;
                if (Array.IndexOf(thisAccount.shiftTuesday, i + 1) > -1)
                {
                    cbTuesday[i].Checked = true;
                }
                cbWednesday[i] = new CheckBox();
                cbWednesday[i].Text = (i + 1).ToString();
                cbWednesday[i].AutoSize = true;
                cbWednesday[i].BackColor = Color.White;
                cbWednesday[i].ForeColor = Color.Black;
                if (Array.IndexOf(thisAccount.shiftWednesday, i + 1) > -1)
                {
                    cbWednesday[i].Checked = true;
                }
                cbThursday[i] = new CheckBox();
                cbThursday[i].Text = (i + 1).ToString();
                cbThursday[i].AutoSize = true;
                cbThursday[i].BackColor = Color.White;
                cbThursday[i].ForeColor = Color.Black;
                if (Array.IndexOf(thisAccount.shiftThursday, i + 1) > -1)
                {
                    cbThursday[i].Checked = true;
                }
                cbFriday[i] = new CheckBox();
                cbFriday[i].Text = (i + 1).ToString();
                cbFriday[i].AutoSize = true;
                cbFriday[i].BackColor = Color.White;
                cbFriday[i].ForeColor = Color.Black;
                if (Array.IndexOf(thisAccount.shiftFriday, i + 1) > -1)
                {
                    cbFriday[i].Checked = true;
                }
                cbSaturday[i] = new CheckBox();
                cbSaturday[i].Text = (i + 1).ToString();
                cbSaturday[i].AutoSize = true;
                cbSaturday[i].BackColor = Color.White;
                cbSaturday[i].ForeColor = Color.Black;
                if (Array.IndexOf(thisAccount.shiftSaturday, i + 1) > -1)
                {
                    cbSaturday[i].Checked = true;
                }
                cbSunday[i] = new CheckBox();
                cbSunday[i].Text = (i + 1).ToString();
                cbSunday[i].AutoSize = true;
                cbSunday[i].BackColor = Color.White;
                cbSunday[i].ForeColor = Color.Black;
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
            }
            for (i = 0; i < shiftList.Count; i++)
            {
                var shiftLabel = new MetroSetLabel();
                shiftLabel.Text = "Shift " + (i + 1).ToString() + ": " + shiftList[i].timeStart.ToString() + " - " + shiftList[i].timeEnd.ToString();
                shiftLabel.AutoSize = true;
                shiftLabel.Location = new System.Drawing.Point(400, 240 + 26 * i);
                this.Controls.Add(shiftLabel);
            }
            this.AutoSize = true;
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
                    accountList[positionAcc].shiftMonday = new int[shiftList.Count];
                    accountList[positionAcc].shiftTuesday = new int[shiftList.Count];
                    accountList[positionAcc].shiftWednesday = new int[shiftList.Count];
                    accountList[positionAcc].shiftThursday = new int[shiftList.Count];
                    accountList[positionAcc].shiftFriday = new int[shiftList.Count];
                    accountList[positionAcc].shiftSaturday = new int[shiftList.Count];
                    accountList[positionAcc].shiftSunday = new int[shiftList.Count];
                    break;
                }
            }
            int i = -1, countChecked = 0;
            foreach (Shift shift in shiftList)
            {
                i++;
                if (cbMonday[i].Checked)
                {
                    accountList[positionAcc].shiftMonday[i] = 1;
                    countChecked++;
                }
                if (cbTuesday[i].Checked)
                {
                    accountList[positionAcc].shiftTuesday[i] = 1;
                    countChecked++;
                }
                if (cbWednesday[i].Checked)
                {
                    accountList[positionAcc].shiftWednesday[i] = 1;
                    countChecked++;
                }
                if (cbThursday[i].Checked)
                {
                    accountList[positionAcc].shiftThursday[i] = 1;
                    countChecked++;
                }
                if (cbFriday[i].Checked)
                {
                    accountList[positionAcc].shiftFriday[i] = 1;
                    countChecked++;
                }
                if (cbSaturday[i].Checked)
                {
                    accountList[positionAcc].shiftSaturday[i] = 1;
                    countChecked++;
                }
                if (cbSunday[i].Checked)
                {
                    accountList[positionAcc].shiftSunday[i] = 1;
                    countChecked++;
                }
            }
            if (txtDob.Text == "")
            {
                MessageBox.Show("Your birthday cannot be empty");
                return;
            }
            if (txtFullname.Text == "")
            {
                MessageBox.Show("Your name cannot be empty");
                return;
            }
            accountList[positionAcc].dob = DateTime.Parse(txtDob.Text);
            accountList[positionAcc].name = txtFullname.Text;
            if (countChecked == 0)
            {
                MessageBox.Show("Please select atleast 1 shift");
                return;
            }
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(accountList);
            File.WriteAllText(path, json);
            MessageBox.Show("Save successful");
            UserUI_Load(null, EventArgs.Empty);
        }
    }
}
