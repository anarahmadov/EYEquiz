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
        public List<QuestionBlock> Questions { get; set; }
        public List<QuestionControl> QuestionControl { get; set; }
        public LogIn LoginView { get; set; }
        public AddQuestionOrGoExam _AddQuestionOrGoExam { get; set; }
        public AddQuestion _AddQuestion { get; set; }
        public ChooseQuestions _ChooseQuestions { get; set; }

        public int QuestionCount { get; set; }
        public int Answercount { get; set; }
        public int CurrentQuestion { get; set; }

        public MetroFramework.Controls.MetroButton BtnBack { get; set; }
        public MetroFramework.Controls.MetroButton BtnAccept { get; set; }
        public MetroFramework.Controls.MetroButton BtnNext { get; set; }
        public MetroFramework.Controls.MetroButton BtnSubmit { get; set; }
        //public StatusStrip StatusStrip { get => statusStrip; set => statusStrip = value; }

        public string NumberOfQuestion { get => numberOfQuestion.Text; set => numberOfQuestion.Text = value; }

        public List<string> UserAnswers { get; set; }
        public bool isClickSubmit { get; set; }

        public bool Dragging { get; set; }
        public Point StartPoint { get; set; }
        
        public MainForm()
        {
            InitializeComponent();
        }

        public void FirstQuestionAnswersInitialize()
        {
            #region Answers initialize

            for (int i = 0; i < Answercount; i++)
            {
                var variant = new MetroFramework.Controls.MetroRadioButton();
                variant.UseCustomForeColor = true;
                variant.ForeColor = Color.DarkGray;
                variant.Cursor = Cursors.Hand;
                variant.Style = MetroFramework.MetroColorStyle.Brown;
                variant.AutoSize = false;
                variant.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
                variant.Text = Questions[CurrentQuestion].Answers[i].Text;
                variant.Size = new Size(700, 20);
                variant.UseCustomBackColor = true;
                variant.BackColor = Color.FromArgb(0, 0, 0, 0);
                variant.CheckedChanged += Answers_CheckedChanged;
                QuestionControl[CurrentQuestion].Flow.Controls.Add(variant);
            }

            #endregion
        }

        public void FourButtonInitialize()
        {
            #region Four buttons initialize
            BtnBack = new MetroFramework.Controls.MetroButton();
            BtnAccept = new MetroFramework.Controls.MetroButton();
            BtnNext = new MetroFramework.Controls.MetroButton();
            BtnSubmit = new MetroFramework.Controls.MetroButton();

            BtnSubmit.Size = new Size(150, 60);
            BtnSubmit.Location = new Point(600, 415);
            BtnSubmit.Text = "Submit";
            BtnSubmit.Click += BtnSubmit_Click;
            BtnSubmit.UseStyleColors = true;
            BtnSubmit.UseCustomBackColor = true;
            BtnSubmit.BackColor = Color.FromArgb(0, 0, 0, 0);
            BtnSubmit.Style = MetroFramework.MetroColorStyle.Black;
            BtnSubmit.TabStop = false;

            BtnBack.Size = new Size(130, 40);
            BtnBack.Location = new Point(10, 429);
            BtnBack.Text = "Back";
            BtnBack.Click += BtnBack_Click;
            BtnBack.UseStyleColors = true;
            BtnBack.UseCustomBackColor = true;
            BtnBack.BackColor = Color.FromArgb(0, 0, 0, 0);
            BtnBack.Style = MetroFramework.MetroColorStyle.Black;
            BtnBack.TabStop = false;

            BtnAccept.Size = new Size(130, 40);
            BtnAccept.Location = new Point(200, 429);
            BtnAccept.Text = "Accept";
            BtnAccept.Enabled = false;
            BtnAccept.Click += BtnAccept_Click;
            BtnAccept.UseStyleColors = true;
            BtnAccept.UseCustomBackColor = true;
            BtnAccept.BackColor = Color.FromArgb(0, 0, 0, 0);
            BtnAccept.Style = MetroFramework.MetroColorStyle.Black;
            BtnAccept.TabStop = false;

            BtnNext.Size = new Size(130, 40);
            BtnNext.Location = new Point(390, 429);
            BtnNext.Text = "Next";
            BtnNext.Click += BtnNext_Click;
            BtnNext.UseStyleColors = true;
            BtnNext.UseCustomBackColor = true;
            BtnNext.BackColor = Color.FromArgb(0, 0, 0, 0);
            BtnNext.Style = MetroFramework.MetroColorStyle.Black;
            BtnNext.TabStop = false;


            this.Controls.Add(BtnSubmit);
            this.Controls.Add(BtnBack);
            this.Controls.Add(BtnAccept);
            this.Controls.Add(BtnNext);
            #endregion
        }

        //private void btnStart_Click(object sender, EventArgs e)
        //{
        //    CurrentQuestion = 0;

        //    //initialize of QuestionControl[CurrentQuestion]
        //    if (File.Exists("QuestionsXML.xml"))
        //    {
        //        using (StreamReader streamReader = new StreamReader("QuestionsXML.xml"))
        //        {
        //            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<QuestionBlock>));
        //            var obj = (List<QuestionBlock>)xmlSerializer.Deserialize(streamReader);
        //            Questions = obj;
        //            QuestionCount = Questions.Count();
        //            UserAnswers = new string[QuestionCount];
        //            numberOfQuestion.Text = $"{CurrentQuestion + 1} / {QuestionCount} questions";

        //        }
        //        #region Question array declare
        //        QuestionControl = new List<QuestionControl>();

        //        for (int i = 0; i < QuestionCount; i++)
        //        {
        //            QuestionControl[i] = new QuestionControl(this);
        //        }
        //        #endregion

        //        Answercount = Questions[CurrentQuestion].Answers.Count();
        //        QuestionControl[CurrentQuestion].LabelQuestion.Text = Questions[CurrentQuestion].Text;
        //        QuestionControl[CurrentQuestion].Location = new Point(14, 35);

        //        #region Answers initialize

        //        for (int i = 0; i < Answercount; i++)
        //        {
        //            var correctvariant = new PictureBox();
        //            correctvariant.Size = new Size(20, 20);
        //            correctvariant.Image = Image.FromFile("correction");
        //            //correctvariant.Visible = false;
        //            QuestionControl[CurrentQuestion].Flow.Controls.Add(correctvariant);
        //        }

        //        for (int i = 0; i < Answercount; i++)
        //        {
        //            var variant = new MetroFramework.Controls.MetroRadioButton();
        //            variant.UseCustomForeColor = true;
        //            variant.ForeColor = Color.DarkGray;
        //            variant.Cursor = Cursors.Hand;
        //            variant.Style = MetroFramework.MetroColorStyle.Brown;
        //            variant.AutoSize = false;
        //            variant.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
        //            variant.Text = Questions[CurrentQuestion].Answers[i].Text;
        //            variant.Size = new Size(700, 20);
        //            variant.UseCustomBackColor = true;
        //            variant.BackColor = Color.FromArgb(0, 0, 0, 0);
        //            variant.CheckedChanged += Answers_CheckedChanged;
        //            QuestionControl[CurrentQuestion].Flow.Controls.Add(variant);
        //        }

        //        #endregion

        //        #region Four buttons initialize
        //        BtnBack = new MetroFramework.Controls.MetroButton();
        //        BtnAccept = new MetroFramework.Controls.MetroButton();
        //        BtnNext = new MetroFramework.Controls.MetroButton();
        //        BtnSubmit = new MetroFramework.Controls.MetroButton();

        //        BtnSubmit.Size = new Size(150, 60);
        //        BtnSubmit.Location = new Point(600, 415);
        //        BtnSubmit.Text = "Submit";
        //        BtnSubmit.Click += BtnSubmit_Click;
        //        BtnSubmit.UseStyleColors = true;
        //        BtnSubmit.UseCustomBackColor = true;
        //        BtnSubmit.BackColor = Color.FromArgb(0, 0, 0, 0);
        //        BtnSubmit.Style = MetroFramework.MetroColorStyle.Black;
        //        BtnSubmit.TabStop = false;

        //        BtnBack.Size = new Size(130, 40);
        //        BtnBack.Location = new Point(10, 429);
        //        BtnBack.Text = "Back";
        //        BtnBack.Click += BtnBack_Click;
        //        BtnBack.UseStyleColors = true;
        //        BtnBack.UseCustomBackColor = true;
        //        BtnBack.BackColor = Color.FromArgb(0, 0, 0, 0);
        //        BtnBack.Style = MetroFramework.MetroColorStyle.Black;
        //        BtnBack.TabStop = false;

        //        BtnAccept.Size = new Size(130, 40);
        //        BtnAccept.Location = new Point(200, 429);
        //        BtnAccept.Text = "Accept";
        //        BtnAccept.Enabled = false;
        //        BtnAccept.Click += BtnAccept_Click;
        //        BtnAccept.UseStyleColors = true;
        //        BtnAccept.UseCustomBackColor = true;
        //        BtnAccept.BackColor = Color.FromArgb(0, 0, 0, 0);
        //        BtnAccept.Style = MetroFramework.MetroColorStyle.Black;
        //        BtnAccept.TabStop = false;

        //        BtnNext.Size = new Size(130, 40);
        //        BtnNext.Location = new Point(390, 429);
        //        BtnNext.Text = "Next";
        //        BtnNext.Click += BtnNext_Click;
        //        BtnNext.UseStyleColors = true;
        //        BtnNext.UseCustomBackColor = true;
        //        BtnNext.BackColor = Color.FromArgb(0, 0, 0, 0);
        //        BtnNext.Style = MetroFramework.MetroColorStyle.Black;
        //        BtnNext.TabStop = false;


        //        this.Controls.Add(BtnSubmit);
        //        this.Controls.Add(BtnBack);
        //        this.Controls.Add(BtnAccept);
        //        this.Controls.Add(BtnNext);
        //        #endregion

        //        this.Controls.Add(QuestionControl[CurrentQuestion]);
        //    }
        //}

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            var dialogResult = System.Windows.Forms.MessageBox.Show("Are you sure ?", "Warning", MessageBoxButtons.OKCancel);

            if (dialogResult == DialogResult.OK)
            {
                isClickSubmit = true;

                #region Count corrects, wrongs or unanswereds
                int correct = 0, wrong = 0, unanswered = 0;

                for (int i = 0; i < Questions.Count; i++)
                {
                    if (UserAnswers[i] == string.Empty)
                    {
                        if (QuestionControl[i].Flow.Controls.Count != 0)
                        {
                            var id = Questions[i].Answers.Find(x => x.IsCorrect == "Yes").id;

                            var a = QuestionControl[i].Flow.Controls.OfType<MetroFramework.Controls.MetroRadioButton>().ElementAt(id);
                            (a as MetroFramework.Controls.MetroRadioButton).BackColor = Color.DimGray;
                        }
                            ++unanswered;
                    }

                    else if (UserAnswers[i] == Questions[i].Answers.Find(x => x.IsCorrect == "Yes").Text)
                    {
                        var id = Questions[i].Answers.Find(x => x.IsCorrect == "Yes").id;
                        ++correct;

                        var a = QuestionControl[i].Flow.Controls.OfType<MetroFramework.Controls.MetroRadioButton>().ElementAt(id);
                        (a as MetroFramework.Controls.MetroRadioButton).BackColor = Color.DarkGreen;
                    }

                    else if (UserAnswers[i] != Questions[i].Answers.Find(x => x.IsCorrect == "Yes").Text)
                    {
                        var id = Questions[i].Answers.Find(x => x.IsCorrect == "Yes").id;
                        ++wrong;

                        var a = QuestionControl[i].Flow.Controls.OfType<MetroFramework.Controls.MetroRadioButton>().SingleOrDefault(x => x.Checked == true);
                        (a as MetroFramework.Controls.MetroRadioButton).BackColor = Color.DarkRed;

                        var b = QuestionControl[i].Flow.Controls.OfType<MetroFramework.Controls.MetroRadioButton>().ElementAt(id);
                        (b as MetroFramework.Controls.MetroRadioButton).BackColor = Color.DarkGreen;
                    }
                }

                ToolStripLabel toolStripLabel = new ToolStripLabel();
                toolStripLabel.Font = new Font("Segoe UI", 9);
                toolStripLabel.Text = $"                                                            " +
                    $" Correct : {correct}   Wrong : {wrong}   Unanswered : {unanswered}";
                toolStripLabel.ForeColor = Color.White;
                statusStrip.Items.Add(toolStripLabel);
                #endregion

                BtnSubmit.Enabled = false;
                BtnAccept.Visible = false;

                QuestionControl[CurrentQuestion].Visible = false;
                CurrentQuestion = 0;
                QuestionControl[CurrentQuestion].Visible = true;
                numberOfQuestion.Text = $"{CurrentQuestion + 1} / {Questions.Count} questions";

                #region Disable All Answers

                foreach (var item in QuestionControl[CurrentQuestion].Flow.Controls)
                {
                    (item as MetroFramework.Controls.MetroRadioButton).Enabled = false;
                }

                if (UserAnswers[CurrentQuestion] == null)
                {
                    foreach (var item in QuestionControl[CurrentQuestion].Flow.Controls)
                    {
                        (item as MetroFramework.Controls.MetroRadioButton).Checked = false;
                    }
                }

                #endregion

            }


        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (CurrentQuestion < Questions.Count - 1)
            {
                QuestionControl[CurrentQuestion].Visible = false;

                ++CurrentQuestion;
                numberOfQuestion.Text = $"{CurrentQuestion + 1} / {Questions.Count} questions";
                Answercount = Questions[CurrentQuestion].Answers.Count();

                if (QuestionControl[CurrentQuestion].LabelQuestion.Text == string.Empty)
                {
                    QuestionControl[CurrentQuestion].LabelQuestion.Text = Questions[CurrentQuestion].Text;
                    QuestionControl[CurrentQuestion].Location = new Point(14, 35);

                    #region Answers initialize

                    for (int i = 0; i < Answercount; i++)
                    {
                        var variant = new MetroFramework.Controls.MetroRadioButton();
                        variant.UseCustomForeColor = true;
                        variant.ForeColor = Color.DarkGray;
                        variant.Style = MetroFramework.MetroColorStyle.Brown;
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

                    #region If isSubmit clicked Disable All Answers
                    if (isClickSubmit)
                    {
                        foreach (var item in QuestionControl[CurrentQuestion].Flow.Controls)
                        {
                            (item as MetroFramework.Controls.MetroRadioButton).Enabled = false;
                        }

                        var id = Questions[CurrentQuestion].Answers.Find(x => x.IsCorrect == "Yes").id;

                        var a = QuestionControl[CurrentQuestion].Flow.Controls.OfType<MetroFramework.Controls.MetroRadioButton>().ElementAt(id);
                        (a as MetroFramework.Controls.MetroRadioButton).BackColor = Color.DimGray;
                    }
                    #endregion

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
                            if (!(item as MetroFramework.Controls.MetroRadioButton).Enabled)
                                BtnAccept.Enabled = false;
                            else
                            {
                                BtnAccept.Enabled = true;
                                count++;
                            }
                        }
                    }
                    if (count == 0)
                        BtnAccept.Enabled = false;

                    #endregion

                    QuestionControl[CurrentQuestion].Visible = true;

                    #region If isSubmit clicked Disable All Answers
                    if (isClickSubmit)
                    {
                        foreach (var item in QuestionControl[CurrentQuestion].Flow.Controls)
                        {
                            (item as MetroFramework.Controls.MetroRadioButton).Enabled = false;
                        }

                        if (UserAnswers[CurrentQuestion] == null)
                        {
                            foreach (var item in QuestionControl[CurrentQuestion].Flow.Controls)
                            {
                                (item as MetroFramework.Controls.MetroRadioButton).Checked = false;
                            }
                        }
                    }
                    #endregion
                }

            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (CurrentQuestion > 0)
            {
                QuestionControl[CurrentQuestion].Visible = false;

                --CurrentQuestion;

                numberOfQuestion.Text = $"{CurrentQuestion + 1} / {Questions.Count} questions";

                #region Control each variant was check(acceptbutton enabled will true) or not?

                int count = 0;
                foreach (var item in QuestionControl[CurrentQuestion].Flow.Controls)
                {
                    if ((item as MetroFramework.Controls.MetroRadioButton).Checked)
                    {
                        if (!(item as MetroFramework.Controls.MetroRadioButton).Enabled)
                            BtnAccept.Enabled = false;
                        else
                        {
                            BtnAccept.Enabled = true;
                            count++;
                        }
                    }
                }
                if (count == 0)
                    BtnAccept.Enabled = false;
                #endregion

                QuestionControl[CurrentQuestion].Visible = true;

                #region Disable All Answers
                if (isClickSubmit)
                {
                    foreach (var item in QuestionControl[CurrentQuestion].Flow.Controls)
                    {
                        (item as MetroFramework.Controls.MetroRadioButton).Enabled = false;
                    }
                }
                #endregion
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            //timer.Interval = 10;
            //timer.Start();
            Application.Exit();
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginView = new LogIn(this);
            LoginView.Location = new Point(0, 49);
            this.Controls.Add(LoginView);
        }

    }
}
