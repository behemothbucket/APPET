namespace APPEET
{
    partial class advsearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(advsearch));
            this.search_label = new System.Windows.Forms.Label();
            this.parameter_comboBox = new System.Windows.Forms.ComboBox();
            this.exit_button = new System.Windows.Forms.Button();
            this.value_textBox = new System.Windows.Forms.TextBox();
            this.status_richTextBox = new System.Windows.Forms.RichTextBox();
            this.add = new System.Windows.Forms.Button();
            this.top_panel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.hide_button = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.advsearch_button = new System.Windows.Forms.Button();
            this.top_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // search_label
            // 
            this.search_label.AutoSize = true;
            this.search_label.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));
            this.search_label.Location = new System.Drawing.Point(24, 47);
            this.search_label.Name = "search_label";
            this.search_label.Size = new System.Drawing.Size(273, 37);
            this.search_label.TabIndex = 1;
            this.search_label.Text = "Расширенный поиск";
            // 
            // parameter_comboBox
            // 
            this.parameter_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parameter_comboBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parameter_comboBox.FormattingEnabled = true;
            this.parameter_comboBox.Location = new System.Drawing.Point(32, 159);
            this.parameter_comboBox.Name = "parameter_comboBox";
            this.parameter_comboBox.Size = new System.Drawing.Size(279, 25);
            this.parameter_comboBox.TabIndex = 64;
            this.parameter_comboBox.SelectionChangeCommitted += new System.EventHandler(this.parameter_comboBox_SelectionChangeCommitted);
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
            this.exit_button.Location = new System.Drawing.Point(465, 0);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(35, 30);
            this.exit_button.TabIndex = 65;
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // value_textBox
            // 
            this.value_textBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.value_textBox.Location = new System.Drawing.Point(32, 262);
            this.value_textBox.Name = "value_textBox";
            this.value_textBox.Size = new System.Drawing.Size(164, 25);
            this.value_textBox.TabIndex = 66;
            // 
            // status_richTextBox
            // 
            this.status_richTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.status_richTextBox.Location = new System.Drawing.Point(31, 338);
            this.status_richTextBox.Name = "status_richTextBox";
            this.status_richTextBox.ReadOnly = true;
            this.status_richTextBox.Size = new System.Drawing.Size(429, 173);
            this.status_richTextBox.TabIndex = 68;
            this.status_richTextBox.Text = resources.GetString("status_richTextBox.Text");
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(156)))));
            this.add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add.Enabled = false;
            this.add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(136)))));
            this.add.FlatAppearance.BorderSize = 2;
            this.add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(156)))));
            this.add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(136)))));
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add.ForeColor = System.Drawing.SystemColors.Control;
            this.add.Location = new System.Drawing.Point(253, 255);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(91, 35);
            this.add.TabIndex = 72;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.top_panel.Controls.Add(this.label3);
            this.top_panel.Controls.Add(this.hide_button);
            this.top_panel.Controls.Add(this.exit_button);
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(500, 30);
            this.top_panel.TabIndex = 74;
            this.top_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.top_panel_MouseDown);
            this.top_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.top_panel_MouseMove);
            this.top_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.top_panel_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(8, 7);
            this.label3.MaximumSize = new System.Drawing.Size(500, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 76;
            this.label3.Text = "Расширенный поиск";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.top_panel_MouseDown);
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.top_panel_MouseMove);
            this.label3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.top_panel_MouseUp);
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
            this.hide_button.Location = new System.Drawing.Point(430, 0);
            this.hide_button.Name = "hide_button";
            this.hide_button.Size = new System.Drawing.Size(35, 30);
            this.hide_button.TabIndex = 76;
            this.hide_button.Text = "–";
            this.hide_button.UseVisualStyleBackColor = false;
            this.hide_button.Click += new System.EventHandler(this.hide_button_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.Enabled = false;
            this.clear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(4)))), ((int)(((byte)(8)))));
            this.clear.FlatAppearance.BorderSize = 2;
            this.clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(4)))), ((int)(((byte)(8)))));
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear.ForeColor = System.Drawing.SystemColors.Control;
            this.clear.Location = new System.Drawing.Point(369, 255);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(91, 35);
            this.clear.TabIndex = 75;
            this.clear.Text = "Очистить";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Location = new System.Drawing.Point(26, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 30);
            this.label1.TabIndex = 63;
            this.label1.Text = "Параметр";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Location = new System.Drawing.Point(27, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 30);
            this.label2.TabIndex = 67;
            this.label2.Text = "Значение";
            // 
            // advsearch_button
            // 
            this.advsearch_button.BackColor = System.Drawing.Color.Black;
            this.advsearch_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.advsearch_button.Enabled = false;
            this.advsearch_button.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.advsearch_button.FlatAppearance.BorderSize = 2;
            this.advsearch_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.advsearch_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.advsearch_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.advsearch_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.advsearch_button.ForeColor = System.Drawing.Color.White;
            this.advsearch_button.Location = new System.Drawing.Point(212, 529);
            this.advsearch_button.Name = "advsearch_button";
            this.advsearch_button.Size = new System.Drawing.Size(96, 35);
            this.advsearch_button.TabIndex = 88;
            this.advsearch_button.Text = "Поиск";
            this.advsearch_button.UseVisualStyleBackColor = false;
            this.advsearch_button.Click += new System.EventHandler(this.advsearch_button_Click);
            // 
            // advsearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(500, 578);
            this.Controls.Add(this.advsearch_button);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.top_panel);
            this.Controls.Add(this.add);
            this.Controls.Add(this.status_richTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.value_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.parameter_comboBox);
            this.Controls.Add(this.search_label);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "advsearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расширенный поиск";
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label search_label;
        private System.Windows.Forms.ComboBox parameter_comboBox;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.TextBox value_textBox;
        private System.Windows.Forms.RichTextBox status_richTextBox;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button hide_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button advsearch_button;
    }
}