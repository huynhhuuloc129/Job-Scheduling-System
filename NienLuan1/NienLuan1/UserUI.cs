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
            Account thisAccount;
            foreach (Account account in accountList)
            {
                if (account.username == username)
                {
                    personalInformation.Text = "Personal Information: "+account.username;
                    personalInformation.AutoSize = true;
                    txtFullname.Text = account.name;
                    txtDob.Text = account.dob.ToShortDateString();
                    thisAccount = new Account(account);
                    break;
                }
            }
            int i = -1;
            foreach (Shift shift in shiftList)
            {
                Debug.WriteLine(shift.timeStart);
                Debug.WriteLine(shift.timeEnd);
                i++;
                var cbMonday = new MetroSetCheckBox();
                var cbTuesday = new MetroSetCheckBox();
                var cbWednesday = new MetroSetCheckBox();
                var cbThursday = new MetroSetCheckBox();
                var cbFriday = new MetroSetCheckBox();
                var cbSaturday = new MetroSetCheckBox();
                var cbSunday = new MetroSetCheckBox();

                cbMonday.Location = new System.Drawing.Point(409, 134 + 22 * i);
                cbTuesday.Location = new System.Drawing.Point(488, 134 + 22 * i);
                cbWednesday.Location = new System.Drawing.Point(575, 134 + 22 * i);
                cbThursday.Location = new System.Drawing.Point(665, 134 + 22 * i);
                cbFriday.Location = new System.Drawing.Point(744, 134 + 22 * i);
                cbSaturday.Location = new System.Drawing.Point(817, 134 + 22 * i);
                cbSunday.Location = new System.Drawing.Point(887, 134 + 22 * i);

                this.Controls.Add(cbMonday);
                this.Controls.Add(cbTuesday);
                this.Controls.Add(cbWednesday);
                this.Controls.Add(cbThursday);
                this.Controls.Add(cbFriday);
                this.Controls.Add(cbSaturday);
                this.Controls.Add(cbSunday);

                cbMonday.Show();
                cbTuesday.Show();
                cbWednesday.Show();
                cbThursday.Show();
                cbFriday.Show();
                cbSaturday.Show();
                cbSunday.Show();


            }

        }

        private void metroSetButton2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
