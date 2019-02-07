using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUAZ
{
    public partial class AddQuestion : UserControl
    {
        public List<MetroFramework.Controls.MetroRadioButton> RadioButtonAnswers { get; set; }
        public List<TextBox> RadioButtonAnswersText { get; set; }

        public int AnswerCount { get => RadioButtonAnswers.Count; }
        public string QuestionText { get => txtboxQuestion.Text; }
        public string IsCorrectVariant { get; set; }

        public int CurrentAnswer { get; set; } = 0;

        public List<Answer> _Answers { get; set; }
        MainForm MainForm;

        public AddQuestion(MainForm mainForm)
        {
            MainForm = mainForm;
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MainForm._AddQuestionOrGoExam.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (RadioButtonAnswers[CurrentAnswer].Checked)
                IsCorrectVariant = "Yes";
            else
                IsCorrectVariant = "No";

            ++CurrentAnswer;

            _Answers = new List<Answer>();

            for (int i = 0; i < _Answers.Count; i++)
            {
                _Answers.Add(new Answer()
                {
                    id = i,
                    Text = RadioButtonAnswersText[i].Text,
                    IsCorrect = IsCorrectVariant
                });
            }

            MainForm.Questions.Add(new QuestionBlock()
            {
                id = MainForm.Questions.Count + 1,
                Text = QuestionText,
                Answers = _Answers 
            });

        }

        private void answerCount_TextChanged(object sender, EventArgs e)
        {
            if (answerCount.Text != string.Empty && int.Parse(answerCount.Text) <= 6)
            {
                RadioButtonAnswers = new List<MetroFramework.Controls.MetroRadioButton>();
                RadioButtonAnswersText = new List<TextBox>();
                for (int i = 0, x = 30, y = 180; i < int.Parse(answerCount.Text); i++, y += 30)
                {
                    RadioButtonAnswersText.Add(new TextBox());
                    RadioButtonAnswersText[i].Location = new Point(x + 20, y);
                    RadioButtonAnswersText[i].Size = new Size(400, 20);
                    this.Controls.Add(RadioButtonAnswersText[i]);

                    RadioButtonAnswers.Add(new MetroFramework.Controls.MetroRadioButton());
                    RadioButtonAnswers[i].CheckedChanged += RadioButtonAnswer_CheckedChanged;
                    RadioButtonAnswers[i].Location = new Point(x, y);
                    RadioButtonAnswers[i].Size = new Size(20, 20);
                    RadioButtonAnswers[i].UseCustomBackColor = true;
                    RadioButtonAnswers[i].Style = MetroFramework.MetroColorStyle.Brown;
                    RadioButtonAnswers[i].BackColor = Color.FromArgb(0, 0, 0, 0);
                    this.Controls.Add(RadioButtonAnswers[i]);
                }
            }
            else if (RadioButtonAnswers != null && RadioButtonAnswersText != null)
            {
                for (int i = 0; i < RadioButtonAnswers.Count; i++)
                {
                    this.Controls.Remove(RadioButtonAnswers[i]);
                    this.Controls.Remove(RadioButtonAnswersText[i]);
                }
                RadioButtonAnswers.Clear();
                RadioButtonAnswersText.Clear();
            }
        }

        private void RadioButtonAnswer_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
