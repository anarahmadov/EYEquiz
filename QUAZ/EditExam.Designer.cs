namespace QUAZ
{
    partial class EditExam
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
            this.btnPreviuos = new MetroFramework.Controls.MetroButton();
            this.btnAddQuestion = new MetroFramework.Controls.MetroButton();
            this.btnNext = new MetroFramework.Controls.MetroButton();
            this.txtboxQuestionText = new MetroFramework.Controls.MetroTextBox();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.allRadiobuttons = new System.Windows.Forms.FlowLayoutPanel();
            this.allTextbox = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnRemoveQuestion = new MetroFramework.Controls.MetroButton();
            this.btnSaveAs = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnPreviuos
            // 
            this.btnPreviuos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btnPreviuos.ForeColor = System.Drawing.Color.DarkGray;
            this.btnPreviuos.Location = new System.Drawing.Point(156, 361);
            this.btnPreviuos.Name = "btnPreviuos";
            this.btnPreviuos.Size = new System.Drawing.Size(116, 41);
            this.btnPreviuos.TabIndex = 0;
            this.btnPreviuos.TabStop = false;
            this.btnPreviuos.Text = "Previuos";
            this.btnPreviuos.UseCustomBackColor = true;
            this.btnPreviuos.UseCustomForeColor = true;
            this.btnPreviuos.UseSelectable = true;
            this.btnPreviuos.Click += new System.EventHandler(this.btnPrevius_Click);
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnAddQuestion.ForeColor = System.Drawing.Color.DarkGray;
            this.btnAddQuestion.Location = new System.Drawing.Point(13, 346);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(116, 35);
            this.btnAddQuestion.TabIndex = 0;
            this.btnAddQuestion.TabStop = false;
            this.btnAddQuestion.Text = "Add new test";
            this.btnAddQuestion.UseCustomBackColor = true;
            this.btnAddQuestion.UseCustomForeColor = true;
            this.btnAddQuestion.UseSelectable = true;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btnNext.ForeColor = System.Drawing.Color.DarkGray;
            this.btnNext.Location = new System.Drawing.Point(314, 361);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(116, 41);
            this.btnNext.TabIndex = 0;
            this.btnNext.TabStop = false;
            this.btnNext.Text = "Next";
            this.btnNext.UseCustomBackColor = true;
            this.btnNext.UseCustomForeColor = true;
            this.btnNext.UseSelectable = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtboxQuestionText
            // 
            // 
            // 
            // 
            this.txtboxQuestionText.CustomButton.Image = null;
            this.txtboxQuestionText.CustomButton.Location = new System.Drawing.Point(652, 2);
            this.txtboxQuestionText.CustomButton.Name = "";
            this.txtboxQuestionText.CustomButton.Size = new System.Drawing.Size(95, 95);
            this.txtboxQuestionText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtboxQuestionText.CustomButton.TabIndex = 1;
            this.txtboxQuestionText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtboxQuestionText.CustomButton.UseSelectable = true;
            this.txtboxQuestionText.CustomButton.Visible = false;
            this.txtboxQuestionText.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtboxQuestionText.ForeColor = System.Drawing.Color.White;
            this.txtboxQuestionText.Lines = new string[0];
            this.txtboxQuestionText.Location = new System.Drawing.Point(27, 13);
            this.txtboxQuestionText.MaxLength = 32767;
            this.txtboxQuestionText.Multiline = true;
            this.txtboxQuestionText.Name = "txtboxQuestionText";
            this.txtboxQuestionText.PasswordChar = '\0';
            this.txtboxQuestionText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtboxQuestionText.SelectedText = "";
            this.txtboxQuestionText.SelectionLength = 0;
            this.txtboxQuestionText.SelectionStart = 0;
            this.txtboxQuestionText.ShortcutsEnabled = true;
            this.txtboxQuestionText.Size = new System.Drawing.Size(750, 100);
            this.txtboxQuestionText.Style = MetroFramework.MetroColorStyle.Silver;
            this.txtboxQuestionText.TabIndex = 1;
            this.txtboxQuestionText.TabStop = false;
            this.txtboxQuestionText.UseCustomBackColor = true;
            this.txtboxQuestionText.UseCustomForeColor = true;
            this.txtboxQuestionText.UseSelectable = true;
            this.txtboxQuestionText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtboxQuestionText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnBack.ForeColor = System.Drawing.Color.DarkGray;
            this.btnBack.Location = new System.Drawing.Point(606, 371);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(153, 52);
            this.btnBack.TabIndex = 0;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "BACK";
            this.btnBack.UseCustomBackColor = true;
            this.btnBack.UseCustomForeColor = true;
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // allRadiobuttons
            // 
            this.allRadiobuttons.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.allRadiobuttons.Location = new System.Drawing.Point(13, 136);
            this.allRadiobuttons.Name = "allRadiobuttons";
            this.allRadiobuttons.Size = new System.Drawing.Size(20, 188);
            this.allRadiobuttons.TabIndex = 2;
            // 
            // allTextbox
            // 
            this.allTextbox.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.allTextbox.Location = new System.Drawing.Point(45, 136);
            this.allTextbox.Name = "allTextbox";
            this.allTextbox.Size = new System.Drawing.Size(725, 188);
            this.allTextbox.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnSave.ForeColor = System.Drawing.Color.DarkGray;
            this.btnSave.Location = new System.Drawing.Point(474, 331);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 92);
            this.btnSave.TabIndex = 0;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Save";
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseCustomForeColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRemoveQuestion
            // 
            this.btnRemoveQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnRemoveQuestion.ForeColor = System.Drawing.Color.DarkGray;
            this.btnRemoveQuestion.Location = new System.Drawing.Point(13, 387);
            this.btnRemoveQuestion.Name = "btnRemoveQuestion";
            this.btnRemoveQuestion.Size = new System.Drawing.Size(116, 35);
            this.btnRemoveQuestion.TabIndex = 0;
            this.btnRemoveQuestion.TabStop = false;
            this.btnRemoveQuestion.Text = "Remove test";
            this.btnRemoveQuestion.UseCustomBackColor = true;
            this.btnRemoveQuestion.UseCustomForeColor = true;
            this.btnRemoveQuestion.UseSelectable = true;
            this.btnRemoveQuestion.Click += new System.EventHandler(this.btnRemoveQuestion_Click);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnSaveAs.ForeColor = System.Drawing.Color.DarkGray;
            this.btnSaveAs.Location = new System.Drawing.Point(606, 330);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(153, 35);
            this.btnSaveAs.TabIndex = 0;
            this.btnSaveAs.TabStop = false;
            this.btnSaveAs.Text = "Save as";
            this.btnSaveAs.UseCustomBackColor = true;
            this.btnSaveAs.UseCustomForeColor = true;
            this.btnSaveAs.UseSelectable = true;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // EditExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.Controls.Add(this.allTextbox);
            this.Controls.Add(this.allRadiobuttons);
            this.Controls.Add(this.txtboxQuestionText);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSaveAs);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRemoveQuestion);
            this.Controls.Add(this.btnAddQuestion);
            this.Controls.Add(this.btnPreviuos);
            this.Name = "EditExam";
            this.Size = new System.Drawing.Size(800, 426);
            this.Load += new System.EventHandler(this.EditExam_Load);
            this.VisibleChanged += new System.EventHandler(this.EditExam_VisibleChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnPreviuos;
        private MetroFramework.Controls.MetroButton btnAddQuestion;
        private MetroFramework.Controls.MetroButton btnNext;
        private MetroFramework.Controls.MetroTextBox txtboxQuestionText;
        private MetroFramework.Controls.MetroButton btnBack;
        private System.Windows.Forms.FlowLayoutPanel allRadiobuttons;
        private System.Windows.Forms.FlowLayoutPanel allTextbox;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnRemoveQuestion;
        private MetroFramework.Controls.MetroButton btnSaveAs;
    }
}
