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
            this.ubicacionFilaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubicacionAsientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubicacionSinnumerarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ubicacionPrecioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubicacionTipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BorrarUbicacion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ubicacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boxDescripcion = new System.Windows.Forms.TextBox();
            this.boxFechaPublicacion = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.boxEmpresa = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.boxRubro = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.boxResponsable = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.boxEstado = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.boxGrado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boxDireccion = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkSinEnumerar = new System.Windows.Forms.CheckBox();
            this.boxTipo = new System.Windows.Forms.ComboBox();
            this.boxPrecio = new System.Windows.Forms.TextBox();
            this.boxAsiento = new System.Windows.Forms.TextBox();
            this.boxFila = new System.Windows.Forms.TextBox();
            this.botonAgregarUbicacion = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.botonAgregarFecha = new System.Windows.Forms.Button();
            this.gridFechasHoras = new System.Windows.Forms.DataGridView();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.botonBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.fechaHoraModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.boxFecha = new System.Windows.Forms.DateTimePicker();
            this.boxHora = new System.Windows.Forms.DateTimePicker();
            this.botonGenerar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridUbicaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFechasHoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechaHoraModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridUbicaciones
            // 
            this.gridUbicaciones.AllowUserToAddRows = false;
            this.gridUbicaciones.AllowUserToDeleteRows = false;
            this.gridUbicaciones.AllowUserToResizeRows = false;
            this.gridUbicaciones.AutoGenerateColumns = false;
            this.gridUbicaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridUbicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUbicaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ubicacionFilaDataGridViewTextBoxColumn,
            this.ubicacionAsientoDataGridViewTextBoxColumn,
            this.ubicacionSinnumerarDataGridViewTextBoxColumn,
            this.ubicacionPrecioDataGridViewTextBoxColumn,
            this.ubicacionTipoDataGridViewTextBoxColumn,
            this.BorrarUbicacion});
            this.gridUbicaciones.DataSource = this.ubicacionBindingSource;
            this.gridUbicaciones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridUbicaciones.Location = new System.Drawing.Point(23, 69);
            this.gridUbicaciones.MultiSelect = false;
            this.gridUbicaciones.Name = "gridUbicaciones";
            this.gridUbicaciones.ReadOnly = true;
            this.gridUbicaciones.RowHeadersVisible = false;
            this.gridUbicaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUbicaciones.Size = new System.Drawing.Size(580, 161);
            this.gridUbicaciones.TabIndex = 0;
            this.gridUbicaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUbicaciones_CellContentClick);
            this.gridUbicaciones.SelectionChanged += new System.EventHandler(this.gridUbicaciones_SelectionChanged);
            // 
            // ubicacionFilaDataGridViewTextBoxColumn
            // 
            this.ubicacionFilaDataGridViewTextBoxColumn.DataPropertyName = "Ubicacion_Fila";
            this.ubicacionFilaDataGridViewTextBoxColumn.FillWeight = 95.63452F;
            this.ubicacionFilaDataGridViewTextBoxColumn.HeaderText = "Fila";
            this.ubicacionFilaDataGridViewTextBoxColumn.Name = "ubicacionFilaDataGridViewTextBoxColumn";
            this.ubicacionFilaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ubicacionAsientoDataGridViewTextBoxColumn
            // 
            this.ubicacionAsientoDataGridViewTextBoxColumn.DataPropertyName = "Ubicacion_Asiento";
            this.ubicacionAsientoDataGridViewTextBoxColumn.FillWeight = 95.63452F;
            this.ubicacionAsientoDataGridViewTextBoxColumn.HeaderText = "Asiento";
            this.ubicacionAsientoDataGridViewTextBoxColumn.Name = "ubicacionAsientoDataGridViewTextBoxColumn";
            this.ubicacionAsientoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ubicacionSinnumerarDataGridViewTextBoxColumn
            // 
            this.ubicacionSinnumerarDataGridViewTextBoxColumn.DataPropertyName = "Ubicacion_Sin_numerar";
            this.ubicacionSinnumerarDataGridViewTextBoxColumn.FillWeight = 95.63452F;
            this.ubicacionSinnumerarDataGridViewTextBoxColumn.HeaderText = "Sin enumerar";
            this.ubicacionSinnumerarDataGridViewTextBoxColumn.Name = "ubicacionSinnumerarDataGridViewTextBoxColumn";
            this.ubicacionSinnumerarDataGridViewTextBoxColumn.ReadOnly = true;
            this.ubicacionSinnumerarDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ubicacionSinnumerarDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ubicacionPrecioDataGridViewTextBoxColumn
            // 
            this.ubicacionPrecioDataGridViewTextBoxColumn.DataPropertyName = "Ubicacion_Precio";
            this.ubicacionPrecioDataGridViewTextBoxColumn.FillWeight = 95.63452F;
            this.ubicacionPrecioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.ubicacionPrecioDataGridViewTextBoxColumn.Name = "ubicacionPrecioDataGridViewTextBoxColumn";
            this.ubicacionPrecioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ubicacionTipoDataGridViewTextBoxColumn
            // 
            this.ubicacionTipoDataGridViewTextBoxColumn.DataPropertyName = "Ubicacion_Tipo";
            this.ubicacionTipoDataGridViewTextBoxColumn.FillWeight = 95.63452F;
            this.ubicacionTipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.ubicacionTipoDataGridViewTextBoxColumn.Name = "ubicacionTipoDataGridViewTextBoxColumn";
            this.ubicacionTipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.ubicacionTipoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // BorrarUbicacion
            // 
            this.BorrarUbicacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BorrarUbicacion.DataPropertyName = "BorrarUbicacion";
            this.BorrarUbicacion.FillWeight = 121.8274F;
            this.BorrarUbicacion.HeaderText = "";
            this.BorrarUbicacion.Name = "BorrarUbicacion";
            this.BorrarUbicacion.ReadOnly = true;
            this.BorrarUbicacion.Width = 30;
            // 
            // ubicacionBindingSource
            // 
            this.ubicacionBindingSource.DataSource = typeof(PalcoNet.Ubicacion);
            // 
            // boxDescripcion
            // 
            this.boxDescripcion.Location = new System.Drawing.Point(26, 85);
            this.boxDescripcion.Multiline = true;
            this.boxDescripcion.Name = "boxDescripcion";
            this.boxDescripcion.Size = new System.Drawing.Size(235, 57);
            this.boxDescripcion.TabIndex = 4;
            // 
            // boxFechaPublicacion
            // 
            this.boxFechaPublicacion.Location = new System.Drawing.Point(406, 70);
            this.boxFechaPublicacion.MinDate = new System.DateTime(1754, 1, 1, 0, 0, 0, 0);
            this.boxFechaPublicacion.Name = "boxFechaPublicacion";
            this.boxFechaPublicacion.Size = new System.Drawing.Size(199, 20);
            this.boxFechaPublicacion.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fecha de publicación";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(634, 271);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.boxEmpresa);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.boxRubro);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.boxResponsable);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.boxEstado);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.boxGrado);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.boxDireccion);
            this.tabPage1.Controls.Add(this.boxDescripcion);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.boxFechaPublicacion);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(626, 245);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Publicación";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // boxEmpresa
            // 
            this.boxEmpresa.Enabled = false;
            this.boxEmpresa.Location = new System.Drawing.Point(406, 207);
            this.boxEmpresa.Name = "boxEmpresa";
            this.boxEmpresa.Size = new System.Drawing.Size(199, 20);
            this.boxEmpresa.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(288, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(119, 24);
            this.label14.TabIndex = 21;
            this.label14.Text = "Publicación";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "Espectáculo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 199);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Rubro";
            // 
            // boxRubro
            // 
            this.boxRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxRubro.FormattingEnabled = true;
            this.boxRubro.Location = new System.Drawing.Point(82, 196);
            this.boxRubro.Name = "boxRubro";
            this.boxRubro.Size = new System.Drawing.Size(179, 21);
            this.boxRubro.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Descripción";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(327, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Responsable";
            // 
            // boxResponsable
            // 
            this.boxResponsable.Enabled = false;
            this.boxResponsable.Location = new System.Drawing.Point(406, 181);
            this.boxResponsable.Name = "boxResponsable";
            this.boxResponsable.Size = new System.Drawing.Size(199, 20);
            this.boxResponsable.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(288, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Estado de publicación";
            // 
            // boxEstado
            // 
            this.boxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxEstado.FormattingEnabled = true;
            this.boxEstado.Items.AddRange(new object[] {
            "Borrador",
            "Publicada",
            "Finalizada"});
            this.boxEstado.Location = new System.Drawing.Point(406, 143);
            this.boxEstado.Name = "boxEstado";
            this.boxEstado.Size = new System.Drawing.Size(199, 21);
            this.boxEstado.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(288, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Grado de publicación";
            // 
            // boxGrado
            // 
            this.boxGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxGrado.FormattingEnabled = true;
            this.boxGrado.Location = new System.Drawing.Point(406, 106);
            this.boxGrado.Name = "boxGrado";
            this.boxGrado.Size = new System.Drawing.Size(199, 21);
            this.boxGrado.TabIndex = 11;
            this.boxGrado.SelectedIndexChanged += new System.EventHandler(this.boxGrado_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Dirección";
            // 
            // boxDireccion
            // 
            this.boxDireccion.Location = new System.Drawing.Point(82, 161);
            this.boxDireccion.Name = "boxDireccion";
            this.boxDireccion.Size = new System.Drawing.Size(179, 20);
            this.boxDireccion.TabIndex = 9;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.checkSinEnumerar);
            this.tabPage2.Controls.Add(this.boxTipo);
            this.tabPage2.Controls.Add(this.boxPrecio);
            this.tabPage2.Controls.Add(this.boxAsiento);
            this.tabPage2.Controls.Add(this.boxFila);
            this.tabPage2.Controls.Add(this.botonAgregarUbicacion);
            this.tabPage2.Controls.Add(this.gridUbicaciones);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(626, 245);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ubicaciones";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(187, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Tipo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(121, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Precio ($)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Asiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Fila";
            // 
            // checkSinEnumerar
            // 
            this.checkSinEnumerar.AutoSize = true;
            this.checkSinEnumerar.Checked = true;
            this.checkSinEnumerar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkSinEnumerar.Location = new System.Drawing.Point(291, 46);
            this.checkSinEnumerar.Name = "checkSinEnumerar";
            this.checkSinEnumerar.Size = new System.Drawing.Size(88, 17);
            this.checkSinEnumerar.TabIndex = 22;
            this.checkSinEnumerar.Text = "Sin enumerar";
            this.checkSinEnumerar.UseVisualStyleBackColor = true;
            // 
            // boxTipo
            // 
            this.boxTipo.FormattingEnabled = true;
            this.boxTipo.Items.AddRange(new object[] {
            "Platea Baja",
            "Platea Alta",
            "Cabecera",
            "Vip",
            "Campo",
            "Super PullMan",
            "PullMan",
            "Campo Vip"});
            this.boxTipo.Location = new System.Drawing.Point(190, 42);
            this.boxTipo.Name = "boxTipo";
            this.boxTipo.Size = new System.Drawing.Size(95, 21);
            this.boxTipo.TabIndex = 21;
            this.boxTipo.Text = "Campo";
            // 
            // boxPrecio
            // 
            this.boxPrecio.Location = new System.Drawing.Point(124, 43);
            this.boxPrecio.Name = "boxPrecio";
            this.boxPrecio.Size = new System.Drawing.Size(60, 20);
            this.boxPrecio.TabIndex = 20;
            this.boxPrecio.Text = "100.00";
            // 
            // boxAsiento
            // 
            this.boxAsiento.Location = new System.Drawing.Point(67, 43);
            this.boxAsiento.Name = "boxAsiento";
            this.boxAsiento.Size = new System.Drawing.Size(51, 20);
            this.boxAsiento.TabIndex = 19;
            this.boxAsiento.Text = "1";
            // 
            // boxFila
            // 
            this.boxFila.Location = new System.Drawing.Point(23, 43);
            this.boxFila.Name = "boxFila";
            this.boxFila.Size = new System.Drawing.Size(38, 20);
            this.boxFila.TabIndex = 18;
            this.boxFila.Text = "A";
            // 
            // botonAgregarUbicacion
            // 
            this.botonAgregarUbicacion.Location = new System.Drawing.Point(385, 42);
            this.botonAgregarUbicacion.Name = "botonAgregarUbicacion";
            this.botonAgregarUbicacion.Size = new System.Drawing.Size(65, 21);
            this.botonAgregarUbicacion.TabIndex = 17;
            this.botonAgregarUbicacion.Text = "Agregar";
            this.botonAgregarUbicacion.UseVisualStyleBackColor = true;
            this.botonAgregarUbicacion.Click += new System.EventHandler(this.botonAgregarUbicacion_Click);
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
            this.tabPage3.Size = new System.Drawing.Size(626, 245);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Espectáculos";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            this.gridFechasHoras.Location = new System.Drawing.Point(23, 56);
            this.gridFechasHoras.MultiSelect = false;
            this.gridFechasHoras.Name = "gridFechasHoras";
            this.gridFechasHoras.ReadOnly = true;
            this.gridFechasHoras.RowHeadersVisible = false;
            this.gridFechasHoras.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridFechasHoras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridFechasHoras.Size = new System.Drawing.Size(580, 171);
            this.gridFechasHoras.TabIndex = 12;
            this.gridFechasHoras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridFechasHoras_CellContentClick);
            this.gridFechasHoras.SelectionChanged += new System.EventHandler(this.gridFechasHoras_SelectionChanged);
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
            // botonBorrar
            // 
            this.botonBorrar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.botonBorrar.HeaderText = "";
            this.botonBorrar.Name = "botonBorrar";
            this.botonBorrar.ReadOnly = true;
            this.botonBorrar.Width = 30;
            // 
            // fechaHoraModelBindingSource
            // 
            this.fechaHoraModelBindingSource.DataSource = typeof(PalcoNet.Model.FechaHoraModel);
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
            // botonGenerar
            // 
            this.botonGenerar.Location = new System.Drawing.Point(476, 289);
            this.botonGenerar.Name = "botonGenerar";
            this.botonGenerar.Size = new System.Drawing.Size(166, 34);
            this.botonGenerar.TabIndex = 11;
            this.botonGenerar.Text = "Generar Publicación";
            this.botonGenerar.UseVisualStyleBackColor = true;
            this.botonGenerar.Click += new System.EventHandler(this.botonGenerar_Click);
            // 
            // GenerarPublicacionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 331);
            this.Controls.Add(this.botonGenerar);
            this.Controls.Add(this.tabControl1);
            this.Name = "GenerarPublicacionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[PalcoNet] - Generar Publicación";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GenerarPublicacionForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.gridUbicaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFechasHoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechaHoraModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridUbicaciones;
        private System.Windows.Forms.BindingSource ubicacionBindingSource;
        private System.Windows.Forms.TextBox boxDescripcion;
        private System.Windows.Forms.DateTimePicker boxFechaPublicacion;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.CheckBox checkSinEnumerar;
        private System.Windows.Forms.ComboBox boxTipo;
        private System.Windows.Forms.TextBox boxPrecio;
        private System.Windows.Forms.TextBox boxAsiento;
        private System.Windows.Forms.TextBox boxFila;
        private System.Windows.Forms.Button botonAgregarUbicacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ubicacionFilaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ubicacionAsientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ubicacionSinnumerarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ubicacionPrecioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ubicacionTipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn BorrarUbicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn botonBorrar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox boxResponsable;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox boxEstado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox boxGrado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boxDireccion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox boxRubro;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button botonGenerar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox boxEmpresa;
    }
}