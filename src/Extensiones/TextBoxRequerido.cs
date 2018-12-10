using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Extensiones
{
    public partial class TextBoxRequerido : UserControl
    {
        public enum Tipo {
            Normal,
            Contraseña
        };

        private TextBox TextBox;
        private Tipo _tipoTextbox;

        [Description("Tipo del Textbox vinculado"), Category("Input")]
        public Tipo TipoTextbox {
            get {
                return _tipoTextbox;
            }
            set {
                CambiarTipo(value);
            }
        }

        public event EventHandler TextChangeEvent;
        public new event CancelEventHandler Validating;

        public TextBoxRequerido() {

            TextBox = CrearTextbox();

            Control container = new ContainerControl()
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(-1)
            };
            container.Controls.Add(TextBox);
            TextBox.TextChanged += new EventHandler(ValidarNotNull);
            TextBox.Validating += new CancelEventHandler(ValidarFormato);
            this.Controls.Add(container);

            BackColor = Color.Tomato;
            Padding = new Padding(1);
            Size = TextBox.Size;
        }

        private void ValidarFormato(object sender, CancelEventArgs e) {
            if (Validating != null)
                Validating(this, e);
        }

        private void ValidarNotNull(object sender, EventArgs e) {
            BackColor = TextBox.Text.Length == 0 ? Color.Tomato : Color.LimeGreen;
            if (TextChangeEvent != null)
                TextChangeEvent(sender, e);
        }
        
        protected override void SetBoundsCore(int x, int y,
            int width, int height, BoundsSpecified specified) {
            base.SetBoundsCore(x, y, width, TextBox.PreferredHeight, specified);
        }

        public override string Text {
            get { return TextBox.Text; }
            set { TextBox.Text = value; }
        }

        private TextBox CrearTextbox() {
            TextBox t = new TextBox()
            {
                BorderStyle = BorderStyle.FixedSingle,
                Location = new Point(-1, -1),
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom |
                         AnchorStyles.Left | AnchorStyles.Right
            };

            if (TipoTextbox == Tipo.Contraseña)
                t.UseSystemPasswordChar = true;
            return t;
        }

        private void CambiarTipo(Tipo tipo) {
            _tipoTextbox = tipo;
            if (tipo == Tipo.Contraseña)
                TextBox.UseSystemPasswordChar = true;
        }

    }
}
