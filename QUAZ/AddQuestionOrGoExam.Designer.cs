namespace QUAZ
{
    partial class AddQuestionOrGoExam
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
            this.btnAddQuestions = new MetroFramework.Controls.MetroButton();
            this.btnGoExam = new MetroFramework.Controls.MetroButton();
            this.btnLogOut = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnAddQuestions
            // 
            this.btnAddQuestions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnAddQuestions.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAddQuestions.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnAddQuestions.ForeColor = System.Drawing.Color.DarkGray;
            this.btnAddQuestions.Location = new System.Drawing.Point(248, 149);
            this.btnAddQuestions.Name = "btnAddQuestions";
            this.btnAddQuestions.Size = new System.Drawing.Size(304, 39);
            this.btnAddQuestions.TabIndex = 0;
            this.btnAddQuestions.Text = "Add Questions";
            this.btnAddQuestions.UseCustomBackColor = true;
            this.btnAddQuestions.UseCustomForeColor = true;
            this.btnAddQuestions.UseSelectable = true;
            this.btnAddQuestions.Click += new System.EventHandler(this.btnAddQuestions_Click);
            // 
            // btnGoExam
            // 
            this.btnGoExam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnGoExam.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnGoExam.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnGoExam.ForeColor = System.Drawing.Color.DarkGray;
            this.btnGoExam.Location = new System.Drawing.Point(248, 213);
            this.btnGoExam.Name = "btnGoExam";
            this.btnGoExam.Size = new System.Drawing.Size(304, 39);
            this.btnGoExam.TabIndex = 0;
            this.btnGoExam.Text = "Go exam";
            this.btnGoExam.UseCustomBackColor = true;
            this.btnGoExam.UseCustomForeColor = true;
            this.btnGoExam.UseSelectable = true;
            this.btnGoExam.Click += new System.EventHandler(this.btnGoExam_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnLogOut.ForeColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.Location = new System.Drawing.Point(323, 314);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(158, 62);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseCustomBackColor = true;
            this.btnLogOut.UseCustomForeColor = true;
            this.btnLogOut.UseSelectable = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // AddQuestionOrGoExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnGoExam);
            this.Controls.Add(this.btnAddQuestions);
            this.Name = "AddQuestionOrGoExam";
            this.Size = new System.Drawing.Size(800, 426);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnAddQuestions;
        private MetroFramework.Controls.MetroButton btnGoExam;
        private MetroFramework.Controls.MetroButton btnLogOut;
    }
}
