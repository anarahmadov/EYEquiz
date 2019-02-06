namespace QUAZ
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.btnStart = new MetroFramework.Controls.MetroButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.numberOfQuestion = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelWelcome = new MetroFramework.Controls.MetroLabel();
            this.labelQuestionCount = new MetroFramework.Controls.MetroLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnExit = new MetroFramework.Controls.MetroButton();
            this.btnMinimize = new MetroFramework.Controls.MetroButton();
            this.topPanel = new MetroFramework.Controls.MetroPanel();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnStart.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnStart.Location = new System.Drawing.Point(233, 278);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(326, 71);
            this.btnStart.TabIndex = 12;
            this.btnStart.TabStop = false;
            this.btnStart.Text = "START QUIZ";
            this.btnStart.UseCustomBackColor = true;
            this.btnStart.UseCustomForeColor = true;
            this.btnStart.UseSelectable = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            this.btnStart.MouseEnter += new System.EventHandler(this.btnStart_MouseEnter);
            this.btnStart.MouseLeave += new System.EventHandler(this.btnStart_MouseLeave);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.Black;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numberOfQuestion});
            this.statusStrip.Location = new System.Drawing.Point(0, 478);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(801, 22);
            this.statusStrip.TabIndex = 14;
            // 
            // numberOfQuestion
            // 
            this.numberOfQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.numberOfQuestion.ForeColor = System.Drawing.Color.White;
            this.numberOfQuestion.Name = "numberOfQuestion";
            this.numberOfQuestion.Size = new System.Drawing.Size(0, 17);
            this.numberOfQuestion.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // labelWelcome
            // 
            this.labelWelcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelWelcome.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelWelcome.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.labelWelcome.ForeColor = System.Drawing.Color.DarkGray;
            this.labelWelcome.Location = new System.Drawing.Point(159, 116);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(490, 83);
            this.labelWelcome.TabIndex = 16;
            this.labelWelcome.Text = "Welcome to Quiz Azerbaijan";
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelWelcome.UseCustomBackColor = true;
            this.labelWelcome.UseCustomForeColor = true;
            // 
            // labelQuestionCount
            // 
            this.labelQuestionCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelQuestionCount.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelQuestionCount.Location = new System.Drawing.Point(310, 211);
            this.labelQuestionCount.Name = "labelQuestionCount";
            this.labelQuestionCount.Size = new System.Drawing.Size(174, 35);
            this.labelQuestionCount.TabIndex = 17;
            this.labelQuestionCount.Text = "Total question count :  20";
            this.labelQuestionCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelQuestionCount.UseCustomBackColor = true;
            this.labelQuestionCount.UseCustomForeColor = true;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnExit.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnExit.Location = new System.Drawing.Point(749, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(51, 43);
            this.btnExit.TabIndex = 18;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "X";
            this.btnExit.UseCustomBackColor = true;
            this.btnExit.UseCustomForeColor = true;
            this.btnExit.UseSelectable = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Black;
            this.btnMinimize.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnMinimize.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnMinimize.Location = new System.Drawing.Point(701, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(51, 43);
            this.btnMinimize.TabIndex = 19;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseCustomBackColor = true;
            this.btnMinimize.UseCustomForeColor = true;
            this.btnMinimize.UseSelectable = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // topPanel
            // 
            this.topPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.topPanel.BackColor = System.Drawing.Color.Black;
            this.topPanel.HorizontalScrollbarBarColor = true;
            this.topPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.topPanel.HorizontalScrollbarSize = 10;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(707, 43);
            this.topPanel.TabIndex = 20;
            this.topPanel.UseCustomBackColor = true;
            this.topPanel.VerticalScrollbarBarColor = true;
            this.topPanel.VerticalScrollbarHighlightOnWheel = false;
            this.topPanel.VerticalScrollbarSize = 10;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
            this.topPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(801, 500);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.labelQuestionCount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "QUAZ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnStart;
        private System.Windows.Forms.StatusStrip statusStrip;
        private MetroFramework.Controls.MetroLabel labelWelcome;
        private MetroFramework.Controls.MetroLabel labelQuestionCount;
        private System.Windows.Forms.ToolStripStatusLabel numberOfQuestion;
        private System.Windows.Forms.Timer timer;
        private MetroFramework.Controls.MetroButton btnExit;
        private MetroFramework.Controls.MetroButton btnMinimize;
        private MetroFramework.Controls.MetroPanel topPanel;
    }
}

