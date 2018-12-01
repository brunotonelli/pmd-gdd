namespace PalcoNet.Forms
{
    partial class FacturasForm
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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.facturaNroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturaFechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturaTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturaPublicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.botonDetalles = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.facturaNroDataGridViewTextBoxColumn,
            this.facturaFechaDataGridViewTextBoxColumn,
            this.facturaTotalDataGridViewTextBoxColumn,
            this.facturaPublicacionDataGridViewTextBoxColumn});
            this.dataGrid.DataSource = this.facturaBindingSource;
            this.dataGrid.Location = new System.Drawing.Point(12, 32);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(569, 241);
            this.dataGrid.TabIndex = 4;
            // 
            // facturaNroDataGridViewTextBoxColumn
            // 
            this.facturaNroDataGridViewTextBoxColumn.DataPropertyName = "Factura_Nro";
            this.facturaNroDataGridViewTextBoxColumn.HeaderText = "Factura";
            this.facturaNroDataGridViewTextBoxColumn.Name = "facturaNroDataGridViewTextBoxColumn";
            this.facturaNroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // facturaFechaDataGridViewTextBoxColumn
            // 
            this.facturaFechaDataGridViewTextBoxColumn.DataPropertyName = "Factura_Fecha";
            this.facturaFechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.facturaFechaDataGridViewTextBoxColumn.Name = "facturaFechaDataGridViewTextBoxColumn";
            this.facturaFechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // facturaTotalDataGridViewTextBoxColumn
            // 
            this.facturaTotalDataGridViewTextBoxColumn.DataPropertyName = "Factura_Total";
            this.facturaTotalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.facturaTotalDataGridViewTextBoxColumn.Name = "facturaTotalDataGridViewTextBoxColumn";
            this.facturaTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // facturaPublicacionDataGridViewTextBoxColumn
            // 
            this.facturaPublicacionDataGridViewTextBoxColumn.DataPropertyName = "Factura_Publicacion";
            this.facturaPublicacionDataGridViewTextBoxColumn.HeaderText = "Publicación";
            this.facturaPublicacionDataGridViewTextBoxColumn.Name = "facturaPublicacionDataGridViewTextBoxColumn";
            this.facturaPublicacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // facturaBindingSource
            // 
            this.facturaBindingSource.DataSource = typeof(PalcoNet.Factura);
            // 
            // botonDetalles
            // 
            this.botonDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDetalles.Location = new System.Drawing.Point(441, 279);
            this.botonDetalles.Name = "botonDetalles";
            this.botonDetalles.Size = new System.Drawing.Size(140, 38);
            this.botonDetalles.TabIndex = 5;
            this.botonDetalles.Text = "Detalles";
            this.botonDetalles.UseVisualStyleBackColor = true;
            this.botonDetalles.Click += new System.EventHandler(this.botonDetalles_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seleccione la factura:";
            // 
            // FacturasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 328);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonDetalles);
            this.Controls.Add(this.dataGrid);
            this.Name = "FacturasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[PalcoNet] - Ver Facturas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn facturaNroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facturaFechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facturaTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facturaPublicacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource facturaBindingSource;
        private System.Windows.Forms.Button botonDetalles;
        private System.Windows.Forms.Label label1;
    }
}