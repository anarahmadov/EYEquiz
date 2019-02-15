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

        public CustomMessageBox(CustomMessageBoxButtons button)
        {
            InitializeComponent();

            if (button is CustomMessageBoxButtons.OK)
            {
                var btnOk = new MetroFramework.Controls.MetroButton();
                btnOk.Location = new Point(80, 88);
                btnOk.Size = new Size(75, 23);
                btnOk.UseCustomBackColor = true;
                btnOk.UseCustomForeColor = true;
                btnOk.BackColor = Color.FromArgb(41, 41, 41);
                btnOk.ForeColor = Color.DarkGray;
                btnOk.TabStop = false;
                btnOk.Text = "OK";
                btnOk.DialogResult = DialogResult.OK;
                this.Controls.Add(btnOk);
            }

            else if(button is CustomMessageBoxButtons.OKCancel)
            {
                var btnOk = new MetroFramework.Controls.MetroButton();
                btnOk.Location = new Point(50, 88);
                btnOk.Size = new Size(60, 23);
                btnOk.UseCustomBackColor = true;
                btnOk.UseCustomForeColor = true;
                btnOk.BackColor = Color.FromArgb(41, 41, 41);
                btnOk.ForeColor = Color.DarkGray;
                btnOk.TabStop = false;
                btnOk.Text = "OK";
                btnOk.DialogResult = DialogResult.OK;
                this.Controls.Add(btnOk);

                var btnCancel = new MetroFramework.Controls.MetroButton();
                btnCancel.Location = new Point(130, 88);
                btnCancel.Size = new Size(60, 23);
                btnCancel.UseCustomBackColor = true;
                btnCancel.UseCustomForeColor = true;
                btnCancel.BackColor = Color.FromArgb(41, 41, 41);
                btnCancel.ForeColor = Color.DarkGray;
                btnCancel.TabStop = false;
                btnCancel.Text = "Cancel";
                btnCancel.DialogResult = DialogResult.Cancel;
                this.Controls.Add(btnCancel);
            }
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

    public enum CustomMessageBoxButtons
    {
        OK = 0,
        OKCancel
    }
}
