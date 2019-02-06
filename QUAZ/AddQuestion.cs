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
    }
}
