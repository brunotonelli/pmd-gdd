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
        public TextBoxRequerido() {
            textBox = new TextBox()
            {
                BorderStyle = BorderStyle.FixedSingle,
                Location = new Point(-1, -1),
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom |
                         AnchorStyles.Left | AnchorStyles.Right
            };
            Control container = new ContainerControl()
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(-1)
            };
            container.Controls.Add(textBox);
            textBox.TextChanged += new EventHandler(Validar);
            this.Controls.Add(container);

            BackColor = Color.Tomato;
            Padding = new Padding(1);
            Size = textBox.Size;
        }

        private void Validar(object sender, EventArgs e) {
            BackColor = textBox.Text.Length == 0 ? Color.Tomato : Color.LimeGreen;
        }

        protected override void OnTextChanged(EventArgs e) {
            base.OnTextChanged(e);
        }

        protected override void SetBoundsCore(int x, int y,
            int width, int height, BoundsSpecified specified) {
            base.SetBoundsCore(x, y, width, textBox.PreferredHeight, specified);
        }

        public override string Text {
            get { return textBox.Text; }
            set { textBox.Text = value; }
        }
    }
}
