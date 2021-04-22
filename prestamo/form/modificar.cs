using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prestamo.form
{
    public partial class modificar : Form
    {
        public modificar()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

     
        private void btnsave_Click(object sender, EventArgs e)
        {
            clases.Clientes m = new clases.Clientes();
            int id;
            id=int.Parse(txt0.Text);

            string fullname=txt1.Text;
            string cedula= txt2.Text;
            string location= txt3.Text; 
            string cell=txt4.Text;



            m.modificar(id,fullname,cedula,location,cell);

            this.Close();
        }
    }
}
