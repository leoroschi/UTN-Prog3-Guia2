using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPractico1
{
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool repite = false;
            foreach (string elemento in lbElementos.Items)
            {
                if (elemento == txtNombre.Text + " " + txtApellido.Text)
                {
                    repite = true;
                }
            }
            if (repite == false && txtNombre.Text.Trim() != "" && txtApellido.Text.Trim() != "")
            {
                lbElementos.Items.Add(txtNombre.Text + " " + txtApellido.Text);
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtNombre.Focus();
            }
            else
            {
                if (repite == true) MessageBox.Show("El nombre agregado no puede repetirse");
                else MessageBox.Show("Las casillas de Nombre y Apellido deben completarse");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (lbElementos.SelectedItem != null)
            {
                lbElementos.Items.Remove(lbElementos.SelectedItem);
            }
            else
            {
                MessageBox.Show("Debe haber una selección para poder borrarla");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
