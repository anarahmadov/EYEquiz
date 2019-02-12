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
            this.labelQuestionCount = new System.Windows.Forms.Label();
            this.labelQuestionTExt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtboxQuestion
            // 
            this.txtboxQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.txtboxQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxQuestion.ForeColor = System.Drawing.Color.White;
            this.txtboxQuestion.Location = new System.Drawing.Point(29, 32);
            this.txtboxQuestion.Name = "txtboxQuestion";
            this.txtboxQuestion.Size = new System.Drawing.Size(448, 90);
            this.txtboxQuestion.TabIndex = 0;
            this.txtboxQuestion.Text = "";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnAdd.ForeColor = System.Drawing.Color.DarkGray;
            this.btnAdd.Location = new System.Drawing.Point(29, 360);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(448, 51);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseCustomBackColor = true;
            this.btnAdd.UseCustomForeColor = true;
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // listboxQuestions
            // 
            this.listboxQuestions.AllowDrop = true;
            this.listboxQuestions.BackColor = System.Drawing.Color.DarkGray;
            this.listboxQuestions.FormattingEnabled = true;
            this.listboxQuestions.Location = new System.Drawing.Point(497, 17);
            this.listboxQuestions.Name = "listboxQuestions";
            this.listboxQuestions.Size = new System.Drawing.Size(289, 329);
            this.listboxQuestions.TabIndex = 2;
            this.listboxQuestions.DragDrop += new System.Windows.Forms.DragEventHandler(this.listboxQuestions_DragDrop);
            this.listboxQuestions.DragEnter += new System.Windows.Forms.DragEventHandler(this.listboxQuestions_DragEnter);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnBack.ForeColor = System.Drawing.Color.DarkGray;
            this.btnBack.Location = new System.Drawing.Point(497, 360);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(289, 51);
            this.btnBack.TabIndex = 3;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "Back";
            this.btnBack.UseCustomBackColor = true;
            this.btnBack.UseCustomForeColor = true;
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // answerCount
            // 
            // 
            // 
            // 
            this.answerCount.CustomButton.Image = null;
            this.answerCount.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.answerCount.CustomButton.Name = "";
            this.answerCount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.answerCount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.answerCount.CustomButton.TabIndex = 1;
            this.answerCount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.answerCount.CustomButton.UseSelectable = true;
            this.answerCount.CustomButton.Visible = false;
            this.answerCount.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.answerCount.ForeColor = System.Drawing.Color.White;
            this.answerCount.Lines = new string[0];
            this.answerCount.Location = new System.Drawing.Point(29, 154);
            this.answerCount.MaxLength = 32767;
            this.answerCount.Name = "answerCount";
            this.answerCount.PasswordChar = '\0';
            this.answerCount.PromptText = "Anwers count";
            this.answerCount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.answerCount.SelectedText = "";
            this.answerCount.SelectionLength = 0;
            this.answerCount.SelectionStart = 0;
            this.answerCount.ShortcutsEnabled = true;
            this.answerCount.Size = new System.Drawing.Size(165, 25);
            this.answerCount.TabIndex = 4;
            this.answerCount.UseCustomBackColor = true;
            this.answerCount.UseCustomForeColor = true;
            this.answerCount.UseSelectable = true;
            this.answerCount.WaterMark = "Anwers count";
            this.answerCount.WaterMarkColor = System.Drawing.Color.Gray;
            this.answerCount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answerCount.TextChanged += new System.EventHandler(this.answerCount_TextChanged);
            // 
            // labelQuestionCount
            // 
            this.labelQuestionCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestionCount.ForeColor = System.Drawing.Color.DarkGray;
            this.labelQuestionCount.Location = new System.Drawing.Point(26, 128);
            this.labelQuestionCount.Name = "labelQuestionCount";
            this.labelQuestionCount.Size = new System.Drawing.Size(100, 23);
            this.labelQuestionCount.TabIndex = 5;
            this.labelQuestionCount.Text = "Question Count";
            this.labelQuestionCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelQuestionTExt
            // 
            this.labelQuestionTExt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestionTExt.ForeColor = System.Drawing.Color.DarkGray;
            this.labelQuestionTExt.Location = new System.Drawing.Point(26, 6);
            this.labelQuestionTExt.Name = "labelQuestionTExt";
            this.labelQuestionTExt.Size = new System.Drawing.Size(100, 23);
            this.labelQuestionTExt.TabIndex = 5;
            this.labelQuestionTExt.Text = "Question Text";
            this.labelQuestionTExt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.Controls.Add(this.labelQuestionTExt);
            this.Controls.Add(this.labelQuestionCount);
            this.Controls.Add(this.answerCount);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.listboxQuestions);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtboxQuestion);
            this.Name = "AddQuestion";
            this.Size = new System.Drawing.Size(800, 426);
            this.Load += new System.EventHandler(this.AddQuestion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtboxQuestion;
        private MetroFramework.Controls.MetroButton btnAdd;
        private System.Windows.Forms.ListBox listboxQuestions;
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroTextBox answerCount;
        private System.Windows.Forms.Label labelQuestionCount;
        private System.Windows.Forms.Label labelQuestionTExt;
    }
}
