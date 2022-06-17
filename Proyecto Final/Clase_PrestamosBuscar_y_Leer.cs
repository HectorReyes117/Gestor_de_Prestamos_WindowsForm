using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto_Final
{

    public partial class Clase_PrestamosBuscar_y_Leer:Clase_General
    {
        SqlConnection conexion = new SqlConnection("Data Source=Nombre_de_su_servidor;Initial Catalog=PruebasFinal1;Integrated Security=True");
        SqlCommand comando;

        private string BuscarDatos;
        public string BuscarDatos1 { get => BuscarDatos; set => BuscarDatos = value; }

        //Metodo para leer los Prestamos
        public override DataTable LeerDatos()
        {
            conexion.Open();
            comando = new SqlCommand($"SELECT * FROM Prestamos", conexion);
            comando.ExecuteNonQuery();
            DataTable tabla = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            adaptador.Fill(tabla);
            conexion.Close();
            return tabla;
        }

        //Metodo para Buscar los Clientes
        public override DataTable Buscar(SqlCommand comando)
        {
            return base.Buscar(comando);
        }

    }
}
