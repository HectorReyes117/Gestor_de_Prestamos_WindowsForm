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
    public partial class ReportesClientesCedula : Form
    {
        public ReportesClientesCedula()
        {
            InitializeComponent();
        }
        public string cedula { get; set; }
        private void ReportesClientesCedula_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DatasetPrincipal.ClientesCedula' Puede moverla o quitarla según sea necesario.
            this.ClientesCedulaTableAdapter.Fill(this.DatasetPrincipal.ClientesCedula,cedula);

            this.reportViewer1.RefreshReport();
        }
    }
}
