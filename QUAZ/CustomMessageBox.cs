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
    public partial class CustomMessageBox : Form
    {
        public string MessageTitle { get => labelMessageTitle.Text; set => labelMessageTitle.Text = value; }
        public string MessageText { get => labelMessageText.Text; set => labelMessageText.Text = value; }

        public bool Dragging { get; set; }
        public Point StartPoint { get; set; }

        public CustomMessageBox()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
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
