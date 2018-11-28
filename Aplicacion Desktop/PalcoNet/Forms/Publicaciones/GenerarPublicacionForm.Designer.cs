namespace PalcoNet.Forms
{
    partial class GenerarPublicacionForm
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
            this.gridUbicaciones = new System.Windows.Forms.DataGridView();
            this.botonAgregarUbicacion = new System.Windows.Forms.Button();
            this.botonEliminarUbicacion = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.boxFechaPublicacion = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.boxFecha = new System.Windows.Forms.DateTimePicker();
            this.boxHora = new System.Windows.Forms.DateTimePicker();
            this.gridFechasHoras = new System.Windows.Forms.DataGridView();
            this.botonAgregarFecha = new System.Windows.Forms.Button();
            this.botonBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ubicacionFilaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubicacionAsientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubicacionSinnumerarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ubicacionPrecioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubicacionTipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ubicacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaHoraModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridUbicaciones)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFechasHoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechaHoraModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridUbicaciones
            // 
            this.gridUbicaciones.AllowUserToAddRows = false;
            this.gridUbicaciones.AllowUserToDeleteRows = false;
            this.gridUbicaciones.AutoGenerateColumns = false;
            this.gridUbicaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridUbicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUbicaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ubicacionFilaDataGridViewTextBoxColumn,
            this.ubicacionAsientoDataGridViewTextBoxColumn,
            this.ubicacionSinnumerarDataGridViewTextBoxColumn,
            this.ubicacionPrecioDataGridViewTextBoxColumn,
            this.ubicacionTipoDataGridViewTextBoxColumn});
            this.gridUbicaciones.DataSource = this.ubicacionBindingSource;
            this.gridUbicaciones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gridUbicaciones.Location = new System.Drawing.Point(17, 61);
            this.gridUbicaciones.Name = "gridUbicaciones";
            this.gridUbicaciones.RowHeadersVisible = false;
            this.gridUbicaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUbicaciones.Size = new System.Drawing.Size(505, 150);
            this.gridUbicaciones.TabIndex = 0;
            this.gridUbicaciones.SelectionChanged += new System.EventHandler(this.gridUbicaciones_SelectionChanged);
            // 
            // botonAgregarUbicacion
            // 
            this.botonAgregarUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAgregarUbicacion.ForeColor = System.Drawing.Color.Green;
            this.botonAgregarUbicacion.Location = new System.Drawing.Point(17, 15);
            this.botonAgregarUbicacion.Name = "botonAgregarUbicacion";
            this.botonAgregarUbicacion.Size = new System.Drawing.Size(43, 40);
            this.botonAgregarUbicacion.TabIndex = 1;
            this.botonAgregarUbicacion.Text = "+";
            this.botonAgregarUbicacion.UseVisualStyleBackColor = true;
            this.botonAgregarUbicacion.Click += new System.EventHandler(this.botonAgregarUbicacion_Click);
            // 
            // botonEliminarUbicacion
            // 
            this.botonEliminarUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonEliminarUbicacion.ForeColor = System.Drawing.Color.Red;
            this.botonEliminarUbicacion.Location = new System.Drawing.Point(66, 15);
            this.botonEliminarUbicacion.Name = "botonEliminarUbicacion";
            this.botonEliminarUbicacion.Size = new System.Drawing.Size(45, 40);
            this.botonEliminarUbicacion.TabIndex = 2;
            this.botonEliminarUbicacion.Text = "-";
            this.botonEliminarUbicacion.UseVisualStyleBackColor = true;
            this.botonEliminarUbicacion.Click += new System.EventHandler(this.botonEliminarUbicacion_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 28);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 95);
            this.textBox1.TabIndex = 4;
            // 
            // boxFechaPublicacion
            // 
            this.boxFechaPublicacion.Location = new System.Drawing.Point(133, 163);
            this.boxFechaPublicacion.MinDate = new System.DateTime(2018, 11, 27, 0, 0, 0, 0);
            this.boxFechaPublicacion.Name = "boxFechaPublicacion";
            this.boxFechaPublicacion.Size = new System.Drawing.Size(200, 20);
            this.boxFechaPublicacion.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(134, 198);
            this.dateTimePicker1.MinDate = new System.DateTime(2018, 11, 27, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(199, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(340, 198);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(67, 20);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-19, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fecha y hora del espectáculo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fecha y hora del espectáculo";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(658, 310);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.boxFechaPublicacion);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.dateTimePicker2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(650, 284);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Publicación";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.botonAgregarUbicacion);
            this.tabPage2.Controls.Add(this.gridUbicaciones);
            this.tabPage2.Controls.Add(this.botonEliminarUbicacion);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(650, 284);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ubicaciones";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.botonAgregarFecha);
            this.tabPage3.Controls.Add(this.gridFechasHoras);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.boxFecha);
            this.tabPage3.Controls.Add(this.boxHora);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(650, 284);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Espectáculos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nueva fecha/hora";
            // 
            // boxFecha
            // 
            this.boxFecha.Location = new System.Drawing.Point(121, 22);
            this.boxFecha.MinDate = new System.DateTime(2018, 11, 27, 0, 0, 0, 0);
            this.boxFecha.Name = "boxFecha";
            this.boxFecha.Size = new System.Drawing.Size(199, 20);
            this.boxFecha.TabIndex = 9;
            // 
            // boxHora
            // 
            this.boxHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.boxHora.Location = new System.Drawing.Point(327, 22);
            this.boxHora.Name = "boxHora";
            this.boxHora.Size = new System.Drawing.Size(67, 20);
            this.boxHora.TabIndex = 10;
            // 
            // gridFechasHoras
            // 
            this.gridFechasHoras.AllowUserToAddRows = false;
            this.gridFechasHoras.AllowUserToDeleteRows = false;
            this.gridFechasHoras.AllowUserToResizeRows = false;
            this.gridFechasHoras.AutoGenerateColumns = false;
            this.gridFechasHoras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridFechasHoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFechasHoras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaDataGridViewTextBoxColumn,
            this.horaDataGridViewTextBoxColumn,
            this.botonBorrar});
            this.gridFechasHoras.DataSource = this.fechaHoraModelBindingSource;
            this.gridFechasHoras.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridFechasHoras.Location = new System.Drawing.Point(23, 59);
            this.gridFechasHoras.MultiSelect = false;
            this.gridFechasHoras.Name = "gridFechasHoras";
            this.gridFechasHoras.ReadOnly = true;
            this.gridFechasHoras.RowHeadersVisible = false;
            this.gridFechasHoras.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridFechasHoras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridFechasHoras.Size = new System.Drawing.Size(442, 150);
            this.gridFechasHoras.TabIndex = 12;
            this.gridFechasHoras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridFechasHoras_CellContentClick);
            this.gridFechasHoras.SelectionChanged += new System.EventHandler(this.gridFechasHoras_SelectionChanged);
            // 
            // botonAgregarFecha
            // 
            this.botonAgregarFecha.Location = new System.Drawing.Point(400, 21);
            this.botonAgregarFecha.Name = "botonAgregarFecha";
            this.botonAgregarFecha.Size = new System.Drawing.Size(65, 21);
            this.botonAgregarFecha.TabIndex = 13;
            this.botonAgregarFecha.Text = "Agregar";
            this.botonAgregarFecha.UseVisualStyleBackColor = true;
            this.botonAgregarFecha.Click += new System.EventHandler(this.botonAgregarFecha_Click);
            // 
            // botonBorrar
            // 
            this.botonBorrar.HeaderText = "Borrar";
            this.botonBorrar.Name = "botonBorrar";
            this.botonBorrar.ReadOnly = true;
            // 
            // ubicacionFilaDataGridViewTextBoxColumn
            // 
            this.ubicacionFilaDataGridViewTextBoxColumn.DataPropertyName = "Ubicacion_Fila";
            this.ubicacionFilaDataGridViewTextBoxColumn.HeaderText = "Ubicacion_Fila";
            this.ubicacionFilaDataGridViewTextBoxColumn.Name = "ubicacionFilaDataGridViewTextBoxColumn";
            // 
            // ubicacionAsientoDataGridViewTextBoxColumn
            // 
            this.ubicacionAsientoDataGridViewTextBoxColumn.DataPropertyName = "Ubicacion_Asiento";
            this.ubicacionAsientoDataGridViewTextBoxColumn.HeaderText = "Ubicacion_Asiento";
            this.ubicacionAsientoDataGridViewTextBoxColumn.Name = "ubicacionAsientoDataGridViewTextBoxColumn";
            // 
            // ubicacionSinnumerarDataGridViewTextBoxColumn
            // 
            this.ubicacionSinnumerarDataGridViewTextBoxColumn.DataPropertyName = "Ubicacion_Sin_numerar";
            this.ubicacionSinnumerarDataGridViewTextBoxColumn.HeaderText = "Ubicacion_Sin_numerar";
            this.ubicacionSinnumerarDataGridViewTextBoxColumn.Name = "ubicacionSinnumerarDataGridViewTextBoxColumn";
            this.ubicacionSinnumerarDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ubicacionSinnumerarDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ubicacionPrecioDataGridViewTextBoxColumn
            // 
            this.ubicacionPrecioDataGridViewTextBoxColumn.DataPropertyName = "Ubicacion_Precio";
            this.ubicacionPrecioDataGridViewTextBoxColumn.HeaderText = "Ubicacion_Precio";
            this.ubicacionPrecioDataGridViewTextBoxColumn.Name = "ubicacionPrecioDataGridViewTextBoxColumn";
            // 
            // ubicacionTipoDataGridViewTextBoxColumn
            // 
            this.ubicacionTipoDataGridViewTextBoxColumn.DataPropertyName = "Ubicacion_Tipo";
            this.ubicacionTipoDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.ubicacionTipoDataGridViewTextBoxColumn.HeaderText = "Ubicacion_Tipo";
            this.ubicacionTipoDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "Platea Baja",
            "Platea Alta",
            "Cabecera",
            "Vip",
            "Campo",
            "Super PullMan",
            "PullMan",
            "Campo Vip"});
            this.ubicacionTipoDataGridViewTextBoxColumn.Name = "ubicacionTipoDataGridViewTextBoxColumn";
            this.ubicacionTipoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ubicacionTipoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ubicacionBindingSource
            // 
            this.ubicacionBindingSource.DataSource = typeof(PalcoNet.Ubicacion);
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horaDataGridViewTextBoxColumn
            // 
            this.horaDataGridViewTextBoxColumn.DataPropertyName = "Hora";
            this.horaDataGridViewTextBoxColumn.HeaderText = "Hora";
            this.horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
            this.horaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaHoraModelBindingSource
            // 
            this.fechaHoraModelBindingSource.DataSource = typeof(PalcoNet.Model.FechaHoraModel);
            // 
            // GenerarPublicacionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 518);
            this.Controls.Add(this.tabControl1);
            this.Name = "GenerarPublicacionForm";
            this.Text = "GenerarPublicacionForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridUbicaciones)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFechasHoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechaHoraModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridUbicaciones;
        private System.Windows.Forms.BindingSource ubicacionBindingSource;
        private System.Windows.Forms.Button botonAgregarUbicacion;
        private System.Windows.Forms.Button botonEliminarUbicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ubicacionFilaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ubicacionAsientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ubicacionSinnumerarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ubicacionPrecioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ubicacionTipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker boxFechaPublicacion;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView gridFechasHoras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker boxFecha;
        private System.Windows.Forms.DateTimePicker boxHora;
        private System.Windows.Forms.Button botonAgregarFecha;
        private System.Windows.Forms.BindingSource fechaHoraModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn botonBorrar;
    }
}