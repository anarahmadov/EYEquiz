namespace QUAZ
{
    partial class CreateExam
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
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.answerCount = new MetroFramework.Controls.MetroTextBox();
            this.labelQuestionCount = new System.Windows.Forms.Label();
            this.labelQuestionTExt = new System.Windows.Forms.Label();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtboxQuestion
            // 
            this.txtboxQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.txtboxQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxQuestion.ForeColor = System.Drawing.Color.White;
            this.txtboxQuestion.Location = new System.Drawing.Point(29, 32);
            this.txtboxQuestion.Name = "txtboxQuestion";
            this.txtboxQuestion.Size = new System.Drawing.Size(742, 90);
            this.txtboxQuestion.TabIndex = 0;
            this.txtboxQuestion.Text = "";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnAdd.ForeColor = System.Drawing.Color.DarkGray;
            this.btnAdd.Location = new System.Drawing.Point(29, 371);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(151, 40);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseCustomBackColor = true;
            this.btnAdd.UseCustomForeColor = true;
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnBack.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnBack.ForeColor = System.Drawing.Color.DarkGray;
            this.btnBack.Location = new System.Drawing.Point(585, 358);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(199, 65);
            this.btnBack.TabIndex = 3;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "BACK";
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
            this.answerCount.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.answerCount.CustomButton.Name = "";
            this.answerCount.CustomButton.Size = new System.Drawing.Size(23, 23);
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
            this.answerCount.Style = MetroFramework.MetroColorStyle.White;
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
            this.labelQuestionCount.Text = "Question count";
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
            this.labelQuestionTExt.Text = "Question text";
            this.labelQuestionTExt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnSave.ForeColor = System.Drawing.Color.DarkGray;
            this.btnSave.Location = new System.Drawing.Point(202, 371);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(165, 40);
            this.btnSave.TabIndex = 1;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Save ";
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseCustomForeColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(343, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Question text";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CreateExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelQuestionTExt);
            this.Controls.Add(this.labelQuestionCount);
            this.Controls.Add(this.answerCount);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtboxQuestion);
            this.Name = "CreateExam";
            this.Size = new System.Drawing.Size(800, 426);
            this.Load += new System.EventHandler(this.CreateExam_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtboxQuestion;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroTextBox answerCount;
        private System.Windows.Forms.Label labelQuestionCount;
        private System.Windows.Forms.Label labelQuestionTExt;
        private MetroFramework.Controls.MetroButton btnSave;
        private System.Windows.Forms.Label label1;
    }
}
