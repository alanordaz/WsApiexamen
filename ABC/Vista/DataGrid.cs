using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using apiexamen;
using apiexamen.dll;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ABC.Vista
{
    public partial class DataGrid : Form



    {
        public DataGrid()
        {
            InitializeComponent();
        }

        private void DataGrid_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            apiexamen.dll.ClsExamen client = new ClsExamen();
            client.AgregarExamen(0, "NUEVO", "NUEVO2");

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {

                MessageBox.Show("Inserte un ID");
            }
            else
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(txtID.Text, "[^0-9]"))
                {
                    MessageBox.Show("inserta solo numeros");
                    txtID.Text = txtID.Text.Remove(txtID.Text.Length - 1);
                }

            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            TabAgregar tab = new TabAgregar();
            tab.ShowDialog();

        }
        //Actulizar
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {

                MessageBox.Show("Inserte un ID");
            }
            else
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(txtID.Text, "[^0-9]"))
                {
                    MessageBox.Show("inserta solo numeros");
                    txtID.Text = txtID.Text.Remove(txtID.Text.Length - 1);
                }
                else
                {

                    TabEditar tab = new TabEditar(txtID.Text);
                    tab.ShowDialog();
                }

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Modelo.ModeloDataGrid.vStore = 1;
        }

        private void BtnElimi_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtID.Text))
            {

                MessageBox.Show("Inserte un ID");
            }
            else
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(txtID.Text, "[^0-9]"))
                {
                    MessageBox.Show("inserta solo numeros");
                    txtID.Text = txtID.Text.Remove(txtID.Text.Length - 1);
                }
                else
                {
                    int valor = 0;

                    valor = Controladador.ControladorDataGrid.Elimniar(int.Parse(txtID.Text));

                    if (valor > 0)
                    {
                        MessageBox.Show("Valor eliminado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }


                }

            }

        }
    }
}
