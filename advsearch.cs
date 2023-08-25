using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace APPEET
{
    public partial class advsearch : Form

    {
        Point start_point = new Point(0, 0);
        bool drag = false;


        public static string parameter, value;
        public int parameterCount;
        public static StringBuilder parametresHere = new StringBuilder();

        public advsearch()
        {
            InitializeComponent();
            loadParametres();
        }

        public void loadParametres()
        {
            string[] parametres = search.parametres.ToString().Split(new char[] { ';' });

            foreach (string parameter in parametres)
            {
                if (parameter.Trim() != ";")
                    parameter_comboBox.Items.Add(parameter);
            }
        }

        private void top_panel_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void top_panel_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void top_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        public void exit_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void hide_button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        private void clear_Click(object sender, EventArgs e)
        {
            status_richTextBox.Clear();
            status_richTextBox.AppendText("Очищено...");
            advsearch_button.Enabled = false;
            parameter_comboBox.SelectedIndex = -1;
            value_textBox.Text = "";
        }

        private void add_Click(object sender, EventArgs e)
        {
            status_richTextBox.AppendText("\r\n" + "[Добавлено] " + parameter_comboBox.Text + " = " + value_textBox.Text);
            status_richTextBox.ScrollToCaret();

            parameterCount++;
            parameter = parameter_comboBox.SelectedItem.ToString();
            value = value_textBox.Text;

            if (parameterCount == 1)
            {
                parametresHere.Append(string.Format("[{0}] LIKE '%{1}%'", advsearch.parameter, advsearch.value));
            }
            else
            {
                parametresHere.Append(string.Format(" AND [{0}] LIKE '%{1}%'", advsearch.parameter, advsearch.value));
            }

            advsearch_button.Enabled = true;
            parameter_comboBox.SelectedIndex = -1;
            value_textBox.Text = "";
            clear.Enabled = true;
        }

        private void parameter_comboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
               add.Enabled = true;
        }

        private void advsearch_button_Click(object sender, EventArgs e)
        {
            try
            {
                search.binding1.Filter = parametresHere.ToString();
                parametresHere.Clear();
                Close();
            }
            catch (System.NullReferenceException)
            {
                throw;
            }
        }
    }
}
