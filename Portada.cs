using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Altas_Clientes_Productos
{
    public partial class Portada : Form
    {

        public Portada()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AltaClientes ac = new AltaClientes();
            ac.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AltaProductos ap = new AltaProductos();
            ap.Show();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            Mostrar mos = new Mostrar();
            mos.Show();
        }

        private void btn_actel_Click(object sender, EventArgs e)
        {
            ActualizarEliminar ae = new ActualizarEliminar();
            ae.Show();
        }

        private void Portada_Load(object sender, EventArgs e)
        {
            //probando git
        }
    }
}
