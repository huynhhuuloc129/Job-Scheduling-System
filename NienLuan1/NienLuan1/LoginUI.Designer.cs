namespace NienLuan1
{
    partial class LoginUI
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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            loginBtn = new MetroSet_UI.Controls.MetroSetButton();
            metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(192, 118);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(230, 32);
            txtUsername.TabIndex = 3;
            txtUsername.KeyDown += txtUsername_KeyDown;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(192, 162);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(230, 32);
            txtPassword.TabIndex = 4;
            txtPassword.KeyDown += txtPassword_KeyDown;
            // 
            // metroSetLabel1
            // 
            metroSetLabel1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            metroSetLabel1.IsDerivedStyle = true;
            metroSetLabel1.Location = new Point(92, 118);
            metroSetLabel1.Name = "metroSetLabel1";
            metroSetLabel1.Size = new Size(94, 32);
            metroSetLabel1.Style = MetroSet_UI.Enums.Style.Light;
            metroSetLabel1.StyleManager = null;
            metroSetLabel1.TabIndex = 6;
            metroSetLabel1.Text = "Username";
            metroSetLabel1.ThemeAuthor = "Narwin";
            metroSetLabel1.ThemeName = "MetroLite";
            // 
            // metroSetLabel2
            // 
            metroSetLabel2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            metroSetLabel2.IsDerivedStyle = true;
            metroSetLabel2.Location = new Point(92, 162);
            metroSetLabel2.Name = "metroSetLabel2";
            metroSetLabel2.Size = new Size(94, 32);
            metroSetLabel2.Style = MetroSet_UI.Enums.Style.Light;
            metroSetLabel2.StyleManager = null;
            metroSetLabel2.TabIndex = 7;
            metroSetLabel2.Text = "Password";
            metroSetLabel2.ThemeAuthor = "Narwin";
            metroSetLabel2.ThemeName = "MetroLite";
            // 
            // loginBtn
            // 
            loginBtn.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            loginBtn.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            loginBtn.DisabledForeColor = Color.Gray;
            loginBtn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            loginBtn.HoverBorderColor = Color.FromArgb(95, 207, 255);
            loginBtn.HoverColor = Color.FromArgb(95, 207, 255);
            loginBtn.HoverTextColor = Color.White;
            loginBtn.IsDerivedStyle = true;
            loginBtn.Location = new Point(214, 216);
            loginBtn.Name = "loginBtn";
            loginBtn.NormalBorderColor = Color.FromArgb(65, 177, 225);
            loginBtn.NormalColor = Color.FromArgb(65, 177, 225);
            loginBtn.NormalTextColor = Color.White;
            loginBtn.PressBorderColor = Color.FromArgb(35, 147, 195);
            loginBtn.PressColor = Color.FromArgb(35, 147, 195);
            loginBtn.PressTextColor = Color.White;
            loginBtn.Size = new Size(105, 37);
            loginBtn.Style = MetroSet_UI.Enums.Style.Light;
            loginBtn.StyleManager = null;
            loginBtn.TabIndex = 8;
            loginBtn.Text = "Login";
            loginBtn.ThemeAuthor = "Narwin";
            loginBtn.ThemeName = "MetroLite";
            loginBtn.Click += btnLogin_Click;
            // 
            // metroSetControlBox1
            // 
            metroSetControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            metroSetControlBox1.CloseHoverBackColor = Color.FromArgb(183, 40, 40);
            metroSetControlBox1.CloseHoverForeColor = Color.White;
            metroSetControlBox1.CloseNormalForeColor = Color.Gray;
            metroSetControlBox1.DisabledForeColor = Color.DimGray;
            metroSetControlBox1.IsDerivedStyle = true;
            metroSetControlBox1.Location = new Point(429, 0);
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
            metroSetControlBox1.TabIndex = 9;
            metroSetControlBox1.Text = "metroSetControlBox1";
            metroSetControlBox1.ThemeAuthor = "Narwin";
            metroSetControlBox1.ThemeName = "MetroLite";
            // 
            // LoginUI
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(76, 66, 140);
            ClientSize = new Size(544, 297);
            Controls.Add(metroSetControlBox1);
            Controls.Add(loginBtn);
            Controls.Add(metroSetLabel2);
            Controls.Add(metroSetLabel1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "LoginUI";
            Text = "System Scheduling Management";
            Load += LoginUI_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUsername;
        private TextBox txtPassword;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetButton loginBtn;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
    }
}