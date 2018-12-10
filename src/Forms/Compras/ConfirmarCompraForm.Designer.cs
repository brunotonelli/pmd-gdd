namespace PalcoNet.Forms
{
    partial class ConfirmarCompraForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
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
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.boxFecha = new System.Windows.Forms.DateTimePicker();
            this.boxFormaPago = new System.Windows.Forms.ComboBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceUbicaciones = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.botonConfirmar = new System.Windows.Forms.Button();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.gridSeleccionados = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceSeleccionados = new System.Windows.Forms.BindingSource(this.components);
            this.botonSeleccionar = new System.Windows.Forms.Button();
            this.botonDeseleccionar = new System.Windows.Forms.Button();
            this.labelPuntos2 = new System.Windows.Forms.Label();
            this.labelPuntos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceUbicaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSeleccionados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceSeleccionados)).BeginInit();
            this.SuspendLayout();
            // 
            // boxFecha
            // 
            this.boxFecha.Enabled = false;
            this.boxFecha.Location = new System.Drawing.Point(108, 22);
            this.boxFecha.Name = "boxFecha";
            this.boxFecha.Size = new System.Drawing.Size(200, 20);
            this.boxFecha.TabIndex = 0;
            // 
            // boxFormaPago
            // 
            this.boxFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxFormaPago.FormattingEnabled = true;
            this.boxFormaPago.Items.AddRange(new object[] {
            "Efectivo",
            "Crédito",
            "Cheque"});
            this.boxFormaPago.Location = new System.Drawing.Point(108, 60);
            this.boxFormaPago.Name = "boxFormaPago";
            this.boxFormaPago.Size = new System.Drawing.Size(200, 21);
            this.boxFormaPago.TabIndex = 1;
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeRows = false;
            this.dataGrid.AutoGenerateColumns = false;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.dataGrid.DataSource = this.sourceUbicaciones;
            this.dataGrid.Location = new System.Drawing.Point(12, 99);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(342, 218);
            this.dataGrid.TabIndex = 3;
            this.dataGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGrid_DataBindingComplete);
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Fila";
            this.dataGridViewTextBoxColumn11.HeaderText = "Fila";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Asiento";
            this.dataGridViewTextBoxColumn12.HeaderText = "Asiento";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Enumerado";
            this.dataGridViewTextBoxColumn13.HeaderText = "Enumerado";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Precio";
            this.dataGridViewTextBoxColumn14.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Tipo";
            this.dataGridViewTextBoxColumn15.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // sourceUbicaciones
            // 
            this.sourceUbicaciones.DataSource = typeof(PalcoNet.Model.UbicacionModel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha de compra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Forma de pago";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(314, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cantidad seleccionada:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(314, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total:";
            // 
            // botonConfirmar
            // 
            this.botonConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonConfirmar.Location = new System.Drawing.Point(593, 19);
            this.botonConfirmar.Name = "botonConfirmar";
            this.botonConfirmar.Size = new System.Drawing.Size(178, 66);
            this.botonConfirmar.TabIndex = 8;
            this.botonConfirmar.Text = "COMPRAR";
            this.botonConfirmar.UseVisualStyleBackColor = true;
            this.botonConfirmar.Click += new System.EventHandler(this.botonConfirmar_Click);
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidad.ForeColor = System.Drawing.Color.Maroon;
            this.labelCantidad.Location = new System.Drawing.Point(526, 19);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(20, 24);
            this.labelCantidad.TabIndex = 9;
            this.labelCantidad.Text = "0";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.Maroon;
            this.labelTotal.Location = new System.Drawing.Point(375, 55);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(60, 24);
            this.labelTotal.TabIndex = 10;
            this.labelTotal.Text = "$ 0,00";
            // 
            // gridSeleccionados
            // 
            this.gridSeleccionados.AllowUserToAddRows = false;
            this.gridSeleccionados.AllowUserToDeleteRows = false;
            this.gridSeleccionados.AllowUserToResizeRows = false;
            this.gridSeleccionados.AutoGenerateColumns = false;
            this.gridSeleccionados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridSeleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSeleccionados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20});
            this.gridSeleccionados.DataSource = this.sourceSeleccionados;
            this.gridSeleccionados.Location = new System.Drawing.Point(429, 99);
            this.gridSeleccionados.MultiSelect = false;
            this.gridSeleccionados.Name = "gridSeleccionados";
            this.gridSeleccionados.ReadOnly = true;
            this.gridSeleccionados.RowHeadersVisible = false;
            this.gridSeleccionados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSeleccionados.Size = new System.Drawing.Size(342, 218);
            this.gridSeleccionados.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Fila";
            this.dataGridViewTextBoxColumn16.HeaderText = "Fila";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Asiento";
            this.dataGridViewTextBoxColumn17.HeaderText = "Asiento";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Enumerado";
            this.dataGridViewTextBoxColumn18.HeaderText = "Enumerado";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Precio";
            this.dataGridViewTextBoxColumn19.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Tipo";
            this.dataGridViewTextBoxColumn20.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // sourceSeleccionados
            // 
            this.sourceSeleccionados.DataSource = typeof(PalcoNet.Model.UbicacionModel);
            // 
            // botonSeleccionar
            // 
            this.botonSeleccionar.BackgroundImage = global::PalcoNet.Properties.Resources.flechaDer;
            this.botonSeleccionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonSeleccionar.Enabled = false;
            this.botonSeleccionar.Location = new System.Drawing.Point(360, 99);
            this.botonSeleccionar.Name = "botonSeleccionar";
            this.botonSeleccionar.Size = new System.Drawing.Size(63, 34);
            this.botonSeleccionar.TabIndex = 12;
            this.botonSeleccionar.UseVisualStyleBackColor = true;
            this.botonSeleccionar.Click += new System.EventHandler(this.botonSeleccionar_Click);
            // 
            // botonDeseleccionar
            // 
            this.botonDeseleccionar.BackgroundImage = global::PalcoNet.Properties.Resources.flechaIzq;
            this.botonDeseleccionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonDeseleccionar.Enabled = false;
            this.botonDeseleccionar.Location = new System.Drawing.Point(360, 139);
            this.botonDeseleccionar.Name = "botonDeseleccionar";
            this.botonDeseleccionar.Size = new System.Drawing.Size(63, 35);
            this.botonDeseleccionar.TabIndex = 13;
            this.botonDeseleccionar.UseVisualStyleBackColor = true;
            this.botonDeseleccionar.Click += new System.EventHandler(this.botonDeseleccionar_Click);
            // 
            // labelPuntos2
            // 
            this.labelPuntos2.AutoSize = true;
            this.labelPuntos2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPuntos2.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelPuntos2.Location = new System.Drawing.Point(425, 330);
            this.labelPuntos2.Name = "labelPuntos2";
            this.labelPuntos2.Size = new System.Drawing.Size(347, 24);
            this.labelPuntos2.TabIndex = 14;
            this.labelPuntos2.Text = "Esta compra generaría                  puntos";
            this.labelPuntos2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPuntos
            // 
            this.labelPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPuntos.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelPuntos.Location = new System.Drawing.Point(622, 330);
            this.labelPuntos.Name = "labelPuntos";
            this.labelPuntos.Size = new System.Drawing.Size(85, 24);
            this.labelPuntos.TabIndex = 15;
            this.labelPuntos.Text = "0";
            this.labelPuntos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConfirmarCompraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 366);
            this.Controls.Add(this.labelPuntos);
            this.Controls.Add(this.labelPuntos2);
            this.Controls.Add(this.botonDeseleccionar);
            this.Controls.Add(this.botonSeleccionar);
            this.Controls.Add(this.gridSeleccionados);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.botonConfirmar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.boxFormaPago);
            this.Controls.Add(this.boxFecha);
            this.Name = "ConfirmarCompraForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[PalcoNet] - Confirmar compra";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceUbicaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSeleccionados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceSeleccionados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker boxFecha;
        private System.Windows.Forms.ComboBox boxFormaPago;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button botonConfirmar;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.DataGridView gridSeleccionados;
        private System.Windows.Forms.Button botonSeleccionar;
        private System.Windows.Forms.Button botonDeseleccionar;
        private System.Windows.Forms.BindingSource sourceUbicaciones;
        private System.Windows.Forms.BindingSource sourceSeleccionados;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.Label labelPuntos2;
        private System.Windows.Forms.Label labelPuntos;
    }
}