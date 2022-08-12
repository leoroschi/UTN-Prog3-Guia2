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
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = txtNombre.Text.Trim();
            if (txtNombre.Text != "")
            {
                bool repite=false;
                foreach (string nombre in lbAgregados.Items)
                {
                    
                    if (nombre.ToUpper() == txtNombre.Text.ToUpper())
                    {
                        repite = true;
                    }
                }
                if (repite == true)
                {
                    MessageBox.Show("El nombre seleccionado ya existe por favor ingrese un nombre distinto");
                    txtNombre.Text = "";
                }
                else
                {
                    ///textoEstandar(txtNombre.text) convierte los nombres a texto estandar JuAn -> Juan, agUstIN -> Agustin
                    lbAgregados.Items.Add(txtNombre.Text);
                    txtNombre.Text = "";
                }
            }
            else
            {
                MessageBox.Show("La casilla nombre no puede estar vacía, ingrese un nombre por favor");
            }
            txtNombre.Focus();
        }

        private void btnPasar_Click(object sender, EventArgs e)
        {
            if (lbAgregados.SelectedItem != null)
            {
                lbPasados.Items.Add(lbAgregados.SelectedItem);
                lbAgregados.Items.Remove(lbAgregados.SelectedItem);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un elemento para pasarlo");
            }
        }

        private void btnPasarTodos_Click(object sender, EventArgs e)
        {
            if(lbAgregados.Items.Count != 0)
            {
                 foreach (string nombre in lbAgregados.Items)
                 {
                     lbPasados.Items.Add(nombre);
                 }
                     lbAgregados.Items.Clear();
            }
            else
            {
                MessageBox.Show("La lista debe poseer al menos un elemento");
            }
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
