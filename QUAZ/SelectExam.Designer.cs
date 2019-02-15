namespace QUAZ
{
    partial class SelectExam
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectExam));
            this.listViewAllQuestions = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateModified = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.label = new System.Windows.Forms.Label();
            this.txtboxQuestionCount = new MetroFramework.Controls.MetroTextBox();
            this.btnStart = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // listViewAllQuestions
            // 
            this.listViewAllQuestions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.listViewAllQuestions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.dateModified,
            this.size,
            this.type});
            this.listViewAllQuestions.HideSelection = false;
            this.listViewAllQuestions.LabelEdit = true;
            this.listViewAllQuestions.LargeImageList = this.imageList;
            this.listViewAllQuestions.Location = new System.Drawing.Point(21, 23);
            this.listViewAllQuestions.Name = "listViewAllQuestions";
            this.listViewAllQuestions.ShowItemToolTips = true;
            this.listViewAllQuestions.Size = new System.Drawing.Size(757, 335);
            this.listViewAllQuestions.TabIndex = 0;
            this.listViewAllQuestions.UseCompatibleStateImageBehavior = false;
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 195;
            // 
            // dateModified
            // 
            this.dateModified.Text = "Date modifed";
            this.dateModified.Width = 195;
            // 
            // size
            // 
            this.size.Text = "Size";
            this.size.Width = 195;
            // 
            // type
            // 
            this.type.Text = "Type";
            this.type.Width = 195;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "xml.png");
            // 
            // label
            // 
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.DarkGray;
            this.label.Location = new System.Drawing.Point(3, 390);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(100, 23);
            this.label.TabIndex = 1;
            this.label.Text = "Question count";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.txtboxQuestionCount.ForeColor = System.Drawing.Color.White;
            this.txtboxQuestionCount.Lines = new string[0];
            this.txtboxQuestionCount.Location = new System.Drawing.Point(106, 390);
            this.txtboxQuestionCount.MaxLength = 32767;
            this.txtboxQuestionCount.Name = "txtboxQuestionCount";
            this.txtboxQuestionCount.PasswordChar = '\0';
            this.txtboxQuestionCount.PromptText = "Question count";
            this.txtboxQuestionCount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtboxQuestionCount.SelectedText = "";
            this.txtboxQuestionCount.SelectionLength = 0;
            this.txtboxQuestionCount.SelectionStart = 0;
            this.txtboxQuestionCount.ShortcutsEnabled = true;
            this.txtboxQuestionCount.Size = new System.Drawing.Size(200, 23);
            this.txtboxQuestionCount.Style = MetroFramework.MetroColorStyle.White;
            this.txtboxQuestionCount.TabIndex = 2;
            this.txtboxQuestionCount.UseCustomBackColor = true;
            this.txtboxQuestionCount.UseCustomForeColor = true;
            this.txtboxQuestionCount.UseSelectable = true;
            this.txtboxQuestionCount.WaterMark = "Question count";
            this.txtboxQuestionCount.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtboxQuestionCount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnStart.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnStart.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnStart.ForeColor = System.Drawing.Color.DarkGray;
            this.btnStart.Location = new System.Drawing.Point(552, 374);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(226, 39);
            this.btnStart.TabIndex = 3;
            this.btnStart.TabStop = false;
            this.btnStart.Text = "Start exam";
            this.btnStart.UseCustomBackColor = true;
            this.btnStart.UseCustomForeColor = true;
            this.btnStart.UseSelectable = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // SelectExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtboxQuestionCount);
            this.Controls.Add(this.label);
            this.Controls.Add(this.listViewAllQuestions);
            this.Name = "SelectExam";
            this.Size = new System.Drawing.Size(800, 426);
            this.Load += new System.EventHandler(this.SelectExam_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewAllQuestions;
        private System.Windows.Forms.Label label;
        private MetroFramework.Controls.MetroTextBox txtboxQuestionCount;
        private MetroFramework.Controls.MetroButton btnStart;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader dateModified;
        private System.Windows.Forms.ColumnHeader size;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.ImageList imageList;
    }
}
