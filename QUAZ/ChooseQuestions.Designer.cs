namespace QUAZ
{
    partial class ChooseQuestions
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxQuestionCount = new MetroFramework.Controls.MetroTextBox();
            this.btnStart = new MetroFramework.Controls.MetroButton();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(21, 23);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(757, 335);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(22, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Question Count";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtboxQuestionCount
            // 
            // 
            // 
            // 
            this.txtboxQuestionCount.CustomButton.Image = null;
            this.txtboxQuestionCount.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtboxQuestionCount.CustomButton.Name = "";
            this.txtboxQuestionCount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtboxQuestionCount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtboxQuestionCount.CustomButton.TabIndex = 1;
            this.txtboxQuestionCount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtboxQuestionCount.CustomButton.UseSelectable = true;
            this.txtboxQuestionCount.CustomButton.Visible = false;
            this.txtboxQuestionCount.Lines = new string[0];
            this.txtboxQuestionCount.Location = new System.Drawing.Point(128, 390);
            this.txtboxQuestionCount.MaxLength = 32767;
            this.txtboxQuestionCount.Name = "txtboxQuestionCount";
            this.txtboxQuestionCount.PasswordChar = '\0';
            this.txtboxQuestionCount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtboxQuestionCount.SelectedText = "";
            this.txtboxQuestionCount.SelectionLength = 0;
            this.txtboxQuestionCount.SelectionStart = 0;
            this.txtboxQuestionCount.ShortcutsEnabled = true;
            this.txtboxQuestionCount.Size = new System.Drawing.Size(200, 23);
            this.txtboxQuestionCount.TabIndex = 2;
            this.txtboxQuestionCount.UseSelectable = true;
            this.txtboxQuestionCount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtboxQuestionCount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnStart
            // 
            this.btnStart.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnStart.Location = new System.Drawing.Point(562, 374);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(216, 39);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start exam";
            this.btnStart.UseSelectable = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(405, 374);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(113, 39);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ChooseQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtboxQuestionCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "ChooseQuestions";
            this.Size = new System.Drawing.Size(800, 426);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txtboxQuestionCount;
        private MetroFramework.Controls.MetroButton btnStart;
        private MetroFramework.Controls.MetroButton btnBack;
    }
}
