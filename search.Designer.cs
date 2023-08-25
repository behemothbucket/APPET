namespace APPEET
{
    partial class search
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(search));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.search_label = new System.Windows.Forms.Label();
            this.find_textbox = new System.Windows.Forms.TextBox();
            this.top_panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.hide_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.db_label = new System.Windows.Forms.Label();
            this.find_label = new System.Windows.Forms.Label();
            this.header_panel = new System.Windows.Forms.Panel();
            this.welcome = new System.Windows.Forms.Label();
            this.choose = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.toolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem_bptrans = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_pltrans = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_phdiods = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_processors = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_keys = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_bis = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_iou = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_sid = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrip_dropDown_db = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem_openDb = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_exportDb = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem_returnDb = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_restoreDb = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_importDb = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel_importDb = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton_closeDb = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel_closeDb = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_addRow = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_deleteRow = new System.Windows.Forms.ToolStripButton();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.adv_search = new System.Windows.Forms.ToolStripButton();
            this.reset_search = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel_resetSearch = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.main_menu_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.hand = new System.Windows.Forms.PictureBox();
            this.table = new System.Windows.Forms.PictureBox();
            this.top_panel.SuspendLayout();
            this.header_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // search_label
            // 
            this.search_label.AutoSize = true;
            this.search_label.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));
            this.search_label.Location = new System.Drawing.Point(18, 54);
            this.search_label.Name = "search_label";
            this.search_label.Size = new System.Drawing.Size(230, 37);
            this.search_label.TabIndex = 0;
            this.search_label.Text = "Поиск элементов";
            // 
            // find_textbox
            // 
            this.find_textbox.BackColor = System.Drawing.Color.Gray;
            this.find_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.find_textbox.Enabled = false;
            this.find_textbox.Font = new System.Drawing.Font("IBM Plex Sans", 10F);
            this.find_textbox.Location = new System.Drawing.Point(791, 123);
            this.find_textbox.Name = "find_textbox";
            this.find_textbox.Size = new System.Drawing.Size(217, 25);
            this.find_textbox.TabIndex = 68;
            this.find_textbox.TextChanged += new System.EventHandler(this.search_textbox_TextChanged);
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.top_panel.Controls.Add(this.label2);
            this.top_panel.Controls.Add(this.hide_button);
            this.top_panel.Controls.Add(this.exit_button);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(1020, 30);
            this.top_panel.TabIndex = 59;
            this.top_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.top_panel_MouseDown);
            this.top_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.top_panel_MouseMove);
            this.top_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.top_panel_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));
            this.label2.Location = new System.Drawing.Point(12, 6);
            this.label2.MaximumSize = new System.Drawing.Size(500, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 64;
            this.label2.Text = "Поиск";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.top_panel_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.top_panel_MouseMove);
            this.label2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.top_panel_MouseUp);
            // 
            // hide_button
            // 
            this.hide_button.BackColor = System.Drawing.Color.Transparent;
            this.hide_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hide_button.FlatAppearance.BorderSize = 0;
            this.hide_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.hide_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.hide_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hide_button.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hide_button.ForeColor = System.Drawing.Color.Transparent;
            this.hide_button.Location = new System.Drawing.Point(950, 0);
            this.hide_button.Name = "hide_button";
            this.hide_button.Size = new System.Drawing.Size(35, 30);
            this.hide_button.TabIndex = 39;
            this.hide_button.Text = "–";
            this.hide_button.UseVisualStyleBackColor = false;
            this.hide_button.Click += new System.EventHandler(this.hide_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.Transparent;
            this.exit_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit_button.BackgroundImage")));
            this.exit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exit_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.exit_button.FlatAppearance.BorderSize = 0;
            this.exit_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(4)))), ((int)(((byte)(8)))));
            this.exit_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Font = new System.Drawing.Font("Ubuntu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit_button.ForeColor = System.Drawing.Color.White;
            this.exit_button.Location = new System.Drawing.Point(984, 0);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(35, 30);
            this.exit_button.TabIndex = 37;
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // db_label
            // 
            this.db_label.AutoSize = true;
            this.db_label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.db_label.ForeColor = System.Drawing.SystemColors.GrayText;
            this.db_label.Location = new System.Drawing.Point(19, 102);
            this.db_label.Name = "db_label";
            this.db_label.Size = new System.Drawing.Size(133, 30);
            this.db_label.TabIndex = 60;
            this.db_label.Text = "База данных";
            this.db_label.Visible = false;
            // 
            // find_label
            // 
            this.find_label.AutoSize = true;
            this.find_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.find_label.ForeColor = System.Drawing.Color.Yellow;
            this.find_label.Location = new System.Drawing.Point(729, 124);
            this.find_label.Name = "find_label";
            this.find_label.Size = new System.Drawing.Size(54, 21);
            this.find_label.TabIndex = 61;
            this.find_label.Text = "Поиск";
            // 
            // header_panel
            // 
            this.header_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(36)))), ((int)(((byte)(86)))));
            this.header_panel.Controls.Add(this.find_label);
            this.header_panel.Controls.Add(this.db_label);
            this.header_panel.Controls.Add(this.top_panel);
            this.header_panel.Controls.Add(this.find_textbox);
            this.header_panel.Controls.Add(this.search_label);
            this.header_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_panel.Location = new System.Drawing.Point(0, 0);
            this.header_panel.Name = "header_panel";
            this.header_panel.Size = new System.Drawing.Size(1020, 165);
            this.header_panel.TabIndex = 0;
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.welcome.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.welcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));
            this.welcome.Location = new System.Drawing.Point(330, 361);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(361, 50);
            this.welcome.TabIndex = 71;
            this.welcome.Text = "Добро пожаловать!";
            // 
            // choose
            // 
            this.choose.AutoSize = true;
            this.choose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.choose.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choose.ForeColor = System.Drawing.SystemColors.GrayText;
            this.choose.Location = new System.Drawing.Point(341, 445);
            this.choose.Name = "choose";
            this.choose.Size = new System.Drawing.Size(310, 32);
            this.choose.TabIndex = 72;
            this.choose.Text = "Выберите таблицу в меню";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 193);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.RowHeadersWidth = 38;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.Size = new System.Drawing.Size(1020, 474);
            this.dataGridView1.TabIndex = 73;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.CountItemFormat = "всего {0} строк";
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton,
            this.toolstrip_dropDown_db,
            this.toolStripSeparator3,
            this.toolStripButton_importDb,
            this.toolStripLabel_importDb,
            this.toolStripButton_closeDb,
            this.toolStripLabel_closeDb,
            this.toolStripSeparator2,
            this.toolStripButton_addRow,
            this.toolStripButton_deleteRow,
            this.helpToolStripButton,
            this.bindingNavigatorCountItem,
            this.toolStripSeparator4,
            this.adv_search,
            this.reset_search,
            this.toolStripLabel_resetSearch});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 165);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.Padding = new System.Windows.Forms.Padding(20, 0, 1, 0);
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(1020, 25);
            this.bindingNavigator1.TabIndex = 74;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bindingNavigatorCountItem.Enabled = false;
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(88, 22);
            this.bindingNavigatorCountItem.Text = "всего {0} строк";
            this.bindingNavigatorCountItem.ToolTipText = "Количество строк";
            // 
            // toolStripDropDownButton
            // 
            this.toolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_bptrans,
            this.toolStripMenuItem_pltrans,
            this.toolStripMenuItem_phdiods,
            this.toolStripMenuItem_processors,
            this.toolStripMenuItem_keys,
            this.toolStripMenuItem_bis,
            this.toolStripMenuItem_iou,
            this.toolStripMenuItem_sid});
            this.toolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton.Image")));
            this.toolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton.Name = "toolStripDropDownButton";
            this.toolStripDropDownButton.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton.Text = "Таблицы";
            this.toolStripDropDownButton.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStripDropDownButton_DropDownItemClicked);
            // 
            // toolStripMenuItem_bptrans
            // 
            this.toolStripMenuItem_bptrans.Name = "toolStripMenuItem_bptrans";
            this.toolStripMenuItem_bptrans.Size = new System.Drawing.Size(218, 22);
            this.toolStripMenuItem_bptrans.Text = "Биполярные транзисторы";
            // 
            // toolStripMenuItem_pltrans
            // 
            this.toolStripMenuItem_pltrans.Name = "toolStripMenuItem_pltrans";
            this.toolStripMenuItem_pltrans.Size = new System.Drawing.Size(218, 22);
            this.toolStripMenuItem_pltrans.Text = "Полевые транзисторы";
            // 
            // toolStripMenuItem_phdiods
            // 
            this.toolStripMenuItem_phdiods.Name = "toolStripMenuItem_phdiods";
            this.toolStripMenuItem_phdiods.Size = new System.Drawing.Size(218, 22);
            this.toolStripMenuItem_phdiods.Text = "Фотодиоды";
            // 
            // toolStripMenuItem_processors
            // 
            this.toolStripMenuItem_processors.Name = "toolStripMenuItem_processors";
            this.toolStripMenuItem_processors.Size = new System.Drawing.Size(218, 22);
            this.toolStripMenuItem_processors.Text = "Процессоры";
            // 
            // toolStripMenuItem_keys
            // 
            this.toolStripMenuItem_keys.Name = "toolStripMenuItem_keys";
            this.toolStripMenuItem_keys.Size = new System.Drawing.Size(218, 22);
            this.toolStripMenuItem_keys.Text = "Ключи";
            // 
            // toolStripMenuItem_bis
            // 
            this.toolStripMenuItem_bis.Name = "toolStripMenuItem_bis";
            this.toolStripMenuItem_bis.Size = new System.Drawing.Size(218, 22);
            this.toolStripMenuItem_bis.Text = "БИС";
            // 
            // toolStripMenuItem_iou
            // 
            this.toolStripMenuItem_iou.Name = "toolStripMenuItem_iou";
            this.toolStripMenuItem_iou.Size = new System.Drawing.Size(218, 22);
            this.toolStripMenuItem_iou.Text = "ИОУ";
            // 
            // toolStripMenuItem_sid
            // 
            this.toolStripMenuItem_sid.Name = "toolStripMenuItem_sid";
            this.toolStripMenuItem_sid.Size = new System.Drawing.Size(218, 22);
            this.toolStripMenuItem_sid.Text = "СИД";
            // 
            // toolstrip_dropDown_db
            // 
            this.toolstrip_dropDown_db.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolstrip_dropDown_db.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_openDb,
            this.toolStripMenuItem_exportDb,
            this.toolStripSeparator1,
            this.toolStripMenuItem_returnDb,
            this.toolStripMenuItem_restoreDb});
            this.toolstrip_dropDown_db.Enabled = false;
            this.toolstrip_dropDown_db.Image = ((System.Drawing.Image)(resources.GetObject("toolstrip_dropDown_db.Image")));
            this.toolstrip_dropDown_db.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolstrip_dropDown_db.Name = "toolstrip_dropDown_db";
            this.toolstrip_dropDown_db.Size = new System.Drawing.Size(29, 22);
            this.toolstrip_dropDown_db.Text = "База данных";
            // 
            // toolStripMenuItem_openDb
            // 
            this.toolStripMenuItem_openDb.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem_openDb.Image")));
            this.toolStripMenuItem_openDb.Name = "toolStripMenuItem_openDb";
            this.toolStripMenuItem_openDb.Size = new System.Drawing.Size(245, 22);
            this.toolStripMenuItem_openDb.Text = "Открыть...";
            this.toolStripMenuItem_openDb.Click += new System.EventHandler(this.toolStripMenuItem_openDb_Click);
            // 
            // toolStripMenuItem_exportDb
            // 
            this.toolStripMenuItem_exportDb.Enabled = false;
            this.toolStripMenuItem_exportDb.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem_exportDb.Image")));
            this.toolStripMenuItem_exportDb.Name = "toolStripMenuItem_exportDb";
            this.toolStripMenuItem_exportDb.Size = new System.Drawing.Size(245, 22);
            this.toolStripMenuItem_exportDb.Text = "Сохранить...";
            this.toolStripMenuItem_exportDb.Click += new System.EventHandler(this.toolStripMenuItem_exportDb_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(242, 6);
            // 
            // toolStripMenuItem_returnDb
            // 
            this.toolStripMenuItem_returnDb.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem_returnDb.Image")));
            this.toolStripMenuItem_returnDb.Name = "toolStripMenuItem_returnDb";
            this.toolStripMenuItem_returnDb.Size = new System.Drawing.Size(245, 22);
            this.toolStripMenuItem_returnDb.Text = "Сбросить последнюю загрузку";
            this.toolStripMenuItem_returnDb.Click += new System.EventHandler(this.toolStripMenuItem_returnDb_Click);
            // 
            // toolStripMenuItem_restoreDb
            // 
            this.toolStripMenuItem_restoreDb.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem_restoreDb.Image")));
            this.toolStripMenuItem_restoreDb.Name = "toolStripMenuItem_restoreDb";
            this.toolStripMenuItem_restoreDb.Size = new System.Drawing.Size(245, 22);
            this.toolStripMenuItem_restoreDb.Text = "Восстановить";
            this.toolStripMenuItem_restoreDb.Click += new System.EventHandler(this.toolStripMenuItem_restoreDb_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator3.Visible = false;
            // 
            // toolStripButton_importDb
            // 
            this.toolStripButton_importDb.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_importDb.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_importDb.Image")));
            this.toolStripButton_importDb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_importDb.Name = "toolStripButton_importDb";
            this.toolStripButton_importDb.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_importDb.Text = "Импортировать";
            this.toolStripButton_importDb.Visible = false;
            this.toolStripButton_importDb.Click += new System.EventHandler(this.toolStripButton_importDb_Click);
            // 
            // toolStripLabel_importDb
            // 
            this.toolStripLabel_importDb.Name = "toolStripLabel_importDb";
            this.toolStripLabel_importDb.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel_importDb.Text = "загрузить";
            this.toolStripLabel_importDb.Visible = false;
            // 
            // toolStripButton_closeDb
            // 
            this.toolStripButton_closeDb.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_closeDb.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_closeDb.Image")));
            this.toolStripButton_closeDb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_closeDb.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.toolStripButton_closeDb.Name = "toolStripButton_closeDb";
            this.toolStripButton_closeDb.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_closeDb.Text = "Закрыть";
            this.toolStripButton_closeDb.Visible = false;
            this.toolStripButton_closeDb.Click += new System.EventHandler(this.toolStripButton_closeDb_Click);
            // 
            // toolStripLabel_closeDb
            // 
            this.toolStripLabel_closeDb.Name = "toolStripLabel_closeDb";
            this.toolStripLabel_closeDb.Size = new System.Drawing.Size(51, 22);
            this.toolStripLabel_closeDb.Text = "закрыть";
            this.toolStripLabel_closeDb.Visible = false;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator2.Visible = false;
            // 
            // toolStripButton_addRow
            // 
            this.toolStripButton_addRow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_addRow.Enabled = false;
            this.toolStripButton_addRow.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_addRow.Image")));
            this.toolStripButton_addRow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_addRow.Name = "toolStripButton_addRow";
            this.toolStripButton_addRow.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_addRow.Text = "Добавить строку";
            this.toolStripButton_addRow.Click += new System.EventHandler(this.toolStripButton_addRow_Click);
            // 
            // toolStripButton_deleteRow
            // 
            this.toolStripButton_deleteRow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_deleteRow.Enabled = false;
            this.toolStripButton_deleteRow.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_deleteRow.Image")));
            this.toolStripButton_deleteRow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_deleteRow.Name = "toolStripButton_deleteRow";
            this.toolStripButton_deleteRow.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_deleteRow.Text = "Удалить строку";
            this.toolStripButton_deleteRow.ToolTipText = "Удалить строку";
            this.toolStripButton_deleteRow.Click += new System.EventHandler(this.toolStripButton_delete_Click_1);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Padding = new System.Windows.Forms.Padding(0, 0, 18, 0);
            this.helpToolStripButton.Size = new System.Drawing.Size(38, 22);
            this.helpToolStripButton.Text = "Помощь";
            this.helpToolStripButton.Click += new System.EventHandler(this.helpToolStripButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator4.Visible = false;
            // 
            // adv_search
            // 
            this.adv_search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.adv_search.Enabled = false;
            this.adv_search.Image = ((System.Drawing.Image)(resources.GetObject("adv_search.Image")));
            this.adv_search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.adv_search.Name = "adv_search";
            this.adv_search.Size = new System.Drawing.Size(23, 22);
            this.adv_search.Text = "Расширенный поиск";
            this.adv_search.Click += new System.EventHandler(this.adv_search_Click);
            // 
            // reset_search
            // 
            this.reset_search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.reset_search.Image = ((System.Drawing.Image)(resources.GetObject("reset_search.Image")));
            this.reset_search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.reset_search.Name = "reset_search";
            this.reset_search.Size = new System.Drawing.Size(23, 22);
            this.reset_search.Text = "Сбросить поиск";
            this.reset_search.Visible = false;
            this.reset_search.Click += new System.EventHandler(this.reset_search_Click);
            // 
            // toolStripLabel_resetSearch
            // 
            this.toolStripLabel_resetSearch.Name = "toolStripLabel_resetSearch";
            this.toolStripLabel_resetSearch.Size = new System.Drawing.Size(94, 22);
            this.toolStripLabel_resetSearch.Text = "сбросить поиск";
            this.toolStripLabel_resetSearch.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panel1.Controls.Add(this.main_menu_button);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 670);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 30);
            this.panel1.TabIndex = 75;
            // 
            // main_menu_button
            // 
            this.main_menu_button.AutoSize = true;
            this.main_menu_button.BackColor = System.Drawing.Color.Transparent;
            this.main_menu_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.main_menu_button.FlatAppearance.BorderSize = 0;
            this.main_menu_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.main_menu_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.main_menu_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.main_menu_button.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.main_menu_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));
            this.main_menu_button.Location = new System.Drawing.Point(950, 0);
            this.main_menu_button.Name = "main_menu_button";
            this.main_menu_button.Size = new System.Drawing.Size(70, 30);
            this.main_menu_button.TabIndex = 91;
            this.main_menu_button.Text = "Меню";
            this.main_menu_button.UseVisualStyleBackColor = false;
            this.main_menu_button.Click += new System.EventHandler(this.main_menu_button_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 30);
            this.button1.TabIndex = 65;
            this.button1.Text = "Описание работы";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.descriptionShow_Click);
            // 
            // hand
            // 
            this.hand.Image = ((System.Drawing.Image)(resources.GetObject("hand.Image")));
            this.hand.Location = new System.Drawing.Point(45, 632);
            this.hand.Name = "hand";
            this.hand.Size = new System.Drawing.Size(32, 32);
            this.hand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.hand.TabIndex = 76;
            this.hand.TabStop = false;
            // 
            // table
            // 
            this.table.Image = ((System.Drawing.Image)(resources.GetObject("table.Image")));
            this.table.Location = new System.Drawing.Point(651, 456);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(16, 16);
            this.table.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.table.TabIndex = 77;
            this.table.TabStop = false;
            // 
            // search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1020, 700);
            this.Controls.Add(this.table);
            this.Controls.Add(this.hand);
            this.Controls.Add(this.choose);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.header_panel);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск элементов";
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            this.header_panel.ResumeLayout(false);
            this.header_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label search_label;
        private System.Windows.Forms.TextBox find_textbox;
        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button hide_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label db_label;
        private System.Windows.Forms.Label find_label;
        private System.Windows.Forms.Panel header_panel;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Label choose;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripDropDownButton toolstrip_dropDown_db;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_openDb;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_exportDb;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_returnDb;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_restoreDb;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_bptrans;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_pltrans;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_phdiods;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_processors;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_bis;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_keys;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_iou;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_sid;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton_importDb;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_importDb;
        private System.Windows.Forms.ToolStripButton toolStripButton_closeDb;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_closeDb;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton_addRow;
        private System.Windows.Forms.ToolStripButton toolStripButton_deleteRow;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox hand;
        private System.Windows.Forms.PictureBox table;
        private System.Windows.Forms.ToolStripButton adv_search;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton reset_search;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_resetSearch;
        private System.Windows.Forms.Button main_menu_button;
    }
}