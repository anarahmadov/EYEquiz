namespace QUAZ
{
    partial class QuestionControl
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
            this.labelQuestion = new MetroFramework.Controls.MetroLabel();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // labelQuestion
            // 
            this.labelQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelQuestion.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelQuestion.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.labelQuestion.Location = new System.Drawing.Point(15, 57);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(702, 138);
            this.labelQuestion.TabIndex = 13;
            this.labelQuestion.UseCustomBackColor = true;
            this.labelQuestion.UseCustomForeColor = true;
            this.labelQuestion.WrapToLine = true;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel.Location = new System.Drawing.Point(15, 230);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(750, 142);
            this.flowLayoutPanel.TabIndex = 15;
            // 
            // QuestionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.labelQuestion);
            this.Name = "QuestionControl";
            this.Size = new System.Drawing.Size(766, 409);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLabel labelQuestion;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
    }
}
