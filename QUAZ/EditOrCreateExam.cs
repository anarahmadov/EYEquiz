﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QUAZ
{
    public partial class EditOrCreateExam : UserControl
    {
        MainForm MainForm;
        public string SelectedFileName { get; set; }
        public int a { get; set; } = 0;

        public EditOrCreateExam(MainForm mainForm)
        {
            MainForm = mainForm;
            InitializeComponent();
        }

        private void EditOrCreateExam_Load(object sender, EventArgs e)
        {
            List<string> paths = new List<string>();
            List<string> filesname = new List<string>();

            paths = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\EYEquiz").ToList<string>();

            for (int i = 0; i < paths.Count(); i++)
            {
                filesname.Add(paths[i].Split('\\').Last());
            }

            imageList.Images.Add(Image.FromFile("iconxml.png"));

            for (int i = 0; i < paths.Count(); i++)
            {
                listViewAllExams.Items.Add(filesname[i], 1);
                listViewAllExams.Items[i].ForeColor = Color.DarkGray;
                listViewAllExams.ShowItemToolTips = true;
            }
        }

        private void btnEditExam_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MainForm._EditExam = new EditExam(MainForm, this);
            MainForm._EditExam.Location = new Point(0, 70);
            MainForm.Controls.Add(MainForm._EditExam);
        }

        private void listViewAllExams_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAllExams.SelectedItems.Count != 0)
            {
                SelectedFileName = listViewAllExams.SelectedItems[0].Text;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MainForm._AddQuestionOrGoExam.Visible = true;
        }

        private void listViewAllExams_DragEnter(object sender, DragEventArgs e)
        {
            if ((e.Data.GetData(DataFormats.FileDrop) as string[])[0].Split('\\', '.').Last() == "xml")
                e.Effect = DragDropEffects.All;
        }

        private void listViewAllExams_DragDrop(object sender, DragEventArgs e)
        {
            string[] filepath = (string[])e.Data.GetData(DataFormats.FileDrop);
            var filename = filepath[0].Split('\\').Last();
            listViewAllExams.Items.Add(filename).ForeColor = Color.DarkGray;

            File.Copy(filepath[0], Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + $@"\EYEquiz\{filename}");
        }
    }
}