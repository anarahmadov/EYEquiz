namespace QUAZ
{
    partial class LogIn
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogIn = new MetroFramework.Controls.MetroButton();
            this.txtboxUsername = new MetroFramework.Controls.MetroTextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.txtboxPassword = new MetroFramework.Controls.MetroTextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.metroTextBox4 = new MetroFramework.Controls.MetroTextBox();
            this.btnRegister = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnLogIn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnLogIn.ForeColor = System.Drawing.Color.DarkGray;
            this.btnLogIn.Location = new System.Drawing.Point(635, 3);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(144, 37);
            this.btnLogIn.TabIndex = 28;
            this.btnLogIn.TabStop = false;
            this.btnLogIn.Text = "Log in";
            this.btnLogIn.UseCustomBackColor = true;
            this.btnLogIn.UseCustomForeColor = true;
            this.btnLogIn.UseSelectable = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // txtboxUsername
            // 
            // 
            // 
            // 
            this.txtboxUsername.CustomButton.Image = null;
            this.txtboxUsername.CustomButton.Location = new System.Drawing.Point(226, 1);
            this.txtboxUsername.CustomButton.Name = "";
            this.txtboxUsername.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtboxUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtboxUsername.CustomButton.TabIndex = 1;
            this.txtboxUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtboxUsername.CustomButton.UseSelectable = true;
            this.txtboxUsername.CustomButton.Visible = false;
            this.txtboxUsername.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtboxUsername.ForeColor = System.Drawing.Color.White;
            this.txtboxUsername.Lines = new string[0];
            this.txtboxUsername.Location = new System.Drawing.Point(107, 12);
            this.txtboxUsername.MaxLength = 32767;
            this.txtboxUsername.Name = "txtboxUsername";
            this.txtboxUsername.PasswordChar = '\0';
            this.txtboxUsername.PromptText = "Username";
            this.txtboxUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtboxUsername.SelectedText = "";
            this.txtboxUsername.SelectionLength = 0;
            this.txtboxUsername.SelectionStart = 0;
            this.txtboxUsername.ShortcutsEnabled = true;
            this.txtboxUsername.Size = new System.Drawing.Size(250, 25);
            this.txtboxUsername.TabIndex = 24;
            this.txtboxUsername.TabStop = false;
            this.txtboxUsername.UseCustomBackColor = true;
            this.txtboxUsername.UseCustomForeColor = true;
            this.txtboxUsername.UseSelectable = true;
            this.txtboxUsername.WaterMark = "Username";
            this.txtboxUsername.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtboxUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // labelPassword
            // 
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.labelPassword.Location = new System.Drawing.Point(148, 210);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(132, 23);
            this.labelPassword.TabIndex = 26;
            this.labelPassword.Text = "Re-Enter Password";
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtboxPassword
            // 
            // 
            // 
            // 
            this.txtboxPassword.CustomButton.Image = null;
            this.txtboxPassword.CustomButton.Location = new System.Drawing.Point(226, 1);
            this.txtboxPassword.CustomButton.Name = "";
            this.txtboxPassword.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtboxPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtboxPassword.CustomButton.TabIndex = 1;
            this.txtboxPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtboxPassword.CustomButton.UseSelectable = true;
            this.txtboxPassword.CustomButton.Visible = false;
            this.txtboxPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtboxPassword.ForeColor = System.Drawing.Color.White;
            this.txtboxPassword.Lines = new string[0];
            this.txtboxPassword.Location = new System.Drawing.Point(363, 12);
            this.txtboxPassword.MaxLength = 32767;
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.PasswordChar = '*';
            this.txtboxPassword.PromptText = "Password";
            this.txtboxPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtboxPassword.SelectedText = "";
            this.txtboxPassword.SelectionLength = 0;
            this.txtboxPassword.SelectionStart = 0;
            this.txtboxPassword.ShortcutsEnabled = true;
            this.txtboxPassword.Size = new System.Drawing.Size(250, 25);
            this.txtboxPassword.TabIndex = 25;
            this.txtboxPassword.TabStop = false;
            this.txtboxPassword.UseCustomBackColor = true;
            this.txtboxPassword.UseCustomForeColor = true;
            this.txtboxPassword.UseSelectable = true;
            this.txtboxPassword.WaterMark = "Password";
            this.txtboxPassword.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtboxPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // labelUsername
            // 
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.DarkGray;
            this.labelUsername.Location = new System.Drawing.Point(158, 132);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(73, 23);
            this.labelUsername.TabIndex = 27;
            this.labelUsername.Text = "Username";
            this.labelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(226, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox1.ForeColor = System.Drawing.Color.White;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(296, 172);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '*';
            this.metroTextBox1.PromptText = "Password";
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(250, 25);
            this.metroTextBox1.TabIndex = 25;
            this.metroTextBox1.TabStop = false;
            this.metroTextBox1.UseCustomBackColor = true;
            this.metroTextBox1.UseCustomForeColor = true;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMark = "Password";
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.Gray;
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox3
            // 
            // 
            // 
            // 
            this.metroTextBox3.CustomButton.Image = null;
            this.metroTextBox3.CustomButton.Location = new System.Drawing.Point(226, 1);
            this.metroTextBox3.CustomButton.Name = "";
            this.metroTextBox3.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.metroTextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox3.CustomButton.TabIndex = 1;
            this.metroTextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox3.CustomButton.UseSelectable = true;
            this.metroTextBox3.CustomButton.Visible = false;
            this.metroTextBox3.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox3.ForeColor = System.Drawing.Color.White;
            this.metroTextBox3.Lines = new string[0];
            this.metroTextBox3.Location = new System.Drawing.Point(296, 132);
            this.metroTextBox3.MaxLength = 32767;
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PasswordChar = '\0';
            this.metroTextBox3.PromptText = "Username";
            this.metroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox3.SelectedText = "";
            this.metroTextBox3.SelectionLength = 0;
            this.metroTextBox3.SelectionStart = 0;
            this.metroTextBox3.ShortcutsEnabled = true;
            this.metroTextBox3.Size = new System.Drawing.Size(250, 25);
            this.metroTextBox3.TabIndex = 24;
            this.metroTextBox3.TabStop = false;
            this.metroTextBox3.UseCustomBackColor = true;
            this.metroTextBox3.UseCustomForeColor = true;
            this.metroTextBox3.UseSelectable = true;
            this.metroTextBox3.WaterMark = "Username";
            this.metroTextBox3.WaterMarkColor = System.Drawing.Color.Gray;
            this.metroTextBox3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(158, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroTextBox4
            // 
            // 
            // 
            // 
            this.metroTextBox4.CustomButton.Image = null;
            this.metroTextBox4.CustomButton.Location = new System.Drawing.Point(226, 1);
            this.metroTextBox4.CustomButton.Name = "";
            this.metroTextBox4.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.metroTextBox4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox4.CustomButton.TabIndex = 1;
            this.metroTextBox4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox4.CustomButton.UseSelectable = true;
            this.metroTextBox4.CustomButton.Visible = false;
            this.metroTextBox4.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox4.ForeColor = System.Drawing.Color.White;
            this.metroTextBox4.Lines = new string[0];
            this.metroTextBox4.Location = new System.Drawing.Point(296, 210);
            this.metroTextBox4.MaxLength = 32767;
            this.metroTextBox4.Name = "metroTextBox4";
            this.metroTextBox4.PasswordChar = '*';
            this.metroTextBox4.PromptText = "Re-Enter Password";
            this.metroTextBox4.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox4.SelectedText = "";
            this.metroTextBox4.SelectionLength = 0;
            this.metroTextBox4.SelectionStart = 0;
            this.metroTextBox4.ShortcutsEnabled = true;
            this.metroTextBox4.Size = new System.Drawing.Size(250, 25);
            this.metroTextBox4.TabIndex = 25;
            this.metroTextBox4.TabStop = false;
            this.metroTextBox4.UseCustomBackColor = true;
            this.metroTextBox4.UseCustomForeColor = true;
            this.metroTextBox4.UseSelectable = true;
            this.metroTextBox4.WaterMark = "Re-Enter Password";
            this.metroTextBox4.WaterMarkColor = System.Drawing.Color.Gray;
            this.metroTextBox4.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnRegister.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnRegister.ForeColor = System.Drawing.Color.DarkGray;
            this.btnRegister.Location = new System.Drawing.Point(295, 267);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(251, 80);
            this.btnRegister.TabIndex = 29;
            this.btnRegister.TabStop = false;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseCustomBackColor = true;
            this.btnRegister.UseCustomForeColor = true;
            this.btnRegister.UseSelectable = true;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.metroTextBox3);
            this.Controls.Add(this.txtboxUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.metroTextBox4);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.txtboxPassword);
            this.Controls.Add(this.labelUsername);
            this.Name = "LogIn";
            this.Size = new System.Drawing.Size(800, 426);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnLogIn;
        private MetroFramework.Controls.MetroTextBox txtboxUsername;
        private System.Windows.Forms.Label labelPassword;
        private MetroFramework.Controls.MetroTextBox txtboxPassword;
        private System.Windows.Forms.Label labelUsername;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox metroTextBox4;
        private MetroFramework.Controls.MetroButton btnRegister;
    }
}
