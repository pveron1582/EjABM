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
    public partial class AltaProductos : Form
    {
        string cadenaConex = @"data source=nOTEBOOK\SQLEXPRESS; initial catalog=Ejercitacion; integrated security=SSPI";
        SqlConnection cn;

        public AltaProductos()
        {
            InitializeComponent();
        }

        private void AltaProductos_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(cadenaConex);
            SqlDataAdapter da;
            DataTable dt = new DataTable();

            cn.Open();
            da = new SqlDataAdapter("select id_tipo, descripcion from tipo_producto", cn);
            da.Fill(dt);

            cbo_prod.DataSource = dt;
            cbo_prod.ValueMember = "id_tipo";
            cbo_prod.DisplayMember = "descripcion";
            cn.Close();
        }

        private void btn_salir(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_nuevoproducto(object sender, EventArgs e)
        {
          
        }

        private void btn_salida_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_altap_Click(object sender, EventArgs e)
        {
            string descripcion = txt_descripcion.Text;
            string precio = txt_precio.Text;
            string tipo = Convert.ToString(cbo_prod.SelectedValue);

             SqlCommand comando = new SqlCommand("insert into Productos (descripcion, precio, id_tipo) values (@des, @pre, @idtipo)", cn);
             comando.Parameters.AddWithValue("@des", descripcion);
             comando.Parameters.AddWithValue("@pre", precio);
             comando.Parameters.AddWithValue("@idtipo", tipo);
             cn.Open();
             comando.ExecuteNonQuery();
             cn.Close();
        }
    }
}
