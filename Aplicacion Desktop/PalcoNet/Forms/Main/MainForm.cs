﻿using PalcoNet.Extensiones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            FormsEstaticos.Principal = this;
        }

        private void botonLogin_Click(object sender, EventArgs e) {
            new LoginForm().Show(this);
            this.Hide();
        }

        private void botonRegistrarse_Click(object sender, EventArgs e) {
            new RegistrarseForm().Show(this);
            this.Hide();
        }

        private void botonSalir_Click(object sender, EventArgs e) {
            Environment.Exit(0);
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void DragForm(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

    }
}
