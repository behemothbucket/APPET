using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace APPEET
{

    public partial class search : Form
    {
        bool drag = false;
        bool dbIsSaved = true;
        bool canSearch = true;
        bool switchedDefaultDb;

        Point start_point = new Point(0, 0);

        public static StringBuilder parametres = new StringBuilder(); //Массив строк текущей таблицы
        public static BindingSource binding1;

        public string projectFolder;
        public string defaultProjectFolder = AppDomain.CurrentDomain.BaseDirectory;
        public string dbName = null;
        public string tableName = null;
        public string defaultDbpath = @"db\elementDb.db";
        public string oldDbPath = @"db\old\elementDb.db";
        public string oldDbOnlyPath = @"db\old\";
        public string clickedMenuItem;
        

        public search()
        {
            InitializeComponent();
            dataGridView1.DoubleBuffered(true); // Буферизация dataGridView (проблема с эффектом "слайд-шоу")
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException); // Перехват текста сообщений об ошибках приложения
            dataGridView1.DataError += new DataGridViewDataErrorEventHandler(dataGridView1_DataError); // Перехват ошибок datagridview
            dataGridView1.EnableHeadersVisualStyles = false;
            canReturn(); // проверка пустоты папки old
        }

        // Загрузка таблицы из базы
        public void loadTable()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(getConnectionString(), true))
                {
                    connection.Open();
                    using (SQLiteCommand command = connection.CreateCommand())
                    {
                        tableName = string.IsNullOrEmpty(tableName) ? "bpTable" : tableName; // проверка таблицы по умолчанию
                        command.CommandText = String.Format(@"SELECT * FROM {0}", tableName);
                        command.CommandType = CommandType.Text;
                        SQLiteDataReader dr = command.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        binding1 = new BindingSource();
                        binding1.DataSource = dt;
                        dataGridView1.DataSource = binding1;
                        bindingNavigator1.BindingSource = binding1;
                        dataGridView1.Columns[0].Visible = false; // скрываем таблицу ID
                        dataGridView1.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable); // отключаем сортировку таблиц
                        columnColorizer();
                        parametres.Clear();
                        getParametres();
                    }
                }
            }
            catch (SQLiteException)
            {
                MessageBox.Show(
                "Неверная база данных или нет файла самой базы",
                "Внимание",
                MessageBoxButtons.OK,
                MessageBoxIcon.None,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
                dataGridView1.DataSource = null;
            }
        }

        // Создаем connectionString для SQLiteConnection
        public string getConnectionString()
        {
            string connectionString = null;

            // Если мы запускаем просто нашу таблицу не загружая
            if ((dbName != null && tableName == null) || (dbName == null && tableName != null) || switchedDefaultDb == true)
            {
                connectionString = "Data Source = " + defaultProjectFolder + defaultDbpath;
            }
            // Если мы хотим открыть другую таблицу
            else if (switchedDefaultDb == false)
            {
                connectionString = "Data Source = " + projectFolder;
            }
            return connectionString;
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

        // Кнопка свернуть
        private void hide_button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        // Кнопка выйти
        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void welcome_load()
        {
            table.Visible = false;
            welcome.Visible = false;
            hand.Visible = false;
            choose.Visible = false;
            dataGridView1.Visible = true;
            toolStripMenuItem_exportDb.Enabled = true;

            if (canSearch == true)
            {
                find_textbox.Enabled = true;
                find_textbox.BackColor = Color.WhiteSmoke;
                toolStripButton_deleteRow.Enabled = true;
                toolStripButton_addRow.Enabled = true;
                adv_search.Enabled = true;
            }
            else
            {
                find_textbox.Enabled = false;
                find_textbox.BackColor = Color.Gray;
                toolStripButton_deleteRow.Enabled = false;
                toolStripButton_addRow.Enabled = false;
                adv_search.Enabled = false;
            }
        }

        // При ошибке удалить дефектную строку
        private void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            if (e.Exception as FormatException != null)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 2);
            }
        }

        //Поиск по таблице
        private void search_textbox_TextChanged(object sender, EventArgs e)
        {
            if (checkColumnHeadersColor())
            {
                if (find_textbox.Text != "" && clickedMenuItem == "Биполярные транзисторы")
                {
                    binding1.Filter = string.Format("[Наимен. прибора] LIKE '%{0}%' OR " +
                    "[Маркировка] LIKE '%{0}%' OR " +
                    "[Полярность] LIKE '%{0}%' OR " +
                    "[Макс. мощность (Pc), Вт] LIKE '%{0}%' OR " +
                    "[Макc. колл-база (Ucb), В] LIKE '%{0}%' OR " +
                    "[Макc. колл-эмитт (Uce), В] LIKE '%{0}%' OR " +
                    "[Макc. эмитт-база (Ueb), В] LIKE '%{0}%' OR " +
                    "[Макc. ток колл (Ic), А] LIKE '%{0}%' OR " +
                    "[Предельная темп (Tj), С] LIKE '%{0}%' OR " +
                    "[Гранич частота коэфф п.т (ft), МГц] LIKE '%{0}%' OR " +
                    "[Ёмкость колл перехода (Cc), pf] LIKE '%{0}%' OR " +
                    "[Статич коэф п. тока (hfe)] LIKE '%{0}%' OR" +
                    "[Тип материала] LIKE '%{0}%'", find_textbox.Text);
                    dataGridView1.DataSource = binding1;
                    toolStripButton_addRow.Enabled = false;
                    toolStripButton_deleteRow.Enabled = false;
                    toolStripMenuItem_restoreDb.Enabled = false;
                    adv_search.Enabled = false;
                }
                else if (find_textbox.Text != "" && clickedMenuItem == "Полевые транзисторы")
                {
                    binding1.Filter = string.Format("[Наимен прибора] LIKE '%{0}%' OR " +
                    "[Тип транзистора] LIKE '%{0}%' OR " +
                    "[Полярность] LIKE '%{0}%' OR " +
                    "[Макс. ток стока (Id), А] LIKE '%{0}%' OR " +
                    "[Сток-исток (Uds), В] LIKE '%{0}%' OR " +
                    "[Затвор и исток (Ugs), В] LIKE '%{0}%' OR " +
                    "[Затвор и исток (Ugs), В] LIKE '%{0}%' OR " +
                    "[Вых. емкость (Cd), pf] LIKE '%{0}%' OR " +
                    "[Макс. расс. мощность (Pd), Вт] LIKE '%{0}%' OR " +
                    "[Макc. темп. канала (Tj), С] LIKE '%{0}%' OR " +
                    "[Время нарастания (tr), nc] LIKE '%{0}%' OR " +
                    "[Общий заряд затвора (Qg), nc] LIKE '%{0}%' OR" +
                    "[Порог.напр. включения Ugs, B] LIKE '%{0}%'", find_textbox.Text);
                    dataGridView1.DataSource = binding1;
                    toolStripButton_addRow.Enabled = false;
                    toolStripButton_deleteRow.Enabled = false;
                    toolStripMenuItem_restoreDb.Enabled = false;
                    adv_search.Enabled = false;
                }
                else if (find_textbox.Text != "" && clickedMenuItem == "Фотодиоды")
                {
                    binding1.Filter = string.Format("[Тип фотодиода] LIKE '%{0}%' OR " +
                    "[S интр, А/Вт] LIKE '%{0}%' OR " +
                    "[S инте, мкА/лк] LIKE '%{0}%' OR " +
                    "[S ннте, мА/лм] LIKE '%{0}%' OR " +
                    "[Uр, В] LIKE '%{0}%' OR " +
                    "[IТ, мкА] LIKE '%{0}%' OR " +
                    "[S, мм2] LIKE '%{0}%' OR " +
                    "[λmin, мкм] LIKE '%{0}%' OR " +
                    "[λmax, мкм] LIKE '%{0}%' OR " +
                    "[λ, мкм] LIKE '%{0}%' OR " +
                    "[τ, мкс] LIKE '%{0}%'", find_textbox.Text);
                    dataGridView1.DataSource = binding1;
                    toolStripButton_addRow.Enabled = false;
                    toolStripButton_deleteRow.Enabled = false;
                    toolStripMenuItem_restoreDb.Enabled = false;
                    adv_search.Enabled = false;
                }
                else if (find_textbox.Text != "" && clickedMenuItem == "Процессоры")
                {
                    binding1.Filter = string.Format("[Наименование процессора] LIKE '%{0}%' OR " +
                    "[N, млн шт] LIKE '%{0}%' OR " +
                    "[n, шт] LIKE '%{0}%' OR " +
                    "[Я,шт] LIKE '%{0}%' OR " +
                    "[П,шт] LIKE '%{0}%' OR " +
                    "[L3, мб] LIKE '%{0}%' OR " +
                    "[I, А] LIKE '%{0}%' OR " +
                    "[Pмин, Вт] LIKE '%{0}%' OR " +
                    "[T, ℃] LIKE '%{0}%' OR " +
                    "[Fт1, ГГц] LIKE '%{0}%' OR " +
                    "[Fт2, ГГц] LIKE '%{0}%' OR" +
                    "[S, мм2] LIKE '%{0}%' OR " +
                    "[UПмин, В] LIKE '%{0}%' OR " +
                    "[UПмакс, В] LIKE '%{0}%' OR " +
                    "[ТП, нм] LIKE '%{0}%' OR " +
                    "[Год выпуска] LIKE '%{0}%' OR " +
                    "[Ц, тыс. руб] LIKE '%{0}%'", find_textbox.Text);
                    dataGridView1.DataSource = binding1;
                    toolStripButton_addRow.Enabled = false;
                    toolStripButton_deleteRow.Enabled = false;
                    toolStripMenuItem_restoreDb.Enabled = false;
                    adv_search.Enabled = false;
                }
                else if (find_textbox.Text != "" && clickedMenuItem == "БИС")
                {
                    binding1.Filter = string.Format("[БИС] LIKE '%{0}%' OR " +
                    "[Nэл] LIKE '%{0}%' OR " +
                    "[Nв] LIKE '%{0}%' OR " +
                    "[Pрас, мВт] LIKE '%{0}%' OR " +
                    "[Iпот, мА] LIKE '%{0}%' OR " +
                    "[Uп, В] LIKE '%{0}%' OR " +
                    "[f, МГц] LIKE '%{0}%' OR " +
                    "[Сн, В] LIKE '%{0}%' OR " +
                    "[t, нс] LIKE '%{0}%' OR " +
                    "[S, м2 10-6] LIKE '%{0}%' OR " +
                    "[m, г] LIKE '%{0}%' OR" +
                    "[Ц, руб] LIKE '%{0}%'", find_textbox.Text);
                    dataGridView1.DataSource = binding1;
                    toolStripButton_addRow.Enabled = false;
                    toolStripButton_deleteRow.Enabled = false;
                    toolStripMenuItem_restoreDb.Enabled = false;
                    adv_search.Enabled = false;
                }
                else if (find_textbox.Text != "" && clickedMenuItem == "Ключи")
                {
                    binding1.Filter = string.Format("[Наименование] LIKE '%{0}%' OR " +
                    "[Кол-во каналов] LIKE '%{0}%' OR " +
                    "[Uпит, В] LIKE '%{0}%' OR " +
                    "[Ron, Ом] LIKE '%{0}%' OR " +
                    "[Iут on, мкА] LIKE '%{0}%' OR " +
                    "[B, МГц] LIKE '%{0}%' OR " +
                    "[Tмин, -оС] LIKE '%{0}%' OR " +
                    "[Tмакс, оС] LIKE '%{0}%' OR " +
                    "[Iвх, мА] LIKE '%{0}%' OR " +
                    "[Iпит, мкА] LIKE '%{0}%' OR " +
                    "[Цена] LIKE '%{0}%'", find_textbox.Text);
                    dataGridView1.DataSource = binding1;
                    toolStripButton_addRow.Enabled = false;
                    toolStripButton_deleteRow.Enabled = false;
                    toolStripMenuItem_restoreDb.Enabled = false;
                    adv_search.Enabled = false;
                }
                else if (find_textbox.Text != "" && clickedMenuItem == "ИОУ")
                {
                    binding1.Filter = string.Format("[Название] LIKE '%{0}%' OR " +
                    "[Кусх103] LIKE '%{0}%' OR " +
                    "[Kос.сф, дБ] LIKE '%{0}%' OR " +
                    "[Iвх, нА] LIKE '%{0}%' OR " +
                    "[F1, МГц] LIKE '%{0}%' OR " +
                    "[VU ВЫХ, В/мкс] LIKE '%{0}%' OR " +
                    "[Uсм, мВ] LIKE '%{0}%' OR " +
                    "[UП1,(-В)] LIKE '%{0}%' OR " +
                    "[UП2,(+В)] LIKE '%{0}%' OR " +
                    "[Iтип, мкА] LIKE '%{0}%' OR " +
                    "[Iп. maкс, мкА] LIKE '%{0}%' OR" +
                    "[Ц,руб] LIKE '%{0}%' OR " +
                    "[N,шт] LIKE '%{0}%' OR " +
                    "[ИИ] LIKE '%{0}%'", find_textbox.Text);
                    dataGridView1.DataSource = binding1;
                    toolStripButton_addRow.Enabled = false;
                    toolStripButton_deleteRow.Enabled = false;
                    toolStripMenuItem_restoreDb.Enabled = false;
                    adv_search.Enabled = false;
                }
                else if (find_textbox.Text != "" && clickedMenuItem == "СИД")
                {
                    binding1.Filter = string.Format("[Наименование] LIKE '%{0}%' OR " +
                    "[Цвет] LIKE '%{0}%' OR " +
                    "[Uпр, В] LIKE '%{0}%' OR " +
                    "[Iпр, mA] LIKE '%{0}%' OR " +
                    "[Длина волны] LIKE '%{0}%' OR " +
                    "[Длина волны max] LIKE '%{0}%' OR " +
                    "[Iv, мкд] LIKE '%{0}%' OR " +
                    "[Тип линзы/размер] LIKE '%{0}%' OR " +
                    "[Световой поток, Ф] LIKE '%{0}%' OR " +
                    "[Тип монтажа] LIKE '%{0}%' OR " +
                    "[Угол обзора, град.] LIKE '%{0}%'", find_textbox.Text);
                    dataGridView1.DataSource = binding1;
                    toolStripButton_addRow.Enabled = false;
                    toolStripButton_deleteRow.Enabled = false;
                    toolStripMenuItem_restoreDb.Enabled = false;
                    adv_search.Enabled = false;
                }
                else
                {
                    binding1.RemoveFilter();
                    toolStripButton_addRow.Enabled = true;
                    toolStripButton_deleteRow.Enabled = true;
                    toolStripMenuItem_restoreDb.Enabled = true;
                    adv_search.Enabled = true;
                }
            }
            else
            {
                if (find_textbox.Text != "")
                {
                    string searchingWord = "";

                    //Найти имя окрашенного столбца
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        if (dataGridView1.Columns[i].HeaderCell.Style.BackColor == Color.Black)
                        {
                            searchingWord = string.Format("[{0}] LIKE '%{1}%'", dataGridView1.Columns[i].HeaderText, find_textbox.Text);
                        }
                    }
                    binding1.Filter = searchingWord;
                    dataGridView1.DataSource = binding1;
                    toolStripButton_addRow.Enabled = false;
                    toolStripButton_deleteRow.Enabled = false;
                    toolStripMenuItem_restoreDb.Enabled = false;
                    adv_search.Enabled = false;
                }
                else
                {
                    binding1.RemoveFilter();
                    toolStripButton_addRow.Enabled = true;
                    toolStripButton_deleteRow.Enabled = true;
                    toolStripMenuItem_restoreDb.Enabled = true;
                    adv_search.Enabled = true;
                }
            }
        }

        private bool checkColumnHeadersColor()
        {
            bool status = true;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                if (dataGridView1.Columns[i].HeaderCell.Style.BackColor != Color.FromArgb(64, 64, 64))
                {
                    status = false;
                }
            }
            return status;
        }

        // Кнопка удалить
        private void toolStripButton_delete_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                using (SQLiteConnection con = new SQLiteConnection(getConnectionString(), true))
                {
                    con.Open();
                    SQLiteCommand cmd = con.CreateCommand();
                    int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    cmd.CommandText = String.Format("DELETE FROM {0} WHERE ID={1}", tableName, id);
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        // При ошибке на datagridview подавить
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception as System.FormatException != null)
            {
                e.Cancel = true;
            }
        }

        // Изменить значение ячейки
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int idColumn = dataGridView1.CurrentCell.ColumnIndex;
            string columnName = dataGridView1.Columns[idColumn].Name;
            var idValue = dataGridView1.Rows[e.RowIndex].Cells[0].Value;

            foreach (DataGridViewCell dgc in dataGridView1.SelectedCells)
            {
                string cellValue = dgc.Value.ToString();
                using (SQLiteConnection connection = new SQLiteConnection(getConnectionString(), true))
                {
                    connection.Open();
                    string queryUpdate = String.Format("UPDATE {0} SET [{1}]='{2}' WHERE ID={3}", tableName, columnName, cellValue, idValue);
                    SQLiteCommand command = new SQLiteCommand(queryUpdate, connection);
                    command.ExecuteNonQuery();
                    int currentIndex = dataGridView1.CurrentRow.Index;
                    loadTable();
                    dataGridView1.FirstDisplayedScrollingRowIndex = currentIndex;
                }
            }
        }

        // Добавить строку
        private void toolStripButton_addRow_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(getConnectionString(), true))
            {
                connection.Open();

                // Добавление пустой строки
                string queryInsert = String.Format("INSERT INTO {0} DEFAULT VALUES", tableName);
                SQLiteCommand commandInsert = new SQLiteCommand(queryInsert, connection);
                commandInsert.ExecuteNonQuery();

                //Фокус на последнюю добавленную строку и ячейку
                loadTable();
                int lastRow = dataGridView1.RowCount - 1;
                dataGridView1.Rows[lastRow].Cells[1].Selected = true;
                dataGridView1.CurrentCell = dataGridView1[1, lastRow];
            }

        }

        // Кнопка информации
        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "При заполении следите за типом данных которые вводятся: буквенные символы, даты, целые числа, дробные... \n\n" +
                "В противном случае строка автоматически удаляется.",
                "Информация",
                MessageBoxButtons.OK,
                MessageBoxIcon.None,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);

        }

        // Скрывать/показать элементы управления
        public void hideAndShowItems(string hideShowSwitcher)
        {
            if (hideShowSwitcher == "true")
            {
                dbIsSaved = false; // можно ли показать сохранение 
                canSearch = false;
                toolStripButton_importDb.Visible = true;
                toolStripButton_deleteRow.Enabled = false;
                toolStripButton_addRow.Enabled = false;
                toolStripSeparator2.Visible = true;
                toolStripSeparator3.Visible = true;
                toolStripButton_closeDb.Visible = true;
                toolStripMenuItem_exportDb.Enabled = false;
                toolStripMenuItem_returnDb.Enabled = false;
                toolStripMenuItem_restoreDb.Enabled = false;
                search_label.Text = "**Режим просмотра**";
                toolStripLabel_closeDb.Visible = true;
                toolStripLabel_importDb.Visible = true;
                find_textbox.Enabled = false;
                find_textbox.BackColor = Color.Gray;
                toolStripMenuItem_exportDb.Enabled = false;
                dataGridView1.ReadOnly = true;
            }
            else
            {
                dbIsSaved = true; // можно ли показать сохранение 
                canSearch = true;
                toolStripButton_importDb.Visible = false;
                toolStripButton_deleteRow.Enabled = true;
                toolStripButton_addRow.Enabled = true;
                toolStripSeparator2.Visible = false;
                toolStripSeparator3.Visible = false;
                toolStripButton_closeDb.Visible = false;
                toolStripMenuItem_exportDb.Enabled = true;
                toolStripMenuItem_returnDb.Enabled = true;
                toolStripMenuItem_restoreDb.Enabled = true;
                search_label.Text = "Поиск элементов";
                toolStripLabel_closeDb.Visible = false;
                toolStripLabel_importDb.Visible = false;
                find_textbox.Enabled = true;
                find_textbox.BackColor = Color.WhiteSmoke;
                toolStripMenuItem_exportDb.Enabled = true;
                dataGridView1.ReadOnly = false;
            }

        }

        // Кнопка импорта
        private void toolStripButton_importDb_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Текущая база данных будет сохранена и впредь будет отображаться всегда. \n Вы уверены что хотите это сделать?", "Сохранение базы данных", MessageBoxButtons.YesNo, MessageBoxIcon.None);

            if (dialogResult == DialogResult.Yes)
            {
                // Копируем старую старую базу в old
                File.Copy(defaultProjectFolder + defaultDbpath, defaultProjectFolder + oldDbPath, true);

                // Копируем новую базу в стандартную папку db
                File.Copy(projectFolder, defaultProjectFolder + defaultDbpath, true);
                hideAndShowItems("false");
                switchedDefaultDb = true;
                loadTable();
            }
            else if (dialogResult == DialogResult.No) { }
        }

        // Кнопка сброса
        private void toolStripMenuItem_restoreDb_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Загрузится база данных исходной версии этой программы. \nВы точно хотите это сделать?", "Сброс базы данных", MessageBoxButtons.YesNo, MessageBoxIcon.None);

            if (dialogResult == DialogResult.Yes)
            {
                foreach (var file in Directory.GetFiles(defaultProjectFolder + @"db\\backup\\"))
                {
                    File.Copy(file, Path.Combine(defaultProjectFolder + @"db\\", Path.GetFileName(file)), true);
                }
                tableName = "bpTable";
                reloadGrid();
                loadTable();
                MessageBox.Show(
                "База данных восстановлена",
                "Операция успешно завершена",
                MessageBoxButtons.OK,
                MessageBoxIcon.None,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        // Кнопка открытия базы
        private void toolStripMenuItem_openDb_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDb = new OpenFileDialog();

            openDb.Filter = "(*.db)|*.db";
            openDb.Multiselect = false;

            if (openDb.ShowDialog() == DialogResult.OK)
            {
                dbName = openDb.SafeFileName;
                projectFolder = openDb.FileName;
                hideAndShowItems("true");
                switchedDefaultDb = false;
                reloadGrid();
                loadTable();
            }
        }

        // Закрыть просмотр базы
        private void toolStripButton_closeDb_Click(object sender, EventArgs e)
        {
            dbName = null;
            hideAndShowItems("false");
            loadTable();
        }

        // Вернуть базу до импорта
        private void toolStripMenuItem_returnDb_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Загрузится база данных которая была у вас до последней загрузки.\nВы точно хотите это сделать?", "Сброс базы данных", MessageBoxButtons.YesNo, MessageBoxIcon.None);

            if (dialogResult == DialogResult.Yes)
            {
                if (Directory.EnumerateFileSystemEntries(defaultProjectFolder + oldDbOnlyPath).Any() == true)
                {
                    File.Copy(defaultProjectFolder + oldDbPath, defaultProjectFolder + defaultDbpath, true);

                    binding1.ResetBindings(false);
                    loadTable();
                }
                else if (Directory.EnumerateFileSystemEntries(defaultProjectFolder + oldDbOnlyPath).Any() == false)
                {
                    MessageBox.Show(
                    "Не найдено ни одной старой базы. Возможно папка пуста или база не загружается корректно.",
                    "Что-то пошло не так...",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                }
            }
        }

        // Проверка на пустую папку
        private void canReturn()
        {
            if (Directory.EnumerateFileSystemEntries(defaultProjectFolder + oldDbOnlyPath).Any() == true)
            {
                toolStripMenuItem_returnDb.Enabled = true;
            }
            else
            {
                toolStripMenuItem_returnDb.Enabled = false;
            }
        }

        private void columnColorizer()
        {
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].HeaderCell.Style.BackColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void toolStripMenuItem_exportDb_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDb = new SaveFileDialog();

            saveDb.Filter = "(*.db)|*.db";
            saveDb.FileName = "elementDb.db";

            if (saveDb.ShowDialog() == DialogResult.OK)
            {
                string saveFilePath = saveDb.FileName;
                File.Copy(defaultProjectFolder + defaultDbpath, saveFilePath, true);
            }
        }

        // Перерисовать базу после загрузки
        private void reloadGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Update();
            dataGridView1.Refresh();
        }


        // Отображение выбранной таблицы
        private void toolStripDropDownButton_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            clickedMenuItem = e.ClickedItem.Text;
            db_label.Text = clickedMenuItem;
            db_label.Visible = true;
            toolstrip_dropDown_db.Enabled = true;
            welcome_load(); // прогрузка элементов

            switch (e.ClickedItem.Text)
            {
                case "Биполярные транзисторы":
                    tableName = "bpTable";
                    loadTable();
                    dataGridView1.Columns[1].Width = 100; // ширина для первой колонкм
                    break;

                case "Полевые транзисторы":
                    tableName = "plTable";
                    loadTable();
                    dataGridView1.Columns[1].Width = 85;
                    break;

                case "Фотодиоды":
                    tableName = "phdiods";
                    loadTable();
                    break;

                case "Процессоры":
                    tableName = "processors";
                    loadTable();
                    dataGridView1.Columns[1].Width = 180;
                    break;

                case "БИС":
                    tableName = "bis";
                    loadTable();
                    break;

                case "Ключи":
                    tableName = "keys";
                    loadTable();
                    break;

                case "ИОУ":
                    tableName = "iou";
                    loadTable();
                    break;

                case "СИД":
                    tableName = "sid";
                    loadTable();
                    break;
            }
        }

        private void descriptionShow_Click(object sender, EventArgs e)
        {
            description_form description = new description_form();
            description.mainButtonControl();
            description.StartPosition = FormStartPosition.Manual;
            description.Left = 120;
            description.Top = 80;
            description.Show();
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                columnColorizer();
                dataGridView1.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = dataGridView1.Columns[e.ColumnIndex].HeaderCell.Style.BackColor.Equals(Color.FromArgb(64, 64, 64)) ? Color.Black : Color.FromArgb(64, 64, 64);
            }
            else if (e.Button == MouseButtons.Right)
            {
                dataGridView1.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void adv_search_Click(object sender, EventArgs e)
        {
            advsearch search = new advsearch();
            toolStripDropDownButton.Enabled = false;
            search.ShowDialog();
            columnColorizer();
            toolStripButton_addRow.Enabled = false;
            toolStripButton_deleteRow.Enabled = false;
            find_textbox.Enabled = false;
            adv_search.Visible = false;
            reset_search.Visible = true;
            toolStripLabel_resetSearch.Visible = true;
            toolStripSeparator4.Visible = true;
            toolstrip_dropDown_db.Enabled = false;
            toolStripDropDownButton.Enabled = false;
            find_textbox.BackColor = Color.Gray;
        }

        public void getParametres()
        {
            for (int i = 1; i < dataGridView1.Columns.Count; i++)
            {
                parametres.Append("");
                parametres.Append(dataGridView1.Columns[i].Name);
                if (i != dataGridView1.Columns.Count - 1)
                {
                    parametres.Append(";");
                }
            }
        }

        public void reset_search_Click(object sender, EventArgs e)
        {
            binding1.RemoveFilter();
            toolStripButton_addRow.Enabled = true;
            toolStripButton_deleteRow.Enabled = true;
            find_textbox.Enabled = true;
            adv_search.Visible = true;
            reset_search.Visible = false;
            toolStripLabel_resetSearch.Visible = false;
            toolStripSeparator4.Visible = false;
            toolstrip_dropDown_db.Enabled = true;
            toolStripDropDownButton.Enabled = true;
            find_textbox.BackColor = Color.WhiteSmoke;
        }

        private void main_menu_button_Click_1(object sender, EventArgs e)
        {
            if (dbIsSaved == true)
            {
                main main = new main();
                main.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show(
                "Вы открыли базу данных для просмотра, импортируйте её прежде чем выйти или закройте",
                "Внимание",
                MessageBoxButtons.OK,
                MessageBoxIcon.None,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            }

        }
    }
    // Буферизация и сглаживание графика
    public static class ExtensionMethods
    {
        public static void DoubleBuffered(this DataGridView dgv, bool setting)
        {
            Type dgvType = dgv.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dgv, setting, null);
        }
    }
}
