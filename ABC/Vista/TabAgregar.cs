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
    public partial class TabAgregar : Form
    {
        public TabAgregar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            int valor = 0;

            valor = Controladador.ControladorDataGrid.Insertar(txtNombre.Text, txtDescripcion.Text);

            if (valor > 0)
            {
                MessageBox.Show("insertado correctamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error");
            }

        }

        private void TabAgregar_Load(object sender, EventArgs e)
        {

        }
    }
}
