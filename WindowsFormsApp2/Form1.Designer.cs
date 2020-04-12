namespace WindowsFormsApp2
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
            this.search_results = new System.Windows.Forms.DataGridView();
            this.TuiTour = new System.Windows.Forms.DataGridView();
            this.Code_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Night_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiuDataSet2 = new WindowsFormsApp2.TiuDataSet2();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nght = new System.Windows.Forms.Label();
            this.nm = new System.Windows.Forms.Label();
            this.dt = new System.Windows.Forms.Label();
            this.cntr = new System.Windows.Forms.Label();
            this.ctdpt = new System.Windows.Forms.Label();
            this.Night = new System.Windows.Forms.TextBox();
            this.prc = new System.Windows.Forms.Label();
            this.change = new System.Windows.Forms.Button();
            this.Name = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.TextBox();
            this.Country = new System.Windows.Forms.TextBox();
            this.City_dpt = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.save_change = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.srch = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.Search_bt = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.TextBox();
            this.toursTableAdapter = new WindowsFormsApp2.TiuDataSet2TableAdapters.ToursTableAdapter();
            this.save = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.search_results)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TuiTour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toursBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiuDataSet2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // search_results
            // 
            this.search_results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.search_results.Location = new System.Drawing.Point(13, 138);
            this.search_results.Margin = new System.Windows.Forms.Padding(4);
            this.search_results.Name = "search_results";
            this.search_results.Size = new System.Drawing.Size(1056, 286);
            this.search_results.TabIndex = 1;
            this.search_results.SelectionChanged += new System.EventHandler(this.search_results_SelectionChanged);
            // 
            // TuiTour
            // 
            this.TuiTour.AllowUserToAddRows = false;
            this.TuiTour.AutoGenerateColumns = false;
            this.TuiTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TuiTour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code_1,
            this.City_1,
            this.Country_1,
            this.Name_1,
            this.Price_1,
            this.Date_1,
            this.Night_1});
            this.TuiTour.DataSource = this.toursBindingSource;
            this.TuiTour.Location = new System.Drawing.Point(13, 138);
            this.TuiTour.Margin = new System.Windows.Forms.Padding(4);
            this.TuiTour.Name = "TuiTour";
            this.TuiTour.Size = new System.Drawing.Size(1056, 286);
            this.TuiTour.TabIndex = 2;
            this.TuiTour.SelectionChanged += new System.EventHandler(this.TuiTour_SelectionChanged);
            // 
            // Code_1
            // 
            this.Code_1.DataPropertyName = "Код тура";
            this.Code_1.HeaderText = "Код тура";
            this.Code_1.Name = "Code_1";
            // 
            // City_1
            // 
            this.City_1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.City_1.DataPropertyName = "Город  отправления";
            this.City_1.HeaderText = "Город  отправления";
            this.City_1.Name = "City_1";
            this.City_1.Width = 156;
            // 
            // Country_1
            // 
            this.Country_1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Country_1.DataPropertyName = "Страна назначения";
            this.Country_1.HeaderText = "Страна назначения";
            this.Country_1.Name = "Country_1";
            this.Country_1.Width = 154;
            // 
            // Name_1
            // 
            this.Name_1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Name_1.DataPropertyName = "Название тура";
            this.Name_1.HeaderText = "Название тура";
            this.Name_1.Name = "Name_1";
            this.Name_1.Width = 124;
            // 
            // Price_1
            // 
            this.Price_1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Price_1.DataPropertyName = "Стоимость";
            this.Price_1.HeaderText = "Стоимость";
            this.Price_1.Name = "Price_1";
            this.Price_1.Width = 107;
            // 
            // Date_1
            // 
            this.Date_1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Date_1.DataPropertyName = "Дата вылета";
            this.Date_1.HeaderText = "Дата вылета";
            this.Date_1.Name = "Date_1";
            this.Date_1.Width = 113;
            // 
            // Night_1
            // 
            this.Night_1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Night_1.DataPropertyName = "Количество ночей";
            this.Night_1.HeaderText = "Количество ночей";
            this.Night_1.Name = "Night_1";
            this.Night_1.Width = 145;
            // 
            // toursBindingSource
            // 
            this.toursBindingSource.DataMember = "Tours";
            this.toursBindingSource.DataSource = this.tiuDataSet2;
            // 
            // tiuDataSet2
            // 
            this.tiuDataSet2.DataSetName = "TiuDataSet2";
            this.tiuDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nght);
            this.groupBox1.Controls.Add(this.nm);
            this.groupBox1.Controls.Add(this.dt);
            this.groupBox1.Controls.Add(this.cntr);
            this.groupBox1.Controls.Add(this.ctdpt);
            this.groupBox1.Controls.Add(this.Night);
            this.groupBox1.Controls.Add(this.prc);
            this.groupBox1.Controls.Add(this.change);
            this.groupBox1.Controls.Add(this.Name);
            this.groupBox1.Controls.Add(this.Date);
            this.groupBox1.Controls.Add(this.Country);
            this.groupBox1.Controls.Add(this.City_dpt);
            this.groupBox1.Controls.Add(this.Price);
            this.groupBox1.Location = new System.Drawing.Point(13, 446);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(410, 221);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация о туре";
            // 
            // nght
            // 
            this.nght.AutoSize = true;
            this.nght.Location = new System.Drawing.Point(223, 117);
            this.nght.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nght.Name = "nght";
            this.nght.Size = new System.Drawing.Size(130, 17);
            this.nght.TabIndex = 11;
            this.nght.Text = "Количество ночей";
            // 
            // nm
            // 
            this.nm.AutoSize = true;
            this.nm.Location = new System.Drawing.Point(149, 26);
            this.nm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nm.Name = "nm";
            this.nm.Size = new System.Drawing.Size(106, 17);
            this.nm.TabIndex = 10;
            this.nm.Text = "Название тура";
            // 
            // dt
            // 
            this.dt.AutoSize = true;
            this.dt.Location = new System.Drawing.Point(223, 73);
            this.dt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(94, 17);
            this.dt.TabIndex = 9;
            this.dt.Text = "Дата вылета";
            // 
            // cntr
            // 
            this.cntr.AutoSize = true;
            this.cntr.Location = new System.Drawing.Point(5, 117);
            this.cntr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cntr.Name = "cntr";
            this.cntr.Size = new System.Drawing.Size(139, 17);
            this.cntr.TabIndex = 8;
            this.cntr.Text = "Страна назначения";
            // 
            // ctdpt
            // 
            this.ctdpt.AutoSize = true;
            this.ctdpt.Location = new System.Drawing.Point(8, 73);
            this.ctdpt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ctdpt.Name = "ctdpt";
            this.ctdpt.Size = new System.Drawing.Size(138, 17);
            this.ctdpt.TabIndex = 6;
            this.ctdpt.Text = "Город отправления";
            // 
            // Night
            // 
            this.Night.Location = new System.Drawing.Point(223, 138);
            this.Night.Margin = new System.Windows.Forms.Padding(4);
            this.Night.Name = "Night";
            this.Night.Size = new System.Drawing.Size(176, 22);
            this.Night.TabIndex = 5;
            // 
            // prc
            // 
            this.prc.AutoSize = true;
            this.prc.Location = new System.Drawing.Point(8, 163);
            this.prc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prc.Name = "prc";
            this.prc.Size = new System.Drawing.Size(78, 17);
            this.prc.TabIndex = 7;
            this.prc.Text = "Стоимость";
            // 
            // change
            // 
            this.change.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.change.Cursor = System.Windows.Forms.Cursors.Hand;
            this.change.Location = new System.Drawing.Point(223, 168);
            this.change.Margin = new System.Windows.Forms.Padding(4);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(176, 36);
            this.change.TabIndex = 4;
            this.change.Text = "Редактировать";
            this.change.UseVisualStyleBackColor = false;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(8, 47);
            this.Name.Margin = new System.Windows.Forms.Padding(4);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(391, 22);
            this.Name.TabIndex = 4;
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(223, 91);
            this.Date.Margin = new System.Windows.Forms.Padding(4);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(176, 22);
            this.Date.TabIndex = 3;
            // 
            // Country
            // 
            this.Country.Location = new System.Drawing.Point(8, 137);
            this.Country.Margin = new System.Windows.Forms.Padding(4);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(176, 22);
            this.Country.TabIndex = 2;
            // 
            // City_dpt
            // 
            this.City_dpt.Location = new System.Drawing.Point(8, 91);
            this.City_dpt.Margin = new System.Windows.Forms.Padding(4);
            this.City_dpt.Name = "City_dpt";
            this.City_dpt.Size = new System.Drawing.Size(176, 22);
            this.City_dpt.TabIndex = 0;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(11, 182);
            this.Price.Margin = new System.Windows.Forms.Padding(4);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(176, 22);
            this.Price.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(435, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 33);
            this.button1.TabIndex = 12;
            this.button1.Text = "Снять выделение";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // save_change
            // 
            this.save_change.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.save_change.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_change.Location = new System.Drawing.Point(431, 563);
            this.save_change.Margin = new System.Windows.Forms.Padding(4);
            this.save_change.Name = "save_change";
            this.save_change.Size = new System.Drawing.Size(179, 51);
            this.save_change.TabIndex = 5;
            this.save_change.Text = "Сохранить изменения";
            this.save_change.UseVisualStyleBackColor = false;
            this.save_change.Click += new System.EventHandler(this.save_change_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel.Location = new System.Drawing.Point(431, 622);
            this.cancel.Margin = new System.Windows.Forms.Padding(4);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(179, 28);
            this.cancel.TabIndex = 6;
            this.cancel.Text = "Отмена";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add.Location = new System.Drawing.Point(431, 501);
            this.add.Margin = new System.Windows.Forms.Padding(4);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(179, 53);
            this.add.TabIndex = 7;
            this.add.Text = "Добавить запись";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.Location = new System.Drawing.Point(618, 563);
            this.delete.Margin = new System.Windows.Forms.Padding(4);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(179, 87);
            this.delete.TabIndex = 9;
            this.delete.Text = "Удалить запись";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.srch);
            this.groupBox2.Controls.Add(this.reset);
            this.groupBox2.Controls.Add(this.Search_bt);
            this.groupBox2.Controls.Add(this.Search);
            this.groupBox2.Location = new System.Drawing.Point(805, 446);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(271, 221);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поиск";
            // 
            // srch
            // 
            this.srch.AutoSize = true;
            this.srch.Location = new System.Drawing.Point(38, 26);
            this.srch.Name = "srch";
            this.srch.Size = new System.Drawing.Size(195, 17);
            this.srch.TabIndex = 14;
            this.srch.Text = "Введите страну назначения";
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset.Location = new System.Drawing.Point(8, 176);
            this.reset.Margin = new System.Windows.Forms.Padding(4);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(256, 28);
            this.reset.TabIndex = 13;
            this.reset.Text = "Сбросить";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Search_bt
            // 
            this.Search_bt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Search_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search_bt.Location = new System.Drawing.Point(8, 143);
            this.Search_bt.Margin = new System.Windows.Forms.Padding(4);
            this.Search_bt.Name = "Search_bt";
            this.Search_bt.Size = new System.Drawing.Size(256, 28);
            this.Search_bt.TabIndex = 11;
            this.Search_bt.Text = "Найти";
            this.Search_bt.UseVisualStyleBackColor = false;
            this.Search_bt.Click += new System.EventHandler(this.Search_bt_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(8, 47);
            this.Search.Margin = new System.Windows.Forms.Padding(4);
            this.Search.Multiline = true;
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(256, 88);
            this.Search.TabIndex = 12;
            // 
            // toursTableAdapter
            // 
            this.toursTableAdapter.ClearBeforeFill = true;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save.Location = new System.Drawing.Point(618, 461);
            this.save.Margin = new System.Windows.Forms.Padding(4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(179, 94);
            this.save.TabIndex = 8;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources._321__1_;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1056, 117);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1089, 675);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.save);
            this.Controls.Add(this.add);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save_change);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TuiTour);
            this.Controls.Add(this.search_results);
            this.Margin = new System.Windows.Forms.Padding(4);
            //this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.search_results)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TuiTour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toursBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiuDataSet2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView search_results;
        private System.Windows.Forms.DataGridView TuiTour;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label nght;
        private System.Windows.Forms.Label nm;
        private System.Windows.Forms.Label dt;
        private System.Windows.Forms.Label cntr;
        private System.Windows.Forms.Label prc;
        private System.Windows.Forms.Label ctdpt;
        private System.Windows.Forms.TextBox Night;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Date;
        private System.Windows.Forms.TextBox Country;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox City_dpt;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Button save_change;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button Search_bt;
        private System.Windows.Forms.TextBox Search;
        private TiuDataSet2 tiuDataSet2;
        private System.Windows.Forms.BindingSource toursBindingSource;
        private TiuDataSet2TableAdapters.ToursTableAdapter toursTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn City_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Night_1;
        private System.Windows.Forms.Label srch;
    }
}

