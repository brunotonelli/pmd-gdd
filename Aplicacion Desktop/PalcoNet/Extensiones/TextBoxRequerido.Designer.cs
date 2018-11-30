namespace PalcoNet.Extensiones
{
    partial class TextBoxRequerido
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
            this.TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.TextBox.Location = new System.Drawing.Point(3, 3);
            this.TextBox.Name = "_textBox";
            this.TextBox.Size = new System.Drawing.Size(120, 20);
            this.TextBox.TabIndex = 0;
            // 
            // TextBoxRequerido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TextBox);
            this.Name = "TextBoxRequerido";
            this.Size = new System.Drawing.Size(125, 28);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
    }
}
