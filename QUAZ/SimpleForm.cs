using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUAZ
{
    public partial class SimpleForm : Form
    {
        public MetroFramework.Controls.MetroTextBox FileName { get => txtboxFileName; set => txtboxFileName = value; }
        public string Label { get => labelFileName.Text; set => labelFileName.Text = value; }
        public string FormTitle { get => labelMessageTitle.Text; set => labelMessageTitle.Text = value; }

        public bool Dragging { get; set; }
        public Point StartPoint { get; set; }

        public SimpleForm()
        {
            InitializeComponent();
        }

        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - StartPoint.X, p.Y - StartPoint.Y);
            }
        }

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            StartPoint = new Point(e.X, e.Y);
        }

        private void topPanel_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }
    }
}
