namespace CSharp_SQL_App {
    partial class UgovoriForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonIzmeni = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonIstorijaPromena = new System.Windows.Forms.Button();
            this.ugovorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ugovoriDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelId = new System.Windows.Forms.Label();
            this.labelOpstina = new System.Windows.Forms.Label();
            this.labelUrbanista = new System.Windows.Forms.Label();
            this.labelNazivPlana = new System.Windows.Forms.Label();
            this.labelDatumUgovora = new System.Windows.Forms.Label();
            this.labelNapomena = new System.Windows.Forms.Label();
            this.labelFaza = new System.Windows.Forms.Label();
            this.labelTipUgovora = new System.Windows.Forms.Label();
            this.labelUGuid = new System.Windows.Forms.Label();
            this.labelPrioritet = new System.Windows.Forms.Label();
            this.labelKrajnjiRok = new System.Windows.Forms.Label();
            this.labelObim = new System.Windows.Forms.Label();
            this.labelRokPoUgovoru = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxOpstina = new System.Windows.Forms.TextBox();
            this.textBoxNazivPlana = new System.Windows.Forms.TextBox();
            this.textBoxUrbanista = new System.Windows.Forms.TextBox();
            this.textBoxTipUgovora = new System.Windows.Forms.TextBox();
            this.textBoxObim = new System.Windows.Forms.TextBox();
            this.textBoxRokPoUgovoru = new System.Windows.Forms.TextBox();
            this.textBoxNapomena = new System.Windows.Forms.TextBox();
            this.textBoxFaza = new System.Windows.Forms.TextBox();
            this.textBoxPrioritet = new System.Windows.Forms.TextBox();
            this.textBoxUGuid = new System.Windows.Forms.TextBox();
            this.buttonPretraga = new System.Windows.Forms.Button();
            this.dateTimeDatumUgovora = new System.Windows.Forms.DateTimePicker();
            this.dateTimeKrajnjiRok = new System.Windows.Forms.DateTimePicker();
            this.checkBoxDatumUgovora = new System.Windows.Forms.CheckBox();
            this.checkBoxKrajnjiRok = new System.Windows.Forms.CheckBox();
            this.panelPretraga = new System.Windows.Forms.Panel();
            this.radioButtonIdLesser = new System.Windows.Forms.RadioButton();
            this.radioButtonIdGreater = new System.Windows.Forms.RadioButton();
            this.radioButtonIdEqual = new System.Windows.Forms.RadioButton();
            this.panelId = new System.Windows.Forms.Panel();
            this.panelDatumUgovora = new System.Windows.Forms.Panel();
            this.radioButtonDatumUgovoraEqual = new System.Windows.Forms.RadioButton();
            this.radioButtonDatumUgovoraLesser = new System.Windows.Forms.RadioButton();
            this.radioButtonDatumUgovoraGreater = new System.Windows.Forms.RadioButton();
            this.panelObim = new System.Windows.Forms.Panel();
            this.radioButtonObimEqual = new System.Windows.Forms.RadioButton();
            this.radioButtonObimLesser = new System.Windows.Forms.RadioButton();
            this.radioButtonObimGreater = new System.Windows.Forms.RadioButton();
            this.panelKrajnjiRok = new System.Windows.Forms.Panel();
            this.radioButtonKrajnjiRokEqual = new System.Windows.Forms.RadioButton();
            this.radioButtonKrajnjiRokLesser = new System.Windows.Forms.RadioButton();
            this.radioButtonKrajnjiRokGreater = new System.Windows.Forms.RadioButton();
            this.panelPrioritet = new System.Windows.Forms.Panel();
            this.radioButtonPrioritetEqual = new System.Windows.Forms.RadioButton();
            this.radioButtonPrioritetLesser = new System.Windows.Forms.RadioButton();
            this.radioButtonPrioritetGreater = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ugovorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ugovoriDataSetBindingSource)).BeginInit();
            this.panelPretraga.SuspendLayout();
            this.panelId.SuspendLayout();
            this.panelDatumUgovora.SuspendLayout();
            this.panelObim.SuspendLayout();
            this.panelKrajnjiRok.SuspendLayout();
            this.panelPrioritet.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1180, 651);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDodaj.AutoSize = true;
            this.buttonDodaj.Location = new System.Drawing.Point(521, 693);
            this.buttonDodaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(347, 77);
            this.buttonDodaj.TabIndex = 1;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonIzmeni
            // 
            this.buttonIzmeni.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonIzmeni.AutoSize = true;
            this.buttonIzmeni.Location = new System.Drawing.Point(908, 693);
            this.buttonIzmeni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonIzmeni.Name = "buttonIzmeni";
            this.buttonIzmeni.Size = new System.Drawing.Size(347, 77);
            this.buttonIzmeni.TabIndex = 2;
            this.buttonIzmeni.Text = "Izmeni";
            this.buttonIzmeni.UseVisualStyleBackColor = true;
            this.buttonIzmeni.Click += new System.EventHandler(this.buttonIzmeni_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRefresh.AutoSize = true;
            this.buttonRefresh.Location = new System.Drawing.Point(12, 693);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(114, 77);
            this.buttonRefresh.TabIndex = 3;
            this.buttonRefresh.Text = "Osveži";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonIstorijaPromena
            // 
            this.buttonIstorijaPromena.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonIstorijaPromena.AutoSize = true;
            this.buttonIstorijaPromena.Location = new System.Drawing.Point(133, 693);
            this.buttonIstorijaPromena.Margin = new System.Windows.Forms.Padding(4);
            this.buttonIstorijaPromena.Name = "buttonIstorijaPromena";
            this.buttonIstorijaPromena.Size = new System.Drawing.Size(114, 77);
            this.buttonIstorijaPromena.TabIndex = 4;
            this.buttonIstorijaPromena.Text = "Istorija Promena";
            this.buttonIstorijaPromena.UseVisualStyleBackColor = true;
            this.buttonIstorijaPromena.Click += new System.EventHandler(this.buttonIstorijaPromena_Click);
            // 
            // ugovorBindingSource
            // 
            this.ugovorBindingSource.DataMember = "ugovor";
            // 
            // labelId
            // 
            this.labelId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(34, 29);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(18, 16);
            this.labelId.TabIndex = 5;
            this.labelId.Text = "Id";
            // 
            // labelOpstina
            // 
            this.labelOpstina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOpstina.AutoSize = true;
            this.labelOpstina.Location = new System.Drawing.Point(34, 77);
            this.labelOpstina.Name = "labelOpstina";
            this.labelOpstina.Size = new System.Drawing.Size(53, 16);
            this.labelOpstina.TabIndex = 6;
            this.labelOpstina.Text = "Opština";
            // 
            // labelUrbanista
            // 
            this.labelUrbanista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUrbanista.AutoSize = true;
            this.labelUrbanista.Location = new System.Drawing.Point(34, 173);
            this.labelUrbanista.Name = "labelUrbanista";
            this.labelUrbanista.Size = new System.Drawing.Size(65, 16);
            this.labelUrbanista.TabIndex = 8;
            this.labelUrbanista.Text = "Urbanista";
            // 
            // labelNazivPlana
            // 
            this.labelNazivPlana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNazivPlana.AutoSize = true;
            this.labelNazivPlana.Location = new System.Drawing.Point(34, 125);
            this.labelNazivPlana.Name = "labelNazivPlana";
            this.labelNazivPlana.Size = new System.Drawing.Size(78, 16);
            this.labelNazivPlana.TabIndex = 7;
            this.labelNazivPlana.Text = "Naziv plana";
            // 
            // labelDatumUgovora
            // 
            this.labelDatumUgovora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDatumUgovora.AutoSize = true;
            this.labelDatumUgovora.Location = new System.Drawing.Point(34, 365);
            this.labelDatumUgovora.Name = "labelDatumUgovora";
            this.labelDatumUgovora.Size = new System.Drawing.Size(99, 16);
            this.labelDatumUgovora.TabIndex = 12;
            this.labelDatumUgovora.Text = "Datum ugovora";
            // 
            // labelNapomena
            // 
            this.labelNapomena.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNapomena.AutoSize = true;
            this.labelNapomena.Location = new System.Drawing.Point(34, 317);
            this.labelNapomena.Name = "labelNapomena";
            this.labelNapomena.Size = new System.Drawing.Size(75, 16);
            this.labelNapomena.TabIndex = 11;
            this.labelNapomena.Text = "Napomena";
            // 
            // labelFaza
            // 
            this.labelFaza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFaza.AutoSize = true;
            this.labelFaza.Location = new System.Drawing.Point(34, 269);
            this.labelFaza.Name = "labelFaza";
            this.labelFaza.Size = new System.Drawing.Size(37, 16);
            this.labelFaza.TabIndex = 10;
            this.labelFaza.Text = "Faza";
            // 
            // labelTipUgovora
            // 
            this.labelTipUgovora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTipUgovora.AutoSize = true;
            this.labelTipUgovora.Location = new System.Drawing.Point(34, 221);
            this.labelTipUgovora.Name = "labelTipUgovora";
            this.labelTipUgovora.Size = new System.Drawing.Size(83, 16);
            this.labelTipUgovora.TabIndex = 9;
            this.labelTipUgovora.Text = "Tip Ugovora";
            // 
            // labelUGuid
            // 
            this.labelUGuid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUGuid.AutoSize = true;
            this.labelUGuid.Location = new System.Drawing.Point(34, 603);
            this.labelUGuid.Name = "labelUGuid";
            this.labelUGuid.Size = new System.Drawing.Size(35, 16);
            this.labelUGuid.TabIndex = 20;
            this.labelUGuid.Text = "Guid";
            // 
            // labelPrioritet
            // 
            this.labelPrioritet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPrioritet.AutoSize = true;
            this.labelPrioritet.Location = new System.Drawing.Point(34, 556);
            this.labelPrioritet.Name = "labelPrioritet";
            this.labelPrioritet.Size = new System.Drawing.Size(52, 16);
            this.labelPrioritet.TabIndex = 18;
            this.labelPrioritet.Text = "Prioritet";
            // 
            // labelKrajnjiRok
            // 
            this.labelKrajnjiRok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKrajnjiRok.AutoSize = true;
            this.labelKrajnjiRok.Location = new System.Drawing.Point(34, 509);
            this.labelKrajnjiRok.Name = "labelKrajnjiRok";
            this.labelKrajnjiRok.Size = new System.Drawing.Size(65, 16);
            this.labelKrajnjiRok.TabIndex = 17;
            this.labelKrajnjiRok.Text = "Krajnji rok";
            // 
            // labelObim
            // 
            this.labelObim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelObim.AutoSize = true;
            this.labelObim.Location = new System.Drawing.Point(34, 461);
            this.labelObim.Name = "labelObim";
            this.labelObim.Size = new System.Drawing.Size(39, 16);
            this.labelObim.TabIndex = 16;
            this.labelObim.Text = "Obim";
            // 
            // labelRokPoUgovoru
            // 
            this.labelRokPoUgovoru.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRokPoUgovoru.AutoSize = true;
            this.labelRokPoUgovoru.Location = new System.Drawing.Point(34, 413);
            this.labelRokPoUgovoru.Name = "labelRokPoUgovoru";
            this.labelRokPoUgovoru.Size = new System.Drawing.Size(103, 16);
            this.labelRokPoUgovoru.TabIndex = 15;
            this.labelRokPoUgovoru.Text = "Rok po ugovoru";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(147, 26);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(264, 22);
            this.textBoxId.TabIndex = 21;
            // 
            // textBoxOpstina
            // 
            this.textBoxOpstina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOpstina.Location = new System.Drawing.Point(147, 74);
            this.textBoxOpstina.Name = "textBoxOpstina";
            this.textBoxOpstina.Size = new System.Drawing.Size(264, 22);
            this.textBoxOpstina.TabIndex = 22;
            // 
            // textBoxNazivPlana
            // 
            this.textBoxNazivPlana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNazivPlana.Location = new System.Drawing.Point(147, 122);
            this.textBoxNazivPlana.Name = "textBoxNazivPlana";
            this.textBoxNazivPlana.Size = new System.Drawing.Size(264, 22);
            this.textBoxNazivPlana.TabIndex = 23;
            // 
            // textBoxUrbanista
            // 
            this.textBoxUrbanista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUrbanista.Location = new System.Drawing.Point(147, 170);
            this.textBoxUrbanista.Name = "textBoxUrbanista";
            this.textBoxUrbanista.Size = new System.Drawing.Size(264, 22);
            this.textBoxUrbanista.TabIndex = 24;
            // 
            // textBoxTipUgovora
            // 
            this.textBoxTipUgovora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTipUgovora.Location = new System.Drawing.Point(147, 218);
            this.textBoxTipUgovora.Name = "textBoxTipUgovora";
            this.textBoxTipUgovora.Size = new System.Drawing.Size(264, 22);
            this.textBoxTipUgovora.TabIndex = 25;
            // 
            // textBoxObim
            // 
            this.textBoxObim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxObim.Location = new System.Drawing.Point(147, 458);
            this.textBoxObim.Name = "textBoxObim";
            this.textBoxObim.Size = new System.Drawing.Size(264, 22);
            this.textBoxObim.TabIndex = 30;
            // 
            // textBoxRokPoUgovoru
            // 
            this.textBoxRokPoUgovoru.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRokPoUgovoru.Location = new System.Drawing.Point(147, 410);
            this.textBoxRokPoUgovoru.Name = "textBoxRokPoUgovoru";
            this.textBoxRokPoUgovoru.Size = new System.Drawing.Size(264, 22);
            this.textBoxRokPoUgovoru.TabIndex = 29;
            // 
            // textBoxNapomena
            // 
            this.textBoxNapomena.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNapomena.Location = new System.Drawing.Point(147, 314);
            this.textBoxNapomena.Name = "textBoxNapomena";
            this.textBoxNapomena.Size = new System.Drawing.Size(264, 22);
            this.textBoxNapomena.TabIndex = 27;
            // 
            // textBoxFaza
            // 
            this.textBoxFaza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFaza.Location = new System.Drawing.Point(147, 266);
            this.textBoxFaza.Name = "textBoxFaza";
            this.textBoxFaza.Size = new System.Drawing.Size(264, 22);
            this.textBoxFaza.TabIndex = 26;
            // 
            // textBoxPrioritet
            // 
            this.textBoxPrioritet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPrioritet.Location = new System.Drawing.Point(147, 554);
            this.textBoxPrioritet.Name = "textBoxPrioritet";
            this.textBoxPrioritet.Size = new System.Drawing.Size(264, 22);
            this.textBoxPrioritet.TabIndex = 32;
            // 
            // textBoxUGuid
            // 
            this.textBoxUGuid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUGuid.Location = new System.Drawing.Point(147, 600);
            this.textBoxUGuid.Name = "textBoxUGuid";
            this.textBoxUGuid.Size = new System.Drawing.Size(264, 22);
            this.textBoxUGuid.TabIndex = 34;
            // 
            // buttonPretraga
            // 
            this.buttonPretraga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPretraga.AutoSize = true;
            this.buttonPretraga.Location = new System.Drawing.Point(1577, 691);
            this.buttonPretraga.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPretraga.Name = "buttonPretraga";
            this.buttonPretraga.Size = new System.Drawing.Size(192, 77);
            this.buttonPretraga.TabIndex = 35;
            this.buttonPretraga.Text = "Pretraga";
            this.buttonPretraga.UseVisualStyleBackColor = true;
            this.buttonPretraga.Click += new System.EventHandler(this.buttonPretraga_Click);
            // 
            // dateTimeDatumUgovora
            // 
            this.dateTimeDatumUgovora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeDatumUgovora.Location = new System.Drawing.Point(147, 362);
            this.dateTimeDatumUgovora.Name = "dateTimeDatumUgovora";
            this.dateTimeDatumUgovora.Size = new System.Drawing.Size(264, 22);
            this.dateTimeDatumUgovora.TabIndex = 49;
            // 
            // dateTimeKrajnjiRok
            // 
            this.dateTimeKrajnjiRok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeKrajnjiRok.Location = new System.Drawing.Point(147, 506);
            this.dateTimeKrajnjiRok.Name = "dateTimeKrajnjiRok";
            this.dateTimeKrajnjiRok.Size = new System.Drawing.Size(264, 22);
            this.dateTimeKrajnjiRok.TabIndex = 50;
            // 
            // checkBoxDatumUgovora
            // 
            this.checkBoxDatumUgovora.AutoSize = true;
            this.checkBoxDatumUgovora.Checked = true;
            this.checkBoxDatumUgovora.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDatumUgovora.Location = new System.Drawing.Point(10, 365);
            this.checkBoxDatumUgovora.Name = "checkBoxDatumUgovora";
            this.checkBoxDatumUgovora.Size = new System.Drawing.Size(18, 17);
            this.checkBoxDatumUgovora.TabIndex = 51;
            this.checkBoxDatumUgovora.UseVisualStyleBackColor = true;
            // 
            // checkBoxKrajnjiRok
            // 
            this.checkBoxKrajnjiRok.AutoSize = true;
            this.checkBoxKrajnjiRok.Checked = true;
            this.checkBoxKrajnjiRok.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxKrajnjiRok.Location = new System.Drawing.Point(10, 509);
            this.checkBoxKrajnjiRok.Name = "checkBoxKrajnjiRok";
            this.checkBoxKrajnjiRok.Size = new System.Drawing.Size(18, 17);
            this.checkBoxKrajnjiRok.TabIndex = 52;
            this.checkBoxKrajnjiRok.UseVisualStyleBackColor = true;
            // 
            // panelPretraga
            // 
            this.panelPretraga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPretraga.Controls.Add(this.panelPrioritet);
            this.panelPretraga.Controls.Add(this.panelKrajnjiRok);
            this.panelPretraga.Controls.Add(this.panelObim);
            this.panelPretraga.Controls.Add(this.panelDatumUgovora);
            this.panelPretraga.Controls.Add(this.panelId);
            this.panelPretraga.Controls.Add(this.checkBoxKrajnjiRok);
            this.panelPretraga.Controls.Add(this.labelId);
            this.panelPretraga.Controls.Add(this.checkBoxDatumUgovora);
            this.panelPretraga.Controls.Add(this.labelOpstina);
            this.panelPretraga.Controls.Add(this.dateTimeKrajnjiRok);
            this.panelPretraga.Controls.Add(this.labelNazivPlana);
            this.panelPretraga.Controls.Add(this.dateTimeDatumUgovora);
            this.panelPretraga.Controls.Add(this.labelUrbanista);
            this.panelPretraga.Controls.Add(this.labelTipUgovora);
            this.panelPretraga.Controls.Add(this.labelFaza);
            this.panelPretraga.Controls.Add(this.labelNapomena);
            this.panelPretraga.Controls.Add(this.labelDatumUgovora);
            this.panelPretraga.Controls.Add(this.labelRokPoUgovoru);
            this.panelPretraga.Controls.Add(this.labelObim);
            this.panelPretraga.Controls.Add(this.labelKrajnjiRok);
            this.panelPretraga.Controls.Add(this.textBoxUGuid);
            this.panelPretraga.Controls.Add(this.labelPrioritet);
            this.panelPretraga.Controls.Add(this.textBoxPrioritet);
            this.panelPretraga.Controls.Add(this.labelUGuid);
            this.panelPretraga.Controls.Add(this.textBoxObim);
            this.panelPretraga.Controls.Add(this.textBoxId);
            this.panelPretraga.Controls.Add(this.textBoxRokPoUgovoru);
            this.panelPretraga.Controls.Add(this.textBoxOpstina);
            this.panelPretraga.Controls.Add(this.textBoxNapomena);
            this.panelPretraga.Controls.Add(this.textBoxNazivPlana);
            this.panelPretraga.Controls.Add(this.textBoxFaza);
            this.panelPretraga.Controls.Add(this.textBoxUrbanista);
            this.panelPretraga.Controls.Add(this.textBoxTipUgovora);
            this.panelPretraga.Location = new System.Drawing.Point(1214, 12);
            this.panelPretraga.Name = "panelPretraga";
            this.panelPretraga.Size = new System.Drawing.Size(556, 651);
            this.panelPretraga.TabIndex = 53;
            // 
            // radioButtonIdLesser
            // 
            this.radioButtonIdLesser.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonIdLesser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonIdLesser.Location = new System.Drawing.Point(0, 0);
            this.radioButtonIdLesser.Name = "radioButtonIdLesser";
            this.radioButtonIdLesser.Size = new System.Drawing.Size(34, 30);
            this.radioButtonIdLesser.TabIndex = 0;
            this.radioButtonIdLesser.TabStop = true;
            this.radioButtonIdLesser.Text = "<";
            this.radioButtonIdLesser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonIdLesser.UseVisualStyleBackColor = true;
            // 
            // radioButtonIdGreater
            // 
            this.radioButtonIdGreater.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonIdGreater.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonIdGreater.Location = new System.Drawing.Point(40, 0);
            this.radioButtonIdGreater.Name = "radioButtonIdGreater";
            this.radioButtonIdGreater.Size = new System.Drawing.Size(34, 30);
            this.radioButtonIdGreater.TabIndex = 1;
            this.radioButtonIdGreater.TabStop = true;
            this.radioButtonIdGreater.Text = ">";
            this.radioButtonIdGreater.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonIdGreater.UseVisualStyleBackColor = true;
            // 
            // radioButtonIdEqual
            // 
            this.radioButtonIdEqual.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonIdEqual.Checked = true;
            this.radioButtonIdEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonIdEqual.Location = new System.Drawing.Point(80, 0);
            this.radioButtonIdEqual.Name = "radioButtonIdEqual";
            this.radioButtonIdEqual.Size = new System.Drawing.Size(34, 30);
            this.radioButtonIdEqual.TabIndex = 2;
            this.radioButtonIdEqual.TabStop = true;
            this.radioButtonIdEqual.Text = "=";
            this.radioButtonIdEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonIdEqual.UseVisualStyleBackColor = true;
            // 
            // panelId
            // 
            this.panelId.Controls.Add(this.radioButtonIdEqual);
            this.panelId.Controls.Add(this.radioButtonIdLesser);
            this.panelId.Controls.Add(this.radioButtonIdGreater);
            this.panelId.Location = new System.Drawing.Point(423, 22);
            this.panelId.Name = "panelId";
            this.panelId.Size = new System.Drawing.Size(114, 30);
            this.panelId.TabIndex = 53;
            // 
            // panelDatumUgovora
            // 
            this.panelDatumUgovora.Controls.Add(this.radioButtonDatumUgovoraEqual);
            this.panelDatumUgovora.Controls.Add(this.radioButtonDatumUgovoraLesser);
            this.panelDatumUgovora.Controls.Add(this.radioButtonDatumUgovoraGreater);
            this.panelDatumUgovora.Location = new System.Drawing.Point(423, 358);
            this.panelDatumUgovora.Name = "panelDatumUgovora";
            this.panelDatumUgovora.Size = new System.Drawing.Size(114, 30);
            this.panelDatumUgovora.TabIndex = 54;
            // 
            // radioButtonDatumUgovoraEqual
            // 
            this.radioButtonDatumUgovoraEqual.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonDatumUgovoraEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDatumUgovoraEqual.Location = new System.Drawing.Point(80, 0);
            this.radioButtonDatumUgovoraEqual.Name = "radioButtonDatumUgovoraEqual";
            this.radioButtonDatumUgovoraEqual.Size = new System.Drawing.Size(34, 30);
            this.radioButtonDatumUgovoraEqual.TabIndex = 2;
            this.radioButtonDatumUgovoraEqual.Text = "=";
            this.radioButtonDatumUgovoraEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonDatumUgovoraEqual.UseVisualStyleBackColor = true;
            // 
            // radioButtonDatumUgovoraLesser
            // 
            this.radioButtonDatumUgovoraLesser.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonDatumUgovoraLesser.Checked = true;
            this.radioButtonDatumUgovoraLesser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDatumUgovoraLesser.Location = new System.Drawing.Point(0, 0);
            this.radioButtonDatumUgovoraLesser.Name = "radioButtonDatumUgovoraLesser";
            this.radioButtonDatumUgovoraLesser.Size = new System.Drawing.Size(34, 30);
            this.radioButtonDatumUgovoraLesser.TabIndex = 0;
            this.radioButtonDatumUgovoraLesser.TabStop = true;
            this.radioButtonDatumUgovoraLesser.Text = "<";
            this.radioButtonDatumUgovoraLesser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonDatumUgovoraLesser.UseVisualStyleBackColor = true;
            // 
            // radioButtonDatumUgovoraGreater
            // 
            this.radioButtonDatumUgovoraGreater.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonDatumUgovoraGreater.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDatumUgovoraGreater.Location = new System.Drawing.Point(40, 0);
            this.radioButtonDatumUgovoraGreater.Name = "radioButtonDatumUgovoraGreater";
            this.radioButtonDatumUgovoraGreater.Size = new System.Drawing.Size(34, 30);
            this.radioButtonDatumUgovoraGreater.TabIndex = 1;
            this.radioButtonDatumUgovoraGreater.TabStop = true;
            this.radioButtonDatumUgovoraGreater.Text = ">";
            this.radioButtonDatumUgovoraGreater.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonDatumUgovoraGreater.UseVisualStyleBackColor = true;
            // 
            // panelObim
            // 
            this.panelObim.Controls.Add(this.radioButtonObimEqual);
            this.panelObim.Controls.Add(this.radioButtonObimLesser);
            this.panelObim.Controls.Add(this.radioButtonObimGreater);
            this.panelObim.Location = new System.Drawing.Point(423, 454);
            this.panelObim.Name = "panelObim";
            this.panelObim.Size = new System.Drawing.Size(114, 30);
            this.panelObim.TabIndex = 54;
            // 
            // radioButtonObimEqual
            // 
            this.radioButtonObimEqual.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonObimEqual.Checked = true;
            this.radioButtonObimEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonObimEqual.Location = new System.Drawing.Point(80, 0);
            this.radioButtonObimEqual.Name = "radioButtonObimEqual";
            this.radioButtonObimEqual.Size = new System.Drawing.Size(34, 30);
            this.radioButtonObimEqual.TabIndex = 2;
            this.radioButtonObimEqual.TabStop = true;
            this.radioButtonObimEqual.Text = "=";
            this.radioButtonObimEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonObimEqual.UseVisualStyleBackColor = true;
            // 
            // radioButtonObimLesser
            // 
            this.radioButtonObimLesser.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonObimLesser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonObimLesser.Location = new System.Drawing.Point(0, 0);
            this.radioButtonObimLesser.Name = "radioButtonObimLesser";
            this.radioButtonObimLesser.Size = new System.Drawing.Size(34, 30);
            this.radioButtonObimLesser.TabIndex = 0;
            this.radioButtonObimLesser.TabStop = true;
            this.radioButtonObimLesser.Text = "<";
            this.radioButtonObimLesser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonObimLesser.UseVisualStyleBackColor = true;
            // 
            // radioButtonObimGreater
            // 
            this.radioButtonObimGreater.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonObimGreater.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonObimGreater.Location = new System.Drawing.Point(40, 0);
            this.radioButtonObimGreater.Name = "radioButtonObimGreater";
            this.radioButtonObimGreater.Size = new System.Drawing.Size(34, 30);
            this.radioButtonObimGreater.TabIndex = 1;
            this.radioButtonObimGreater.TabStop = true;
            this.radioButtonObimGreater.Text = ">";
            this.radioButtonObimGreater.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonObimGreater.UseVisualStyleBackColor = true;
            // 
            // panelKrajnjiRok
            // 
            this.panelKrajnjiRok.Controls.Add(this.radioButtonKrajnjiRokEqual);
            this.panelKrajnjiRok.Controls.Add(this.radioButtonKrajnjiRokLesser);
            this.panelKrajnjiRok.Controls.Add(this.radioButtonKrajnjiRokGreater);
            this.panelKrajnjiRok.Location = new System.Drawing.Point(423, 502);
            this.panelKrajnjiRok.Name = "panelKrajnjiRok";
            this.panelKrajnjiRok.Size = new System.Drawing.Size(114, 30);
            this.panelKrajnjiRok.TabIndex = 54;
            // 
            // radioButtonKrajnjiRokEqual
            // 
            this.radioButtonKrajnjiRokEqual.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonKrajnjiRokEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonKrajnjiRokEqual.Location = new System.Drawing.Point(80, 0);
            this.radioButtonKrajnjiRokEqual.Name = "radioButtonKrajnjiRokEqual";
            this.radioButtonKrajnjiRokEqual.Size = new System.Drawing.Size(34, 30);
            this.radioButtonKrajnjiRokEqual.TabIndex = 2;
            this.radioButtonKrajnjiRokEqual.Text = "=";
            this.radioButtonKrajnjiRokEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonKrajnjiRokEqual.UseVisualStyleBackColor = true;
            // 
            // radioButtonKrajnjiRokLesser
            // 
            this.radioButtonKrajnjiRokLesser.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonKrajnjiRokLesser.Checked = true;
            this.radioButtonKrajnjiRokLesser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonKrajnjiRokLesser.Location = new System.Drawing.Point(0, 0);
            this.radioButtonKrajnjiRokLesser.Name = "radioButtonKrajnjiRokLesser";
            this.radioButtonKrajnjiRokLesser.Size = new System.Drawing.Size(34, 30);
            this.radioButtonKrajnjiRokLesser.TabIndex = 0;
            this.radioButtonKrajnjiRokLesser.TabStop = true;
            this.radioButtonKrajnjiRokLesser.Text = "<";
            this.radioButtonKrajnjiRokLesser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonKrajnjiRokLesser.UseVisualStyleBackColor = true;
            // 
            // radioButtonKrajnjiRokGreater
            // 
            this.radioButtonKrajnjiRokGreater.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonKrajnjiRokGreater.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonKrajnjiRokGreater.Location = new System.Drawing.Point(40, 0);
            this.radioButtonKrajnjiRokGreater.Name = "radioButtonKrajnjiRokGreater";
            this.radioButtonKrajnjiRokGreater.Size = new System.Drawing.Size(34, 30);
            this.radioButtonKrajnjiRokGreater.TabIndex = 1;
            this.radioButtonKrajnjiRokGreater.TabStop = true;
            this.radioButtonKrajnjiRokGreater.Text = ">";
            this.radioButtonKrajnjiRokGreater.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonKrajnjiRokGreater.UseVisualStyleBackColor = true;
            // 
            // panelPrioritet
            // 
            this.panelPrioritet.Controls.Add(this.radioButtonPrioritetEqual);
            this.panelPrioritet.Controls.Add(this.radioButtonPrioritetLesser);
            this.panelPrioritet.Controls.Add(this.radioButtonPrioritetGreater);
            this.panelPrioritet.Location = new System.Drawing.Point(423, 550);
            this.panelPrioritet.Name = "panelPrioritet";
            this.panelPrioritet.Size = new System.Drawing.Size(114, 30);
            this.panelPrioritet.TabIndex = 54;
            // 
            // radioButtonPrioritetEqual
            // 
            this.radioButtonPrioritetEqual.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonPrioritetEqual.Checked = true;
            this.radioButtonPrioritetEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPrioritetEqual.Location = new System.Drawing.Point(80, 0);
            this.radioButtonPrioritetEqual.Name = "radioButtonPrioritetEqual";
            this.radioButtonPrioritetEqual.Size = new System.Drawing.Size(34, 30);
            this.radioButtonPrioritetEqual.TabIndex = 2;
            this.radioButtonPrioritetEqual.TabStop = true;
            this.radioButtonPrioritetEqual.Text = "=";
            this.radioButtonPrioritetEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonPrioritetEqual.UseVisualStyleBackColor = true;
            // 
            // radioButtonPrioritetLesser
            // 
            this.radioButtonPrioritetLesser.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonPrioritetLesser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPrioritetLesser.Location = new System.Drawing.Point(0, 0);
            this.radioButtonPrioritetLesser.Name = "radioButtonPrioritetLesser";
            this.radioButtonPrioritetLesser.Size = new System.Drawing.Size(34, 30);
            this.radioButtonPrioritetLesser.TabIndex = 0;
            this.radioButtonPrioritetLesser.TabStop = true;
            this.radioButtonPrioritetLesser.Text = "<";
            this.radioButtonPrioritetLesser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonPrioritetLesser.UseVisualStyleBackColor = true;
            // 
            // radioButtonPrioritetGreater
            // 
            this.radioButtonPrioritetGreater.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonPrioritetGreater.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPrioritetGreater.Location = new System.Drawing.Point(40, 0);
            this.radioButtonPrioritetGreater.Name = "radioButtonPrioritetGreater";
            this.radioButtonPrioritetGreater.Size = new System.Drawing.Size(34, 30);
            this.radioButtonPrioritetGreater.TabIndex = 1;
            this.radioButtonPrioritetGreater.TabStop = true;
            this.radioButtonPrioritetGreater.Text = ">";
            this.radioButtonPrioritetGreater.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonPrioritetGreater.UseVisualStyleBackColor = true;
            // 
            // UgovoriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1782, 781);
            this.Controls.Add(this.buttonPretraga);
            this.Controls.Add(this.buttonIstorijaPromena);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonIzmeni);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelPretraga);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1800, 828);
            this.Name = "UgovoriForm";
            this.Text = "Ugovori";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UgovoriForm_Load);
            this.ResizeBegin += new System.EventHandler(this.UgovoriForm_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.UgovoriForm_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ugovorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ugovoriDataSetBindingSource)).EndInit();
            this.panelPretraga.ResumeLayout(false);
            this.panelPretraga.PerformLayout();
            this.panelId.ResumeLayout(false);
            this.panelDatumUgovora.ResumeLayout(false);
            this.panelObim.ResumeLayout(false);
            this.panelKrajnjiRok.ResumeLayout(false);
            this.panelPrioritet.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonIzmeni;
        private System.Windows.Forms.BindingSource ugovoriDataSetBindingSource;
        private System.Windows.Forms.BindingSource ugovorBindingSource;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonIstorijaPromena;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelOpstina;
        private System.Windows.Forms.Label labelUrbanista;
        private System.Windows.Forms.Label labelNazivPlana;
        private System.Windows.Forms.Label labelDatumUgovora;
        private System.Windows.Forms.Label labelNapomena;
        private System.Windows.Forms.Label labelFaza;
        private System.Windows.Forms.Label labelTipUgovora;
        private System.Windows.Forms.Label labelUGuid;
        private System.Windows.Forms.Label labelPrioritet;
        private System.Windows.Forms.Label labelKrajnjiRok;
        private System.Windows.Forms.Label labelObim;
        private System.Windows.Forms.Label labelRokPoUgovoru;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxOpstina;
        private System.Windows.Forms.TextBox textBoxNazivPlana;
        private System.Windows.Forms.TextBox textBoxUrbanista;
        private System.Windows.Forms.TextBox textBoxTipUgovora;
        private System.Windows.Forms.TextBox textBoxObim;
        private System.Windows.Forms.TextBox textBoxRokPoUgovoru;
        private System.Windows.Forms.TextBox textBoxNapomena;
        private System.Windows.Forms.TextBox textBoxFaza;
        private System.Windows.Forms.TextBox textBoxPrioritet;
        private System.Windows.Forms.TextBox textBoxUGuid;
        private System.Windows.Forms.Button buttonPretraga;
        private System.Windows.Forms.DateTimePicker dateTimeDatumUgovora;
        private System.Windows.Forms.DateTimePicker dateTimeKrajnjiRok;
        private System.Windows.Forms.CheckBox checkBoxDatumUgovora;
        private System.Windows.Forms.CheckBox checkBoxKrajnjiRok;
        private System.Windows.Forms.Panel panelPretraga;
        private System.Windows.Forms.Panel panelId;
        private System.Windows.Forms.RadioButton radioButtonIdEqual;
        private System.Windows.Forms.RadioButton radioButtonIdLesser;
        private System.Windows.Forms.RadioButton radioButtonIdGreater;
        private System.Windows.Forms.Panel panelPrioritet;
        private System.Windows.Forms.RadioButton radioButtonPrioritetEqual;
        private System.Windows.Forms.RadioButton radioButtonPrioritetLesser;
        private System.Windows.Forms.RadioButton radioButtonPrioritetGreater;
        private System.Windows.Forms.Panel panelKrajnjiRok;
        private System.Windows.Forms.RadioButton radioButtonKrajnjiRokEqual;
        private System.Windows.Forms.RadioButton radioButtonKrajnjiRokLesser;
        private System.Windows.Forms.RadioButton radioButtonKrajnjiRokGreater;
        private System.Windows.Forms.Panel panelObim;
        private System.Windows.Forms.RadioButton radioButtonObimEqual;
        private System.Windows.Forms.RadioButton radioButtonObimLesser;
        private System.Windows.Forms.RadioButton radioButtonObimGreater;
        private System.Windows.Forms.Panel panelDatumUgovora;
        private System.Windows.Forms.RadioButton radioButtonDatumUgovoraEqual;
        private System.Windows.Forms.RadioButton radioButtonDatumUgovoraLesser;
        private System.Windows.Forms.RadioButton radioButtonDatumUgovoraGreater;
    }
}