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
            this.SuspendLayout();
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnLogIn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnLogIn.Location = new System.Drawing.Point(328, 258);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(144, 51);
            this.btnLogIn.TabIndex = 28;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseSelectable = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // txtboxUsername
            // 
            // 
            // 
            // 
            this.txtboxUsername.CustomButton.Image = null;
            this.txtboxUsername.CustomButton.Location = new System.Drawing.Point(278, 1);
            this.txtboxUsername.CustomButton.Name = "";
            this.txtboxUsername.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtboxUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtboxUsername.CustomButton.TabIndex = 1;
            this.txtboxUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtboxUsername.CustomButton.UseSelectable = true;
            this.txtboxUsername.CustomButton.Visible = false;
            this.txtboxUsername.Lines = new string[0];
            this.txtboxUsername.Location = new System.Drawing.Point(259, 144);
            this.txtboxUsername.MaxLength = 32767;
            this.txtboxUsername.Name = "txtboxUsername";
            this.txtboxUsername.PasswordChar = '\0';
            this.txtboxUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtboxUsername.SelectedText = "";
            this.txtboxUsername.SelectionLength = 0;
            this.txtboxUsername.SelectionStart = 0;
            this.txtboxUsername.ShortcutsEnabled = true;
            this.txtboxUsername.Size = new System.Drawing.Size(300, 23);
            this.txtboxUsername.TabIndex = 24;
            this.txtboxUsername.TabStop = false;
            this.txtboxUsername.UseSelectable = true;
            this.txtboxUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtboxUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // labelPassword
            // 
            this.labelPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.labelPassword.Location = new System.Drawing.Point(169, 198);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(60, 23);
            this.labelPassword.TabIndex = 26;
            this.labelPassword.Text = "Password";
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtboxPassword
            // 
            // 
            // 
            // 
            this.txtboxPassword.CustomButton.Image = null;
            this.txtboxPassword.CustomButton.Location = new System.Drawing.Point(278, 1);
            this.txtboxPassword.CustomButton.Name = "";
            this.txtboxPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtboxPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtboxPassword.CustomButton.TabIndex = 1;
            this.txtboxPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtboxPassword.CustomButton.UseSelectable = true;
            this.txtboxPassword.CustomButton.Visible = false;
            this.txtboxPassword.Lines = new string[0];
            this.txtboxPassword.Location = new System.Drawing.Point(259, 198);
            this.txtboxPassword.MaxLength = 32767;
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.PasswordChar = '*';
            this.txtboxPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtboxPassword.SelectedText = "";
            this.txtboxPassword.SelectionLength = 0;
            this.txtboxPassword.SelectionStart = 0;
            this.txtboxPassword.ShortcutsEnabled = true;
            this.txtboxPassword.Size = new System.Drawing.Size(300, 23);
            this.txtboxPassword.TabIndex = 25;
            this.txtboxPassword.TabStop = false;
            this.txtboxPassword.UseSelectable = true;
            this.txtboxPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtboxPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // labelUsername
            // 
            this.labelUsername.ForeColor = System.Drawing.Color.DarkGray;
            this.labelUsername.Location = new System.Drawing.Point(169, 144);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(73, 23);
            this.labelUsername.TabIndex = 27;
            this.labelUsername.Text = "Username";
            this.labelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.txtboxUsername);
            this.Controls.Add(this.labelPassword);
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
    }
}
