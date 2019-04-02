using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dominioo
{
    public partial class FormularioGestionarUsusarios : Form
    {
        public FormularioGestionarUsusarios()
        {
            InitializeComponent();
        }

       
    

        SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\SANTIAGO\SOFTWAREII\WINDOWSFORMSAPP1\DATABASE.MDF;Integrated Security=True;Connect Timeout=30");

        private void FormularioGestionarUsusarios_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

   

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand cmd = conexion.CreateCommand();
            cmd.CommandText = "SELECT * FROM[USUARIOS] WHERE ID ='" +CODIGO.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable data = new DataTable();
            SqlDataAdapter datap = new SqlDataAdapter(cmd);
            datap.Fill(data);
            PANTALLATABLA.DataSource = data;
            conexion.Close();


        }

        private void FormularioGestionarUsusarios_Load_1(object sender, EventArgs e)
        {

        }

        private void BTNELIMINAR_Click(object sender, EventArgs e)
        {
            conexion.Open();
            
            SqlCommand cmd = conexion.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from [USUARIOS] where cedula = '" + CODIGO.Text + "'";
            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("datos eliminados");
        }
    }
}

