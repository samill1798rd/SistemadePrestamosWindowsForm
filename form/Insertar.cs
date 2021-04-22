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
using CapaEntidades;
using CapaLogica;
namespace prestamo.form
{
    public partial class Insertar : Form
    {
        persona per = new persona();
        Negocio ejecutor = new Negocio();


        public Insertar()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {

                per.Cedula = txtCedula.Text;
                per.Nombre = txtNombre.Text;
                per.Manzana = cboxmazana.SelectedItem.ToString();
                per.Edificio = cboxedif.SelectedItem.ToString();
                per.Apartamento = txtApartamento.Text;

                ejecutor.insertar(per);

                MessageBox.Show("Persona Registrada");
                this.Close();
            }

            catch(Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

          
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
   
}
