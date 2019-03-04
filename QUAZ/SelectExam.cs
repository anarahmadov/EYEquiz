using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace QUAZ
{
    public partial class SelectExam : UserControl
    {
        MainForm MainForm;
        CustomMessageBox customMessageBox;
        public int QuestionCount { get => int.Parse(txtboxQuestionCount.Text);}

        public SelectExam(MainForm mainForm)
        {
            MainForm = mainForm;
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (listViewAllQuestions.SelectedIndices.Count != 0)
            {                                        
                var defaulttestpath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + $@"\EYEquiz\{listViewAllQuestions.SelectedItems[0].Text}";

                List<QuestionBlock> obj;
                using (StreamReader streamReader = new StreamReader(defaulttestpath))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<QuestionBlock>));
                    obj = (List<QuestionBlock>)xmlSerializer.Deserialize(streamReader);
                }             

                if (QuestionCount <= obj.Count && QuestionCount != 0)
                {
                    this.Visible = false;
                    MainForm.CurrentQuestion = 0;

                    #region Deserialize file that selected in listview
                    //initialize of QuestionControl[CurrentQuestion]
                    if (File.Exists(defaulttestpath))
                    {
                        MainForm.Questions = new List<QuestionBlock>();

                        for (int i = 0; i < QuestionCount; i++)
                        {
                            MainForm.Questions.Add(new QuestionBlock());
                            MainForm.Questions[i] = obj[i];
                        }

                        MainForm.QuestionCount = MainForm.Questions.Count();
                        MainForm.UserAnswers = new List<string>();
                    }
                    #endregion

                    #region Question array declare

                    MainForm.QuestionControl = new List<QuestionControl>();

                    for (int i = 0; i < QuestionCount; i++)
                    {
                        MainForm.QuestionControl.Add(new QuestionControl(MainForm));
                    }

                    #endregion

                    MainForm.Answercount = MainForm.Questions[MainForm.CurrentQuestion].Answers.Count();
                    MainForm.QuestionControl[MainForm.CurrentQuestion].LabelQuestion.Text = MainForm.Questions[MainForm.CurrentQuestion].Text;
                    MainForm.QuestionControl[MainForm.CurrentQuestion].Location = new Point(14, 70);
                    MainForm.NumberOfQuestion = $"{MainForm.CurrentQuestion + 1} / {MainForm.Questions.Count} questions";

                    for (int i = 0; i < MainForm.Questions.Count; i++)
                    {
                        MainForm.UserAnswers.Add("");
                    }

                    MainForm.FirstQuestionAnswersInitialize();
                    MainForm.FourButtonInitialize();
                    MainForm.Controls.Add(MainForm.QuestionControl[MainForm.CurrentQuestion]);
                }
                else
                {
                    customMessageBox = new CustomMessageBox(CustomMessageBoxButtons.OK);
                    customMessageBox.MessageText = "Question count is invalid";
                    customMessageBox.MessageTitle = "Warning";
                    customMessageBox.ShowDialog();
                }
            }
            else
            {
                customMessageBox = new CustomMessageBox(CustomMessageBoxButtons.OK);
                customMessageBox.MessageText = "Please, select file";
                customMessageBox.MessageTitle = "Warning";
                customMessageBox.ShowDialog();
            }
                
        }

        private void SelectExam_Load(object sender, EventArgs e)
        {
            List<string> paths = new List<string>();
            List<string> filesname = new List<string>();

            paths = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\EYEquiz").ToList<string>();

            for (int i = 0; i < paths.Count(); i++)
            {
                filesname.Add(paths[i].Split('\\').Last());
            }

            for (int i = 0; i < paths.Count(); i++)
            {
                listViewAllQuestions.Items.Add(filesname[i], 0);
                listViewAllQuestions.Items[i].ForeColor = Color.DarkGray;
                listViewAllQuestions.ShowItemToolTips = true;
            }
        }

        private void txtboxQuestionCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            var ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }

        }
    }
}
