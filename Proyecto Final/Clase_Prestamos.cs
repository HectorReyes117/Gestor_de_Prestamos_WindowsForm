using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class Clase_Prestamos:InterfacePrestamos
    {
        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-R1E8E6O\\SQLEXPRESS;Initial Catalog=PruebasFinal1;Integrated Security=True");
        SqlCommand comando;
        SqlCommand comandoResultado;
        SqlCommand comando2;
        SqlCommand comando3;


        //Propiedades Encapsuladas
        private int iD;
        private string fecha;
        private string monto_Prestamo;
        private string cliente;
        private int cuotas;

        public int ID { get => iD; set => iD = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Monto_Prestamo { get => monto_Prestamo; set => monto_Prestamo = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public int Cuotas { get => cuotas; set => cuotas = value; }


        ////Metodos Guardar,Eliminar,Editar Prestamos
        public void Guardar(int Id, string fecha, string monto, string cliente, int cuotas)
        {
            ID = Id;
            Fecha = fecha;
            Monto_Prestamo = monto;
            Cliente = cliente;
            Cuotas = cuotas;
            
            try
            {
                conexion.Open();
                comando = new SqlCommand($"INSERT INTO Prestamos VALUES({ID},'{Fecha}',{Monto_Prestamo},'{Cliente}',{Cuotas})", conexion); 
                comando2 = new SqlCommand($"INSERT INTO TablaCuota VALUES({ID},{Cuotas})",conexion);
                comando3 = new SqlCommand($"INSERT INTO Movimientos_Prestamos VALUES ({ID},{Monto_Prestamo},{Monto_Prestamo})", conexion);
                comando.ExecuteNonQuery();
                comando2.ExecuteNonQuery();
                comando3.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            conexion.Close();
        }
        public void Eliminar(int EliminarID)
        {
            try
            {
                conexion.Open();

                string querry = $@"DELETE FROM TablaCuota WHERE Id={EliminarID}
                                   DELETE FROM Pagos WHERE Id={EliminarID}
                                   DELETE FROM Movimientos_Prestamos WHERE Id={EliminarID}
                                   DELETE FROM cuotasApagar WHERE id={EliminarID}";

                comando = new SqlCommand($"DELETE FROM Prestamos WHERE Id={EliminarID}", conexion);
                comando2 = new SqlCommand(querry,conexion);

                comando2.ExecuteNonQuery();
                comando.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            conexion.Close();
        }
        public void Editar(int Id, string fecha, string monto, string cliente, int cuotas, int EditarID)
        {
            ID = Id;
            Fecha = fecha;
            Monto_Prestamo = monto;
            Cliente = cliente;
            Cuotas = cuotas;

            try
            {
                conexion.Open();
                comando = new SqlCommand($"UPDATE Prestamos SET Id={ID},Fecha='{Fecha}',Monto_Prestamo='{Monto_Prestamo}',Cliente='{Cliente}',Cuotas='{Cuotas}' WHERE Id = {EditarID}", conexion);
                comando.ExecuteNonQuery();
                
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            conexion.Close();
        }

        
        //Metodo para Verificar si el Prestamo seleccionado existe
        public void BuscarIDPrestamo(int ID,string Cliente)
        {           
            try
            {
                conexion.Open();
                comando = new SqlCommand($"Select * from Prestamos where Id={ID} and Cliente='{Cliente}'",conexion);
                SqlDataReader leer = comando.ExecuteReader();
                
                if (leer.Read())
                {
                    FormPagos formulario5 = new FormPagos(ID,Cliente);
                    formulario5.Show();
                }
                else
                {
                    MessageBox.Show("El Prestamo no existe, seleccione otro");
                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
            conexion.Close();           
        }
       
        
        //Leer en tablaPagos, Movimientos_Prestamos y Pagos 
        public DataTable LeerTablaPagos(int IDPrestamoSeleccionado, string ClientePrestamoSeleccionado) 
        {
            conexion.Open();
            comando = new SqlCommand($"SELECT * FROM Pagos where Id = {IDPrestamoSeleccionado} and Cliente='{ClientePrestamoSeleccionado}'", conexion);
            comando.ExecuteNonQuery();
            DataTable tabla = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            adaptador.Fill(tabla);
            conexion.Close();
            return tabla;          
        } 
        public DataTable LeerTablaMovimientos_PrestamosID(int IDPrestamoSeleccionado)
        {
            conexion.Open();
            comando = new SqlCommand($"SELECT * FROM Movimientos_Prestamos where Id={IDPrestamoSeleccionado}", conexion);
            comando.ExecuteNonQuery();
            DataTable tabla = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            adaptador.Fill(tabla);
            conexion.Close();
            return tabla;
        }
        public DataTable LeerPagos()
        {
            conexion.Open();
            comando = new SqlCommand($"SELECT * FROM Pagos", conexion);
            comando.ExecuteNonQuery();
            DataTable tabla = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            adaptador.Fill(tabla);
            conexion.Close();
            return tabla;
        }
        public DataTable LeerMovimientosPrestamos()
        {
            conexion.Open();
            comando = new SqlCommand($"SELECT * FROM Movimientos_Prestamos", conexion);
            comando.ExecuteNonQuery();
            DataTable tabla = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            adaptador.Fill(tabla);
            conexion.Close();
            return tabla;
        }
        public DataTable LeerCuotaApagar(int IDPrestamoSeleccionado)
        {
            conexion.Open();
            comando = new SqlCommand($"SELECT cuotapagar FROM cuotasApagar where id={IDPrestamoSeleccionado}", conexion);
            comando.ExecuteNonQuery();
            DataTable tabla = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            adaptador.Fill(tabla);
            conexion.Close();
            return tabla;
        }


        //Pagos por Cuotas y Totalidad
        public void TotalidadProcesoDePagoSiNoLee(int IDPrestamoSeleccionado, string ClientePrestamoSeleccionado, int PagoTotalidad)
        {
            conexion.Open();

            string sqlResultado = $@"declare @d int
                                     set @d = (Select Prestamo from Movimientos_Prestamos where Id={IDPrestamoSeleccionado})
                                     update Movimientos_Prestamos set Monto_Pendiente = Monto_Pendiente-@d where Id ={IDPrestamoSeleccionado}
                                     update Pagos set Monto_Pagado = Monto_Pagado + @d where Id={IDPrestamoSeleccionado}";

            string sqlRestarCuota = $@"declare @i int
                                       set @i = (select Cuotas from TablaCuota where Id={IDPrestamoSeleccionado})
                                       Update Prestamos set Cuotas = Cuotas - @i where Id={IDPrestamoSeleccionado} and Cliente='{ClientePrestamoSeleccionado}'";
            
            comando2 = new SqlCommand($"insert into Pagos (Id,Fecha,Prestamo,Cliente,Monto_Pagado) select Id,Fecha,Monto_Prestamo,Cliente,0 from Prestamos where Id={IDPrestamoSeleccionado}", conexion);
            
            comando = new SqlCommand(sqlRestarCuota,conexion);
            comandoResultado = new SqlCommand(sqlResultado, conexion);

            comando2.ExecuteNonQuery();
            
            comandoResultado.ExecuteNonQuery();
            comando.ExecuteNonQuery();

            conexion.Close();
        }
        public void TotalidadProcesoDePagoSiLee(int IDPrestamoSeleccionado, string ClientePrestamoSeleccionado, int PagoTotalidad)
        {
             conexion.Open();

            string sqlResultado = $@"declare @d int
                                     set @d = (Select Monto_Pendiente from Movimientos_Prestamos where Id={IDPrestamoSeleccionado})
                                     update Movimientos_Prestamos set Monto_Pendiente = Monto_Pendiente-Monto_Pendiente where Id ={IDPrestamoSeleccionado}
                                     update Pagos set Monto_Pagado = Monto_Pagado + @d where Monto_Pagado = 0";

            string sqlRestarCuota = $@"Update TablaCuota set Cuotas = Cuotas - Cuotas where Id={IDPrestamoSeleccionado}";
            
            comando2 = new SqlCommand($"insert into Pagos (Id,Fecha,Prestamo,Cliente,Monto_Pagado) select Id,Fecha,Monto_Prestamo,Cliente,0 from Prestamos where Id={IDPrestamoSeleccionado}", conexion);
            
            comando = new SqlCommand(sqlRestarCuota,conexion);
            comandoResultado = new SqlCommand(sqlResultado, conexion);

            
            comando2.ExecuteNonQuery();
           
            comandoResultado.ExecuteNonQuery();
            comando.ExecuteNonQuery();

            conexion.Close();
        }
        public void CuotasP(int IDPrestamoSeleccionado, string ClientePrestamoSeleccionado, int Cuota)
        {
            conexion.Open();

            string sqlResultado = $@"declare @i int
                                     set @i = (select Cuotas from Prestamos where Id={IDPrestamoSeleccionado})
                                     declare @d int
                                     set @d = (Select Monto_Prestamo from Prestamos where Id={IDPrestamoSeleccionado})
                                     declare @resultado int
                                     set @resultado =(@d/@i) * 1
                                     update Movimientos_Prestamos set Monto_Pendiente = Monto_Pendiente-@resultado where Id ={IDPrestamoSeleccionado}
                                     update Pagos set Monto_Pagado = @resultado where Monto_Pagado =0";

            comando2 = new SqlCommand($"insert into Pagos (Id,Fecha,Prestamo,Cliente,Monto_Pagado) select Id,Fecha,Monto_Prestamo,Cliente,0 from Prestamos where Id={IDPrestamoSeleccionado}", conexion);
            comando = new SqlCommand($"Update TablaCuota set Cuotas = Cuotas - {Cuota} where Id={IDPrestamoSeleccionado}", conexion);
            comandoResultado = new SqlCommand(sqlResultado, conexion);
           

            comando2.ExecuteNonQuery();
            
            comandoResultado.ExecuteNonQuery();  
            comando.ExecuteNonQuery();
            
            
            conexion.Close();
        }
        public void CalcularCuota(int IDPrestamoSeleccionado, string ClientePrestamoSeleccionado, int Cuota)
        {
            conexion.Open();

            string sqlResultado = $@"declare @i int
                                     set @i = (select Cuotas from Prestamos where Id={IDPrestamoSeleccionado})
                                     declare @d int
                                     set @d = (Select Monto_Prestamo from Prestamos where Id={IDPrestamoSeleccionado})
                                     declare @resultado int
                                     set @resultado =(@d/@i) * 1
                                     ";

            comandoResultado = new SqlCommand(sqlResultado, conexion);
            //comandoResultado.Parameters.AddWithValue()
            comandoResultado.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
