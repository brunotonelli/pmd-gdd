namespace PalcoNet.Forms
{
    partial class MenuForm
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
            this.botonRoles = new System.Windows.Forms.Button();
            this.botonClientes = new System.Windows.Forms.Button();
            this.botonEmpresas = new System.Windows.Forms.Button();
            this.botonRubros = new System.Windows.Forms.Button();
            this.botonGenerar = new System.Windows.Forms.Button();
            this.botonEditar = new System.Windows.Forms.Button();
            this.botonComprar = new System.Windows.Forms.Button();
            this.botonHistorial = new System.Windows.Forms.Button();
            this.botonPuntos = new System.Windows.Forms.Button();
            this.botonComisiones = new System.Windows.Forms.Button();
            this.botonListado = new System.Windows.Forms.Button();
            this.botonGrados = new System.Windows.Forms.Button();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.botonLogout = new System.Windows.Forms.Button();
            this.botonCuenta = new System.Windows.Forms.Button();
            this.labelRol = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonRoles
            // 
            this.botonRoles.Location = new System.Drawing.Point(6, 65);
            this.botonRoles.Name = "botonRoles";
            this.botonRoles.Size = new System.Drawing.Size(120, 40);
            this.botonRoles.TabIndex = 0;
            this.botonRoles.Text = "ABM de Rol";
            this.botonRoles.UseVisualStyleBackColor = true;
            this.botonRoles.Click += new System.EventHandler(this.botonRoles_Click);
            // 
            // botonClientes
            // 
            this.botonClientes.Location = new System.Drawing.Point(6, 19);
            this.botonClientes.Name = "botonClientes";
            this.botonClientes.Size = new System.Drawing.Size(120, 40);
            this.botonClientes.TabIndex = 1;
            this.botonClientes.Text = "ABM de Clientes";
            this.botonClientes.UseVisualStyleBackColor = true;
            this.botonClientes.Click += new System.EventHandler(this.botonClientes_Click);
            // 
            // botonEmpresas
            // 
            this.botonEmpresas.Location = new System.Drawing.Point(132, 19);
            this.botonEmpresas.Name = "botonEmpresas";
            this.botonEmpresas.Size = new System.Drawing.Size(120, 40);
            this.botonEmpresas.TabIndex = 2;
            this.botonEmpresas.Text = "ABM de Empresa";
            this.botonEmpresas.UseVisualStyleBackColor = true;
            this.botonEmpresas.Click += new System.EventHandler(this.botonEmpresas_Click);
            // 
            // botonRubros
            // 
            this.botonRubros.Location = new System.Drawing.Point(132, 65);
            this.botonRubros.Name = "botonRubros";
            this.botonRubros.Size = new System.Drawing.Size(120, 40);
            this.botonRubros.TabIndex = 3;
            this.botonRubros.Text = "ABM de Rubro";
            this.botonRubros.UseVisualStyleBackColor = true;
            this.botonRubros.Click += new System.EventHandler(this.botonRubros_Click);
            // 
            // botonGenerar
            // 
            this.botonGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonGenerar.Location = new System.Drawing.Point(6, 88);
            this.botonGenerar.Name = "botonGenerar";
            this.botonGenerar.Size = new System.Drawing.Size(246, 57);
            this.botonGenerar.TabIndex = 4;
            this.botonGenerar.Text = "Generar Publicación";
            this.botonGenerar.UseVisualStyleBackColor = true;
            // 
            // botonEditar
            // 
            this.botonEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonEditar.Location = new System.Drawing.Point(6, 158);
            this.botonEditar.Name = "botonEditar";
            this.botonEditar.Size = new System.Drawing.Size(246, 57);
            this.botonEditar.TabIndex = 5;
            this.botonEditar.Text = "Editar Publicación";
            this.botonEditar.UseVisualStyleBackColor = true;
            // 
            // botonComprar
            // 
            this.botonComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonComprar.Location = new System.Drawing.Point(6, 19);
            this.botonComprar.Name = "botonComprar";
            this.botonComprar.Size = new System.Drawing.Size(246, 57);
            this.botonComprar.TabIndex = 6;
            this.botonComprar.Text = "Comprar";
            this.botonComprar.UseVisualStyleBackColor = true;
            this.botonComprar.Click += new System.EventHandler(this.botonComprar_Click);
            // 
            // botonHistorial
            // 
            this.botonHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonHistorial.Location = new System.Drawing.Point(6, 24);
            this.botonHistorial.Name = "botonHistorial";
            this.botonHistorial.Size = new System.Drawing.Size(124, 64);
            this.botonHistorial.TabIndex = 7;
            this.botonHistorial.Text = "Historial de Cliente";
            this.botonHistorial.UseVisualStyleBackColor = true;
            // 
            // botonPuntos
            // 
            this.botonPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonPuntos.Location = new System.Drawing.Point(136, 24);
            this.botonPuntos.Name = "botonPuntos";
            this.botonPuntos.Size = new System.Drawing.Size(124, 64);
            this.botonPuntos.TabIndex = 8;
            this.botonPuntos.Text = "Administración de Puntos";
            this.botonPuntos.UseVisualStyleBackColor = true;
            // 
            // botonComisiones
            // 
            this.botonComisiones.Location = new System.Drawing.Point(6, 157);
            this.botonComisiones.Name = "botonComisiones";
            this.botonComisiones.Size = new System.Drawing.Size(120, 58);
            this.botonComisiones.TabIndex = 9;
            this.botonComisiones.Text = "Generar rendición de Comisiones";
            this.botonComisiones.UseVisualStyleBackColor = true;
            // 
            // botonListado
            // 
            this.botonListado.Location = new System.Drawing.Point(132, 157);
            this.botonListado.Name = "botonListado";
            this.botonListado.Size = new System.Drawing.Size(120, 58);
            this.botonListado.TabIndex = 10;
            this.botonListado.Text = "Listado estadístico";
            this.botonListado.UseVisualStyleBackColor = true;
            // 
            // botonGrados
            // 
            this.botonGrados.Location = new System.Drawing.Point(6, 111);
            this.botonGrados.Name = "botonGrados";
            this.botonGrados.Size = new System.Drawing.Size(246, 40);
            this.botonGrados.TabIndex = 11;
            this.botonGrados.Text = "ABM de Grado de Publicación";
            this.botonGrados.UseVisualStyleBackColor = true;
            this.botonGrados.Click += new System.EventHandler(this.botonGrados_Click);
            // 
            // labelUsuario
            // 
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelUsuario.Location = new System.Drawing.Point(282, 24);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(251, 26);
            this.labelUsuario.TabIndex = 20;
            this.labelUsuario.Text = "NOMBRE_USUARIO";
            this.labelUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // botonLogout
            // 
            this.botonLogout.Location = new System.Drawing.Point(369, 59);
            this.botonLogout.Name = "botonLogout";
            this.botonLogout.Size = new System.Drawing.Size(164, 29);
            this.botonLogout.TabIndex = 15;
            this.botonLogout.Text = "Cerrar sesión";
            this.botonLogout.UseVisualStyleBackColor = true;
            // 
            // botonCuenta
            // 
            this.botonCuenta.Location = new System.Drawing.Point(281, 59);
            this.botonCuenta.Name = "botonCuenta";
            this.botonCuenta.Size = new System.Drawing.Size(82, 29);
            this.botonCuenta.TabIndex = 16;
            this.botonCuenta.Text = "Cuenta";
            this.botonCuenta.UseVisualStyleBackColor = true;
            // 
            // labelRol
            // 
            this.labelRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRol.ForeColor = System.Drawing.Color.Maroon;
            this.labelRol.Location = new System.Drawing.Point(241, 23);
            this.labelRol.Name = "labelRol";
            this.labelRol.Size = new System.Drawing.Size(318, 32);
            this.labelRol.TabIndex = 14;
            this.labelRol.Text = "ROL_USUARIO";
            this.labelRol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.botonClientes);
            this.groupBox1.Controls.Add(this.botonRoles);
            this.groupBox1.Controls.Add(this.botonEmpresas);
            this.groupBox1.Controls.Add(this.botonRubros);
            this.groupBox1.Controls.Add(this.botonComisiones);
            this.groupBox1.Controls.Add(this.botonListado);
            this.groupBox1.Controls.Add(this.botonGrados);
            this.groupBox1.Location = new System.Drawing.Point(300, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 224);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administrativo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.botonEditar);
            this.groupBox2.Controls.Add(this.botonGenerar);
            this.groupBox2.Controls.Add(this.botonComprar);
            this.groupBox2.Location = new System.Drawing.Point(19, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 224);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Espectaculos";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelUsuario);
            this.groupBox3.Controls.Add(this.botonHistorial);
            this.groupBox3.Controls.Add(this.botonPuntos);
            this.groupBox3.Controls.Add(this.botonCuenta);
            this.groupBox3.Controls.Add(this.botonLogout);
            this.groupBox3.Location = new System.Drawing.Point(19, 319);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(540, 98);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "Menú principal";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 432);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelRol);
            this.Controls.Add(this.label1);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonRoles;
        private System.Windows.Forms.Button botonClientes;
        private System.Windows.Forms.Button botonEmpresas;
        private System.Windows.Forms.Button botonRubros;
        private System.Windows.Forms.Button botonGenerar;
        private System.Windows.Forms.Button botonEditar;
        private System.Windows.Forms.Button botonComprar;
        private System.Windows.Forms.Button botonHistorial;
        private System.Windows.Forms.Button botonPuntos;
        private System.Windows.Forms.Button botonComisiones;
        private System.Windows.Forms.Button botonListado;
        private System.Windows.Forms.Button botonGrados;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Button botonLogout;
        private System.Windows.Forms.Button botonCuenta;
        private System.Windows.Forms.Label labelRol;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
    }
}