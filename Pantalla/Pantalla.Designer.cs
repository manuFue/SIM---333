using System;

namespace Vista
{
    partial class Pantalla
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_Montecarlo = new System.Windows.Forms.DataGridView();
            this.lbl_TamañoLote = new System.Windows.Forms.Label();
            this.txt_TamañoLote = new System.Windows.Forms.TextBox();
            this.txt_PuntoReposicion = new System.Windows.Forms.TextBox();
            this.lbl_PuntoReposicion = new System.Windows.Forms.Label();
            this.lbl_TiempoSimulacion = new System.Windows.Forms.Label();
            this.txt_ko = new System.Windows.Forms.TextBox();
            this.lbl_ko = new System.Windows.Forms.Label();
            this.txt_km = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ks = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbx_Demanda = new System.Windows.Forms.GroupBox();
            this.btn_cargarValores = new System.Windows.Forms.Button();
            this.radioButton_Automatico = new System.Windows.Forms.RadioButton();
            this.radioButton_Manual = new System.Windows.Forms.RadioButton();
            this.gbx_Demora = new System.Windows.Forms.GroupBox();
            this.txt_Entre21_30 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Entre1_10 = new System.Windows.Forms.TextBox();
            this.txt_Entre11_20 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_demoraError = new System.Windows.Forms.Label();
            this.lbl_DemandaError = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Stock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Simular = new System.Windows.Forms.Button();
            this.btn_Reiniciar = new System.Windows.Forms.Button();
            this.txt_CostoPromedio = new System.Windows.Forms.TextBox();
            this.lbl_CostoPromedio = new System.Windows.Forms.Label();
            this.txt_CostoMaximo = new System.Windows.Forms.TextBox();
            this.lbl_CostoMaximo = new System.Windows.Forms.Label();
            this.txt_CostoMinimo = new System.Windows.Forms.TextBox();
            this.lbl_CostoMinimo = new System.Windows.Forms.Label();
            this.gbx_Resultado = new System.Windows.Forms.GroupBox();
            this.txt_hasta = new System.Windows.Forms.TextBox();
            this.gbx_Simulacion = new System.Windows.Forms.GroupBox();
            this.txt_aPartir = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_TiempoSimulacion = new System.Windows.Forms.TextBox();
            this.relojCentral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd_Demanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd_DemoraEntre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demoraEntre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd_distribucion_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd_Distribucion_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demoraReal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.llegadaPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faltante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo_ko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo_km = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo_ks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoDiario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoAcumulado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoMaximo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Montecarlo)).BeginInit();
            this.gbx_Demanda.SuspendLayout();
            this.gbx_Demora.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbx_Resultado.SuspendLayout();
            this.gbx_Simulacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Montecarlo
            // 
            this.dgv_Montecarlo.AllowUserToAddRows = false;
            this.dgv_Montecarlo.AllowUserToDeleteRows = false;
            this.dgv_Montecarlo.AllowUserToResizeColumns = false;
            this.dgv_Montecarlo.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Montecarlo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Montecarlo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Montecarlo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.relojCentral,
            this.rnd_Demanda,
            this.demanda,
            this.rnd_DemoraEntre,
            this.demoraEntre,
            this.rnd_distribucion_1,
            this.rnd_Distribucion_2,
            this.demoraReal,
            this.fechaPedido,
            this.llegadaPedido,
            this.stock,
            this.faltante,
            this.costo_ko,
            this.costo_km,
            this.costo_ks,
            this.costoDiario,
            this.costoAcumulado,
            this.costoMaximo,
            this.costoMinimo});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Montecarlo.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Montecarlo.Location = new System.Drawing.Point(11, 225);
            this.dgv_Montecarlo.MultiSelect = false;
            this.dgv_Montecarlo.Name = "dgv_Montecarlo";
            this.dgv_Montecarlo.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Montecarlo.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Montecarlo.RowHeadersVisible = false;
            this.dgv_Montecarlo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Montecarlo.Size = new System.Drawing.Size(1042, 345);
            this.dgv_Montecarlo.TabIndex = 0;
            // 
            // lbl_TamañoLote
            // 
            this.lbl_TamañoLote.AutoSize = true;
            this.lbl_TamañoLote.Location = new System.Drawing.Point(8, 22);
            this.lbl_TamañoLote.Name = "lbl_TamañoLote";
            this.lbl_TamañoLote.Size = new System.Drawing.Size(70, 13);
            this.lbl_TamañoLote.TabIndex = 1;
            this.lbl_TamañoLote.Text = "Tamaño Lote";
            // 
            // txt_TamañoLote
            // 
            this.txt_TamañoLote.Location = new System.Drawing.Point(104, 19);
            this.txt_TamañoLote.Name = "txt_TamañoLote";
            this.txt_TamañoLote.Size = new System.Drawing.Size(56, 20);
            this.txt_TamañoLote.TabIndex = 2;
            this.txt_TamañoLote.Text = "1000";
            this.txt_TamañoLote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_TamañoLote.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            this.txt_TamañoLote.LostFocus += new System.EventHandler(this.txt_tamañoLote_LostFocus);
            // 
            // txt_PuntoReposicion
            // 
            this.txt_PuntoReposicion.Location = new System.Drawing.Point(104, 45);
            this.txt_PuntoReposicion.Name = "txt_PuntoReposicion";
            this.txt_PuntoReposicion.Size = new System.Drawing.Size(56, 20);
            this.txt_PuntoReposicion.TabIndex = 4;
            this.txt_PuntoReposicion.Text = "500";
            this.txt_PuntoReposicion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_PuntoReposicion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            this.txt_PuntoReposicion.LostFocus += new System.EventHandler(this.txt_puntoReposicion_LostFocus);
            // 
            // lbl_PuntoReposicion
            // 
            this.lbl_PuntoReposicion.Location = new System.Drawing.Point(6, 39);
            this.lbl_PuntoReposicion.Name = "lbl_PuntoReposicion";
            this.lbl_PuntoReposicion.Size = new System.Drawing.Size(93, 30);
            this.lbl_PuntoReposicion.TabIndex = 3;
            this.lbl_PuntoReposicion.Text = "Punto Reposicion";
            this.lbl_PuntoReposicion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_TiempoSimulacion
            // 
            this.lbl_TiempoSimulacion.AutoSize = true;
            this.lbl_TiempoSimulacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TiempoSimulacion.Location = new System.Drawing.Point(7, 22);
            this.lbl_TiempoSimulacion.Name = "lbl_TiempoSimulacion";
            this.lbl_TiempoSimulacion.Size = new System.Drawing.Size(125, 20);
            this.lbl_TiempoSimulacion.TabIndex = 5;
            this.lbl_TiempoSimulacion.Text = "Días a Simular";
            // 
            // txt_ko
            // 
            this.txt_ko.Location = new System.Drawing.Point(329, 16);
            this.txt_ko.Name = "txt_ko";
            this.txt_ko.Size = new System.Drawing.Size(61, 20);
            this.txt_ko.TabIndex = 8;
            this.txt_ko.Text = "500";
            this.txt_ko.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_ko.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            this.txt_ko.LostFocus += new System.EventHandler(this.txt_costos_LostFocus);
            // 
            // lbl_ko
            // 
            this.lbl_ko.AutoSize = true;
            this.lbl_ko.Location = new System.Drawing.Point(192, 19);
            this.lbl_ko.Name = "lbl_ko";
            this.lbl_ko.Size = new System.Drawing.Size(131, 13);
            this.lbl_ko.TabIndex = 7;
            this.lbl_ko.Text = "Costo Ordenamiento ( Ko )";
            // 
            // txt_km
            // 
            this.txt_km.Location = new System.Drawing.Point(329, 48);
            this.txt_km.Name = "txt_km";
            this.txt_km.Size = new System.Drawing.Size(61, 20);
            this.txt_km.TabIndex = 10;
            this.txt_km.Text = "5";
            this.txt_km.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_km.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            this.txt_km.LostFocus += new System.EventHandler(this.txt_costos_LostFocus);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Costo Mantenimiento ( Km )";
            // 
            // txt_ks
            // 
            this.txt_ks.Location = new System.Drawing.Point(329, 81);
            this.txt_ks.Name = "txt_ks";
            this.txt_ks.Size = new System.Drawing.Size(61, 20);
            this.txt_ks.TabIndex = 12;
            this.txt_ks.Text = "3";
            this.txt_ks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_ks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            this.txt_ks.LostFocus += new System.EventHandler(this.txt_costos_LostFocus);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Costo Stock-Out ( Ks )";
            // 
            // gbx_Demanda
            // 
            this.gbx_Demanda.Controls.Add(this.btn_cargarValores);
            this.gbx_Demanda.Controls.Add(this.radioButton_Automatico);
            this.gbx_Demanda.Controls.Add(this.radioButton_Manual);
            this.gbx_Demanda.Location = new System.Drawing.Point(474, 13);
            this.gbx_Demanda.Name = "gbx_Demanda";
            this.gbx_Demanda.Size = new System.Drawing.Size(289, 111);
            this.gbx_Demanda.TabIndex = 13;
            this.gbx_Demanda.TabStop = false;
            this.gbx_Demanda.Text = "Demanda";
            // 
            // btn_cargarValores
            // 
            this.btn_cargarValores.BackColor = System.Drawing.Color.DarkGray;
            this.btn_cargarValores.Enabled = false;
            this.btn_cargarValores.Location = new System.Drawing.Point(164, 66);
            this.btn_cargarValores.Name = "btn_cargarValores";
            this.btn_cargarValores.Size = new System.Drawing.Size(108, 23);
            this.btn_cargarValores.TabIndex = 2;
            this.btn_cargarValores.Text = "Cargar Valores";
            this.btn_cargarValores.UseVisualStyleBackColor = false;
            this.btn_cargarValores.Click += new System.EventHandler(this.btn_cargarValores_Click);
            // 
            // radioButton_Automatico
            // 
            this.radioButton_Automatico.AutoSize = true;
            this.radioButton_Automatico.Checked = true;
            this.radioButton_Automatico.Location = new System.Drawing.Point(6, 35);
            this.radioButton_Automatico.Name = "radioButton_Automatico";
            this.radioButton_Automatico.Size = new System.Drawing.Size(148, 17);
            this.radioButton_Automatico.TabIndex = 1;
            this.radioButton_Automatico.TabStop = true;
            this.radioButton_Automatico.Text = "Generar Automáticamente";
            this.radioButton_Automatico.UseVisualStyleBackColor = true;
            // 
            // radioButton_Manual
            // 
            this.radioButton_Manual.AutoSize = true;
            this.radioButton_Manual.Location = new System.Drawing.Point(6, 69);
            this.radioButton_Manual.Name = "radioButton_Manual";
            this.radioButton_Manual.Size = new System.Drawing.Size(123, 17);
            this.radioButton_Manual.TabIndex = 0;
            this.radioButton_Manual.Text = "Cargar Manualmente";
            this.radioButton_Manual.UseVisualStyleBackColor = true;
            this.radioButton_Manual.CheckedChanged += new System.EventHandler(this.radioButton_Manual_CheckedChanged);
            // 
            // gbx_Demora
            // 
            this.gbx_Demora.Controls.Add(this.txt_Entre21_30);
            this.gbx_Demora.Controls.Add(this.label5);
            this.gbx_Demora.Controls.Add(this.label3);
            this.gbx_Demora.Controls.Add(this.txt_Entre1_10);
            this.gbx_Demora.Controls.Add(this.txt_Entre11_20);
            this.gbx_Demora.Controls.Add(this.label4);
            this.gbx_Demora.Location = new System.Drawing.Point(799, 13);
            this.gbx_Demora.Name = "gbx_Demora";
            this.gbx_Demora.Size = new System.Drawing.Size(254, 111);
            this.gbx_Demora.TabIndex = 14;
            this.gbx_Demora.TabStop = false;
            this.gbx_Demora.Text = "Días de Demora - Probabilidad";
            // 
            // txt_Entre21_30
            // 
            this.txt_Entre21_30.Location = new System.Drawing.Point(136, 74);
            this.txt_Entre21_30.Name = "txt_Entre21_30";
            this.txt_Entre21_30.Size = new System.Drawing.Size(61, 20);
            this.txt_Entre21_30.TabIndex = 20;
            this.txt_Entre21_30.Text = "0,35";
            this.txt_Entre21_30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Entre21_30.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            this.txt_Entre21_30.LostFocus += new System.EventHandler(this.txt_probabilidad_LostFocus);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Entre 1 - 10 Días";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Entre 21 - 30 Días";
            // 
            // txt_Entre1_10
            // 
            this.txt_Entre1_10.Location = new System.Drawing.Point(136, 26);
            this.txt_Entre1_10.Name = "txt_Entre1_10";
            this.txt_Entre1_10.Size = new System.Drawing.Size(61, 20);
            this.txt_Entre1_10.TabIndex = 16;
            this.txt_Entre1_10.Text = "0,25";
            this.txt_Entre1_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Entre1_10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            this.txt_Entre1_10.LostFocus += new System.EventHandler(this.txt_probabilidad_LostFocus);
            // 
            // txt_Entre11_20
            // 
            this.txt_Entre11_20.Location = new System.Drawing.Point(136, 50);
            this.txt_Entre11_20.Name = "txt_Entre11_20";
            this.txt_Entre11_20.Size = new System.Drawing.Size(61, 20);
            this.txt_Entre11_20.TabIndex = 18;
            this.txt_Entre11_20.Text = "0,40";
            this.txt_Entre11_20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Entre11_20.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            this.txt_Entre11_20.LostFocus += new System.EventHandler(this.txt_probabilidad_LostFocus);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Entre 11 - 20 Días";
            // 
            // lbl_demoraError
            // 
            this.lbl_demoraError.AutoSize = true;
            this.lbl_demoraError.ForeColor = System.Drawing.Color.Red;
            this.lbl_demoraError.Location = new System.Drawing.Point(796, 132);
            this.lbl_demoraError.Name = "lbl_demoraError";
            this.lbl_demoraError.Size = new System.Drawing.Size(198, 13);
            this.lbl_demoraError.TabIndex = 15;
            this.lbl_demoraError.Text = "* Las probabilidades no suman 1 en total";
            this.lbl_demoraError.Visible = false;
            // 
            // lbl_DemandaError
            // 
            this.lbl_DemandaError.AutoSize = true;
            this.lbl_DemandaError.ForeColor = System.Drawing.Color.Red;
            this.lbl_DemandaError.Location = new System.Drawing.Point(471, 132);
            this.lbl_DemandaError.Name = "lbl_DemandaError";
            this.lbl_DemandaError.Size = new System.Drawing.Size(197, 13);
            this.lbl_DemandaError.TabIndex = 16;
            this.lbl_DemandaError.Text = "* No hay valores de demanda cargados.";
            this.lbl_DemandaError.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Stock);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_ks);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_km);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_ko);
            this.groupBox1.Controls.Add(this.lbl_ko);
            this.groupBox1.Controls.Add(this.txt_PuntoReposicion);
            this.groupBox1.Controls.Add(this.lbl_PuntoReposicion);
            this.groupBox1.Controls.Add(this.txt_TamañoLote);
            this.groupBox1.Controls.Add(this.lbl_TamañoLote);
            this.groupBox1.Location = new System.Drawing.Point(15, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 111);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // txt_Stock
            // 
            this.txt_Stock.Location = new System.Drawing.Point(104, 73);
            this.txt_Stock.Name = "txt_Stock";
            this.txt_Stock.Size = new System.Drawing.Size(56, 20);
            this.txt_Stock.TabIndex = 14;
            this.txt_Stock.Text = "1000";
            this.txt_Stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            this.txt_Stock.LostFocus += new System.EventHandler(this.txt_stockInicial_LostFocus);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(2, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 27);
            this.label6.TabIndex = 13;
            this.label6.Text = "Stock Inicial";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Simular
            // 
            this.btn_Simular.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Simular.Enabled = false;
            this.btn_Simular.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Simular.Location = new System.Drawing.Point(807, 186);
            this.btn_Simular.Name = "btn_Simular";
            this.btn_Simular.Size = new System.Drawing.Size(120, 35);
            this.btn_Simular.TabIndex = 3;
            this.btn_Simular.Text = "SIMULAR";
            this.btn_Simular.UseVisualStyleBackColor = false;
            this.btn_Simular.Click += new System.EventHandler(this.btn_Simular_Click);
            // 
            // btn_Reiniciar
            // 
            this.btn_Reiniciar.BackColor = System.Drawing.Color.Salmon;
            this.btn_Reiniciar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Reiniciar.Location = new System.Drawing.Point(933, 184);
            this.btn_Reiniciar.Name = "btn_Reiniciar";
            this.btn_Reiniciar.Size = new System.Drawing.Size(120, 35);
            this.btn_Reiniciar.TabIndex = 18;
            this.btn_Reiniciar.Text = "REINICIAR";
            this.btn_Reiniciar.UseVisualStyleBackColor = false;
            this.btn_Reiniciar.Click += new System.EventHandler(this.btn_Reiniciar_Click);
            // 
            // txt_CostoPromedio
            // 
            this.txt_CostoPromedio.BackColor = System.Drawing.Color.Khaki;
            this.txt_CostoPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CostoPromedio.Location = new System.Drawing.Point(270, 13);
            this.txt_CostoPromedio.Name = "txt_CostoPromedio";
            this.txt_CostoPromedio.Size = new System.Drawing.Size(102, 29);
            this.txt_CostoPromedio.TabIndex = 20;
            this.txt_CostoPromedio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_CostoPromedio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // lbl_CostoPromedio
            // 
            this.lbl_CostoPromedio.AutoSize = true;
            this.lbl_CostoPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CostoPromedio.Location = new System.Drawing.Point(67, 16);
            this.lbl_CostoPromedio.Name = "lbl_CostoPromedio";
            this.lbl_CostoPromedio.Size = new System.Drawing.Size(198, 24);
            this.lbl_CostoPromedio.TabIndex = 19;
            this.lbl_CostoPromedio.Text = "Costo Promedio Diario";
            // 
            // txt_CostoMaximo
            // 
            this.txt_CostoMaximo.BackColor = System.Drawing.Color.Khaki;
            this.txt_CostoMaximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CostoMaximo.Location = new System.Drawing.Point(536, 13);
            this.txt_CostoMaximo.Name = "txt_CostoMaximo";
            this.txt_CostoMaximo.Size = new System.Drawing.Size(102, 29);
            this.txt_CostoMaximo.TabIndex = 22;
            this.txt_CostoMaximo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_CostoMaximo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // lbl_CostoMaximo
            // 
            this.lbl_CostoMaximo.AutoSize = true;
            this.lbl_CostoMaximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CostoMaximo.Location = new System.Drawing.Point(400, 16);
            this.lbl_CostoMaximo.Name = "lbl_CostoMaximo";
            this.lbl_CostoMaximo.Size = new System.Drawing.Size(130, 24);
            this.lbl_CostoMaximo.TabIndex = 21;
            this.lbl_CostoMaximo.Text = "Costo Máximo";
            // 
            // txt_CostoMinimo
            // 
            this.txt_CostoMinimo.BackColor = System.Drawing.Color.Khaki;
            this.txt_CostoMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CostoMinimo.Location = new System.Drawing.Point(807, 13);
            this.txt_CostoMinimo.Name = "txt_CostoMinimo";
            this.txt_CostoMinimo.Size = new System.Drawing.Size(102, 29);
            this.txt_CostoMinimo.TabIndex = 24;
            this.txt_CostoMinimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_CostoMinimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // lbl_CostoMinimo
            // 
            this.lbl_CostoMinimo.AutoSize = true;
            this.lbl_CostoMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CostoMinimo.Location = new System.Drawing.Point(671, 16);
            this.lbl_CostoMinimo.Name = "lbl_CostoMinimo";
            this.lbl_CostoMinimo.Size = new System.Drawing.Size(125, 24);
            this.lbl_CostoMinimo.TabIndex = 23;
            this.lbl_CostoMinimo.Text = "Costo Mínimo";
            // 
            // gbx_Resultado
            // 
            this.gbx_Resultado.Controls.Add(this.txt_CostoMinimo);
            this.gbx_Resultado.Controls.Add(this.lbl_CostoMinimo);
            this.gbx_Resultado.Controls.Add(this.txt_CostoMaximo);
            this.gbx_Resultado.Controls.Add(this.lbl_CostoMaximo);
            this.gbx_Resultado.Controls.Add(this.txt_CostoPromedio);
            this.gbx_Resultado.Controls.Add(this.lbl_CostoPromedio);
            this.gbx_Resultado.Location = new System.Drawing.Point(11, 570);
            this.gbx_Resultado.Name = "gbx_Resultado";
            this.gbx_Resultado.Size = new System.Drawing.Size(1010, 47);
            this.gbx_Resultado.TabIndex = 25;
            this.gbx_Resultado.TabStop = false;
            this.gbx_Resultado.Visible = false;
            // 
            // txt_hasta
            // 
            this.txt_hasta.Enabled = false;
            this.txt_hasta.Location = new System.Drawing.Point(192, 49);
            this.txt_hasta.Name = "txt_hasta";
            this.txt_hasta.Size = new System.Drawing.Size(53, 20);
            this.txt_hasta.TabIndex = 27;
            this.txt_hasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_hasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            this.txt_hasta.LostFocus += new System.EventHandler(this.txt_Hasta_LostFocus);
            // 
            // gbx_Simulacion
            // 
            this.gbx_Simulacion.Controls.Add(this.txt_aPartir);
            this.gbx_Simulacion.Controls.Add(this.label8);
            this.gbx_Simulacion.Controls.Add(this.label7);
            this.gbx_Simulacion.Controls.Add(this.txt_hasta);
            this.gbx_Simulacion.Controls.Add(this.lbl_TiempoSimulacion);
            this.gbx_Simulacion.Controls.Add(this.txt_TiempoSimulacion);
            this.gbx_Simulacion.Location = new System.Drawing.Point(15, 130);
            this.gbx_Simulacion.Name = "gbx_Simulacion";
            this.gbx_Simulacion.Size = new System.Drawing.Size(281, 88);
            this.gbx_Simulacion.TabIndex = 28;
            this.gbx_Simulacion.TabStop = false;
            this.gbx_Simulacion.Text = "Simulación";
            // 
            // txt_aPartir
            // 
            this.txt_aPartir.Enabled = false;
            this.txt_aPartir.Location = new System.Drawing.Point(91, 49);
            this.txt_aPartir.Name = "txt_aPartir";
            this.txt_aPartir.Size = new System.Drawing.Size(53, 20);
            this.txt_aPartir.TabIndex = 30;
            this.txt_aPartir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_aPartir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            this.txt_aPartir.LostFocus += new System.EventHandler(this.txt_Desde_LostFocus);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(150, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "hasta:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Mostrar a partir";
            // 
            // txt_TiempoSimulacion
            // 
            this.txt_TiempoSimulacion.BackColor = System.Drawing.Color.Khaki;
            this.txt_TiempoSimulacion.Location = new System.Drawing.Point(145, 22);
            this.txt_TiempoSimulacion.MaxLength = 15;
            this.txt_TiempoSimulacion.Name = "txt_TiempoSimulacion";
            this.txt_TiempoSimulacion.Size = new System.Drawing.Size(100, 20);
            this.txt_TiempoSimulacion.TabIndex = 6;
            this.txt_TiempoSimulacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_TiempoSimulacion.TextChanged += new System.EventHandler(this.txt_TiempoSimulacion_TextChanged);
            this.txt_TiempoSimulacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            this.txt_TiempoSimulacion.LostFocus += new System.EventHandler(this.txt_TiempoSimulacion_LostFocus);
            // 
            // relojCentral
            // 
            this.relojCentral.HeaderText = "Reloj";
            this.relojCentral.Name = "relojCentral";
            this.relojCentral.ReadOnly = true;
            this.relojCentral.Width = 50;
            // 
            // rnd_Demanda
            // 
            this.rnd_Demanda.HeaderText = "RND";
            this.rnd_Demanda.Name = "rnd_Demanda";
            this.rnd_Demanda.ReadOnly = true;
            this.rnd_Demanda.Width = 45;
            // 
            // demanda
            // 
            this.demanda.HeaderText = "Demanda";
            this.demanda.Name = "demanda";
            this.demanda.ReadOnly = true;
            this.demanda.Width = 52;
            // 
            // rnd_DemoraEntre
            // 
            this.rnd_DemoraEntre.HeaderText = "RND";
            this.rnd_DemoraEntre.Name = "rnd_DemoraEntre";
            this.rnd_DemoraEntre.ReadOnly = true;
            this.rnd_DemoraEntre.Width = 45;
            // 
            // demoraEntre
            // 
            this.demoraEntre.HeaderText = "Demora";
            this.demoraEntre.Name = "demoraEntre";
            this.demoraEntre.ReadOnly = true;
            this.demoraEntre.Width = 70;
            // 
            // rnd_distribucion_1
            // 
            this.rnd_distribucion_1.HeaderText = "RND-1";
            this.rnd_distribucion_1.Name = "rnd_distribucion_1";
            this.rnd_distribucion_1.ReadOnly = true;
            this.rnd_distribucion_1.Width = 45;
            // 
            // rnd_Distribucion_2
            // 
            this.rnd_Distribucion_2.HeaderText = "RND-2";
            this.rnd_Distribucion_2.Name = "rnd_Distribucion_2";
            this.rnd_Distribucion_2.ReadOnly = true;
            this.rnd_Distribucion_2.Width = 45;
            // 
            // demoraReal
            // 
            this.demoraReal.HeaderText = "Dias";
            this.demoraReal.Name = "demoraReal";
            this.demoraReal.ReadOnly = true;
            this.demoraReal.Width = 40;
            // 
            // fechaPedido
            // 
            this.fechaPedido.HeaderText = "Fecha Pedido";
            this.fechaPedido.Name = "fechaPedido";
            this.fechaPedido.ReadOnly = true;
            this.fechaPedido.Width = 40;
            // 
            // llegadaPedido
            // 
            this.llegadaPedido.HeaderText = "Llegada Pedido";
            this.llegadaPedido.Name = "llegadaPedido";
            this.llegadaPedido.ReadOnly = true;
            this.llegadaPedido.Width = 45;
            // 
            // stock
            // 
            this.stock.HeaderText = "STOCK";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            this.stock.Width = 53;
            // 
            // faltante
            // 
            this.faltante.HeaderText = "Faltante";
            this.faltante.Name = "faltante";
            this.faltante.ReadOnly = true;
            this.faltante.Width = 50;
            // 
            // costo_ko
            // 
            this.costo_ko.HeaderText = "Costo Ko";
            this.costo_ko.Name = "costo_ko";
            this.costo_ko.ReadOnly = true;
            this.costo_ko.Width = 60;
            // 
            // costo_km
            // 
            this.costo_km.HeaderText = "Costo Km";
            this.costo_km.Name = "costo_km";
            this.costo_km.ReadOnly = true;
            this.costo_km.Width = 60;
            // 
            // costo_ks
            // 
            this.costo_ks.HeaderText = "Costo Ks";
            this.costo_ks.Name = "costo_ks";
            this.costo_ks.ReadOnly = true;
            this.costo_ks.Width = 60;
            // 
            // costoDiario
            // 
            this.costoDiario.HeaderText = "Costo Diario";
            this.costoDiario.Name = "costoDiario";
            this.costoDiario.ReadOnly = true;
            this.costoDiario.Width = 70;
            // 
            // costoAcumulado
            // 
            this.costoAcumulado.HeaderText = "Costo Acumulado";
            this.costoAcumulado.Name = "costoAcumulado";
            this.costoAcumulado.ReadOnly = true;
            this.costoAcumulado.Width = 70;
            // 
            // costoMaximo
            // 
            this.costoMaximo.HeaderText = "Costo Máximo";
            this.costoMaximo.Name = "costoMaximo";
            this.costoMaximo.ReadOnly = true;
            this.costoMaximo.Width = 70;
            // 
            // costoMinimo
            // 
            this.costoMinimo.HeaderText = "Costo Mínimo";
            this.costoMinimo.Name = "costoMinimo";
            this.costoMinimo.ReadOnly = true;
            this.costoMinimo.Width = 70;
            // 
            // Pantalla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 624);
            this.Controls.Add(this.gbx_Simulacion);
            this.Controls.Add(this.gbx_Resultado);
            this.Controls.Add(this.btn_Reiniciar);
            this.Controls.Add(this.btn_Simular);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_DemandaError);
            this.Controls.Add(this.lbl_demoraError);
            this.Controls.Add(this.gbx_Demora);
            this.Controls.Add(this.gbx_Demanda);
            this.Controls.Add(this.dgv_Montecarlo);
            this.MaximizeBox = false;
            this.Name = "Pantalla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio #333 - Reaprovisionamiento de Stock";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Montecarlo)).EndInit();
            this.gbx_Demanda.ResumeLayout(false);
            this.gbx_Demanda.PerformLayout();
            this.gbx_Demora.ResumeLayout(false);
            this.gbx_Demora.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbx_Resultado.ResumeLayout(false);
            this.gbx_Resultado.PerformLayout();
            this.gbx_Simulacion.ResumeLayout(false);
            this.gbx_Simulacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Montecarlo;
        private System.Windows.Forms.Label lbl_TamañoLote;
        private System.Windows.Forms.TextBox txt_TamañoLote;
        private System.Windows.Forms.TextBox txt_PuntoReposicion;
        private System.Windows.Forms.Label lbl_PuntoReposicion;
        private System.Windows.Forms.Label lbl_TiempoSimulacion;
        private System.Windows.Forms.TextBox txt_ko;
        private System.Windows.Forms.Label lbl_ko;
        private System.Windows.Forms.TextBox txt_km;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbx_Demanda;
        private System.Windows.Forms.Button btn_cargarValores;
        private System.Windows.Forms.RadioButton radioButton_Automatico;
        private System.Windows.Forms.RadioButton radioButton_Manual;
        private System.Windows.Forms.GroupBox gbx_Demora;
        private System.Windows.Forms.TextBox txt_Entre21_30;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Entre1_10;
        private System.Windows.Forms.TextBox txt_Entre11_20;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_demoraError;
        private System.Windows.Forms.Label lbl_DemandaError;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Simular;
        private System.Windows.Forms.Button btn_Reiniciar;
        private System.Windows.Forms.TextBox txt_Stock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_CostoPromedio;
        private System.Windows.Forms.Label lbl_CostoPromedio;
        private System.Windows.Forms.TextBox txt_CostoMaximo;
        private System.Windows.Forms.Label lbl_CostoMaximo;
        private System.Windows.Forms.TextBox txt_CostoMinimo;
        private System.Windows.Forms.Label lbl_CostoMinimo;
        private System.Windows.Forms.GroupBox gbx_Resultado;
        private System.Windows.Forms.TextBox txt_hasta;
        private System.Windows.Forms.GroupBox gbx_Simulacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_aPartir;
        private System.Windows.Forms.TextBox txt_TiempoSimulacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn relojCentral;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd_Demanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn demanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd_DemoraEntre;
        private System.Windows.Forms.DataGridViewTextBoxColumn demoraEntre;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd_distribucion_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd_Distribucion_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn demoraReal;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn llegadaPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn faltante;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo_ko;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo_km;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo_ks;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoDiario;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoAcumulado;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoMaximo;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoMinimo;
    }
}

