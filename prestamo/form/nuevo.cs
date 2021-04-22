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
    public partial class nuevo : Form
    {
        public nuevo()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'prestamosDataSet1.cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter1.Fill(this.prestamosDataSet1.cliente);


        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.clienteTableAdapter.FillBy1(this.prestamosDataSet.cliente);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            clases.servicios t = new clases.servicios();

            string tiempo = dtp1.Value.ToString();
            int monto, interes,cuota;
            int cliente = Convert.ToInt32(cbox1.SelectedValue);
            monto = int.Parse(txt1.Text);
            interes = int.Parse(txt2.Text);
            int meses = int.Parse(txt3.Text);
            cuota= int.Parse(txt4.Text);
            
            double resultado = (monto*interes)/100;
            double balance = resultado+monto;
            double cuota1= balance / cuota;


            t.insertar(cliente,tiempo,monto,interes,meses,cuota1,balance);


            this.Close();

        }
    }
}
