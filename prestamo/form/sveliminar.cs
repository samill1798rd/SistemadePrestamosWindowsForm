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
    public partial class sveliminar : Form
    {
        public sveliminar()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            clases.servicios t = new clases.servicios();
            int id;
            id = int.Parse(txt0.Text);

            t.eliminar(id);

            this.Close();
        }
    }
}
