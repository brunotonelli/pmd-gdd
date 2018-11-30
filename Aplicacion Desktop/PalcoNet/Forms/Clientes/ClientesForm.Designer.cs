namespace PalcoNet.Forms
{
    partial class ClientesForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.boxFiltroMail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.boxFiltroDNI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boxFiltroApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boxFiltroNombre = new System.Windows.Forms.TextBox();
            this.botonNuevo = new System.Windows.Forms.Button();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.botonModificar = new System.Windows.Forms.Button();
            this.cliNombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliApellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliDniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliFechaNacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gradoPublicacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradoPublicacionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeRows = false;
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid.AutoGenerateColumns = false;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cliNombreDataGridViewTextBoxColumn,
            this.cliApellidoDataGridViewTextBoxColumn,
            this.cliDniDataGridViewTextBoxColumn,
            this.cliFechaNacDataGridViewTextBoxColumn,
            this.cliMailDataGridViewTextBoxColumn});
            this.dataGrid.DataSource = this.clienteBindingSource;
            this.dataGrid.Location = new System.Drawing.Point(12, 189);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(492, 249);
            this.dataGrid.TabIndex = 1;
            this.dataGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGrid_DataBindingComplete);
            this.dataGrid.SelectionChanged += new System.EventHandler(this.dataGrid_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.botonLimpiar);
            this.groupBox1.Controls.Add(this.botonBuscar);
            this.groupBox1.Controls.Add(this.boxFiltroMail);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.boxFiltroDNI);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.boxFiltroApellido);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.boxFiltroNombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 156);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de búsqueda";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mail";
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(96, 115);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.botonLimpiar.TabIndex = 3;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(177, 115);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(75, 23);
            this.botonBuscar.TabIndex = 4;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // boxFiltroMail
            // 
            this.boxFiltroMail.Location = new System.Drawing.Point(231, 72);
            this.boxFiltroMail.Name = "boxFiltroMail";
            this.boxFiltroMail.Size = new System.Drawing.Size(100, 20);
            this.boxFiltroMail.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "DNI";
            // 
            // boxFiltroDNI
            // 
            this.boxFiltroDNI.Location = new System.Drawing.Point(231, 35);
            this.boxFiltroDNI.Name = "boxFiltroDNI";
            this.boxFiltroDNI.Size = new System.Drawing.Size(100, 20);
            this.boxFiltroDNI.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido";
            // 
            // boxFiltroApellido
            // 
            this.boxFiltroApellido.Location = new System.Drawing.Point(71, 71);
            this.boxFiltroApellido.Name = "boxFiltroApellido";
            this.boxFiltroApellido.Size = new System.Drawing.Size(100, 20);
            this.boxFiltroApellido.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // boxFiltroNombre
            // 
            this.boxFiltroNombre.Location = new System.Drawing.Point(71, 35);
            this.boxFiltroNombre.Name = "boxFiltroNombre";
            this.boxFiltroNombre.Size = new System.Drawing.Size(100, 20);
            this.boxFiltroNombre.TabIndex = 0;
            // 
            // botonNuevo
            // 
            this.botonNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonNuevo.Location = new System.Drawing.Point(381, 23);
            this.botonNuevo.Name = "botonNuevo";
            this.botonNuevo.Size = new System.Drawing.Size(123, 34);
            this.botonNuevo.TabIndex = 5;
            this.botonNuevo.Text = "Nuevo";
            this.botonNuevo.UseVisualStyleBackColor = true;
            this.botonNuevo.Click += new System.EventHandler(this.botonNuevo_Click);
            // 
            // botonEliminar
            // 
            this.botonEliminar.Enabled = false;
            this.botonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonEliminar.Location = new System.Drawing.Point(381, 140);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(123, 34);
            this.botonEliminar.TabIndex = 7;
            this.botonEliminar.Text = "Eliminar";
            this.botonEliminar.UseVisualStyleBackColor = true;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // botonModificar
            // 
            this.botonModificar.Enabled = false;
            this.botonModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonModificar.Location = new System.Drawing.Point(381, 82);
            this.botonModificar.Name = "botonModificar";
            this.botonModificar.Size = new System.Drawing.Size(123, 34);
            this.botonModificar.TabIndex = 8;
            this.botonModificar.Text = "Modificar";
            this.botonModificar.UseVisualStyleBackColor = true;
            this.botonModificar.Click += new System.EventHandler(this.botonModificar_Click);
            // 
            // cliNombreDataGridViewTextBoxColumn
            // 
            this.cliNombreDataGridViewTextBoxColumn.DataPropertyName = "Cli_Nombre";
            this.cliNombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.cliNombreDataGridViewTextBoxColumn.Name = "cliNombreDataGridViewTextBoxColumn";
            this.cliNombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cliApellidoDataGridViewTextBoxColumn
            // 
            this.cliApellidoDataGridViewTextBoxColumn.DataPropertyName = "Cli_Apellido";
            this.cliApellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.cliApellidoDataGridViewTextBoxColumn.Name = "cliApellidoDataGridViewTextBoxColumn";
            this.cliApellidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cliDniDataGridViewTextBoxColumn
            // 
            this.cliDniDataGridViewTextBoxColumn.DataPropertyName = "Cli_Nro_Doc";
            this.cliDniDataGridViewTextBoxColumn.HeaderText = "Documento";
            this.cliDniDataGridViewTextBoxColumn.Name = "cliDniDataGridViewTextBoxColumn";
            this.cliDniDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cliFechaNacDataGridViewTextBoxColumn
            // 
            this.cliFechaNacDataGridViewTextBoxColumn.DataPropertyName = "Cli_Fecha_Nac";
            this.cliFechaNacDataGridViewTextBoxColumn.HeaderText = "Fecha de nacimiento";
            this.cliFechaNacDataGridViewTextBoxColumn.Name = "cliFechaNacDataGridViewTextBoxColumn";
            this.cliFechaNacDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cliMailDataGridViewTextBoxColumn
            // 
            this.cliMailDataGridViewTextBoxColumn.DataPropertyName = "Cli_Mail";
            this.cliMailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.cliMailDataGridViewTextBoxColumn.Name = "cliMailDataGridViewTextBoxColumn";
            this.cliMailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(PalcoNet.Cliente);
            // 
            // gradoPublicacionBindingSource
            // 
            this.gradoPublicacionBindingSource.DataSource = typeof(PalcoNet.Grado_Publicacion);
            // 
            // ClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 450);
            this.Controls.Add(this.botonModificar);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.botonNuevo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGrid);
            this.Name = "ClientesForm";
            this.Text = "ClientesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradoPublicacionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.TextBox boxFiltroMail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox boxFiltroDNI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boxFiltroApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxFiltroNombre;
        private System.Windows.Forms.Button botonNuevo;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.Button botonModificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliApellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliDniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliFechaNacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource gradoPublicacionBindingSource;
    }
}