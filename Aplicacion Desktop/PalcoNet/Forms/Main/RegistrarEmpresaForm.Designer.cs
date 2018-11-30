namespace PalcoNet.Forms
{
    partial class RegistrarEmpresaForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.boxContraseña = new PalcoNet.Extensiones.TextBoxRequerido();
            this.boxUsuario = new PalcoNet.Extensiones.TextBoxRequerido();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.boxCUIT = new PalcoNet.Extensiones.TextBoxRequerido();
            this.boxRazon = new PalcoNet.Extensiones.TextBoxRequerido();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.boxMail = new PalcoNet.Extensiones.TextBoxRequerido();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.boxTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.botonRegistrarse = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.boxContraseña);
            this.groupBox1.Controls.Add(this.boxUsuario);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Usuario";
            // 
            // boxContraseña
            // 
            this.boxContraseña.BackColor = System.Drawing.Color.Tomato;
            this.boxContraseña.Location = new System.Drawing.Point(122, 71);
            this.boxContraseña.Name = "boxContraseña";
            this.boxContraseña.Padding = new System.Windows.Forms.Padding(1);
            this.boxContraseña.Size = new System.Drawing.Size(122, 20);
            this.boxContraseña.TabIndex = 28;
            this.boxContraseña.TipoTextbox = PalcoNet.Extensiones.TextBoxRequerido.Tipo.Contraseña;
            // 
            // boxUsuario
            // 
            this.boxUsuario.BackColor = System.Drawing.Color.Tomato;
            this.boxUsuario.Location = new System.Drawing.Point(122, 36);
            this.boxUsuario.Name = "boxUsuario";
            this.boxUsuario.Padding = new System.Windows.Forms.Padding(1);
            this.boxUsuario.Size = new System.Drawing.Size(122, 20);
            this.boxUsuario.TabIndex = 27;
            this.boxUsuario.TipoTextbox = PalcoNet.Extensiones.TextBoxRequerido.Tipo.Normal;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rol";
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cliente",
            "Empresa"});
            this.comboBox1.Location = new System.Drawing.Point(122, 106);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(122, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "Empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "* Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "* Nombre de usuario";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.boxCUIT);
            this.groupBox3.Controls.Add(this.boxRazon);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 168);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 114);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos de Empresa";
            // 
            // boxCUIT
            // 
            this.boxCUIT.BackColor = System.Drawing.Color.Tomato;
            this.boxCUIT.Location = new System.Drawing.Point(94, 73);
            this.boxCUIT.Name = "boxCUIT";
            this.boxCUIT.Padding = new System.Windows.Forms.Padding(1);
            this.boxCUIT.Size = new System.Drawing.Size(150, 20);
            this.boxCUIT.TabIndex = 26;
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
            this.groupBox2.TabIndex = 38;
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.boxMail);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.boxTelefono);
            this.groupBox4.Location = new System.Drawing.Point(12, 292);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(264, 109);
            this.groupBox4.TabIndex = 39;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos de contacto";
            // 
            // boxMail
            // 
            this.boxMail.BackColor = System.Drawing.Color.Tomato;
            this.boxMail.Location = new System.Drawing.Point(97, 29);
            this.boxMail.Name = "boxMail";
            this.boxMail.Padding = new System.Windows.Forms.Padding(1);
            this.boxMail.Size = new System.Drawing.Size(150, 20);
            this.boxMail.TabIndex = 28;
            this.boxMail.TipoTextbox = PalcoNet.Extensiones.TextBoxRequerido.Tipo.Normal;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "* Mail";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Los campos marcados con * son requeridos";
            // 
            // botonCancelar
            // 
            this.botonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCancelar.Location = new System.Drawing.Point(293, 364);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(119, 37);
            this.botonCancelar.TabIndex = 42;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            // 
            // botonRegistrarse
            // 
            this.botonRegistrarse.Enabled = false;
            this.botonRegistrarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRegistrarse.Location = new System.Drawing.Point(428, 364);
            this.botonRegistrarse.Name = "botonRegistrarse";
            this.botonRegistrarse.Size = new System.Drawing.Size(132, 37);
            this.botonRegistrarse.TabIndex = 41;
            this.botonRegistrarse.Text = "Registrarse";
            this.botonRegistrarse.UseVisualStyleBackColor = true;
            this.botonRegistrarse.Click += new System.EventHandler(this.botonRegistrarse_Click);
            // 
            // RegistrarEmpresaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 411);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.botonRegistrarse);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegistrarEmpresaForm";
            this.Text = "RegistrarEmpresaForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private Extensiones.TextBoxRequerido boxRazon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
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
        private Extensiones.TextBoxRequerido boxCUIT;
        private System.Windows.Forms.GroupBox groupBox4;
        private Extensiones.TextBoxRequerido boxMail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox boxTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Button botonRegistrarse;
        private Extensiones.TextBoxRequerido boxContraseña;
        private Extensiones.TextBoxRequerido boxUsuario;
    }
}