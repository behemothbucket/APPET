using System;
using System.Drawing;
using System.Windows.Forms;

namespace APPEET
{
    public partial class theory_form : Form
    {
        bool drag = false;
        Point start_point = new Point(0, 0);
        public theory_form()
        {
            InitializeComponent();
            string startup = Application.StartupPath + @"\html\welcome.html";
            html_viewer.Navigate(startup);
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hide_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void top_panel_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void top_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void top_panel_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            main main = new main();
            main.Show();
            this.Close();
        }

        private void main_menu_button_MouseDown(object sender, MouseEventArgs e)
        {
            main_menu_button.FlatAppearance.BorderSize = 1;
            main_menu_button.FlatAppearance.BorderColor = Color.FromArgb(15, 98, 254);
        }

        private void main_menu_button_MouseUp(object sender, MouseEventArgs e)
        {
            main_menu_button.FlatAppearance.BorderSize = 0;
            main_menu_button.FlatAppearance.BorderColor = Color.FromArgb(0, 17, 65);
        }

        private void flowLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            flowLayoutPanel1.BackColor = Color.FromArgb(25, 25, 25);
            flowLayoutPanel2.BackColor = Color.FromArgb(38, 38, 38);
            flowLayoutPanel3.BackColor = Color.FromArgb(38, 38, 38);
            flowLayoutPanel5.BackColor = Color.FromArgb(38, 38, 38);
            flowLayoutPanel6.BackColor = Color.FromArgb(38, 38, 38);
            flowLayoutPanel4.BackColor = Color.FromArgb(38, 38, 38);
            //string applicationDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            //string myFile = Path.Combine(applicationDirectory, @"html\introduction.html");
            //html_viewer.Url = new Uri("file:///" + myFile);
            string path = Application.StartupPath + @"\html\introduction.html";
            html_viewer.Navigate(path);
        }

        private void flowLayoutPanel2_MouseClick(object sender, MouseEventArgs e)
        {
            flowLayoutPanel1.BackColor = Color.FromArgb(38, 38, 38);
            flowLayoutPanel2.BackColor = Color.FromArgb(25, 25, 25);
            flowLayoutPanel3.BackColor = Color.FromArgb(38, 38, 38);
            flowLayoutPanel5.BackColor = Color.FromArgb(38, 38, 38);
            flowLayoutPanel6.BackColor = Color.FromArgb(38, 38, 38);
            flowLayoutPanel4.BackColor = Color.FromArgb(38, 38, 38);
            string path = Application.StartupPath + @"\html\criteria.html";
            html_viewer.Navigate(path);
        }

        private void flowLayoutPanel3_MouseClick(object sender, MouseEventArgs e)
        {
            flowLayoutPanel1.BackColor = Color.FromArgb(38, 38, 38);
            flowLayoutPanel2.BackColor = Color.FromArgb(38, 38, 38);
            flowLayoutPanel3.BackColor = Color.FromArgb(25, 25, 25);
            flowLayoutPanel5.BackColor = Color.FromArgb(38, 38, 38);
            flowLayoutPanel6.BackColor = Color.FromArgb(38, 38, 38);
            flowLayoutPanel4.BackColor = Color.FromArgb(38, 38, 38);
            string path = Application.StartupPath + @"\html\algoritm.html";
            html_viewer.Navigate(path);
        }

        private void prim_label_MouseClick(object sender, MouseEventArgs e)
        {
            flowLayoutPanel1.BackColor = Color.FromArgb(38, 38, 38);
            flowLayoutPanel2.BackColor = Color.FromArgb(38, 38, 38);
            flowLayoutPanel3.BackColor = Color.FromArgb(38, 38, 38);
            flowLayoutPanel5.BackColor = Color.FromArgb(25, 25, 25);
            flowLayoutPanel6.BackColor = Color.FromArgb(38, 38, 38);
            flowLayoutPanel4.BackColor = Color.FromArgb(38, 38, 38);
            string path = Application.StartupPath + @"\html\prim.html";
            html_viewer.Navigate(path);
        }

        private void end_label_MouseClick(object sender, MouseEventArgs e)
        {
            flowLayoutPanel1.BackColor = Color.FromArgb(38, 38, 38);
            flowLayoutPanel2.BackColor = Color.FromArgb(38, 38, 38);
            flowLayoutPanel3.BackColor = Color.FromArgb(38, 38, 38);
            flowLayoutPanel5.BackColor = Color.FromArgb(38, 38, 38);
            flowLayoutPanel6.BackColor = Color.FromArgb(25, 25, 25);
            flowLayoutPanel4.BackColor = Color.FromArgb(38, 38, 38);
            string path = Application.StartupPath + @"\html\end.html";
            html_viewer.Navigate(path);
        }

        private void pril_label_MouseClick(object sender, MouseEventArgs e)
        {
            flowLayoutPanel1.BackColor = Color.FromArgb(38, 38, 38);
            flowLayoutPanel2.BackColor = Color.FromArgb(38, 38, 38);
            flowLayoutPanel3.BackColor = Color.FromArgb(38, 38, 38);
            flowLayoutPanel4.BackColor = Color.FromArgb(25, 25, 25);
            flowLayoutPanel5.BackColor = Color.FromArgb(38, 38, 38);
            flowLayoutPanel6.BackColor = Color.FromArgb(38, 38, 38);
            string path = Application.StartupPath + @"\html\pril.html";
            html_viewer.Navigate(path);
        }

        private void flowLayoutPanel4_MouseClick(object sender, MouseEventArgs e)
        {
            flowLayoutPanel1.BackColor = Color.FromArgb(38, 38, 38);
            flowLayoutPanel2.BackColor = Color.FromArgb(38, 38, 38);
            flowLayoutPanel3.BackColor = Color.FromArgb(38, 38, 38);
            flowLayoutPanel4.BackColor = Color.FromArgb(25, 25, 25);
            flowLayoutPanel5.BackColor = Color.FromArgb(38, 38, 38);
            flowLayoutPanel6.BackColor = Color.FromArgb(38, 38, 38);
            string path = Application.StartupPath + @"\html\pril.html";
            html_viewer.Navigate(path);
        }

        private void flowLayoutPanel5_MouseClick(object sender, MouseEventArgs e)
        {
            flowLayoutPanel1.BackColor = Color.FromArgb(38, 38, 38);
            flowLayoutPanel2.BackColor = Color.FromArgb(38, 38, 38);
            flowLayoutPanel3.BackColor = Color.FromArgb(38, 38, 38);
            flowLayoutPanel5.BackColor = Color.FromArgb(25, 25, 25);
            flowLayoutPanel6.BackColor = Color.FromArgb(38, 38, 38);
            flowLayoutPanel4.BackColor = Color.FromArgb(38, 38, 38);
            string path = Application.StartupPath + @"\html\prim.html";
            html_viewer.Navigate(path);
        }

        private void flowLayoutPanel6_MouseClick(object sender, MouseEventArgs e)
        {
            flowLayoutPanel1.BackColor = Color.FromArgb(38, 38, 38);
            flowLayoutPanel2.BackColor = Color.FromArgb(38, 38, 38);
            flowLayoutPanel3.BackColor = Color.FromArgb(38, 38, 38);
            flowLayoutPanel5.BackColor = Color.FromArgb(38, 38, 38);
            flowLayoutPanel6.BackColor = Color.FromArgb(25, 25, 25);
            flowLayoutPanel4.BackColor = Color.FromArgb(38, 38, 38);
            string path = Application.StartupPath + @"\html\end.html";
            html_viewer.Navigate(path);
        }
    }
}
