namespace PalcoNet.Forms
{
    partial class ConfiguracionForm
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
            this.botonArchivo = new System.Windows.Forms.Button();
            this.boxServidor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.boxBaseDeDatos = new System.Windows.Forms.TextBox();
            this.boxUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.boxContraseña = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.boxFechaActual = new System.Windows.Forms.DateTimePicker();
            this.botonRestablecer = new System.Windows.Forms.Button();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonArchivo
            // 
            this.botonArchivo.Location = new System.Drawing.Point(12, 232);
            this.botonArchivo.Name = "botonArchivo";
            this.botonArchivo.Size = new System.Drawing.Size(75, 38);
            this.botonArchivo.TabIndex = 0;
            this.botonArchivo.Text = "Ver archivo";
            this.botonArchivo.UseVisualStyleBackColor = true;
            this.botonArchivo.Click += new System.EventHandler(this.botonArchivo_Click);
            // 
            // boxServidor
            // 
            this.boxServidor.Location = new System.Drawing.Point(98, 54);
            this.boxServidor.Name = "boxServidor";
            this.boxServidor.Size = new System.Drawing.Size(208, 20);
            this.boxServidor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "La modificación de estos campos se verá reflejada en\r\nel archivo de configuración" +
    "\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Servidor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Base de datos";
            // 
            // boxBaseDeDatos
            // 
            this.boxBaseDeDatos.Location = new System.Drawing.Point(98, 88);
            this.boxBaseDeDatos.Name = "boxBaseDeDatos";
            this.boxBaseDeDatos.Size = new System.Drawing.Size(208, 20);
            this.boxBaseDeDatos.TabIndex = 5;
            // 
            // boxUsuario
            // 
            this.boxUsuario.Location = new System.Drawing.Point(98, 122);
            this.boxUsuario.Name = "boxUsuario";
            this.boxUsuario.Size = new System.Drawing.Size(208, 20);
            this.boxUsuario.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Contraseña";
            // 
            // boxContraseña
            // 
            this.boxContraseña.Location = new System.Drawing.Point(98, 156);
            this.boxContraseña.Name = "boxContraseña";
            this.boxContraseña.Size = new System.Drawing.Size(208, 20);
            this.boxContraseña.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fecha actual";
            // 
            // boxFechaActual
            // 
            this.boxFechaActual.Location = new System.Drawing.Point(98, 190);
            this.boxFechaActual.Name = "boxFechaActual";
            this.boxFechaActual.Size = new System.Drawing.Size(208, 20);
            this.boxFechaActual.TabIndex = 11;
            // 
            // botonRestablecer
            // 
            this.botonRestablecer.Location = new System.Drawing.Point(93, 232);
            this.botonRestablecer.Name = "botonRestablecer";
            this.botonRestablecer.Size = new System.Drawing.Size(111, 38);
            this.botonRestablecer.TabIndex = 12;
            this.botonRestablecer.Text = "Restablecer valores";
            this.botonRestablecer.UseVisualStyleBackColor = true;
            this.botonRestablecer.Click += new System.EventHandler(this.botonRestablecer_Click);
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(210, 232);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(96, 38);
            this.botonGuardar.TabIndex = 13;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.UseVisualStyleBackColor = true;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // ConfiguracionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 282);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.botonRestablecer);
            this.Controls.Add(this.boxFechaActual);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.boxContraseña);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.boxUsuario);
            this.Controls.Add(this.boxBaseDeDatos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxServidor);
            this.Controls.Add(this.botonArchivo);
            this.Name = "ConfiguracionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ConfiguracionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonArchivo;
        private System.Windows.Forms.TextBox boxServidor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox boxBaseDeDatos;
        private System.Windows.Forms.TextBox boxUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox boxContraseña;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker boxFechaActual;
        private System.Windows.Forms.Button botonRestablecer;
        private System.Windows.Forms.Button botonGuardar;
    }
}