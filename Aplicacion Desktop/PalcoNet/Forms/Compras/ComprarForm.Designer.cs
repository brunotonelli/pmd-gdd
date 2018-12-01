namespace PalcoNet.Forms
{
    partial class ComprarForm
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
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rubroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Localidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPublicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RangoFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publicacionModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.botonAnterior = new System.Windows.Forms.Button();
            this.labelPagina = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkFecha = new System.Windows.Forms.CheckBox();
            this.listBoxRubros = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boxFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.boxFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.boxDescripcion = new System.Windows.Forms.TextBox();
            this.botonComprar = new System.Windows.Forms.Button();
            this.botonSiguiente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicacionModelBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.nombreDataGridViewTextBoxColumn,
            this.rubroDataGridViewTextBoxColumn,
            this.Localidades,
            this.empresaDataGridViewTextBoxColumn,
            this.fechaPublicacionDataGridViewTextBoxColumn,
            this.RangoFecha});
            this.dataGrid.DataSource = this.publicacionModelBindingSource;
            this.dataGrid.Location = new System.Drawing.Point(16, 204);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(939, 303);
            this.dataGrid.TabIndex = 2;
            this.dataGrid.SelectionChanged += new System.EventHandler(this.dataGrid_SelectionChanged);
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rubroDataGridViewTextBoxColumn
            // 
            this.rubroDataGridViewTextBoxColumn.DataPropertyName = "Rubro";
            this.rubroDataGridViewTextBoxColumn.HeaderText = "Rubro";
            this.rubroDataGridViewTextBoxColumn.Name = "rubroDataGridViewTextBoxColumn";
            this.rubroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Localidades
            // 
            this.Localidades.DataPropertyName = "Localidades";
            this.Localidades.HeaderText = "Localidades";
            this.Localidades.Name = "Localidades";
            this.Localidades.ReadOnly = true;
            // 
            // empresaDataGridViewTextBoxColumn
            // 
            this.empresaDataGridViewTextBoxColumn.DataPropertyName = "Empresa";
            this.empresaDataGridViewTextBoxColumn.HeaderText = "Empresa";
            this.empresaDataGridViewTextBoxColumn.Name = "empresaDataGridViewTextBoxColumn";
            this.empresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaPublicacionDataGridViewTextBoxColumn
            // 
            this.fechaPublicacionDataGridViewTextBoxColumn.DataPropertyName = "FechaPublicacion";
            this.fechaPublicacionDataGridViewTextBoxColumn.HeaderText = "FechaPublicacion";
            this.fechaPublicacionDataGridViewTextBoxColumn.Name = "fechaPublicacionDataGridViewTextBoxColumn";
            this.fechaPublicacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // RangoFecha
            // 
            this.RangoFecha.DataPropertyName = "RangoFecha";
            this.RangoFecha.HeaderText = "RangoFecha";
            this.RangoFecha.Name = "RangoFecha";
            this.RangoFecha.ReadOnly = true;
            // 
            // publicacionModelBindingSource
            // 
            this.publicacionModelBindingSource.DataSource = typeof(PalcoNet.Model.PublicacionModel);
            // 
            // botonAnterior
            // 
            this.botonAnterior.BackgroundImage = global::PalcoNet.Properties.Resources.flechaIzq;
            this.botonAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonAnterior.Location = new System.Drawing.Point(225, 519);
            this.botonAnterior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botonAnterior.Name = "botonAnterior";
            this.botonAnterior.Size = new System.Drawing.Size(100, 44);
            this.botonAnterior.TabIndex = 4;
            this.botonAnterior.UseVisualStyleBackColor = true;
            this.botonAnterior.Click += new System.EventHandler(this.botonAnterior_Click);
            // 
            // labelPagina
            // 
            this.labelPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPagina.Location = new System.Drawing.Point(333, 519);
            this.labelPagina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPagina.Name = "labelPagina";
            this.labelPagina.Size = new System.Drawing.Size(332, 42);
            this.labelPagina.TabIndex = 5;
            this.labelPagina.Text = "Página X de Y";
            this.labelPagina.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkFecha);
            this.groupBox1.Controls.Add(this.listBoxRubros);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.boxFechaFinal);
            this.groupBox1.Controls.Add(this.boxFechaInicial);
            this.groupBox1.Controls.Add(this.botonLimpiar);
            this.groupBox1.Controls.Add(this.botonBuscar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.boxDescripcion);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(684, 182);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de búsqueda";
            // 
            // checkFecha
            // 
            this.checkFecha.AutoSize = true;
            this.checkFecha.Location = new System.Drawing.Point(33, 97);
            this.checkFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkFecha.Name = "checkFecha";
            this.checkFecha.Size = new System.Drawing.Size(106, 21);
            this.checkFecha.TabIndex = 12;
            this.checkFecha.Text = "Fecha entre";
            this.checkFecha.UseVisualStyleBackColor = true;
            this.checkFecha.CheckedChanged += new System.EventHandler(this.checkFecha_CheckedChanged);
            // 
            // listBoxRubros
            // 
            this.listBoxRubros.CheckOnClick = true;
            this.listBoxRubros.FormattingEnabled = true;
            this.listBoxRubros.Items.AddRange(new object[] {
            "Rubro1",
            "Rubro2",
            "Rubro3",
            "Rubro4"});
            this.listBoxRubros.Location = new System.Drawing.Point(484, 46);
            this.listBoxRubros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxRubros.Name = "listBoxRubros";
            this.listBoxRubros.ScrollAlwaysVisible = true;
            this.listBoxRubros.Size = new System.Drawing.Size(179, 106);
            this.listBoxRubros.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "y";
            // 
            // boxFechaFinal
            // 
            this.boxFechaFinal.Enabled = false;
            this.boxFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.boxFechaFinal.Location = new System.Drawing.Point(324, 95);
            this.boxFechaFinal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxFechaFinal.Name = "boxFechaFinal";
            this.boxFechaFinal.Size = new System.Drawing.Size(136, 22);
            this.boxFechaFinal.TabIndex = 9;
            // 
            // boxFechaInicial
            // 
            this.boxFechaInicial.Enabled = false;
            this.boxFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.boxFechaInicial.Location = new System.Drawing.Point(152, 95);
            this.boxFechaInicial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxFechaInicial.Name = "boxFechaInicial";
            this.boxFechaInicial.Size = new System.Drawing.Size(136, 22);
            this.boxFechaInicial.TabIndex = 8;
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(32, 138);
            this.botonLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(217, 28);
            this.botonLimpiar.TabIndex = 3;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(257, 138);
            this.botonBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(204, 28);
            this.botonBuscar.TabIndex = 4;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descripción";
            // 
            // boxDescripcion
            // 
            this.boxDescripcion.Location = new System.Drawing.Point(121, 42);
            this.boxDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxDescripcion.Name = "boxDescripcion";
            this.boxDescripcion.Size = new System.Drawing.Size(339, 22);
            this.boxDescripcion.TabIndex = 4;
            // 
            // botonComprar
            // 
            this.botonComprar.BackgroundImage = global::PalcoNet.Properties.Resources.ticket;
            this.botonComprar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonComprar.Enabled = false;
            this.botonComprar.Location = new System.Drawing.Point(708, 21);
            this.botonComprar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botonComprar.Name = "botonComprar";
            this.botonComprar.Size = new System.Drawing.Size(247, 176);
            this.botonComprar.TabIndex = 7;
            this.botonComprar.UseVisualStyleBackColor = true;
            this.botonComprar.Click += new System.EventHandler(this.botonComprar_Click);
            // 
            // botonSiguiente
            // 
            this.botonSiguiente.BackgroundImage = global::PalcoNet.Properties.Resources.flechaDer;
            this.botonSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonSiguiente.Location = new System.Drawing.Point(673, 519);
            this.botonSiguiente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botonSiguiente.Name = "botonSiguiente";
            this.botonSiguiente.Size = new System.Drawing.Size(100, 44);
            this.botonSiguiente.TabIndex = 3;
            this.botonSiguiente.UseVisualStyleBackColor = true;
            this.botonSiguiente.Click += new System.EventHandler(this.botonSiguiente_Click);
            // 
            // ComprarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 575);
            this.Controls.Add(this.botonComprar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelPagina);
            this.Controls.Add(this.botonAnterior);
            this.Controls.Add(this.botonSiguiente);
            this.Controls.Add(this.dataGrid);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ComprarForm";
            this.Text = "++";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ComprarForm_FormClosing);
            this.Load += new System.EventHandler(this.ComprarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicacionModelBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.BindingSource publicacionModelBindingSource;
        private System.Windows.Forms.Button botonSiguiente;
        private System.Windows.Forms.Button botonAnterior;
        private System.Windows.Forms.Label labelPagina;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox listBoxRubros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker boxFechaFinal;
        private System.Windows.Forms.DateTimePicker boxFechaInicial;
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox boxDescripcion;
        private System.Windows.Forms.Button botonComprar;
        private System.Windows.Forms.CheckBox checkFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rubroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Localidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPublicacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RangoFecha;
    }
}