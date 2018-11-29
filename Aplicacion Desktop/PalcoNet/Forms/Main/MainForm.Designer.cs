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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.botonConfig = new System.Windows.Forms.Button();
            this.botonEstrategia = new System.Windows.Forms.Button();
            this.botonLogin = new System.Windows.Forms.Button();
            this.botonRegistrarse = new System.Windows.Forms.Button();
            this.botonSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 212);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::PalcoNet.Properties.Resources.logoPALCO;
            this.pictureBox2.Location = new System.Drawing.Point(33, -86);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(734, 326);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Location = new System.Drawing.Point(234, 225);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(338, 154);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // botonConfig
            // 
            this.botonConfig.BackColor = System.Drawing.SystemColors.ControlText;
            this.botonConfig.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botonConfig.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonConfig.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.botonConfig.Location = new System.Drawing.Point(34, 225);
            this.botonConfig.Name = "botonConfig";
            this.botonConfig.Size = new System.Drawing.Size(160, 65);
            this.botonConfig.TabIndex = 11;
            this.botonConfig.Text = "Configuración";
            this.botonConfig.UseVisualStyleBackColor = false;
            // 
            // botonEstrategia
            // 
            this.botonEstrategia.BackColor = System.Drawing.SystemColors.ControlText;
            this.botonEstrategia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botonEstrategia.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonEstrategia.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.botonEstrategia.Location = new System.Drawing.Point(33, 314);
            this.botonEstrategia.Name = "botonEstrategia";
            this.botonEstrategia.Size = new System.Drawing.Size(160, 65);
            this.botonEstrategia.TabIndex = 12;
            this.botonEstrategia.Text = "Estrategia";
            this.botonEstrategia.UseVisualStyleBackColor = false;
            // 
            // botonLogin
            // 
            this.botonLogin.BackColor = System.Drawing.SystemColors.ControlText;
            this.botonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botonLogin.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonLogin.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.botonLogin.Location = new System.Drawing.Point(608, 225);
            this.botonLogin.Name = "botonLogin";
            this.botonLogin.Size = new System.Drawing.Size(160, 65);
            this.botonLogin.TabIndex = 13;
            this.botonLogin.Text = "Iniciar sesión";
            this.botonLogin.UseVisualStyleBackColor = false;
            this.botonLogin.Click += new System.EventHandler(this.botonLogin_Click);
            // 
            // botonRegistrarse
            // 
            this.botonRegistrarse.BackColor = System.Drawing.SystemColors.ControlText;
            this.botonRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botonRegistrarse.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRegistrarse.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.botonRegistrarse.Location = new System.Drawing.Point(607, 314);
            this.botonRegistrarse.Name = "botonRegistrarse";
            this.botonRegistrarse.Size = new System.Drawing.Size(160, 65);
            this.botonRegistrarse.TabIndex = 14;
            this.botonRegistrarse.Text = "Registrarse";
            this.botonRegistrarse.UseVisualStyleBackColor = false;
            this.botonRegistrarse.Click += new System.EventHandler(this.botonRegistrarse_Click);
            // 
            // botonSalir
            // 
            this.botonSalir.BackColor = System.Drawing.Color.Transparent;
            this.botonSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.botonSalir.FlatAppearance.BorderSize = 0;
            this.botonSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botonSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.botonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonSalir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.botonSalir.Location = new System.Drawing.Point(773, 1);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(25, 26);
            this.botonSalir.TabIndex = 15;
            this.botonSalir.Text = "X";
            this.botonSalir.UseVisualStyleBackColor = false;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PalcoNet.Properties.Resources.logoBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.botonRegistrarse);
            this.Controls.Add(this.botonLogin);
            this.Controls.Add(this.botonEstrategia);
            this.Controls.Add(this.botonConfig);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button botonConfig;
        private System.Windows.Forms.Button botonEstrategia;
        private System.Windows.Forms.Button botonLogin;
        private System.Windows.Forms.Button botonRegistrarse;
        private System.Windows.Forms.Button botonSalir;
    }
}