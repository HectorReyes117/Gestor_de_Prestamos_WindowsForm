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
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
            Grid();
        }

        SqlConnection conexion = new SqlConnection("Data Source=Nombre_de_su_servidor;Initial Catalog=PruebasFinal1;Integrated Security=True");
        SqlCommand comando;

        Clase_Clientes Datos = new Clase_Clientes();

        //CRUD Prestamos
        public void Guardar()
        {            
            int Id = int.Parse(txtID.Text);
            string cedula = txtCedula.Text;
            string nombre = txtNombre.Text;
            string correo = txtCorreo.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;

            try
            {
                Datos.Guardar(Id, cedula, nombre, correo, direccion,telefono);
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

            Buscar.BuscarDatos1 = txtBuscarNombre.Text;
            conexion.Open();

            if (RadioNombre.Checked == true)
            {
                comando = new SqlCommand($"SELECT * FROM Clientes WHERE Nombre='{Buscar.BuscarDatos1}'", conexion);
            }

            if (RadioCedula.Checked == true)
            {
                comando = new SqlCommand($"SELECT * FROM Clientes WHERE Cedula='{Buscar.BuscarDatos1}'", conexion);
            }

            if (RadioCorreo.Checked == true)
            {
                comando = new SqlCommand($"SELECT * FROM Clientes WHERE Correo_Electronico='{Buscar.BuscarDatos1}'", conexion);
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
            string cedula = txtCedula.Text;
            string nombre = txtNombre.Text;
            string correo = txtCorreo.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;
            int EditarID = int.Parse(txtEditarID.Text);

            Datos.Editar(Id, cedula, nombre, correo, direccion, telefono, EditarID);
            Grid();
        }

        //Grid para leer los Prestamos y Grid para leer la busqueda
        public void Grid()
        {
            Clase_Clientes2 Leer = new Clase_Clientes2();
            DataGridView.DataSource = Leer.LeerDatos();
        }
        public void GridBuscar()
        {
            Clase_Clientes2 Buscar = new Clase_Clientes2();
            DataGridView.DataSource = Buscar.Buscar(comando);
        }

        //Limpiar texboxs Clientes
        public void Limpiar()
        {
            txtID.Text = "";
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
        }

        //Botones Guardar,Buscar,Refrescar,Eliminar,Editar
        private void botonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text == "" || txtID.Text == "" || txtCedula.Text == "" || txtCorreo.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "")
                {
                    MessageBox.Show("Todos los Campos deben estar llenos");
                }
                else
                {
                    Guardar();
                    Limpiar();
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
        private void gunaButton1_Click(object sender, EventArgs e)
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
                if (txtNombre.Text == "" || txtID.Text == "" || txtCedula.Text == "" || txtCorreo.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "")
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
