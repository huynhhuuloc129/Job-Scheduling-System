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
using System.ComponentModel;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.VisualBasic.ApplicationServices;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace NienLuan1
{


    public partial class AdminForm : MetroSetForm
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private DataGridView gridView;
        private void AdminForm_Load(object sender, EventArgs e)
        {
            this.AutoScroll = true;
            this.AutoSize = true;
            string path = Path.Combine(Environment.CurrentDirectory, @"..\..\..\Data\Accounts.json");
            string accountsString = System.IO.File.ReadAllText(path);
            List<Account> accountList = (List<Account>)Newtonsoft.Json.JsonConvert.DeserializeObject(accountsString, typeof(List<Account>));

            string pathGrid = Path.Combine(Environment.CurrentDirectory, @"..\..\..\Data\Grid.json");
            string gridStr = System.IO.File.ReadAllText(pathGrid);
            GridData gridData = Newtonsoft.Json.JsonConvert.DeserializeObject<GridData>(gridStr);

            string pathShift = Path.Combine(Environment.CurrentDirectory, @"..\..\..\Data\Shifts.json");
            string jsonStringShift = System.IO.File.ReadAllText(pathShift);
            List<Shift> shiftList = (List<Shift>)Newtonsoft.Json.JsonConvert.DeserializeObject(jsonStringShift, typeof(List<Shift>));

            initAccounts(accountList);

            // make empty grid
            gridView = initGridView();
            gridView.AutoSize = true;
            gridView.Location = new Point(374, 48);
            gridView.EditMode = DataGridViewEditMode.EditOnEnter;
            for (int i = 0; i < shiftList.Count; i++)
            {
                gridView.Rows.Add(i + 1, gridData.Monday[i], gridData.Tuesday[i], gridData.Wednesday[i], gridData.Thursday[i], gridData.Friday[i], gridData.Saturday[i], gridData.Sunday[i]);
            }
            this.Controls.Add(gridView);

             
            for (int i = 0; i < shiftList.Count; i++)
            {
                var shiftLabel = new MetroSetLabel();
                shiftLabel.Text = "Shift " + (i + 1).ToString() + ": " + shiftList[i].timeStart.ToString() + " - " + shiftList[i].timeEnd.ToString();
                shiftLabel.AutoSize = true;
                shiftLabel.Location = new System.Drawing.Point(400, 26 * i + (shiftList.Count+5)*32);
                this.Controls.Add(shiftLabel);
            }
        }

        private DataGridView initGridView()
        {
            string pathShift = Path.Combine(Environment.CurrentDirectory, @"..\..\..\Data\Shifts.json");
            string jsonStringShift = System.IO.File.ReadAllText(pathShift);
            List<Shift> shiftList = (List<Shift>)Newtonsoft.Json.JsonConvert.DeserializeObject(jsonStringShift, typeof(List<Shift>));

            string[] columnName = { "Shift", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            DataGridView dataGridView = new DataGridView();

            dataGridView.AutoGenerateColumns = false;
            dataGridView.AutoSize = true;
            int i;
            for (i = 0; i < columnName.Length; i++)
            {
                DataGridViewColumn column = new DataGridViewTextBoxColumn();
                column.DataPropertyName = columnName[i];
                column.Name = columnName[i];
                dataGridView.Columns.Add(column);
                dataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            saveDataBtn.Location = new Point(600,(shiftList.Count + 5) * 32);
            return dataGridView;
        }

        private void initAccounts(List<Account> accounts)
        {
            var i = -1;
            foreach (Account account in accounts)
            {
                i += 2;
                var tempUsername = new MetroSetLabel();
                var tempPassword = new MetroSetLabel();
                var showBtn = new Button();

                showBtn.Location = new Point(250, 130 + i * 24);
                showBtn.Text = "Show";
                showBtn.AutoSize = true;
                showBtn.BackColor = Color.Blue;
                showBtn.ForeColor = Color.White;
                showBtn.Name = account.username;
                showBtn.Click += new EventHandler(showBtn_Click);
                showBtn.Cursor = Cursors.Hand;

                tempUsername.Location = new Point(10, 130 + i * 24);
                tempUsername.Text = "Username: " + account.username;
                tempUsername.AutoSize = true;

                tempPassword.Location = new Point(10, 150 + i * 24);
                tempPassword.Text = "Password: " + account.password;
                tempPassword.AutoSize = true;

                this.Controls.Add(tempUsername);
                this.Controls.Add(tempPassword);
                this.Controls.Add(showBtn);
            }
            i += 2;
            newUsername.Location = new Point(10, 150 + i * 24);
            newPassword.Location = new Point(10, 190 + i * 24);

            txtNewUsername.Location = new Point(110, 150 + i * 24);
            txtNewPassword.Location = new Point(110, 190 + i * 24);
            txtNewPassword.PasswordChar = '*';

            plusAccountBtn.Location = new Point(10, 230 + i * 24);
            sortBtn.Location = new Point(10, 280 + i * 24);

            this.Controls.Add(newUsername);
            this.Controls.Add(newPassword);
        }

        private void showBtn_Click(object sender, System.EventArgs e)
        {
            var button = (Button)sender;
            ShowShiftForm ssf = new ShowShiftForm(button.Name);
            ssf.Show();
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
            System.Windows.Forms.Application.Restart();
        }

        int countArray(int[] count)
        {
            int s = 0;
            for (int i = 0; i < count.Length; i++)
            {
                s += count[i];
            }
            return s;
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {
            gridView.Rows.Clear();
            // get Accounts
            string path = Path.Combine(Environment.CurrentDirectory, @"..\..\..\Data\Accounts.json");
            string accountsString = System.IO.File.ReadAllText(path);
            List<Account> accountList = (List<Account>)Newtonsoft.Json.JsonConvert.DeserializeObject(accountsString, typeof(List<Account>));
            // get Shifts
            string pathShift = Path.Combine(Environment.CurrentDirectory, @"..\..\..\Data\Shifts.json");
            string jsonStringShift = System.IO.File.ReadAllText(pathShift);
            List<Shift> shiftList = (List<Shift>)Newtonsoft.Json.JsonConvert.DeserializeObject(jsonStringShift, typeof(List<Shift>));

            // sort account
            for (int i = 0; i < accountList.Count; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    var count1 = countArray(accountList[i].shiftMonday) + countArray(accountList[i].shiftTuesday) + countArray(accountList[i].shiftWednesday) + countArray(accountList[i].shiftThursday) + countArray(accountList[i].shiftFriday) + countArray(accountList[i].shiftSaturday) + countArray(accountList[i].shiftSunday);
                    var count2 = countArray(accountList[j].shiftMonday) + countArray(accountList[j].shiftTuesday) + countArray(accountList[j].shiftWednesday) + countArray(accountList[j].shiftThursday) + countArray(accountList[j].shiftFriday) + countArray(accountList[j].shiftSaturday) + countArray(accountList[j].shiftSunday);
                    if (count1 > count2)
                    {
                        Account tempAccount = new Account(accountList[i]);
                        accountList[i] = new Account(accountList[j]);
                        accountList[j] = new Account(tempAccount);
                    }
                }
            }
            GridData gridData = new GridData();

            string[] dayOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            for (int i = 0; i < dayOfWeek.Length; i++)
            {
                foreach (Account account in accountList)
                {
                    for (int j = 0; j < shiftList.Count; j++)
                    {
                        switch (dayOfWeek[i])
                        {
                            case "Monday":
                                if (account.shiftMonday[j] != 0 && gridData.Monday[j] == null)
                                {
                                    gridData.Monday[j] = account.username;
                                }
                                break;
                            case "Tuesday":
                                if (account.shiftTuesday[j] != 0 && gridData.Tuesday[j] == null)
                                {
                                    gridData.Tuesday[j] = account.username;
                                }
                                break;
                            case "Wednesday":
                                if (account.shiftWednesday[j] != 0 && gridData.Wednesday[j] == null)
                                {
                                    gridData.Wednesday[j] = account.username;
                                }
                                break;
                            case "Thursday":
                                if (account.shiftThursday[j] != 0 && gridData.Thursday[j] == null)
                                {
                                    gridData.Thursday[j] = account.username;
                                }
                                break;
                            case "Friday":
                                if (account.shiftFriday[j] != 0 && gridData.Friday[j] == null)
                                {
                                    gridData.Friday[j] = account.username;
                                }
                                break;
                            case "Saturday":
                                if (account.shiftSaturday[j] != 0 && gridData.Saturday[j] == null)
                                {
                                    gridData.Saturday[j] = account.username;
                                }
                                break;
                            case "Sunday":
                                if (account.shiftSunday[j] != 0 && gridData.Sunday[j] == null)
                                {
                                    gridData.Sunday[j] = account.username;
                                }
                                break;
                        }
                    }
                }
            }

            for (int i = 0; i < shiftList.Count; i++)
            {
                gridView.Rows.Add(i + 1, gridData.Monday[i], gridData.Tuesday[i], gridData.Wednesday[i], gridData.Thursday[i], gridData.Friday[i], gridData.Saturday[i], gridData.Sunday[i]);
            }
            gridView.AutoSize = true;
            gridView.Location = new Point(374, 48);
            gridView.Update();
            gridView.Refresh();

            string pathGrid = Path.Combine(Environment.CurrentDirectory, @"..\..\..\Data\Grid.json");
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(gridData);
            File.WriteAllText(pathGrid, json);
        }

        private void saveDataBtn_Click(object sender, EventArgs e)
        {
            GridData gridData = new GridData();
            for (int i = 0; i<gridView.RowCount; i++) {
                gridData.Monday[i]= gridView.Rows[i].Cells[1].Value?.ToString();
                gridData.Tuesday[i] = gridView.Rows[i].Cells[2].Value?.ToString();
                gridData.Wednesday[i] = gridView.Rows[i].Cells[3].Value?.ToString();
                gridData.Thursday[i] = gridView.Rows[i].Cells[4].Value?.ToString();
                gridData.Friday[i] = gridView.Rows[i].Cells[5].Value?.ToString();
                gridData.Saturday[i] = gridView.Rows[i].Cells[6].Value?.ToString();
                gridData.Sunday[i] = gridView.Rows[i].Cells[7].Value?.ToString();
            }

            string pathGrid = Path.Combine(Environment.CurrentDirectory, @"..\..\..\Data\Grid.json");
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(gridData);

            File.WriteAllText(pathGrid, json);
            MessageBox.Show("Save Successful!");
        }
    }
}
