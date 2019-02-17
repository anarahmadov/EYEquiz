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
    public partial class EditExam : UserControl
    {
        public int AnswerCount { get; set; }
        public int OldAnswerCount { get; set; }
        public string QuestionText { get => txtboxQuestionText.Text; set => txtboxQuestionText.Text = value; }
        public string IsCorrectVariant { get; set; }
        public int CurrentQuestion { get; set; }

        public FlowLayoutPanel Allradiobuttons { get => allRadiobuttons; set => allRadiobuttons = value; }
        public FlowLayoutPanel Alltextbox { get => allTextbox; set => allTextbox = value; }
        public string Textbox { get => txtboxQuestionText.Text; set => txtboxQuestionText.Text = value; }

        public string SelectedFileName { get; set; }

        public bool isClickedAddOrRemoveButton { get; set; }

        public int CurrentAnswersCount { get; set; }

        MainForm MainForm;
        EditOrCreateExam EditOrCreateExam;
        CustomMessageBox CustomMessageBox;
        SimpleForm SimpleForm;
        MetroFramework.Controls.MetroButton addbutton;
        MetroFramework.Controls.MetroButton removebutton;

        public EditExam(MainForm mainForm, EditOrCreateExam editOrCreateExam)
        {
            EditOrCreateExam = editOrCreateExam;
            SelectedFileName = EditOrCreateExam.SelectedFileName;
            MainForm = mainForm;
            InitializeComponent();
        }

        private void btnPrevius_Click(object sender, EventArgs e)
        {
            if (CurrentQuestion > 0)
            {
                --CurrentQuestion;
                txtboxQuestionText.Text = string.Empty;

                allRadiobuttons.Controls.Clear();
                allTextbox.Controls.Clear();

                MainForm.NumberOfQuestion = $"{CurrentQuestion + 1} / {MainForm.Questions.Count} questions";
                AnswerCount = MainForm.Questions[CurrentQuestion].Answers.Count;
                OldAnswerCount = MainForm.Questions[CurrentQuestion].Answers.Count;
                txtboxQuestionText.Text = MainForm.Questions[CurrentQuestion].Text;

                for (int i = 0, x = 15, y = 200; i < AnswerCount; i++, y += 30)
                {
                    var txtbox = new MetroFramework.Controls.MetroTextBox();
                    txtbox.Location = new Point(x + 20, y);
                    txtbox.Size = new Size(720, 20);
                    txtbox.Text = MainForm.Questions[CurrentQuestion].Answers[i].Text;
                    txtbox.UseCustomBackColor = true;
                    txtbox.UseCustomForeColor = true;
                    txtbox.Style = MetroFramework.MetroColorStyle.White;
                    txtbox.BackColor = Color.FromArgb(61, 61, 61);
                    txtbox.ForeColor = Color.White;
                    allTextbox.Controls.Add(txtbox);

                    var radiobutton = new MetroFramework.Controls.MetroRadioButton();
                    radiobutton.Location = new Point(x, y);
                    radiobutton.Size = new Size(20, 20);
                    radiobutton.UseCustomBackColor = true;
                    radiobutton.Style = MetroFramework.MetroColorStyle.Brown;
                    radiobutton.BackColor = Color.FromArgb(61, 61, 61);
                    allRadiobuttons.Controls.Add(radiobutton);
                }

                #region AddAnswer&RemoveAnswer Button initialize        

                var x1 = allTextbox.Controls.OfType<MetroFramework.Controls.MetroTextBox>().Last<MetroFramework.Controls.MetroTextBox>().Location.X + 773;
                var y1 = allTextbox.Controls.OfType<MetroFramework.Controls.MetroTextBox>().Last<MetroFramework.Controls.MetroTextBox>().Location.Y + 160;
                addbutton.Location = new Point(x1, y1);

                removebutton.Location = new Point(x1, y1 + 30);

                #endregion

                for (int i = 0; i < AnswerCount; i++)
                {
                    if (MainForm.Questions[CurrentQuestion].Answers[i].IsCorrect == "Yes")
                        (allRadiobuttons.Controls[i] as MetroFramework.Controls.MetroRadioButton).Checked = true;
                }

            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CurrentQuestion < MainForm.Questions.Count - 1)
            {
                ++CurrentQuestion;
                txtboxQuestionText.Text = string.Empty;

                allRadiobuttons.Controls.Clear();
                allTextbox.Controls.Clear();

                MainForm.NumberOfQuestion = $"{CurrentQuestion + 1} / {MainForm.Questions.Count} questions";
                AnswerCount = MainForm.Questions[CurrentQuestion].Answers.Count;
                OldAnswerCount = MainForm.Questions[CurrentQuestion].Answers.Count;
                txtboxQuestionText.Text = MainForm.Questions[CurrentQuestion].Text;

                for (int i = 0, x = 15, y = 200; i < AnswerCount; i++, y += 30)
                {
                    var txtbox = new MetroFramework.Controls.MetroTextBox();
                    txtbox.Location = new Point(x + 20, y);
                    txtbox.Size = new Size(720, 20);
                    txtbox.Text = MainForm.Questions[CurrentQuestion].Answers[i].Text;
                    txtbox.UseCustomBackColor = true;
                    txtbox.UseCustomForeColor = true;
                    txtbox.Multiline = true;
                    txtbox.Style = MetroFramework.MetroColorStyle.White;
                    txtbox.BackColor = Color.FromArgb(61, 61, 61);
                    txtbox.ForeColor = Color.White;
                    allTextbox.Controls.Add(txtbox);

                    var radiobutton = new MetroFramework.Controls.MetroRadioButton();
                    radiobutton.Location = new Point(x, y);
                    radiobutton.Size = new Size(20, 20);
                    radiobutton.UseCustomBackColor = true;
                    radiobutton.Style = MetroFramework.MetroColorStyle.Brown;
                    radiobutton.BackColor = Color.FromArgb(61, 61, 61);
                    allRadiobuttons.Controls.Add(radiobutton);
                }

                #region AddAnswer&RemoveAnswer Button initialize

                var x1 = allTextbox.Controls.OfType<MetroFramework.Controls.MetroTextBox>().Last<MetroFramework.Controls.MetroTextBox>().Location.X + 773;
                var y1 = allTextbox.Controls.OfType<MetroFramework.Controls.MetroTextBox>().Last<MetroFramework.Controls.MetroTextBox>().Location.Y + 160;
                addbutton.Location = new Point(x1, y1);

                removebutton.Location = new Point(x1, y1 + 30);


                #endregion

                for (int i = 0; i < AnswerCount; i++)
                {
                    if (MainForm.Questions[CurrentQuestion].Answers[i].IsCorrect == "Yes")
                        (allRadiobuttons.Controls[i] as MetroFramework.Controls.MetroRadioButton).Checked = true;
                }

            }
        }

        private void EditExam_Load(object sender, EventArgs e)
        {
            CurrentQuestion = 0;

            if (File.Exists(MainForm.MainLink + $@"\{SelectedFileName}"))
            {
                #region Selected File deserialize
                using (StreamReader streamReader = new StreamReader(MainForm.MainLink + $@"\{SelectedFileName}"))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<QuestionBlock>));
                    var obj = (List<QuestionBlock>)xmlSerializer.Deserialize(streamReader);
                    MainForm.Questions = obj;
                    MainForm.QuestionCount = MainForm.Questions.Count();
                    MainForm.UserAnswers = new List<string>();
                    MainForm.NumberOfQuestion = $"{CurrentQuestion + 1} / {MainForm.Questions.Count} questions";
                }
                #endregion

                txtboxQuestionText.Text = MainForm.Questions[CurrentQuestion].Text;
                AnswerCount = MainForm.Questions[CurrentQuestion].Answers.Count;
                OldAnswerCount = MainForm.Questions[CurrentQuestion].Answers.Count;

                for (int i = 0; i < AnswerCount; i++)
                {
                    var txtbox = new MetroFramework.Controls.MetroTextBox();
                    txtbox.Size = new Size(720, 20);
                    txtbox.Text = MainForm.Questions[CurrentQuestion].Answers[i].Text;
                    txtbox.UseCustomBackColor = true;
                    txtbox.UseCustomForeColor = true;
                    
                    txtbox.Style = MetroFramework.MetroColorStyle.White;
                    txtbox.BackColor = Color.FromArgb(61, 61, 61);
                    txtbox.ForeColor = Color.White;
                    allTextbox.Controls.Add(txtbox);

                    var radiobutton = new MetroFramework.Controls.MetroRadioButton();
                    radiobutton.Size = new Size(20, 20);
                    radiobutton.UseCustomBackColor = true;
                    radiobutton.Style = MetroFramework.MetroColorStyle.Brown;
                    radiobutton.BackColor = Color.FromArgb(61, 61, 61);
                    allRadiobuttons.Controls.Add(radiobutton);
                }

                #region AddAnswer&RemoveAnswer Button initialize

                addbutton = new MetroFramework.Controls.MetroButton();
                addbutton.Size = new Size(20, 25);
                addbutton.Text = "+";
                addbutton.FontWeight = MetroFramework.MetroButtonWeight.Bold;
                addbutton.TextAlign = ContentAlignment.MiddleCenter;
                addbutton.TabStop = false;
                addbutton.UseCustomBackColor = true;
                addbutton.UseCustomForeColor = true;
                addbutton.BackColor = Color.FromArgb(41, 41, 41);
                addbutton.ForeColor = Color.DarkGray;
                addbutton.FontSize = MetroFramework.MetroButtonSize.Medium;
                addbutton.Click += Addbutton_Click;
                this.Controls.Add(addbutton);

                removebutton = new MetroFramework.Controls.MetroButton();
                removebutton.Size = new Size(20, 25);
                removebutton.Text = "-";
                removebutton.FontWeight = MetroFramework.MetroButtonWeight.Bold;
                removebutton.TextAlign = ContentAlignment.MiddleCenter;
                removebutton.TabStop = false;
                removebutton.UseCustomBackColor = true;
                removebutton.UseCustomForeColor = true;
                removebutton.BackColor = Color.FromArgb(41, 41, 41);
                removebutton.ForeColor = Color.DarkGray;
                removebutton.FontSize = MetroFramework.MetroButtonSize.Medium;
                removebutton.Click += Removebutton_Click;
                this.Controls.Add(removebutton);

                var x = allTextbox.Controls.OfType<MetroFramework.Controls.MetroTextBox>().Last<MetroFramework.Controls.MetroTextBox>().Location.X + 773;
                var y = allTextbox.Controls.OfType<MetroFramework.Controls.MetroTextBox>().Last<MetroFramework.Controls.MetroTextBox>().Location.Y + 160;
                addbutton.Location = new Point(x, y);

                removebutton.Location = new Point(x, y + 30);


                #endregion

                for (int i = 0; i < AnswerCount; i++)
                {
                    if (MainForm.Questions[CurrentQuestion].Answers[i].IsCorrect == "Yes")
                        (allRadiobuttons.Controls[i] as MetroFramework.Controls.MetroRadioButton).Checked = true;
                }
            }


        }

        private void Removebutton_Click(object sender, EventArgs e)
        {
            if (AnswerCount > 2)
            {
                isClickedAddOrRemoveButton = true;

                var last = allRadiobuttons.Controls.OfType<MetroFramework.Controls.MetroRadioButton>().Last<MetroFramework.Controls.MetroRadioButton>();
                allRadiobuttons.Controls.Remove(last);
                var last2 = allTextbox.Controls.OfType<MetroFramework.Controls.MetroTextBox>().Last<MetroFramework.Controls.MetroTextBox>();
                allTextbox.Controls.Remove(last2);

                --AnswerCount;

                //var x = addbutton.Location.X;
                //var y = addbutton.Location.Y - 30;
                var x = allTextbox.Controls.OfType<MetroFramework.Controls.MetroTextBox>().Last<MetroFramework.Controls.MetroTextBox>().Location.X + 773;
                var y = allTextbox.Controls.OfType<MetroFramework.Controls.MetroTextBox>().Last<MetroFramework.Controls.MetroTextBox>().Location.Y + 160;
                addbutton.Location = new Point(x, y);
                removebutton.Location = new Point(x, y + 30);
            }
            else
            {
                CustomMessageBox = new CustomMessageBox(CustomMessageBoxButtons.OK);
                CustomMessageBox.MessageText = "Min answer count is 2";
                CustomMessageBox.MessageTitle = "Warning";
                CustomMessageBox.ShowDialog();
            }
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            if (AnswerCount < 7)
            {
                isClickedAddOrRemoveButton = true;

                var radiobutton = new MetroFramework.Controls.MetroRadioButton();
                radiobutton.Size = new Size(20, 20);
                radiobutton.UseCustomBackColor = true;
                radiobutton.Style = MetroFramework.MetroColorStyle.Brown;
                radiobutton.BackColor = Color.FromArgb(61, 61, 61);
                allRadiobuttons.Controls.Add(radiobutton);

                var txtbox = new MetroFramework.Controls.MetroTextBox();
                txtbox.Size = new Size(720, 20);
                txtbox.UseCustomBackColor = true;
                txtbox.UseCustomForeColor = true;
                txtbox.Style = MetroFramework.MetroColorStyle.Silver;
                txtbox.BackColor = Color.FromArgb(61, 61, 61);
                txtbox.ForeColor = Color.White;
                allTextbox.Controls.Add(txtbox);

                ++AnswerCount;

                var x = allTextbox.Controls.OfType<MetroFramework.Controls.MetroTextBox>().Last<MetroFramework.Controls.MetroTextBox>().Location.X + 773;
                var y = allTextbox.Controls.OfType<MetroFramework.Controls.MetroTextBox>().Last<MetroFramework.Controls.MetroTextBox>().Location.Y + 160;
                addbutton.Location = new Point(x, y);
                removebutton.Location = new Point(x, y + 30);
            }
            else
            {
                CustomMessageBox = new CustomMessageBox(CustomMessageBoxButtons.OK);
                CustomMessageBox.MessageText = "Max answer count is 7";
                CustomMessageBox.MessageTitle = "Warning";
                CustomMessageBox.ShowDialog();
            }
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            btnAddQuestion.Enabled = false;
            btnPreviuos.Enabled = false;
            btnNext.Enabled = false;

            isClickedAddOrRemoveButton = true;

            txtboxQuestionText.Text = string.Empty;
            AnswerCount = 2;
            OldAnswerCount = 0;

            int z = 0;

            foreach (var item in allRadiobuttons.Controls)
            {
                z++;
            }

            for (int i = 0; i < z - 1; i++)
            {
                allTextbox.Controls[i].Text = string.Empty;
                (allRadiobuttons.Controls[i] as MetroFramework.Controls.MetroRadioButton).Checked = false;
            }

            for (int i = z - 1; i > 1; i--)
            {
                allTextbox.Controls[i].Dispose();
                allRadiobuttons.Controls[i].Dispose();
            }


            var x = allTextbox.Controls.OfType<MetroFramework.Controls.MetroTextBox>().Last<MetroFramework.Controls.MetroTextBox>().Location.X + 773;
            var y = allTextbox.Controls.OfType<MetroFramework.Controls.MetroTextBox>().Last<MetroFramework.Controls.MetroTextBox>().Location.Y + 160;
            addbutton.Location = new Point(x, y);
            removebutton.Location = new Point(x, y + 30);


            int c = 0;

            foreach (var item in MainForm.Questions)
            {
                ++c;
            }

            QuestionBlock questionBlock = new QuestionBlock()
            {
                Answers = new List<Answer>()
            };

            MainForm.Questions.Add(questionBlock);

            CurrentQuestion = c;

            MainForm.NumberOfQuestion = $"{CurrentQuestion + 1} / {MainForm.Questions.Count} questions";

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            MainForm._EditOrCreateExam.Visible = true;
            MainForm.NumberOfQuestion = string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Control any area filled or not 
            if (allRadiobuttons.Controls.OfType<MetroFramework.Controls.MetroRadioButton>().FirstOrDefault(x => x.Checked == true) != null
                && allTextbox.Controls.OfType<MetroFramework.Controls.MetroTextBox>().FirstOrDefault(x => x.Text == string.Empty || x.Text == string.Empty) == null
                && txtboxQuestionText.Text != null
                && txtboxQuestionText.Text != string.Empty)
            {
                MainForm.Questions[CurrentQuestion].Text = txtboxQuestionText.Text;

                #region Added OR Removed Answers realization

                //if (OldAnswerCount < AnswerCount)
                //{
                //    for (int i = OldAnswerCount; i < OldAnswerCount + (AnswerCount - OldAnswerCount); i++)
                //    {
                //        if ((allRadiobuttons.Controls[i] as MetroFramework.Controls.MetroRadioButton).Checked)
                //        {
                //            MainForm.Questions[CurrentQuestion].Answers.Add(new Answer()
                //            {
                //                Text = allTextbox.Controls[i].Text,
                //                id = i,
                //                IsCorrect = "Yes"
                //            });
                //        }
                //        else
                //        {
                //            MainForm.Questions[CurrentQuestion].Answers.Add(new Answer()
                //            {
                //                Text = allTextbox.Controls[i].Text,
                //                id = i,
                //                IsCorrect = "No"
                //            });
                //        }
                //    }
                //}
                //else if (OldAnswerCount > AnswerCount)
                //{
                //    for (int i = OldAnswerCount - 1; i > OldAnswerCount - (OldAnswerCount - AnswerCount) - 1; i--)
                //    {
                //        MainForm.Questions[CurrentQuestion].Answers.RemoveAt(i);
                //    }
                //}
                #endregion

                #region If Answer add or remove clicked realize this code block

                if (isClickedAddOrRemoveButton)
                {
                    MainForm.Questions[CurrentQuestion].Answers.Clear();

                    for (int i = 0; i < AnswerCount; i++)
                    {
                        if ((allRadiobuttons.Controls[i] as MetroFramework.Controls.MetroRadioButton).Checked)
                        {
                            MainForm.Questions[CurrentQuestion].Answers.Add(new Answer()
                            {
                                Text = allTextbox.Controls[i].Text,
                                id = i,
                                IsCorrect = "Yes"
                            });
                        }
                        else
                        {
                            MainForm.Questions[CurrentQuestion].Answers.Add(new Answer()
                            {
                                Text = allTextbox.Controls[i].Text,
                                id = i,
                                IsCorrect = "No"
                            });
                        }
                    }
                }
                #endregion

                else
                {
                    for (int i = 0; i < MainForm.Questions[CurrentQuestion].Answers.Count; i++)
                    {
                        MainForm.Questions[CurrentQuestion].Answers[i].Text = allTextbox.Controls[i].Text;

                        if ((allRadiobuttons.Controls[i] as MetroFramework.Controls.MetroRadioButton).Checked == true)
                            MainForm.Questions[CurrentQuestion].Answers[i].IsCorrect = "Yes";
                        else
                            MainForm.Questions[CurrentQuestion].Answers[i].IsCorrect = "No";
                    }
                }

                using (StreamWriter stream = new StreamWriter(MainForm.MainLink + $@"\{SelectedFileName}"))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<QuestionBlock>));
                    xmlSerializer.Serialize(stream, MainForm.Questions);
                }

                CustomMessageBox = new CustomMessageBox(CustomMessageBoxButtons.OK);
                CustomMessageBox.MessageText = "Changes was done";
                CustomMessageBox.MessageTitle = "Info";

                CustomMessageBox.ShowDialog();

                isClickedAddOrRemoveButton = false;

                btnAddQuestion.Enabled = true;
                btnNext.Enabled = true;
                btnPreviuos.Enabled = true;
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

        private void btnRemoveQuestion_Click(object sender, EventArgs e)
        {
            
            CustomMessageBox = new CustomMessageBox(CustomMessageBoxButtons.OKCancel);
            CustomMessageBox.MessageText = "Are you sure?";
            CustomMessageBox.MessageTitle = "Warning";
            var dialog = CustomMessageBox.ShowDialog();

            if (dialog == DialogResult.OK)
            {
                btnNext.Enabled = true;
                btnPreviuos.Enabled = true;
                btnAddQuestion.Enabled = true;

                MainForm.Questions.RemoveAt(CurrentQuestion);

                using (StreamWriter stream = new StreamWriter(MainForm.MainLink + $@"\{SelectedFileName}"))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<QuestionBlock>));
                    xmlSerializer.Serialize(stream, MainForm.Questions);
                }
            }
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            SimpleForm = new SimpleForm();

            if (SimpleForm.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter stream = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + $@"\EYEquiz\{SimpleForm.FileName.Text}.xml"))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<QuestionBlock>));
                    serializer.Serialize(stream, MainForm.Questions);
                }

                CustomMessageBox = new CustomMessageBox(CustomMessageBoxButtons.OK);
                CustomMessageBox.MessageText = "Exam saved succesfully...";
                CustomMessageBox.MessageTitle = "Info";
                CustomMessageBox.ShowDialog();
            }
        }

        private void EditExam_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                MainForm.MenuStrip.Enabled = true;
            }
        }
    }
}
