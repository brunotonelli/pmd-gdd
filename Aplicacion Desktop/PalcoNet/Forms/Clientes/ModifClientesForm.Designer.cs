namespace PalcoNet.Forms
{
    partial class ModifClientesForm
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
            this.label13 = new System.Windows.Forms.Label();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.boxMail = new PalcoNet.Extensiones.TextBoxRequerido();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.boxTelefono = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.boxCalle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.boxNumero = new System.Windows.Forms.TextBox();
            this.boxCodigoPostal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.boxLocalidad = new System.Windows.Forms.TextBox();
            this.boxPiso = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.boxDepartamento = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.boxCUIL = new System.Windows.Forms.TextBox();
            this.boxTipoDoc = new System.Windows.Forms.ComboBox();
            this.boxNroDoc = new PalcoNet.Extensiones.TextBoxRequerido();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.boxApellido = new PalcoNet.Extensiones.TextBoxRequerido();
            this.boxNombre = new PalcoNet.Extensiones.TextBoxRequerido();
            this.label1 = new System.Windows.Forms.Label();
            this.boxFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.boxTipoTarjeta = new System.Windows.Forms.ComboBox();
            this.boxNroTarjeta = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.checkHabilitado = new System.Windows.Forms.CheckBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(35, 434);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(213, 13);
            this.label13.TabIndex = 46;
            this.label13.Text = "Los campos marcados con * son requeridos";
            // 
            // botonCancelar
            // 
            this.botonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCancelar.Location = new System.Drawing.Point(291, 410);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(119, 37);
            this.botonCancelar.TabIndex = 45;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.boxMail);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.boxTelefono);
            this.groupBox3.Location = new System.Drawing.Point(20, 283);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(254, 109);
            this.groupBox3.TabIndex = 44;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos de contacto";
            // 
            // boxMail
            // 
            this.boxMail.BackColor = System.Drawing.Color.Tomato;
            this.boxMail.Location = new System.Drawing.Point(84, 32);
            this.boxMail.Name = "boxMail";
            this.boxMail.Padding = new System.Windows.Forms.Padding(1);
            this.boxMail.Size = new System.Drawing.Size(150, 20);
            this.boxMail.TabIndex = 28;
            this.boxMail.TipoTextbox = PalcoNet.Extensiones.TextBoxRequerido.Tipo.Normal;
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
            this.groupBox2.Location = new System.Drawing.Point(291, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 253);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de ubicación";
            // 
            // boxCalle
            // 
            this.boxCalle.Location = new System.Drawing.Point(97, 33);
            this.boxCalle.Name = "boxCalle";
            this.boxCalle.Size = new System.Drawing.Size(150, 20);
            this.boxCalle.TabIndex = 11;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Numero";
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Departamento";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.boxCUIL);
            this.groupBox1.Controls.Add(this.boxTipoDoc);
            this.groupBox1.Controls.Add(this.boxNroDoc);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.boxApellido);
            this.groupBox1.Controls.Add(this.boxNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.boxFecha);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 253);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos personales";
            // 
            // boxCUIL
            // 
            this.boxCUIL.Location = new System.Drawing.Point(84, 181);
            this.boxCUIL.Name = "boxCUIL";
            this.boxCUIL.Size = new System.Drawing.Size(151, 20);
            this.boxCUIL.TabIndex = 42;
            // 
            // boxTipoDoc
            // 
            this.boxTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxTipoDoc.Enabled = false;
            this.boxTipoDoc.FormattingEnabled = true;
            this.boxTipoDoc.Items.AddRange(new object[] {
            "DNI",
            "Libreta electoral",
            "Carnet de extranjeria",
            "Reg. unico de contribuyentes",
            "Pasaporte",
            "Part. de nacimiento-identidad",
            "Otros",
            "N/E"});
            this.boxTipoDoc.Location = new System.Drawing.Point(83, 106);
            this.boxTipoDoc.Name = "boxTipoDoc";
            this.boxTipoDoc.Size = new System.Drawing.Size(152, 21);
            this.boxTipoDoc.TabIndex = 41;
            // 
            // boxNroDoc
            // 
            this.boxNroDoc.BackColor = System.Drawing.Color.Tomato;
            this.boxNroDoc.Enabled = false;
            this.boxNroDoc.Location = new System.Drawing.Point(84, 145);
            this.boxNroDoc.Name = "boxNroDoc";
            this.boxNroDoc.Padding = new System.Windows.Forms.Padding(1);
            this.boxNroDoc.Size = new System.Drawing.Size(150, 20);
            this.boxNroDoc.TabIndex = 38;
            this.boxNroDoc.TipoTextbox = PalcoNet.Extensiones.TextBoxRequerido.Tipo.Normal;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(2, 145);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 13);
            this.label18.TabIndex = 37;
            this.label18.Text = "* Num. de Doc.";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(2, 107);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 13);
            this.label15.TabIndex = 35;
            this.label15.Text = "* Tipo de Doc.";
            // 
            // boxApellido
            // 
            this.boxApellido.BackColor = System.Drawing.Color.Tomato;
            this.boxApellido.Location = new System.Drawing.Point(84, 73);
            this.boxApellido.Name = "boxApellido";
            this.boxApellido.Padding = new System.Windows.Forms.Padding(1);
            this.boxApellido.Size = new System.Drawing.Size(150, 20);
            this.boxApellido.TabIndex = 26;
            this.boxApellido.TipoTextbox = PalcoNet.Extensiones.TextBoxRequerido.Tipo.Normal;
            // 
            // boxNombre
            // 
            this.boxNombre.BackColor = System.Drawing.Color.Tomato;
            this.boxNombre.Location = new System.Drawing.Point(84, 36);
            this.boxNombre.Name = "boxNombre";
            this.boxNombre.Padding = new System.Windows.Forms.Padding(1);
            this.boxNombre.Size = new System.Drawing.Size(150, 20);
            this.boxNombre.TabIndex = 25;
            this.boxNombre.TipoTextbox = PalcoNet.Extensiones.TextBoxRequerido.Tipo.Normal;
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
            this.boxFecha.Location = new System.Drawing.Point(133, 218);
            this.boxFecha.Name = "boxFecha";
            this.boxFecha.Size = new System.Drawing.Size(100, 20);
            this.boxFecha.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha de Nacimiento";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 184);
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
            // botonGuardar
            // 
            this.botonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonGuardar.Location = new System.Drawing.Point(437, 410);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(121, 37);
            this.botonGuardar.TabIndex = 41;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.UseVisualStyleBackColor = true;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.boxTipoTarjeta);
            this.groupBox5.Controls.Add(this.boxNroTarjeta);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Location = new System.Drawing.Point(291, 283);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(267, 109);
            this.groupBox5.TabIndex = 49;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tarjeta asociada";
            // 
            // boxTipoTarjeta
            // 
            this.boxTipoTarjeta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxTipoTarjeta.FormattingEnabled = true;
            this.boxTipoTarjeta.Items.AddRange(new object[] {
            "Visa",
            "MasterCard",
            "American Express"});
            this.boxTipoTarjeta.Location = new System.Drawing.Point(72, 28);
            this.boxTipoTarjeta.Name = "boxTipoTarjeta";
            this.boxTipoTarjeta.Size = new System.Drawing.Size(150, 21);
            this.boxTipoTarjeta.TabIndex = 40;
            // 
            // boxNroTarjeta
            // 
            this.boxNroTarjeta.Location = new System.Drawing.Point(72, 66);
            this.boxNroTarjeta.Name = "boxNroTarjeta";
            this.boxNroTarjeta.Size = new System.Drawing.Size(150, 20);
            this.boxNroTarjeta.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Tipo";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(17, 69);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 13);
            this.label19.TabIndex = 22;
            this.label19.Text = "Numero";
            // 
            // checkHabilitado
            // 
            this.checkHabilitado.AutoSize = true;
            this.checkHabilitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkHabilitado.Location = new System.Drawing.Point(66, 402);
            this.checkHabilitado.Name = "checkHabilitado";
            this.checkHabilitado.Size = new System.Drawing.Size(152, 24);
            this.checkHabilitado.TabIndex = 50;
            this.checkHabilitado.Text = "Cliente Habilitado";
            this.checkHabilitado.UseVisualStyleBackColor = true;
            // 
            // ModifClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 462);
            this.Controls.Add(this.checkHabilitado);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.botonGuardar);
            this.Name = "ModifClientesForm";
            this.Text = "[PalcoNet] - Modificar Cliente";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.GroupBox groupBox3;
        private Extensiones.TextBoxRequerido boxMail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox boxTelefono;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox boxCalle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox boxNumero;
        private System.Windows.Forms.TextBox boxCodigoPostal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox boxLocalidad;
        private System.Windows.Forms.TextBox boxPiso;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.TextBox boxDepartamento;
        private System.Windows.Forms.GroupBox groupBox1;
        private Extensiones.TextBoxRequerido boxApellido;
        private Extensiones.TextBoxRequerido boxNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker boxFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botonGuardar;
        private Extensiones.TextBoxRequerido boxNroDoc;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox boxNroTarjeta;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox boxTipoDoc;
        private System.Windows.Forms.ComboBox boxTipoTarjeta;
        private System.Windows.Forms.TextBox boxCUIL;
        private System.Windows.Forms.CheckBox checkHabilitado;
    }
}