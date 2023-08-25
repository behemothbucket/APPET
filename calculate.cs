using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace APPEET
{
    public partial class calculate : Form
    {
        bool drag = false;
        Point start_point = new Point(0, 0);
        public calculate()
        {
            InitializeComponent();
            loadEmptyDgvs();
        }

        private void loadEmptyDgvs()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Расчитанные показатели/устройства", typeof(string));
            DataRow dr = table.NewRow();
            dr["Расчитанные показатели/устройства"] = "";
            table.Rows.Add(dr);
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.White;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.DataSource = table;
            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.White;
            dataGridView1.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable); // отключаем сортировку таблиц
            dataGridView2.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable); // отключаем сортировку таблиц
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.DataSource = table;
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
                Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void header_panel_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void hide_button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void main_menu_button_Click(object sender, EventArgs e)
        {
            status_richTextBox.AppendText("\r\n" + "[Добавлено] " + parameter_textBox.Text + " = " + value_textBox.Text);
            status_richTextBox.ScrollToCaret();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            status_richTextBox.Clear();
            status_richTextBox.AppendText("Очищено...");
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            main main = new main();
            main.Show();
            Close();
        }
    }
}
