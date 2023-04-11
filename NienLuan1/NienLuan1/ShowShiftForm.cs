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
    public partial class ShowShiftForm : MetroSetForm
    {
        public ShowShiftForm(string username)
        {
            this.AutoSize = true;
            InitializeComponent();
            string path = Path.Combine(Environment.CurrentDirectory, @"..\..\..\Data\Accounts.json");
            string accountsString = System.IO.File.ReadAllText(path);
            List<Account> accountList = (List<Account>)Newtonsoft.Json.JsonConvert.DeserializeObject(accountsString, typeof(List<Account>));

            string pathShift = Path.Combine(Environment.CurrentDirectory, @"..\..\..\Data\Shifts.json");
            string jsonStringShift = System.IO.File.ReadAllText(pathShift);
            List<Shift> shiftList = (List<Shift>)Newtonsoft.Json.JsonConvert.DeserializeObject(jsonStringShift, typeof(List<Shift>));

            Account mainAccount = new Account();
            foreach (Account account in accountList)
            {
                if (account.username == username)
                {
                    mainAccount = new Account(account);
                    break;
                }
            }
            usernameLabel.Text = "Username: " + username;
            usernameLabel.AutoSize = true;
            for (int i = 0; i < shiftList.Count; i++)
            {
                MetroSetLabel metroSetLabel = new MetroSetLabel();
                metroSetLabel.Text = (i + 1).ToString() + ":       " + mainAccount.shiftMonday[i] + "             "
                    + mainAccount.shiftTuesday[i] + "                 "
                    + mainAccount.shiftWednesday[i] + "                 "
                    + mainAccount.shiftThursday[i] + "            "
                    + mainAccount.shiftFriday[i] + "            "
                    + mainAccount.shiftSaturday[i] + "             "
                    + mainAccount.shiftSunday[i];
                metroSetLabel.Location = new Point(54, 125 + 23 * i);
                metroSetLabel.AutoSize = true;
                this.Controls.Add(metroSetLabel);
            }
        }

        public void ShowShiftForm_Load(object sender, EventArgs e)
        {

        }
    }
}
