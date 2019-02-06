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
    public partial class ChooseQuestions : UserControl
    {
        MainForm MainForm;

        public ChooseQuestions(MainForm mainForm)
        {
            MainForm = mainForm;
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MainForm._AddQuestionOrGoExam.Visible = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            MainForm.CurrentQuestion = 0;

            //initialize of QuestionControl[CurrentQuestion]
            if (File.Exists("QuestionsXML.xml"))
            {
                using (StreamReader streamReader = new StreamReader("QuestionsXML.xml"))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(QuestionBlock[]));
                    var obj = (QuestionBlock[])xmlSerializer.Deserialize(streamReader);
                    MainForm.Questions = obj;
                    MainForm.QuestionCount = MainForm.Questions.Count();
                    MainForm.UserAnswers = new string[MainForm.QuestionCount];
                    MainForm.NumberOfQuestion = $"{MainForm.CurrentQuestion + 1} / {MainForm.QuestionCount} questions";
                }
                #region Question array declare
                MainForm.QuestionControl = new QuestionControl[MainForm.QuestionCount];

                for (int i = 0; i < MainForm.QuestionCount; i++)
                {
                    MainForm.QuestionControl[i] = new QuestionControl(MainForm);
                }
                #endregion

                MainForm.Answercount = MainForm.Questions[MainForm.CurrentQuestion].Answers.Count();
                MainForm.QuestionControl[MainForm.CurrentQuestion].LabelQuestion.Text = MainForm.Questions[MainForm.CurrentQuestion].Text;
                MainForm.QuestionControl[MainForm.CurrentQuestion].Location = new Point(14, 35);

                MainForm.FirstQuestionAnswersInitialize();

                MainForm.FourButtonInitialize();

                MainForm.Controls.Add(MainForm.QuestionControl[MainForm.CurrentQuestion]);
            }
        }
    }
}
