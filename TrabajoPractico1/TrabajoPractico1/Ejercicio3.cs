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
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lblMostrar.Text = "Usted seleccionó los siguientes elementos:";
            if (rbFemenino.Checked == true) lblSeleccion.Text = gbSexo.Text + ": " + rbFemenino.Text + "\n";
            else lblSeleccion.Text = gbSexo.Text + ": " + rbMasculino.Text + "\n";
            if (rbCasado.Checked == true) lblSeleccion.Text += gbEstado.Text + ": " + rbCasado.Text + "\n";
            else lblSeleccion.Text += gbEstado.Text + ": " + rbSoltero.Text + "\n";
            if (clbOficio.SelectedItems.Count > 0) lblSeleccion.Text += "Oficio: \n";
            foreach (string elemento in clbOficio.CheckedItems)
            {
                lblSeleccion.Text += "-" + elemento + "\n";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
