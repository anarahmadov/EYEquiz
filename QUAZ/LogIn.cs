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
using QUAZ.DataBase;
using QUAZ.Model;
using System.Data.Entity;
using System.Text.RegularExpressions;

namespace QUAZ
{
    public partial class LogIn : UserControl
    {
        private MainForm MainForm;
        UserContext DB;
        CustomMessageBox CustomMessageBox;
        public Regex EmailFormat { get; set; }

        public LogIn(MainForm mainForm)
        {
            MainForm = mainForm;
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (txtboxLPassword.Text != string.Empty && txtboxLEmail.Text != string.Empty)
            {
                if (EmailFormat.IsMatch(txtboxLEmail.Text))
                {
                    if (DB.Users.SingleOrDefault(x => x.Email == txtboxLEmail.Text && x.Password == txtboxLPassword.Text) != null)
                    {
                        this.Visible = false;

                        MainForm.FullNameUser = DB.Users.Single(x => x.Email == txtboxLEmail.Text).FullName;

                        MainForm._AddQuestionOrGoExam = new AddQuestionOrGoExam(MainForm);
                        MainForm._AddQuestionOrGoExam.Location = new Point(0, 60);
                        MainForm.Controls.Add(MainForm._AddQuestionOrGoExam);

                        txtboxLEmail.Text = string.Empty;
                        txtboxLPassword.Text = string.Empty;

                        var currentpath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\EYEquiz";

                        if (!Directory.Exists(currentpath))
                        {
                            Directory.CreateDirectory(currentpath);
                        }

                        var current = "QuestionsXML.xml";

                        if (!File.Exists(currentpath + @"\QuestionsXML.xml"))
                        {
                            File.Copy(current, Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\EYEquiz\QuestionsXML.xml");
                        }
                    }
                    else
                    {
                        CustomMessageBox = new CustomMessageBox(CustomMessageBoxButtons.OK);
                        CustomMessageBox.MessageText = "Not fount this user";
                        CustomMessageBox.MessageTitle = "Error";
                        CustomMessageBox.ShowDialog();
                    }
                }
                else
                {
                    CustomMessageBox = new CustomMessageBox(CustomMessageBoxButtons.OK);
                    CustomMessageBox.MessageText = "Email format is not valid";
                    CustomMessageBox.MessageTitle = "Warning";
                    CustomMessageBox.ShowDialog();
                }
            }
            else
            {
                CustomMessageBox = new CustomMessageBox(CustomMessageBoxButtons.OK);
                CustomMessageBox.MessageText = "Fill the compulsory area";
                CustomMessageBox.MessageTitle = "Warning";
                CustomMessageBox.ShowDialog();
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtboxFullName.Text != string.Empty && txtboxRePassword.Text != string.Empty
                    && txtboxRPassword.Text != string.Empty && txtboxREmail.Text != string.Empty)
            {
                if (txtboxRPassword.Text == txtboxRePassword.Text)
                {
                    if (DB.Users.SingleOrDefault(x => x.Email == txtboxREmail.Text) == null)
                    {
                        if (EmailFormat.IsMatch(txtboxREmail.Text))
                        {
                            User user = new User()
                            {
                                Email = txtboxREmail.Text,
                                Password = txtboxRPassword.Text,
                                FullName = txtboxFullName.Text,
                            };

                            DB.Users.Add(user);
                            DB.SaveChanges();

                            txtboxRePassword.Text = string.Empty;
                            txtboxRPassword.Text = string.Empty;
                            txtboxREmail.Text = string.Empty;
                            txtboxFullName.Text = string.Empty;

                            CustomMessageBox = new CustomMessageBox(CustomMessageBoxButtons.OK);
                            CustomMessageBox.MessageText = "Succesfully registered..";
                            CustomMessageBox.MessageTitle = "Info";
                            CustomMessageBox.ShowDialog();
                        }
                        else
                        {
                            CustomMessageBox = new CustomMessageBox(CustomMessageBoxButtons.OK);
                            CustomMessageBox.MessageText = "E-mail format is not valid";
                            CustomMessageBox.MessageTitle = "Warning";
                            CustomMessageBox.ShowDialog();
                        }
                    }
                    else
                    {
                        CustomMessageBox = new CustomMessageBox(CustomMessageBoxButtons.OK);
                        CustomMessageBox.MessageText = "This e-mail was registered already";
                        CustomMessageBox.MessageTitle = "Warning";
                        CustomMessageBox.ShowDialog();
                    }
                }
                else
                {
                    CustomMessageBox = new CustomMessageBox(CustomMessageBoxButtons.OK);
                    CustomMessageBox.MessageText = "Passwords are not match";
                    CustomMessageBox.MessageTitle = "Error";
                    CustomMessageBox.ShowDialog();
                }
            }
            else
            {
                CustomMessageBox = new CustomMessageBox(CustomMessageBoxButtons.OK);
                CustomMessageBox.MessageText = "Please, fill all area";
                CustomMessageBox.MessageTitle = "Warning";
                CustomMessageBox.ShowDialog();
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            DB = new UserContext();
            EmailFormat = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        }
    }
}
