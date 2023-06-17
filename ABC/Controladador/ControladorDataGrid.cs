using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABC.Modelo;
using apiexamen;
using ServiceExamen;

namespace ABC.Controladador
{
    public static class ControladorDataGrid
    {

        
        public static int Insertar(string nombre, string descripcion )
            {
            int valor = 0;
            apiexamen.dll.ClsExamen client = new apiexamen.dll.ClsExamen();
            valor = client.AgregarExamen(ModeloDataGrid.vStore, nombre,descripcion);
            return valor;
            }
        public static int Actualizar(int id,string nombre, string descripcion)
        {
            int valor = 0;
            apiexamen.dll.ClsExamen client = new apiexamen.dll.ClsExamen();
            valor = client.ActualizarExamen(ModeloDataGrid.vStore, id,nombre, descripcion);
            return valor;
        }
        public static int Elimniar(int id)
        {
            int valor = 0;
            apiexamen.dll.ClsExamen client = new apiexamen.dll.ClsExamen();
            valor = client.EliminarExamen(ModeloDataGrid.vStore, id);
            return valor;
        }

        

    }
}
