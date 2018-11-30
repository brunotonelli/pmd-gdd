namespace PalcoNet.Forms
{
    partial class ModifEmpresasForm
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
            this.botonCancelar = new System.Windows.Forms.Button();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.boxMail = new PalcoNet.Extensiones.TextBoxRequerido();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.boxTelefono = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.boxCiudad = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.boxCalle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.boxNumero = new System.Windows.Forms.TextBox();
            this.boxCodigoPostal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.boxLocalidad = new System.Windows.Forms.TextBox();
            this.boxPiso = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.boxDepartamento = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.boxCUIT = new PalcoNet.Extensiones.TextBoxRequerido();
            this.boxRazon = new PalcoNet.Extensiones.TextBoxRequerido();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.checkHabilitado = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonCancelar
            // 
            this.botonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCancelar.Location = new System.Drawing.Point(292, 326);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(129, 37);
            this.botonCancelar.TabIndex = 55;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // botonGuardar
            // 
            this.botonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonGuardar.Location = new System.Drawing.Point(427, 325);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(132, 37);
            this.botonGuardar.TabIndex = 54;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.UseVisualStyleBackColor = true;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.boxMail);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.boxTelefono);
            this.groupBox4.Location = new System.Drawing.Point(12, 136);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(264, 109);
            this.groupBox4.TabIndex = 53;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos de contacto";
            // 
            // boxMail
            // 
            this.boxMail.BackColor = System.Drawing.Color.Tomato;
            this.boxMail.Location = new System.Drawing.Point(97, 32);
            this.boxMail.Name = "boxMail";
            this.boxMail.Padding = new System.Windows.Forms.Padding(1);
            this.boxMail.Size = new System.Drawing.Size(150, 20);
            this.boxMail.TabIndex = 27;
            this.boxMail.TipoTextbox = PalcoNet.Extensiones.TextBoxRequerido.Tipo.Normal;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "*Mail";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Telefono";
            // 
            // boxTelefono
            // 
            this.boxTelefono.Location = new System.Drawing.Point(97, 66);
            this.boxTelefono.Name = "boxTelefono";
            this.boxTelefono.Size = new System.Drawing.Size(150, 20);
            this.boxTelefono.TabIndex = 21;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.boxCiudad);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.boxCalle);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.boxNumero);
            this.groupBox2.Controls.Add(this.boxCodigoPostal);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.boxLocalidad);
            this.groupBox2.Controls.Add(this.boxPiso);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label100);
            this.groupBox2.Controls.Add(this.boxDepartamento);
            this.groupBox2.Location = new System.Drawing.Point(292, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 295);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de ubicación";
            // 
            // boxCiudad
            // 
            this.boxCiudad.Location = new System.Drawing.Point(97, 248);
            this.boxCiudad.Name = "boxCiudad";
            this.boxCiudad.Size = new System.Drawing.Size(150, 20);
            this.boxCiudad.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 251);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Ciudad";
            // 
            // boxCalle
            // 
            this.boxCalle.Location = new System.Drawing.Point(97, 33);
            this.boxCalle.Name = "boxCalle";
            this.boxCalle.Size = new System.Drawing.Size(150, 20);
            this.boxCalle.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Calle";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Codigo postal";
            // 
            // boxNumero
            // 
            this.boxNumero.Location = new System.Drawing.Point(97, 70);
            this.boxNumero.Name = "boxNumero";
            this.boxNumero.Size = new System.Drawing.Size(150, 20);
            this.boxNumero.TabIndex = 13;
            // 
            // boxCodigoPostal
            // 
            this.boxCodigoPostal.Location = new System.Drawing.Point(97, 178);
            this.boxCodigoPostal.Name = "boxCodigoPostal";
            this.boxCodigoPostal.Size = new System.Drawing.Size(150, 20);
            this.boxCodigoPostal.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Numero";
            // 
            // boxLocalidad
            // 
            this.boxLocalidad.Location = new System.Drawing.Point(97, 214);
            this.boxLocalidad.Name = "boxLocalidad";
            this.boxLocalidad.Size = new System.Drawing.Size(150, 20);
            this.boxLocalidad.TabIndex = 27;
            // 
            // boxPiso
            // 
            this.boxPiso.Location = new System.Drawing.Point(97, 106);
            this.boxPiso.Name = "boxPiso";
            this.boxPiso.Size = new System.Drawing.Size(150, 20);
            this.boxPiso.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Departamento";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 109);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Piso";
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Location = new System.Drawing.Point(17, 217);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(53, 13);
            this.label100.TabIndex = 28;
            this.label100.Text = "Localidad";
            // 
            // boxDepartamento
            // 
            this.boxDepartamento.Location = new System.Drawing.Point(97, 142);
            this.boxDepartamento.Name = "boxDepartamento";
            this.boxDepartamento.Size = new System.Drawing.Size(150, 20);
            this.boxDepartamento.TabIndex = 17;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.boxCUIT);
            this.groupBox3.Controls.Add(this.boxRazon);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 114);
            this.groupBox3.TabIndex = 51;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos de Empresa";
            // 
            // boxCUIT
            // 
            this.boxCUIT.BackColor = System.Drawing.Color.Tomato;
            this.boxCUIT.Enabled = false;
            this.boxCUIT.Location = new System.Drawing.Point(94, 70);
            this.boxCUIT.Name = "boxCUIT";
            this.boxCUIT.Padding = new System.Windows.Forms.Padding(1);
            this.boxCUIT.Size = new System.Drawing.Size(150, 20);
            this.boxCUIT.TabIndex = 28;
            this.boxCUIT.TipoTextbox = PalcoNet.Extensiones.TextBoxRequerido.Tipo.Normal;
            // 
            // boxRazon
            // 
            this.boxRazon.BackColor = System.Drawing.Color.Tomato;
            this.boxRazon.Location = new System.Drawing.Point(94, 36);
            this.boxRazon.Name = "boxRazon";
            this.boxRazon.Padding = new System.Windows.Forms.Padding(1);
            this.boxRazon.Size = new System.Drawing.Size(150, 20);
            this.boxRazon.TabIndex = 25;
            this.boxRazon.TipoTextbox = PalcoNet.Extensiones.TextBoxRequerido.Tipo.Normal;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "* Razón social";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "* CUIT";
            // 
            // checkHabilitado
            // 
            this.checkHabilitado.AutoSize = true;
            this.checkHabilitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkHabilitado.Location = new System.Drawing.Point(53, 283);
            this.checkHabilitado.Name = "checkHabilitado";
            this.checkHabilitado.Size = new System.Drawing.Size(167, 24);
            this.checkHabilitado.TabIndex = 57;
            this.checkHabilitado.Text = "Empresa Habilitada";
            this.checkHabilitado.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Los campos marcados con * son requeridos";
            // 
            // ModifEmpresasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 375);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.checkHabilitado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "ModifEmpresasForm";
            this.Text = "[PalcoNet] - Modificar Empresa";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.GroupBox groupBox4;
        private Extensiones.TextBoxRequerido boxMail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox boxTelefono;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox boxCiudad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox boxCalle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox boxNumero;
        private System.Windows.Forms.TextBox boxCodigoPostal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox boxLocalidad;
        private System.Windows.Forms.TextBox boxPiso;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.TextBox boxDepartamento;
        private System.Windows.Forms.GroupBox groupBox3;
        private Extensiones.TextBoxRequerido boxRazon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private Extensiones.TextBoxRequerido boxCUIT;
        private System.Windows.Forms.CheckBox checkHabilitado;
        private System.Windows.Forms.Label label1;
    }
}