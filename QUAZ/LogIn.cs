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
    public partial class LogIn : UserControl
    {
        private MainForm MainForm;

        public LogIn(MainForm mainForm)
        {
            MainForm = mainForm;
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            MainForm._AddQuestionOrGoExam = new AddQuestionOrGoExam(MainForm);
            MainForm._AddQuestionOrGoExam.Location = new Point(0, 49);
            MainForm.Controls.Add(MainForm._AddQuestionOrGoExam);

            #region Old code
            //MainForm._AddQuestionOrGoExam = new AddQuestionOrGoExam(MainForm);
            //MainForm._AddQuestionOrGoExam.Location = new Point(0, 49);
            //MainForm.Controls.Add(MainForm._AddQuestionOrGoExam);

            //MainForm.CurrentQuestion = 0;

            ////initialize of QuestionControl[CurrentQuestion]
            //if (File.Exists("QuestionsXML.xml"))
            //{
            //    using (StreamReader streamReader = new StreamReader("QuestionsXML.xml"))
            //    {
            //        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<QuestionBlock>));
            //        var obj = (List<QuestionBlock>)xmlSerializer.Deserialize(streamReader);
            //        MainForm.Questions = obj;
            //        MainForm.QuestionCount = MainForm.Questions.Count();
            //        MainForm.UserAnswers = new List<string>();                    
            //    }
            //    #region Question array declare
            //    //MainForm.QuestionControl = new List<QuestionControl>();

            //    //for (int i = 0; i < MainForm.QuestionCount; i++)
            //    //{
            //    //    MainForm.QuestionControl.Add(new QuestionControl(MainForm));
            //    //}
            //    #endregion

            //}
            #endregion

            var currentpath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\EYEquiz";

            if (!Directory.Exists(currentpath))
            {
                Directory.CreateDirectory(currentpath);
            }

            var current = @"C:\Users\Anar\source\repos\EYEquiz!\QUAZ\bin\Debug\QuestionsXML.xml";

            if (!File.Exists(currentpath + @"\QuestionsXML.xml"))
            {
                File.Copy(current, Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\EYEquiz\QuestionsXML.xml");
            }

        }
    }
}
