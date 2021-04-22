using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace prestamo.clases
{
    class Conexion
    {
        string cadena = "Data Source=.;Initial Catalog = prestamos; Integrated Security = True";
        public SqlConnection conectar = new SqlConnection();

        public Conexion()
        {
            conectar.ConnectionString = cadena;
        }

        public void abrir()
        {
            try 
            {
                conectar.Open();
                
            }
            catch(Exception Ex)
            {
                MessageBox.Show("Error"+ Ex.ToString());
            }

           
        }

        public void cerrar() 
        {
            conectar.Close();
        }
    }
}
