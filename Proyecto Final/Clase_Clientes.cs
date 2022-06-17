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
    public partial class Clase_Clientes:Interface_Clientes
    {
        SqlConnection conexion = new SqlConnection("Data Source=Nombre_de_su_servidor;Initial Catalog=PruebasFinal1;Integrated Security=True");
        SqlCommand comando;

        
        //Propiedades Encapsuladas
        private int iD;
        private string cedula;
        private string nombre;
        private string correo;
        private string direccion;
        private string telefono;
        

        public int ID { get => iD; set => iD = value;}
        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }


        //Metodos Guardar,Eliminar,Editar Clientes
        public void Guardar(int Id, string cedula, string nombre, string correo, string direccion, string telefono)
        {
            ID = Id;
            Cedula = cedula;
            Nombre = nombre;
            Correo = correo;
            Direccion = direccion;
            Telefono = telefono;

            try
            {
                conexion.Open();
                comando = new SqlCommand($"INSERT INTO Clientes VALUES({ID},'{Cedula}','{Nombre}','{Correo}','{Direccion}','{Telefono}')", conexion);
                comando.ExecuteNonQuery();
                conexion.Close();                
            }
            catch(Exception error)
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
                comando = new SqlCommand($"DELETE FROM Clientes WHERE ID={EliminarID}", conexion);
                comando.ExecuteNonQuery();                                 
            }
            catch 
            {
                MessageBox.Show("Elimine el Prestamo para porder eliminar el Cliente");
            }
            conexion.Close();
        }
        public void Editar(int Id, string cedula, string nombre, string correo, string direccion, string telefono, int EditarID)
        {
            ID = Id;
            Cedula = cedula;
            Nombre = nombre;
            Correo = correo;
            Direccion = direccion;
            Telefono = telefono;

            try
            {
                conexion.Open();
                comando = new SqlCommand($"UPDATE Clientes SET ID={ID},Cedula='{Cedula}',Nombre='{Nombre}',Correo_Electronico='{Correo}',Direccion='{Direccion}',Telefono='{Telefono}' WHERE ID = {EditarID}", conexion);
                comando.ExecuteNonQuery();
                conexion.Close();
                
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
