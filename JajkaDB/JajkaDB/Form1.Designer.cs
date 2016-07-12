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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iloscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zniesioneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new JajkaDB.DatabaseDataSet();
            this.tabPageDokupione = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxDokupioneGroszy = new System.Windows.Forms.TextBox();
            this.textBoxDokupionezloty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDokupioneNotka = new System.Windows.Forms.TextBox();
            this.textBoxDokupioneIlosc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerDokupione = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dokupioneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageKlienci = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNazwiskoKlienci = new System.Windows.Forms.TextBox();
            this.textBoxImieKlienci = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridViewKlienci = new System.Windows.Forms.DataGridView();
            this.klienciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageTransakcje = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.comboBoxKlientTrans = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxGroszyTrans = new System.Windows.Forms.TextBox();
            this.textBoxZlotyTrans = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxNotkaTrans = new System.Windows.Forms.TextBox();
            this.textBoxIloscTrans = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePickerTrans = new System.Windows.Forms.DateTimePicker();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.dataGridViewTrans = new System.Windows.Forms.DataGridView();
            this.transakcjeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet1 = new JajkaDB.DatabaseDataSet();
            this.tabPageStatystyka = new System.Windows.Forms.TabPage();
            this.zniesioneTableAdapter = new JajkaDB.DatabaseDataSetTableAdapters.ZniesioneTableAdapter();
            this.dokupioneTableAdapter = new JajkaDB.DatabaseDataSetTableAdapters.DokupioneTableAdapter();
            this.klienciTableAdapter = new JajkaDB.DatabaseDataSetTableAdapters.KlienciTableAdapter();
            this.transakcjeTableAdapter = new JajkaDB.DatabaseDataSetTableAdapters.TransakcjeTableAdapter();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iloscDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groszeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notkaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jajkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groszeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pelneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notkaDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonUsunTrans = new System.Windows.Forms.Button();
            this.Grosze = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPageZniesione.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zniesioneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.tabPageDokupione.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokupioneBindingSource)).BeginInit();
            this.tabPageKlienci.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKlienci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klienciBindingSource)).BeginInit();
            this.tabPageTransakcje.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transakcjeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageZniesione);
            this.tabControl1.Controls.Add(this.tabPageDokupione);
            this.tabControl1.Controls.Add(this.tabPageKlienci);
            this.tabControl1.Controls.Add(this.tabPageTransakcje);
            this.tabControl1.Controls.Add(this.tabPageStatystyka);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(592, 411);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageZniesione
            // 
            this.tabPageZniesione.Controls.Add(this.groupBox2);
            this.tabPageZniesione.Controls.Add(this.groupBox1);
            this.tabPageZniesione.Location = new System.Drawing.Point(4, 22);
            this.tabPageZniesione.Name = "tabPageZniesione";
            this.tabPageZniesione.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageZniesione.Size = new System.Drawing.Size(584, 385);
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
            this.groupBox2.Location = new System.Drawing.Point(6, 319);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(570, 60);
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
            this.groupBox1.Size = new System.Drawing.Size(570, 307);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zniesione Historia";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonUsun
            // 
            this.buttonUsun.Location = new System.Drawing.Point(481, 278);
            this.buttonUsun.Name = "buttonUsun";
            this.buttonUsun.Size = new System.Drawing.Size(83, 23);
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
            this.dataGridView1.Size = new System.Drawing.Size(472, 288);
            this.dataGridView1.TabIndex = 0;
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
            // zniesioneBindingSource
            // 
            this.zniesioneBindingSource.DataMember = "Zniesione";
            this.zniesioneBindingSource.DataSource = this.databaseDataSetBindingSource;
            // 
            // databaseDataSetBindingSource
            // 
            this.databaseDataSetBindingSource.DataSource = this.databaseDataSet;
            this.databaseDataSetBindingSource.Position = 0;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPageDokupione
            // 
            this.tabPageDokupione.Controls.Add(this.groupBox4);
            this.tabPageDokupione.Controls.Add(this.groupBox3);
            this.tabPageDokupione.Location = new System.Drawing.Point(4, 22);
            this.tabPageDokupione.Name = "tabPageDokupione";
            this.tabPageDokupione.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDokupione.Size = new System.Drawing.Size(584, 385);
            this.tabPageDokupione.TabIndex = 1;
            this.tabPageDokupione.Text = "Dokupione jajka";
            this.tabPageDokupione.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.textBoxDokupioneGroszy);
            this.groupBox4.Controls.Add(this.textBoxDokupionezloty);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.textBoxDokupioneNotka);
            this.groupBox4.Controls.Add(this.textBoxDokupioneIlosc);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.dateTimePickerDokupione);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Location = new System.Drawing.Point(6, 319);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(570, 60);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dodawanie jajek";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(194, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "gr";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(142, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "zł";
            // 
            // textBoxDokupioneGroszy
            // 
            this.textBoxDokupioneGroszy.Location = new System.Drawing.Point(164, 33);
            this.textBoxDokupioneGroszy.Name = "textBoxDokupioneGroszy";
            this.textBoxDokupioneGroszy.Size = new System.Drawing.Size(29, 20);
            this.textBoxDokupioneGroszy.TabIndex = 10;
            // 
            // textBoxDokupionezloty
            // 
            this.textBoxDokupionezloty.Location = new System.Drawing.Point(113, 33);
            this.textBoxDokupionezloty.Name = "textBoxDokupionezloty";
            this.textBoxDokupionezloty.Size = new System.Drawing.Size(29, 20);
            this.textBoxDokupionezloty.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Notka";
            // 
            // textBoxDokupioneNotka
            // 
            this.textBoxDokupioneNotka.Location = new System.Drawing.Point(216, 33);
            this.textBoxDokupioneNotka.Name = "textBoxDokupioneNotka";
            this.textBoxDokupioneNotka.Size = new System.Drawing.Size(100, 20);
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
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(570, 307);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dodane Historia";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(481, 278);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 23);
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
            this.dataGridView2.Size = new System.Drawing.Size(472, 288);
            this.dataGridView2.TabIndex = 0;
            // 
            // dokupioneBindingSource
            // 
            this.dokupioneBindingSource.DataMember = "Dokupione";
            this.dokupioneBindingSource.DataSource = this.databaseDataSetBindingSource;
            // 
            // tabPageKlienci
            // 
            this.tabPageKlienci.Controls.Add(this.groupBox5);
            this.tabPageKlienci.Controls.Add(this.groupBox6);
            this.tabPageKlienci.Location = new System.Drawing.Point(4, 22);
            this.tabPageKlienci.Name = "tabPageKlienci";
            this.tabPageKlienci.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKlienci.Size = new System.Drawing.Size(584, 385);
            this.tabPageKlienci.TabIndex = 4;
            this.tabPageKlienci.Text = "Klienci";
            this.tabPageKlienci.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.textBoxNazwiskoKlienci);
            this.groupBox5.Controls.Add(this.textBoxImieKlienci);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.button4);
            this.groupBox5.Location = new System.Drawing.Point(6, 319);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(570, 60);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Dodawanie nowego klienta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nazwisko";
            // 
            // textBoxNazwiskoKlienci
            // 
            this.textBoxNazwiskoKlienci.Location = new System.Drawing.Point(113, 33);
            this.textBoxNazwiskoKlienci.Name = "textBoxNazwiskoKlienci";
            this.textBoxNazwiskoKlienci.Size = new System.Drawing.Size(100, 20);
            this.textBoxNazwiskoKlienci.TabIndex = 7;
            // 
            // textBoxImieKlienci
            // 
            this.textBoxImieKlienci.Location = new System.Drawing.Point(7, 33);
            this.textBoxImieKlienci.Name = "textBoxImieKlienci";
            this.textBoxImieKlienci.Size = new System.Drawing.Size(100, 20);
            this.textBoxImieKlienci.TabIndex = 6;
            this.textBoxImieKlienci.WordWrap = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Imię";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(481, 31);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Dodaj";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.button5);
            this.groupBox6.Controls.Add(this.dataGridViewKlienci);
            this.groupBox6.Location = new System.Drawing.Point(6, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(570, 307);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Klienci";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(481, 278);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(83, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "Usuń";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridViewKlienci
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewKlienci.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewKlienci.AutoGenerateColumns = false;
            this.dataGridViewKlienci.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewKlienci.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewKlienci.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridViewKlienci.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewKlienci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKlienci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.imieDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn});
            this.dataGridViewKlienci.DataSource = this.klienciBindingSource;
            this.dataGridViewKlienci.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewKlienci.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewKlienci.Name = "dataGridViewKlienci";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewKlienci.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewKlienci.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewKlienci.Size = new System.Drawing.Size(472, 288);
            this.dataGridViewKlienci.TabIndex = 0;
            // 
            // klienciBindingSource
            // 
            this.klienciBindingSource.DataMember = "Klienci";
            this.klienciBindingSource.DataSource = this.databaseDataSet;
            // 
            // tabPageTransakcje
            // 
            this.tabPageTransakcje.Controls.Add(this.groupBox7);
            this.tabPageTransakcje.Controls.Add(this.groupBox8);
            this.tabPageTransakcje.Location = new System.Drawing.Point(4, 22);
            this.tabPageTransakcje.Name = "tabPageTransakcje";
            this.tabPageTransakcje.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTransakcje.Size = new System.Drawing.Size(584, 385);
            this.tabPageTransakcje.TabIndex = 2;
            this.tabPageTransakcje.Text = "Sprzedaż";
            this.tabPageTransakcje.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.comboBoxKlientTrans);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.textBoxGroszyTrans);
            this.groupBox7.Controls.Add(this.textBoxZlotyTrans);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.textBoxNotkaTrans);
            this.groupBox7.Controls.Add(this.textBoxIloscTrans);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.dateTimePickerTrans);
            this.groupBox7.Controls.Add(this.button6);
            this.groupBox7.Location = new System.Drawing.Point(6, 314);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(570, 65);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Dodawanie Transakcji";
            // 
            // comboBoxKlientTrans
            // 
            this.comboBoxKlientTrans.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.klienciBindingSource, "Id", true));
            this.comboBoxKlientTrans.DataSource = this.klienciBindingSource;
            this.comboBoxKlientTrans.DisplayMember = "Pelne";
            this.comboBoxKlientTrans.FormattingEnabled = true;
            this.comboBoxKlientTrans.Location = new System.Drawing.Point(322, 38);
            this.comboBoxKlientTrans.Name = "comboBoxKlientTrans";
            this.comboBoxKlientTrans.Size = new System.Drawing.Size(153, 21);
            this.comboBoxKlientTrans.TabIndex = 11;
            this.comboBoxKlientTrans.ValueMember = "Id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(194, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "gr";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(142, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "zł";
            // 
            // textBoxGroszyTrans
            // 
            this.textBoxGroszyTrans.Location = new System.Drawing.Point(164, 33);
            this.textBoxGroszyTrans.Name = "textBoxGroszyTrans";
            this.textBoxGroszyTrans.Size = new System.Drawing.Size(29, 20);
            this.textBoxGroszyTrans.TabIndex = 8;
            // 
            // textBoxZlotyTrans
            // 
            this.textBoxZlotyTrans.Location = new System.Drawing.Point(113, 33);
            this.textBoxZlotyTrans.Name = "textBoxZlotyTrans";
            this.textBoxZlotyTrans.Size = new System.Drawing.Size(29, 20);
            this.textBoxZlotyTrans.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(213, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Notka";
            // 
            // textBoxNotkaTrans
            // 
            this.textBoxNotkaTrans.Location = new System.Drawing.Point(216, 33);
            this.textBoxNotkaTrans.Name = "textBoxNotkaTrans";
            this.textBoxNotkaTrans.Size = new System.Drawing.Size(100, 20);
            this.textBoxNotkaTrans.TabIndex = 9;
            // 
            // textBoxIloscTrans
            // 
            this.textBoxIloscTrans.Location = new System.Drawing.Point(7, 33);
            this.textBoxIloscTrans.Name = "textBoxIloscTrans";
            this.textBoxIloscTrans.Size = new System.Drawing.Size(100, 20);
            this.textBoxIloscTrans.TabIndex = 6;
            this.textBoxIloscTrans.WordWrap = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Ilość";
            // 
            // dateTimePickerTrans
            // 
            this.dateTimePickerTrans.Location = new System.Drawing.Point(322, 12);
            this.dateTimePickerTrans.Name = "dateTimePickerTrans";
            this.dateTimePickerTrans.Size = new System.Drawing.Size(153, 20);
            this.dateTimePickerTrans.TabIndex = 10;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(481, 38);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 12;
            this.button6.Text = "Dodaj";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox8.Controls.Add(this.buttonUsunTrans);
            this.groupBox8.Controls.Add(this.dataGridViewTrans);
            this.groupBox8.Location = new System.Drawing.Point(6, 6);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(570, 302);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Sprzedaż Historia";
            // 
            // dataGridViewTrans
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTrans.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTrans.AutoGenerateColumns = false;
            this.dataGridViewTrans.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewTrans.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewTrans.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridViewTrans.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.jajkaDataGridViewTextBoxColumn,
            this.groszeDataGridViewTextBoxColumn1,
            this.pelneDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn2,
            this.notkaDataGridViewTextBoxColumn2,
            this.Grosze});
            this.dataGridViewTrans.DataSource = this.transakcjeBindingSource;
            this.dataGridViewTrans.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewTrans.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewTrans.Name = "dataGridViewTrans";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTrans.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTrans.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTrans.Size = new System.Drawing.Size(564, 255);
            this.dataGridViewTrans.TabIndex = 0;
            // 
            // transakcjeBindingSource
            // 
            this.transakcjeBindingSource.DataMember = "Transakcje";
            this.transakcjeBindingSource.DataSource = this.databaseDataSet1;
            // 
            // databaseDataSet1
            // 
            this.databaseDataSet1.DataSetName = "DatabaseDataSet";
            this.databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPageStatystyka
            // 
            this.tabPageStatystyka.Location = new System.Drawing.Point(4, 22);
            this.tabPageStatystyka.Name = "tabPageStatystyka";
            this.tabPageStatystyka.Size = new System.Drawing.Size(584, 385);
            this.tabPageStatystyka.TabIndex = 3;
            this.tabPageStatystyka.Text = "Statystyka";
            this.tabPageStatystyka.UseVisualStyleBackColor = true;
            // 
            // zniesioneTableAdapter
            // 
            this.zniesioneTableAdapter.ClearBeforeFill = true;
            // 
            // dokupioneTableAdapter
            // 
            this.dokupioneTableAdapter.ClearBeforeFill = true;
            // 
            // klienciTableAdapter
            // 
            this.klienciTableAdapter.ClearBeforeFill = true;
            // 
            // transakcjeTableAdapter
            // 
            this.transakcjeTableAdapter.ClearBeforeFill = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 20;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 20;
            // 
            // imieDataGridViewTextBoxColumn
            // 
            this.imieDataGridViewTextBoxColumn.DataPropertyName = "Imie";
            this.imieDataGridViewTextBoxColumn.HeaderText = "Imie";
            this.imieDataGridViewTextBoxColumn.Name = "imieDataGridViewTextBoxColumn";
            // 
            // nazwiskoDataGridViewTextBoxColumn
            // 
            this.nazwiskoDataGridViewTextBoxColumn.DataPropertyName = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.Name = "nazwiskoDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            this.idDataGridViewTextBoxColumn2.Width = 20;
            // 
            // jajkaDataGridViewTextBoxColumn
            // 
            this.jajkaDataGridViewTextBoxColumn.DataPropertyName = "Jajka";
            this.jajkaDataGridViewTextBoxColumn.HeaderText = "Jajka";
            this.jajkaDataGridViewTextBoxColumn.Name = "jajkaDataGridViewTextBoxColumn";
            // 
            // groszeDataGridViewTextBoxColumn1
            // 
            this.groszeDataGridViewTextBoxColumn1.DataPropertyName = "Grosze";
            this.groszeDataGridViewTextBoxColumn1.HeaderText = "Grosze";
            this.groszeDataGridViewTextBoxColumn1.Name = "groszeDataGridViewTextBoxColumn1";
            // 
            // pelneDataGridViewTextBoxColumn
            // 
            this.pelneDataGridViewTextBoxColumn.DataPropertyName = "Pelne";
            this.pelneDataGridViewTextBoxColumn.HeaderText = "Pelne";
            this.pelneDataGridViewTextBoxColumn.Name = "pelneDataGridViewTextBoxColumn";
            this.pelneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn2
            // 
            this.dataDataGridViewTextBoxColumn2.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn2.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn2.Name = "dataDataGridViewTextBoxColumn2";
            // 
            // notkaDataGridViewTextBoxColumn2
            // 
            this.notkaDataGridViewTextBoxColumn2.DataPropertyName = "Notka";
            this.notkaDataGridViewTextBoxColumn2.HeaderText = "Notka";
            this.notkaDataGridViewTextBoxColumn2.Name = "notkaDataGridViewTextBoxColumn2";
            // 
            // buttonUsunTrans
            // 
            this.buttonUsunTrans.Location = new System.Drawing.Point(481, 273);
            this.buttonUsunTrans.Name = "buttonUsunTrans";
            this.buttonUsunTrans.Size = new System.Drawing.Size(83, 23);
            this.buttonUsunTrans.TabIndex = 2;
            this.buttonUsunTrans.Text = "Usuń";
            this.buttonUsunTrans.UseVisualStyleBackColor = true;
            this.buttonUsunTrans.Click += new System.EventHandler(this.buttonUsunTrans_Click);
            // 
            // Grosze
            // 
            this.Grosze.DataPropertyName = "Grosze";
            this.Grosze.HeaderText = "Grosze";
            this.Grosze.Name = "Grosze";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 411);
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
            ((System.ComponentModel.ISupportInitialize)(this.zniesioneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.tabPageDokupione.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokupioneBindingSource)).EndInit();
            this.tabPageKlienci.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKlienci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klienciBindingSource)).EndInit();
            this.tabPageTransakcje.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transakcjeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iloscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPageKlienci;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNazwiskoKlienci;
        private System.Windows.Forms.TextBox textBoxImieKlienci;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridViewKlienci;
        private System.Windows.Forms.BindingSource klienciBindingSource;
        private DatabaseDataSetTableAdapters.KlienciTableAdapter klienciTableAdapter;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.DataGridView dataGridViewTrans;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxDokupioneGroszy;
        private System.Windows.Forms.TextBox textBoxDokupionezloty;
        private DatabaseDataSet databaseDataSet1;
        private System.Windows.Forms.BindingSource transakcjeBindingSource;
        private DatabaseDataSetTableAdapters.TransakcjeTableAdapter transakcjeTableAdapter;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox comboBoxKlientTrans;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxGroszyTrans;
        private System.Windows.Forms.TextBox textBoxZlotyTrans;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxNotkaTrans;
        private System.Windows.Forms.TextBox textBoxIloscTrans;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePickerTrans;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn iloscDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn groszeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notkaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonUsunTrans;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn jajkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groszeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pelneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn notkaDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grosze;
    }
}

