namespace PalcoNet.Forms
{
    partial class RegistrarseForm
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
            this.botonEmpresa = new System.Windows.Forms.Button();
            this.botonCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botonEmpresa
            // 
            this.botonEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonEmpresa.Location = new System.Drawing.Point(40, 106);
            this.botonEmpresa.Name = "botonEmpresa";
            this.botonEmpresa.Size = new System.Drawing.Size(197, 62);
            this.botonEmpresa.TabIndex = 0;
            this.botonEmpresa.Text = "Empresa";
            this.botonEmpresa.UseVisualStyleBackColor = true;
            this.botonEmpresa.Click += new System.EventHandler(this.botonEmpresa_Click);
            // 
            // botonCliente
            // 
            this.botonCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCliente.Location = new System.Drawing.Point(243, 106);
            this.botonCliente.Name = "botonCliente";
            this.botonCliente.Size = new System.Drawing.Size(197, 62);
            this.botonCliente.TabIndex = 1;
            this.botonCliente.Text = "Cliente";
            this.botonCliente.UseVisualStyleBackColor = true;
            this.botonCliente.Click += new System.EventHandler(this.botonCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registrarse como";
            // 
            // RegistrarseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 204);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonCliente);
            this.Controls.Add(this.botonEmpresa);
            this.Name = "RegistrarseForm";
            this.Text = "Registrarse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonEmpresa;
        private System.Windows.Forms.Button botonCliente;
        private System.Windows.Forms.Label label1;
    }
}