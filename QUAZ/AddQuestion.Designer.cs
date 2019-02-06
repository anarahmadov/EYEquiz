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
            this.SuspendLayout();
            // 
            // txtboxQuestion
            // 
            this.txtboxQuestion.Location = new System.Drawing.Point(29, 17);
            this.txtboxQuestion.Name = "txtboxQuestion";
            this.txtboxQuestion.Size = new System.Drawing.Size(448, 329);
            this.txtboxQuestion.TabIndex = 0;
            this.txtboxQuestion.Text = "";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(29, 359);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(448, 52);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseSelectable = true;
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
            // AddQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.listboxQuestions);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtboxQuestion);
            this.Name = "AddQuestion";
            this.Size = new System.Drawing.Size(800, 426);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtboxQuestion;
        private MetroFramework.Controls.MetroButton btnAdd;
        private System.Windows.Forms.ListBox listboxQuestions;
        private MetroFramework.Controls.MetroButton btnBack;
    }
}
