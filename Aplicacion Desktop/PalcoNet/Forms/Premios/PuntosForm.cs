using PalcoNet.Extensiones;
using PalcoNet.Model;
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
    public partial class PuntosForm : Form
    {
        List<Puntos> PuntosValidos = new List<Puntos>();
        List<Puntos> PuntosVencidos = new List<Puntos>();

        GD2C2018Entities Db = new GD2C2018Entities();

        int Totales = 0;

        public PuntosForm() {
            InitializeComponent();
            PuntosValidos = GetValidos();
            PuntosVencidos = GetVencidos();
            CargarPremios();
            panelPremios.AutoScroll = true;
            ActualizarLabels();
        }

        private IQueryable<Puntos> GetPuntos() {
            var query = from pun in Db.Puntos
                        where pun.Puntos_Tipo_Doc_Cliente == InfoSesion.TipoDocumento
                            && pun.Puntos_Num_Doc_Cliente == InfoSesion.NroDocumento
                        select pun;
            return query;
        }

        private List<Puntos> GetValidos() {
            return GetPuntos().Where(p => p.Puntos_Vencimiento > Properties.Settings.Default.FechaActual).ToList();                
        }

        private List<Puntos> GetVencidos() {
            return GetPuntos().Where(p => p.Puntos_Vencimiento <= Properties.Settings.Default.FechaActual).ToList();
        }

        private void CargarPremios() {
            var premios = new GD2C2018Entities().Premio.ToList();
            int x = 0, y = 0;
            int cantidad = 0;
            foreach (var p in premios)
            {
                cantidad++;
                var control = new PremioControl(p);
                control.Location = new Point(x, y);
                control.BotonClick += new EventHandler(PremioClick);
                panelPremios.Controls.Add(control);
                x += control.Width;
                if (cantidad % 2 == 0)
                {
                    x = 0;
                    y += control.Height;
                }
            }
        }

        private void PremioClick(object sender, EventArgs e) {
            var m = sender as PremioEventoModel;
            new CanjearPremioForm(this, m.Premio, m.Imagen, Totales).Show();
        }

        public void ConfirmarCanje(Premio premio) {
            var Db = new GD2C2018Entities();
            Premio_X_Cliente x = new Premio_X_Cliente();
            x.Pre_Cli_Nro_Doc = InfoSesion.NroDocumento;
            x.Pre_Cli_Tipo_Doc = InfoSesion.TipoDocumento;
            x.Pre_Premio_ID = premio.Premio_ID;
            ConsumirPuntos(premio.Premio_Puntos_Necesarios ?? 0);
            Db.Entry(x).State = System.Data.Entity.EntityState.Added;
            Db.SaveChanges();
            ActualizarLabels();
        }

        private void ConsumirPuntos(int puntos) {
            int puntosAux = puntos;
            while (puntosAux > 0)
            {
                Puntos puntosACanjear = PuntosValidos.OrderBy(p => p.Puntos_Vencimiento).FirstOrDefault();

                int disponibles = puntosACanjear.Puntos_Cantidad.Value;

                puntosACanjear.Puntos_Cantidad -= puntosAux;
                puntosAux -= disponibles;

                if (puntosACanjear.Puntos_Cantidad <= 0)
                {
                    Db.Entry(puntosACanjear).State = System.Data.Entity.EntityState.Deleted;
                    Db.SaveChanges();
                    PuntosValidos.Remove(puntosACanjear);
                }
                else
                {
                    Db.Entry(puntosACanjear).State = System.Data.Entity.EntityState.Modified;
                    Db.SaveChanges();
                }
            }
        }

        private void ActualizarLabels() {
            Totales = PuntosValidos.Sum(p => p.Puntos_Cantidad) ?? 0;
            labelPuntos.Text = Totales.ToString();
            labelVencidos.Text = PuntosVencidos.Sum(p => p.Puntos_Cantidad).ToString();
        }

    }
}
