using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;

namespace prestamo.form
{
    public partial class Insertar : Form
    {
        public Insertar()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txt2.Text;
            string cedula = txt1.Text;
            string direccion = txt3.Text;
            string cell = txt4.Text;

            clases.Clientes p = new clases.Clientes();
            p.insertar(nombre, cedula, direccion, cell);

            txt2.Text = "";
            txt1.Text = "";
            txt3.Text = "";
            txt4.Text = "";

            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Insertar_Load(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
          ///////////////////////////////////
            

            var url= "http://173.249.49.169:88/api/test/consulta/" + txt1.Text;
            WebClient wc = new WebClient();

            var datos = wc.DownloadString(url);

            var rs = JsonConvert.DeserializeObject<resultado>(datos);

            string nombre = rs.Nombres + " " + rs.Apellido1 + " " + rs.Apellido2;
           

           
           

            ptb1.LoadAsync(@"http://173.249.49.169:88/api/test/foto/"+txt1.Text);


            ////////////////////////////////////////
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
    class resultado
    {
        public string Cedula { get; set; }
        public string Nombres { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string FechaNacimiento { get; set; }
        public string LugarNacimiento { get; set; }
        public string Ok { get; set; }
        public string Foto { get; set; }

    }
}
