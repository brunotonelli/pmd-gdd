namespace PalcoNet.Forms
{
    partial class SeleccionRolForm
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
            this.boxRol = new System.Windows.Forms.ComboBox();
            this.botonContinuar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // boxRol
            // 
            this.boxRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxRol.FormattingEnabled = true;
            this.boxRol.Location = new System.Drawing.Point(12, 59);
            this.boxRol.Name = "boxRol";
            this.boxRol.Size = new System.Drawing.Size(244, 21);
            this.boxRol.TabIndex = 0;
            // 
            // botonContinuar
            // 
            this.botonContinuar.Location = new System.Drawing.Point(12, 93);
            this.botonContinuar.Name = "botonContinuar";
            this.botonContinuar.Size = new System.Drawing.Size(244, 23);
            this.botonContinuar.TabIndex = 1;
            this.botonContinuar.Text = "Continuar";
            this.botonContinuar.UseVisualStyleBackColor = true;
            this.botonContinuar.Click += new System.EventHandler(this.botonContinuar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Su usuario tiene más de un rol asignado. \r\nElija uno para continuar:";
            // 
            // SeleccionRolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 128);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonContinuar);
            this.Controls.Add(this.boxRol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SeleccionRolForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar Rol";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SeleccionRolForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox boxRol;
        private System.Windows.Forms.Button botonContinuar;
        private System.Windows.Forms.Label label1;
    }
}