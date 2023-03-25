
namespace _25032023
{
    partial class Form_menager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_menager));
            this.Panel_top = new System.Windows.Forms.Panel();
            this.picture_comp = new System.Windows.Forms.PictureBox();
            this.CompName_label = new System.Windows.Forms.Label();
            this.Panel_bot = new System.Windows.Forms.Panel();
            this.button_exit = new System.Windows.Forms.Button();
            this.do_button = new System.Windows.Forms.Button();
            this.info_dgv = new System.Windows.Forms.DataGridView();
            this.clientidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datebeginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beginpointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endpointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientstransportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._25032023_safinDataSet2 = new _25032023._25032023_safinDataSet2();
            this.clients_transportsTableAdapter = new _25032023._25032023_safinDataSet2TableAdapters.clients_transportsTableAdapter();
            this.client_info_dgv = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this._25032023_safinDataSet5 = new _25032023._25032023_safinDataSet5();
            this._25032023_safinDataSet3 = new _25032023._25032023_safinDataSet3();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new _25032023._25032023_safinDataSet3TableAdapters.clientsTableAdapter();
            this._25032023_safinDataSet4 = new _25032023._25032023_safinDataSet4();
            this.clientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter1 = new _25032023._25032023_safinDataSet4TableAdapters.clientsTableAdapter();
            this.clientsTableAdapter2 = new _25032023._25032023_safinDataSet5TableAdapters.clientsTableAdapter();
            this.newname_label = new System.Windows.Forms.Label();
            this.newname_textBox = new System.Windows.Forms.TextBox();
            this.newcolor_textBox = new System.Windows.Forms.TextBox();
            this.newcolor_label = new System.Windows.Forms.Label();
            this.newnumber_textBox = new System.Windows.Forms.TextBox();
            this.newnumber_label = new System.Windows.Forms.Label();
            this.Panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_comp)).BeginInit();
            this.Panel_bot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.info_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientstransportsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._25032023_safinDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_info_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._25032023_safinDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._25032023_safinDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._25032023_safinDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_top
            // 
            this.Panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(37)))), ((int)(((byte)(181)))));
            this.Panel_top.Controls.Add(this.picture_comp);
            this.Panel_top.Controls.Add(this.CompName_label);
            this.Panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_top.Location = new System.Drawing.Point(0, 0);
            this.Panel_top.Margin = new System.Windows.Forms.Padding(2, 9, 2, 9);
            this.Panel_top.Name = "Panel_top";
            this.Panel_top.Size = new System.Drawing.Size(1015, 150);
            this.Panel_top.TabIndex = 10;
            // 
            // picture_comp
            // 
            this.picture_comp.Image = ((System.Drawing.Image)(resources.GetObject("picture_comp.Image")));
            this.picture_comp.Location = new System.Drawing.Point(0, 0);
            this.picture_comp.Margin = new System.Windows.Forms.Padding(2, 9, 2, 9);
            this.picture_comp.Name = "picture_comp";
            this.picture_comp.Size = new System.Drawing.Size(125, 150);
            this.picture_comp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_comp.TabIndex = 8;
            this.picture_comp.TabStop = false;
            // 
            // CompName_label
            // 
            this.CompName_label.AutoSize = true;
            this.CompName_label.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompName_label.Location = new System.Drawing.Point(289, 54);
            this.CompName_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CompName_label.Name = "CompName_label";
            this.CompName_label.Size = new System.Drawing.Size(118, 50);
            this.CompName_label.TabIndex = 8;
            this.CompName_label.Text = "Мегадрайв";
            // 
            // Panel_bot
            // 
            this.Panel_bot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(37)))), ((int)(((byte)(181)))));
            this.Panel_bot.Controls.Add(this.button_exit);
            this.Panel_bot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_bot.Location = new System.Drawing.Point(0, 815);
            this.Panel_bot.Margin = new System.Windows.Forms.Padding(2, 9, 2, 9);
            this.Panel_bot.Name = "Panel_bot";
            this.Panel_bot.Size = new System.Drawing.Size(1015, 146);
            this.Panel_bot.TabIndex = 11;
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.button_exit.Location = new System.Drawing.Point(835, 45);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(143, 81);
            this.button_exit.TabIndex = 15;
            this.button_exit.Text = "Выйти";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // do_button
            // 
            this.do_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.do_button.Location = new System.Drawing.Point(809, 443);
            this.do_button.Name = "do_button";
            this.do_button.Size = new System.Drawing.Size(143, 81);
            this.do_button.TabIndex = 14;
            this.do_button.Text = "Добавить данные";
            this.do_button.UseVisualStyleBackColor = false;
            // 
            // info_dgv
            // 
            this.info_dgv.AutoGenerateColumns = false;
            this.info_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.info_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientidDataGridViewTextBoxColumn,
            this.transportidDataGridViewTextBoxColumn,
            this.datebeginDataGridViewTextBoxColumn,
            this.dateendDataGridViewTextBoxColumn,
            this.beginpointDataGridViewTextBoxColumn,
            this.endpointDataGridViewTextBoxColumn,
            this.transportnumDataGridViewTextBoxColumn});
            this.info_dgv.DataSource = this.clientstransportsBindingSource;
            this.info_dgv.Location = new System.Drawing.Point(0, 151);
            this.info_dgv.Name = "info_dgv";
            this.info_dgv.Size = new System.Drawing.Size(356, 664);
            this.info_dgv.TabIndex = 12;
            // 
            // clientidDataGridViewTextBoxColumn
            // 
            this.clientidDataGridViewTextBoxColumn.DataPropertyName = "client_id";
            this.clientidDataGridViewTextBoxColumn.HeaderText = "client_id";
            this.clientidDataGridViewTextBoxColumn.Name = "clientidDataGridViewTextBoxColumn";
            // 
            // transportidDataGridViewTextBoxColumn
            // 
            this.transportidDataGridViewTextBoxColumn.DataPropertyName = "transport_id";
            this.transportidDataGridViewTextBoxColumn.HeaderText = "transport_id";
            this.transportidDataGridViewTextBoxColumn.Name = "transportidDataGridViewTextBoxColumn";
            // 
            // datebeginDataGridViewTextBoxColumn
            // 
            this.datebeginDataGridViewTextBoxColumn.DataPropertyName = "date_begin";
            this.datebeginDataGridViewTextBoxColumn.HeaderText = "date_begin";
            this.datebeginDataGridViewTextBoxColumn.Name = "datebeginDataGridViewTextBoxColumn";
            // 
            // dateendDataGridViewTextBoxColumn
            // 
            this.dateendDataGridViewTextBoxColumn.DataPropertyName = "date_end";
            this.dateendDataGridViewTextBoxColumn.HeaderText = "date_end";
            this.dateendDataGridViewTextBoxColumn.Name = "dateendDataGridViewTextBoxColumn";
            // 
            // beginpointDataGridViewTextBoxColumn
            // 
            this.beginpointDataGridViewTextBoxColumn.DataPropertyName = "begin_point";
            this.beginpointDataGridViewTextBoxColumn.HeaderText = "begin_point";
            this.beginpointDataGridViewTextBoxColumn.Name = "beginpointDataGridViewTextBoxColumn";
            // 
            // endpointDataGridViewTextBoxColumn
            // 
            this.endpointDataGridViewTextBoxColumn.DataPropertyName = "end_point";
            this.endpointDataGridViewTextBoxColumn.HeaderText = "end_point";
            this.endpointDataGridViewTextBoxColumn.Name = "endpointDataGridViewTextBoxColumn";
            // 
            // transportnumDataGridViewTextBoxColumn
            // 
            this.transportnumDataGridViewTextBoxColumn.DataPropertyName = "transport_num";
            this.transportnumDataGridViewTextBoxColumn.HeaderText = "transport_num";
            this.transportnumDataGridViewTextBoxColumn.Name = "transportnumDataGridViewTextBoxColumn";
            // 
            // clientstransportsBindingSource
            // 
            this.clientstransportsBindingSource.DataMember = "clients_transports";
            this.clientstransportsBindingSource.DataSource = this._25032023_safinDataSet2;
            // 
            // _25032023_safinDataSet2
            // 
            this._25032023_safinDataSet2.DataSetName = "_25032023_safinDataSet2";
            this._25032023_safinDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clients_transportsTableAdapter
            // 
            this.clients_transportsTableAdapter.ClearBeforeFill = true;
            // 
            // client_info_dgv
            // 
            this.client_info_dgv.AutoGenerateColumns = false;
            this.client_info_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.client_info_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.patronymicDataGridViewTextBoxColumn,
            this.phonenumberDataGridViewTextBoxColumn});
            this.client_info_dgv.DataSource = this.clientsBindingSource2;
            this.client_info_dgv.Location = new System.Drawing.Point(373, 151);
            this.client_info_dgv.Name = "client_info_dgv";
            this.client_info_dgv.Size = new System.Drawing.Size(356, 664);
            this.client_info_dgv.TabIndex = 13;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // patronymicDataGridViewTextBoxColumn
            // 
            this.patronymicDataGridViewTextBoxColumn.DataPropertyName = "patronymic";
            this.patronymicDataGridViewTextBoxColumn.HeaderText = "patronymic";
            this.patronymicDataGridViewTextBoxColumn.Name = "patronymicDataGridViewTextBoxColumn";
            // 
            // phonenumberDataGridViewTextBoxColumn
            // 
            this.phonenumberDataGridViewTextBoxColumn.DataPropertyName = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.HeaderText = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            // 
            // clientsBindingSource2
            // 
            this.clientsBindingSource2.DataMember = "clients";
            this.clientsBindingSource2.DataSource = this._25032023_safinDataSet5;
            // 
            // _25032023_safinDataSet5
            // 
            this._25032023_safinDataSet5.DataSetName = "_25032023_safinDataSet5";
            this._25032023_safinDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // _25032023_safinDataSet3
            // 
            this._25032023_safinDataSet3.DataSetName = "_25032023_safinDataSet3";
            this._25032023_safinDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "clients";
            this.clientsBindingSource.DataSource = this._25032023_safinDataSet3;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // _25032023_safinDataSet4
            // 
            this._25032023_safinDataSet4.DataSetName = "_25032023_safinDataSet4";
            this._25032023_safinDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsBindingSource1
            // 
            this.clientsBindingSource1.DataMember = "clients";
            this.clientsBindingSource1.DataSource = this._25032023_safinDataSet4;
            // 
            // clientsTableAdapter1
            // 
            this.clientsTableAdapter1.ClearBeforeFill = true;
            // 
            // clientsTableAdapter2
            // 
            this.clientsTableAdapter2.ClearBeforeFill = true;
            // 
            // newname_label
            // 
            this.newname_label.AutoSize = true;
            this.newname_label.Location = new System.Drawing.Point(805, 183);
            this.newname_label.Name = "newname_label";
            this.newname_label.Size = new System.Drawing.Size(99, 23);
            this.newname_label.TabIndex = 14;
            this.newname_label.Text = "Название нового ТС:";
            // 
            // newname_textBox
            // 
            this.newname_textBox.Location = new System.Drawing.Point(809, 209);
            this.newname_textBox.Name = "newname_textBox";
            this.newname_textBox.Size = new System.Drawing.Size(100, 30);
            this.newname_textBox.TabIndex = 15;
            // 
            // newcolor_textBox
            // 
            this.newcolor_textBox.Location = new System.Drawing.Point(809, 293);
            this.newcolor_textBox.Name = "newcolor_textBox";
            this.newcolor_textBox.Size = new System.Drawing.Size(100, 30);
            this.newcolor_textBox.TabIndex = 17;
            // 
            // newcolor_label
            // 
            this.newcolor_label.AutoSize = true;
            this.newcolor_label.Location = new System.Drawing.Point(805, 267);
            this.newcolor_label.Name = "newcolor_label";
            this.newcolor_label.Size = new System.Drawing.Size(80, 23);
            this.newcolor_label.TabIndex = 16;
            this.newcolor_label.Text = "Цвет нового ТС:";
            // 
            // newnumber_textBox
            // 
            this.newnumber_textBox.Location = new System.Drawing.Point(809, 375);
            this.newnumber_textBox.Name = "newnumber_textBox";
            this.newnumber_textBox.Size = new System.Drawing.Size(100, 30);
            this.newnumber_textBox.TabIndex = 19;
            // 
            // newnumber_label
            // 
            this.newnumber_label.AutoSize = true;
            this.newnumber_label.Location = new System.Drawing.Point(805, 349);
            this.newnumber_label.Name = "newnumber_label";
            this.newnumber_label.Size = new System.Drawing.Size(84, 23);
            this.newnumber_label.TabIndex = 18;
            this.newnumber_label.Text = "Номер нового ТС:";
            // 
            // Form_menager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 961);
            this.Controls.Add(this.newnumber_textBox);
            this.Controls.Add(this.do_button);
            this.Controls.Add(this.newnumber_label);
            this.Controls.Add(this.newcolor_textBox);
            this.Controls.Add(this.newcolor_label);
            this.Controls.Add(this.newname_textBox);
            this.Controls.Add(this.newname_label);
            this.Controls.Add(this.client_info_dgv);
            this.Controls.Add(this.info_dgv);
            this.Controls.Add(this.Panel_top);
            this.Controls.Add(this.Panel_bot);
            this.Font = new System.Drawing.Font("Gabriola", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.Name = "Form_menager";
            this.Text = "Форма менеджера";
            this.Load += new System.EventHandler(this.Form_menager_Load);
            this.Panel_top.ResumeLayout(false);
            this.Panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_comp)).EndInit();
            this.Panel_bot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.info_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientstransportsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._25032023_safinDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_info_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._25032023_safinDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._25032023_safinDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._25032023_safinDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel_top;
        private System.Windows.Forms.PictureBox picture_comp;
        private System.Windows.Forms.Label CompName_label;
        private System.Windows.Forms.Panel Panel_bot;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button do_button;
        private System.Windows.Forms.DataGridView info_dgv;
        private _25032023_safinDataSet2 _25032023_safinDataSet2;
        private System.Windows.Forms.BindingSource clientstransportsBindingSource;
        private _25032023_safinDataSet2TableAdapters.clients_transportsTableAdapter clients_transportsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datebeginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beginpointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endpointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView client_info_dgv;
        private _25032023_safinDataSet3 _25032023_safinDataSet3;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private _25032023_safinDataSet3TableAdapters.clientsTableAdapter clientsTableAdapter;
        private _25032023_safinDataSet4 _25032023_safinDataSet4;
        private System.Windows.Forms.BindingSource clientsBindingSource1;
        private _25032023_safinDataSet4TableAdapters.clientsTableAdapter clientsTableAdapter1;
        private _25032023_safinDataSet5 _25032023_safinDataSet5;
        private System.Windows.Forms.BindingSource clientsBindingSource2;
        private _25032023_safinDataSet5TableAdapters.clientsTableAdapter clientsTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label newname_label;
        private System.Windows.Forms.TextBox newname_textBox;
        private System.Windows.Forms.TextBox newcolor_textBox;
        private System.Windows.Forms.Label newcolor_label;
        private System.Windows.Forms.TextBox newnumber_textBox;
        private System.Windows.Forms.Label newnumber_label;
    }
}