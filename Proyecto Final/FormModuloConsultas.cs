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
    public partial class FormModuloConsultas : Form
    {
       
        public FormModuloConsultas()
        {
            InitializeComponent();
            GridClientes();
            GridPrestamo();
            GridPagos();
            GridMovimientosPrestamos();
        }

        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-R1E8E6O\\SQLEXPRESS;Initial Catalog=PruebasFinal1;Integrated Security=True");
        SqlCommand comando;

        Clase_Clientes Datos = new Clase_Clientes();
        Clase_Prestamos Prestamos = new Clase_Prestamos();
        
        //Buscar Clientes
        public void BuscarClientes()
        {
            Clase_Clientes2 Buscar = new Clase_Clientes2();

            Buscar.BuscarDatos1 = txtBuscarClientes.Text;
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
        public void GridClientes()
        {
            Clase_Clientes2 Leer = new Clase_Clientes2();
            DataGridViewClientes.DataSource = Leer.LeerDatos();
        }
        public void GridBuscarClientes()
        {
            Clase_Clientes2 Buscar = new Clase_Clientes2();
            DataGridViewClientes.DataSource = Buscar.Buscar(comando);
        }


        //Buscar Prestamos
        public void BuscarPrestamo()
        {
            Clase_PrestamosBuscar_y_Leer Buscar = new Clase_PrestamosBuscar_y_Leer();

            Buscar.BuscarDatos1 = txtBuscarPrestamos.Text;
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
        public void GridPrestamo()
        {
            Clase_PrestamosBuscar_y_Leer Leer = new Clase_PrestamosBuscar_y_Leer();
            DataGridViewPrestamos.DataSource = Leer.LeerDatos();
        }
        public void GridBuscarPrestamo()
        {
            Clase_PrestamosBuscar_y_Leer Buscar = new Clase_PrestamosBuscar_y_Leer();
            DataGridViewPrestamos.DataSource = Buscar.Buscar(comando);
        }

        //Buscar Pagos
        public void BuscarPagos()
        {
            Clase_PrestamosBuscar_y_Leer Buscar = new Clase_PrestamosBuscar_y_Leer();
            
            conexion.Open();
            comando = new SqlCommand($"SELECT * FROM Pagos where Fecha BETWEEN '{DataTimeDesde.Text}' and '{DataTimeHasta.Text}'",conexion);
            Buscar.Buscar(comando);
        }
        public void GridPagos()
        {
            gunaDataGridViewPagos.DataSource = Prestamos.LeerPagos();
        }
        public void GridBuscarPagos()
        {
            Clase_PrestamosBuscar_y_Leer Buscar = new Clase_PrestamosBuscar_y_Leer();
            gunaDataGridViewPagos.DataSource = Buscar.Buscar(comando);

        }

        //Buscar Movimientos Prestamos
        public void BuscarMovimientosPrestamos()
        {
            Clase_PrestamosBuscar_y_Leer Buscar = new Clase_PrestamosBuscar_y_Leer();

            Buscar.BuscarDatos1 = txtBuscarMovimientosPrestamos.Text;
            conexion.Open();
            comando = new SqlCommand($"SELECT * FROM Movimientos_Prestamos WHERE Id={Buscar.BuscarDatos1}", conexion);
            Buscar.Buscar(comando);
        }
        public void GridMovimientosPrestamos()
        {
            DataGridViewBalancesPendientes.DataSource = Prestamos.LeerMovimientosPrestamos();
        }
        public void GridBuscarMovimientosPrestamos()
        {
            Clase_PrestamosBuscar_y_Leer Buscar = new Clase_PrestamosBuscar_y_Leer();
            DataGridViewBalancesPendientes.DataSource = Buscar.Buscar(comando);
        }
        
        
        //Botones Guardar
        private void botonBuscarClientes_Click(object sender, EventArgs e)
        {          
            try
            {
                BuscarClientes();
                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    leer.Close();
                    GridBuscarClientes();
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
        private void botonBuscarPrestamos_Click(object sender, EventArgs e)
        {
            try
            {
                BuscarPrestamo();
                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    leer.Close();
                    GridBuscarPrestamo();
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
        private void botonPagos_Click(object sender, EventArgs e)
        {
            try
            {
                BuscarPagos();
                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    leer.Close();
                    GridBuscarPagos();
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
            try
            {
                BuscarMovimientosPrestamos();
                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    leer.Close();
                    GridBuscarMovimientosPrestamos();
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

        //Botones Refrescar
        private void botonRefrescarClientes_Click(object sender, EventArgs e)
        {
            GridClientes();
        }
        private void botonRefrescarPrestamo_Click(object sender, EventArgs e)
        {
            GridPrestamo();
        }
        private void botonRefrescarPagos_Click(object sender, EventArgs e)
        {
            GridPagos();
        }
        private void botonRefrescarBalances_Click(object sender, EventArgs e)
        {
            GridMovimientosPrestamos();
        }

        private void botonReportesClientes_Click(object sender, EventArgs e)
        {
            if (RadioNombre.Checked)
            {
                ReporteClientesNombre nombre = new ReporteClientesNombre();
                nombre.nombre = txtBuscarClientes.Text;
                nombre.Show();
            }
            if (RadioCedula.Checked)
            {
                ReportesClientesCedula cedula = new ReportesClientesCedula();
                cedula.cedula = txtBuscarClientes.Text;
                cedula.Show();
            }
            if (RadioCorreo.Checked)
            {
                ReportesClientesCorreo correo = new ReportesClientesCorreo();
                correo.correo = txtBuscarClientes.Text;
                correo.Show();
            }
        }
        private void botonReportesPrestamos_Click(object sender, EventArgs e)
        {
            if (RadioFecha.Checked)
            {
                ReportesPrestamosFecha fecha = new ReportesPrestamosFecha();
                fecha.fecha = txtBuscarPrestamos.Text;
                fecha.Show();
            }
            if (RadioCliente.Checked)
            {
                ReportesPrestamosCliente cliente = new ReportesPrestamosCliente();
                cliente.cliente = txtBuscarPrestamos.Text;
                cliente.Show();
            }
        }
        private void botonReportesPagos_Click(object sender, EventArgs e)
        {
            ReportesPagosRangos rango = new ReportesPagosRangos();
            rango.desde = DataTimeDesde.Text;
            rango.hasta = DataTimeHasta.Text;
            rango.Show();
        }
        private void botonReportesBalances_Click(object sender, EventArgs e)
        {
            ReportesMovimientosId id = new ReportesMovimientosId();
            id.id = int.Parse(txtBuscarMovimientosPrestamos.Text);
            id.Show();
            
        }
    }
}
