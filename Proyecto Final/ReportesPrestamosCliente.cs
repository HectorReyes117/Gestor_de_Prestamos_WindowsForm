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
    public partial class ReportesPrestamosCliente : Form
    {
        public ReportesPrestamosCliente()
        {
            InitializeComponent();
        }

        public string cliente { get; set; }
        private void ReportesPrestamosCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DatasetPrincipal.PrestamosCliente' Puede moverla o quitarla según sea necesario.
            this.PrestamosClienteTableAdapter.Fill(this.DatasetPrincipal.PrestamosCliente,cliente);

            this.reportViewer1.RefreshReport();
        }
    }
}
