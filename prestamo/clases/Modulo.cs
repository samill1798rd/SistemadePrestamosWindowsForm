using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace prestamo.clases
{
      
    class Clientes
    {
        Conexion p = new Conexion();
        public string insertar(string fullname, string cedula, string location, string cell)
        {
            string salida = "se inserto";
            p.abrir();
        
               string cadena="insert into cliente(fullname,cedula,location,cell) values('" + fullname + "','" + cedula + "','" + location + "','" + cell + "')";
            SqlCommand comando = new SqlCommand(cadena, p.conectar);
            comando.ExecuteNonQuery();
            MessageBox.Show("Los Datos se guardaron corectamente");


            return salida;
            
        }


        public string modificar(int id,string fullname, string cedula, string location, string cell)
        {
            string salida = "se inserto";
            p.abrir();

            string cadena = "update cliente set fullname='" + fullname + "',cedula='" + cedula + "',location='" + location + "',cell='" + cell + "' where Idcliente="+id; 
            SqlCommand comando = new SqlCommand(cadena, p.conectar);
            comando.ExecuteNonQuery();
            MessageBox.Show("Los Datos se Modificaron corectamente");


            return salida;

        }




        public string eliminar (int id)
        {
            string salida = "se inserto";
            p.abrir();

            string cadena = "delete from cliente where Idcliente="+ id;
            SqlCommand comando = new SqlCommand(cadena, p.conectar);
            comando.ExecuteNonQuery();
            MessageBox.Show("Los Datos se eliminaron corectamente");


            return salida;

        }



    }

    class servicios
    {

        Conexion p = new Conexion();
        public string insertar(int id, string tiempo, int monto, int interes, int meses, double cuota,double balance)
        {
            string salida = "se inserto";
            p.abrir();
            string cadena = "insert into prestamo(clienteid,tiempo,monto,balanace,interes,meses,cuotas) values("+id+",'"+tiempo+"',"+monto+","+balance+","+interes+","+meses+","+cuota+")";
           
            SqlCommand comando = new SqlCommand(cadena, p.conectar);
            comando.ExecuteNonQuery();
            MessageBox.Show("Los Datos se guardaron corectamente");


            return salida;

        }

        public string modificar(int id, int monto)
        {
            string salida = "se inserto";
            p.abrir();

            string cadena = "update prestamo set monto='" + monto + "' where Idprestamo=" + id;
            SqlCommand comando = new SqlCommand(cadena, p.conectar);
            comando.ExecuteNonQuery();
            MessageBox.Show("Monto Modificado");


            return salida;

        }

        public string eliminar(int id)
        {
            string salida = "se inserto";
            p.abrir();

            string cadena = "delete from prestamo where Idprestamo=" + id;
            SqlCommand comando = new SqlCommand(cadena, p.conectar);
            comando.ExecuteNonQuery();
            MessageBox.Show("Los Datos se eliminaron corectamente");


            return salida;

        }


        public string pago(int id, int pago)
        {
            string salida = "se inserto";
            p.abrir();

            string cadena = "update prestamo set balanace='" + pago + "' where Idprestamo=" + id;
            SqlCommand comando = new SqlCommand(cadena, p.conectar);
            comando.ExecuteNonQuery();
            MessageBox.Show("Pago descontado");


            return salida;

        }




    }

}
