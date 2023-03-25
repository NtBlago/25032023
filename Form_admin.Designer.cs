
namespace _25032023
{
    partial class Form_admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_admin));
            this.Panel_top = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CompName_label = new System.Windows.Forms.Label();
            this.Panel_bot = new System.Windows.Forms.Panel();
            this.exit_button = new System.Windows.Forms.Button();
            this.do_button = new System.Windows.Forms.Button();
            this.newname_label = new System.Windows.Forms.Label();
            this.newname_textBox = new System.Windows.Forms.TextBox();
            this.newpatro_textBox = new System.Windows.Forms.TextBox();
            this.newpatro_label = new System.Windows.Forms.Label();
            this.newsecondname_textBox = new System.Windows.Forms.TextBox();
            this.newsecondname_label = new System.Windows.Forms.Label();
            this.newlogin_textBox = new System.Windows.Forms.TextBox();
            this.newlogin_label = new System.Windows.Forms.Label();
            this.newpassword_textBox = new System.Windows.Forms.TextBox();
            this.newpassword_label = new System.Windows.Forms.Label();
            this.doublepass_textBox = new System.Windows.Forms.TextBox();
            this.doublepass_label = new System.Windows.Forms.Label();
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
            this.Panel_top.Size = new System.Drawing.Size(478, 174);
            this.Panel_top.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 9, 2, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // CompName_label
            // 
            this.CompName_label.AutoSize = true;
            this.CompName_label.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompName_label.Location = new System.Drawing.Point(304, 56);
            this.CompName_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CompName_label.Name = "CompName_label";
            this.CompName_label.Size = new System.Drawing.Size(118, 50);
            this.CompName_label.TabIndex = 8;
            this.CompName_label.Text = "Мегадрайв";
            // 
            // Panel_bot
            // 
            this.Panel_bot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(37)))), ((int)(((byte)(181)))));
            this.Panel_bot.Controls.Add(this.exit_button);
            this.Panel_bot.Controls.Add(this.do_button);
            this.Panel_bot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_bot.Location = new System.Drawing.Point(0, 603);
            this.Panel_bot.Margin = new System.Windows.Forms.Padding(2, 9, 2, 9);
            this.Panel_bot.Name = "Panel_bot";
            this.Panel_bot.Size = new System.Drawing.Size(478, 100);
            this.Panel_bot.TabIndex = 11;
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.exit_button.Location = new System.Drawing.Point(265, 16);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(143, 81);
            this.exit_button.TabIndex = 15;
            this.exit_button.Text = "Выйти";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // do_button
            // 
            this.do_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.do_button.Location = new System.Drawing.Point(12, 7);
            this.do_button.Name = "do_button";
            this.do_button.Size = new System.Drawing.Size(143, 81);
            this.do_button.TabIndex = 14;
            this.do_button.Text = "Применить изменения";
            this.do_button.UseVisualStyleBackColor = false;
            // 
            // newname_label
            // 
            this.newname_label.AutoSize = true;
            this.newname_label.Location = new System.Drawing.Point(36, 198);
            this.newname_label.Name = "newname_label";
            this.newname_label.Size = new System.Drawing.Size(119, 23);
            this.newname_label.TabIndex = 12;
            this.newname_label.Text = "Имя нового пользователя";
            // 
            // newname_textBox
            // 
            this.newname_textBox.Location = new System.Drawing.Point(40, 224);
            this.newname_textBox.Name = "newname_textBox";
            this.newname_textBox.Size = new System.Drawing.Size(100, 30);
            this.newname_textBox.TabIndex = 13;
            // 
            // newpatro_textBox
            // 
            this.newpatro_textBox.Location = new System.Drawing.Point(40, 377);
            this.newpatro_textBox.Name = "newpatro_textBox";
            this.newpatro_textBox.Size = new System.Drawing.Size(100, 30);
            this.newpatro_textBox.TabIndex = 15;
            // 
            // newpatro_label
            // 
            this.newpatro_label.AutoSize = true;
            this.newpatro_label.Location = new System.Drawing.Point(36, 343);
            this.newpatro_label.Name = "newpatro_label";
            this.newpatro_label.Size = new System.Drawing.Size(145, 23);
            this.newpatro_label.TabIndex = 14;
            this.newpatro_label.Text = "Отчество нового пользователя";
            // 
            // newsecondname_textBox
            // 
            this.newsecondname_textBox.Location = new System.Drawing.Point(40, 297);
            this.newsecondname_textBox.Name = "newsecondname_textBox";
            this.newsecondname_textBox.Size = new System.Drawing.Size(100, 30);
            this.newsecondname_textBox.TabIndex = 17;
            // 
            // newsecondname_label
            // 
            this.newsecondname_label.AutoSize = true;
            this.newsecondname_label.Location = new System.Drawing.Point(36, 271);
            this.newsecondname_label.Name = "newsecondname_label";
            this.newsecondname_label.Size = new System.Drawing.Size(140, 23);
            this.newsecondname_label.TabIndex = 16;
            this.newsecondname_label.Text = "Фамилия нового пользователя";
            // 
            // newlogin_textBox
            // 
            this.newlogin_textBox.Location = new System.Drawing.Point(313, 224);
            this.newlogin_textBox.Name = "newlogin_textBox";
            this.newlogin_textBox.Size = new System.Drawing.Size(100, 30);
            this.newlogin_textBox.TabIndex = 19;
            // 
            // newlogin_label
            // 
            this.newlogin_label.AutoSize = true;
            this.newlogin_label.Location = new System.Drawing.Point(309, 198);
            this.newlogin_label.Name = "newlogin_label";
            this.newlogin_label.Size = new System.Drawing.Size(127, 23);
            this.newlogin_label.TabIndex = 18;
            this.newlogin_label.Text = "Логин нового пользователя";
            // 
            // newpassword_textBox
            // 
            this.newpassword_textBox.Location = new System.Drawing.Point(313, 293);
            this.newpassword_textBox.Name = "newpassword_textBox";
            this.newpassword_textBox.Size = new System.Drawing.Size(100, 30);
            this.newpassword_textBox.TabIndex = 21;
            // 
            // newpassword_label
            // 
            this.newpassword_label.AutoSize = true;
            this.newpassword_label.Location = new System.Drawing.Point(309, 267);
            this.newpassword_label.Name = "newpassword_label";
            this.newpassword_label.Size = new System.Drawing.Size(131, 23);
            this.newpassword_label.TabIndex = 20;
            this.newpassword_label.Text = "Пароль нового пользователя";
            // 
            // doublepass_textBox
            // 
            this.doublepass_textBox.Location = new System.Drawing.Point(309, 369);
            this.doublepass_textBox.Name = "doublepass_textBox";
            this.doublepass_textBox.Size = new System.Drawing.Size(100, 30);
            this.doublepass_textBox.TabIndex = 23;
            // 
            // doublepass_label
            // 
            this.doublepass_label.AutoSize = true;
            this.doublepass_label.Location = new System.Drawing.Point(305, 343);
            this.doublepass_label.Name = "doublepass_label";
            this.doublepass_label.Size = new System.Drawing.Size(108, 23);
            this.doublepass_label.TabIndex = 22;
            this.doublepass_label.Text = "Продублируйте пароль ";
            // 
            // Form_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 703);
            this.Controls.Add(this.doublepass_textBox);
            this.Controls.Add(this.doublepass_label);
            this.Controls.Add(this.newpassword_textBox);
            this.Controls.Add(this.newpassword_label);
            this.Controls.Add(this.newlogin_textBox);
            this.Controls.Add(this.newlogin_label);
            this.Controls.Add(this.newsecondname_textBox);
            this.Controls.Add(this.newsecondname_label);
            this.Controls.Add(this.newpatro_textBox);
            this.Controls.Add(this.newpatro_label);
            this.Controls.Add(this.newname_textBox);
            this.Controls.Add(this.newname_label);
            this.Controls.Add(this.Panel_top);
            this.Controls.Add(this.Panel_bot);
            this.Font = new System.Drawing.Font("Gabriola", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.Name = "Form_admin";
            this.Text = "Администрирование";
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
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button do_button;
        private System.Windows.Forms.Label newname_label;
        private System.Windows.Forms.TextBox newname_textBox;
        private System.Windows.Forms.TextBox newpatro_textBox;
        private System.Windows.Forms.Label newpatro_label;
        private System.Windows.Forms.TextBox newsecondname_textBox;
        private System.Windows.Forms.Label newsecondname_label;
        private System.Windows.Forms.TextBox newlogin_textBox;
        private System.Windows.Forms.Label newlogin_label;
        private System.Windows.Forms.TextBox newpassword_textBox;
        private System.Windows.Forms.Label newpassword_label;
        private System.Windows.Forms.TextBox doublepass_textBox;
        private System.Windows.Forms.Label doublepass_label;
    }
}