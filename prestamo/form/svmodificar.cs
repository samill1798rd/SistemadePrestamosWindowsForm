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
    public partial class svmodificar : Form
    {
        public svmodificar()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            clases.servicios t = new clases.servicios();

            int id =int.Parse(txt0.Text);
            int monto = int.Parse(txt2.Text);

               t.modificar(id,monto);


            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
