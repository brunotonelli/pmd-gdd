namespace PalcoNet.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.botonSalir = new System.Windows.Forms.Button();
            this.botonRegistrarse = new System.Windows.Forms.PictureBox();
            this.botonLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.botonRegistrarse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // botonSalir
            // 
            this.botonSalir.BackColor = System.Drawing.Color.Transparent;
            this.botonSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.botonSalir.FlatAppearance.BorderSize = 0;
            this.botonSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botonSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.botonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonSalir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.botonSalir.Location = new System.Drawing.Point(668, 12);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(25, 26);
            this.botonSalir.TabIndex = 15;
            this.botonSalir.Text = "X";
            this.botonSalir.UseVisualStyleBackColor = false;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // botonRegistrarse
            // 
            this.botonRegistrarse.BackColor = System.Drawing.Color.Transparent;
            this.botonRegistrarse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonRegistrarse.Location = new System.Drawing.Point(342, 281);
            this.botonRegistrarse.Name = "botonRegistrarse";
            this.botonRegistrarse.Size = new System.Drawing.Size(202, 55);
            this.botonRegistrarse.TabIndex = 16;
            this.botonRegistrarse.TabStop = false;
            this.botonRegistrarse.Click += new System.EventHandler(this.botonRegistrarse_Click);
            // 
            // botonLogin
            // 
            this.botonLogin.BackColor = System.Drawing.Color.Transparent;
            this.botonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonLogin.Location = new System.Drawing.Point(177, 271);
            this.botonLogin.Name = "botonLogin";
            this.botonLogin.Size = new System.Drawing.Size(149, 65);
            this.botonLogin.TabIndex = 17;
            this.botonLogin.TabStop = false;
            this.botonLogin.Click += new System.EventHandler(this.botonLogin_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(700, 397);
            this.Controls.Add(this.botonLogin);
            this.Controls.Add(this.botonRegistrarse);
            this.Controls.Add(this.botonSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.botonRegistrarse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.PictureBox botonRegistrarse;
        private System.Windows.Forms.PictureBox botonLogin;
    }
}