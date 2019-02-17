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
            this.txtboxLEmail = new MetroFramework.Controls.MetroTextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.txtboxLPassword = new MetroFramework.Controls.MetroTextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.txtboxRPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtboxREmail = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxRePassword = new MetroFramework.Controls.MetroTextBox();
            this.btnRegister = new MetroFramework.Controls.MetroButton();
            this.txtboxFullName = new MetroFramework.Controls.MetroTextBox();
            this.labelFullName = new System.Windows.Forms.Label();
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
            this.btnLogIn.TabIndex = 3;
            this.btnLogIn.Text = "Log in";
            this.btnLogIn.UseCustomBackColor = true;
            this.btnLogIn.UseCustomForeColor = true;
            this.btnLogIn.UseSelectable = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // txtboxLEmail
            // 
            // 
            // 
            // 
            this.txtboxLEmail.CustomButton.Image = null;
            this.txtboxLEmail.CustomButton.Location = new System.Drawing.Point(226, 1);
            this.txtboxLEmail.CustomButton.Name = "";
            this.txtboxLEmail.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtboxLEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtboxLEmail.CustomButton.TabIndex = 1;
            this.txtboxLEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtboxLEmail.CustomButton.UseSelectable = true;
            this.txtboxLEmail.CustomButton.Visible = false;
            this.txtboxLEmail.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtboxLEmail.ForeColor = System.Drawing.Color.White;
            this.txtboxLEmail.Lines = new string[0];
            this.txtboxLEmail.Location = new System.Drawing.Point(107, 12);
            this.txtboxLEmail.MaxLength = 32767;
            this.txtboxLEmail.Name = "txtboxLEmail";
            this.txtboxLEmail.PasswordChar = '\0';
            this.txtboxLEmail.PromptText = "E-mail";
            this.txtboxLEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtboxLEmail.SelectedText = "";
            this.txtboxLEmail.SelectionLength = 0;
            this.txtboxLEmail.SelectionStart = 0;
            this.txtboxLEmail.ShortcutsEnabled = true;
            this.txtboxLEmail.Size = new System.Drawing.Size(250, 25);
            this.txtboxLEmail.Style = MetroFramework.MetroColorStyle.White;
            this.txtboxLEmail.TabIndex = 1;
            this.txtboxLEmail.UseCustomBackColor = true;
            this.txtboxLEmail.UseCustomForeColor = true;
            this.txtboxLEmail.UseSelectable = true;
            this.txtboxLEmail.WaterMark = "E-mail";
            this.txtboxLEmail.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtboxLEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // txtboxLPassword
            // 
            // 
            // 
            // 
            this.txtboxLPassword.CustomButton.Image = null;
            this.txtboxLPassword.CustomButton.Location = new System.Drawing.Point(226, 1);
            this.txtboxLPassword.CustomButton.Name = "";
            this.txtboxLPassword.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtboxLPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtboxLPassword.CustomButton.TabIndex = 1;
            this.txtboxLPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtboxLPassword.CustomButton.UseSelectable = true;
            this.txtboxLPassword.CustomButton.Visible = false;
            this.txtboxLPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtboxLPassword.ForeColor = System.Drawing.Color.White;
            this.txtboxLPassword.Lines = new string[0];
            this.txtboxLPassword.Location = new System.Drawing.Point(363, 12);
            this.txtboxLPassword.MaxLength = 32767;
            this.txtboxLPassword.Name = "txtboxLPassword";
            this.txtboxLPassword.PasswordChar = '*';
            this.txtboxLPassword.PromptText = "Password";
            this.txtboxLPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtboxLPassword.SelectedText = "";
            this.txtboxLPassword.SelectionLength = 0;
            this.txtboxLPassword.SelectionStart = 0;
            this.txtboxLPassword.ShortcutsEnabled = true;
            this.txtboxLPassword.Size = new System.Drawing.Size(250, 25);
            this.txtboxLPassword.Style = MetroFramework.MetroColorStyle.White;
            this.txtboxLPassword.TabIndex = 2;
            this.txtboxLPassword.UseCustomBackColor = true;
            this.txtboxLPassword.UseCustomForeColor = true;
            this.txtboxLPassword.UseSelectable = true;
            this.txtboxLPassword.WaterMark = "Password";
            this.txtboxLPassword.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtboxLPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // labelEmail
            // 
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.DarkGray;
            this.labelEmail.Location = new System.Drawing.Point(162, 158);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(73, 23);
            this.labelEmail.TabIndex = 27;
            this.labelEmail.Text = "E-mail";
            this.labelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.txtboxRPassword.TabIndex = 6;
            this.txtboxRPassword.UseCustomBackColor = true;
            this.txtboxRPassword.UseCustomForeColor = true;
            this.txtboxRPassword.UseSelectable = true;
            this.txtboxRPassword.WaterMark = "Password";
            this.txtboxRPassword.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtboxRPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtboxREmail
            // 
            // 
            // 
            // 
            this.txtboxREmail.CustomButton.Image = null;
            this.txtboxREmail.CustomButton.Location = new System.Drawing.Point(226, 1);
            this.txtboxREmail.CustomButton.Name = "";
            this.txtboxREmail.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtboxREmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtboxREmail.CustomButton.TabIndex = 1;
            this.txtboxREmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtboxREmail.CustomButton.UseSelectable = true;
            this.txtboxREmail.CustomButton.Visible = false;
            this.txtboxREmail.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtboxREmail.ForeColor = System.Drawing.Color.White;
            this.txtboxREmail.Lines = new string[0];
            this.txtboxREmail.Location = new System.Drawing.Point(300, 158);
            this.txtboxREmail.MaxLength = 32767;
            this.txtboxREmail.Name = "txtboxREmail";
            this.txtboxREmail.PasswordChar = '\0';
            this.txtboxREmail.PromptText = "E-mail";
            this.txtboxREmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtboxREmail.SelectedText = "";
            this.txtboxREmail.SelectionLength = 0;
            this.txtboxREmail.SelectionStart = 0;
            this.txtboxREmail.ShortcutsEnabled = true;
            this.txtboxREmail.Size = new System.Drawing.Size(250, 25);
            this.txtboxREmail.Style = MetroFramework.MetroColorStyle.White;
            this.txtboxREmail.TabIndex = 5;
            this.txtboxREmail.UseCustomBackColor = true;
            this.txtboxREmail.UseCustomForeColor = true;
            this.txtboxREmail.UseSelectable = true;
            this.txtboxREmail.WaterMark = "E-mail";
            this.txtboxREmail.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtboxREmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.txtboxRePassword.TabIndex = 7;
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
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseCustomBackColor = true;
            this.btnRegister.UseCustomForeColor = true;
            this.btnRegister.UseSelectable = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtboxFullName
            // 
            // 
            // 
            // 
            this.txtboxFullName.CustomButton.Image = null;
            this.txtboxFullName.CustomButton.Location = new System.Drawing.Point(226, 1);
            this.txtboxFullName.CustomButton.Name = "";
            this.txtboxFullName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtboxFullName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtboxFullName.CustomButton.TabIndex = 1;
            this.txtboxFullName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtboxFullName.CustomButton.UseSelectable = true;
            this.txtboxFullName.CustomButton.Visible = false;
            this.txtboxFullName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtboxFullName.ForeColor = System.Drawing.Color.White;
            this.txtboxFullName.Lines = new string[0];
            this.txtboxFullName.Location = new System.Drawing.Point(300, 116);
            this.txtboxFullName.MaxLength = 32767;
            this.txtboxFullName.Name = "txtboxFullName";
            this.txtboxFullName.PasswordChar = '\0';
            this.txtboxFullName.PromptText = "Full name";
            this.txtboxFullName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtboxFullName.SelectedText = "";
            this.txtboxFullName.SelectionLength = 0;
            this.txtboxFullName.SelectionStart = 0;
            this.txtboxFullName.ShortcutsEnabled = true;
            this.txtboxFullName.Size = new System.Drawing.Size(250, 25);
            this.txtboxFullName.Style = MetroFramework.MetroColorStyle.White;
            this.txtboxFullName.TabIndex = 4;
            this.txtboxFullName.UseCustomBackColor = true;
            this.txtboxFullName.UseCustomForeColor = true;
            this.txtboxFullName.UseSelectable = true;
            this.txtboxFullName.WaterMark = "Full name";
            this.txtboxFullName.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtboxFullName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // labelFullName
            // 
            this.labelFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFullName.ForeColor = System.Drawing.Color.DarkGray;
            this.labelFullName.Location = new System.Drawing.Point(162, 116);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(73, 23);
            this.labelFullName.TabIndex = 27;
            this.labelFullName.Text = "Full Name";
            this.labelFullName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.txtboxFullName);
            this.Controls.Add(this.txtboxREmail);
            this.Controls.Add(this.txtboxLEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.txtboxRePassword);
            this.Controls.Add(this.txtboxRPassword);
            this.Controls.Add(this.txtboxLPassword);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.labelEmail);
            this.Name = "LogIn";
            this.Size = new System.Drawing.Size(800, 426);
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnLogIn;
        private MetroFramework.Controls.MetroTextBox txtboxLEmail;
        private System.Windows.Forms.Label labelPassword;
        private MetroFramework.Controls.MetroTextBox txtboxLPassword;
        private System.Windows.Forms.Label labelEmail;
        private MetroFramework.Controls.MetroTextBox txtboxRPassword;
        private MetroFramework.Controls.MetroTextBox txtboxREmail;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txtboxRePassword;
        private MetroFramework.Controls.MetroButton btnRegister;
        private MetroFramework.Controls.MetroTextBox txtboxFullName;
        private System.Windows.Forms.Label labelFullName;
    }
}
