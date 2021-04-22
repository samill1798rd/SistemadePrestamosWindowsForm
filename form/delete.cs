using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaLogica;

namespace prestamo.form
{
    public partial class delete : Form
    {

        Negocio obj = new Negocio();
        persona per = new persona();
        public delete()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            try
            {
                per.Id = txt0.Text;
                obj.eliminar(per);

                MessageBox.Show("Persona Elimanada");
               this.Close();
            }

            catch(Exception ex)
            {

                MessageBox.Show(ex.ToString());

            }

        }
    }
}
