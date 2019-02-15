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
            this.txtboxRPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtboxRUsername = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxRePassword = new MetroFramework.Controls.MetroTextBox();
            this.btnRegister = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnLogIn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnLogIn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
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
            this.txtboxUsername.Style = MetroFramework.MetroColorStyle.White;
            this.txtboxUsername.TabIndex = 24;
            this.txtboxUsername.TabStop = false;
            this.txtboxUsername.UseCustomBackColor = true;
            this.txtboxUsername.UseCustomForeColor = true;
            this.txtboxUsername.UseSelectable = true;
            this.txtboxUsername.WaterMark = "Username";
            this.txtboxUsername.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtboxUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // labelPassword
            // 
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.labelPassword.Location = new System.Drawing.Point(152, 236);
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
            this.txtboxPassword.Style = MetroFramework.MetroColorStyle.White;
            this.txtboxPassword.TabIndex = 25;
            this.txtboxPassword.TabStop = false;
            this.txtboxPassword.UseCustomBackColor = true;
            this.txtboxPassword.UseCustomForeColor = true;
            this.txtboxPassword.UseSelectable = true;
            this.txtboxPassword.WaterMark = "Password";
            this.txtboxPassword.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtboxPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // labelUsername
            // 
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.DarkGray;
            this.labelUsername.Location = new System.Drawing.Point(162, 158);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(73, 23);
            this.labelUsername.TabIndex = 27;
            this.labelUsername.Text = "Username";
            this.labelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtboxRPassword
            // 
            // 
            // 
            // 
            this.txtboxRPassword.CustomButton.Image = null;
            this.txtboxRPassword.CustomButton.Location = new System.Drawing.Point(226, 1);
            this.txtboxRPassword.CustomButton.Name = "";
            this.txtboxRPassword.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtboxRPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtboxRPassword.CustomButton.TabIndex = 1;
            this.txtboxRPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtboxRPassword.CustomButton.UseSelectable = true;
            this.txtboxRPassword.CustomButton.Visible = false;
            this.txtboxRPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtboxRPassword.ForeColor = System.Drawing.Color.White;
            this.txtboxRPassword.Lines = new string[0];
            this.txtboxRPassword.Location = new System.Drawing.Point(300, 198);
            this.txtboxRPassword.MaxLength = 32767;
            this.txtboxRPassword.Name = "txtboxRPassword";
            this.txtboxRPassword.PasswordChar = '*';
            this.txtboxRPassword.PromptText = "Password";
            this.txtboxRPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtboxRPassword.SelectedText = "";
            this.txtboxRPassword.SelectionLength = 0;
            this.txtboxRPassword.SelectionStart = 0;
            this.txtboxRPassword.ShortcutsEnabled = true;
            this.txtboxRPassword.Size = new System.Drawing.Size(250, 25);
            this.txtboxRPassword.Style = MetroFramework.MetroColorStyle.White;
            this.txtboxRPassword.TabIndex = 25;
            this.txtboxRPassword.TabStop = false;
            this.txtboxRPassword.UseCustomBackColor = true;
            this.txtboxRPassword.UseCustomForeColor = true;
            this.txtboxRPassword.UseSelectable = true;
            this.txtboxRPassword.WaterMark = "Password";
            this.txtboxRPassword.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtboxRPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtboxRUsername
            // 
            // 
            // 
            // 
            this.txtboxRUsername.CustomButton.Image = null;
            this.txtboxRUsername.CustomButton.Location = new System.Drawing.Point(226, 1);
            this.txtboxRUsername.CustomButton.Name = "";
            this.txtboxRUsername.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtboxRUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtboxRUsername.CustomButton.TabIndex = 1;
            this.txtboxRUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtboxRUsername.CustomButton.UseSelectable = true;
            this.txtboxRUsername.CustomButton.Visible = false;
            this.txtboxRUsername.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtboxRUsername.ForeColor = System.Drawing.Color.White;
            this.txtboxRUsername.Lines = new string[0];
            this.txtboxRUsername.Location = new System.Drawing.Point(300, 158);
            this.txtboxRUsername.MaxLength = 32767;
            this.txtboxRUsername.Name = "txtboxRUsername";
            this.txtboxRUsername.PasswordChar = '\0';
            this.txtboxRUsername.PromptText = "Username";
            this.txtboxRUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtboxRUsername.SelectedText = "";
            this.txtboxRUsername.SelectionLength = 0;
            this.txtboxRUsername.SelectionStart = 0;
            this.txtboxRUsername.ShortcutsEnabled = true;
            this.txtboxRUsername.Size = new System.Drawing.Size(250, 25);
            this.txtboxRUsername.Style = MetroFramework.MetroColorStyle.White;
            this.txtboxRUsername.TabIndex = 24;
            this.txtboxRUsername.TabStop = false;
            this.txtboxRUsername.UseCustomBackColor = true;
            this.txtboxRUsername.UseCustomForeColor = true;
            this.txtboxRUsername.UseSelectable = true;
            this.txtboxRUsername.WaterMark = "Username";
            this.txtboxRUsername.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtboxRUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(162, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtboxRePassword
            // 
            // 
            // 
            // 
            this.txtboxRePassword.CustomButton.Image = null;
            this.txtboxRePassword.CustomButton.Location = new System.Drawing.Point(226, 1);
            this.txtboxRePassword.CustomButton.Name = "";
            this.txtboxRePassword.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtboxRePassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtboxRePassword.CustomButton.TabIndex = 1;
            this.txtboxRePassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtboxRePassword.CustomButton.UseSelectable = true;
            this.txtboxRePassword.CustomButton.Visible = false;
            this.txtboxRePassword.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtboxRePassword.ForeColor = System.Drawing.Color.White;
            this.txtboxRePassword.Lines = new string[0];
            this.txtboxRePassword.Location = new System.Drawing.Point(300, 236);
            this.txtboxRePassword.MaxLength = 32767;
            this.txtboxRePassword.Name = "txtboxRePassword";
            this.txtboxRePassword.PasswordChar = '*';
            this.txtboxRePassword.PromptText = "Re-Enter Password";
            this.txtboxRePassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtboxRePassword.SelectedText = "";
            this.txtboxRePassword.SelectionLength = 0;
            this.txtboxRePassword.SelectionStart = 0;
            this.txtboxRePassword.ShortcutsEnabled = true;
            this.txtboxRePassword.Size = new System.Drawing.Size(250, 25);
            this.txtboxRePassword.Style = MetroFramework.MetroColorStyle.White;
            this.txtboxRePassword.TabIndex = 25;
            this.txtboxRePassword.TabStop = false;
            this.txtboxRePassword.UseCustomBackColor = true;
            this.txtboxRePassword.UseCustomForeColor = true;
            this.txtboxRePassword.UseSelectable = true;
            this.txtboxRePassword.WaterMark = "Re-Enter Password";
            this.txtboxRePassword.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtboxRePassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnRegister.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnRegister.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnRegister.ForeColor = System.Drawing.Color.DarkGray;
            this.btnRegister.Location = new System.Drawing.Point(299, 293);
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
            this.Controls.Add(this.txtboxRUsername);
            this.Controls.Add(this.txtboxUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.txtboxRePassword);
            this.Controls.Add(this.txtboxRPassword);
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
        private MetroFramework.Controls.MetroTextBox txtboxRPassword;
        private MetroFramework.Controls.MetroTextBox txtboxRUsername;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txtboxRePassword;
        private MetroFramework.Controls.MetroButton btnRegister;
    }
}
