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
            this.facturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturaNroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturaFechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturaTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturaPublicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.botonDetalles = new System.Windows.Forms.Button();
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
            this.dataGrid.Location = new System.Drawing.Point(12, 88);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(569, 319);
            this.dataGrid.TabIndex = 4;
            // 
            // facturaBindingSource
            // 
            this.facturaBindingSource.DataSource = typeof(PalcoNet.Factura);
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
            // botonDetalles
            // 
            this.botonDetalles.Location = new System.Drawing.Point(615, 88);
            this.botonDetalles.Name = "botonDetalles";
            this.botonDetalles.Size = new System.Drawing.Size(75, 23);
            this.botonDetalles.TabIndex = 5;
            this.botonDetalles.Text = "Detalles";
            this.botonDetalles.UseVisualStyleBackColor = true;
            this.botonDetalles.Click += new System.EventHandler(this.botonDetalles_Click);
            // 
            // FacturasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonDetalles);
            this.Controls.Add(this.dataGrid);
            this.Name = "FacturasForm";
            this.Text = "FacturasForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn facturaNroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facturaFechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facturaTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facturaPublicacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource facturaBindingSource;
        private System.Windows.Forms.Button botonDetalles;
    }
}