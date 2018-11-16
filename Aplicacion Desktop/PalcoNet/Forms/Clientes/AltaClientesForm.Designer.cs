using PalcoNet.Extensiones;

namespace PalcoNet.Forms.Clientes
{
    partial class AltaClientesForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.boxCalle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.boxNumero = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.boxPiso = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.boxDepartamento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.boxCodigoPostal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.boxTelefono = new System.Windows.Forms.TextBox();
            this.label100 = new System.Windows.Forms.Label();
            this.boxLocalidad = new System.Windows.Forms.TextBox();
            this.botonCrear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.boxCUIL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boxFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.boxNombre = new PalcoNet.Extensiones.TextBoxRequerido();
            this.boxApellido = new PalcoNet.Extensiones.TextBoxRequerido();
            this.boxDNI = new PalcoNet.Extensiones.TextBoxRequerido();
            this.boxMail = new PalcoNet.Extensiones.TextBoxRequerido();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "* Mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Calle";
            // 
            // boxCalle
            // 
            this.boxCalle.Location = new System.Drawing.Point(97, 33);
            this.boxCalle.Name = "boxCalle";
            this.boxCalle.Size = new System.Drawing.Size(150, 20);
            this.boxCalle.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Numero";
            // 
            // boxNumero
            // 
            this.boxNumero.Location = new System.Drawing.Point(97, 70);
            this.boxNumero.Name = "boxNumero";
            this.boxNumero.Size = new System.Drawing.Size(150, 20);
            this.boxNumero.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Piso";
            // 
            // boxPiso
            // 
            this.boxPiso.Location = new System.Drawing.Point(97, 106);
            this.boxPiso.Name = "boxPiso";
            this.boxPiso.Size = new System.Drawing.Size(150, 20);
            this.boxPiso.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Departamento";
            // 
            // boxDepartamento
            // 
            this.boxDepartamento.Location = new System.Drawing.Point(97, 142);
            this.boxDepartamento.Name = "boxDepartamento";
            this.boxDepartamento.Size = new System.Drawing.Size(150, 20);
            this.boxDepartamento.TabIndex = 17;
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
            // boxCodigoPostal
            // 
            this.boxCodigoPostal.Location = new System.Drawing.Point(97, 178);
            this.boxCodigoPostal.Name = "boxCodigoPostal";
            this.boxCodigoPostal.Size = new System.Drawing.Size(150, 20);
            this.boxCodigoPostal.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Telefono";
            // 
            // boxTelefono
            // 
            this.boxTelefono.Location = new System.Drawing.Point(84, 69);
            this.boxTelefono.Name = "boxTelefono";
            this.boxTelefono.Size = new System.Drawing.Size(150, 20);
            this.boxTelefono.TabIndex = 21;
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
            // boxLocalidad
            // 
            this.boxLocalidad.Location = new System.Drawing.Point(97, 214);
            this.boxLocalidad.Name = "boxLocalidad";
            this.boxLocalidad.Size = new System.Drawing.Size(150, 20);
            this.boxLocalidad.TabIndex = 27;
            // 
            // botonCrear
            // 
            this.botonCrear.Enabled = false;
            this.botonCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCrear.Location = new System.Drawing.Point(429, 332);
            this.botonCrear.Name = "botonCrear";
            this.botonCrear.Size = new System.Drawing.Size(121, 37);
            this.botonCrear.TabIndex = 29;
            this.botonCrear.Text = "Crear";
            this.botonCrear.UseVisualStyleBackColor = true;
            this.botonCrear.Click += new System.EventHandler(this.botonCrear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.boxDNI);
            this.groupBox1.Controls.Add(this.boxApellido);
            this.groupBox1.Controls.Add(this.boxNombre);
            this.groupBox1.Controls.Add(this.boxCUIL);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.boxFecha);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 217);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos personales";
            // 
            // boxCUIL
            // 
            this.boxCUIL.Location = new System.Drawing.Point(84, 144);
            this.boxCUIL.Name = "boxCUIL";
            this.boxCUIL.Size = new System.Drawing.Size(150, 20);
            this.boxCUIL.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "* Nombre";
            // 
            // boxFecha
            // 
            this.boxFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.boxFecha.Location = new System.Drawing.Point(134, 181);
            this.boxFecha.Name = "boxFecha";
            this.boxFecha.Size = new System.Drawing.Size(100, 20);
            this.boxFecha.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha de Nacimiento";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 147);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "CUIL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "* Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "* DNI";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.boxCalle);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.boxNumero);
            this.groupBox2.Controls.Add(this.boxCodigoPostal);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.boxLocalidad);
            this.groupBox2.Controls.Add(this.boxPiso);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label100);
            this.groupBox2.Controls.Add(this.boxDepartamento);
            this.groupBox2.Location = new System.Drawing.Point(283, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 253);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de ubicación";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.boxMail);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.boxTelefono);
            this.groupBox3.Location = new System.Drawing.Point(12, 260);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(254, 109);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos de contacto";
            // 
            // botonCancelar
            // 
            this.botonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCancelar.Location = new System.Drawing.Point(283, 332);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(119, 37);
            this.botonCancelar.TabIndex = 39;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(307, 300);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(213, 13);
            this.label13.TabIndex = 40;
            this.label13.Text = "Los campos marcados con * son requeridos";
            // 
            // boxNombre
            // 
            this.boxNombre.BackColor = System.Drawing.Color.Tomato;
            this.boxNombre.Location = new System.Drawing.Point(84, 36);
            this.boxNombre.Name = "boxNombre";
            this.boxNombre.Padding = new System.Windows.Forms.Padding(1);
            this.boxNombre.Size = new System.Drawing.Size(150, 20);
            this.boxNombre.TabIndex = 25;
            // 
            // boxApellido
            // 
            this.boxApellido.BackColor = System.Drawing.Color.Tomato;
            this.boxApellido.Location = new System.Drawing.Point(84, 73);
            this.boxApellido.Name = "boxApellido";
            this.boxApellido.Padding = new System.Windows.Forms.Padding(1);
            this.boxApellido.Size = new System.Drawing.Size(150, 20);
            this.boxApellido.TabIndex = 26;
            // 
            // boxDNI
            // 
            this.boxDNI.BackColor = System.Drawing.Color.Tomato;
            this.boxDNI.Location = new System.Drawing.Point(84, 111);
            this.boxDNI.Name = "boxDNI";
            this.boxDNI.Padding = new System.Windows.Forms.Padding(1);
            this.boxDNI.Size = new System.Drawing.Size(150, 20);
            this.boxDNI.TabIndex = 27;
            // 
            // boxMail
            // 
            this.boxMail.BackColor = System.Drawing.Color.Tomato;
            this.boxMail.Location = new System.Drawing.Point(84, 32);
            this.boxMail.Name = "boxMail";
            this.boxMail.Padding = new System.Windows.Forms.Padding(1);
            this.boxMail.Size = new System.Drawing.Size(150, 20);
            this.boxMail.TabIndex = 28;
            // 
            // AltaClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 395);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.botonCrear);
            this.Name = "AltaClientesForm";
            this.Text = "[PalcoNet] - Nuevo Cliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox boxCalle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox boxNumero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox boxPiso;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox boxDepartamento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox boxCodigoPostal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox boxTelefono;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.TextBox boxLocalidad;
        private System.Windows.Forms.Button botonCrear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox boxCUIL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker boxFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Label label13;
        private TextBoxRequerido boxDNI;
        private TextBoxRequerido boxApellido;
        private TextBoxRequerido boxNombre;
        private TextBoxRequerido boxMail;
    }
}