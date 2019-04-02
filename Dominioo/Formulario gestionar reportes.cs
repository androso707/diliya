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
    public partial class FormularioGestionarReportes : Form
    {

        string ESTACT = "";
        public FormularioGestionarReportes()
        {
            InitializeComponent();
        }

   

        SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\SANTIAGO\SOFTWAREII\WINDOWSFORMSAPP1\DATABASE.MDF;Integrated Security=True;Connect Timeout=30");

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormularioGestionarReportes_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNCAMBIO_Click(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand cmd = conexion.CreateCommand();
            cmd.CommandText = "SELECT ESTADO FROM[TRAMITES] WHERE ID ='" + CODTRAMITE.Text+"'";
            cmd.ExecuteNonQuery();
           
            ESTACT = cmd.ExecuteNonQuery().ToString();
            if (CODTRAMITE.Text==ESTACT)
            {
                MessageBox.Show("ESE ES EL ESTADO ACTUAL DEL TRAMITE");
            }
            cmd.CommandText = "UPDATE TRAMITES SET ESTADO ='" + NEWSTATE.Text+"'"+" WHERE  ID = '"+CODTRAMITE.Text+"'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("SE HA HECHO LA MODIFICACION");
            MessageBox.Show(ESTACT);
            conexion.Close();
        }
    }
}

