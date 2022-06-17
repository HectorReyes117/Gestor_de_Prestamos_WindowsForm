using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    interface InterfacePrestamos
    {
        //Metodos Guardar,Eliminar,Editar Prestamos
        //Heredados a la clase "Clase_Prestamos"

        void Editar(int Id, string fecha, string monto, string cliente, int cuotas, int EditarID);
        void Guardar(int Id, string fecha, string monto, string cliente, int cuotas);
        void Eliminar(int EliminarID);


        //Metodo para Verificar si el Prestamo seleccionado existe
        void BuscarIDPrestamo(int ID,string Cliente);

    }
}
