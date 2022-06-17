using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Final
{
    interface Interface_Clientes
    {
        //Metodos Guardar,Eliminar,Editar Clientes
        //Heredados a la clase "Clase_Clientes"

        void Guardar(int Id, string cedula, string nombre, string correo, string direccion, string telefono);
        void Eliminar(int EliminarID);
        void Editar(int Id, string cedula, string nombre, string correo, string direccion, string telefono, int EditarID);     
    }
}
