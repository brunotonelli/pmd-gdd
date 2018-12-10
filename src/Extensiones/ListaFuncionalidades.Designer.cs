namespace PalcoNet.Extensiones
{
    partial class ListaFuncionalidades
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.lista = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // lista
            // 
            this.lista.BackColor = System.Drawing.SystemColors.Control;
            this.lista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lista.CheckOnClick = true;
            this.lista.FormattingEnabled = true;
            this.lista.Items.AddRange(new object[] {
            "ABM de Rol",
            "ABM de Clientes",
            "ABM de Empresa de Espectáculos",
            "ABM de Rubro",
            "ABM Grado de Publicación",
            "Generar publicación",
            "Editar publicación",
            "Comprar",
            "Historial de cliente",
            "Canje y administración de puntos",
            "Generar rendición de comisiones",
            "Listado Estadistico"});
            this.lista.Location = new System.Drawing.Point(3, 3);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(206, 195);
            this.lista.TabIndex = 0;
            // 
            // ListaFuncionalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lista);
            this.Name = "ListaFuncionalidades";
            this.Size = new System.Drawing.Size(205, 190);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox lista;
    }
}
