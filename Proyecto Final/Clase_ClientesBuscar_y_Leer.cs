using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto_Final
{
    public partial class Clase_Clientes2:Clase_General
    {
        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-R1E8E6O\\SQLEXPRESS;Initial Catalog=PruebasFinal1;Integrated Security=True");
        SqlCommand comando;

        private string BuscarDatos;
        public string BuscarDatos1 { get => BuscarDatos; set => BuscarDatos = value; }

        //Metodo para leer los Clientes
        public override DataTable LeerDatos()
        {
            conexion.Open();
            comando = new SqlCommand($"SELECT * FROM Clientes", conexion);
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
