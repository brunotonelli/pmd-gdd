using PalcoNet.Extensiones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Validaciones
{
    public class ValidadorCampos
    {
        public enum TipoValidacion
        {
            NotNull,
            Numerica,
            NumericaNotNull,
            NoVacia,
            Largo,
            CUIT
        }

        ErrorProvider Provider;

        public ValidadorCampos(Form form) {
            Provider = new ErrorProvider(form);
            ((ISupportInitialize)Provider).BeginInit();
            Provider.BlinkRate = 0;
            Provider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            Provider.ContainerControl = form;
            ((ISupportInitialize)Provider).EndInit();
        }
        
        public void AgregarCampo(Control textBox, TipoValidacion tipoValidacion) {
            switch (tipoValidacion)
            {
                case TipoValidacion.NotNull:
                    textBox.Validating += new CancelEventHandler(ValidarNotNull);
                    break;
                case TipoValidacion.Numerica:
                    textBox.Validating += new CancelEventHandler(ValidarCampoNumerico);
                    break;
                case TipoValidacion.NumericaNotNull:
                    textBox.Validating += new CancelEventHandler(ValidarCampoNumericoNotNull);
                    break;
                case TipoValidacion.CUIT:
                    textBox.Validating += new CancelEventHandler(ValidarCampoCUIT);
                    break;
                default:
                    break;
            }            
        }

        private void ValidarNotNull(object sender, CancelEventArgs e) {
            Validar(sender, e, t => t.Length > 0, "Es un campo requerido");
        }

        private void ValidarCampoNumerico(object sender, CancelEventArgs e) {
            decimal n;
            Validar(sender, e, t => t.Length == 0 || decimal.TryParse(t, out n), "Es un campo numerico");
        }

        private void ValidarCampoNumericoNotNull(object sender, CancelEventArgs e) {
            decimal n;
            Validar(sender, e, t => decimal.TryParse(t, out n), "Es un campo numerico requerido");
        }

        private void ValidarCampoCUIT(object sender, CancelEventArgs e) {
            Validar(sender, e, t => t.Length == 0 || ValidacionesInput.CUILValido(t), "No cumple formato CUIT");
        }

        //el metodo principal: si no se cumple la condicion se bloquea el form hasta que funcione
        private void Validar(object sender, CancelEventArgs e, Predicate<string> condicion, string mensaje) {
            var box = sender as Control;
            if (condicion.Invoke(box.Text))
            {
                Provider.Clear();
                e.Cancel = false;
            }
            else
            {
                Provider.SetError(box, mensaje);
                e.Cancel = true;
            }
        }
    }
}
