namespace PalcoNet.Forms
{
    partial class GradosForm
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
            this.botonModificar = new System.Windows.Forms.Button();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.botonNuevo = new System.Windows.Forms.Button();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gradoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradoNombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradoComisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradoHabilitadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradoPublicacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradoPublicacionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // botonModificar
            // 
            this.botonModificar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.botonModificar.Enabled = false;
            this.botonModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonModificar.Location = new System.Drawing.Point(171, 64);
            this.botonModificar.Name = "botonModificar";
            this.botonModificar.Size = new System.Drawing.Size(147, 34);
            this.botonModificar.TabIndex = 18;
            this.botonModificar.Text = "Modificar";
            this.botonModificar.UseVisualStyleBackColor = true;
            this.botonModificar.Click += new System.EventHandler(this.botonModificar_Click);
            // 
            // botonEliminar
            // 
            this.botonEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonEliminar.Enabled = false;
            this.botonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonEliminar.Location = new System.Drawing.Point(330, 64);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(147, 34);
            this.botonEliminar.TabIndex = 17;
            this.botonEliminar.Text = "Eliminar";
            this.botonEliminar.UseVisualStyleBackColor = true;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // botonNuevo
            // 
            this.botonNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonNuevo.Location = new System.Drawing.Point(12, 64);
            this.botonNuevo.Name = "botonNuevo";
            this.botonNuevo.Size = new System.Drawing.Size(147, 34);
            this.botonNuevo.TabIndex = 16;
            this.botonNuevo.Text = "Nuevo";
            this.botonNuevo.UseVisualStyleBackColor = true;
            this.botonNuevo.Click += new System.EventHandler(this.botonNuevo_Click);
            // 
            // datagrid
            // 
            this.datagrid.AllowUserToAddRows = false;
            this.datagrid.AllowUserToDeleteRows = false;
            this.datagrid.AllowUserToResizeRows = false;
            this.datagrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagrid.AutoGenerateColumns = false;
            this.datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gradoIDDataGridViewTextBoxColumn,
            this.gradoNombreDataGridViewTextBoxColumn,
            this.gradoComisionDataGridViewTextBoxColumn,
            this.gradoHabilitadoDataGridViewTextBoxColumn});
            this.datagrid.DataSource = this.gradoPublicacionBindingSource;
            this.datagrid.Location = new System.Drawing.Point(12, 116);
            this.datagrid.MultiSelect = false;
            this.datagrid.Name = "datagrid";
            this.datagrid.ReadOnly = true;
            this.datagrid.RowHeadersVisible = false;
            this.datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid.Size = new System.Drawing.Size(465, 152);
            this.datagrid.TabIndex = 19;
            this.datagrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.datagrid_DataBindingComplete);
            this.datagrid.SelectionChanged += new System.EventHandler(this.datagrid_SelectionChanged_1);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(77, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 33);
            this.label1.TabIndex = 20;
            this.label1.Text = "- Grados de publicación -";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(-26, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(547, 50);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // gradoIDDataGridViewTextBoxColumn
            // 
            this.gradoIDDataGridViewTextBoxColumn.DataPropertyName = "Grado_ID";
            this.gradoIDDataGridViewTextBoxColumn.HeaderText = "Grado_ID";
            this.gradoIDDataGridViewTextBoxColumn.Name = "gradoIDDataGridViewTextBoxColumn";
            this.gradoIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gradoNombreDataGridViewTextBoxColumn
            // 
            this.gradoNombreDataGridViewTextBoxColumn.DataPropertyName = "Grado_Nombre";
            this.gradoNombreDataGridViewTextBoxColumn.HeaderText = "Grado_Nombre";
            this.gradoNombreDataGridViewTextBoxColumn.Name = "gradoNombreDataGridViewTextBoxColumn";
            this.gradoNombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gradoComisionDataGridViewTextBoxColumn
            // 
            this.gradoComisionDataGridViewTextBoxColumn.DataPropertyName = "Grado_Comision";
            this.gradoComisionDataGridViewTextBoxColumn.HeaderText = "Grado_Comision";
            this.gradoComisionDataGridViewTextBoxColumn.Name = "gradoComisionDataGridViewTextBoxColumn";
            this.gradoComisionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gradoHabilitadoDataGridViewTextBoxColumn
            // 
            this.gradoHabilitadoDataGridViewTextBoxColumn.DataPropertyName = "Grado_Habilitado";
            this.gradoHabilitadoDataGridViewTextBoxColumn.HeaderText = "Grado_Habilitado";
            this.gradoHabilitadoDataGridViewTextBoxColumn.Name = "gradoHabilitadoDataGridViewTextBoxColumn";
            this.gradoHabilitadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gradoPublicacionBindingSource
            // 
            this.gradoPublicacionBindingSource.DataSource = typeof(PalcoNet.Grado_Publicacion);
            // 
            // GradosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 280);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.datagrid);
            this.Controls.Add(this.botonModificar);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.botonNuevo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GradosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[PalcoNet] - Grado de Publicación";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GradosForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradoPublicacionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonModificar;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.Button botonNuevo;
        private System.Windows.Forms.BindingSource gradoPublicacionBindingSource;
        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradoNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradoComisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradoHabilitadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}