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
            this.boxTipoDoc = new System.Windows.Forms.ComboBox();
            this.boxNroDoc = new PalcoNet.Extensiones.TextBoxRequerido();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.boxApellido = new PalcoNet.Extensiones.TextBoxRequerido();
            this.boxNombre = new PalcoNet.Extensiones.TextBoxRequerido();
            this.boxCUIL = new System.Windows.Forms.TextBox();
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
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(47, 519);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(285, 17);
            this.label13.TabIndex = 46;
            this.label13.Text = "Los campos marcados con * son requeridos";
            // 
            // botonCancelar
            // 
            this.botonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCancelar.Location = new System.Drawing.Point(388, 505);
            this.botonCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(159, 46);
            this.botonCancelar.TabIndex = 45;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.boxMail);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.boxTelefono);
            this.groupBox3.Location = new System.Drawing.Point(27, 348);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(339, 134);
            this.groupBox3.TabIndex = 44;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos de contacto";
            // 
            // boxMail
            // 
            this.boxMail.BackColor = System.Drawing.Color.Tomato;
            this.boxMail.Location = new System.Drawing.Point(112, 39);
            this.boxMail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxMail.Name = "boxMail";
            this.boxMail.Padding = new System.Windows.Forms.Padding(1);
            this.boxMail.Size = new System.Drawing.Size(200, 22);
            this.boxMail.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "* Mail";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 89);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "Telefono";
            // 
            // boxTelefono
            // 
            this.boxTelefono.Location = new System.Drawing.Point(112, 85);
            this.boxTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxTelefono.Name = "boxTelefono";
            this.boxTelefono.Size = new System.Drawing.Size(199, 22);
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
            this.groupBox2.Location = new System.Drawing.Point(388, 30);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(356, 311);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de ubicación";
            // 
            // boxCalle
            // 
            this.boxCalle.Location = new System.Drawing.Point(129, 41);
            this.boxCalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxCalle.Name = "boxCalle";
            this.boxCalle.Size = new System.Drawing.Size(199, 22);
            this.boxCalle.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 44);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Calle";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 223);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Codigo postal";
            // 
            // boxNumero
            // 
            this.boxNumero.Location = new System.Drawing.Point(129, 86);
            this.boxNumero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxNumero.Name = "boxNumero";
            this.boxNumero.Size = new System.Drawing.Size(199, 22);
            this.boxNumero.TabIndex = 13;
            // 
            // boxCodigoPostal
            // 
            this.boxCodigoPostal.Location = new System.Drawing.Point(129, 219);
            this.boxCodigoPostal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxCodigoPostal.Name = "boxCodigoPostal";
            this.boxCodigoPostal.Size = new System.Drawing.Size(199, 22);
            this.boxCodigoPostal.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 90);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Numero";
            // 
            // boxLocalidad
            // 
            this.boxLocalidad.Location = new System.Drawing.Point(129, 263);
            this.boxLocalidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxLocalidad.Name = "boxLocalidad";
            this.boxLocalidad.Size = new System.Drawing.Size(199, 22);
            this.boxLocalidad.TabIndex = 27;
            // 
            // boxPiso
            // 
            this.boxPiso.Location = new System.Drawing.Point(129, 130);
            this.boxPiso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxPiso.Name = "boxPiso";
            this.boxPiso.Size = new System.Drawing.Size(199, 22);
            this.boxPiso.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 178);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Departamento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 134);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Piso";
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Location = new System.Drawing.Point(23, 267);
            this.label100.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(69, 17);
            this.label100.TabIndex = 28;
            this.label100.Text = "Localidad";
            // 
            // boxDepartamento
            // 
            this.boxDepartamento.Location = new System.Drawing.Point(129, 175);
            this.boxDepartamento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxDepartamento.Name = "boxDepartamento";
            this.boxDepartamento.Size = new System.Drawing.Size(199, 22);
            this.boxDepartamento.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.boxTipoDoc);
            this.groupBox1.Controls.Add(this.boxNroDoc);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.boxApellido);
            this.groupBox1.Controls.Add(this.boxNombre);
            this.groupBox1.Controls.Add(this.boxCUIL);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.boxFecha);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(339, 311);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos personales";
            // 
            // boxTipoDoc
            // 
            this.boxTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.boxTipoDoc.Location = new System.Drawing.Point(111, 130);
            this.boxTipoDoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxTipoDoc.Name = "boxTipoDoc";
            this.boxTipoDoc.Size = new System.Drawing.Size(201, 25);
            this.boxTipoDoc.TabIndex = 41;
            // 
            // boxNroDoc
            // 
            this.boxNroDoc.BackColor = System.Drawing.Color.Tomato;
            this.boxNroDoc.Location = new System.Drawing.Point(112, 178);
            this.boxNroDoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxNroDoc.Name = "boxNroDoc";
            this.boxNroDoc.Padding = new System.Windows.Forms.Padding(1);
            this.boxNroDoc.Size = new System.Drawing.Size(200, 23);
            this.boxNroDoc.TabIndex = 38;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 178);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(103, 17);
            this.label18.TabIndex = 37;
            this.label18.Text = "* Num. de Doc.";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 132);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 17);
            this.label15.TabIndex = 35;
            this.label15.Text = "* Tipo de Doc.";
            // 
            // boxApellido
            // 
            this.boxApellido.BackColor = System.Drawing.Color.Tomato;
            this.boxApellido.Location = new System.Drawing.Point(112, 90);
            this.boxApellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxApellido.Name = "boxApellido";
            this.boxApellido.Padding = new System.Windows.Forms.Padding(1);
            this.boxApellido.Size = new System.Drawing.Size(200, 23);
            this.boxApellido.TabIndex = 26;
            // 
            // boxNombre
            // 
            this.boxNombre.BackColor = System.Drawing.Color.Tomato;
            this.boxNombre.Location = new System.Drawing.Point(112, 44);
            this.boxNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxNombre.Name = "boxNombre";
            this.boxNombre.Padding = new System.Windows.Forms.Padding(1);
            this.boxNombre.Size = new System.Drawing.Size(200, 23);
            this.boxNombre.TabIndex = 25;
            // 
            // boxCUIL
            // 
            this.boxCUIL.Location = new System.Drawing.Point(111, 223);
            this.boxCUIL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxCUIL.Name = "boxCUIL";
            this.boxCUIL.Size = new System.Drawing.Size(199, 23);
            this.boxCUIL.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "* Nombre";
            // 
            // boxFecha
            // 
            this.boxFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.boxFecha.Location = new System.Drawing.Point(177, 268);
            this.boxFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxFecha.Name = "boxFecha";
            this.boxFecha.Size = new System.Drawing.Size(132, 23);
            this.boxFecha.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 272);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha de Nacimiento";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 226);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 17);
            this.label12.TabIndex = 24;
            this.label12.Text = "CUIL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "* Apellido";
            // 
            // botonGuardar
            // 
            this.botonGuardar.Enabled = false;
            this.botonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonGuardar.Location = new System.Drawing.Point(583, 505);
            this.botonGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(161, 46);
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
            this.groupBox5.Location = new System.Drawing.Point(388, 348);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(356, 134);
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
            this.boxTipoTarjeta.Location = new System.Drawing.Point(96, 34);
            this.boxTipoTarjeta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxTipoTarjeta.Name = "boxTipoTarjeta";
            this.boxTipoTarjeta.Size = new System.Drawing.Size(199, 24);
            this.boxTipoTarjeta.TabIndex = 40;
            // 
            // boxNroTarjeta
            // 
            this.boxNroTarjeta.Location = new System.Drawing.Point(96, 81);
            this.boxNroTarjeta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxNroTarjeta.Name = "boxNroTarjeta";
            this.boxNroTarjeta.Size = new System.Drawing.Size(199, 22);
            this.boxNroTarjeta.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(23, 39);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 17);
            this.label14.TabIndex = 10;
            this.label14.Text = "Tipo";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(23, 85);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 17);
            this.label19.TabIndex = 22;
            this.label19.Text = "Numero";
            // 
            // ModifClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 569);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.botonGuardar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ModifClientesForm";
            this.Text = "[PalcoNet] - Modificar Cliente";
            this.Load += new System.EventHandler(this.ModifClientesForm_Load);
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
        private System.Windows.Forms.TextBox boxCUIL;
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
    }
}