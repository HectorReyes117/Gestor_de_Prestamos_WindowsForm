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
    public partial class ReportesMovimientosId : Form
    {
        public ReportesMovimientosId()
        {
            InitializeComponent();
        }

        public int id { get; set; }
        private void ReportesMovimientosId_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DatasetPrincipal.MovimientosId' Puede moverla o quitarla según sea necesario.
            this.MovimientosIdTableAdapter.Fill(this.DatasetPrincipal.MovimientosId,id);

            this.reportViewer1.RefreshReport();
        }
    }
}
