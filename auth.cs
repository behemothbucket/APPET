using System;
using System.Drawing;
using System.Windows.Forms;


namespace APPEET
{
    public partial class auth : Form
    {
        bool drag = false;
        Point start_point = new Point(0, 0);

        public static string name = "";
        public static string second_name = "";
        public static string group = "";
        public static string variant = "";

        public auth()
        {
            InitializeComponent();
            auth_label.Parent = bg_logo;
            name_label.Parent = bg_logo;
            second_name_label.Parent = bg_logo;
            group_label.Parent = bg_logo;
            variant_label.Parent = bg_logo;
            error_label.Parent = bg_logo;
            exit_button.Parent = bg_logo;
            hide_button.Parent = bg_logo;
            header_panel.Parent = bg_logo;
            header_panel.BackColor = Color.Transparent;
            name_label.BackColor = Color.Transparent;
            second_name_label.BackColor = Color.Transparent;
            group_label.BackColor = Color.Transparent;
            variant_label.BackColor = Color.Transparent;
            error_label.BackColor = Color.Transparent;
            exit_button.BackColor = Color.Transparent;
            hide_button.BackColor = Color.Transparent;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name_textbox.AutoSize = false;
            name_textbox.Size = new Size(225, 20);
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_button_Click_1(object sender, EventArgs e)
        {

            if (name_textbox.Text != "" & second_name_textbox.Text != "" & group_textbox.Text != "" & variant_comboBox.Text != "")
            {
                name = name_textbox.Text;
                second_name = second_name_textbox.Text;
                group = group_textbox.Text;
                variant = "Вариант " + variant_comboBox.Text;
                main main_form = new main();
                Hide();
                main_form.Show();
            }
            else
            {
                error_label.Visible = true;
            }

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void hide_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void login_button_MouseDown(object sender, MouseEventArgs e)
        {
            login_button.FlatAppearance.BorderSize = 1;
            login_button.FlatAppearance.BorderColor = Color.FromArgb(15, 98, 254);
        }

        private void login_button_MouseUp(object sender, MouseEventArgs e)
        {
            login_button.FlatAppearance.BorderSize = 0;
            login_button.FlatAppearance.BorderColor = Color.FromArgb(0, 17, 65);
        }

        private void auth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Enter)
            {
                main main_form = new main();
                this.Hide();
                main_form.Show();
            }
        }
    }
}
