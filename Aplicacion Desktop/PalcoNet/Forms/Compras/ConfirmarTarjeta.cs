﻿using System;
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
    public partial class ConfirmarTarjeta : Form
    {
        public ConfirmarTarjeta()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Owner.Close();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AsociarTarjeta().Show();
            this.Close();
        }


    }
}
