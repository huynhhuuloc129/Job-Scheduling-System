namespace NienLuan1
{
    partial class ShowShiftForm
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
            metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            usernameLabel = new MetroSet_UI.Controls.MetroSetLabel();
            Shift = new MetroSet_UI.Controls.MetroSetLabel();
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
            metroSetControlBox1.Location = new Point(604, 0);
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
            // usernameLabel
            // 
            usernameLabel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            usernameLabel.IsDerivedStyle = true;
            usernameLabel.Location = new Point(91, 52);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(356, 22);
            usernameLabel.Style = MetroSet_UI.Enums.Style.Light;
            usernameLabel.StyleManager = null;
            usernameLabel.TabIndex = 8;
            usernameLabel.Text = "Username: ";
            usernameLabel.ThemeAuthor = "Narwin";
            usernameLabel.ThemeName = "MetroLite";
            // 
            // Shift
            // 
            Shift.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Shift.IsDerivedStyle = true;
            Shift.Location = new Point(30, 92);
            Shift.Name = "Shift";
            Shift.Size = new Size(613, 33);
            Shift.Style = MetroSet_UI.Enums.Style.Light;
            Shift.StyleManager = null;
            Shift.TabIndex = 10;
            Shift.Text = "Shift   Monday   Tuesday   Wednesday   Thursday   Friday   Saturday   Sunday";
            Shift.ThemeAuthor = "Narwin";
            Shift.ThemeName = "MetroLite";
            // 
            // ShowShiftForm
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 234);
            Controls.Add(Shift);
            Controls.Add(usernameLabel);
            Controls.Add(metroSetControlBox1);
            Name = "ShowShiftForm";
            Text = "Shifts";
            Load += ShowShiftForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private MetroSet_UI.Controls.MetroSetLabel usernameLabel;
        private MetroSet_UI.Controls.MetroSetLabel Shift;
    }
}