namespace PalcoNet.Forms
{
    partial class CuentaForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.botonCambiarDatos = new System.Windows.Forms.Button();
            this.botonCambiar = new System.Windows.Forms.Button();
            this.labelRol = new System.Windows.Forms.Label();
            this.labelIntentos = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.botonCambiarDatos);
            this.groupBox1.Controls.Add(this.botonCambiar);
            this.groupBox1.Controls.Add(this.labelRol);
            this.groupBox1.Controls.Add(this.labelIntentos);
            this.groupBox1.Controls.Add(this.labelUsuario);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 232);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cuenta";
            // 
            // botonCambiarDatos
            // 
            this.botonCambiarDatos.Location = new System.Drawing.Point(22, 163);
            this.botonCambiarDatos.Name = "botonCambiarDatos";
            this.botonCambiarDatos.Size = new System.Drawing.Size(326, 24);
            this.botonCambiarDatos.TabIndex = 10;
            this.botonCambiarDatos.Text = "Cambiar datos de <CLI/EMP>";
            this.botonCambiarDatos.UseVisualStyleBackColor = true;
            this.botonCambiarDatos.Click += new System.EventHandler(this.botonCambiarDatos_Click);
            // 
            // botonCambiar
            // 
            this.botonCambiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCambiar.Location = new System.Drawing.Point(22, 193);
            this.botonCambiar.Name = "botonCambiar";
            this.botonCambiar.Size = new System.Drawing.Size(326, 23);
            this.botonCambiar.TabIndex = 8;
            this.botonCambiar.Text = "Cambiar contraseña";
            this.botonCambiar.UseVisualStyleBackColor = true;
            this.botonCambiar.Click += new System.EventHandler(this.botonCambiar_Click);
            // 
            // labelRol
            // 
            this.labelRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRol.Location = new System.Drawing.Point(196, 123);
            this.labelRol.Name = "labelRol";
            this.labelRol.Size = new System.Drawing.Size(135, 20);
            this.labelRol.TabIndex = 7;
            this.labelRol.Text = "ROL_DESCRIP";
            this.labelRol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelIntentos
            // 
            this.labelIntentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIntentos.Location = new System.Drawing.Point(193, 76);
            this.labelIntentos.Name = "labelIntentos";
            this.labelIntentos.Size = new System.Drawing.Size(138, 20);
            this.labelIntentos.TabIndex = 6;
            this.labelIntentos.Text = "INT_FALLIDOS";
            this.labelIntentos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUsuario
            // 
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.Location = new System.Drawing.Point(196, 35);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(135, 20);
            this.labelUsuario.TabIndex = 4;
            this.labelUsuario.Text = "USERNAME";
            this.labelUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(146, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rol:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Intentos fallidos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de usuario:";
            // 
            // CuentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 261);
            this.Controls.Add(this.groupBox1);
            this.Name = "CuentaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Información de cuenta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CuentaForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonCambiar;
        private System.Windows.Forms.Label labelRol;
        private System.Windows.Forms.Label labelIntentos;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button botonCambiarDatos;
    }
}