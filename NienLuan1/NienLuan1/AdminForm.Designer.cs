namespace NienLuan1
{
    partial class AdminForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            newPassword = new MetroSet_UI.Controls.MetroSetLabel();
            newUsername = new MetroSet_UI.Controls.MetroSetLabel();
            txtNewPassword = new TextBox();
            txtNewUsername = new TextBox();
            plusAccountBtn = new MetroSet_UI.Controls.MetroSetButton();
            logoutBtn = new MetroSet_UI.Controls.MetroSetButton();
            sortBtn = new MetroSet_UI.Controls.MetroSetButton();
            saveDataBtn = new MetroSet_UI.Controls.MetroSetButton();
            labelDay = new MetroSet_UI.Controls.MetroSetLabel();
            comboBoxDay = new MetroSet_UI.Controls.MetroSetComboBox();
            labelShift = new MetroSet_UI.Controls.MetroSetLabel();
            comboBoxShift = new MetroSet_UI.Controls.MetroSetComboBox();
            labelName = new MetroSet_UI.Controls.MetroSetLabel();
            comboBoxName = new MetroSet_UI.Controls.MetroSetComboBox();
            SuspendLayout();
            // 
            // metroSetControlBox1
            // 
            metroSetControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            metroSetControlBox1.CloseHoverBackColor = Color.FromArgb(183, 40, 40);
            metroSetControlBox1.CloseHoverForeColor = Color.White;
            metroSetControlBox1.CloseNormalForeColor = Color.Gray;
            metroSetControlBox1.DisabledForeColor = Color.DimGray;
            metroSetControlBox1.IsDerivedStyle = true;
            metroSetControlBox1.Location = new Point(1204, -1);
            metroSetControlBox1.MaximizeBox = true;
            metroSetControlBox1.MaximizeHoverBackColor = Color.FromArgb(238, 238, 238);
            metroSetControlBox1.MaximizeHoverForeColor = Color.Gray;
            metroSetControlBox1.MaximizeNormalForeColor = Color.Gray;
            metroSetControlBox1.MinimizeBox = true;
            metroSetControlBox1.MinimizeHoverBackColor = Color.FromArgb(238, 238, 238);
            metroSetControlBox1.MinimizeHoverForeColor = Color.Gray;
            metroSetControlBox1.MinimizeNormalForeColor = Color.Gray;
            metroSetControlBox1.Name = "metroSetControlBox1";
            metroSetControlBox1.Size = new Size(100, 25);
            metroSetControlBox1.Style = MetroSet_UI.Enums.Style.Light;
            metroSetControlBox1.StyleManager = null;
            metroSetControlBox1.TabIndex = 0;
            metroSetControlBox1.Text = "metroSetControlBox1";
            metroSetControlBox1.ThemeAuthor = "Narwin";
            metroSetControlBox1.ThemeName = "MetroLite";
            // 
            // metroSetLabel1
            // 
            metroSetLabel1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            metroSetLabel1.IsDerivedStyle = true;
            metroSetLabel1.Location = new Point(15, 105);
            metroSetLabel1.Name = "metroSetLabel1";
            metroSetLabel1.Size = new Size(93, 26);
            metroSetLabel1.Style = MetroSet_UI.Enums.Style.Light;
            metroSetLabel1.StyleManager = null;
            metroSetLabel1.TabIndex = 1;
            metroSetLabel1.Text = "Accounts";
            metroSetLabel1.ThemeAuthor = "Narwin";
            metroSetLabel1.ThemeName = "MetroLite";
            // 
            // newPassword
            // 
            newPassword.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            newPassword.IsDerivedStyle = true;
            newPassword.Location = new Point(14, 184);
            newPassword.Name = "newPassword";
            newPassword.Size = new Size(94, 32);
            newPassword.Style = MetroSet_UI.Enums.Style.Light;
            newPassword.StyleManager = null;
            newPassword.TabIndex = 11;
            newPassword.Text = "Password";
            newPassword.ThemeAuthor = "Narwin";
            newPassword.ThemeName = "MetroLite";
            // 
            // newUsername
            // 
            newUsername.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            newUsername.IsDerivedStyle = true;
            newUsername.Location = new Point(14, 140);
            newUsername.Name = "newUsername";
            newUsername.Size = new Size(94, 32);
            newUsername.Style = MetroSet_UI.Enums.Style.Light;
            newUsername.StyleManager = null;
            newUsername.TabIndex = 10;
            newUsername.Text = "Username";
            newUsername.ThemeAuthor = "Narwin";
            newUsername.ThemeName = "MetroLite";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(114, 184);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(230, 32);
            txtNewPassword.TabIndex = 9;
            txtNewPassword.KeyDown += txtNewPassword_KeyDown;
            // 
            // txtNewUsername
            // 
            txtNewUsername.Location = new Point(114, 140);
            txtNewUsername.Name = "txtNewUsername";
            txtNewUsername.Size = new Size(230, 32);
            txtNewUsername.TabIndex = 8;
            txtNewUsername.KeyDown += txtNewUsername_KeyDown;
            // 
            // plusAccountBtn
            // 
            plusAccountBtn.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            plusAccountBtn.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            plusAccountBtn.DisabledForeColor = Color.Gray;
            plusAccountBtn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            plusAccountBtn.HoverBorderColor = Color.FromArgb(95, 207, 255);
            plusAccountBtn.HoverColor = Color.FromArgb(95, 207, 255);
            plusAccountBtn.HoverTextColor = Color.White;
            plusAccountBtn.IsDerivedStyle = true;
            plusAccountBtn.Location = new Point(293, 235);
            plusAccountBtn.Name = "plusAccountBtn";
            plusAccountBtn.NormalBorderColor = Color.FromArgb(65, 177, 225);
            plusAccountBtn.NormalColor = Color.FromArgb(65, 177, 225);
            plusAccountBtn.NormalTextColor = Color.White;
            plusAccountBtn.PressBorderColor = Color.FromArgb(35, 147, 195);
            plusAccountBtn.PressColor = Color.FromArgb(35, 147, 195);
            plusAccountBtn.PressTextColor = Color.White;
            plusAccountBtn.Size = new Size(51, 30);
            plusAccountBtn.Style = MetroSet_UI.Enums.Style.Light;
            plusAccountBtn.StyleManager = null;
            plusAccountBtn.TabIndex = 12;
            plusAccountBtn.Text = "+";
            plusAccountBtn.ThemeAuthor = "Narwin";
            plusAccountBtn.ThemeName = "MetroLite";
            plusAccountBtn.Click += plusAccountBtn_Click;
            // 
            // logoutBtn
            // 
            logoutBtn.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            logoutBtn.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            logoutBtn.DisabledForeColor = Color.Gray;
            logoutBtn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            logoutBtn.HoverBorderColor = Color.FromArgb(95, 207, 255);
            logoutBtn.HoverColor = Color.FromArgb(95, 207, 255);
            logoutBtn.HoverTextColor = Color.White;
            logoutBtn.IsDerivedStyle = true;
            logoutBtn.Location = new Point(129, 105);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.NormalBorderColor = Color.FromArgb(65, 177, 225);
            logoutBtn.NormalColor = Color.FromArgb(65, 177, 225);
            logoutBtn.NormalTextColor = Color.White;
            logoutBtn.PressBorderColor = Color.FromArgb(35, 147, 195);
            logoutBtn.PressColor = Color.FromArgb(35, 147, 195);
            logoutBtn.PressTextColor = Color.White;
            logoutBtn.Size = new Size(94, 29);
            logoutBtn.Style = MetroSet_UI.Enums.Style.Light;
            logoutBtn.StyleManager = null;
            logoutBtn.TabIndex = 13;
            logoutBtn.Text = "Logout";
            logoutBtn.ThemeAuthor = "Narwin";
            logoutBtn.ThemeName = "MetroLite";
            logoutBtn.Click += logoutBtn_Click;
            // 
            // sortBtn
            // 
            sortBtn.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            sortBtn.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            sortBtn.DisabledForeColor = Color.Gray;
            sortBtn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            sortBtn.HoverBorderColor = Color.FromArgb(95, 207, 255);
            sortBtn.HoverColor = Color.FromArgb(95, 207, 255);
            sortBtn.HoverTextColor = Color.White;
            sortBtn.IsDerivedStyle = true;
            sortBtn.Location = new Point(250, 281);
            sortBtn.Name = "sortBtn";
            sortBtn.NormalBorderColor = Color.FromArgb(65, 177, 225);
            sortBtn.NormalColor = Color.FromArgb(65, 177, 225);
            sortBtn.NormalTextColor = Color.White;
            sortBtn.PressBorderColor = Color.FromArgb(35, 147, 195);
            sortBtn.PressColor = Color.FromArgb(35, 147, 195);
            sortBtn.PressTextColor = Color.White;
            sortBtn.Size = new Size(94, 29);
            sortBtn.Style = MetroSet_UI.Enums.Style.Light;
            sortBtn.StyleManager = null;
            sortBtn.TabIndex = 15;
            sortBtn.Text = "Sort";
            sortBtn.ThemeAuthor = "Narwin";
            sortBtn.ThemeName = "MetroLite";
            sortBtn.Click += sortBtn_Click;
            // 
            // saveDataBtn
            // 
            saveDataBtn.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            saveDataBtn.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            saveDataBtn.DisabledForeColor = Color.Gray;
            saveDataBtn.Enabled = false;
            saveDataBtn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            saveDataBtn.HoverBorderColor = Color.FromArgb(95, 207, 255);
            saveDataBtn.HoverColor = Color.FromArgb(95, 207, 255);
            saveDataBtn.HoverTextColor = Color.White;
            saveDataBtn.IsDerivedStyle = true;
            saveDataBtn.Location = new Point(1152, 266);
            saveDataBtn.Name = "saveDataBtn";
            saveDataBtn.NormalBorderColor = Color.FromArgb(65, 177, 225);
            saveDataBtn.NormalColor = Color.FromArgb(65, 177, 225);
            saveDataBtn.NormalTextColor = Color.White;
            saveDataBtn.PressBorderColor = Color.FromArgb(35, 147, 195);
            saveDataBtn.PressColor = Color.FromArgb(35, 147, 195);
            saveDataBtn.PressTextColor = Color.White;
            saveDataBtn.Size = new Size(111, 44);
            saveDataBtn.Style = MetroSet_UI.Enums.Style.Light;
            saveDataBtn.StyleManager = null;
            saveDataBtn.TabIndex = 16;
            saveDataBtn.Text = "Save Data";
            saveDataBtn.ThemeAuthor = "Narwin";
            saveDataBtn.ThemeName = "MetroLite";
            saveDataBtn.Click += saveDataBtn_Click;
            // 
            // labelDay
            // 
            labelDay.AutoSize = true;
            labelDay.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelDay.IsDerivedStyle = true;
            labelDay.Location = new Point(506, 155);
            labelDay.Name = "labelDay";
            labelDay.Size = new Size(44, 20);
            labelDay.Style = MetroSet_UI.Enums.Style.Light;
            labelDay.StyleManager = null;
            labelDay.TabIndex = 17;
            labelDay.Text = "Day:";
            labelDay.ThemeAuthor = "Narwin";
            labelDay.ThemeName = "MetroLite";
            // 
            // comboBoxDay
            // 
            comboBoxDay.AllowDrop = true;
            comboBoxDay.ArrowColor = Color.FromArgb(150, 150, 150);
            comboBoxDay.BackColor = Color.Transparent;
            comboBoxDay.BackgroundColor = Color.FromArgb(238, 238, 238);
            comboBoxDay.BorderColor = Color.FromArgb(150, 150, 150);
            comboBoxDay.CausesValidation = false;
            comboBoxDay.DisabledBackColor = Color.FromArgb(204, 204, 204);
            comboBoxDay.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            comboBoxDay.DisabledForeColor = Color.FromArgb(136, 136, 136);
            comboBoxDay.DrawMode = DrawMode.OwnerDrawFixed;
            comboBoxDay.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDay.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxDay.FormattingEnabled = true;
            comboBoxDay.IsDerivedStyle = true;
            comboBoxDay.ItemHeight = 20;
            comboBoxDay.Location = new Point(556, 155);
            comboBoxDay.Name = "comboBoxDay";
            comboBoxDay.SelectedItemBackColor = Color.FromArgb(65, 177, 225);
            comboBoxDay.SelectedItemForeColor = Color.White;
            comboBoxDay.Size = new Size(99, 26);
            comboBoxDay.Style = MetroSet_UI.Enums.Style.Light;
            comboBoxDay.StyleManager = null;
            comboBoxDay.TabIndex = 18;
            comboBoxDay.ThemeAuthor = "Narwin";
            comboBoxDay.ThemeName = "MetroLite";
            comboBoxDay.SelectedIndexChanged += metroSetComboBox1_SelectedIndexChanged;
            // 
            // labelShift
            // 
            labelShift.AutoSize = true;
            labelShift.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelShift.IsDerivedStyle = true;
            labelShift.Location = new Point(713, 155);
            labelShift.Name = "labelShift";
            labelShift.Size = new Size(48, 20);
            labelShift.Style = MetroSet_UI.Enums.Style.Light;
            labelShift.StyleManager = null;
            labelShift.TabIndex = 19;
            labelShift.Text = "Shift:";
            labelShift.ThemeAuthor = "Narwin";
            labelShift.ThemeName = "MetroLite";
            // 
            // comboBoxShift
            // 
            comboBoxShift.AllowDrop = true;
            comboBoxShift.ArrowColor = Color.FromArgb(150, 150, 150);
            comboBoxShift.BackColor = Color.Transparent;
            comboBoxShift.BackgroundColor = Color.FromArgb(238, 238, 238);
            comboBoxShift.BorderColor = Color.FromArgb(150, 150, 150);
            comboBoxShift.CausesValidation = false;
            comboBoxShift.DisabledBackColor = Color.FromArgb(204, 204, 204);
            comboBoxShift.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            comboBoxShift.DisabledForeColor = Color.FromArgb(136, 136, 136);
            comboBoxShift.DrawMode = DrawMode.OwnerDrawFixed;
            comboBoxShift.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxShift.Enabled = false;
            comboBoxShift.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxShift.FormattingEnabled = true;
            comboBoxShift.IsDerivedStyle = true;
            comboBoxShift.ItemHeight = 20;
            comboBoxShift.Location = new Point(767, 155);
            comboBoxShift.Name = "comboBoxShift";
            comboBoxShift.SelectedItemBackColor = Color.FromArgb(65, 177, 225);
            comboBoxShift.SelectedItemForeColor = Color.White;
            comboBoxShift.Size = new Size(44, 26);
            comboBoxShift.Style = MetroSet_UI.Enums.Style.Light;
            comboBoxShift.StyleManager = null;
            comboBoxShift.TabIndex = 20;
            comboBoxShift.ThemeAuthor = "Narwin";
            comboBoxShift.ThemeName = "MetroLite";
            comboBoxShift.SelectedIndexChanged += comboBoxShift_SelectedIndexChanged;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.IsDerivedStyle = true;
            labelName.Location = new Point(838, 155);
            labelName.Name = "labelName";
            labelName.Size = new Size(58, 20);
            labelName.Style = MetroSet_UI.Enums.Style.Light;
            labelName.StyleManager = null;
            labelName.TabIndex = 21;
            labelName.Text = "Name:";
            labelName.ThemeAuthor = "Narwin";
            labelName.ThemeName = "MetroLite";
            // 
            // comboBoxName
            // 
            comboBoxName.AllowDrop = true;
            comboBoxName.ArrowColor = Color.FromArgb(150, 150, 150);
            comboBoxName.BackColor = Color.Transparent;
            comboBoxName.BackgroundColor = Color.FromArgb(238, 238, 238);
            comboBoxName.BorderColor = Color.FromArgb(150, 150, 150);
            comboBoxName.CausesValidation = false;
            comboBoxName.DisabledBackColor = Color.FromArgb(204, 204, 204);
            comboBoxName.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            comboBoxName.DisabledForeColor = Color.FromArgb(136, 136, 136);
            comboBoxName.DrawMode = DrawMode.OwnerDrawFixed;
            comboBoxName.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxName.Enabled = false;
            comboBoxName.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxName.FormattingEnabled = true;
            comboBoxName.IsDerivedStyle = true;
            comboBoxName.ItemHeight = 20;
            comboBoxName.Location = new Point(902, 155);
            comboBoxName.Name = "comboBoxName";
            comboBoxName.SelectedItemBackColor = Color.FromArgb(65, 177, 225);
            comboBoxName.SelectedItemForeColor = Color.White;
            comboBoxName.Size = new Size(169, 26);
            comboBoxName.Style = MetroSet_UI.Enums.Style.Light;
            comboBoxName.StyleManager = null;
            comboBoxName.TabIndex = 22;
            comboBoxName.ThemeAuthor = "Narwin";
            comboBoxName.ThemeName = "MetroLite";
            comboBoxName.SelectedIndexChanged += comboBoxName_SelectedIndexChanged;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1319, 357);
            Controls.Add(comboBoxName);
            Controls.Add(labelName);
            Controls.Add(comboBoxShift);
            Controls.Add(labelShift);
            Controls.Add(comboBoxDay);
            Controls.Add(labelDay);
            Controls.Add(saveDataBtn);
            Controls.Add(sortBtn);
            Controls.Add(logoutBtn);
            Controls.Add(plusAccountBtn);
            Controls.Add(newPassword);
            Controls.Add(newUsername);
            Controls.Add(txtNewPassword);
            Controls.Add(txtNewUsername);
            Controls.Add(metroSetLabel1);
            Controls.Add(metroSetControlBox1);
            Name = "AdminForm";
            Text = "System Scheduling Management";
            Load += AdminForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetLabel newPassword;
        private MetroSet_UI.Controls.MetroSetLabel newUsername;
        private TextBox txtNewPassword;
        private TextBox txtNewUsername;
        private MetroSet_UI.Controls.MetroSetButton plusAccountBtn;
        private MetroSet_UI.Controls.MetroSetButton logoutBtn;
        private MetroSet_UI.Controls.MetroSetButton sortBtn;
        private MetroSet_UI.Controls.MetroSetButton saveDataBtn;
        private MetroSet_UI.Controls.MetroSetLabel labelDay;
        private MetroSet_UI.Controls.MetroSetComboBox comboBoxDay;
        private MetroSet_UI.Controls.MetroSetLabel labelShift;
        private MetroSet_UI.Controls.MetroSetComboBox comboBoxShift;
        private MetroSet_UI.Controls.MetroSetLabel labelName;
        private MetroSet_UI.Controls.MetroSetComboBox comboBoxName;
    }
}