using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerRepairManagementSystem
{
    public partial class DashBForm : Form
    {
        public DashBForm()
        {
            InitializeComponent();
            RoundButton(btnAdd, 60);
            RoundButton(btnExit, 20);
            btnAdd.TextAlign = ContentAlignment.MiddleCenter;
            btnAdd.Padding = new Padding(0);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.TabStop = false;
            btnExit.FlatAppearance.MouseOverBackColor = Color.Red;
            btnExit.FlatAppearance.MouseDownBackColor = Color.DarkRed;
            btnExit.TextAlign = ContentAlignment.MiddleCenter;

        }
        private void RoundButton(Button btn, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btn.Width - radius, btn.Height - radius,
                        radius, radius, 0, 90);
            path.AddArc(0, btn.Height - radius,
                        radius, radius, 90, 90);

            path.CloseFigure();

            btn.Region = new Region(path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataForm df = new DataForm();
            df.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
