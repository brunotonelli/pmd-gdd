namespace PalcoNet.Forms
{
    partial class ComisionesForm
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
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.espectaculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compraModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.botonGenerar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.botonVerFacturas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraModelBindingSource)).BeginInit();
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
            this.fechaDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.empresaDataGridViewTextBoxColumn,
            this.espectaculoDataGridViewTextBoxColumn});
            this.dataGrid.DataSource = this.compraModelBindingSource;
            this.dataGrid.Location = new System.Drawing.Point(28, 97);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(637, 393);
            this.dataGrid.TabIndex = 3;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empresaDataGridViewTextBoxColumn
            // 
            this.empresaDataGridViewTextBoxColumn.DataPropertyName = "Empresa";
            this.empresaDataGridViewTextBoxColumn.HeaderText = "Empresa";
            this.empresaDataGridViewTextBoxColumn.Name = "empresaDataGridViewTextBoxColumn";
            this.empresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // espectaculoDataGridViewTextBoxColumn
            // 
            this.espectaculoDataGridViewTextBoxColumn.DataPropertyName = "Espectaculo";
            this.espectaculoDataGridViewTextBoxColumn.HeaderText = "Espectaculo";
            this.espectaculoDataGridViewTextBoxColumn.Name = "espectaculoDataGridViewTextBoxColumn";
            this.espectaculoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // compraModelBindingSource
            // 
            this.compraModelBindingSource.DataSource = typeof(PalcoNet.Model.CompraModel);
            // 
            // botonGenerar
            // 
            this.botonGenerar.Location = new System.Drawing.Point(700, 295);
            this.botonGenerar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botonGenerar.Name = "botonGenerar";
            this.botonGenerar.Size = new System.Drawing.Size(321, 194);
            this.botonGenerar.TabIndex = 4;
            this.botonGenerar.Text = "Generar Factura";
            this.botonGenerar.UseVisualStyleBackColor = true;
            this.botonGenerar.Click += new System.EventHandler(this.botonGenerar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Puede seleccionar varias compras y facturarlas al mismo tiempo";
            // 
            // botonVerFacturas
            // 
            this.botonVerFacturas.Location = new System.Drawing.Point(700, 97);
            this.botonVerFacturas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botonVerFacturas.Name = "botonVerFacturas";
            this.botonVerFacturas.Size = new System.Drawing.Size(321, 84);
            this.botonVerFacturas.TabIndex = 6;
            this.botonVerFacturas.Text = "Ver Facturas";
            this.botonVerFacturas.UseVisualStyleBackColor = true;
            this.botonVerFacturas.Click += new System.EventHandler(this.botonVerFacturas_Click);
            // 
            // ComisionesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 505);
            this.Controls.Add(this.botonVerFacturas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonGenerar);
            this.Controls.Add(this.dataGrid);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ComisionesForm";
            this.Text = "ComisionesForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ComisionesForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn espectaculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource compraModelBindingSource;
        private System.Windows.Forms.Button botonGenerar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonVerFacturas;
    }
}