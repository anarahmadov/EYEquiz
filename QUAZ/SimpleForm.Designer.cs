namespace QUAZ
{
    partial class SimpleForm
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
            this.topPanel = new MetroFramework.Controls.MetroPanel();
            this.labelMessageTitle = new MetroFramework.Controls.MetroLabel();
            this.txtboxFileName = new MetroFramework.Controls.MetroTextBox();
            this.labelFileName = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnExit = new MetroFramework.Controls.MetroButton();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Black;
            this.topPanel.Controls.Add(this.labelMessageTitle);
            this.topPanel.HorizontalScrollbarBarColor = true;
            this.topPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.topPanel.HorizontalScrollbarSize = 10;
            this.topPanel.Location = new System.Drawing.Point(-3, -1);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(340, 24);
            this.topPanel.TabIndex = 0;
            this.topPanel.UseCustomBackColor = true;
            this.topPanel.VerticalScrollbarBarColor = true;
            this.topPanel.VerticalScrollbarHighlightOnWheel = false;
            this.topPanel.VerticalScrollbarSize = 10;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
            this.topPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseUp);
            // 
            // labelMessageTitle
            // 
            this.labelMessageTitle.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelMessageTitle.ForeColor = System.Drawing.Color.DarkGray;
            this.labelMessageTitle.Location = new System.Drawing.Point(3, 0);
            this.labelMessageTitle.Name = "labelMessageTitle";
            this.labelMessageTitle.Size = new System.Drawing.Size(75, 23);
            this.labelMessageTitle.TabIndex = 2;
            this.labelMessageTitle.Text = "Save as";
            this.labelMessageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelMessageTitle.UseCustomBackColor = true;
            this.labelMessageTitle.UseCustomForeColor = true;
            // 
            // txtboxFileName
            // 
            // 
            // 
            // 
            this.txtboxFileName.CustomButton.Image = null;
            this.txtboxFileName.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.txtboxFileName.CustomButton.Name = "";
            this.txtboxFileName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtboxFileName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtboxFileName.CustomButton.TabIndex = 1;
            this.txtboxFileName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtboxFileName.CustomButton.UseSelectable = true;
            this.txtboxFileName.CustomButton.Visible = false;
            this.txtboxFileName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtboxFileName.ForeColor = System.Drawing.Color.DarkGray;
            this.txtboxFileName.Lines = new string[0];
            this.txtboxFileName.Location = new System.Drawing.Point(93, 43);
            this.txtboxFileName.MaxLength = 32767;
            this.txtboxFileName.Name = "txtboxFileName";
            this.txtboxFileName.PasswordChar = '\0';
            this.txtboxFileName.PromptText = "File name";
            this.txtboxFileName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtboxFileName.SelectedText = "";
            this.txtboxFileName.SelectionLength = 0;
            this.txtboxFileName.SelectionStart = 0;
            this.txtboxFileName.ShortcutsEnabled = true;
            this.txtboxFileName.Size = new System.Drawing.Size(200, 25);
            this.txtboxFileName.Style = MetroFramework.MetroColorStyle.White;
            this.txtboxFileName.TabIndex = 1;
            this.txtboxFileName.UseCustomBackColor = true;
            this.txtboxFileName.UseCustomForeColor = true;
            this.txtboxFileName.UseSelectable = true;
            this.txtboxFileName.WaterMark = "File name";
            this.txtboxFileName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtboxFileName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // labelFileName
            // 
            this.labelFileName.ForeColor = System.Drawing.Color.DarkGray;
            this.labelFileName.Location = new System.Drawing.Point(12, 43);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(75, 25);
            this.labelFileName.TabIndex = 2;
            this.labelFileName.Text = "File name";
            this.labelFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelFileName.UseCustomBackColor = true;
            this.labelFileName.UseCustomForeColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.ForeColor = System.Drawing.Color.DarkGray;
            this.btnSave.Location = new System.Drawing.Point(130, 88);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseCustomForeColor = true;
            this.btnSave.UseSelectable = true;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.ForeColor = System.Drawing.Color.Silver;
            this.btnExit.Location = new System.Drawing.Point(333, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "X";
            this.btnExit.UseCustomBackColor = true;
            this.btnExit.UseCustomForeColor = true;
            this.btnExit.UseSelectable = true;
            // 
            // SimpleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(368, 123);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelFileName);
            this.Controls.Add(this.txtboxFileName);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "SimpleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel topPanel;
        private MetroFramework.Controls.MetroLabel labelMessageTitle;
        private MetroFramework.Controls.MetroTextBox txtboxFileName;
        private MetroFramework.Controls.MetroLabel labelFileName;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnExit;
    }
}