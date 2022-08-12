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
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void btnEjercicio1_Click(object sender, EventArgs e)
        {
            Form formulario = new Ejercicio1();
            formulario.Show();
        }

        private void btnEjercicio2_Click(object sender, EventArgs e)
        {
            Form formulario = new Ejercicio2();
            formulario.Show();
        }

        private void BtnEjercicio3_Click(object sender, EventArgs e)
        {
            Form formulario = new Ejercicio3();
            formulario.Show();
        }
    }
}
