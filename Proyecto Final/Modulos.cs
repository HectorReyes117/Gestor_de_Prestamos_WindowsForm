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
    public partial class Modulos : Form
    {
        public Modulos()
        {
            InitializeComponent();
        }
        Form formulario;
        
        private void botonClientes_Click(object sender, EventArgs e)
        {
            formulario = new FormClientes();
            formulario.Show();
        }

        private void BotonPrestamos_Click(object sender, EventArgs e)
        {
            formulario = new FormPrestamos();
            formulario.Show();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            formulario = new SeleccionarPrestamos();
            formulario.Show();
        }

        private void botonModuloConsultas_Click(object sender, EventArgs e)
        {
            formulario = new FormModuloConsultas();
            formulario.Show();
        }
    }
}
