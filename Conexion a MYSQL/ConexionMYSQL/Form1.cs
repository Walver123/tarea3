using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionMYSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCONECTAR_Click(object sender, EventArgs e)
        {

            string MYSQL = txtSERVIDOR.Text;
            string ENTRADA = txtPUERTO.Text;
            string USUARIO = txtUSUARIO.Text;
            string CONTRASENIA = txtPASSWORD.Text;
            string BASEDEDATOS = txtBD.Text;

            string cadenaConexion = "Database = " + BASEDEDATOS + ";Data Source = " + MYSQL + "; Port = "+ENTRADA+"; User Id =" + USUARIO+"; Password ="+CONTRASENIA;

            MySqlConnection conexiondb = new MySqlConnection(cadenaConexion);

            MySqlDataReader reader = null;

            string data = null;

            try
            {
                string consulta = "SHOW DATABASES";
                MySqlCommand comando = new MySqlCommand(consulta);
                comando.Connection = conexiondb;
                conexiondb.Open();
                reader = comando.ExecuteReader();

                while(reader.Read())
                {
                    data += reader.GetString(0);
                }

                MessageBox.Show("COnectado: "+ data);
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Error:" +ex.Message);
            }

            finally
            {
                conexiondb.Close();
            }
        }
    }
}
