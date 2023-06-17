using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace WsApiexamen
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface AppService
    {

        [OperationContract]
        int AgregarExamen(App app);

        [OperationContract]
        int ActualizarExamen(App app);
        [OperationContract]
        int EliminarExamen(App app);
        [OperationContract]
        App ConsultarExamen(int idcontacto,string Nombre, string Descripcion);
        [OperationContract]
        List<App> mostrarExamenes();



    } 
    [DataContract]
    public class App
    {
        int _idExamen;
        string _Nombre;
        string _Descripcion;

        [DataMember]
        public int idExamen
        {
            get { return _idExamen; }
            set { _idExamen = value; }
        }
        [DataMember]
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        [DataMember]
        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

    }
    
}
