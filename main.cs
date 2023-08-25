using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace APPEET
{
    public partial class main : Form
    {
        bool drag = false;
        bool isClicked = true;
        Point start_point = new Point(0, 0);

        public main()
        {
            InitializeComponent();
            fullname_label.Text = auth.name + " " + auth.second_name;
            group_label.Text = auth.group;
            variant_label.Text = auth.variant;
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void header_panel_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void header_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void header_panel_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void hide_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void relogin_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            auth login_form = new auth();
            login_form.Show();
            this.Close();
        }

        private void description_button_MouseDown(object sender, MouseEventArgs e)
        {
            description_button.FlatAppearance.BorderSize = 1;
            description_button.FlatAppearance.BorderColor = Color.FromArgb(15, 98, 254);
        }

        private void description_button_MouseUp(object sender, MouseEventArgs e)
        {
            description_button.FlatAppearance.BorderSize = 0;
            description_button.FlatAppearance.BorderColor = Color.FromArgb(22, 22, 22);
        }

        private void theory_button_MouseDown(object sender, MouseEventArgs e)
        {
            theory_button.FlatAppearance.BorderSize = 1;
            theory_button.FlatAppearance.BorderColor = Color.FromArgb(15, 98, 254);
        }

        private void theory_button_MouseUp(object sender, MouseEventArgs e)
        {
            theory_button.FlatAppearance.BorderSize = 0;
            theory_button.FlatAppearance.BorderColor = Color.FromArgb(22, 22, 22);
        }

        private void search_button_MouseDown(object sender, MouseEventArgs e)
        {
            search_button.FlatAppearance.BorderSize = 1;
            search_button.FlatAppearance.BorderColor = Color.FromArgb(15, 98, 254);
        }

        private void search_button_MouseUp(object sender, MouseEventArgs e)
        {
            search_button.FlatAppearance.BorderSize = 0;
            search_button.FlatAppearance.BorderColor = Color.FromArgb(22, 22, 22);
        }

        private void calculate_button_MouseDown(object sender, MouseEventArgs e)
        {
            calculate_button.FlatAppearance.BorderSize = 1;
            calculate_button.FlatAppearance.BorderColor = Color.FromArgb(15, 98, 254);
        }

        private void calculate_button_MouseUp(object sender, MouseEventArgs e)
        {
            calculate_button.FlatAppearance.BorderSize = 0;
            calculate_button.FlatAppearance.BorderColor = Color.FromArgb(22, 22, 22);
        }

        private void variant_label_MouseHover(object sender, EventArgs e)
        {
            variant_label.ForeColor = Color.White;
        }

        private void variant_label_MouseLeave(object sender, EventArgs e)
        {
            variant_label.ForeColor = Color.FromArgb(105, 105, 105);
        }

        private void group_label_MouseHover(object sender, EventArgs e)
        {
            group_label.Font = new Font(group_label.Font.Name, group_label.Font.SizeInPoints, FontStyle.Underline);
        }

        private void group_label_MouseLeave(object sender, EventArgs e)
        {
            group_label.Font = new Font(group_label.Font.Name, group_label.Font.SizeInPoints, FontStyle.Regular);
        }

        private void theory_button_Click(object sender, EventArgs e)
        {
            theory_form theory_form = new theory_form();
            theory_form.Show();
            theory_form = null;
            this.Close();
        }

        private void description_button_Click(object sender, EventArgs e)
        {
            description_form description_form = new description_form();
            description_form.Show();
            this.Close();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            search search_form = new search();
            search_form.Show();
            this.Close();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            information_panel.Visible = true;
            description_label1.Visible = true;
            description_label2.Visible = true;
            description_label3.Visible = true;
        }

        private void picture_arrow_2_MouseHover(object sender, EventArgs e)
        {
            picture_arrow_2.BackColor = Color.FromArgb(30, 30, 30);
        }

        private void picture_arrow_2_MouseLeave(object sender, EventArgs e)
        {
            picture_arrow_2.BackColor = Color.FromArgb(38, 38, 38);
        }

        private void question_button_Click(object sender, EventArgs e)
        {
            information_panel.Visible = true;
        }

        private void calculate_button_Click(object sender, EventArgs e)
        {
            calculate calculate = new calculate();
            calculate.Show();
            this.Close();
        }

        private void like_Click(object sender, EventArgs e)
        {
            try
            {
                dislike.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"images\icons\dislikeEmpty.png");
                like.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"images\icons\fillLike.png");
                user_picture.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"images\icons\wink.png");
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("Куда-то делся файлик...", "Не найден файл для вашей реакции");

            }

        }

        private void dislike_Click(object sender, EventArgs e)
        {
            try
            {
                like.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"images\icons\likeEmpty.png");
                dislike.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"images\icons\fillDislike.png");
                user_picture.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"images\icons\sad.png");
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("Куда-то делся файлик...", "Не найден файл для вашей реакции");
            }
        }

        private void admin_Click(object sender, EventArgs e)
        {
            if (isClicked)
            {
                password_label.Visible = true;
                password_textbox.Visible = true;
                isClicked = false;
            }
            else
            {
                password_label.Visible = false;
                password_textbox.Visible = false;
                password_textbox.Text = "";
                isClicked = true;
            }
        }

        private void password_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Enter) && password_textbox.Text == "81771")
            {
                if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"db\elementDb.db") == true)
                {
                    password_textbox.Text = "";
                    //variants variants = new variants();
                    //variants.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show(
                   "Неверная база данных или нет файла самой базы",
                   "Внимание",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.None,
                   MessageBoxDefaultButton.Button1,
                   MessageBoxOptions.DefaultDesktopOnly);
                }
            }
        }
    }
}