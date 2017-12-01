namespace Vista
{
    partial class Demanda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_valoresDemanda = new System.Windows.Forms.DataGridView();
            this.valoresDemanda = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.valoresNuevos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_valoresDemanda)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(38, 236);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(136, 23);
            this.btn_Aceptar.TabIndex = 1;
            this.btn_Aceptar.Text = "ACEPTAR";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // numero
            // 
            this.numero.HeaderText = "Numero";
            this.numero.Name = "numero";
            // 
            // dgv_valoresDemanda
            // 
            this.dgv_valoresDemanda.AllowUserToResizeColumns = false;
            this.dgv_valoresDemanda.AllowUserToResizeRows = false;
            this.dgv_valoresDemanda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_valoresDemanda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_valoresDemanda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_valoresDemanda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.valoresDemanda,
            this.valoresNuevos});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_valoresDemanda.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_valoresDemanda.Location = new System.Drawing.Point(12, 12);
            this.dgv_valoresDemanda.Name = "dgv_valoresDemanda";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_valoresDemanda.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_valoresDemanda.RowHeadersVisible = false;
            this.dgv_valoresDemanda.Size = new System.Drawing.Size(190, 218);
            this.dgv_valoresDemanda.TabIndex = 2;
            this.dgv_valoresDemanda.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgv_valoresDemanda_EditingControlShowing);
            // 
            // valoresDemanda
            // 
            this.valoresDemanda.HeaderText = "Valores Históricos de Demanda";
            this.valoresDemanda.Name = "valoresDemanda";
            this.valoresDemanda.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.valoresDemanda.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.valoresDemanda.Visible = false;
            // 
            // valoresNuevos
            // 
            this.valoresNuevos.HeaderText = "Valores Históricos de Demanda";
            this.valoresNuevos.Name = "valoresNuevos";
            this.valoresNuevos.Visible = false;
            // 
            // Demanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 271);
            this.Controls.Add(this.dgv_valoresDemanda);
            this.Controls.Add(this.btn_Aceptar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Demanda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demanda";
            this.Load += new System.EventHandler(this.Demanda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_valoresDemanda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaValores;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridView dgv_valoresDemanda;
        private System.Windows.Forms.DataGridViewComboBoxColumn valoresDemanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoresNuevos;
    }
}