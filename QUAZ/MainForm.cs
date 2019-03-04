using iTextSharp.text;
using iTextSharp.text.pdf;
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
        public MenuStrip MenuStrip { get => menuStrip; set => menuStrip = value; }

        public List<QuestionBlock> Questions { get; set; }
        public List<QuestionControl> QuestionControl { get; set; }
        public LogIn LoginView { get; set; }
        public AddQuestionOrGoExam _AddQuestionOrGoExam { get; set; }
        public CreateExam _AddQuestion { get; set; }
        public SelectExam _ChooseQuestions { get; set; }
        public EditOrCreateExam _EditOrCreateExam { get; set; }
        public EditExam _EditExam { get; set; }
        public string MainLink { get; set; } = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\EYEquiz";

        public int QuestionCount { get; set; }
        public int Answercount { get; set; }
        public int CurrentQuestion { get; set; }

        public MetroFramework.Controls.MetroButton BtnBack { get; set; }
        public MetroFramework.Controls.MetroButton BtnAccept { get; set; }
        public MetroFramework.Controls.MetroButton BtnNext { get; set; }
        public MetroFramework.Controls.MetroButton BtnSubmit { get; set; }
        public MetroFramework.Controls.MetroButton BtnSaveAs { get; set; }
        //public StatusStrip StatusStrip { get => statusStrip; set => statusStrip = value; }

        public string NumberOfQuestion { get => numberOfQuestion.Text; set => numberOfQuestion.Text = value; }

        public List<string> UserAnswers { get; set; }
        public bool isClickSubmit { get; set; }

        public string Report { get; set; }
        public string FullNameUser { get; set; }

        public bool Dragging { get; set; }
        public Point StartPoint { get; set; }

        CustomMessageBox CustomMessageBox;

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
            BtnSaveAs = new MetroFramework.Controls.MetroButton();

            BtnSubmit.Size = new Size(150, 60);
            BtnSubmit.Location = new Point(600, 435);
            BtnSubmit.Text = "Submit";
            BtnSubmit.Click += BtnSubmit_Click;
            BtnSubmit.UseStyleColors = true;
            BtnSubmit.UseCustomBackColor = true;
            BtnSubmit.UseCustomForeColor = true;
            BtnSubmit.BackColor = Color.FromArgb(21, 21, 21);
            BtnSubmit.ForeColor = Color.DarkGray;
            BtnSubmit.Style = MetroFramework.MetroColorStyle.Black;
            BtnSubmit.TabStop = false;

            BtnBack.Size = new Size(130, 40);
            BtnBack.Location = new Point(10, 450);
            BtnBack.Text = "Back";
            BtnBack.Click += BtnBack_Click;
            BtnBack.UseStyleColors = true;
            BtnBack.UseCustomBackColor = true;
            BtnBack.UseCustomForeColor = true;
            BtnBack.BackColor = Color.FromArgb(41, 41, 41);
            BtnBack.ForeColor = Color.DarkGray;
            BtnBack.Style = MetroFramework.MetroColorStyle.Black;
            BtnBack.TabStop = false;

            BtnAccept.Size = new Size(130, 40);
            BtnAccept.Location = new Point(200, 450);
            BtnAccept.Text = "Accept";
            BtnAccept.Enabled = false;
            BtnAccept.Click += BtnAccept_Click;
            BtnAccept.UseStyleColors = true;
            BtnAccept.UseCustomBackColor = true;
            BtnAccept.UseCustomForeColor = true;
            BtnAccept.BackColor = Color.FromArgb(41, 41, 41);
            BtnAccept.ForeColor = Color.DarkGray;
            BtnAccept.Style = MetroFramework.MetroColorStyle.Black;
            BtnAccept.TabStop = false;

            BtnNext.Size = new Size(130, 40);
            BtnNext.Location = new Point(390, 450);
            BtnNext.Text = "Next";
            BtnNext.Click += BtnNext_Click;
            BtnNext.UseStyleColors = true;
            BtnNext.UseCustomBackColor = true;
            BtnNext.UseCustomForeColor = true;
            BtnNext.BackColor = Color.FromArgb(41, 41, 41);
            BtnNext.ForeColor = Color.DarkGray;
            BtnNext.Style = MetroFramework.MetroColorStyle.Black;
            BtnNext.TabStop = false;

            BtnSaveAs.Location = new Point(600, 435);
            BtnSaveAs.Size = new Size(150, 60);
            BtnSaveAs.Text = "Save as";
            BtnSaveAs.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            BtnSaveAs.FontSize = MetroFramework.MetroButtonSize.Medium;
            BtnSaveAs.UseCustomBackColor = true;
            BtnSaveAs.UseCustomForeColor = true;
            BtnSaveAs.ForeColor = Color.DarkGray;
            BtnSaveAs.BackColor = Color.FromArgb(21, 21, 21);
            BtnSaveAs.Click += BtnSaveAs_Click;
            BtnSaveAs.TabStop = false;
            BtnSaveAs.Visible = false;

            this.Controls.Add(BtnSaveAs);
            this.Controls.Add(BtnSubmit);
            this.Controls.Add(BtnBack);
            this.Controls.Add(BtnAccept);
            this.Controls.Add(BtnNext);
            #endregion
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            CustomMessageBox = new CustomMessageBox(CustomMessageBoxButtons.OKCancel);
            CustomMessageBox.MessageText = "Are you sure?";
            CustomMessageBox.MessageTitle = "Warning";
            var dialogresult = CustomMessageBox.ShowDialog();

            if (dialogresult == DialogResult.OK)
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
                toolStripLabel.Font = new System.Drawing.Font("Segoe UI", 9);
                toolStripLabel.Text = $"                                                            " +
                    $" Correct : {correct}   Wrong : {wrong}   Unanswered : {unanswered}";
                toolStripLabel.ForeColor = Color.White;
                statusStrip.Items.Add(toolStripLabel);

                var resultbypercent = correct * 100 / QuestionCount;

                Report = $"Correct : {correct}\n" +
                    $"Wrong : {wrong}\n" +
                    $"Unanswered : {unanswered}\n\n" +
                    $"Result : {resultbypercent} %";

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

                #region
                for (int i = 0; i < Questions.Count; i++)
                {
                    if (UserAnswers[i] == string.Empty)
                    {
                        foreach (var item in QuestionControl[i].Flow.Controls)
                        {
                            (item as MetroFramework.Controls.MetroRadioButton).Checked = false;
                        }
                    }
                }
                #endregion

                #endregion

                BtnSubmit.Visible = false;
                BtnSaveAs.Visible = true;

            }
        }

        private void BtnSaveAs_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF files (*.pdf)|*.pdf |DOC files (*.doc)|*.doc", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Document doc = new Document(PageSize.A4.Rotate());

                    #region If SaveFileDialog filter selected item is PDF

                    if (sfd.FilterIndex == 1)
                    {
                        try
                        {
                            var writer = PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                            doc.Open();
                            
                            #region Write to PDF

                            doc.AddTitle("EYEquiz");
                            doc.Add(new Paragraph($"{FullNameUser}"));
                            //doc.Add(new Paragraph(" "));
                            //doc.Add(new Paragraph(" "));


                            doc.Add(new Paragraph(" "));

                            for (int i = 0; i < Report.Split('\n').Count(); i++)
                            {
                                if (Report.Split('\n')[i] == Report.Split('\n').Last())
                                    break;

                                doc.Add(new Paragraph($"{Report.Split('\n')[i]}"));
                            }

                            doc.Add(new Paragraph("  "));
                            doc.Add(new Paragraph("  "));
                            doc.Add(new Paragraph("  "));
                            doc.Add(new Paragraph("  "));
                            doc.Add(new Paragraph("  "));


                            PdfContentByte contentByte = writer.DirectContent;
                            contentByte.SetColorStroke(BaseColor.BLACK);
                            contentByte.MoveTo(0, 410);
                            contentByte.LineTo(850, 410);
                            contentByte.Stroke();

                            contentByte.Rectangle(30, 420, PageSize.A4.Width * 1 / 2, PageSize.A4.Height / 6);
                            contentByte.Stroke();

                            #endregion

                            #region Write Result Word

                            iTextSharp.text.Font font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 18, iTextSharp.text.Font.BOLDITALIC, new BaseColor(0, 0, 0));
                            Phrase phrase = new Phrase(0.0f, $"{Report.Split('\n').Last()}", font);
                            ColumnText.ShowTextAligned(contentByte, Element.ALIGN_CENTER, phrase, 85, 430, 0.0f);

                            #endregion

                            for (int i = 0; i < QuestionCount; i++)
                            {
                                doc.Add(new Paragraph($"{i + 1}. {Questions[i].Text}"));
                                doc.Add(new Paragraph("                        "));

                                if (QuestionControl[i].Flow.Controls.OfType<MetroFramework.Controls.MetroRadioButton>()
                                        .FirstOrDefault(x => x.Checked == true) != null)
                                {
                                    for (int z = 0; z < Answercount; z++)
                                    {
                                        if (Questions[i].Answers[z].Text == Questions[i].Answers.Find(x => x.IsCorrect == "Yes").Text)
                                        {
                                            if (Questions[i].Answers[z].Text == QuestionControl[i].Flow.Controls.OfType<MetroFramework.Controls.MetroRadioButton>()
                                            .FirstOrDefault(x => x.Checked == true).Text)
                                            {
                                                doc.Add(new Paragraph($"     {Questions[i].Answers[z].Text} [Correct answered]"));
                                            }

                                            else
                                                doc.Add(new Paragraph($"     {Questions[i].Answers[z].Text} [Correct answer]"));
                                        }

                                        else if (Questions[i].Answers[z].Text == QuestionControl[i].Flow.Controls.OfType<MetroFramework.Controls.MetroRadioButton>()
                                       .FirstOrDefault(x => x.Checked == true).Text)
                                            doc.Add(new Paragraph($"     {Questions[i].Answers[z].Text} [Your answer]"));
                                        else                              
                                                doc.Add(new Paragraph($"     {Questions[i].Answers[z].Text}"));
                                        
                                    }
                                }
                                else
                                {
                                    for (int z = 0; z < Answercount; z++)
                                    {

                                        if (Questions[i].Answers[z].Text == Questions[i].Answers.Find(x => x.IsCorrect == "Yes").Text)
                                            doc.Add(new Paragraph($"     {Questions[i].Answers[z].Text} [Correct answer]"));

                                        else
                                            doc.Add(new Paragraph($"     {Questions[i].Answers[z].Text}"));

                                    }
                                }

                                doc.Add(new Paragraph("                        "));
                            }

                            doc.Close();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    #endregion

                    #region If SaveFileDialog filter selected item is DOC

                    else if (sfd.FilterIndex == 2)
                    {
                        var path = Path.GetFullPath($"{sfd.FileName}");

                        using (StreamWriter stream = new StreamWriter(Path.GetFullPath(sfd.FileName)))
                        {
                            stream.Write($"{Report}                  {FullNameUser}");
                            stream.Write("\n\n\n\n");

                            for (int i = 0; i < QuestionCount; i++)
                            {
                                stream.Write($"{i+1}. {Questions[i].Text}");
                                stream.Write($"\n");

                                if (QuestionControl[i].Flow.Controls.OfType<MetroFramework.Controls.MetroRadioButton>()
                                        .FirstOrDefault(x => x.Checked == true) != null)
                                {
                                    for (int z = 0; z < Answercount; z++)
                                    {
                                        if (Questions[i].Answers[z].Text == Questions[i].Answers.Find(x => x.IsCorrect == "Yes").Text)
                                        {
                                            if (Questions[i].Answers[z].Text == QuestionControl[i].Flow.Controls.OfType<MetroFramework.Controls.MetroRadioButton>()
                                            .FirstOrDefault(x => x.Checked == true).Text)
                                            {
                                                stream.Write($"     {Questions[i].Answers[z].Text} [Correct answered]");
                                            }

                                            else
                                                stream.Write($"     {Questions[i].Answers[z].Text} [Correct answer]");
                                        }

                                        else if (Questions[i].Answers[z].Text == QuestionControl[i].Flow.Controls.OfType<MetroFramework.Controls.MetroRadioButton>()
                                       .FirstOrDefault(x => x.Checked == true).Text)
                                            stream.Write($"     {Questions[i].Answers[z].Text} [Your answer]");
                                        else
                                            stream.Write($"     {Questions[i].Answers[z].Text}");

                                    }
                                }
                                else
                                {
                                    for (int z = 0; z < Answercount; z++)
                                    {

                                        if (Questions[i].Answers[z].Text == Questions[i].Answers.Find(x => x.IsCorrect == "Yes").Text)
                                            stream.Write($"     {Questions[i].Answers[z].Text} [Correct answer]");

                                        else
                                            stream.Write($"     {Questions[i].Answers[z].Text}");

                                    }
                                }

                                stream.Write($"\n");

                            }
                        }
                        
                    }

                    #endregion
                }
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
                    QuestionControl[CurrentQuestion].Location = new Point(14, 70);

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
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.025;
            }
            else
            {
                timer.Stop();
                //WindowState = FormWindowState.Minimized;
                Application.Exit();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            //timer.Interval = 10;
            //timer.Start();
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
            LoginView.Location = new Point(0, 70);
            this.Controls.Add(LoginView);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_EditExam != null && _EditExam.Visible)
            {

                //Control any area filled or not 
                if (_EditExam.Allradiobuttons.Controls.OfType<MetroFramework.Controls.MetroRadioButton>().FirstOrDefault(x => x.Checked == true) != null
                && _EditExam.Alltextbox.Controls.OfType<MetroFramework.Controls.MetroTextBox>().FirstOrDefault(x => x.Text == string.Empty || x.Text == string.Empty) == null
                && _EditExam.Textbox != null
                && _EditExam.Textbox != string.Empty)
                {
                    CustomMessageBox = new CustomMessageBox(CustomMessageBoxButtons.OK);
                    CustomMessageBox.MessageText = "Changes was done";
                    CustomMessageBox.MessageTitle = "Info";

                    Questions[CurrentQuestion].Text = _EditExam.Textbox;

                    #region If Answer add or remove clicked realize this code block

                    if (_EditExam.isClickedAddOrRemoveButton)
                    {
                        this.Questions[CurrentQuestion].Answers.Clear();

                        for (int i = 0; i < _EditExam.AnswerCount; i++)
                        {
                            if ((_EditExam.Allradiobuttons.Controls[i] as MetroFramework.Controls.MetroRadioButton).Checked)
                            {
                                this.Questions[CurrentQuestion].Answers.Add(new Answer()
                                {
                                    Text = _EditExam.Alltextbox.Controls[i].Text,
                                    id = i,
                                    IsCorrect = "Yes"
                                });
                            }
                            else
                            {
                                this.Questions[CurrentQuestion].Answers.Add(new Answer()
                                {
                                    Text = _EditExam.Alltextbox.Controls[i].Text,
                                    id = i,
                                    IsCorrect = "No"
                                });
                            }
                        }
                    }
                    #endregion

                    else
                    {
                        for (int i = 0; i < Questions[CurrentQuestion].Answers.Count; i++)
                        {
                            Questions[CurrentQuestion].Answers[i].Text = _EditExam.Alltextbox.Controls[i].Text;

                            if ((_EditExam.Allradiobuttons.Controls[i] as MetroFramework.Controls.MetroRadioButton).Checked == true)
                                Questions[CurrentQuestion].Answers[i].IsCorrect = "Yes";
                            else
                                Questions[CurrentQuestion].Answers[i].IsCorrect = "No";
                        }
                    }


                    using (StreamWriter stream = new StreamWriter(MainLink + $@"\{_EditExam.SelectedFileName}"))
                    {
                        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<QuestionBlock>));
                        xmlSerializer.Serialize(stream, Questions);
                    }


                    CustomMessageBox.ShowDialog();
                }

                //otherwise this info output
                else
                {
                    CustomMessageBox = new CustomMessageBox(CustomMessageBoxButtons.OK);
                    CustomMessageBox.MessageText = "Please, fill the important area";
                    CustomMessageBox.MessageTitle = "Warning";
                    CustomMessageBox.ShowDialog();
                }
            }

        }
    }
}
