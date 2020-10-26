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
    public partial class Mostrar : Form
    {

        string cadenaConex = @"data source=nOTEBOOK\SQLEXPRESS; initial catalog=Ejercitacion; integrated security=SSPI";
        SqlConnection cn;


        public Mostrar()
        {
            InitializeComponent();
        }

        private void Mostrar_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(cadenaConex);
        }

        private void btn_mostrarclientes_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = "select * from Clientes;";

            cn.Open();
            da = new SqlDataAdapter(query, cn);
            da.Fill(dt);
            cn.Close();

            dataGridView1.DataSource = dt;
        }

        private void btn_mostrarproductos_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = "select * from Productos;";

            cn.Open();
            da = new SqlDataAdapter(query, cn);
            da.Fill(dt);
            cn.Close();

            dataGridView1.DataSource = dt;
        }

        private void btn_buscarproducto_Click(object sender, EventArgs e)
        {
            string producto = txt_descripcion.Text;
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string consulta = "select * from Productos where descripcion like @prod;";
            
            cn.Open();
            da = new SqlDataAdapter(consulta, cn);
            da.SelectCommand.Parameters.AddWithValue("@prod", "%" + producto + "%");
            da.Fill(dt);
            cn.Close();

            dataGridView1.DataSource = dt;
        }

        private void btn_buscarCliente_Click(object sender, EventArgs e)
        {
            string nombreape = txt_nombreape.Text;
            

            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string consulta = "select nombre ,apellido, direccion from Clientes where nombre like @nomape or apellido like @nomape;";

            cn.Open();
            da = new SqlDataAdapter(consulta, cn);
            da.SelectCommand.Parameters.AddWithValue("@nomape", "%" + nombreape + "%");
            
            da.Fill(dt);
            cn.Close();

            dataGridView1.DataSource = dt;
        }
    }
}
