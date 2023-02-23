namespace ProyectoAJ
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NombreE = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dia = new System.Windows.Forms.ComboBox();
            this.mes = new System.Windows.Forms.ComboBox();
            this.año = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.activoC = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.montoAC = new System.Windows.Forms.MaskedTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.montoAF = new System.Windows.Forms.MaskedTextBox();
            this.activoF = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.montoPC = new System.Windows.Forms.MaskedTextBox();
            this.pasivoC = new System.Windows.Forms.ComboBox();
            this.agregarA = new System.Windows.Forms.Button();
            this.data1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agregarP = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ACTIVOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de la Empresa";
            // 
            // NombreE
            // 
            this.NombreE.Location = new System.Drawing.Point(191, 59);
            this.NombreE.Name = "NombreE";
            this.NombreE.Size = new System.Drawing.Size(124, 23);
            this.NombreE.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(531, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 15);
            this.label6.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Año";
            // 
            // dia
            // 
            this.dia.FormattingEnabled = true;
            this.dia.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.dia.Location = new System.Drawing.Point(56, 22);
            this.dia.Name = "dia";
            this.dia.Size = new System.Drawing.Size(52, 23);
            this.dia.TabIndex = 6;
            // 
            // mes
            // 
            this.mes.FormattingEnabled = true;
            this.mes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.mes.Location = new System.Drawing.Point(56, 60);
            this.mes.Name = "mes";
            this.mes.Size = new System.Drawing.Size(52, 23);
            this.mes.TabIndex = 7;
            // 
            // año
            // 
            this.año.FormattingEnabled = true;
            this.año.Items.AddRange(new object[] {
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024"});
            this.año.Location = new System.Drawing.Point(56, 98);
            this.año.Name = "año";
            this.año.Size = new System.Drawing.Size(52, 23);
            this.año.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.año);
            this.groupBox1.Controls.Add(this.mes);
            this.groupBox1.Controls.Add(this.dia);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(41, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 137);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fecha";
            // 
            // activoC
            // 
            this.activoC.FormattingEnabled = true;
            this.activoC.Items.AddRange(new object[] {
            "Caja",
            "Bancos",
            "Clientes",
            "Mercancias"});
            this.activoC.Location = new System.Drawing.Point(15, 45);
            this.activoC.Name = "activoC";
            this.activoC.Size = new System.Drawing.Size(121, 23);
            this.activoC.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(460, 205);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.montoAC);
            this.groupBox2.Controls.Add(this.activoC);
            this.groupBox2.Location = new System.Drawing.Point(32, 319);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 129);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Activos Circulantes";
            // 
            // montoAC
            // 
            this.montoAC.Location = new System.Drawing.Point(159, 45);
            this.montoAC.Name = "montoAC";
            this.montoAC.Size = new System.Drawing.Size(100, 23);
            this.montoAC.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.montoAF);
            this.groupBox3.Controls.Add(this.activoF);
            this.groupBox3.Location = new System.Drawing.Point(32, 474);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(283, 121);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Activos Fijos";
            // 
            // montoAF
            // 
            this.montoAF.Location = new System.Drawing.Point(159, 45);
            this.montoAF.Name = "montoAF";
            this.montoAF.Size = new System.Drawing.Size(100, 23);
            this.montoAF.TabIndex = 8;
            // 
            // activoF
            // 
            this.activoF.FormattingEnabled = true;
            this.activoF.Items.AddRange(new object[] {
            "Terreno",
            "Edificio",
            "Mobiliario y Eq."});
            this.activoF.Location = new System.Drawing.Point(15, 45);
            this.activoF.Name = "activoF";
            this.activoF.Size = new System.Drawing.Size(121, 23);
            this.activoF.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(486, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "PASIVOS";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.montoPC);
            this.groupBox4.Controls.Add(this.pasivoC);
            this.groupBox4.Location = new System.Drawing.Point(375, 326);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(283, 122);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pasivos Circulantes";
            // 
            // montoPC
            // 
            this.montoPC.Location = new System.Drawing.Point(156, 45);
            this.montoPC.Name = "montoPC";
            this.montoPC.Size = new System.Drawing.Size(100, 23);
            this.montoPC.TabIndex = 8;
            // 
            // pasivoC
            // 
            this.pasivoC.FormattingEnabled = true;
            this.pasivoC.Items.AddRange(new object[] {
            "Proveedores",
            "Documentos por pagar",
            "Acreedores diversos",
            "Impuestos por pagar"});
            this.pasivoC.Location = new System.Drawing.Point(15, 45);
            this.pasivoC.Name = "pasivoC";
            this.pasivoC.Size = new System.Drawing.Size(121, 23);
            this.pasivoC.TabIndex = 6;
            // 
            // agregarA
            // 
            this.agregarA.Location = new System.Drawing.Point(32, 614);
            this.agregarA.Name = "agregarA";
            this.agregarA.Size = new System.Drawing.Size(283, 44);
            this.agregarA.TabIndex = 9;
            this.agregarA.Text = "Agregar";
            this.agregarA.UseVisualStyleBackColor = true;
            this.agregarA.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // data1
            // 
            this.data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.data1.Location = new System.Drawing.Point(41, 722);
            this.data1.Name = "data1";
            this.data1.RowTemplate.Height = 25;
            this.data1.Size = new System.Drawing.Size(236, 208);
            this.data1.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cuenta";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Total";
            this.Column2.Name = "Column2";
            // 
            // data2
            // 
            this.data2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.data2.Location = new System.Drawing.Point(460, 722);
            this.data2.Name = "data2";
            this.data2.RowTemplate.Height = 25;
            this.data2.Size = new System.Drawing.Size(236, 208);
            this.data2.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Cuenta";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Total";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // agregarP
            // 
            this.agregarP.Location = new System.Drawing.Point(390, 614);
            this.agregarP.Name = "agregarP";
            this.agregarP.Size = new System.Drawing.Size(283, 44);
            this.agregarP.TabIndex = 14;
            this.agregarP.Text = "Agregar";
            this.agregarP.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 999);
            this.Controls.Add(this.agregarP);
            this.Controls.Add(this.agregarA);
            this.Controls.Add(this.data2);
            this.Controls.Add(this.data1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NombreE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox NombreE;
        private Label label6;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox dia;
        private ComboBox mes;
        private ComboBox año;
        private GroupBox groupBox1;
        private ComboBox activoC;
        private TextBox textBox2;
        private GroupBox groupBox2;
        private MaskedTextBox montoAC;
        private GroupBox groupBox3;
        private MaskedTextBox montoAF;
        private ComboBox activoF;
        private Label label9;
        private GroupBox groupBox4;
        private MaskedTextBox montoPC;
        private ComboBox pasivoC;
        private Button agregarA;
        private DataGridView data1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridView data2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Button agregarP;
    }
}