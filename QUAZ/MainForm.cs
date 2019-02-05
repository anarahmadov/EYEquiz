using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.XPath;

namespace QUAZ
{
    public partial class MainForm : Form
    {
        public QuestionBlock[] Questions { get; set; }
        public QuestionControl[] QuestionControl { get; set; }

        public int QuestionCount { get; set; }
        public int Answercount { get; set; }
        public int CurrentQuestion { get; set; }

        public MetroFramework.Controls.MetroButton BtnBack { get; set; }
        public MetroFramework.Controls.MetroButton BtnAccept { get; set; }
        public MetroFramework.Controls.MetroButton BtnNext { get; set; }
        public MetroFramework.Controls.MetroButton BtnSubmit { get; set; }

        public string[] UserAnswers { get; set; }
        public bool isClickSubmit { get; set; }
        public object AppLication { get; private set; }

        public bool Dragging { get; set; }
        public Point StartPoint { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Visible = false;
            labelQuestionCount.Visible = false;
            labelWelcome.Visible = false;
            CurrentQuestion = 0;

            //initialize of QuestionControl[CurrentQuestion]
            //var a =  Path.GetFullPath("QuestionsXML.xml");
            using (StreamReader streamReader = new StreamReader("QuestionsXML.xml"))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(QuestionBlock[]));
                var obj = (QuestionBlock[])xmlSerializer.Deserialize(streamReader);
                Questions = obj;
                QuestionCount = Questions.Count();
                UserAnswers = new string[QuestionCount];
                numberOfQuestion.Text = $"{CurrentQuestion + 1} / {QuestionCount} questions";
            }
            #region Question array declare
            QuestionControl = new QuestionControl[QuestionCount];

            for (int i = 0; i < QuestionCount; i++)
            {
                QuestionControl[i] = new QuestionControl(this);
            }
            #endregion

            Answercount = Questions[CurrentQuestion].Answers.Count();
            QuestionControl[CurrentQuestion].LabelQuestion.Text = Questions[CurrentQuestion].Text;
            QuestionControl[CurrentQuestion].Location = new Point(14, 35);

            #region Answers initialize

            for (int i = 0; i < Answercount; i++)
            {
                var variant = new MetroFramework.Controls.MetroRadioButton();
                variant.Cursor = Cursors.Hand;
                variant.Style = MetroFramework.MetroColorStyle.Teal;
                variant.AutoSize = false;
                variant.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
                variant.Text = Questions[CurrentQuestion].Answers[i].Text;
                //if (Questions[CurrentQuestion].Answers.Find(x => x.IsCorrect == "Yes").id == i)
                //{
                //    variant.Text = Questions[CurrentQuestion].Answers[i].Text += ")";
                //}
                variant.Size = new Size(700, 20);
                variant.UseCustomBackColor = true;
                variant.BackColor = Color.FromArgb(0, 0, 0, 0);
                variant.CheckedChanged += Answers_CheckedChanged;
                QuestionControl[CurrentQuestion].Flow.Controls.Add(variant);
            }

            #endregion

            #region Four buttons initialize
            BtnBack = new MetroFramework.Controls.MetroButton();
            BtnAccept = new MetroFramework.Controls.MetroButton();
            BtnNext = new MetroFramework.Controls.MetroButton();
            BtnSubmit = new MetroFramework.Controls.MetroButton();

            BtnSubmit.Size = new Size(150, 60);
            BtnSubmit.Location = new Point(600, 415);
            //BtnSubmit.Dock = DockStyle.Bottom;
            BtnSubmit.Text = "Submit";
            BtnSubmit.Click += BtnSubmit_Click;
            BtnSubmit.UseStyleColors = true;
            BtnSubmit.UseCustomBackColor = true;
            BtnSubmit.BackColor = Color.FromArgb(0,0,0,0);
            BtnSubmit.Style = MetroFramework.MetroColorStyle.Teal;
            BtnSubmit.TabStop = false;

            BtnBack.Size = new Size(130, 40);
            BtnBack.Location = new Point(10, 429);
            BtnBack.Text = "Back";
            BtnBack.Click += BtnBack_Click;
            BtnBack.UseStyleColors = true;
            BtnBack.UseCustomBackColor = true;
            BtnBack.BackColor = Color.FromArgb(0, 0, 0, 0);
            BtnBack.Style = MetroFramework.MetroColorStyle.Teal;
            BtnBack.TabStop = false;

            BtnAccept.Size = new Size(130, 40);
            BtnAccept.Location = new Point(200, 429);
            BtnAccept.Text = "Accept";
            BtnAccept.Enabled = false;
            BtnAccept.Click += BtnAccept_Click;
            BtnAccept.UseStyleColors = true;
            BtnAccept.UseCustomBackColor = true;
            BtnAccept.BackColor = Color.FromArgb(0, 0, 0, 0);
            BtnAccept.Style = MetroFramework.MetroColorStyle.Teal;
            BtnAccept.TabStop = false;

            BtnNext.Size = new Size(130, 40);
            BtnNext.Location = new Point(390, 429);
            BtnNext.Text = "Next";
            BtnNext.Click += BtnNext_Click;
            BtnNext.UseStyleColors = true;
            BtnNext.UseCustomBackColor = true;
            BtnNext.BackColor = Color.FromArgb(0, 0, 0, 0);
            BtnNext.Style = MetroFramework.MetroColorStyle.Teal;
            BtnNext.TabStop = false;
            

            this.Controls.Add(BtnSubmit);
            this.Controls.Add(BtnBack);
            this.Controls.Add(BtnAccept);
            this.Controls.Add(BtnNext);
            #endregion

            this.Controls.Add(QuestionControl[CurrentQuestion]);
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Are you sure ?", "Warning", MessageBoxButtons.OKCancel);

            if (dialogResult == DialogResult.OK)
            {
                isClickSubmit = true;

                #region Count corrects, wrongs or unanswereds
                int correct = 0, wrong = 0, unanswered = 0;

                for (int i = 0; i < QuestionCount; i++)
                {
                    if (UserAnswers[i] == null)
                        ++unanswered;
                    else if (UserAnswers[i] == Questions[i].Answers.Find(x => x.IsCorrect == "Yes").Text)
                        ++correct;
                    else if (UserAnswers[i] != Questions[i].Answers.Find(x => x.IsCorrect == "Yes").Text)
                        ++wrong;
                }
                ToolStripLabel toolStripLabel = new ToolStripLabel();
                toolStripLabel.Font = new Font("Segoe UI", 9);
                toolStripLabel.Text = $"                                                             Correct : {correct}   Wrong : {wrong}   Unanswered : {unanswered}";
                statusStrip.Items.Add(toolStripLabel);
                #endregion

                #region Enable All Answers

                for (int i = 0; i < QuestionCount; i++)
                {
                    foreach (var item in QuestionControl[i].Flow.Controls)
                    {
                        (item as MetroFramework.Controls.MetroRadioButton).Enabled = false;
                    }
                }


                #endregion

                BtnSubmit.Enabled = false;
                BtnAccept.Visible = false;
            }


        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (CurrentQuestion < QuestionCount - 1)
            {
                for (int i = 0; i < QuestionCount; i++)
                {
                    QuestionControl[CurrentQuestion].Visible = false;
                }

                ++CurrentQuestion;
                numberOfQuestion.Text = $"{CurrentQuestion + 1} / {QuestionCount} questions";
                Answercount = Questions[CurrentQuestion].Answers.Count();
                
                #region Enable All Answers
               if (isClickSubmit)
               {
                   foreach (var item in QuestionControl[CurrentQuestion].Flow.Controls)
                   {
                       (item as MetroFramework.Controls.MetroRadioButton).Enabled = false;
                   }
               }
               #endregion
                
                if (QuestionControl[CurrentQuestion].LabelQuestion.Text == string.Empty)
                {

                    QuestionControl[CurrentQuestion].LabelQuestion.Text = Questions[CurrentQuestion].Text;
                    QuestionControl[CurrentQuestion].Location = new Point(14, 35);

                    #region Answers initialize

                    for (int i = 0; i < Answercount; i++)
                    {
                        var variant = new MetroFramework.Controls.MetroRadioButton();
                        variant.Style = MetroFramework.MetroColorStyle.Teal;
                        variant.AutoSize = false;
                        variant.Text = Questions[CurrentQuestion].Answers[i].Text;
                        variant.Cursor = Cursors.Hand;
                        variant.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
                        variant.Size = new Size(750, 20);
                        variant.UseCustomBackColor = true;
                        variant.BackColor = Color.FromArgb(0, 0, 0, 0);
                        variant.CheckedChanged += Answers_CheckedChanged;
                        QuestionControl[CurrentQuestion].Flow.Controls.Add(variant);
                    }

                    #endregion

                    BtnAccept.Enabled = false;

                    this.Controls.Add(QuestionControl[CurrentQuestion]);
                }
                else
                {
                    Answercount = Questions[CurrentQuestion].Answers.Count();

                    #region Control each variant was check(acceptbutton enabled will true) or not?

                    int count = 0;
                    foreach (var item in QuestionControl[CurrentQuestion].Flow.Controls)
                    {
                        if ((item as MetroFramework.Controls.MetroRadioButton).Checked)
                        {
                            BtnAccept.Enabled = true;
                            count++;
                        }
                    }
                    if (count == 0)
                        BtnAccept.Enabled = false;

                    #endregion

                    for (int i = 0; i < QuestionCount; i++)
                    {
                        QuestionControl[CurrentQuestion].Visible = true;
                    }
                }
            }
        }

        private void Answers_CheckedChanged(object sender, EventArgs e)
        {
            BtnAccept.Enabled = true;
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            foreach (var item in QuestionControl[CurrentQuestion].Flow.Controls)
            {
                if ((item as MetroFramework.Controls.MetroRadioButton).Checked)
                {
                    UserAnswers[CurrentQuestion] = (item as MetroFramework.Controls.MetroRadioButton).Text;
                }

                (item as MetroFramework.Controls.MetroRadioButton).Enabled = false;
            }
            BtnAccept.Enabled = false;

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (CurrentQuestion > 0)
            {

                for (int i = 0; i < QuestionCount; i++)
                {
                    QuestionControl[CurrentQuestion].Visible = false;
                }

                --CurrentQuestion;

                numberOfQuestion.Text = $"{CurrentQuestion + 1} / {QuestionCount} questions";

                #region Enable All Answers
                if (isClickSubmit)
                {
                    foreach (var item in QuestionControl[CurrentQuestion].Flow.Controls)
                    {
                        (item as MetroFramework.Controls.MetroRadioButton).Enabled = false;
                    }
                }
                #endregion

                #region Control each variant was check(acceptbutton enabled will true) or not?

                int count = 0;
                foreach (var item in QuestionControl[CurrentQuestion].Flow.Controls)
                {
                    if ((item as MetroFramework.Controls.MetroRadioButton).Checked)
                    {
                        BtnAccept.Enabled = true;
                        count++;
                    }
                }
                if (count == 0)
                    BtnAccept.Enabled = false;
                #endregion

                for (int i = 0; i < QuestionCount; i++)
                {
                    QuestionControl[CurrentQuestion].Visible = true;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //timer.Interval = 10;
            //timer.Start();
            Application.Exit();
        }

        private void btnStart_MouseEnter(object sender, EventArgs e)
        {
            btnStart.BackColor = Color.Teal;
        }

        private void btnStart_MouseLeave(object sender, EventArgs e)
        {
            btnStart.BackColor = Color.FromArgb(0,0,0,0);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //if (this.Opacity > 0.0)
            //{
            //    this.Opacity -= 0.025;
            //}
            //else
            //{
            //    timer.Stop();
            //    Application.Exit();
            //}
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
                WindowState = FormWindowState.Minimized;
        }

        private void topPanel_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            StartPoint = new Point(e.X, e.Y);
        }

        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - StartPoint.X, p.Y - StartPoint.Y);
            }
        }
    }
}
