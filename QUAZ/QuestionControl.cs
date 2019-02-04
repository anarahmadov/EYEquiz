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
    public partial class QuestionControl : UserControl
    {
        public MetroFramework.Controls.MetroLabel LabelQuestion { get => labelQuestion; set => labelQuestion = value; }
        public FlowLayoutPanel Flow { get => flowLayoutPanel; set => flowLayoutPanel = value; }

        MainForm mainForm;

        public QuestionControl(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            
        }


    }
}
