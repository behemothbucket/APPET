using System;
using System.Data.SQLite;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace APPEET
{
    public partial class description_form : Form
    {
        bool drag = false;
        Point start_point = new Point(0, 0);
        public static string variantDescription;
        public description_form()
        {
            InitializeComponent();
            html_viewer.Navigate(Application.StartupPath + @"\html\description.html");
            variant_label.Text = auth.variant != "" ? auth.variant : "";
            richTextBox1.Text = getVarDesc() != "" ? getVarDesc() : "";
            richTextBox1.BackColor = Color.FromArgb(18, 22, 25);
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private string getVarDesc()
        {
            string variantInt = Regex.Match(variant_label.Text, @"\d+").Value;
            string result = "";
            if (variantInt != "")
            {
                string sql = string.Format("SELECT [Условие] FROM variants WHERE ID = {0}", variantInt);
                using (SQLiteConnection connection = new SQLiteConnection("Data Source = " + AppDomain.CurrentDomain.BaseDirectory + @"db\elementDb.db", true))
                {
                    using (SQLiteCommand command = connection.CreateCommand())
                    {
                        connection.Open();
                        using (SQLiteCommand cmd = new SQLiteCommand())
                        {
                            cmd.Connection = connection;
                            cmd.CommandText = sql;
                            Console.WriteLine(cmd.CommandText.ToString());
                            SQLiteDataReader reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                result = reader[0].ToString();
                            }
                        }
                        connection.Close();
                    }
                }
            }
            return result;
        }

        private void hide_button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void main_menu_button_Click(object sender, EventArgs e)
        {
            main main = new main();
            main.Show();
            Close();
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
                Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void top_panel_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        public void mainButtonControl()
        {
            main_menu_button.Visible = false;
            exit_button.Click -= exit_button_Click;
            exit_button.Click += new EventHandler(OnClick);
        }

        private void OnClick(object sender,  EventArgs e)
        {
            Close();
        }
    }
}
