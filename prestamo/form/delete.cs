﻿using System;
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
    public partial class delete : Form
    {
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
            clases.Clientes t = new clases.Clientes();
            int id;
            id = int.Parse(txt0.Text);

            t.eliminar(id);

            this.Close();
        }

        private void delete_Load(object sender, EventArgs e)
        {

        }
    }
}
