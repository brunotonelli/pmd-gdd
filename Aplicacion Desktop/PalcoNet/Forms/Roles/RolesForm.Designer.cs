namespace PalcoNet.Forms
{
    partial class RolesForm
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
            this.Rol_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolNombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolHabilitadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.botonModificar = new System.Windows.Forms.Button();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.botonNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).BeginInit();
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
            this.Rol_ID,
            this.rolNombreDataGridViewTextBoxColumn,
            this.rolHabilitadoDataGridViewTextBoxColumn});
            this.dataGrid.DataSource = this.rolBindingSource;
            this.dataGrid.Location = new System.Drawing.Point(12, 12);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(344, 225);
            this.dataGrid.TabIndex = 2;
            this.dataGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGrid_DataBindingComplete);
            this.dataGrid.SelectionChanged += new System.EventHandler(this.dataGrid_SelectionChanged);
            // 
            // Rol_ID
            // 
            this.Rol_ID.DataPropertyName = "Rol_ID";
            this.Rol_ID.HeaderText = "Rol";
            this.Rol_ID.Name = "Rol_ID";
            this.Rol_ID.ReadOnly = true;
            // 
            // rolNombreDataGridViewTextBoxColumn
            // 
            this.rolNombreDataGridViewTextBoxColumn.DataPropertyName = "Rol_Nombre";
            this.rolNombreDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.rolNombreDataGridViewTextBoxColumn.Name = "rolNombreDataGridViewTextBoxColumn";
            this.rolNombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rolHabilitadoDataGridViewTextBoxColumn
            // 
            this.rolHabilitadoDataGridViewTextBoxColumn.DataPropertyName = "Rol_Habilitado";
            this.rolHabilitadoDataGridViewTextBoxColumn.HeaderText = "Habilitado";
            this.rolHabilitadoDataGridViewTextBoxColumn.Name = "rolHabilitadoDataGridViewTextBoxColumn";
            this.rolHabilitadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rolBindingSource
            // 
            this.rolBindingSource.DataSource = typeof(PalcoNet.Rol);
            // 
            // botonModificar
            // 
            this.botonModificar.Enabled = false;
            this.botonModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonModificar.Location = new System.Drawing.Point(362, 52);
            this.botonModificar.Name = "botonModificar";
            this.botonModificar.Size = new System.Drawing.Size(123, 34);
            this.botonModificar.TabIndex = 11;
            this.botonModificar.Text = "Modificar";
            this.botonModificar.UseVisualStyleBackColor = true;
            this.botonModificar.Click += new System.EventHandler(this.botonModificar_Click);
            // 
            // botonEliminar
            // 
            this.botonEliminar.Enabled = false;
            this.botonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonEliminar.Location = new System.Drawing.Point(362, 92);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(123, 34);
            this.botonEliminar.TabIndex = 10;
            this.botonEliminar.Text = "Eliminar";
            this.botonEliminar.UseVisualStyleBackColor = true;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // botonNuevo
            // 
            this.botonNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonNuevo.Location = new System.Drawing.Point(362, 12);
            this.botonNuevo.Name = "botonNuevo";
            this.botonNuevo.Size = new System.Drawing.Size(123, 34);
            this.botonNuevo.TabIndex = 9;
            this.botonNuevo.Text = "Nuevo";
            this.botonNuevo.UseVisualStyleBackColor = true;
            this.botonNuevo.Click += new System.EventHandler(this.botonNuevo_Click);
            // 
            // RolesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 249);
            this.Controls.Add(this.botonModificar);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.botonNuevo);
            this.Controls.Add(this.dataGrid);
            this.Name = "RolesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[PalcoNet] - Roles";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RolesForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.BindingSource rolBindingSource;
        private System.Windows.Forms.Button botonModificar;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.Button botonNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolHabilitadoDataGridViewTextBoxColumn;
    }
}