namespace PalcoNet.Forms
{
    partial class EmpresasForm
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
            this.botonModificar = new System.Windows.Forms.Button();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.botonNuevo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.boxFiltroMail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.boxFiltroCUIT = new System.Windows.Forms.TextBox();
            this.boxFiltroRazon = new System.Windows.Forms.TextBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.Espec_Empresa_Dom_Calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Espec_Empresa_Nro_Calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.especEmpresaCuitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especEmpresaRazonSocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especEmpresaMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especEmpresaCodPostalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especEmpresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.especEmpresaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // botonModificar
            // 
            this.botonModificar.Enabled = false;
            this.botonModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonModificar.Location = new System.Drawing.Point(380, 114);
            this.botonModificar.Name = "botonModificar";
            this.botonModificar.Size = new System.Drawing.Size(123, 34);
            this.botonModificar.TabIndex = 14;
            this.botonModificar.Text = "Modificar";
            this.botonModificar.UseVisualStyleBackColor = true;
            this.botonModificar.Click += new System.EventHandler(this.botonModificar_Click);
            // 
            // botonEliminar
            // 
            this.botonEliminar.Enabled = false;
            this.botonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonEliminar.Location = new System.Drawing.Point(379, 172);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(123, 34);
            this.botonEliminar.TabIndex = 13;
            this.botonEliminar.Text = "Eliminar";
            this.botonEliminar.UseVisualStyleBackColor = true;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // botonNuevo
            // 
            this.botonNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonNuevo.Location = new System.Drawing.Point(380, 55);
            this.botonNuevo.Name = "botonNuevo";
            this.botonNuevo.Size = new System.Drawing.Size(123, 34);
            this.botonNuevo.TabIndex = 11;
            this.botonNuevo.Text = "Nuevo";
            this.botonNuevo.UseVisualStyleBackColor = true;
            this.botonNuevo.Click += new System.EventHandler(this.botonNuevo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.botonLimpiar);
            this.groupBox1.Controls.Add(this.botonBuscar);
            this.groupBox1.Controls.Add(this.boxFiltroMail);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.boxFiltroCUIT);
            this.groupBox1.Controls.Add(this.boxFiltroRazon);
            this.groupBox1.Location = new System.Drawing.Point(11, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 156);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de búsqueda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Razon Social";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(119, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Mail";
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(95, 115);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.botonLimpiar.TabIndex = 3;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(190, 115);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(75, 23);
            this.botonBuscar.TabIndex = 4;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // boxFiltroMail
            // 
            this.boxFiltroMail.Location = new System.Drawing.Point(151, 84);
            this.boxFiltroMail.Name = "boxFiltroMail";
            this.boxFiltroMail.Size = new System.Drawing.Size(100, 20);
            this.boxFiltroMail.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "CUIT";
            // 
            // boxFiltroCUIT
            // 
            this.boxFiltroCUIT.Location = new System.Drawing.Point(151, 51);
            this.boxFiltroCUIT.Name = "boxFiltroCUIT";
            this.boxFiltroCUIT.Size = new System.Drawing.Size(100, 20);
            this.boxFiltroCUIT.TabIndex = 2;
            // 
            // boxFiltroRazon
            // 
            this.boxFiltroRazon.Location = new System.Drawing.Point(151, 19);
            this.boxFiltroRazon.Name = "boxFiltroRazon";
            this.boxFiltroRazon.Size = new System.Drawing.Size(100, 20);
            this.boxFiltroRazon.TabIndex = 0;
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
            this.especEmpresaCuitDataGridViewTextBoxColumn,
            this.especEmpresaRazonSocialDataGridViewTextBoxColumn,
            this.especEmpresaMailDataGridViewTextBoxColumn,
            this.especEmpresaCodPostalDataGridViewTextBoxColumn,
            this.Espec_Empresa_Dom_Calle,
            this.Espec_Empresa_Nro_Calle});
            this.dataGrid.DataSource = this.especEmpresaBindingSource;
            this.dataGrid.Location = new System.Drawing.Point(11, 219);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(492, 193);
            this.dataGrid.TabIndex = 9;
            this.dataGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGrid_DataBindingComplete);
            this.dataGrid.SelectionChanged += new System.EventHandler(this.dataGrid_SelectionChanged);
            // 
            // Espec_Empresa_Dom_Calle
            // 
            this.Espec_Empresa_Dom_Calle.DataPropertyName = "Espec_Empresa_Dom_Calle";
            this.Espec_Empresa_Dom_Calle.HeaderText = "Calle";
            this.Espec_Empresa_Dom_Calle.Name = "Espec_Empresa_Dom_Calle";
            this.Espec_Empresa_Dom_Calle.ReadOnly = true;
            // 
            // Espec_Empresa_Nro_Calle
            // 
            this.Espec_Empresa_Nro_Calle.DataPropertyName = "Espec_Empresa_Nro_Calle";
            this.Espec_Empresa_Nro_Calle.HeaderText = "Nro Calle";
            this.Espec_Empresa_Nro_Calle.Name = "Espec_Empresa_Nro_Calle";
            this.Espec_Empresa_Nro_Calle.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(171, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 33);
            this.label1.TabIndex = 15;
            this.label1.Text = "- Empresas - ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(-8, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(547, 52);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // especEmpresaCuitDataGridViewTextBoxColumn
            // 
            this.especEmpresaCuitDataGridViewTextBoxColumn.DataPropertyName = "Espec_Empresa_Cuit";
            this.especEmpresaCuitDataGridViewTextBoxColumn.HeaderText = "CUIT";
            this.especEmpresaCuitDataGridViewTextBoxColumn.Name = "especEmpresaCuitDataGridViewTextBoxColumn";
            this.especEmpresaCuitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // especEmpresaRazonSocialDataGridViewTextBoxColumn
            // 
            this.especEmpresaRazonSocialDataGridViewTextBoxColumn.DataPropertyName = "Espec_Empresa_Razon_Social";
            this.especEmpresaRazonSocialDataGridViewTextBoxColumn.HeaderText = "Razon Social";
            this.especEmpresaRazonSocialDataGridViewTextBoxColumn.Name = "especEmpresaRazonSocialDataGridViewTextBoxColumn";
            this.especEmpresaRazonSocialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // especEmpresaMailDataGridViewTextBoxColumn
            // 
            this.especEmpresaMailDataGridViewTextBoxColumn.DataPropertyName = "Espec_Empresa_Mail";
            this.especEmpresaMailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.especEmpresaMailDataGridViewTextBoxColumn.Name = "especEmpresaMailDataGridViewTextBoxColumn";
            this.especEmpresaMailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // especEmpresaCodPostalDataGridViewTextBoxColumn
            // 
            this.especEmpresaCodPostalDataGridViewTextBoxColumn.DataPropertyName = "Espec_Empresa_Cod_Postal";
            this.especEmpresaCodPostalDataGridViewTextBoxColumn.HeaderText = "Cod Postal";
            this.especEmpresaCodPostalDataGridViewTextBoxColumn.Name = "especEmpresaCodPostalDataGridViewTextBoxColumn";
            this.especEmpresaCodPostalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // especEmpresaBindingSource
            // 
            this.especEmpresaBindingSource.DataSource = typeof(PalcoNet.Espec_Empresa);
            // 
            // EmpresasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 424);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.botonModificar);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.botonNuevo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGrid);
            this.Name = "EmpresasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[PalcoNet] - Empresa de Espectaculos ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmpresasForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.especEmpresaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonModificar;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.Button botonNuevo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.BindingSource especEmpresaBindingSource;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox boxFiltroMail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox boxFiltroCUIT;
        private System.Windows.Forms.TextBox boxFiltroRazon;
        private System.Windows.Forms.DataGridViewTextBoxColumn especEmpresaCuitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn especEmpresaRazonSocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn especEmpresaMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn especEmpresaCodPostalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Espec_Empresa_Dom_Calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Espec_Empresa_Nro_Calle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}