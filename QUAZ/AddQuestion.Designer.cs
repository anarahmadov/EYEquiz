namespace QUAZ
{
    partial class AddQuestion
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
            this.txtboxQuestion = new System.Windows.Forms.RichTextBox();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.listboxQuestions = new System.Windows.Forms.ListBox();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.answerCount = new MetroFramework.Controls.MetroTextBox();
            this.labelQuestionCount = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // txtboxQuestion
            // 
            this.txtboxQuestion.Location = new System.Drawing.Point(29, 17);
            this.txtboxQuestion.Name = "txtboxQuestion";
            this.txtboxQuestion.Size = new System.Drawing.Size(448, 90);
            this.txtboxQuestion.TabIndex = 0;
            this.txtboxQuestion.Text = "";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(29, 360);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(448, 51);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // listboxQuestions
            // 
            this.listboxQuestions.FormattingEnabled = true;
            this.listboxQuestions.Location = new System.Drawing.Point(497, 17);
            this.listboxQuestions.Name = "listboxQuestions";
            this.listboxQuestions.Size = new System.Drawing.Size(289, 329);
            this.listboxQuestions.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(497, 360);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(289, 51);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // answerCount
            // 
            // 
            // 
            // 
            this.answerCount.CustomButton.Image = null;
            this.answerCount.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.answerCount.CustomButton.Name = "";
            this.answerCount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.answerCount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.answerCount.CustomButton.TabIndex = 1;
            this.answerCount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.answerCount.CustomButton.UseSelectable = true;
            this.answerCount.CustomButton.Visible = false;
            this.answerCount.Lines = new string[0];
            this.answerCount.Location = new System.Drawing.Point(175, 113);
            this.answerCount.MaxLength = 32767;
            this.answerCount.Name = "answerCount";
            this.answerCount.PasswordChar = '\0';
            this.answerCount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.answerCount.SelectedText = "";
            this.answerCount.SelectionLength = 0;
            this.answerCount.SelectionStart = 0;
            this.answerCount.ShortcutsEnabled = true;
            this.answerCount.Size = new System.Drawing.Size(200, 23);
            this.answerCount.TabIndex = 4;
            this.answerCount.UseSelectable = true;
            this.answerCount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.answerCount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.answerCount.TextChanged += new System.EventHandler(this.answerCount_TextChanged);
            // 
            // labelQuestionCount
            // 
            this.labelQuestionCount.AutoSize = true;
            this.labelQuestionCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelQuestionCount.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelQuestionCount.Location = new System.Drawing.Point(21, 117);
            this.labelQuestionCount.Name = "labelQuestionCount";
            this.labelQuestionCount.Size = new System.Drawing.Size(135, 19);
            this.labelQuestionCount.TabIndex = 5;
            this.labelQuestionCount.Text = "Enter Answer Count : ";
            this.labelQuestionCount.UseCustomBackColor = true;
            this.labelQuestionCount.UseCustomForeColor = true;
            // 
            // AddQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.Controls.Add(this.labelQuestionCount);
            this.Controls.Add(this.answerCount);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.listboxQuestions);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtboxQuestion);
            this.Name = "AddQuestion";
            this.Size = new System.Drawing.Size(800, 426);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtboxQuestion;
        private MetroFramework.Controls.MetroButton btnAdd;
        private System.Windows.Forms.ListBox listboxQuestions;
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroTextBox answerCount;
        private MetroFramework.Controls.MetroLabel labelQuestionCount;
    }
}
