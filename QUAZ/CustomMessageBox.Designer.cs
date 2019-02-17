namespace QUAZ
{
    partial class CustomMessageBox
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
            this.btnOk = new MetroFramework.Controls.MetroButton();
            this.labelMessageText = new MetroFramework.Controls.MetroLabel();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Black;
            this.topPanel.Controls.Add(this.labelMessageTitle);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.HorizontalScrollbarBarColor = true;
            this.topPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.topPanel.HorizontalScrollbarSize = 10;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(234, 26);
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
            this.labelMessageTitle.AutoSize = true;
            this.labelMessageTitle.FontSize = MetroFramework.MetroLabelSize.Small;
            this.labelMessageTitle.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelMessageTitle.ForeColor = System.Drawing.Color.DarkGray;
            this.labelMessageTitle.Location = new System.Drawing.Point(3, 7);
            this.labelMessageTitle.Name = "labelMessageTitle";
            this.labelMessageTitle.Size = new System.Drawing.Size(0, 0);
            this.labelMessageTitle.TabIndex = 2;
            this.labelMessageTitle.UseCustomBackColor = true;
            this.labelMessageTitle.UseCustomForeColor = true;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.ForeColor = System.Drawing.Color.DarkGray;
            this.btnOk.Location = new System.Drawing.Point(80, 88);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.TabStop = false;
            this.btnOk.Text = "OK";
            this.btnOk.UseCustomBackColor = true;
            this.btnOk.UseCustomForeColor = true;
            this.btnOk.UseSelectable = true;
            this.btnOk.Visible = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // labelMessageText
            // 
            this.labelMessageText.ForeColor = System.Drawing.Color.DarkGray;
            this.labelMessageText.Location = new System.Drawing.Point(12, 38);
            this.labelMessageText.Name = "labelMessageText";
            this.labelMessageText.Size = new System.Drawing.Size(210, 36);
            this.labelMessageText.TabIndex = 2;
            this.labelMessageText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMessageText.UseCustomBackColor = true;
            this.labelMessageText.UseCustomForeColor = true;
            this.labelMessageText.WrapToLine = true;
            // 
            // CustomMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(234, 114);
            this.ControlBox = false;
            this.Controls.Add(this.labelMessageText);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CustomMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel topPanel;
        private MetroFramework.Controls.MetroLabel labelMessageTitle;
        private MetroFramework.Controls.MetroButton btnOk;
        private MetroFramework.Controls.MetroLabel labelMessageText;
    }
}