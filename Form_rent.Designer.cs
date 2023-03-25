
namespace _25032023
{
    partial class Form_rent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_rent));
            this.Panel_top = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CompName_label = new System.Windows.Forms.Label();
            this.Panel_bot = new System.Windows.Forms.Panel();
            this.do_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.date_start_label = new System.Windows.Forms.Label();
            this.date_start_textbox = new System.Windows.Forms.TextBox();
            this.tranport_select_label = new System.Windows.Forms.Label();
            this.select_ts_combobox = new System.Windows.Forms.ComboBox();
            this.end_date_textbox = new System.Windows.Forms.TextBox();
            this.date_end_label = new System.Windows.Forms.Label();
            this.Panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Panel_bot.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_top
            // 
            this.Panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(37)))), ((int)(((byte)(181)))));
            this.Panel_top.Controls.Add(this.pictureBox1);
            this.Panel_top.Controls.Add(this.CompName_label);
            this.Panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_top.Location = new System.Drawing.Point(0, 0);
            this.Panel_top.Margin = new System.Windows.Forms.Padding(2, 9, 2, 9);
            this.Panel_top.Name = "Panel_top";
            this.Panel_top.Size = new System.Drawing.Size(460, 136);
            this.Panel_top.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 9, 2, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // CompName_label
            // 
            this.CompName_label.AutoSize = true;
            this.CompName_label.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompName_label.Location = new System.Drawing.Point(203, 41);
            this.CompName_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CompName_label.Name = "CompName_label";
            this.CompName_label.Size = new System.Drawing.Size(118, 50);
            this.CompName_label.TabIndex = 8;
            this.CompName_label.Text = "Мегадрайв";
            // 
            // Panel_bot
            // 
            this.Panel_bot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(37)))), ((int)(((byte)(181)))));
            this.Panel_bot.Controls.Add(this.do_button);
            this.Panel_bot.Controls.Add(this.exit_button);
            this.Panel_bot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_bot.Location = new System.Drawing.Point(0, 538);
            this.Panel_bot.Margin = new System.Windows.Forms.Padding(2, 9, 2, 9);
            this.Panel_bot.Name = "Panel_bot";
            this.Panel_bot.Size = new System.Drawing.Size(460, 113);
            this.Panel_bot.TabIndex = 11;
            // 
            // do_button
            // 
            this.do_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.do_button.Location = new System.Drawing.Point(12, 20);
            this.do_button.Name = "do_button";
            this.do_button.Size = new System.Drawing.Size(143, 81);
            this.do_button.TabIndex = 15;
            this.do_button.Text = "Применить расчет и выполнить запись ";
            this.do_button.UseVisualStyleBackColor = false;
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.exit_button.Location = new System.Drawing.Point(273, 20);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(143, 81);
            this.exit_button.TabIndex = 14;
            this.exit_button.Text = "Выйти";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // date_start_label
            // 
            this.date_start_label.AutoSize = true;
            this.date_start_label.Location = new System.Drawing.Point(114, 176);
            this.date_start_label.Name = "date_start_label";
            this.date_start_label.Size = new System.Drawing.Size(101, 23);
            this.date_start_label.TabIndex = 12;
            this.date_start_label.Text = "Дата начала аренды:";
            // 
            // date_start_textbox
            // 
            this.date_start_textbox.Location = new System.Drawing.Point(113, 212);
            this.date_start_textbox.Name = "date_start_textbox";
            this.date_start_textbox.Size = new System.Drawing.Size(121, 30);
            this.date_start_textbox.TabIndex = 13;
            // 
            // tranport_select_label
            // 
            this.tranport_select_label.AutoSize = true;
            this.tranport_select_label.Location = new System.Drawing.Point(109, 280);
            this.tranport_select_label.Name = "tranport_select_label";
            this.tranport_select_label.Size = new System.Drawing.Size(212, 23);
            this.tranport_select_label.TabIndex = 14;
            this.tranport_select_label.Text = "Транспортное средство выбранное для аренды:";
            // 
            // select_ts_combobox
            // 
            this.select_ts_combobox.FormattingEnabled = true;
            this.select_ts_combobox.Items.AddRange(new object[] {
            "MERIDA KALAHARI-500",
            "Suzuki RG200",
            "STELS 730",
            "LADA VESTA",
            "Kia Rio",
            "MERIDA KALAHARI-500",
            "Alpha RX-11",
            "Alpha RX-15",
            "Yamaha G800",
            "Renault Sandero-II",
            "GT-50"});
            this.select_ts_combobox.Location = new System.Drawing.Point(113, 315);
            this.select_ts_combobox.Name = "select_ts_combobox";
            this.select_ts_combobox.Size = new System.Drawing.Size(121, 31);
            this.select_ts_combobox.TabIndex = 15;
            // 
            // end_date_textbox
            // 
            this.end_date_textbox.Location = new System.Drawing.Point(113, 416);
            this.end_date_textbox.Name = "end_date_textbox";
            this.end_date_textbox.Size = new System.Drawing.Size(121, 30);
            this.end_date_textbox.TabIndex = 17;
            // 
            // date_end_label
            // 
            this.date_end_label.AutoSize = true;
            this.date_end_label.Location = new System.Drawing.Point(114, 380);
            this.date_end_label.Name = "date_end_label";
            this.date_end_label.Size = new System.Drawing.Size(119, 23);
            this.date_end_label.TabIndex = 16;
            this.date_end_label.Text = "Дата окончания аренды:";
            // 
            // Form_rent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 651);
            this.Controls.Add(this.end_date_textbox);
            this.Controls.Add(this.date_end_label);
            this.Controls.Add(this.select_ts_combobox);
            this.Controls.Add(this.tranport_select_label);
            this.Controls.Add(this.date_start_textbox);
            this.Controls.Add(this.date_start_label);
            this.Controls.Add(this.Panel_top);
            this.Controls.Add(this.Panel_bot);
            this.Font = new System.Drawing.Font("Gabriola", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.Name = "Form_rent";
            this.Text = "Форма аренды";
            this.Panel_top.ResumeLayout(false);
            this.Panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Panel_bot.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel_top;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label CompName_label;
        private System.Windows.Forms.Panel Panel_bot;
        private System.Windows.Forms.Button do_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label date_start_label;
        private System.Windows.Forms.TextBox date_start_textbox;
        private System.Windows.Forms.Label tranport_select_label;
        private System.Windows.Forms.ComboBox select_ts_combobox;
        private System.Windows.Forms.TextBox end_date_textbox;
        private System.Windows.Forms.Label date_end_label;
    }
}