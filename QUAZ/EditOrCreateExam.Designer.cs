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
            this.SuspendLayout();
            // 
            // listViewAllExams
            // 
            this.listViewAllExams.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewAllExams.AllowDrop = true;
            this.listViewAllExams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.listViewAllExams.HideSelection = false;
            this.listViewAllExams.Location = new System.Drawing.Point(22, 21);
            this.listViewAllExams.MultiSelect = false;
            this.listViewAllExams.Name = "listViewAllExams";
            this.listViewAllExams.Size = new System.Drawing.Size(756, 250);
            this.listViewAllExams.StateImageList = this.imageList;
            this.listViewAllExams.TabIndex = 0;
            this.listViewAllExams.UseCompatibleStateImageBehavior = false;
            this.listViewAllExams.View = System.Windows.Forms.View.SmallIcon;
            this.listViewAllExams.SelectedIndexChanged += new System.EventHandler(this.listViewAllExams_SelectedIndexChanged);
            this.listViewAllExams.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewAllExams_DragDrop);
            this.listViewAllExams.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewAllExams_DragEnter);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.imageList.Images.SetKeyName(0, "xmlicon.jpg");
            this.imageList.Images.SetKeyName(1, "iconxml.png");
            // 
            // btnEditExam
            // 
            this.btnEditExam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnEditExam.ForeColor = System.Drawing.Color.DarkGray;
            this.btnEditExam.Location = new System.Drawing.Point(84, 363);
            this.btnEditExam.Name = "btnEditExam";
            this.btnEditExam.Size = new System.Drawing.Size(159, 41);
            this.btnEditExam.TabIndex = 1;
            this.btnEditExam.Text = "Edit exam";
            this.btnEditExam.UseCustomBackColor = true;
            this.btnEditExam.UseCustomForeColor = true;
            this.btnEditExam.UseSelectable = true;
            this.btnEditExam.Click += new System.EventHandler(this.btnEditExam_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnBack.ForeColor = System.Drawing.Color.DarkGray;
            this.btnBack.Location = new System.Drawing.Point(600, 350);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(178, 64);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "BACK";
            this.btnBack.UseCustomBackColor = true;
            this.btnBack.UseCustomForeColor = true;
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // EditOrCreateExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnEditExam);
            this.Controls.Add(this.listViewAllExams);
            this.Name = "EditOrCreateExam";
            this.Size = new System.Drawing.Size(800, 426);
            this.Load += new System.EventHandler(this.EditOrCreateExam_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewAllExams;
        private MetroFramework.Controls.MetroButton btnEditExam;
        private System.Windows.Forms.ImageList imageList;
        private MetroFramework.Controls.MetroButton btnBack;
    }
}
