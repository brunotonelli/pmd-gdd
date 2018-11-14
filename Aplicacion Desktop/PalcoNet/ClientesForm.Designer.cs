namespace PalcoNet
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cliDniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliApellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliNombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliFechaNacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliDomCalleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliNroCalleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliPisoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliDeptoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliCodPostalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliCUILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliTelefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliLocalidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliFechaAltaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliTarjetaNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliTarjetaTipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cliDniDataGridViewTextBoxColumn,
            this.cliApellidoDataGridViewTextBoxColumn,
            this.cliNombreDataGridViewTextBoxColumn,
            this.cliFechaNacDataGridViewTextBoxColumn,
            this.cliMailDataGridViewTextBoxColumn,
            this.cliDomCalleDataGridViewTextBoxColumn,
            this.cliNroCalleDataGridViewTextBoxColumn,
            this.cliPisoDataGridViewTextBoxColumn,
            this.cliDeptoDataGridViewTextBoxColumn,
            this.cliCodPostalDataGridViewTextBoxColumn,
            this.cliCUILDataGridViewTextBoxColumn,
            this.cliTelefonoDataGridViewTextBoxColumn,
            this.cliLocalidadDataGridViewTextBoxColumn,
            this.cliFechaAltaDataGridViewTextBoxColumn,
            this.cliTarjetaNumDataGridViewTextBoxColumn,
            this.cliTarjetaTipoDataGridViewTextBoxColumn,
            this.cliUsuarioDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clienteBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(984, 561);
            this.dataGridView1.TabIndex = 0;
            // 
            // cliDniDataGridViewTextBoxColumn
            // 
            this.cliDniDataGridViewTextBoxColumn.DataPropertyName = "Cli_Dni";
            this.cliDniDataGridViewTextBoxColumn.HeaderText = "Cli_Dni";
            this.cliDniDataGridViewTextBoxColumn.Name = "cliDniDataGridViewTextBoxColumn";
            // 
            // cliApellidoDataGridViewTextBoxColumn
            // 
            this.cliApellidoDataGridViewTextBoxColumn.DataPropertyName = "Cli_Apellido";
            this.cliApellidoDataGridViewTextBoxColumn.HeaderText = "Cli_Apellido";
            this.cliApellidoDataGridViewTextBoxColumn.Name = "cliApellidoDataGridViewTextBoxColumn";
            // 
            // cliNombreDataGridViewTextBoxColumn
            // 
            this.cliNombreDataGridViewTextBoxColumn.DataPropertyName = "Cli_Nombre";
            this.cliNombreDataGridViewTextBoxColumn.HeaderText = "Cli_Nombre";
            this.cliNombreDataGridViewTextBoxColumn.Name = "cliNombreDataGridViewTextBoxColumn";
            // 
            // cliFechaNacDataGridViewTextBoxColumn
            // 
            this.cliFechaNacDataGridViewTextBoxColumn.DataPropertyName = "Cli_Fecha_Nac";
            this.cliFechaNacDataGridViewTextBoxColumn.HeaderText = "Cli_Fecha_Nac";
            this.cliFechaNacDataGridViewTextBoxColumn.Name = "cliFechaNacDataGridViewTextBoxColumn";
            // 
            // cliMailDataGridViewTextBoxColumn
            // 
            this.cliMailDataGridViewTextBoxColumn.DataPropertyName = "Cli_Mail";
            this.cliMailDataGridViewTextBoxColumn.HeaderText = "Cli_Mail";
            this.cliMailDataGridViewTextBoxColumn.Name = "cliMailDataGridViewTextBoxColumn";
            // 
            // cliDomCalleDataGridViewTextBoxColumn
            // 
            this.cliDomCalleDataGridViewTextBoxColumn.DataPropertyName = "Cli_Dom_Calle";
            this.cliDomCalleDataGridViewTextBoxColumn.HeaderText = "Cli_Dom_Calle";
            this.cliDomCalleDataGridViewTextBoxColumn.Name = "cliDomCalleDataGridViewTextBoxColumn";
            // 
            // cliNroCalleDataGridViewTextBoxColumn
            // 
            this.cliNroCalleDataGridViewTextBoxColumn.DataPropertyName = "Cli_Nro_Calle";
            this.cliNroCalleDataGridViewTextBoxColumn.HeaderText = "Cli_Nro_Calle";
            this.cliNroCalleDataGridViewTextBoxColumn.Name = "cliNroCalleDataGridViewTextBoxColumn";
            // 
            // cliPisoDataGridViewTextBoxColumn
            // 
            this.cliPisoDataGridViewTextBoxColumn.DataPropertyName = "Cli_Piso";
            this.cliPisoDataGridViewTextBoxColumn.HeaderText = "Cli_Piso";
            this.cliPisoDataGridViewTextBoxColumn.Name = "cliPisoDataGridViewTextBoxColumn";
            // 
            // cliDeptoDataGridViewTextBoxColumn
            // 
            this.cliDeptoDataGridViewTextBoxColumn.DataPropertyName = "Cli_Depto";
            this.cliDeptoDataGridViewTextBoxColumn.HeaderText = "Cli_Depto";
            this.cliDeptoDataGridViewTextBoxColumn.Name = "cliDeptoDataGridViewTextBoxColumn";
            // 
            // cliCodPostalDataGridViewTextBoxColumn
            // 
            this.cliCodPostalDataGridViewTextBoxColumn.DataPropertyName = "Cli_Cod_Postal";
            this.cliCodPostalDataGridViewTextBoxColumn.HeaderText = "Cli_Cod_Postal";
            this.cliCodPostalDataGridViewTextBoxColumn.Name = "cliCodPostalDataGridViewTextBoxColumn";
            // 
            // cliCUILDataGridViewTextBoxColumn
            // 
            this.cliCUILDataGridViewTextBoxColumn.DataPropertyName = "Cli_CUIL";
            this.cliCUILDataGridViewTextBoxColumn.HeaderText = "Cli_CUIL";
            this.cliCUILDataGridViewTextBoxColumn.Name = "cliCUILDataGridViewTextBoxColumn";
            // 
            // cliTelefonoDataGridViewTextBoxColumn
            // 
            this.cliTelefonoDataGridViewTextBoxColumn.DataPropertyName = "Cli_Telefono";
            this.cliTelefonoDataGridViewTextBoxColumn.HeaderText = "Cli_Telefono";
            this.cliTelefonoDataGridViewTextBoxColumn.Name = "cliTelefonoDataGridViewTextBoxColumn";
            // 
            // cliLocalidadDataGridViewTextBoxColumn
            // 
            this.cliLocalidadDataGridViewTextBoxColumn.DataPropertyName = "Cli_Localidad";
            this.cliLocalidadDataGridViewTextBoxColumn.HeaderText = "Cli_Localidad";
            this.cliLocalidadDataGridViewTextBoxColumn.Name = "cliLocalidadDataGridViewTextBoxColumn";
            // 
            // cliFechaAltaDataGridViewTextBoxColumn
            // 
            this.cliFechaAltaDataGridViewTextBoxColumn.DataPropertyName = "Cli_Fecha_Alta";
            this.cliFechaAltaDataGridViewTextBoxColumn.HeaderText = "Cli_Fecha_Alta";
            this.cliFechaAltaDataGridViewTextBoxColumn.Name = "cliFechaAltaDataGridViewTextBoxColumn";
            // 
            // cliTarjetaNumDataGridViewTextBoxColumn
            // 
            this.cliTarjetaNumDataGridViewTextBoxColumn.DataPropertyName = "Cli_Tarjeta_Num";
            this.cliTarjetaNumDataGridViewTextBoxColumn.HeaderText = "Cli_Tarjeta_Num";
            this.cliTarjetaNumDataGridViewTextBoxColumn.Name = "cliTarjetaNumDataGridViewTextBoxColumn";
            // 
            // cliTarjetaTipoDataGridViewTextBoxColumn
            // 
            this.cliTarjetaTipoDataGridViewTextBoxColumn.DataPropertyName = "Cli_Tarjeta_Tipo";
            this.cliTarjetaTipoDataGridViewTextBoxColumn.HeaderText = "Cli_Tarjeta_Tipo";
            this.cliTarjetaTipoDataGridViewTextBoxColumn.Name = "cliTarjetaTipoDataGridViewTextBoxColumn";
            // 
            // cliUsuarioDataGridViewTextBoxColumn
            // 
            this.cliUsuarioDataGridViewTextBoxColumn.DataPropertyName = "Cli_Usuario";
            this.cliUsuarioDataGridViewTextBoxColumn.HeaderText = "Cli_Usuario";
            this.cliUsuarioDataGridViewTextBoxColumn.Name = "cliUsuarioDataGridViewTextBoxColumn";
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(PalcoNet.Cliente);
            this.clienteBindingSource.CurrentChanged += new System.EventHandler(this.clienteBindingSource_CurrentChanged);
            // 
            // ClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ClientesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliDniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliApellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliFechaNacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliDomCalleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliNroCalleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliPisoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliDeptoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliCodPostalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliCUILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliTelefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliLocalidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliFechaAltaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliTarjetaNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliTarjetaTipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clienteBindingSource;
    }
}