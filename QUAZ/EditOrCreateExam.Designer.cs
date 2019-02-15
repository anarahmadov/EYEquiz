namespace QUAZ
{
    partial class EditOrCreateExam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditOrCreateExam));
            this.listViewAllExams = new System.Windows.Forms.ListView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.btnEditExam = new MetroFramework.Controls.MetroButton();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.btnCreateExam = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // listViewAllExams
            // 
            this.listViewAllExams.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewAllExams.AllowDrop = true;
            this.listViewAllExams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.listViewAllExams.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listViewAllExams.BackgroundImage")));
            this.listViewAllExams.HideSelection = false;
            this.listViewAllExams.LargeImageList = this.imageList;
            this.listViewAllExams.Location = new System.Drawing.Point(22, 23);
            this.listViewAllExams.MultiSelect = false;
            this.listViewAllExams.Name = "listViewAllExams";
            this.listViewAllExams.Size = new System.Drawing.Size(756, 259);
            this.listViewAllExams.TabIndex = 0;
            this.listViewAllExams.UseCompatibleStateImageBehavior = false;
            this.listViewAllExams.SelectedIndexChanged += new System.EventHandler(this.listViewAllExams_SelectedIndexChanged);
            this.listViewAllExams.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewAllExams_DragDrop);
            this.listViewAllExams.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewAllExams_DragEnter);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.imageList.Images.SetKeyName(0, "xml.png");
            // 
            // btnEditExam
            // 
            this.btnEditExam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnEditExam.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnEditExam.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnEditExam.ForeColor = System.Drawing.Color.DarkGray;
            this.btnEditExam.Location = new System.Drawing.Point(31, 350);
            this.btnEditExam.Name = "btnEditExam";
            this.btnEditExam.Size = new System.Drawing.Size(178, 64);
            this.btnEditExam.TabIndex = 1;
            this.btnEditExam.TabStop = false;
            this.btnEditExam.Text = "Edit exam";
            this.btnEditExam.UseCustomBackColor = true;
            this.btnEditExam.UseCustomForeColor = true;
            this.btnEditExam.UseSelectable = true;
            this.btnEditExam.Click += new System.EventHandler(this.btnEditExam_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnBack.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnBack.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnBack.ForeColor = System.Drawing.Color.DarkGray;
            this.btnBack.Location = new System.Drawing.Point(249, 350);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(178, 64);
            this.btnBack.TabIndex = 1;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "BACK";
            this.btnBack.UseCustomBackColor = true;
            this.btnBack.UseCustomForeColor = true;
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCreateExam
            // 
            this.btnCreateExam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnCreateExam.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnCreateExam.ForeColor = System.Drawing.Color.DarkGray;
            this.btnCreateExam.Location = new System.Drawing.Point(600, 350);
            this.btnCreateExam.Name = "btnCreateExam";
            this.btnCreateExam.Size = new System.Drawing.Size(178, 64);
            this.btnCreateExam.TabIndex = 1;
            this.btnCreateExam.TabStop = false;
            this.btnCreateExam.Text = "Create new exam";
            this.btnCreateExam.UseCustomBackColor = true;
            this.btnCreateExam.UseCustomForeColor = true;
            this.btnCreateExam.UseSelectable = true;
            this.btnCreateExam.Click += new System.EventHandler(this.btnCreateExam_Click);
            // 
            // EditOrCreateExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCreateExam);
            this.Controls.Add(this.btnEditExam);
            this.Controls.Add(this.listViewAllExams);
            this.Name = "EditOrCreateExam";
            this.Size = new System.Drawing.Size(800, 426);
            this.Load += new System.EventHandler(this.EditOrCreateExam_Load);
            this.VisibleChanged += new System.EventHandler(this.EditOrCreateExam_VisibleChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewAllExams;
        private MetroFramework.Controls.MetroButton btnEditExam;
        private System.Windows.Forms.ImageList imageList;
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroButton btnCreateExam;
    }
}
