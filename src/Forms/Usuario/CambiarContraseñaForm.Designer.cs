namespace PalcoNet.Forms
{
    partial class CambiarContraseñaForm
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
            this.boxActual = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.boxNueva = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.boxConfirmar = new System.Windows.Forms.TextBox();
            this.botonConfirmar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // boxActual
            // 
            this.boxActual.Location = new System.Drawing.Point(135, 28);
            this.boxActual.Name = "boxActual";
            this.boxActual.Size = new System.Drawing.Size(143, 20);
            this.boxActual.TabIndex = 0;
            this.boxActual.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contraseña actual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nueva contraseña";
            // 
            // boxNueva
            // 
            this.boxNueva.Location = new System.Drawing.Point(135, 88);
            this.boxNueva.Name = "boxNueva";
            this.boxNueva.Size = new System.Drawing.Size(143, 20);
            this.boxNueva.TabIndex = 2;
            this.boxNueva.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Confirmar contraseña";
            // 
            // boxConfirmar
            // 
            this.boxConfirmar.Location = new System.Drawing.Point(135, 126);
            this.boxConfirmar.Name = "boxConfirmar";
            this.boxConfirmar.Size = new System.Drawing.Size(143, 20);
            this.boxConfirmar.TabIndex = 4;
            this.boxConfirmar.UseSystemPasswordChar = true;
            // 
            // botonConfirmar
            // 
            this.botonConfirmar.Location = new System.Drawing.Point(37, 166);
            this.botonConfirmar.Name = "botonConfirmar";
            this.botonConfirmar.Size = new System.Drawing.Size(241, 23);
            this.botonConfirmar.TabIndex = 7;
            this.botonConfirmar.Text = "Guardar cambio";
            this.botonConfirmar.UseVisualStyleBackColor = true;
            this.botonConfirmar.Click += new System.EventHandler(this.botonConfirmar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "_______________________________________";
            // 
            // CambiarContraseñaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 211);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.botonConfirmar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boxConfirmar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxNueva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxActual);
            this.Name = "CambiarContraseñaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[PalcoNet] - Cambiar PW";
            this.Load += new System.EventHandler(this.CambiarContraseñaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boxActual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boxNueva;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox boxConfirmar;
        private System.Windows.Forms.Button botonConfirmar;
        private System.Windows.Forms.Label label4;
    }
}