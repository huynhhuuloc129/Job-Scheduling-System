namespace NienLuan1
{
    partial class UserUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            personalInformation = new MetroSet_UI.Controls.MetroSetLabel();
            nameLabel = new MetroSet_UI.Controls.MetroSetLabel();
            metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            txtFullname = new TextBox();
            txtDob = new TextBox();
            metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            saveBtn = new MetroSet_UI.Controls.MetroSetButton();
            metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            logoutBtn = new MetroSet_UI.Controls.MetroSetButton();
            createdAtLabel = new MetroSet_UI.Controls.MetroSetLabel();
            SuspendLayout();
            // 
            // personalInformation
            // 
            personalInformation.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            personalInformation.IsDerivedStyle = true;
            personalInformation.Location = new Point(15, 97);
            personalInformation.Name = "personalInformation";
            personalInformation.Size = new Size(166, 24);
            personalInformation.Style = MetroSet_UI.Enums.Style.Light;
            personalInformation.StyleManager = null;
            personalInformation.TabIndex = 0;
            personalInformation.Text = "Personal Information";
            personalInformation.ThemeAuthor = "Narwin";
            personalInformation.ThemeName = "MetroLite";
            // 
            // nameLabel
            // 
            nameLabel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.IsDerivedStyle = true;
            nameLabel.Location = new Point(15, 124);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(125, 29);
            nameLabel.Style = MetroSet_UI.Enums.Style.Light;
            nameLabel.StyleManager = null;
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Full name:";
            nameLabel.ThemeAuthor = "Narwin";
            nameLabel.ThemeName = "MetroLite";
            // 
            // metroSetLabel2
            // 
            metroSetLabel2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            metroSetLabel2.IsDerivedStyle = true;
            metroSetLabel2.Location = new Point(15, 161);
            metroSetLabel2.Name = "metroSetLabel2";
            metroSetLabel2.Size = new Size(103, 27);
            metroSetLabel2.Style = MetroSet_UI.Enums.Style.Light;
            metroSetLabel2.StyleManager = null;
            metroSetLabel2.TabIndex = 2;
            metroSetLabel2.Text = "Day of birth:";
            metroSetLabel2.ThemeAuthor = "Narwin";
            metroSetLabel2.ThemeName = "MetroLite";
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(124, 121);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(220, 32);
            txtFullname.TabIndex = 3;
            // 
            // txtDob
            // 
            txtDob.Location = new Point(124, 156);
            txtDob.Name = "txtDob";
            txtDob.Size = new Size(220, 32);
            txtDob.TabIndex = 4;
            // 
            // metroSetLabel3
            // 
            metroSetLabel3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            metroSetLabel3.IsDerivedStyle = true;
            metroSetLabel3.Location = new Point(395, 97);
            metroSetLabel3.Name = "metroSetLabel3";
            metroSetLabel3.Size = new Size(547, 24);
            metroSetLabel3.Style = MetroSet_UI.Enums.Style.Light;
            metroSetLabel3.StyleManager = null;
            metroSetLabel3.TabIndex = 5;
            metroSetLabel3.Text = "Monday   Tuesday   Wednesday   Thursday   Friday   Saturday   Sunday";
            metroSetLabel3.ThemeAuthor = "Narwin";
            metroSetLabel3.ThemeName = "MetroLite";
            // 
            // saveBtn
            // 
            saveBtn.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            saveBtn.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            saveBtn.DisabledForeColor = Color.Gray;
            saveBtn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            saveBtn.HoverBorderColor = Color.FromArgb(95, 207, 255);
            saveBtn.HoverColor = Color.FromArgb(95, 207, 255);
            saveBtn.HoverTextColor = Color.White;
            saveBtn.IsDerivedStyle = true;
            saveBtn.Location = new Point(250, 232);
            saveBtn.Name = "saveBtn";
            saveBtn.NormalBorderColor = Color.FromArgb(65, 177, 225);
            saveBtn.NormalColor = Color.FromArgb(65, 177, 225);
            saveBtn.NormalTextColor = Color.White;
            saveBtn.PressBorderColor = Color.FromArgb(35, 147, 195);
            saveBtn.PressColor = Color.FromArgb(35, 147, 195);
            saveBtn.PressTextColor = Color.White;
            saveBtn.Size = new Size(94, 29);
            saveBtn.Style = MetroSet_UI.Enums.Style.Light;
            saveBtn.StyleManager = null;
            saveBtn.TabIndex = 34;
            saveBtn.Text = "Save";
            saveBtn.ThemeAuthor = "Narwin";
            saveBtn.ThemeName = "MetroLite";
            saveBtn.Click += saveBtn_Click;
            // 
            // metroSetControlBox1
            // 
            metroSetControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            metroSetControlBox1.CloseHoverBackColor = Color.FromArgb(183, 40, 40);
            metroSetControlBox1.CloseHoverForeColor = Color.White;
            metroSetControlBox1.CloseNormalForeColor = Color.Gray;
            metroSetControlBox1.DisabledForeColor = Color.DimGray;
            metroSetControlBox1.IsDerivedStyle = true;
            metroSetControlBox1.Location = new Point(842, -1);
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
            metroSetControlBox1.TabIndex = 35;
            metroSetControlBox1.Text = "metroSetControlBox1";
            metroSetControlBox1.ThemeAuthor = "Narwin";
            metroSetControlBox1.ThemeName = "MetroLite";
            // 
            // logoutBtn
            // 
            logoutBtn.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            logoutBtn.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            logoutBtn.DisabledForeColor = Color.Gray;
            logoutBtn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            logoutBtn.HoverBorderColor = Color.FromArgb(95, 207, 255);
            logoutBtn.HoverColor = Color.FromArgb(95, 207, 255);
            logoutBtn.HoverTextColor = Color.White;
            logoutBtn.IsDerivedStyle = true;
            logoutBtn.Location = new Point(15, 232);
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
            logoutBtn.TabIndex = 36;
            logoutBtn.Text = "Logout";
            logoutBtn.ThemeAuthor = "Narwin";
            logoutBtn.ThemeName = "MetroLite";
            logoutBtn.Click += logoutBtn_Click;
            // 
            // createdAtLabel
            // 
            createdAtLabel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            createdAtLabel.IsDerivedStyle = true;
            createdAtLabel.Location = new Point(15, 200);
            createdAtLabel.Name = "createdAtLabel";
            createdAtLabel.Size = new Size(125, 29);
            createdAtLabel.Style = MetroSet_UI.Enums.Style.Light;
            createdAtLabel.StyleManager = null;
            createdAtLabel.TabIndex = 37;
            createdAtLabel.Text = "Created at: ";
            createdAtLabel.ThemeAuthor = "Narwin";
            createdAtLabel.ThemeName = "MetroLite";
            // 
            // UserUI
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 276);
            Controls.Add(createdAtLabel);
            Controls.Add(logoutBtn);
            Controls.Add(metroSetControlBox1);
            Controls.Add(saveBtn);
            Controls.Add(metroSetLabel3);
            Controls.Add(txtDob);
            Controls.Add(txtFullname);
            Controls.Add(metroSetLabel2);
            Controls.Add(nameLabel);
            Controls.Add(personalInformation);
            Name = "UserUI";
            Text = "System Scheduling Management";
            Load += UserUI_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MetroSet_UI.Controls.MetroSetLabel personalInformation;
        private MetroSet_UI.Controls.MetroSetLabel nameLabel;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private TextBox txtFullname;
        private TextBox txtDob;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private MetroSet_UI.Controls.MetroSetButton saveBtn;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private MetroSet_UI.Controls.MetroSetButton logoutBtn;
        private MetroSet_UI.Controls.MetroSetLabel createdAtLabel;
    }
}