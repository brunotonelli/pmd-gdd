namespace PalcoNet.Forms
{
    partial class PuntosForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelPuntos = new System.Windows.Forms.Label();
            this.labelVencidos = new System.Windows.Forms.Label();
            this.panelPremios = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Puntos";
            // 
            // labelPuntos
            // 
            this.labelPuntos.Font = new System.Drawing.Font("Bahnschrift SemiBold", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPuntos.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelPuntos.Location = new System.Drawing.Point(143, 9);
            this.labelPuntos.Name = "labelPuntos";
            this.labelPuntos.Size = new System.Drawing.Size(360, 46);
            this.labelPuntos.TabIndex = 1;
            this.labelPuntos.Text = "####";
            this.labelPuntos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelVencidos
            // 
            this.labelVencidos.Font = new System.Drawing.Font("Bahnschrift SemiBold", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVencidos.ForeColor = System.Drawing.Color.Maroon;
            this.labelVencidos.Location = new System.Drawing.Point(473, 9);
            this.labelVencidos.Name = "labelVencidos";
            this.labelVencidos.Size = new System.Drawing.Size(119, 46);
            this.labelVencidos.TabIndex = 2;
            this.labelVencidos.Text = "####";
            this.labelVencidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelPremios
            // 
            this.panelPremios.Location = new System.Drawing.Point(20, 115);
            this.panelPremios.Name = "panelPremios";
            this.panelPremios.Size = new System.Drawing.Size(645, 360);
            this.panelPremios.TabIndex = 3;
            // 
            // PuntosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 499);
            this.Controls.Add(this.panelPremios);
            this.Controls.Add(this.labelVencidos);
            this.Controls.Add(this.labelPuntos);
            this.Controls.Add(this.label1);
            this.Name = "PuntosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PuntosForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPuntos;
        private System.Windows.Forms.Label labelVencidos;
        private System.Windows.Forms.Panel panelPremios;
    }
}