using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class FormPrestamos : Form
    {
        public FormPrestamos()
        {
            InitializeComponent();
            Grid();
        }

        SqlConnection conexion = new SqlConnection("Data Source=Nombre_de_su_servidor;Initial Catalog=PruebasFinal1;Integrated Security=True");
        SqlCommand comando;

        Clase_Prestamos Datos = new Clase_Prestamos();

        //CRUD Prestamos
        public void Guardar()
        {
            int Id = int.Parse(txtID.Text);
            string fecha = txtFecha.Text;
            string monto = txtMontoPrestamo.Text;
            string cliente = txtCliente.Text;
            int cuotas = int.Parse(txtCuotas.Text);          

            try
            {
                Datos.Guardar(Id, fecha, monto, cliente, cuotas);
                Grid();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            conexion.Close();
        }
        public void Buscar()
        {
            Clase_Clientes2 Buscar = new Clase_Clientes2();

            Buscar.BuscarDatos1 = txtBuscarDatos.Text;
            conexion.Open();

            if (RadioFecha.Checked == true)
            {
                comando = new SqlCommand($"SELECT * FROM Prestamos WHERE Fecha='{Buscar.BuscarDatos1}'", conexion);
            }

            if (RadioCliente.Checked == true)
            {
                comando = new SqlCommand($"SELECT * FROM Prestamos WHERE Cliente='{Buscar.BuscarDatos1}'", conexion);
            }         

            Buscar.Buscar(comando);
        }
        public void Eliminar()
        {
            int EliminarID = int.Parse(txtEliminarID.Text);
            Datos.Eliminar(EliminarID);
            Grid();
        }
        public void Editar()
        {
            int Id = int.Parse(txtID.Text);
            string fecha = txtFecha.Text;
            string monto = txtMontoPrestamo.Text;
            string cliente = txtCliente.Text;
            int cuotas = int.Parse(txtCuotas.Text);
            int EditarID = int.Parse(txtEditarID.Text);

            Datos.Editar(Id, fecha, monto, cliente,cuotas, EditarID);
            Grid();
        }

        //Grid para leer los Prestamos y Grid para leer la busqueda
        public void Grid()
        {
            Clase_PrestamosBuscar_y_Leer Leer = new Clase_PrestamosBuscar_y_Leer();
            DataGridView.DataSource = Leer.LeerDatos();
        }
        public void GridBuscar()
        {
            Clase_PrestamosBuscar_y_Leer Buscar = new Clase_PrestamosBuscar_y_Leer();
            DataGridView.DataSource = Buscar.Buscar(comando);
        }

        //Limpiar texboxs Clientes
        public void Limpiar()
        {
            txtID.Text = "";
            txtFecha.Text = "";
            txtMontoPrestamo.Text = "";
            txtCliente.Text = "";
            txtCuotas.Text = "";
            
        }

        //Botones Guardar,Buscar,Refrescar,Eliminar,Editar
        private void botonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "" || txtFecha.Text == "" || txtMontoPrestamo.Text == "" || txtCliente.Text == "" || txtCuotas.Text == "")
                {
                    MessageBox.Show("Todos los Campos deben estar llenos");
                }
                else
                {
                    Guardar();
                    Limpiar();
                    Grid();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            conexion.Close();
            
        }
        private void botonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Buscar();
                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    leer.Close();
                    GridBuscar();
                }
                else
                {
                    MessageBox.Show("No se ha encontrado la busqueda");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            conexion.Close();
        }
        private void gunaButton2_Click(object sender, EventArgs e)
        {
            Grid();
        }
        private void botonEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
            Grid();
        }
        private void botonEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "" || txtFecha.Text == "" || txtMontoPrestamo.Text == "" || txtCliente.Text == "" || txtCuotas.Text == "")
                {
                    MessageBox.Show("Todos los Campos deben estar llenos");
                }
                else
                {
                    Editar();
                    Limpiar();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            conexion.Close();
        }
    }
}
