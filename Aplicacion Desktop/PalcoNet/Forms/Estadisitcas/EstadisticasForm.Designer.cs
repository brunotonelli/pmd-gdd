namespace PalcoNet.Forms
{
    partial class EstadisticasForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_Respuesta = new System.Windows.Forms.Label();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_ComprasCliente = new System.Windows.Forms.RadioButton();
            this.rb_Empresas = new System.Windows.Forms.RadioButton();
            this.rb_PuntosCliente = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Trimestre = new System.Windows.Forms.ComboBox();
            this.tm_Verificar = new System.Windows.Forms.Timer(this.components);
            this.comprasEstadisticoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dg_WEA = new System.Windows.Forms.DataGridView();
            this.txt_Ano = new PalcoNet.Extensiones.TextBoxRequerido();
            this.comprasEstadisticoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comprasEstadisticoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_WEA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasEstadisticoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estadisticas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Año";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Ano);
            this.groupBox1.Controls.Add(this.lbl_Respuesta);
            this.groupBox1.Controls.Add(this.btn_Cerrar);
            this.groupBox1.Controls.Add(this.btn_Buscar);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cb_Trimestre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(18, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 309);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese los datos a buscar";
            // 
            // lbl_Respuesta
            // 
            this.lbl_Respuesta.AutoSize = true;
            this.lbl_Respuesta.ForeColor = System.Drawing.Color.Red;
            this.lbl_Respuesta.Location = new System.Drawing.Point(40, 222);
            this.lbl_Respuesta.Name = "lbl_Respuesta";
            this.lbl_Respuesta.Size = new System.Drawing.Size(53, 20);
            this.lbl_Respuesta.TabIndex = 4;
            this.lbl_Respuesta.Text = "label4";
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Location = new System.Drawing.Point(362, 245);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(100, 55);
            this.btn_Cerrar.TabIndex = 9;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Enabled = false;
            this.btn_Buscar.Location = new System.Drawing.Point(468, 245);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(100, 55);
            this.btn_Buscar.TabIndex = 5;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_ComprasCliente);
            this.groupBox2.Controls.Add(this.rb_Empresas);
            this.groupBox2.Controls.Add(this.rb_PuntosCliente);
            this.groupBox2.Location = new System.Drawing.Point(38, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(530, 128);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Criterio de busqueda";
            // 
            // rb_ComprasCliente
            // 
            this.rb_ComprasCliente.AutoSize = true;
            this.rb_ComprasCliente.Location = new System.Drawing.Point(15, 85);
            this.rb_ComprasCliente.Name = "rb_ComprasCliente";
            this.rb_ComprasCliente.Size = new System.Drawing.Size(335, 24);
            this.rb_ComprasCliente.TabIndex = 7;
            this.rb_ComprasCliente.TabStop = true;
            this.rb_ComprasCliente.Text = "Clientes con mayor cantidad de compras";
            this.rb_ComprasCliente.UseVisualStyleBackColor = true;
            this.rb_ComprasCliente.CheckedChanged += new System.EventHandler(this.rb_ComprasCliente_CheckedChanged);
            // 
            // rb_Empresas
            // 
            this.rb_Empresas.AutoSize = true;
            this.rb_Empresas.Location = new System.Drawing.Point(12, 25);
            this.rb_Empresas.Name = "rb_Empresas";
            this.rb_Empresas.Size = new System.Drawing.Size(463, 24);
            this.rb_Empresas.TabIndex = 5;
            this.rb_Empresas.TabStop = true;
            this.rb_Empresas.Text = "Empresas con mayor cantidad de localidades no vendidas";
            this.rb_Empresas.UseVisualStyleBackColor = true;
            this.rb_Empresas.CheckedChanged += new System.EventHandler(this.rb_Empresas_CheckedChanged);
            // 
            // rb_PuntosCliente
            // 
            this.rb_PuntosCliente.AutoSize = true;
            this.rb_PuntosCliente.Location = new System.Drawing.Point(12, 55);
            this.rb_PuntosCliente.Name = "rb_PuntosCliente";
            this.rb_PuntosCliente.Size = new System.Drawing.Size(391, 24);
            this.rb_PuntosCliente.TabIndex = 6;
            this.rb_PuntosCliente.TabStop = true;
            this.rb_PuntosCliente.Text = "Clientes con mayor cantidad de puntos vencidos";
            this.rb_PuntosCliente.UseVisualStyleBackColor = true;
            this.rb_PuntosCliente.CheckedChanged += new System.EventHandler(this.rb_PuntosCliente_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Trimestre";
            // 
            // cb_Trimestre
            // 
            this.cb_Trimestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Trimestre.FormattingEnabled = true;
            this.cb_Trimestre.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cb_Trimestre.Location = new System.Drawing.Point(157, 57);
            this.cb_Trimestre.Name = "cb_Trimestre";
            this.cb_Trimestre.Size = new System.Drawing.Size(248, 28);
            this.cb_Trimestre.TabIndex = 3;
            // 
            // tm_Verificar
            // 
            this.tm_Verificar.Interval = 500;
            this.tm_Verificar.Tick += new System.EventHandler(this.tm_Verificar_Tick);
            // 
            // dg_WEA
            // 
            this.dg_WEA.AllowUserToAddRows = false;
            this.dg_WEA.AllowUserToDeleteRows = false;
            this.dg_WEA.AllowUserToResizeRows = false;
            this.dg_WEA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_WEA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_WEA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_WEA.Location = new System.Drawing.Point(18, 365);
            this.dg_WEA.Margin = new System.Windows.Forms.Padding(4);
            this.dg_WEA.MultiSelect = false;
            this.dg_WEA.Name = "dg_WEA";
            this.dg_WEA.ReadOnly = true;
            this.dg_WEA.RowHeadersVisible = false;
            this.dg_WEA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_WEA.Size = new System.Drawing.Size(599, 174);
            this.dg_WEA.TabIndex = 21;
            // 
            // txt_Ano
            // 
            this.txt_Ano.BackColor = System.Drawing.Color.Tomato;
            this.txt_Ano.Location = new System.Drawing.Point(157, 25);
            this.txt_Ano.Name = "txt_Ano";
            this.txt_Ano.Padding = new System.Windows.Forms.Padding(1);
            this.txt_Ano.Size = new System.Drawing.Size(248, 26);
            this.txt_Ano.TabIndex = 10;
            // 
            // comprasEstadisticoBindingSource
            // 
            this.comprasEstadisticoBindingSource.DataSource = typeof(PalcoNet.Model.ComprasEstadistico);
            // 
            // EstadisticasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 579);
            this.Controls.Add(this.dg_WEA);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "EstadisticasForm";
            this.Text = "[PalcoNet] Estadisticas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comprasEstadisticoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_WEA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasEstadisticoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_Trimestre;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.RadioButton rb_Empresas;
        private System.Windows.Forms.RadioButton rb_PuntosCliente;
        private System.Windows.Forms.RadioButton rb_ComprasCliente;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Timer tm_Verificar;
        private System.Windows.Forms.Label lbl_Respuesta;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.BindingSource comprasEstadisticoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroDocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantComprasDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource comprasEstadisticoBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliNroDocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliTipoDocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliApellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entradasCompradasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dg_WEA;
        private Extensiones.TextBoxRequerido txt_Ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}