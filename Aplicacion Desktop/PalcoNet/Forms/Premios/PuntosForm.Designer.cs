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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PuntosForm));
            this.label1 = new System.Windows.Forms.Label();
            this.labelPuntos = new System.Windows.Forms.Label();
            this.labelVencidos = new System.Windows.Forms.Label();
            this.panelPremios = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Puntos";
            // 
            // labelPuntos
            // 
            this.labelPuntos.Font = new System.Drawing.Font("Bahnschrift SemiBold", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPuntos.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelPuntos.Location = new System.Drawing.Point(191, 11);
            this.labelPuntos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPuntos.Name = "labelPuntos";
            this.labelPuntos.Size = new System.Drawing.Size(480, 57);
            this.labelPuntos.TabIndex = 1;
            this.labelPuntos.Text = "####";
            this.labelPuntos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelVencidos
            // 
            this.labelVencidos.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVencidos.ForeColor = System.Drawing.Color.Maroon;
            this.labelVencidos.Location = new System.Drawing.Point(743, 63);
            this.labelVencidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVencidos.Name = "labelVencidos";
            this.labelVencidos.Size = new System.Drawing.Size(144, 57);
            this.labelVencidos.TabIndex = 2;
            this.labelVencidos.Text = "####";
            this.labelVencidos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelPremios
            // 
            this.panelPremios.Location = new System.Drawing.Point(27, 142);
            this.panelPremios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelPremios.Name = "panelPremios";
            this.panelPremios.Size = new System.Drawing.Size(860, 443);
            this.panelPremios.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(743, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vencidos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(645, 51);
            this.label3.TabIndex = 5;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // PuntosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 614);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelPremios);
            this.Controls.Add(this.labelVencidos);
            this.Controls.Add(this.labelPuntos);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PuntosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PuntosForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PuntosForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPuntos;
        private System.Windows.Forms.Label labelVencidos;
        private System.Windows.Forms.Panel panelPremios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}