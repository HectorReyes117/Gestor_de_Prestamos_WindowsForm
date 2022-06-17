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
    public partial class ReportesPrestamosFecha : Form
    {
        public ReportesPrestamosFecha()
        {
            InitializeComponent();
        }
        public string fecha { get; set; }
        private void ReportesPrestamosFecha_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DatasetPrincipal.PrestamosFecha' Puede moverla o quitarla según sea necesario.
            this.PrestamosFechaTableAdapter.Fill(this.DatasetPrincipal.PrestamosFecha,fecha);

            this.reportViewer1.RefreshReport();
        }
    }
}
