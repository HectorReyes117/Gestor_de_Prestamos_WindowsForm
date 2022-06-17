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
    public partial class ReportesClientesCorreo : Form
    {
        public ReportesClientesCorreo()
        {
            InitializeComponent();
        }
        public string correo { get; set; }
        private void ReportesClientesCorreo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DatasetPrincipal.ClientesCorreoElectronico' Puede moverla o quitarla según sea necesario.
            this.ClientesCorreoElectronicoTableAdapter.Fill(this.DatasetPrincipal.ClientesCorreoElectronico,correo);

            this.reportViewer1.RefreshReport();
        }
    }
}
