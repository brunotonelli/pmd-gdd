namespace PalcoNet.Forms
{
    partial class CanjearPremioForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelNombre = new System.Windows.Forms.Label();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.botonCanjear = new System.Windows.Forms.Button();
            this.textDescripcion = new System.Windows.Forms.Label();
            this.boxImagen = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPuntos = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelNombre);
            this.panel1.Controls.Add(this.botonCancelar);
            this.panel1.Controls.Add(this.botonCanjear);
            this.panel1.Controls.Add(this.textDescripcion);
            this.panel1.Controls.Add(this.boxImagen);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.labelPuntos);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 299);
            this.panel1.TabIndex = 6;
            // 
            // labelNombre
            // 
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(260, 15);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(289, 54);
            this.labelNombre.TabIndex = 9;
            this.labelNombre.Text = "NOMBRE_PREMIO";
            this.labelNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(263, 253);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(139, 39);
            this.botonCancelar.TabIndex = 8;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // botonCanjear
            // 
            this.botonCanjear.Location = new System.Drawing.Point(408, 253);
            this.botonCanjear.Name = "botonCanjear";
            this.botonCanjear.Size = new System.Drawing.Size(141, 39);
            this.botonCanjear.TabIndex = 7;
            this.botonCanjear.Text = "Canjear";
            this.botonCanjear.UseVisualStyleBackColor = true;
            this.botonCanjear.Click += new System.EventHandler(this.botonCanjear_Click);
            // 
            // textDescripcion
            // 
            this.textDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDescripcion.Location = new System.Drawing.Point(260, 69);
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(289, 181);
            this.textDescripcion.TabIndex = 6;
            this.textDescripcion.Text = "textDescripcion";
            this.textDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(135, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Puntos";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelPuntos
            // 
            this.labelPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPuntos.ForeColor = System.Drawing.Color.Maroon;
            this.labelPuntos.Location = new System.Drawing.Point(23, 256);
            this.labelPuntos.Name = "labelPuntos";
            this.labelPuntos.Size = new System.Drawing.Size(121, 36);
            this.labelPuntos.TabIndex = 2;
            this.labelPuntos.Text = "####\r\n";
            this.labelPuntos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CanjearPremioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 325);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CanjearPremioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CanjearPremioForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.boxImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox boxImagen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPuntos;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Button botonCanjear;
        private System.Windows.Forms.Label textDescripcion;
        private System.Windows.Forms.Label labelNombre;
    }
}