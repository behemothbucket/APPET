namespace APPEET
{
    partial class auth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(auth));
            this.bg_logo = new System.Windows.Forms.PictureBox();
            this.name_label = new System.Windows.Forms.Label();
            this.second_name_label = new System.Windows.Forms.Label();
            this.group_label = new System.Windows.Forms.Label();
            this.variant_label = new System.Windows.Forms.Label();
            this.variant_comboBox = new System.Windows.Forms.ComboBox();
            this.login_button = new System.Windows.Forms.Button();
            this.error_label = new System.Windows.Forms.Label();
            this.auth_label = new System.Windows.Forms.Label();
            this.hide_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.header_panel = new System.Windows.Forms.Panel();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.second_name_textbox = new System.Windows.Forms.TextBox();
            this.group_textbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bg_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // bg_logo
            // 
            this.bg_logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bg_logo.Image = ((System.Drawing.Image)(resources.GetObject("bg_logo.Image")));
            this.bg_logo.Location = new System.Drawing.Point(0, 0);
            this.bg_logo.Name = "bg_logo";
            this.bg_logo.Size = new System.Drawing.Size(695, 488);
            this.bg_logo.TabIndex = 0;
            this.bg_logo.TabStop = false;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.name_label.Location = new System.Drawing.Point(399, 114);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(34, 17);
            this.name_label.TabIndex = 28;
            this.name_label.Text = "Имя";
            // 
            // second_name_label
            // 
            this.second_name_label.AutoSize = true;
            this.second_name_label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.second_name_label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.second_name_label.Location = new System.Drawing.Point(398, 179);
            this.second_name_label.Name = "second_name_label";
            this.second_name_label.Size = new System.Drawing.Size(61, 17);
            this.second_name_label.TabIndex = 30;
            this.second_name_label.Text = "Фамилия";
            // 
            // group_label
            // 
            this.group_label.AutoSize = true;
            this.group_label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.group_label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.group_label.Location = new System.Drawing.Point(399, 242);
            this.group_label.Name = "group_label";
            this.group_label.Size = new System.Drawing.Size(49, 17);
            this.group_label.TabIndex = 32;
            this.group_label.Text = "Группа";
            // 
            // variant_label
            // 
            this.variant_label.AutoSize = true;
            this.variant_label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.variant_label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.variant_label.Location = new System.Drawing.Point(400, 307);
            this.variant_label.Name = "variant_label";
            this.variant_label.Size = new System.Drawing.Size(56, 17);
            this.variant_label.TabIndex = 33;
            this.variant_label.Text = "Вариант";
            // 
            // variant_comboBox
            // 
            this.variant_comboBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.variant_comboBox.DropDownHeight = 70;
            this.variant_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.variant_comboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.variant_comboBox.FormattingEnabled = true;
            this.variant_comboBox.IntegralHeight = false;
            this.variant_comboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.variant_comboBox.Location = new System.Drawing.Point(404, 336);
            this.variant_comboBox.Name = "variant_comboBox";
            this.variant_comboBox.Size = new System.Drawing.Size(124, 29);
            this.variant_comboBox.TabIndex = 4;
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(108)))));
            this.login_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.login_button.FlatAppearance.BorderSize = 2;
            this.login_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(206)))));
            this.login_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(85)))));
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_button.ForeColor = System.Drawing.SystemColors.Control;
            this.login_button.Location = new System.Drawing.Point(464, 420);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(115, 44);
            this.login_button.TabIndex = 5;
            this.login_button.Text = "Войти";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click_1);
            this.login_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.login_button_MouseDown);
            this.login_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.login_button_MouseUp);
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.error_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.error_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.error_label.Location = new System.Drawing.Point(439, 380);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(151, 21);
            this.error_label.TabIndex = 37;
            this.error_label.Text = "Заполните все поля";
            this.error_label.Visible = false;
            // 
            // auth_label
            // 
            this.auth_label.AutoSize = true;
            this.auth_label.BackColor = System.Drawing.Color.Transparent;
            this.auth_label.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.auth_label.ForeColor = System.Drawing.Color.Transparent;
            this.auth_label.Location = new System.Drawing.Point(394, 60);
            this.auth_label.Name = "auth_label";
            this.auth_label.Size = new System.Drawing.Size(83, 37);
            this.auth_label.TabIndex = 27;
            this.auth_label.Text = "Вход";
            // 
            // hide_button
            // 
            this.hide_button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.hide_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hide_button.FlatAppearance.BorderSize = 0;
            this.hide_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.hide_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.hide_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hide_button.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hide_button.ForeColor = System.Drawing.Color.Transparent;
            this.hide_button.Location = new System.Drawing.Point(625, 0);
            this.hide_button.Name = "hide_button";
            this.hide_button.Size = new System.Drawing.Size(35, 30);
            this.hide_button.TabIndex = 6;
            this.hide_button.Text = "–";
            this.hide_button.UseVisualStyleBackColor = false;
            this.hide_button.Click += new System.EventHandler(this.hide_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.exit_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit_button.BackgroundImage")));
            this.exit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exit_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.exit_button.FlatAppearance.BorderSize = 0;
            this.exit_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(4)))), ((int)(((byte)(8)))));
            this.exit_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Font = new System.Drawing.Font("Ubuntu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit_button.ForeColor = System.Drawing.Color.White;
            this.exit_button.Location = new System.Drawing.Point(660, 0);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(35, 30);
            this.exit_button.TabIndex = 7;
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // header_panel
            // 
            this.header_panel.BackColor = System.Drawing.Color.Transparent;
            this.header_panel.ForeColor = System.Drawing.Color.Transparent;
            this.header_panel.Location = new System.Drawing.Point(0, 0);
            this.header_panel.Name = "header_panel";
            this.header_panel.Size = new System.Drawing.Size(695, 56);
            this.header_panel.TabIndex = 42;
            this.header_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.header_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.header_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // name_textbox
            // 
            this.name_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_textbox.Location = new System.Drawing.Point(402, 143);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(229, 29);
            this.name_textbox.TabIndex = 1;
            // 
            // second_name_textbox
            // 
            this.second_name_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.second_name_textbox.Location = new System.Drawing.Point(402, 206);
            this.second_name_textbox.Name = "second_name_textbox";
            this.second_name_textbox.Size = new System.Drawing.Size(229, 29);
            this.second_name_textbox.TabIndex = 2;
            // 
            // group_textbox
            // 
            this.group_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.group_textbox.Location = new System.Drawing.Point(402, 270);
            this.group_textbox.Name = "group_textbox";
            this.group_textbox.Size = new System.Drawing.Size(229, 29);
            this.group_textbox.TabIndex = 3;
            // 
            // auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(695, 488);
            this.Controls.Add(this.group_textbox);
            this.Controls.Add(this.second_name_textbox);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.hide_button);
            this.Controls.Add(this.header_panel);
            this.Controls.Add(this.error_label);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.variant_comboBox);
            this.Controls.Add(this.variant_label);
            this.Controls.Add(this.group_label);
            this.Controls.Add(this.second_name_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.auth_label);
            this.Controls.Add(this.bg_logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "auth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.auth_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.bg_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox bg_logo;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label second_name_label;
        private System.Windows.Forms.Label group_label;
        private System.Windows.Forms.Label variant_label;
        private System.Windows.Forms.ComboBox variant_comboBox;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Label error_label;
        private System.Windows.Forms.Label auth_label;
        private System.Windows.Forms.Button hide_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Panel header_panel;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.TextBox second_name_textbox;
        private System.Windows.Forms.TextBox group_textbox;
    }
}