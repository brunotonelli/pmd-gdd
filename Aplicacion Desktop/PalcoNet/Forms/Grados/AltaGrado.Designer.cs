namespace PalcoNet.Forms
{
    partial class AltaGrado
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
            this.boxComision = new PalcoNet.Extensiones.TextBoxRequerido();
            this.boxNombre = new PalcoNet.Extensiones.TextBoxRequerido();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boxComision
            // 
            this.boxComision.BackColor = System.Drawing.Color.Tomato;
            this.boxComision.Location = new System.Drawing.Point(168, 69);
            this.boxComision.Name = "boxComision";
            this.boxComision.Padding = new System.Windows.Forms.Padding(1);
            this.boxComision.Size = new System.Drawing.Size(248, 22);
            this.boxComision.TabIndex = 59;
            // 
            // boxNombre
            // 
            this.boxNombre.BackColor = System.Drawing.Color.Tomato;
            this.boxNombre.Location = new System.Drawing.Point(168, 19);
            this.boxNombre.Name = "boxNombre";
            this.boxNombre.Padding = new System.Windows.Forms.Padding(1);
            this.boxNombre.Size = new System.Drawing.Size(248, 22);
            this.boxNombre.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 57;
            this.label2.Text = "*Comision";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 56;
            this.label1.Text = "*Nombre de grado";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 191);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(285, 17);
            this.label13.TabIndex = 55;
            this.label13.Text = "Los campos marcados con * son requeridos";
            // 
            // botonGuardar
            // 
            this.botonGuardar.Enabled = false;
            this.botonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonGuardar.Location = new System.Drawing.Point(255, 120);
            this.botonGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(161, 46);
            this.botonGuardar.TabIndex = 54;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.UseVisualStyleBackColor = true;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCancelar.Location = new System.Drawing.Point(15, 120);
            this.botonCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(159, 46);
            this.botonCancelar.TabIndex = 53;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // AltaGrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 224);
            this.Controls.Add(this.boxComision);
            this.Controls.Add(this.boxNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.botonCancelar);
            this.Name = "AltaGrado";
            this.Text = "[PalcoNet]- Alta grado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Extensiones.TextBoxRequerido boxComision;
        private Extensiones.TextBoxRequerido boxNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.Button botonCancelar;

    }
}