using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Altas_Clientes_Productos
{
    public partial class AltaClientes : Form
    {
        string cadenaConex = @"data source=nOTEBOOK\SQLEXPRESS; initial catalog=Ejercitacion; integrated security=SSPI";
        SqlConnection cn;

        public AltaClientes()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AltaClientes_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(cadenaConex);
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            string nombre = txt_nombre.Text;
            string apellido = txt_apellido.Text;
            string direccion = txt_direccion.Text;
            string fecha = txt_fecha.Text;
            string provincia = txt_provincia.Text;

            SqlCommand comando = new SqlCommand("insert into Clientes (nombre, apellido, direccion, fecha_registracion, provincia) values (@nom, @ape, @dir, @fec, @pro)", cn);
            comando.Parameters.AddWithValue("@nom", nombre);
            comando.Parameters.AddWithValue("@ape", apellido);
            comando.Parameters.AddWithValue("@dir", direccion);
            comando.Parameters.AddWithValue("@fec", fecha);
            comando.Parameters.AddWithValue("@pro", provincia);

            cn.Open();
            comando.ExecuteNonQuery();
            cn.Close();
        }
    }
}
