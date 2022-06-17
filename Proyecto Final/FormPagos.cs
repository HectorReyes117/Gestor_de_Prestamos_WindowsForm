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
    public partial class FormPagos : Form
    {
        

        SqlConnection conexion = new SqlConnection("Data Source=Nombre_de_su_servidor;Initial Catalog=PruebasFinal1;Integrated Security=True");
        SqlCommand comando;
        SqlCommand comandoResultado;

        Clase_Prestamos Dato = new Clase_Prestamos();

        public FormPagos(int ID,string Cliente)
        {
            InitializeComponent();                                   
            this.IDPrestamoSeleccionado = ID;
            this.ClientePrestamoSeleccionado = Cliente;
            GridMovimientos_Prestamos();
            GridPagos();
            GridCuotaApagar();
        }

        int IDPrestamoSeleccionado;
        string ClientePrestamoSeleccionado;

        public void GridCuotaApagar()
        {
            DataGridViewCuotaPagar.DataSource = Dato.LeerCuotaApagar(IDPrestamoSeleccionado);
        }

        //Pagar por Cuotas
        public void PagarCuota()
        {
            int Cuota = int.Parse(txtPago.Text);

            try
            {
                if (Cuota >1 || Cuota <1)
                {
                    MessageBox.Show("Introduzca una Cuota igual a 1");
                }
                else
                {
                    conexion.Open();
                    comando = new SqlCommand($"Select Cuotas from TablaCuota where Id={IDPrestamoSeleccionado} and Cuotas>=1", conexion);
                    SqlDataReader leer = comando.ExecuteReader();
                    if (leer.Read())
                    {
                        leer.Close();

                        Dato.CuotasP(IDPrestamoSeleccionado, ClientePrestamoSeleccionado, Cuota);
                        GridMovimientos_Prestamos();
                        GridPagos();
                        conexion.Close();
                    }
                    else
                    {
                        leer.Close();
                        comando = new SqlCommand($"Select Cuotas from TablaCuota where Id={IDPrestamoSeleccionado} and Cuotas=0", conexion);
                        leer = comando.ExecuteReader();
                        if (leer.Read())
                        {
                            MessageBox.Show("La deuda ha sido Pagada");
                        }
                        else
                        {
                            MessageBox.Show("Introduce una Cuota Valida");
                        }
                        leer.Close();
                    }
                }
               
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            conexion.Close();
        }

        //Pagar la totalidad
        public void PagarTotalidad()
        {
            int PagoTotalidad = int.Parse(txtPago.Text);
            try
            {
                conexion.Open();
                comando = new SqlCommand($"Select Monto_Pendiente from Movimientos_Prestamos where Id={IDPrestamoSeleccionado} and Monto_Pendiente ={PagoTotalidad}", conexion);
                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    leer.Close();

                    comando = new SqlCommand($"Select Id from Pagos where Id = {IDPrestamoSeleccionado}",conexion);
                    leer = comando.ExecuteReader();

                    if (leer.Read())
                    {
                        Dato.TotalidadProcesoDePagoSiLee(IDPrestamoSeleccionado, ClientePrestamoSeleccionado, PagoTotalidad);
                        GridMovimientos_Prestamos();
                        GridPagos();
                    }
                    else
                    {
                        Dato.TotalidadProcesoDePagoSiNoLee(IDPrestamoSeleccionado, ClientePrestamoSeleccionado, PagoTotalidad);
                        GridMovimientos_Prestamos();
                        GridPagos();
                    }
                    leer.Close();
                }
                else
                {
                    leer.Close();
                    comando = new SqlCommand($"Select Monto_Pendiente from Movimientos_Prestamos where Id={IDPrestamoSeleccionado} and Monto_Pendiente=0", conexion);
                    leer = comando.ExecuteReader();

                    if (leer.Read())
                    {
                        MessageBox.Show("La deuda a sido Pagada");
                    }
                    else
                    {
                        MessageBox.Show("Introduce una Prestamo Valido");
                    }
                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
            conexion.Close();
        }

        //Grids Pagos y Movimientos Prestamos
        public void GridPagos()
        {
            DataGridViewPago.DataSource = Dato.LeerTablaPagos(IDPrestamoSeleccionado,ClientePrestamoSeleccionado);
        }
        public void GridMovimientos_Prestamos()
        {
            gunaDataGridViewMovimientos.DataSource = Dato.LeerTablaMovimientos_PrestamosID(IDPrestamoSeleccionado);
        }
        
        //Boton Pagar
        private void botonPagar_Click(object sender, EventArgs e)
        {
            if (RadioCuota.Checked)
            {
                PagarCuota();
            }

            if (RadioTotalidad.Checked)
            {
                PagarTotalidad();
            }
        }      
        private void botonCalcularCuota_Click(object sender, EventArgs e)
        {
            conexion.Open();
            comando = new SqlCommand($"select * from cuotasApagar where id={IDPrestamoSeleccionado}",conexion);
            SqlDataReader leer = comando.ExecuteReader();
            
            if (leer.Read())
            {
                leer.Close();
                MessageBox.Show("Calculado");
            }
            else
            {
                conexion.Close();
                conexion.Open();
                string sqlResultado =$@"declare @i int
                                     set @i = (select Cuotas from Prestamos where Id={IDPrestamoSeleccionado})
                                     declare @d int
                                     set @d = (Select Monto_Prestamo from Prestamos where Id={IDPrestamoSeleccionado})
                                     declare @resultado int
                                     set @resultado =(@d/@i) * 1
                                     insert into cuotasApagar values({IDPrestamoSeleccionado},@resultado)";

                comandoResultado = new SqlCommand(sqlResultado, conexion);
                comandoResultado.ExecuteNonQuery();
                MessageBox.Show("Calculado");
            }
            conexion.Close();
            GridCuotaApagar();
        }
    }
}
