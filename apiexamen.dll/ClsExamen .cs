

namespace apiexamen.dll

{
    using System.Runtime.Serialization;
    using ServiceExamen;
    using System.Data.SqlClient;
    using System.Configuration;
    using System.Web;
    using System.Net;
    using App = ServiceExamen.App;




    public class ClsExamen
    {
        int result2;
        string nombre2;
        string descripcion2;
        public int ConsultarExamen(int param, int id, string Nombre, string Descripcion)
        {
            int task = 0;
            if (param == 0)
            {
                task = ConsultarExamenpriv(id,Nombre, Descripcion);
                
            }
            else if (param == 1)
            {
                string cadenaConexion = "server=localhost; database=BdiExamen; integrated security=true; Trusted_Connection=SSPI;MultipleActiveResultSets=true;";
                SqlConnection cnn = new SqlConnection(cadenaConexion);
                cnn.Open();
                SqlCommand command = new SqlCommand("spConsultar", cnn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@Nombre", Nombre);
                command.Parameters.AddWithValue("@Descripcion", Descripcion);
                SqlDataReader rd = command.ExecuteReader();
                if (rd.HasRows)
                {
                    if (rd.Read())
                    {
                    }
                }
                else
                {
                    throw new Exception("No hay Registros");
                }
                cnn.Close();
            }
            return task;
        }

        public int AgregarExamen(int param, string Nombre, string Descripcion)
        {
            int task =0;
            if (param == 0)
            {
                task = AgregarExamenPriv(Nombre,Descripcion).Result;
            }
            else  if (param == 1) 
            {
                string cadenaConexion = "server=localhost; database=BdiExamen; integrated security=true; Trusted_Connection=SSPI;MultipleActiveResultSets=true;";
                SqlConnection cnn = new SqlConnection(cadenaConexion);
                cnn.Open();
                SqlCommand command = new SqlCommand("spAgregar", cnn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Nombre",Nombre);
                command.Parameters.AddWithValue("@Descripcion", Descripcion);
                task = command.ExecuteNonQuery();
                if (task== -1)
                {
                    task = 1;
                }
                cnn.Close();
            }
            return task;           
        }

        public int ActualizarExamen(int param,int id, string Nombre, string Descripcion)
        {
            int task = 0;
            if (param == 0)
            {
                task = ActualizarExamenpriv(id,Nombre,Descripcion).Result;
            }
            else if (param == 1)  
            {
                string cadenaConexion = "server=localhost; database=BdiExamen; integrated security=true; Trusted_Connection=SSPI;MultipleActiveResultSets=true;";
                SqlConnection cnn = new SqlConnection(cadenaConexion);
                cnn.Open();
                SqlCommand command = new SqlCommand("spActualizar", cnn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Nombre", Nombre);
                command.Parameters.AddWithValue("@Descripcion", Descripcion);
                command.Parameters.AddWithValue("@id", id);
                task = command.ExecuteNonQuery();
                cnn.Close();
            }
            return task;
        }
        public int EliminarExamen(int param, int id)
        {
            int task = 0;
            if (param == 0)
            {
                task = EliminarExamenpriv(id).Result;
            }
            else if (param == 1) 
            {
                string cadenaConexion = "server=localhost; database=BdiExamen; integrated security=true; Trusted_Connection=SSPI;MultipleActiveResultSets=true;";
                SqlConnection cnn = new SqlConnection(cadenaConexion);
                cnn.Open();
                SqlCommand command = new SqlCommand("spEliminar", cnn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", id);
                task = command.ExecuteNonQuery();
                cnn.Close();
            }
            return task;
        }
        private async Task<int> AgregarExamenPriv( string Nombre, string Descripcion)
        {
            
            ServiceExamen.AppServiceClient client = new AppServiceClient();
            App app = new App();
            app.Nombre = Nombre;
            app.Descripcion = Descripcion;
            var task = client.AgregarExamenAsync(app).Result;
            int result =  task;
            return result;
           

        }
        private async Task<int> ActualizarExamenpriv(int id, string Nombre, string Descripcion)
        {

            ServiceExamen.AppServiceClient client = new AppServiceClient();
            App app = new App();
            app.idExamen = id;
            app.Nombre = Nombre;
            app.Descripcion = Descripcion;
            var task =client.ActualizarExamenAsync(app).Result;
            int result = task;
            return result;


        }
        private async Task<int> EliminarExamenpriv(int id)
        {

            ServiceExamen.AppServiceClient client = new AppServiceClient();
            App app = new App();
            app.idExamen = id;
            var task = client.EliminarExamenAsync(app).Result;
            int val = task;
            return val;
            

        }
        public App ConsultarExamenpriv(int id, string nombre, string Descripcion)
        {
            int result = 0;
            App app = new App();
            ServiceExamen.AppServiceClient client = new AppServiceClient();
            
            var task = client.ConsultarExamenAsync(id, nombre,Descripcion).Result;
            result2 = app.idExamen;
            nombre2 = app.Nombre;
            descripcion2 = app.Descripcion;

            return task;

        }

    }
}