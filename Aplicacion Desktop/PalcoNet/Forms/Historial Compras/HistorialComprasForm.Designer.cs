namespace PalcoNet.Forms
{
    partial class HistorialComprasForm
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
            this.labelPagina = new System.Windows.Forms.Label();
            this.botonAnterior = new System.Windows.Forms.Button();
            this.botonSiguiente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.espectaculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formaPagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historialModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPagina
            // 
            this.labelPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPagina.Location = new System.Drawing.Point(151, 267);
            this.labelPagina.Name = "labelPagina";
            this.labelPagina.Size = new System.Drawing.Size(249, 34);
            this.labelPagina.TabIndex = 9;
            this.labelPagina.Text = "Página X de Y";
            this.labelPagina.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // botonAnterior
            // 
            this.botonAnterior.BackgroundImage = global::PalcoNet.Properties.Resources.flechaIzq;
            this.botonAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonAnterior.Location = new System.Drawing.Point(70, 267);
            this.botonAnterior.Name = "botonAnterior";
            this.botonAnterior.Size = new System.Drawing.Size(75, 36);
            this.botonAnterior.TabIndex = 8;
            this.botonAnterior.UseVisualStyleBackColor = true;
            this.botonAnterior.Click += new System.EventHandler(this.botonAnterior_Click);
            // 
            // botonSiguiente
            // 
            this.botonSiguiente.BackgroundImage = global::PalcoNet.Properties.Resources.flechaDer;
            this.botonSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonSiguiente.Location = new System.Drawing.Point(406, 267);
            this.botonSiguiente.Name = "botonSiguiente";
            this.botonSiguiente.Size = new System.Drawing.Size(75, 36);
            this.botonSiguiente.TabIndex = 7;
            this.botonSiguiente.UseVisualStyleBackColor = true;
            this.botonAnterior.Click += new System.EventHandler(this.botonSiguiente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Compras realizadas:";
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
            this.fechaDataGridViewTextBoxColumn,
            this.espectaculoDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.formaPagoDataGridViewTextBoxColumn});
            this.dataGrid.DataSource = this.historialModelBindingSource;
            this.dataGrid.Location = new System.Drawing.Point(16, 35);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(505, 219);
            this.dataGrid.TabIndex = 2;
            this.dataGrid.SelectionChanged += new System.EventHandler(this.dataGrid_SelectionChanged);
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // espectaculoDataGridViewTextBoxColumn
            // 
            this.espectaculoDataGridViewTextBoxColumn.DataPropertyName = "Espectaculo";
            this.espectaculoDataGridViewTextBoxColumn.HeaderText = "Espectaculo";
            this.espectaculoDataGridViewTextBoxColumn.Name = "espectaculoDataGridViewTextBoxColumn";
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // formaPagoDataGridViewTextBoxColumn
            // 
            this.formaPagoDataGridViewTextBoxColumn.DataPropertyName = "FormaPago";
            this.formaPagoDataGridViewTextBoxColumn.HeaderText = "FormaPago";
            this.formaPagoDataGridViewTextBoxColumn.Name = "formaPagoDataGridViewTextBoxColumn";
            // 
            // historialModelBindingSource
            // 
            this.historialModelBindingSource.DataSource = typeof(PalcoNet.Model.HistorialModel);
            // 
            // HistorialComprasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 323);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelPagina);
            this.Controls.Add(this.botonAnterior);
            this.Controls.Add(this.botonSiguiente);
            this.Name = "HistorialComprasForm";
            this.Text = "[PalcoNet] - Historial de Compras";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.Load += new System.EventHandler(this.HistorialComprasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.historialModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPagina;
        private System.Windows.Forms.Button botonAnterior;
        private System.Windows.Forms.Button botonSiguiente;
        private System.Windows.Forms.BindingSource historialModelBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn espectaculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formaPagoDataGridViewTextBoxColumn;
    }
}