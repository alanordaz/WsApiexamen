using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC.Vista
{
    public partial class TabEditar : Form


    {
        public static int _val;
        public static int val
        {
            get { return _val; }
            set { val = value; }
        }
        public TabEditar(string id)
        {
           
            InitializeComponent();
            LbID.Text = id;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            int valor = 0;

            valor = Controladador.ControladorDataGrid.Actualizar(int.Parse(LbID.Text),txtNombre.Text, txtDescripcion.Text);

            if (valor > 0)
            {
                MessageBox.Show("Actualizado correctamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error");
            }

        }

        private void TabEditar_Load(object sender, EventArgs e)
        {
            
        }
    }
}
