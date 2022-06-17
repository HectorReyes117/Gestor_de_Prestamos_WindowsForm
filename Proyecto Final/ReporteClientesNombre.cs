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
    public partial class ReporteClientesNombre : Form
    {
        public ReporteClientesNombre()
        {
            InitializeComponent();
        }

        public string nombre { get; set; }
        private void ReporteClientesNombre_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DatasetPrincipal.ClientesNombre' Puede moverla o quitarla según sea necesario.
            this.ClientesNombreTableAdapter.Fill(this.DatasetPrincipal.ClientesNombre,nombre);

            this.reportViewer1.RefreshReport();
        }
    }
}
