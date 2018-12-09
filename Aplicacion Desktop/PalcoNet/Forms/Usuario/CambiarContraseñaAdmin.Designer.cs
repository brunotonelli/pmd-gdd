namespace PalcoNet.Forms
{
    partial class CambiarContraseñaAdmin
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
            this.botonConfirmar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.boxConfirmar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boxNueva = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botonConfirmar
            // 
            this.botonConfirmar.Location = new System.Drawing.Point(27, 141);
            this.botonConfirmar.Name = "botonConfirmar";
            this.botonConfirmar.Size = new System.Drawing.Size(241, 23);
            this.botonConfirmar.TabIndex = 15;
            this.botonConfirmar.Text = "Guardar cambio";
            this.botonConfirmar.UseVisualStyleBackColor = true;
            this.botonConfirmar.Click += new System.EventHandler(this.botonConfirmar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Confirmar contraseña";
            // 
            // boxConfirmar
            // 
            this.boxConfirmar.Location = new System.Drawing.Point(125, 101);
            this.boxConfirmar.Name = "boxConfirmar";
            this.boxConfirmar.Size = new System.Drawing.Size(143, 20);
            this.boxConfirmar.TabIndex = 13;
            this.boxConfirmar.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nueva contraseña";
            // 
            // boxNueva
            // 
            this.boxNueva.Location = new System.Drawing.Point(125, 63);
            this.boxNueva.Name = "boxNueva";
            this.boxNueva.Size = new System.Drawing.Size(143, 20);
            this.boxNueva.TabIndex = 11;
            this.boxNueva.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Cambiando contraseña para usuario";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(1, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(288, 22);
            this.label4.TabIndex = 17;
            this.label4.Text = "USUARIO";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CambiarContraseñaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 186);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonConfirmar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boxConfirmar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxNueva);
            this.Name = "CambiarContraseñaAdmin";
            this.Text = "CambiarContraseñaAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonConfirmar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox boxConfirmar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boxNueva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}