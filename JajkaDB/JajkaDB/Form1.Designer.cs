namespace JajkaDB
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageZniesione = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNotka = new System.Windows.Forms.TextBox();
            this.textBoxIlosc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonUsun = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPageDokupione = new System.Windows.Forms.TabPage();
            this.tabPageTransakcje = new System.Windows.Forms.TabPage();
            this.databaseDataSet = new JajkaDB.DatabaseDataSet();
            this.databaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zniesioneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zniesioneTableAdapter = new JajkaDB.DatabaseDataSetTableAdapters.ZniesioneTableAdapter();
            this.tabPageStatystyka = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDokupioneNotka = new System.Windows.Forms.TextBox();
            this.textBoxDokupioneIlosc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerDokupione = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.dokupioneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dokupioneTableAdapter = new JajkaDB.DatabaseDataSetTableAdapters.DokupioneTableAdapter();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iloscDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groszeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notkaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iloscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPageZniesione.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPageDokupione.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zniesioneBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dokupioneBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageZniesione);
            this.tabControl1.Controls.Add(this.tabPageDokupione);
            this.tabControl1.Controls.Add(this.tabPageTransakcje);
            this.tabControl1.Controls.Add(this.tabPageStatystyka);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(584, 361);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageZniesione
            // 
            this.tabPageZniesione.Controls.Add(this.groupBox2);
            this.tabPageZniesione.Controls.Add(this.groupBox1);
            this.tabPageZniesione.Location = new System.Drawing.Point(4, 22);
            this.tabPageZniesione.Name = "tabPageZniesione";
            this.tabPageZniesione.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageZniesione.Size = new System.Drawing.Size(576, 335);
            this.tabPageZniesione.TabIndex = 0;
            this.tabPageZniesione.Text = "Zniesione jajka";
            this.tabPageZniesione.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxNotka);
            this.groupBox2.Controls.Add(this.textBoxIlosc);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(6, 269);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(562, 58);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dodawanie jajek";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Notka";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxNotka
            // 
            this.textBoxNotka.Location = new System.Drawing.Point(113, 33);
            this.textBoxNotka.Name = "textBoxNotka";
            this.textBoxNotka.Size = new System.Drawing.Size(203, 20);
            this.textBoxNotka.TabIndex = 7;
            // 
            // textBoxIlosc
            // 
            this.textBoxIlosc.Location = new System.Drawing.Point(7, 33);
            this.textBoxIlosc.Name = "textBoxIlosc";
            this.textBoxIlosc.Size = new System.Drawing.Size(100, 20);
            this.textBoxIlosc.TabIndex = 6;
            this.textBoxIlosc.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ilość";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(322, 33);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(153, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(481, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonUsun);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 257);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zniesione Historia";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonUsun
            // 
            this.buttonUsun.Location = new System.Drawing.Point(452, 224);
            this.buttonUsun.Name = "buttonUsun";
            this.buttonUsun.Size = new System.Drawing.Size(104, 23);
            this.buttonUsun.TabIndex = 1;
            this.buttonUsun.Text = "Usuń";
            this.buttonUsun.UseVisualStyleBackColor = true;
            this.buttonUsun.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.iloscDataGridViewTextBoxColumn,
            this.notkaDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zniesioneBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridView1.Size = new System.Drawing.Size(443, 238);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPageDokupione
            // 
            this.tabPageDokupione.Controls.Add(this.groupBox4);
            this.tabPageDokupione.Controls.Add(this.groupBox3);
            this.tabPageDokupione.Location = new System.Drawing.Point(4, 22);
            this.tabPageDokupione.Name = "tabPageDokupione";
            this.tabPageDokupione.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDokupione.Size = new System.Drawing.Size(576, 335);
            this.tabPageDokupione.TabIndex = 1;
            this.tabPageDokupione.Text = "Dokupione jajka";
            this.tabPageDokupione.UseVisualStyleBackColor = true;
            // 
            // tabPageTransakcje
            // 
            this.tabPageTransakcje.Location = new System.Drawing.Point(4, 22);
            this.tabPageTransakcje.Name = "tabPageTransakcje";
            this.tabPageTransakcje.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTransakcje.Size = new System.Drawing.Size(576, 335);
            this.tabPageTransakcje.TabIndex = 2;
            this.tabPageTransakcje.Text = "Sprzedaż";
            this.tabPageTransakcje.UseVisualStyleBackColor = true;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // databaseDataSetBindingSource
            // 
            this.databaseDataSetBindingSource.DataSource = this.databaseDataSet;
            this.databaseDataSetBindingSource.Position = 0;
            // 
            // zniesioneBindingSource
            // 
            this.zniesioneBindingSource.DataMember = "Zniesione";
            this.zniesioneBindingSource.DataSource = this.databaseDataSetBindingSource;
            // 
            // zniesioneTableAdapter
            // 
            this.zniesioneTableAdapter.ClearBeforeFill = true;
            // 
            // tabPageStatystyka
            // 
            this.tabPageStatystyka.Location = new System.Drawing.Point(4, 22);
            this.tabPageStatystyka.Name = "tabPageStatystyka";
            this.tabPageStatystyka.Size = new System.Drawing.Size(576, 335);
            this.tabPageStatystyka.TabIndex = 3;
            this.tabPageStatystyka.Text = "Statystyka";
            this.tabPageStatystyka.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(562, 257);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dodane Historia";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(452, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Usuń";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView2
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.iloscDataGridViewTextBoxColumn1,
            this.groszeDataGridViewTextBoxColumn,
            this.notkaDataGridViewTextBoxColumn1,
            this.dataDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.dokupioneBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView2.Location = new System.Drawing.Point(3, 16);
            this.dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridView2.Size = new System.Drawing.Size(443, 238);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.textBoxDokupioneNotka);
            this.groupBox4.Controls.Add(this.textBoxDokupioneIlosc);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.dateTimePickerDokupione);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Location = new System.Drawing.Point(6, 269);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(562, 58);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dodawanie jajek";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Notka";
            // 
            // textBoxDokupioneNotka
            // 
            this.textBoxDokupioneNotka.Location = new System.Drawing.Point(113, 33);
            this.textBoxDokupioneNotka.Name = "textBoxDokupioneNotka";
            this.textBoxDokupioneNotka.Size = new System.Drawing.Size(203, 20);
            this.textBoxDokupioneNotka.TabIndex = 7;
            // 
            // textBoxDokupioneIlosc
            // 
            this.textBoxDokupioneIlosc.Location = new System.Drawing.Point(7, 33);
            this.textBoxDokupioneIlosc.Name = "textBoxDokupioneIlosc";
            this.textBoxDokupioneIlosc.Size = new System.Drawing.Size(100, 20);
            this.textBoxDokupioneIlosc.TabIndex = 6;
            this.textBoxDokupioneIlosc.WordWrap = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ilość";
            // 
            // dateTimePickerDokupione
            // 
            this.dateTimePickerDokupione.Location = new System.Drawing.Point(322, 33);
            this.dateTimePickerDokupione.Name = "dateTimePickerDokupione";
            this.dateTimePickerDokupione.Size = new System.Drawing.Size(153, 20);
            this.dateTimePickerDokupione.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(481, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Dodaj";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dokupioneBindingSource
            // 
            this.dokupioneBindingSource.DataMember = "Dokupione";
            this.dokupioneBindingSource.DataSource = this.databaseDataSetBindingSource;
            // 
            // dokupioneTableAdapter
            // 
            this.dokupioneTableAdapter.ClearBeforeFill = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // iloscDataGridViewTextBoxColumn1
            // 
            this.iloscDataGridViewTextBoxColumn1.DataPropertyName = "Ilosc";
            this.iloscDataGridViewTextBoxColumn1.HeaderText = "Ilosc";
            this.iloscDataGridViewTextBoxColumn1.Name = "iloscDataGridViewTextBoxColumn1";
            // 
            // groszeDataGridViewTextBoxColumn
            // 
            this.groszeDataGridViewTextBoxColumn.DataPropertyName = "Grosze";
            this.groszeDataGridViewTextBoxColumn.HeaderText = "Grosze";
            this.groszeDataGridViewTextBoxColumn.Name = "groszeDataGridViewTextBoxColumn";
            // 
            // notkaDataGridViewTextBoxColumn1
            // 
            this.notkaDataGridViewTextBoxColumn1.DataPropertyName = "Notka";
            this.notkaDataGridViewTextBoxColumn1.HeaderText = "Notka";
            this.notkaDataGridViewTextBoxColumn1.Name = "notkaDataGridViewTextBoxColumn1";
            // 
            // dataDataGridViewTextBoxColumn1
            // 
            this.dataDataGridViewTextBoxColumn1.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn1.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn1.Name = "dataDataGridViewTextBoxColumn1";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // iloscDataGridViewTextBoxColumn
            // 
            this.iloscDataGridViewTextBoxColumn.DataPropertyName = "Ilosc";
            this.iloscDataGridViewTextBoxColumn.HeaderText = "Ilosc";
            this.iloscDataGridViewTextBoxColumn.Name = "iloscDataGridViewTextBoxColumn";
            // 
            // notkaDataGridViewTextBoxColumn
            // 
            this.notkaDataGridViewTextBoxColumn.DataPropertyName = "Notka";
            this.notkaDataGridViewTextBoxColumn.HeaderText = "Notka";
            this.notkaDataGridViewTextBoxColumn.Name = "notkaDataGridViewTextBoxColumn";
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "MainForm";
            this.Text = "JajkaDB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageZniesione.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPageDokupione.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zniesioneBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dokupioneBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageZniesione;
        private System.Windows.Forms.TabPage tabPageDokupione;
        private System.Windows.Forms.TabPage tabPageTransakcje;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonUsun;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNotka;
        private System.Windows.Forms.TextBox textBoxIlosc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource databaseDataSetBindingSource;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource zniesioneBindingSource;
        private DatabaseDataSetTableAdapters.ZniesioneTableAdapter zniesioneTableAdapter;
        private System.Windows.Forms.TabPage tabPageStatystyka;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDokupioneNotka;
        private System.Windows.Forms.TextBox textBoxDokupioneIlosc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerDokupione;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource dokupioneBindingSource;
        private DatabaseDataSetTableAdapters.DokupioneTableAdapter dokupioneTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn iloscDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn groszeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notkaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iloscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
    }
}

