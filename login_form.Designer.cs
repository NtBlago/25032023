
namespace _25032023
{
    partial class login_form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_form));
            this.Panel_top = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CompName_label = new System.Windows.Forms.Label();
            this.Panel_bot = new System.Windows.Forms.Panel();
            this.enter_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.login_label = new System.Windows.Forms.Label();
            this.login_textbox = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.Panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_top
            // 
            this.Panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(37)))), ((int)(((byte)(181)))));
            this.Panel_top.Controls.Add(this.pictureBox1);
            this.Panel_top.Controls.Add(this.CompName_label);
            this.Panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_top.Location = new System.Drawing.Point(0, 0);
            this.Panel_top.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.Panel_top.Name = "Panel_top";
            this.Panel_top.Size = new System.Drawing.Size(467, 131);
            this.Panel_top.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // CompName_label
            // 
            this.CompName_label.AutoSize = true;
            this.CompName_label.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompName_label.Location = new System.Drawing.Point(217, 37);
            this.CompName_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CompName_label.Name = "CompName_label";
            this.CompName_label.Size = new System.Drawing.Size(118, 50);
            this.CompName_label.TabIndex = 8;
            this.CompName_label.Text = "Мегадрайв";
            // 
            // Panel_bot
            // 
            this.Panel_bot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(37)))), ((int)(((byte)(181)))));
            this.Panel_bot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_bot.Location = new System.Drawing.Point(0, 612);
            this.Panel_bot.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.Panel_bot.Name = "Panel_bot";
            this.Panel_bot.Size = new System.Drawing.Size(467, 131);
            this.Panel_bot.TabIndex = 1;
            // 
            // enter_button
            // 
            this.enter_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.enter_button.Location = new System.Drawing.Point(170, 407);
            this.enter_button.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.enter_button.Name = "enter_button";
            this.enter_button.Size = new System.Drawing.Size(125, 67);
            this.enter_button.TabIndex = 2;
            this.enter_button.Text = "Войти";
            this.enter_button.UseVisualStyleBackColor = false;
            this.enter_button.Click += new System.EventHandler(this.enter_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.exit_button.Location = new System.Drawing.Point(170, 484);
            this.exit_button.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(125, 66);
            this.exit_button.TabIndex = 3;
            this.exit_button.Text = "Выйти из программы.";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Location = new System.Drawing.Point(166, 171);
            this.login_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(75, 23);
            this.login_label.TabIndex = 4;
            this.login_label.Text = "Введите логин:";
            // 
            // login_textbox
            // 
            this.login_textbox.Location = new System.Drawing.Point(168, 217);
            this.login_textbox.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.login_textbox.Name = "login_textbox";
            this.login_textbox.Size = new System.Drawing.Size(123, 30);
            this.login_textbox.TabIndex = 5;
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(168, 338);
            this.password_textbox.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(123, 30);
            this.password_textbox.TabIndex = 7;
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(166, 292);
            this.password_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(79, 23);
            this.password_label.TabIndex = 6;
            this.password_label.Text = "Введите пароль:";
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(467, 743);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.login_textbox);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.enter_button);
            this.Controls.Add(this.Panel_bot);
            this.Controls.Add(this.Panel_top);
            this.Font = new System.Drawing.Font("Gabriola", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.Name = "login_form";
            this.Text = "Вход в программу";
            this.Shown += new System.EventHandler(this.login_form_Shown);
            this.Panel_top.ResumeLayout(false);
            this.Panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel_top;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label CompName_label;
        private System.Windows.Forms.Panel Panel_bot;
        private System.Windows.Forms.Button enter_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.TextBox login_textbox;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.Label password_label;
    }
}

