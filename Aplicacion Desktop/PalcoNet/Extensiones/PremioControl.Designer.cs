namespace PalcoNet.Extensiones
{
    partial class PremioControl
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
            this.boxImagen = new System.Windows.Forms.PictureBox();
            this.labelPuntos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.botonNombre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.boxImagen)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxImagen
            // 
            this.boxImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.boxImagen.Location = new System.Drawing.Point(18, 15);
            this.boxImagen.Name = "boxImagen";
            this.boxImagen.Size = new System.Drawing.Size(236, 236);
            this.boxImagen.TabIndex = 0;
            this.boxImagen.TabStop = false;
            // 
            // labelPuntos
            // 
            this.labelPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPuntos.ForeColor = System.Drawing.Color.Maroon;
            this.labelPuntos.Location = new System.Drawing.Point(193, 267);
            this.labelPuntos.Name = "labelPuntos";
            this.labelPuntos.Size = new System.Drawing.Size(61, 21);
            this.labelPuntos.TabIndex = 2;
            this.labelPuntos.Text = "####\r\n";
            this.labelPuntos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(194, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Puntos";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(189, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(2, 51);
            this.label4.TabIndex = 4;
            this.label4.Text = " ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.botonNombre);
            this.panel1.Controls.Add(this.boxImagen);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.labelPuntos);
            this.panel1.Location = new System.Drawing.Point(14, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 337);
            this.panel1.TabIndex = 5;
            // 
            // botonNombre
            // 
            this.botonNombre.BackColor = System.Drawing.Color.DimGray;
            this.botonNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonNombre.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonNombre.ForeColor = System.Drawing.Color.White;
            this.botonNombre.Location = new System.Drawing.Point(18, 267);
            this.botonNombre.Name = "botonNombre";
            this.botonNombre.Size = new System.Drawing.Size(153, 51);
            this.botonNombre.TabIndex = 5;
            this.botonNombre.Text = "NOMBRE";
            this.botonNombre.UseVisualStyleBackColor = false;
            this.botonNombre.Click += new System.EventHandler(this.botonNombre_Click);
            // 
            // PremioControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "PremioControl";
            this.Size = new System.Drawing.Size(300, 360);
            ((System.ComponentModel.ISupportInitialize)(this.boxImagen)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox boxImagen;
        private System.Windows.Forms.Label labelPuntos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button botonNombre;
    }
}
