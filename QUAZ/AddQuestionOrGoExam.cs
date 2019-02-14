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
    public partial class AddQuestionOrGoExam : UserControl
    {
        MainForm MainForm;

        public AddQuestionOrGoExam(MainForm mainForm)
        {
            MainForm = mainForm;
            InitializeComponent();
        }

        private void btnAddQuestions_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if(MainForm._AddQuestion == null)
            {
                MainForm._EditOrCreateExam = new EditOrCreateExam(MainForm);
                MainForm._EditOrCreateExam.Location = new Point(0, 80);
                MainForm.Controls.Add(MainForm._EditOrCreateExam);
            }
            else
            {
                MainForm._EditOrCreateExam.Visible = true;
            }

        }

        private void btnGoExam_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if(MainForm._ChooseQuestions == null)
            {
                MainForm._ChooseQuestions = new ChooseQuestions(MainForm);
                MainForm._ChooseQuestions.Location = new Point(0, 80);
                MainForm.Controls.Add(MainForm._ChooseQuestions);
            }
            else
            {
                MainForm._ChooseQuestions.Visible = true;
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MainForm.LoginView.Visible = true;
            MainForm._ChooseQuestions = null;
            MainForm._AddQuestionOrGoExam = null;
            MainForm._AddQuestion = null;
            
        }
    }
}
