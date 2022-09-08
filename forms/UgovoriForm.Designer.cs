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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UgovoriForm));
            this.dataGridViewUgovori = new System.Windows.Forms.DataGridView();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonIzmeni = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonIstorijaPromena = new System.Windows.Forms.Button();
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
            this.labelStatus = new System.Windows.Forms.Label();
            this.panelCena = new System.Windows.Forms.Panel();
            this.radioButtonCenaEqual = new System.Windows.Forms.RadioButton();
            this.radioButtonCenaLesser = new System.Windows.Forms.RadioButton();
            this.radioButtonCenaGreater = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.textBoxCena = new System.Windows.Forms.TextBox();
            this.panelPrioritet = new System.Windows.Forms.Panel();
            this.radioButtonPrioritetEqual = new System.Windows.Forms.RadioButton();
            this.radioButtonPrioritetLesser = new System.Windows.Forms.RadioButton();
            this.radioButtonPrioritetGreater = new System.Windows.Forms.RadioButton();
            this.panelKrajnjiRok = new System.Windows.Forms.Panel();
            this.radioButtonKrajnjiRokEqual = new System.Windows.Forms.RadioButton();
            this.radioButtonKrajnjiRokLesser = new System.Windows.Forms.RadioButton();
            this.radioButtonKrajnjiRokGreater = new System.Windows.Forms.RadioButton();
            this.panelObim = new System.Windows.Forms.Panel();
            this.radioButtonObimEqual = new System.Windows.Forms.RadioButton();
            this.radioButtonObimLesser = new System.Windows.Forms.RadioButton();
            this.radioButtonObimGreater = new System.Windows.Forms.RadioButton();
            this.panelDatumUgovora = new System.Windows.Forms.Panel();
            this.radioButtonDatumUgovoraEqual = new System.Windows.Forms.RadioButton();
            this.radioButtonDatumUgovoraLesser = new System.Windows.Forms.RadioButton();
            this.radioButtonDatumUgovoraGreater = new System.Windows.Forms.RadioButton();
            this.panelId = new System.Windows.Forms.Panel();
            this.radioButtonIdEqual = new System.Windows.Forms.RadioButton();
            this.radioButtonIdLesser = new System.Windows.Forms.RadioButton();
            this.radioButtonIdGreater = new System.Windows.Forms.RadioButton();
            this.buttonObrisi = new System.Windows.Forms.Button();
            this.buttonIstorijaPromenaObrisanihUgovora = new System.Windows.Forms.Button();
            this.buttonZatvori = new System.Windows.Forms.Button();
            this.buttonUgovorFiles = new System.Windows.Forms.Button();
            this.ugovorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ugovoriDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radioButtonIdLessOrEqual = new System.Windows.Forms.RadioButton();
            this.radioButtonIdGreaterOrEqual = new System.Windows.Forms.RadioButton();
            this.radioButtonDatumUgovoraGreaterOrEqual = new System.Windows.Forms.RadioButton();
            this.radioButtonDatumUgovoraLessOrEqual = new System.Windows.Forms.RadioButton();
            this.radioButtonObimGreaterOrEqual = new System.Windows.Forms.RadioButton();
            this.radioButtonObimLessOrEqual = new System.Windows.Forms.RadioButton();
            this.radioButtonKrajnjiRokGreaterOrEqual = new System.Windows.Forms.RadioButton();
            this.radioButtonKrajnjiRokLessOrEqual = new System.Windows.Forms.RadioButton();
            this.radioButtonPrioritetGreaterOrEqual = new System.Windows.Forms.RadioButton();
            this.radioButtonPrioritetLessOrEqual = new System.Windows.Forms.RadioButton();
            this.radioButtonCenaGreaterOrEqual = new System.Windows.Forms.RadioButton();
            this.radioButtonCenaLessOrEqual = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUgovori)).BeginInit();
            this.panelPretraga.SuspendLayout();
            this.panelCena.SuspendLayout();
            this.panelPrioritet.SuspendLayout();
            this.panelKrajnjiRok.SuspendLayout();
            this.panelObim.SuspendLayout();
            this.panelDatumUgovora.SuspendLayout();
            this.panelId.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ugovorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ugovoriDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUgovori
            // 
            this.dataGridViewUgovori.AllowUserToAddRows = false;
            this.dataGridViewUgovori.AllowUserToDeleteRows = false;
            this.dataGridViewUgovori.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewUgovori.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUgovori.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewUgovori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUgovori.Location = new System.Drawing.Point(9, 10);
            this.dataGridViewUgovori.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewUgovori.MultiSelect = false;
            this.dataGridViewUgovori.Name = "dataGridViewUgovori";
            this.dataGridViewUgovori.ReadOnly = true;
            this.dataGridViewUgovori.RowHeadersVisible = false;
            this.dataGridViewUgovori.RowHeadersWidth = 51;
            this.dataGridViewUgovori.RowTemplate.Height = 24;
            this.dataGridViewUgovori.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUgovori.Size = new System.Drawing.Size(924, 529);
            this.dataGridViewUgovori.TabIndex = 0;
            this.dataGridViewUgovori.TabStop = false;
            this.dataGridViewUgovori.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUgovori_CellDoubleClick);
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDodaj.AutoSize = true;
            this.buttonDodaj.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDodaj.Location = new System.Drawing.Point(379, 567);
            this.buttonDodaj.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(192, 63);
            this.buttonDodaj.TabIndex = 19;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonIzmeni
            // 
            this.buttonIzmeni.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonIzmeni.AutoSize = true;
            this.buttonIzmeni.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIzmeni.Location = new System.Drawing.Point(588, 567);
            this.buttonIzmeni.Margin = new System.Windows.Forms.Padding(2);
            this.buttonIzmeni.Name = "buttonIzmeni";
            this.buttonIzmeni.Size = new System.Drawing.Size(192, 63);
            this.buttonIzmeni.TabIndex = 20;
            this.buttonIzmeni.Text = "Izmeni";
            this.buttonIzmeni.UseVisualStyleBackColor = true;
            this.buttonIzmeni.Click += new System.EventHandler(this.buttonIzmeni_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRefresh.AutoSize = true;
            this.buttonRefresh.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.buttonRefresh.Location = new System.Drawing.Point(9, 567);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(59, 63);
            this.buttonRefresh.TabIndex = 16;
            this.buttonRefresh.Text = "Osveži";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonIstorijaPromena
            // 
            this.buttonIstorijaPromena.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonIstorijaPromena.AutoSize = true;
            this.buttonIstorijaPromena.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.buttonIstorijaPromena.Location = new System.Drawing.Point(85, 567);
            this.buttonIstorijaPromena.Name = "buttonIstorijaPromena";
            this.buttonIstorijaPromena.Size = new System.Drawing.Size(122, 63);
            this.buttonIstorijaPromena.TabIndex = 17;
            this.buttonIstorijaPromena.Text = "Istorija Promena";
            this.buttonIstorijaPromena.UseVisualStyleBackColor = true;
            this.buttonIstorijaPromena.Click += new System.EventHandler(this.buttonIstorijaPromena_Click);
            // 
            // labelId
            // 
            this.labelId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(30, 16);
            this.labelId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(18, 16);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "Id";
            // 
            // labelOpstina
            // 
            this.labelOpstina.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOpstina.AutoSize = true;
            this.labelOpstina.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpstina.Location = new System.Drawing.Point(30, 49);
            this.labelOpstina.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOpstina.Name = "labelOpstina";
            this.labelOpstina.Size = new System.Drawing.Size(50, 16);
            this.labelOpstina.TabIndex = 0;
            this.labelOpstina.Text = "Opština";
            // 
            // labelUrbanista
            // 
            this.labelUrbanista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUrbanista.AutoSize = true;
            this.labelUrbanista.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUrbanista.Location = new System.Drawing.Point(30, 115);
            this.labelUrbanista.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUrbanista.Name = "labelUrbanista";
            this.labelUrbanista.Size = new System.Drawing.Size(59, 16);
            this.labelUrbanista.TabIndex = 0;
            this.labelUrbanista.Text = "Urbanista";
            // 
            // labelNazivPlana
            // 
            this.labelNazivPlana.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNazivPlana.AutoSize = true;
            this.labelNazivPlana.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNazivPlana.Location = new System.Drawing.Point(30, 82);
            this.labelNazivPlana.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNazivPlana.Name = "labelNazivPlana";
            this.labelNazivPlana.Size = new System.Drawing.Size(74, 16);
            this.labelNazivPlana.TabIndex = 0;
            this.labelNazivPlana.Text = "Naziv plana";
            // 
            // labelDatumUgovora
            // 
            this.labelDatumUgovora.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDatumUgovora.AutoSize = true;
            this.labelDatumUgovora.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatumUgovora.Location = new System.Drawing.Point(30, 243);
            this.labelDatumUgovora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDatumUgovora.Name = "labelDatumUgovora";
            this.labelDatumUgovora.Size = new System.Drawing.Size(94, 16);
            this.labelDatumUgovora.TabIndex = 0;
            this.labelDatumUgovora.Text = "Datum ugovora";
            // 
            // labelNapomena
            // 
            this.labelNapomena.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNapomena.AutoSize = true;
            this.labelNapomena.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNapomena.Location = new System.Drawing.Point(30, 214);
            this.labelNapomena.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNapomena.Name = "labelNapomena";
            this.labelNapomena.Size = new System.Drawing.Size(70, 16);
            this.labelNapomena.TabIndex = 0;
            this.labelNapomena.Text = "Napomena";
            // 
            // labelFaza
            // 
            this.labelFaza.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFaza.AutoSize = true;
            this.labelFaza.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFaza.Location = new System.Drawing.Point(30, 181);
            this.labelFaza.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFaza.Name = "labelFaza";
            this.labelFaza.Size = new System.Drawing.Size(33, 16);
            this.labelFaza.TabIndex = 0;
            this.labelFaza.Text = "Faza";
            // 
            // labelTipUgovora
            // 
            this.labelTipUgovora.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTipUgovora.AutoSize = true;
            this.labelTipUgovora.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipUgovora.Location = new System.Drawing.Point(30, 148);
            this.labelTipUgovora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTipUgovora.Name = "labelTipUgovora";
            this.labelTipUgovora.Size = new System.Drawing.Size(72, 16);
            this.labelTipUgovora.TabIndex = 0;
            this.labelTipUgovora.Text = "Tip ugovora";
            // 
            // labelUGuid
            // 
            this.labelUGuid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUGuid.AutoSize = true;
            this.labelUGuid.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUGuid.Location = new System.Drawing.Point(30, 478);
            this.labelUGuid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUGuid.Name = "labelUGuid";
            this.labelUGuid.Size = new System.Drawing.Size(34, 16);
            this.labelUGuid.TabIndex = 0;
            this.labelUGuid.Text = "Guid";
            // 
            // labelPrioritet
            // 
            this.labelPrioritet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPrioritet.AutoSize = true;
            this.labelPrioritet.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrioritet.Location = new System.Drawing.Point(30, 379);
            this.labelPrioritet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrioritet.Name = "labelPrioritet";
            this.labelPrioritet.Size = new System.Drawing.Size(46, 16);
            this.labelPrioritet.TabIndex = 0;
            this.labelPrioritet.Text = "Prioritet";
            // 
            // labelKrajnjiRok
            // 
            this.labelKrajnjiRok.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKrajnjiRok.AutoSize = true;
            this.labelKrajnjiRok.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKrajnjiRok.Location = new System.Drawing.Point(30, 346);
            this.labelKrajnjiRok.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelKrajnjiRok.Name = "labelKrajnjiRok";
            this.labelKrajnjiRok.Size = new System.Drawing.Size(56, 16);
            this.labelKrajnjiRok.TabIndex = 0;
            this.labelKrajnjiRok.Text = "Krajnji rok";
            // 
            // labelObim
            // 
            this.labelObim.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelObim.AutoSize = true;
            this.labelObim.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObim.Location = new System.Drawing.Point(30, 313);
            this.labelObim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelObim.Name = "labelObim";
            this.labelObim.Size = new System.Drawing.Size(37, 16);
            this.labelObim.TabIndex = 0;
            this.labelObim.Text = "Obim";
            // 
            // labelRokPoUgovoru
            // 
            this.labelRokPoUgovoru.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRokPoUgovoru.AutoSize = true;
            this.labelRokPoUgovoru.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRokPoUgovoru.Location = new System.Drawing.Point(30, 278);
            this.labelRokPoUgovoru.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRokPoUgovoru.Name = "labelRokPoUgovoru";
            this.labelRokPoUgovoru.Size = new System.Drawing.Size(93, 16);
            this.labelRokPoUgovoru.TabIndex = 0;
            this.labelRokPoUgovoru.Text = "Rok po ugovoru";
            // 
            // textBoxId
            // 
            this.textBoxId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxId.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.textBoxId.Location = new System.Drawing.Point(127, 14);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(199, 21);
            this.textBoxId.TabIndex = 1;
            // 
            // textBoxOpstina
            // 
            this.textBoxOpstina.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOpstina.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.textBoxOpstina.Location = new System.Drawing.Point(127, 47);
            this.textBoxOpstina.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxOpstina.Name = "textBoxOpstina";
            this.textBoxOpstina.Size = new System.Drawing.Size(199, 21);
            this.textBoxOpstina.TabIndex = 2;
            // 
            // textBoxNazivPlana
            // 
            this.textBoxNazivPlana.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNazivPlana.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.textBoxNazivPlana.Location = new System.Drawing.Point(127, 80);
            this.textBoxNazivPlana.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNazivPlana.Name = "textBoxNazivPlana";
            this.textBoxNazivPlana.Size = new System.Drawing.Size(199, 21);
            this.textBoxNazivPlana.TabIndex = 3;
            // 
            // textBoxUrbanista
            // 
            this.textBoxUrbanista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUrbanista.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.textBoxUrbanista.Location = new System.Drawing.Point(127, 113);
            this.textBoxUrbanista.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUrbanista.Name = "textBoxUrbanista";
            this.textBoxUrbanista.Size = new System.Drawing.Size(199, 21);
            this.textBoxUrbanista.TabIndex = 4;
            // 
            // textBoxTipUgovora
            // 
            this.textBoxTipUgovora.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTipUgovora.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.textBoxTipUgovora.Location = new System.Drawing.Point(127, 146);
            this.textBoxTipUgovora.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTipUgovora.Name = "textBoxTipUgovora";
            this.textBoxTipUgovora.Size = new System.Drawing.Size(199, 21);
            this.textBoxTipUgovora.TabIndex = 5;
            // 
            // textBoxObim
            // 
            this.textBoxObim.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxObim.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.textBoxObim.Location = new System.Drawing.Point(127, 311);
            this.textBoxObim.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxObim.Name = "textBoxObim";
            this.textBoxObim.Size = new System.Drawing.Size(199, 21);
            this.textBoxObim.TabIndex = 10;
            this.textBoxObim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxObim_KeyPress);
            // 
            // textBoxRokPoUgovoru
            // 
            this.textBoxRokPoUgovoru.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRokPoUgovoru.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.textBoxRokPoUgovoru.Location = new System.Drawing.Point(127, 276);
            this.textBoxRokPoUgovoru.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRokPoUgovoru.Name = "textBoxRokPoUgovoru";
            this.textBoxRokPoUgovoru.Size = new System.Drawing.Size(199, 21);
            this.textBoxRokPoUgovoru.TabIndex = 9;
            this.textBoxRokPoUgovoru.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRokPoUgovoru_KeyPress);
            // 
            // textBoxNapomena
            // 
            this.textBoxNapomena.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNapomena.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.textBoxNapomena.Location = new System.Drawing.Point(127, 212);
            this.textBoxNapomena.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNapomena.Name = "textBoxNapomena";
            this.textBoxNapomena.Size = new System.Drawing.Size(199, 21);
            this.textBoxNapomena.TabIndex = 7;
            // 
            // textBoxFaza
            // 
            this.textBoxFaza.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFaza.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.textBoxFaza.Location = new System.Drawing.Point(127, 179);
            this.textBoxFaza.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFaza.Name = "textBoxFaza";
            this.textBoxFaza.Size = new System.Drawing.Size(199, 21);
            this.textBoxFaza.TabIndex = 6;
            // 
            // textBoxPrioritet
            // 
            this.textBoxPrioritet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPrioritet.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.textBoxPrioritet.Location = new System.Drawing.Point(127, 377);
            this.textBoxPrioritet.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPrioritet.Name = "textBoxPrioritet";
            this.textBoxPrioritet.Size = new System.Drawing.Size(199, 21);
            this.textBoxPrioritet.TabIndex = 12;
            // 
            // textBoxUGuid
            // 
            this.textBoxUGuid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUGuid.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.textBoxUGuid.Location = new System.Drawing.Point(127, 476);
            this.textBoxUGuid.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUGuid.Name = "textBoxUGuid";
            this.textBoxUGuid.Size = new System.Drawing.Size(199, 21);
            this.textBoxUGuid.TabIndex = 15;
            // 
            // buttonPretraga
            // 
            this.buttonPretraga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPretraga.AutoSize = true;
            this.buttonPretraga.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPretraga.Location = new System.Drawing.Point(1184, 567);
            this.buttonPretraga.Name = "buttonPretraga";
            this.buttonPretraga.Size = new System.Drawing.Size(161, 63);
            this.buttonPretraga.TabIndex = 23;
            this.buttonPretraga.Text = "Pretraga";
            this.buttonPretraga.UseVisualStyleBackColor = true;
            this.buttonPretraga.Click += new System.EventHandler(this.buttonPretraga_Click);
            // 
            // dateTimeDatumUgovora
            // 
            this.dateTimeDatumUgovora.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeDatumUgovora.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.dateTimeDatumUgovora.Location = new System.Drawing.Point(127, 241);
            this.dateTimeDatumUgovora.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeDatumUgovora.Name = "dateTimeDatumUgovora";
            this.dateTimeDatumUgovora.Size = new System.Drawing.Size(199, 21);
            this.dateTimeDatumUgovora.TabIndex = 8;
            // 
            // dateTimeKrajnjiRok
            // 
            this.dateTimeKrajnjiRok.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeKrajnjiRok.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.dateTimeKrajnjiRok.Location = new System.Drawing.Point(127, 344);
            this.dateTimeKrajnjiRok.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeKrajnjiRok.Name = "dateTimeKrajnjiRok";
            this.dateTimeKrajnjiRok.Size = new System.Drawing.Size(199, 21);
            this.dateTimeKrajnjiRok.TabIndex = 11;
            // 
            // checkBoxDatumUgovora
            // 
            this.checkBoxDatumUgovora.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxDatumUgovora.AutoSize = true;
            this.checkBoxDatumUgovora.Location = new System.Drawing.Point(7, 244);
            this.checkBoxDatumUgovora.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxDatumUgovora.Name = "checkBoxDatumUgovora";
            this.checkBoxDatumUgovora.Size = new System.Drawing.Size(15, 14);
            this.checkBoxDatumUgovora.TabIndex = 26;
            this.checkBoxDatumUgovora.UseVisualStyleBackColor = true;
            // 
            // checkBoxKrajnjiRok
            // 
            this.checkBoxKrajnjiRok.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxKrajnjiRok.AutoSize = true;
            this.checkBoxKrajnjiRok.Location = new System.Drawing.Point(7, 347);
            this.checkBoxKrajnjiRok.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxKrajnjiRok.Name = "checkBoxKrajnjiRok";
            this.checkBoxKrajnjiRok.Size = new System.Drawing.Size(15, 14);
            this.checkBoxKrajnjiRok.TabIndex = 29;
            this.checkBoxKrajnjiRok.UseVisualStyleBackColor = true;
            // 
            // panelPretraga
            // 
            this.panelPretraga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPretraga.Controls.Add(this.labelStatus);
            this.panelPretraga.Controls.Add(this.panelCena);
            this.panelPretraga.Controls.Add(this.label1);
            this.panelPretraga.Controls.Add(this.textBoxStatus);
            this.panelPretraga.Controls.Add(this.textBoxCena);
            this.panelPretraga.Controls.Add(this.panelPrioritet);
            this.panelPretraga.Controls.Add(this.panelKrajnjiRok);
            this.panelPretraga.Controls.Add(this.panelObim);
            this.panelPretraga.Controls.Add(this.panelDatumUgovora);
            this.panelPretraga.Controls.Add(this.labelUGuid);
            this.panelPretraga.Controls.Add(this.textBoxUGuid);
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
            this.panelPretraga.Controls.Add(this.labelPrioritet);
            this.panelPretraga.Controls.Add(this.textBoxPrioritet);
            this.panelPretraga.Controls.Add(this.textBoxObim);
            this.panelPretraga.Controls.Add(this.textBoxId);
            this.panelPretraga.Controls.Add(this.textBoxRokPoUgovoru);
            this.panelPretraga.Controls.Add(this.textBoxOpstina);
            this.panelPretraga.Controls.Add(this.textBoxNapomena);
            this.panelPretraga.Controls.Add(this.textBoxNazivPlana);
            this.panelPretraga.Controls.Add(this.textBoxFaza);
            this.panelPretraga.Controls.Add(this.textBoxUrbanista);
            this.panelPretraga.Controls.Add(this.textBoxTipUgovora);
            this.panelPretraga.Location = new System.Drawing.Point(937, 10);
            this.panelPretraga.Margin = new System.Windows.Forms.Padding(2);
            this.panelPretraga.Name = "panelPretraga";
            this.panelPretraga.Size = new System.Drawing.Size(492, 529);
            this.panelPretraga.TabIndex = 33;
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(30, 445);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(40, 16);
            this.labelStatus.TabIndex = 31;
            this.labelStatus.Text = "Status";
            // 
            // panelCena
            // 
            this.panelCena.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCena.Controls.Add(this.radioButtonCenaGreaterOrEqual);
            this.panelCena.Controls.Add(this.radioButtonCenaEqual);
            this.panelCena.Controls.Add(this.radioButtonCenaLessOrEqual);
            this.panelCena.Controls.Add(this.radioButtonCenaLesser);
            this.panelCena.Controls.Add(this.radioButtonCenaGreater);
            this.panelCena.Location = new System.Drawing.Point(337, 408);
            this.panelCena.Margin = new System.Windows.Forms.Padding(2);
            this.panelCena.Name = "panelCena";
            this.panelCena.Size = new System.Drawing.Size(146, 24);
            this.panelCena.TabIndex = 32;
            // 
            // radioButtonCenaEqual
            // 
            this.radioButtonCenaEqual.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonCenaEqual.Checked = true;
            this.radioButtonCenaEqual.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCenaEqual.Location = new System.Drawing.Point(60, 0);
            this.radioButtonCenaEqual.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonCenaEqual.Name = "radioButtonCenaEqual";
            this.radioButtonCenaEqual.Size = new System.Drawing.Size(26, 24);
            this.radioButtonCenaEqual.TabIndex = 2;
            this.radioButtonCenaEqual.TabStop = true;
            this.radioButtonCenaEqual.Text = "=";
            this.radioButtonCenaEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonCenaEqual.UseVisualStyleBackColor = true;
            // 
            // radioButtonCenaLesser
            // 
            this.radioButtonCenaLesser.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonCenaLesser.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCenaLesser.Location = new System.Drawing.Point(0, 0);
            this.radioButtonCenaLesser.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonCenaLesser.Name = "radioButtonCenaLesser";
            this.radioButtonCenaLesser.Size = new System.Drawing.Size(26, 24);
            this.radioButtonCenaLesser.TabIndex = 0;
            this.radioButtonCenaLesser.Text = "<";
            this.radioButtonCenaLesser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonCenaLesser.UseVisualStyleBackColor = true;
            // 
            // radioButtonCenaGreater
            // 
            this.radioButtonCenaGreater.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonCenaGreater.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCenaGreater.Location = new System.Drawing.Point(30, 0);
            this.radioButtonCenaGreater.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonCenaGreater.Name = "radioButtonCenaGreater";
            this.radioButtonCenaGreater.Size = new System.Drawing.Size(26, 24);
            this.radioButtonCenaGreater.TabIndex = 1;
            this.radioButtonCenaGreater.Text = ">";
            this.radioButtonCenaGreater.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonCenaGreater.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 412);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Cena";
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStatus.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.textBoxStatus.Location = new System.Drawing.Point(127, 443);
            this.textBoxStatus.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(199, 21);
            this.textBoxStatus.TabIndex = 14;
            // 
            // textBoxCena
            // 
            this.textBoxCena.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCena.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.textBoxCena.Location = new System.Drawing.Point(127, 410);
            this.textBoxCena.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCena.Name = "textBoxCena";
            this.textBoxCena.Size = new System.Drawing.Size(199, 21);
            this.textBoxCena.TabIndex = 13;
            this.textBoxCena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCena_KeyPress);
            // 
            // panelPrioritet
            // 
            this.panelPrioritet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPrioritet.Controls.Add(this.radioButtonPrioritetGreaterOrEqual);
            this.panelPrioritet.Controls.Add(this.radioButtonPrioritetEqual);
            this.panelPrioritet.Controls.Add(this.radioButtonPrioritetLessOrEqual);
            this.panelPrioritet.Controls.Add(this.radioButtonPrioritetLesser);
            this.panelPrioritet.Controls.Add(this.radioButtonPrioritetGreater);
            this.panelPrioritet.Location = new System.Drawing.Point(337, 375);
            this.panelPrioritet.Margin = new System.Windows.Forms.Padding(2);
            this.panelPrioritet.Name = "panelPrioritet";
            this.panelPrioritet.Size = new System.Drawing.Size(146, 24);
            this.panelPrioritet.TabIndex = 31;
            // 
            // radioButtonPrioritetEqual
            // 
            this.radioButtonPrioritetEqual.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonPrioritetEqual.Checked = true;
            this.radioButtonPrioritetEqual.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPrioritetEqual.Location = new System.Drawing.Point(60, 0);
            this.radioButtonPrioritetEqual.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonPrioritetEqual.Name = "radioButtonPrioritetEqual";
            this.radioButtonPrioritetEqual.Size = new System.Drawing.Size(26, 24);
            this.radioButtonPrioritetEqual.TabIndex = 2;
            this.radioButtonPrioritetEqual.TabStop = true;
            this.radioButtonPrioritetEqual.Text = "=";
            this.radioButtonPrioritetEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonPrioritetEqual.UseVisualStyleBackColor = true;
            // 
            // radioButtonPrioritetLesser
            // 
            this.radioButtonPrioritetLesser.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonPrioritetLesser.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPrioritetLesser.Location = new System.Drawing.Point(0, 0);
            this.radioButtonPrioritetLesser.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonPrioritetLesser.Name = "radioButtonPrioritetLesser";
            this.radioButtonPrioritetLesser.Size = new System.Drawing.Size(26, 24);
            this.radioButtonPrioritetLesser.TabIndex = 0;
            this.radioButtonPrioritetLesser.Text = "<";
            this.radioButtonPrioritetLesser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonPrioritetLesser.UseVisualStyleBackColor = true;
            // 
            // radioButtonPrioritetGreater
            // 
            this.radioButtonPrioritetGreater.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonPrioritetGreater.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPrioritetGreater.Location = new System.Drawing.Point(30, 0);
            this.radioButtonPrioritetGreater.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonPrioritetGreater.Name = "radioButtonPrioritetGreater";
            this.radioButtonPrioritetGreater.Size = new System.Drawing.Size(26, 24);
            this.radioButtonPrioritetGreater.TabIndex = 1;
            this.radioButtonPrioritetGreater.Text = ">";
            this.radioButtonPrioritetGreater.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonPrioritetGreater.UseVisualStyleBackColor = true;
            // 
            // panelKrajnjiRok
            // 
            this.panelKrajnjiRok.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelKrajnjiRok.Controls.Add(this.radioButtonKrajnjiRokGreaterOrEqual);
            this.panelKrajnjiRok.Controls.Add(this.radioButtonKrajnjiRokLessOrEqual);
            this.panelKrajnjiRok.Controls.Add(this.radioButtonKrajnjiRokEqual);
            this.panelKrajnjiRok.Controls.Add(this.radioButtonKrajnjiRokLesser);
            this.panelKrajnjiRok.Controls.Add(this.radioButtonKrajnjiRokGreater);
            this.panelKrajnjiRok.Location = new System.Drawing.Point(337, 342);
            this.panelKrajnjiRok.Margin = new System.Windows.Forms.Padding(2);
            this.panelKrajnjiRok.Name = "panelKrajnjiRok";
            this.panelKrajnjiRok.Size = new System.Drawing.Size(146, 24);
            this.panelKrajnjiRok.TabIndex = 30;
            // 
            // radioButtonKrajnjiRokEqual
            // 
            this.radioButtonKrajnjiRokEqual.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonKrajnjiRokEqual.Checked = true;
            this.radioButtonKrajnjiRokEqual.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonKrajnjiRokEqual.Location = new System.Drawing.Point(60, 0);
            this.radioButtonKrajnjiRokEqual.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonKrajnjiRokEqual.Name = "radioButtonKrajnjiRokEqual";
            this.radioButtonKrajnjiRokEqual.Size = new System.Drawing.Size(26, 24);
            this.radioButtonKrajnjiRokEqual.TabIndex = 2;
            this.radioButtonKrajnjiRokEqual.TabStop = true;
            this.radioButtonKrajnjiRokEqual.Text = "=";
            this.radioButtonKrajnjiRokEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonKrajnjiRokEqual.UseVisualStyleBackColor = true;
            // 
            // radioButtonKrajnjiRokLesser
            // 
            this.radioButtonKrajnjiRokLesser.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonKrajnjiRokLesser.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonKrajnjiRokLesser.Location = new System.Drawing.Point(0, 0);
            this.radioButtonKrajnjiRokLesser.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonKrajnjiRokLesser.Name = "radioButtonKrajnjiRokLesser";
            this.radioButtonKrajnjiRokLesser.Size = new System.Drawing.Size(26, 24);
            this.radioButtonKrajnjiRokLesser.TabIndex = 0;
            this.radioButtonKrajnjiRokLesser.Text = "<";
            this.radioButtonKrajnjiRokLesser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonKrajnjiRokLesser.UseVisualStyleBackColor = true;
            // 
            // radioButtonKrajnjiRokGreater
            // 
            this.radioButtonKrajnjiRokGreater.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonKrajnjiRokGreater.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonKrajnjiRokGreater.Location = new System.Drawing.Point(30, 0);
            this.radioButtonKrajnjiRokGreater.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonKrajnjiRokGreater.Name = "radioButtonKrajnjiRokGreater";
            this.radioButtonKrajnjiRokGreater.Size = new System.Drawing.Size(26, 24);
            this.radioButtonKrajnjiRokGreater.TabIndex = 1;
            this.radioButtonKrajnjiRokGreater.Text = ">";
            this.radioButtonKrajnjiRokGreater.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonKrajnjiRokGreater.UseVisualStyleBackColor = true;
            // 
            // panelObim
            // 
            this.panelObim.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelObim.Controls.Add(this.radioButtonObimGreaterOrEqual);
            this.panelObim.Controls.Add(this.radioButtonObimEqual);
            this.panelObim.Controls.Add(this.radioButtonObimLessOrEqual);
            this.panelObim.Controls.Add(this.radioButtonObimLesser);
            this.panelObim.Controls.Add(this.radioButtonObimGreater);
            this.panelObim.Location = new System.Drawing.Point(337, 309);
            this.panelObim.Margin = new System.Windows.Forms.Padding(2);
            this.panelObim.Name = "panelObim";
            this.panelObim.Size = new System.Drawing.Size(146, 24);
            this.panelObim.TabIndex = 28;
            // 
            // radioButtonObimEqual
            // 
            this.radioButtonObimEqual.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonObimEqual.Checked = true;
            this.radioButtonObimEqual.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonObimEqual.Location = new System.Drawing.Point(60, 0);
            this.radioButtonObimEqual.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonObimEqual.Name = "radioButtonObimEqual";
            this.radioButtonObimEqual.Size = new System.Drawing.Size(26, 24);
            this.radioButtonObimEqual.TabIndex = 2;
            this.radioButtonObimEqual.Text = "=";
            this.radioButtonObimEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonObimEqual.UseVisualStyleBackColor = true;
            // 
            // radioButtonObimLesser
            // 
            this.radioButtonObimLesser.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonObimLesser.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonObimLesser.Location = new System.Drawing.Point(0, 0);
            this.radioButtonObimLesser.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonObimLesser.Name = "radioButtonObimLesser";
            this.radioButtonObimLesser.Size = new System.Drawing.Size(26, 24);
            this.radioButtonObimLesser.TabIndex = 0;
            this.radioButtonObimLesser.Text = "<";
            this.radioButtonObimLesser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonObimLesser.UseVisualStyleBackColor = true;
            // 
            // radioButtonObimGreater
            // 
            this.radioButtonObimGreater.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonObimGreater.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonObimGreater.Location = new System.Drawing.Point(30, 0);
            this.radioButtonObimGreater.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonObimGreater.Name = "radioButtonObimGreater";
            this.radioButtonObimGreater.Size = new System.Drawing.Size(26, 24);
            this.radioButtonObimGreater.TabIndex = 1;
            this.radioButtonObimGreater.Text = ">";
            this.radioButtonObimGreater.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonObimGreater.UseVisualStyleBackColor = true;
            // 
            // panelDatumUgovora
            // 
            this.panelDatumUgovora.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDatumUgovora.Controls.Add(this.radioButtonDatumUgovoraGreaterOrEqual);
            this.panelDatumUgovora.Controls.Add(this.radioButtonDatumUgovoraLessOrEqual);
            this.panelDatumUgovora.Controls.Add(this.radioButtonDatumUgovoraEqual);
            this.panelDatumUgovora.Controls.Add(this.radioButtonDatumUgovoraLesser);
            this.panelDatumUgovora.Controls.Add(this.radioButtonDatumUgovoraGreater);
            this.panelDatumUgovora.Location = new System.Drawing.Point(337, 239);
            this.panelDatumUgovora.Margin = new System.Windows.Forms.Padding(2);
            this.panelDatumUgovora.Name = "panelDatumUgovora";
            this.panelDatumUgovora.Size = new System.Drawing.Size(146, 24);
            this.panelDatumUgovora.TabIndex = 27;
            // 
            // radioButtonDatumUgovoraEqual
            // 
            this.radioButtonDatumUgovoraEqual.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonDatumUgovoraEqual.Checked = true;
            this.radioButtonDatumUgovoraEqual.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDatumUgovoraEqual.Location = new System.Drawing.Point(60, 0);
            this.radioButtonDatumUgovoraEqual.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonDatumUgovoraEqual.Name = "radioButtonDatumUgovoraEqual";
            this.radioButtonDatumUgovoraEqual.Size = new System.Drawing.Size(26, 24);
            this.radioButtonDatumUgovoraEqual.TabIndex = 2;
            this.radioButtonDatumUgovoraEqual.TabStop = true;
            this.radioButtonDatumUgovoraEqual.Text = "=";
            this.radioButtonDatumUgovoraEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonDatumUgovoraEqual.UseVisualStyleBackColor = true;
            // 
            // radioButtonDatumUgovoraLesser
            // 
            this.radioButtonDatumUgovoraLesser.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonDatumUgovoraLesser.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDatumUgovoraLesser.Location = new System.Drawing.Point(0, 0);
            this.radioButtonDatumUgovoraLesser.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonDatumUgovoraLesser.Name = "radioButtonDatumUgovoraLesser";
            this.radioButtonDatumUgovoraLesser.Size = new System.Drawing.Size(26, 24);
            this.radioButtonDatumUgovoraLesser.TabIndex = 0;
            this.radioButtonDatumUgovoraLesser.Text = "<";
            this.radioButtonDatumUgovoraLesser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonDatumUgovoraLesser.UseVisualStyleBackColor = true;
            // 
            // radioButtonDatumUgovoraGreater
            // 
            this.radioButtonDatumUgovoraGreater.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonDatumUgovoraGreater.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDatumUgovoraGreater.Location = new System.Drawing.Point(30, 0);
            this.radioButtonDatumUgovoraGreater.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonDatumUgovoraGreater.Name = "radioButtonDatumUgovoraGreater";
            this.radioButtonDatumUgovoraGreater.Size = new System.Drawing.Size(26, 24);
            this.radioButtonDatumUgovoraGreater.TabIndex = 1;
            this.radioButtonDatumUgovoraGreater.Text = ">";
            this.radioButtonDatumUgovoraGreater.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonDatumUgovoraGreater.UseVisualStyleBackColor = true;
            // 
            // panelId
            // 
            this.panelId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelId.Controls.Add(this.radioButtonIdGreaterOrEqual);
            this.panelId.Controls.Add(this.radioButtonIdLessOrEqual);
            this.panelId.Controls.Add(this.radioButtonIdEqual);
            this.panelId.Controls.Add(this.radioButtonIdLesser);
            this.panelId.Controls.Add(this.radioButtonIdGreater);
            this.panelId.Location = new System.Drawing.Point(337, 12);
            this.panelId.Margin = new System.Windows.Forms.Padding(2);
            this.panelId.Name = "panelId";
            this.panelId.Size = new System.Drawing.Size(146, 24);
            this.panelId.TabIndex = 25;
            // 
            // radioButtonIdEqual
            // 
            this.radioButtonIdEqual.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonIdEqual.Checked = true;
            this.radioButtonIdEqual.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonIdEqual.Location = new System.Drawing.Point(60, 0);
            this.radioButtonIdEqual.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonIdEqual.Name = "radioButtonIdEqual";
            this.radioButtonIdEqual.Size = new System.Drawing.Size(26, 24);
            this.radioButtonIdEqual.TabIndex = 2;
            this.radioButtonIdEqual.Text = "=";
            this.radioButtonIdEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonIdEqual.UseVisualStyleBackColor = true;
            // 
            // radioButtonIdLesser
            // 
            this.radioButtonIdLesser.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonIdLesser.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonIdLesser.Location = new System.Drawing.Point(0, 0);
            this.radioButtonIdLesser.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonIdLesser.Name = "radioButtonIdLesser";
            this.radioButtonIdLesser.Size = new System.Drawing.Size(26, 24);
            this.radioButtonIdLesser.TabIndex = 0;
            this.radioButtonIdLesser.Text = "<";
            this.radioButtonIdLesser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonIdLesser.UseVisualStyleBackColor = true;
            // 
            // radioButtonIdGreater
            // 
            this.radioButtonIdGreater.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonIdGreater.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonIdGreater.Location = new System.Drawing.Point(30, 0);
            this.radioButtonIdGreater.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonIdGreater.Name = "radioButtonIdGreater";
            this.radioButtonIdGreater.Size = new System.Drawing.Size(26, 24);
            this.radioButtonIdGreater.TabIndex = 1;
            this.radioButtonIdGreater.Text = ">";
            this.radioButtonIdGreater.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonIdGreater.UseVisualStyleBackColor = true;
            // 
            // buttonObrisi
            // 
            this.buttonObrisi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonObrisi.AutoSize = true;
            this.buttonObrisi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonObrisi.Location = new System.Drawing.Point(797, 567);
            this.buttonObrisi.Margin = new System.Windows.Forms.Padding(2);
            this.buttonObrisi.Name = "buttonObrisi";
            this.buttonObrisi.Size = new System.Drawing.Size(192, 63);
            this.buttonObrisi.TabIndex = 21;
            this.buttonObrisi.Text = "Obriši";
            this.buttonObrisi.UseVisualStyleBackColor = true;
            this.buttonObrisi.Click += new System.EventHandler(this.buttonObrisi_Click);
            // 
            // buttonIstorijaPromenaObrisanihUgovora
            // 
            this.buttonIstorijaPromenaObrisanihUgovora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonIstorijaPromenaObrisanihUgovora.AutoSize = true;
            this.buttonIstorijaPromenaObrisanihUgovora.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.buttonIstorijaPromenaObrisanihUgovora.Location = new System.Drawing.Point(224, 567);
            this.buttonIstorijaPromenaObrisanihUgovora.Name = "buttonIstorijaPromenaObrisanihUgovora";
            this.buttonIstorijaPromenaObrisanihUgovora.Size = new System.Drawing.Size(138, 63);
            this.buttonIstorijaPromenaObrisanihUgovora.TabIndex = 18;
            this.buttonIstorijaPromenaObrisanihUgovora.Text = "Istorija Promena\r\nObrisanih Ugovora";
            this.buttonIstorijaPromenaObrisanihUgovora.UseVisualStyleBackColor = true;
            this.buttonIstorijaPromenaObrisanihUgovora.Click += new System.EventHandler(this.buttonIstorijaPromenaObrisanihUgovora_Click);
            // 
            // buttonZatvori
            // 
            this.buttonZatvori.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonZatvori.AutoSize = true;
            this.buttonZatvori.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.buttonZatvori.Location = new System.Drawing.Point(1366, 567);
            this.buttonZatvori.Margin = new System.Windows.Forms.Padding(2);
            this.buttonZatvori.Name = "buttonZatvori";
            this.buttonZatvori.Size = new System.Drawing.Size(63, 63);
            this.buttonZatvori.TabIndex = 24;
            this.buttonZatvori.Text = "Zatvori";
            this.buttonZatvori.UseVisualStyleBackColor = true;
            this.buttonZatvori.Click += new System.EventHandler(this.buttonZatvori_Click);
            // 
            // buttonUgovorFiles
            // 
            this.buttonUgovorFiles.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonUgovorFiles.AutoSize = true;
            this.buttonUgovorFiles.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUgovorFiles.Location = new System.Drawing.Point(1006, 567);
            this.buttonUgovorFiles.Name = "buttonUgovorFiles";
            this.buttonUgovorFiles.Size = new System.Drawing.Size(161, 63);
            this.buttonUgovorFiles.TabIndex = 22;
            this.buttonUgovorFiles.Text = "Fajlovi Ugovora";
            this.buttonUgovorFiles.UseVisualStyleBackColor = true;
            this.buttonUgovorFiles.Click += new System.EventHandler(this.buttonUgovorFiles_Click);
            // 
            // ugovorBindingSource
            // 
            this.ugovorBindingSource.DataMember = "ugovor";
            // 
            // radioButtonIdLessOrEqual
            // 
            this.radioButtonIdLessOrEqual.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonIdLessOrEqual.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonIdLessOrEqual.Location = new System.Drawing.Point(90, 0);
            this.radioButtonIdLessOrEqual.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonIdLessOrEqual.Name = "radioButtonIdLessOrEqual";
            this.radioButtonIdLessOrEqual.Size = new System.Drawing.Size(26, 24);
            this.radioButtonIdLessOrEqual.TabIndex = 3;
            this.radioButtonIdLessOrEqual.Text = "≤";
            this.radioButtonIdLessOrEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonIdLessOrEqual.UseVisualStyleBackColor = true;
            // 
            // radioButtonIdGreaterOrEqual
            // 
            this.radioButtonIdGreaterOrEqual.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonIdGreaterOrEqual.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonIdGreaterOrEqual.Location = new System.Drawing.Point(120, 0);
            this.radioButtonIdGreaterOrEqual.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonIdGreaterOrEqual.Name = "radioButtonIdGreaterOrEqual";
            this.radioButtonIdGreaterOrEqual.Size = new System.Drawing.Size(26, 24);
            this.radioButtonIdGreaterOrEqual.TabIndex = 4;
            this.radioButtonIdGreaterOrEqual.Text = "≥";
            this.radioButtonIdGreaterOrEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonIdGreaterOrEqual.UseVisualStyleBackColor = true;
            // 
            // radioButtonDatumUgovoraGreaterOrEqual
            // 
            this.radioButtonDatumUgovoraGreaterOrEqual.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonDatumUgovoraGreaterOrEqual.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDatumUgovoraGreaterOrEqual.Location = new System.Drawing.Point(120, 0);
            this.radioButtonDatumUgovoraGreaterOrEqual.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonDatumUgovoraGreaterOrEqual.Name = "radioButtonDatumUgovoraGreaterOrEqual";
            this.radioButtonDatumUgovoraGreaterOrEqual.Size = new System.Drawing.Size(26, 24);
            this.radioButtonDatumUgovoraGreaterOrEqual.TabIndex = 4;
            this.radioButtonDatumUgovoraGreaterOrEqual.Text = "≥";
            this.radioButtonDatumUgovoraGreaterOrEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonDatumUgovoraGreaterOrEqual.UseVisualStyleBackColor = true;
            // 
            // radioButtonDatumUgovoraLessOrEqual
            // 
            this.radioButtonDatumUgovoraLessOrEqual.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonDatumUgovoraLessOrEqual.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDatumUgovoraLessOrEqual.Location = new System.Drawing.Point(90, 0);
            this.radioButtonDatumUgovoraLessOrEqual.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonDatumUgovoraLessOrEqual.Name = "radioButtonDatumUgovoraLessOrEqual";
            this.radioButtonDatumUgovoraLessOrEqual.Size = new System.Drawing.Size(26, 24);
            this.radioButtonDatumUgovoraLessOrEqual.TabIndex = 3;
            this.radioButtonDatumUgovoraLessOrEqual.Text = "≤";
            this.radioButtonDatumUgovoraLessOrEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonDatumUgovoraLessOrEqual.UseVisualStyleBackColor = true;
            // 
            // radioButtonObimGreaterOrEqual
            // 
            this.radioButtonObimGreaterOrEqual.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonObimGreaterOrEqual.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonObimGreaterOrEqual.Location = new System.Drawing.Point(120, 0);
            this.radioButtonObimGreaterOrEqual.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonObimGreaterOrEqual.Name = "radioButtonObimGreaterOrEqual";
            this.radioButtonObimGreaterOrEqual.Size = new System.Drawing.Size(26, 24);
            this.radioButtonObimGreaterOrEqual.TabIndex = 4;
            this.radioButtonObimGreaterOrEqual.Text = "≥";
            this.radioButtonObimGreaterOrEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonObimGreaterOrEqual.UseVisualStyleBackColor = true;
            // 
            // radioButtonObimLessOrEqual
            // 
            this.radioButtonObimLessOrEqual.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonObimLessOrEqual.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonObimLessOrEqual.Location = new System.Drawing.Point(90, 0);
            this.radioButtonObimLessOrEqual.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonObimLessOrEqual.Name = "radioButtonObimLessOrEqual";
            this.radioButtonObimLessOrEqual.Size = new System.Drawing.Size(26, 24);
            this.radioButtonObimLessOrEqual.TabIndex = 3;
            this.radioButtonObimLessOrEqual.Text = "≤";
            this.radioButtonObimLessOrEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonObimLessOrEqual.UseVisualStyleBackColor = true;
            // 
            // radioButtonKrajnjiRokGreaterOrEqual
            // 
            this.radioButtonKrajnjiRokGreaterOrEqual.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonKrajnjiRokGreaterOrEqual.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonKrajnjiRokGreaterOrEqual.Location = new System.Drawing.Point(120, 0);
            this.radioButtonKrajnjiRokGreaterOrEqual.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonKrajnjiRokGreaterOrEqual.Name = "radioButtonKrajnjiRokGreaterOrEqual";
            this.radioButtonKrajnjiRokGreaterOrEqual.Size = new System.Drawing.Size(26, 24);
            this.radioButtonKrajnjiRokGreaterOrEqual.TabIndex = 4;
            this.radioButtonKrajnjiRokGreaterOrEqual.Text = "≥";
            this.radioButtonKrajnjiRokGreaterOrEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonKrajnjiRokGreaterOrEqual.UseVisualStyleBackColor = true;
            // 
            // radioButtonKrajnjiRokLessOrEqual
            // 
            this.radioButtonKrajnjiRokLessOrEqual.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonKrajnjiRokLessOrEqual.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonKrajnjiRokLessOrEqual.Location = new System.Drawing.Point(90, 0);
            this.radioButtonKrajnjiRokLessOrEqual.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonKrajnjiRokLessOrEqual.Name = "radioButtonKrajnjiRokLessOrEqual";
            this.radioButtonKrajnjiRokLessOrEqual.Size = new System.Drawing.Size(26, 24);
            this.radioButtonKrajnjiRokLessOrEqual.TabIndex = 3;
            this.radioButtonKrajnjiRokLessOrEqual.Text = "≤";
            this.radioButtonKrajnjiRokLessOrEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonKrajnjiRokLessOrEqual.UseVisualStyleBackColor = true;
            // 
            // radioButtonPrioritetGreaterOrEqual
            // 
            this.radioButtonPrioritetGreaterOrEqual.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonPrioritetGreaterOrEqual.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPrioritetGreaterOrEqual.Location = new System.Drawing.Point(120, 0);
            this.radioButtonPrioritetGreaterOrEqual.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonPrioritetGreaterOrEqual.Name = "radioButtonPrioritetGreaterOrEqual";
            this.radioButtonPrioritetGreaterOrEqual.Size = new System.Drawing.Size(26, 24);
            this.radioButtonPrioritetGreaterOrEqual.TabIndex = 4;
            this.radioButtonPrioritetGreaterOrEqual.Text = "≥";
            this.radioButtonPrioritetGreaterOrEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonPrioritetGreaterOrEqual.UseVisualStyleBackColor = true;
            // 
            // radioButtonPrioritetLessOrEqual
            // 
            this.radioButtonPrioritetLessOrEqual.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonPrioritetLessOrEqual.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPrioritetLessOrEqual.Location = new System.Drawing.Point(90, 0);
            this.radioButtonPrioritetLessOrEqual.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonPrioritetLessOrEqual.Name = "radioButtonPrioritetLessOrEqual";
            this.radioButtonPrioritetLessOrEqual.Size = new System.Drawing.Size(26, 24);
            this.radioButtonPrioritetLessOrEqual.TabIndex = 3;
            this.radioButtonPrioritetLessOrEqual.Text = "≤";
            this.radioButtonPrioritetLessOrEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonPrioritetLessOrEqual.UseVisualStyleBackColor = true;
            // 
            // radioButtonCenaGreaterOrEqual
            // 
            this.radioButtonCenaGreaterOrEqual.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonCenaGreaterOrEqual.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCenaGreaterOrEqual.Location = new System.Drawing.Point(120, 0);
            this.radioButtonCenaGreaterOrEqual.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonCenaGreaterOrEqual.Name = "radioButtonCenaGreaterOrEqual";
            this.radioButtonCenaGreaterOrEqual.Size = new System.Drawing.Size(26, 24);
            this.radioButtonCenaGreaterOrEqual.TabIndex = 4;
            this.radioButtonCenaGreaterOrEqual.Text = "≥";
            this.radioButtonCenaGreaterOrEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonCenaGreaterOrEqual.UseVisualStyleBackColor = true;
            // 
            // radioButtonCenaLessOrEqual
            // 
            this.radioButtonCenaLessOrEqual.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonCenaLessOrEqual.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCenaLessOrEqual.Location = new System.Drawing.Point(90, 0);
            this.radioButtonCenaLessOrEqual.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonCenaLessOrEqual.Name = "radioButtonCenaLessOrEqual";
            this.radioButtonCenaLessOrEqual.Size = new System.Drawing.Size(26, 24);
            this.radioButtonCenaLessOrEqual.TabIndex = 3;
            this.radioButtonCenaLessOrEqual.Text = "≤";
            this.radioButtonCenaLessOrEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonCenaLessOrEqual.UseVisualStyleBackColor = true;
            // 
            // UgovoriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 641);
            this.Controls.Add(this.buttonUgovorFiles);
            this.Controls.Add(this.buttonZatvori);
            this.Controls.Add(this.buttonIstorijaPromenaObrisanihUgovora);
            this.Controls.Add(this.buttonObrisi);
            this.Controls.Add(this.buttonPretraga);
            this.Controls.Add(this.buttonIstorijaPromena);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonIzmeni);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.dataGridViewUgovori);
            this.Controls.Add(this.panelPretraga);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1456, 680);
            this.Name = "UgovoriForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ugovori";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UgovoriForm_Load);
            this.ResizeBegin += new System.EventHandler(this.UgovoriForm_ResizeBegin_1);
            this.ResizeEnd += new System.EventHandler(this.UgovoriForm_ResizeEnd_1);
            this.Click += new System.EventHandler(this.UgovoriForm_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUgovori)).EndInit();
            this.panelPretraga.ResumeLayout(false);
            this.panelPretraga.PerformLayout();
            this.panelCena.ResumeLayout(false);
            this.panelPrioritet.ResumeLayout(false);
            this.panelKrajnjiRok.ResumeLayout(false);
            this.panelObim.ResumeLayout(false);
            this.panelDatumUgovora.ResumeLayout(false);
            this.panelId.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ugovorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ugovoriDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUgovori;
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
        private System.Windows.Forms.Button buttonObrisi;
        private System.Windows.Forms.Button buttonIstorijaPromenaObrisanihUgovora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCena;
        private System.Windows.Forms.Panel panelCena;
        private System.Windows.Forms.RadioButton radioButtonCenaEqual;
        private System.Windows.Forms.RadioButton radioButtonCenaLesser;
        private System.Windows.Forms.RadioButton radioButtonCenaGreater;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Button buttonZatvori;
        private System.Windows.Forms.Button buttonUgovorFiles;
        private System.Windows.Forms.RadioButton radioButtonIdGreaterOrEqual;
        private System.Windows.Forms.RadioButton radioButtonIdLessOrEqual;
        private System.Windows.Forms.RadioButton radioButtonDatumUgovoraGreaterOrEqual;
        private System.Windows.Forms.RadioButton radioButtonDatumUgovoraLessOrEqual;
        private System.Windows.Forms.RadioButton radioButtonCenaGreaterOrEqual;
        private System.Windows.Forms.RadioButton radioButtonCenaLessOrEqual;
        private System.Windows.Forms.RadioButton radioButtonPrioritetGreaterOrEqual;
        private System.Windows.Forms.RadioButton radioButtonPrioritetLessOrEqual;
        private System.Windows.Forms.RadioButton radioButtonKrajnjiRokGreaterOrEqual;
        private System.Windows.Forms.RadioButton radioButtonKrajnjiRokLessOrEqual;
        private System.Windows.Forms.RadioButton radioButtonObimGreaterOrEqual;
        private System.Windows.Forms.RadioButton radioButtonObimLessOrEqual;
    }
}