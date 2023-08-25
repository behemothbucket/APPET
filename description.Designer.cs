namespace APPEET
{
    partial class description_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(description_form));
            this.hide_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.top_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.html_viewer = new System.Windows.Forms.WebBrowser();
            this.main_menu_button = new System.Windows.Forms.Button();
            this.variant_label = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.top_panel.SuspendLayout();
            this.SuspendLayout();
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
            this.hide_button.Location = new System.Drawing.Point(1130, 0);
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
            this.exit_button.Location = new System.Drawing.Point(1165, 0);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(35, 30);
            this.exit_button.TabIndex = 37;
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.top_panel.Controls.Add(this.label1);
            this.top_panel.Controls.Add(this.hide_button);
            this.top_panel.Controls.Add(this.exit_button);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(1200, 30);
            this.top_panel.TabIndex = 60;
            this.top_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.top_panel_MouseDown);
            this.top_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.top_panel_MouseMove);
            this.top_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.top_panel_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.MaximumSize = new System.Drawing.Size(500, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 65;
            this.label1.Text = "Цель и описание";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.top_panel_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.top_panel_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.top_panel_MouseUp);
            // 
            // html_viewer
            // 
            this.html_viewer.Location = new System.Drawing.Point(0, 30);
            this.html_viewer.MinimumSize = new System.Drawing.Size(20, 20);
            this.html_viewer.Name = "html_viewer";
            this.html_viewer.Size = new System.Drawing.Size(1200, 590);
            this.html_viewer.TabIndex = 61;
            // 
            // main_menu_button
            // 
            this.main_menu_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(108)))));
            this.main_menu_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.main_menu_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.main_menu_button.FlatAppearance.BorderSize = 2;
            this.main_menu_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(206)))));
            this.main_menu_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(85)))));
            this.main_menu_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.main_menu_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.main_menu_button.ForeColor = System.Drawing.SystemColors.Control;
            this.main_menu_button.Location = new System.Drawing.Point(12, 637);
            this.main_menu_button.Name = "main_menu_button";
            this.main_menu_button.Size = new System.Drawing.Size(130, 45);
            this.main_menu_button.TabIndex = 66;
            this.main_menu_button.Text = "Главное меню";
            this.main_menu_button.UseVisualStyleBackColor = false;
            this.main_menu_button.Click += new System.EventHandler(this.main_menu_button_Click);
            // 
            // variant_label
            // 
            this.variant_label.AutoSize = true;
            this.variant_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.variant_label.Location = new System.Drawing.Point(245, 649);
            this.variant_label.Name = "variant_label";
            this.variant_label.Size = new System.Drawing.Size(0, 21);
            this.variant_label.TabIndex = 67;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(25)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.Location = new System.Drawing.Point(460, 631);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(592, 57);
            this.richTextBox1.TabIndex = 68;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = "";
            // 
            // description_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.variant_label);
            this.Controls.Add(this.main_menu_button);
            this.Controls.Add(this.html_viewer);
            this.Controls.Add(this.top_panel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "description_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Цель и описание";
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hide_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.WebBrowser html_viewer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button main_menu_button;
        private System.Windows.Forms.Label variant_label;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}