namespace Enrole
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usermobilenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useremailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userdateofreceiptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usergroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userspecialtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userpassportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_passport_division_сode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userpassportplaceofbirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userpassportplaceofissueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userpassportdateofissueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userDataSet = new Enrole.dbDataSet2();
            this.save_btn_header = new System.Windows.Forms.Button();
            this.add_header = new System.Windows.Forms.Button();
            this.menuStrip_header = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit_app = new System.Windows.Forms.Button();
            this.search_header = new System.Windows.Forms.Button();
            this.data_panel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.records = new System.Windows.Forms.Label();
            this.records_info = new System.Windows.Forms.Label();
            this.usersTableAdapter = new Enrole.dbDataSet2TableAdapters.usersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataSet)).BeginInit();
            this.menuStrip_header.SuspendLayout();
            this.panel1.SuspendLayout();
            this.data_panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.useridDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.usersexDataGridViewTextBoxColumn,
            this.usermobilenumberDataGridViewTextBoxColumn,
            this.useremailDataGridViewTextBoxColumn,
            this.userdateofreceiptDataGridViewTextBoxColumn,
            this.usergroupDataGridViewTextBoxColumn,
            this.userspecialtyDataGridViewTextBoxColumn,
            this.userpassportDataGridViewTextBoxColumn,
            this.user_passport_division_сode,
            this.userpassportplaceofbirthDataGridViewTextBoxColumn,
            this.userpassportplaceofissueDataGridViewTextBoxColumn,
            this.userpassportdateofissueDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usersBindingSource;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1284, 324);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.VirtualMode = true;
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.delete_row);
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "user_id";
            this.useridDataGridViewTextBoxColumn.FillWeight = 79.18782F;
            this.useridDataGridViewTextBoxColumn.HeaderText = "ID";
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "user_name";
            this.usernameDataGridViewTextBoxColumn.FillWeight = 101.7343F;
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // usersexDataGridViewTextBoxColumn
            // 
            this.usersexDataGridViewTextBoxColumn.DataPropertyName = "user_sex";
            this.usersexDataGridViewTextBoxColumn.FillWeight = 101.7343F;
            this.usersexDataGridViewTextBoxColumn.HeaderText = "Пол";
            this.usersexDataGridViewTextBoxColumn.Name = "usersexDataGridViewTextBoxColumn";
            // 
            // usermobilenumberDataGridViewTextBoxColumn
            // 
            this.usermobilenumberDataGridViewTextBoxColumn.DataPropertyName = "user_mobilenumber";
            this.usermobilenumberDataGridViewTextBoxColumn.FillWeight = 101.7343F;
            this.usermobilenumberDataGridViewTextBoxColumn.HeaderText = "Мобильный телефон";
            this.usermobilenumberDataGridViewTextBoxColumn.Name = "usermobilenumberDataGridViewTextBoxColumn";
            // 
            // useremailDataGridViewTextBoxColumn
            // 
            this.useremailDataGridViewTextBoxColumn.DataPropertyName = "user_email";
            this.useremailDataGridViewTextBoxColumn.FillWeight = 101.7343F;
            this.useremailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.useremailDataGridViewTextBoxColumn.Name = "useremailDataGridViewTextBoxColumn";
            // 
            // userdateofreceiptDataGridViewTextBoxColumn
            // 
            this.userdateofreceiptDataGridViewTextBoxColumn.DataPropertyName = "user_dateofreceipt";
            this.userdateofreceiptDataGridViewTextBoxColumn.FillWeight = 101.7343F;
            this.userdateofreceiptDataGridViewTextBoxColumn.HeaderText = "Дата поступления";
            this.userdateofreceiptDataGridViewTextBoxColumn.Name = "userdateofreceiptDataGridViewTextBoxColumn";
            // 
            // usergroupDataGridViewTextBoxColumn
            // 
            this.usergroupDataGridViewTextBoxColumn.DataPropertyName = "user_group";
            this.usergroupDataGridViewTextBoxColumn.FillWeight = 101.7343F;
            this.usergroupDataGridViewTextBoxColumn.HeaderText = "Группа";
            this.usergroupDataGridViewTextBoxColumn.Name = "usergroupDataGridViewTextBoxColumn";
            // 
            // userspecialtyDataGridViewTextBoxColumn
            // 
            this.userspecialtyDataGridViewTextBoxColumn.DataPropertyName = "user_specialty";
            this.userspecialtyDataGridViewTextBoxColumn.FillWeight = 101.7343F;
            this.userspecialtyDataGridViewTextBoxColumn.HeaderText = "Специальность";
            this.userspecialtyDataGridViewTextBoxColumn.Name = "userspecialtyDataGridViewTextBoxColumn";
            // 
            // userpassportDataGridViewTextBoxColumn
            // 
            this.userpassportDataGridViewTextBoxColumn.DataPropertyName = "user_passport";
            this.userpassportDataGridViewTextBoxColumn.FillWeight = 101.7343F;
            this.userpassportDataGridViewTextBoxColumn.HeaderText = "Номер и серия паспорта";
            this.userpassportDataGridViewTextBoxColumn.Name = "userpassportDataGridViewTextBoxColumn";
            // 
            // user_passport_division_сode
            // 
            this.user_passport_division_сode.DataPropertyName = "user_passport_division_сode";
            this.user_passport_division_сode.HeaderText = "Код подразделения";
            this.user_passport_division_сode.Name = "user_passport_division_сode";
            // 
            // userpassportplaceofbirthDataGridViewTextBoxColumn
            // 
            this.userpassportplaceofbirthDataGridViewTextBoxColumn.DataPropertyName = "user_passport_placeofbirth";
            this.userpassportplaceofbirthDataGridViewTextBoxColumn.FillWeight = 101.7343F;
            this.userpassportplaceofbirthDataGridViewTextBoxColumn.HeaderText = "Город по прописке";
            this.userpassportplaceofbirthDataGridViewTextBoxColumn.Name = "userpassportplaceofbirthDataGridViewTextBoxColumn";
            // 
            // userpassportplaceofissueDataGridViewTextBoxColumn
            // 
            this.userpassportplaceofissueDataGridViewTextBoxColumn.DataPropertyName = "user_passport_placeofissue";
            this.userpassportplaceofissueDataGridViewTextBoxColumn.FillWeight = 101.7343F;
            this.userpassportplaceofissueDataGridViewTextBoxColumn.HeaderText = "Место выдачи";
            this.userpassportplaceofissueDataGridViewTextBoxColumn.Name = "userpassportplaceofissueDataGridViewTextBoxColumn";
            // 
            // userpassportdateofissueDataGridViewTextBoxColumn
            // 
            this.userpassportdateofissueDataGridViewTextBoxColumn.DataPropertyName = "user_passport_dateofissue";
            this.userpassportdateofissueDataGridViewTextBoxColumn.FillWeight = 101.7343F;
            this.userpassportdateofissueDataGridViewTextBoxColumn.HeaderText = "Дата выдачи";
            this.userpassportdateofissueDataGridViewTextBoxColumn.Name = "userpassportdateofissueDataGridViewTextBoxColumn";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.userDataSet;
            // 
            // userDataSet
            // 
            this.userDataSet.DataSetName = "userDataSet";
            this.userDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // save_btn_header
            // 
            this.save_btn_header.AutoSize = true;
            this.save_btn_header.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.save_btn_header.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.save_btn_header.Dock = System.Windows.Forms.DockStyle.Left;
            this.save_btn_header.FlatAppearance.BorderSize = 0;
            this.save_btn_header.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_btn_header.Image = ((System.Drawing.Image)(resources.GetObject("save_btn_header.Image")));
            this.save_btn_header.Location = new System.Drawing.Point(40, 0);
            this.save_btn_header.Name = "save_btn_header";
            this.save_btn_header.Padding = new System.Windows.Forms.Padding(5);
            this.save_btn_header.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.save_btn_header.Size = new System.Drawing.Size(40, 44);
            this.save_btn_header.TabIndex = 2;
            this.save_btn_header.UseVisualStyleBackColor = false;
            this.save_btn_header.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // add_header
            // 
            this.add_header.AccessibleDescription = "Добавить запись";
            this.add_header.AutoSize = true;
            this.add_header.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.add_header.BackColor = System.Drawing.SystemColors.HighlightText;
            this.add_header.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add_header.BackgroundImage")));
            this.add_header.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.add_header.Dock = System.Windows.Forms.DockStyle.Left;
            this.add_header.FlatAppearance.BorderSize = 0;
            this.add_header.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_header.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.add_header.Image = ((System.Drawing.Image)(resources.GetObject("add_header.Image")));
            this.add_header.Location = new System.Drawing.Point(0, 0);
            this.add_header.Name = "add_header";
            this.add_header.Padding = new System.Windows.Forms.Padding(5);
            this.add_header.Size = new System.Drawing.Size(40, 44);
            this.add_header.TabIndex = 1;
            this.add_header.UseVisualStyleBackColor = false;
            this.add_header.Click += new System.EventHandler(this.add);
            // 
            // menuStrip_header
            // 
            this.menuStrip_header.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip_header.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip_header.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_header.Name = "menuStrip_header";
            this.menuStrip_header.Size = new System.Drawing.Size(1284, 24);
            this.menuStrip_header.TabIndex = 4;
            this.menuStrip_header.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.About_Info);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.exit_app);
            this.panel1.Controls.Add(this.search_header);
            this.panel1.Controls.Add(this.save_btn_header);
            this.panel1.Controls.Add(this.add_header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(1284, 44);
            this.panel1.TabIndex = 5;
            // 
            // exit_app
            // 
            this.exit_app.AutoSize = true;
            this.exit_app.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exit_app.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exit_app.Dock = System.Windows.Forms.DockStyle.Right;
            this.exit_app.FlatAppearance.BorderSize = 0;
            this.exit_app.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_app.Image = ((System.Drawing.Image)(resources.GetObject("exit_app.Image")));
            this.exit_app.Location = new System.Drawing.Point(1244, 0);
            this.exit_app.Name = "exit_app";
            this.exit_app.Padding = new System.Windows.Forms.Padding(5);
            this.exit_app.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.exit_app.Size = new System.Drawing.Size(40, 44);
            this.exit_app.TabIndex = 4;
            this.exit_app.UseVisualStyleBackColor = false;
            this.exit_app.Click += new System.EventHandler(this.exit_form);
            // 
            // search_header
            // 
            this.search_header.AutoSize = true;
            this.search_header.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.search_header.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.search_header.Dock = System.Windows.Forms.DockStyle.Left;
            this.search_header.FlatAppearance.BorderSize = 0;
            this.search_header.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_header.Image = ((System.Drawing.Image)(resources.GetObject("search_header.Image")));
            this.search_header.Location = new System.Drawing.Point(80, 0);
            this.search_header.Name = "search_header";
            this.search_header.Padding = new System.Windows.Forms.Padding(5);
            this.search_header.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.search_header.Size = new System.Drawing.Size(40, 44);
            this.search_header.TabIndex = 3;
            this.search_header.UseVisualStyleBackColor = false;
            this.search_header.Click += new System.EventHandler(this.search);
            // 
            // data_panel
            // 
            this.data_panel.AutoSize = true;
            this.data_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.data_panel.Controls.Add(this.flowLayoutPanel1);
            this.data_panel.Controls.Add(this.dataGridView1);
            this.data_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_panel.Location = new System.Drawing.Point(0, 68);
            this.data_panel.Name = "data_panel";
            this.data_panel.Size = new System.Drawing.Size(1284, 324);
            this.data_panel.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.Controls.Add(this.records);
            this.flowLayoutPanel1.Controls.Add(this.records_info);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 292);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1284, 32);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // records
            // 
            this.records.AutoSize = true;
            this.records.Dock = System.Windows.Forms.DockStyle.Left;
            this.records.Location = new System.Drawing.Point(8, 5);
            this.records.Margin = new System.Windows.Forms.Padding(3, 0, 1, 0);
            this.records.Name = "records";
            this.records.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.records.Size = new System.Drawing.Size(23, 23);
            this.records.TabIndex = 0;
            this.records.Text = "0";
            // 
            // records_info
            // 
            this.records_info.AutoSize = true;
            this.records_info.Dock = System.Windows.Forms.DockStyle.Left;
            this.records_info.Location = new System.Drawing.Point(32, 5);
            this.records_info.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.records_info.Name = "records_info";
            this.records_info.Padding = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.records_info.Size = new System.Drawing.Size(54, 23);
            this.records_info.TabIndex = 1;
            this.records_info.Text = "записей";
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1284, 392);
            this.Controls.Add(this.data_panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip_header;
            this.MinimumSize = new System.Drawing.Size(731, 431);
            this.Name = "Form1";
            this.Text = "База данных";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataSet)).EndInit();
            this.menuStrip_header.ResumeLayout(false);
            this.menuStrip_header.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.data_panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button save_btn_header;
        private System.Windows.Forms.Button add_header;
        private System.Windows.Forms.MenuStrip menuStrip_header;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button search_header;
        private System.Windows.Forms.Panel data_panel;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Button exit_app;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label records;
        private System.Windows.Forms.Label records_info;
        public dbDataSet2 userDataSet;
        public System.Windows.Forms.BindingSource usersBindingSource;
        public dbDataSet2TableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usersexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usermobilenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn useremailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userdateofreceiptDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usergroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userspecialtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userpassportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_passport_division_сode;
        private System.Windows.Forms.DataGridViewTextBoxColumn userpassportplaceofbirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userpassportplaceofissueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userpassportdateofissueDataGridViewTextBoxColumn;
    }
}

