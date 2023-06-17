using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApp.ExamenReference;
using WebApp.ExamenService;
using App = WebApp.ExamenReference.App;
namespace WebApp
{
    public partial class wfincio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            ExamenReference.AppServiceClient cliente = new ExamenReference.AppServiceClient();
            App app = new App();
            
            if(txtID.Text.Trim() != "")
            {
                app =cliente.ConsultarExamen(int.Parse(txtID.Text), txNombre.Text, txtDescripcion.Text);
                txNombre.Text = app.Nombre;
                txtDescripcion.Text = app.Descripcion;

            }
            
        }

        protected void txNombre_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {


           /* ExamenReference.AppServiceClient cliente = new ExamenReference.AppServiceClient();
            App app = new App();
            app.Nombre = txNombre.Text;
            app.Descripcion = txtDescripcion.Text;

            if (cliente.AgregarExamen(app) > 0)
            {
                lbmensaje.Text = "contacto agregado con exito..";
            }
            else
            {
                lbmensaje.Text = "contacto no agregado";
            }*/

        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            ExamenReference.AppServiceClient cliente = new ExamenReference.AppServiceClient();
            App app = new App();
            app.idExamen = int.Parse(txtID.Text);
            app.Nombre = txNombre.Text;
            app.Descripcion = txtDescripcion.Text;

            if (cliente.ActualizarExamen(app) > 0)
            {
                lbmensaje.Text = "contacto actualizado con exito..";
            }
            else
            {
                lbmensaje.Text = "contacto no actualizado";
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            ExamenReference.AppServiceClient cliente = new ExamenReference.AppServiceClient();
            App app = new App();
            app.idExamen = int.Parse(txtID.Text);
            

            if (cliente.EliminarExamen(app) > 0)
            {
                lbmensaje.Text = "contacto eliminado con exito..";
            }
            else
            {
                lbmensaje.Text = "contacto no eliminado";
            }
        }

        protected System.Void btnBuscar_Click(System.Object sender, System.EventArgs e)
        {

        }
    }
}