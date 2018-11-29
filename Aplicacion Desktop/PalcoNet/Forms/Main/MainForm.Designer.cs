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
            this.botonRegistrarse = new System.Windows.Forms.Button();
            this.botonLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonRegistrarse
            // 
            this.botonRegistrarse.Location = new System.Drawing.Point(258, 45);
            this.botonRegistrarse.Name = "botonRegistrarse";
            this.botonRegistrarse.Size = new System.Drawing.Size(75, 23);
            this.botonRegistrarse.TabIndex = 7;
            this.botonRegistrarse.Text = "Registrarse";
            this.botonRegistrarse.UseVisualStyleBackColor = true;
            this.botonRegistrarse.Click += new System.EventHandler(this.botonRegistrarse_Click);
            // 
            // botonLogin
            // 
            this.botonLogin.Location = new System.Drawing.Point(144, 45);
            this.botonLogin.Name = "botonLogin";
            this.botonLogin.Size = new System.Drawing.Size(75, 23);
            this.botonLogin.TabIndex = 6;
            this.botonLogin.Text = "Login";
            this.botonLogin.UseVisualStyleBackColor = true;
            this.botonLogin.Click += new System.EventHandler(this.botonLogin_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 349);
            this.Controls.Add(this.botonRegistrarse);
            this.Controls.Add(this.botonLogin);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonRegistrarse;
        private System.Windows.Forms.Button botonLogin;
    }
}