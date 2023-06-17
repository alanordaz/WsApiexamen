using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Modelo
{
    public class ModeloDataGrid
    {
        private static int _vStore = 0;
        private static int _id;
        private static string _nombre;
        private static string _descripcion;
        public static int vStore
        {
            get { return _vStore; }
            set { _vStore = value; }
        }

        public static int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public static string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public static string descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }



    }
}
