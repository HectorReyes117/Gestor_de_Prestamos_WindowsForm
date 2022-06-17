using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class ReportesPagosRangos : Form
    {
        public ReportesPagosRangos()
        {
            InitializeComponent();
        }
        public string desde { get; set; }
        public string hasta { get; set; }
        private void ReportesPagosRangos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DatasetPrincipal.PagosRangos' Puede moverla o quitarla según sea necesario.
            this.PagosRangosTableAdapter.Fill(this.DatasetPrincipal.PagosRangos,desde,hasta);

            this.reportViewer1.RefreshReport();
        }
    }
}
