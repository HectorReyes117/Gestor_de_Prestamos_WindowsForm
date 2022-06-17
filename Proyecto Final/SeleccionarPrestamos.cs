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
    public partial class SeleccionarPrestamos : Form
    {
        public SeleccionarPrestamos()
        {
            InitializeComponent();
            LlenarCombobox();
        }

        SqlConnection conexion = new SqlConnection("Data Source=Nombre_de_su_servidor;Initial Catalog=PruebasFinal1;Integrated Security=True");
        SqlCommand comando;

        //Llenar Combobox con Clientes
        public void LlenarCombobox()
        {
            comando = new SqlCommand("Select Nombre from Clientes", conexion);
            conexion.Open();
            SqlDataReader Leer = comando.ExecuteReader();
            while (Leer.Read())
            {
                ComboBox.Items.Add(Leer["Nombre"].ToString());
            }
            conexion.Close();
        }
       
        //Cargar Prestamos
        public DataTable CargarPrestamos()
        {
            string Cliente = ComboBox.Text;
            
            conexion.Open();            
            comando = new SqlCommand($"SELECT * FROM Prestamos WHERE Cliente='{Cliente}'",conexion);
            comando.ExecuteNonQuery();
            DataTable tabla = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            adaptador.Fill(tabla);
            conexion.Close();
            return tabla;          
        }

        //Grid para Mostrar prestamos
        public void Grid()
        {
            DataGridView.DataSource = CargarPrestamos();
        }

        public int IDSeleccion;
        public string ClienteSeleccion;

        //Verifica si el Prestamo existe
        public void AnalizarPrestamo()
        {
            try
            {
                string Cliente = ComboBox.Text;
                int ID = int.Parse(txtIdPago.Text);
                Clase_Prestamos Dato = new Clase_Prestamos();
                Dato.BuscarIDPrestamo(ID, Cliente);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //boton para seleccionar al cliente
        private void botonSeleccionarCliente_Click(object sender, EventArgs e)
        {
            Grid();
        }

        //boton para verificar si el prestamo existe y pasar a los pagos de prestamos
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            AnalizarPrestamo();
        }
    }
}
