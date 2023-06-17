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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : AppService
    {
        string cadenaConexion = ConfigurationManager.ConnectionStrings["myConexion"].ConnectionString;
     
        public int EliminarExamen(App app)
        {
            int res = 0;
            try
            {
                SqlConnection cnn = new SqlConnection(cadenaConexion);
                cnn.Open();
                String query = "DELETE FROM tblExamen WHERE idExamen = "+app.idExamen+";";
                SqlCommand command = new SqlCommand(query, cnn);
                res = command.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al Insertar", ex);
            }
            return res;
        }

        public List<App> mostrarExamenes()
        {
            List<App> lista = new List<App>();
         
            try
            {
                SqlConnection cnn = new SqlConnection(cadenaConexion);
                cnn.Open();
                String query = "SELECT * FROM tblExamen WHERE Nombre=@Nombre AND Descripcion=@Descripcion AND idExamen = @id";
                SqlCommand command = new SqlCommand(query, cnn);
                command.Parameters.Add("@Nombre", "");
                command.Parameters.Add("@Descripcion", "");
                command.Parameters.Add("@id", "");
              

                SqlDataReader rd = command.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Add(new App
                        {
                        idExamen = rd.GetInt32(0),
                        Nombre = rd.GetString(1),
                        Descripcion = rd.GetString(2)
                        });
                    }
                }
                else
                {
                    throw new Exception("No hay Registros");
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al Insertar", ex);
            }
            return lista;
        }

        public int AgregarExamen(App app)
        {
            int res = 0;
            try
            {
                SqlConnection cnn = new SqlConnection(cadenaConexion);
                cnn.Open();
                String query = "INSERT INTO tblExamen (Nombre,Descripcion) VALUES ('"+app.Nombre+"','"+app.Descripcion+"')";
                SqlCommand command = new SqlCommand(query, cnn);
                command.Parameters.Add("@Nombre",app.Nombre);
                command.Parameters.Add("@Descripcion",app.Descripcion);
                res = command.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al Insertar", ex);
            }
            return res;
        }

        public int ActualizarExamen(App app)
        {
            int res = 0;
            try
            {
                SqlConnection cnn = new SqlConnection(cadenaConexion);
                cnn.Open();
                String query = "UPDATE tblExamen SET Nombre = '"+app.Nombre+"', Descripcion ='"+app.Descripcion+"' WHERE idExamen = "+app.idExamen+";";
                SqlCommand command = new SqlCommand(query, cnn);
                res = command.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al Actualizar", ex);
            }
            return res;
        }

        public App ConsultarExamen(int idcontacto, string Nombre, string Descripcion)
        {
            App newapp = new App();
            try
            {
                SqlConnection cnn = new SqlConnection(cadenaConexion);
                cnn.Open();
                String query = "SELECT * FROM tblExamen WHERE Nombre='"+Nombre+"' AND Descripcion='"+Descripcion+"' AND idExamen = "+idcontacto;
                SqlCommand command = new SqlCommand(query, cnn);
                SqlDataReader rd = command.ExecuteReader();
                if(rd.HasRows)
                {
                    if(rd.Read())
                    {
                        newapp.idExamen = rd.GetInt32(0);
                        newapp.Nombre = rd.GetString(1);
                        newapp.Descripcion = rd.GetString(2);
                    }
                }
                else
                {
                    throw new Exception("No hay Registros");
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al Insertar", ex);
            }
            return newapp;
        }
    }
}
