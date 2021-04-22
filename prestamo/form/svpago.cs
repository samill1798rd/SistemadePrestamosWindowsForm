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
    public partial class svpago : Form
    {
        public svpago()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnpago_Click(object sender, EventArgs e)
        {
            clases.servicios t = new clases.servicios();
            int id;

            id = int.Parse(txt0.Text);
            int balance= int.Parse(txt2.Text);
            int pago1= int.Parse(txt3.Text);

            int pago = balance - pago1;


            t.pago(id,pago);

            this.Close();

        }
    }
}
