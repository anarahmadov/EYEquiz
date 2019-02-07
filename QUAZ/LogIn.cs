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

            var directory = Directory.CreateDirectory(".");

                
         
        }
    }
}
