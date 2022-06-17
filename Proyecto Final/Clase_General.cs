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
    public abstract partial class Clase_General
    {

        SqlConnection conexion = new SqlConnection("Data Source=Nombre_de_su_servidor;Initial Catalog=PruebasFinal1;Integrated Security=True");


        //Metodos heredados a la Clase "Clase_Clientes2" y "Clase_PrestamosBuscar_y_Leer"
        public abstract DataTable LeerDatos();
        public virtual DataTable Buscar(SqlCommand comando)
        {                      
            DataTable tabla = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            adaptador.Fill(tabla);            
            conexion.Close();
            return tabla;    
        }    
    }
}
