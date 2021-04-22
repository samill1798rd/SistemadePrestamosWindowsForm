using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prestamo.form
{
    public partial class servicios : Form
    {
        public servicios()
        {
            InitializeComponent();
        }

        private void servicios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'prestamosDataSet2.prestamo' Puede moverla o quitarla según sea necesario.
            this.prestamoTableAdapter2.Fill(this.prestamosDataSet2.prestamo);


        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            nuevo fh = new nuevo();
            fh.StartPosition = FormStartPosition.CenterParent;
            fh.ShowDialog();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.prestamoTableAdapter2.FillBy(this.prestamosDataSet2.prestamo);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

       

        private void btnpago_Click(object sender, EventArgs e)
        {
            svmodificar frm = new svmodificar();
           
            if (dgvbuscar.SelectedRows.Count > 0)
            {
                frm.txt0.Text = dgvbuscar.CurrentRow.Cells[5].Value.ToString();
                frm.txt1.Text = dgvbuscar.CurrentRow.Cells[1].Value.ToString();
                frm.txt2.Text = dgvbuscar.CurrentRow.Cells[8].Value.ToString();

                frm.StartPosition = FormStartPosition.CenterParent;

                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe selecionar una fila");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            sveliminar frm = new sveliminar();

            if (dgvbuscar.SelectedRows.Count > 0)
            {
                frm.txt0.Text = dgvbuscar.CurrentRow.Cells[5].Value.ToString();
                frm.txt1.Text = dgvbuscar.CurrentRow.Cells[1].Value.ToString();
                frm.txt2.Text = dgvbuscar.CurrentRow.Cells[7].Value.ToString();
                frm.txt3.Text = dgvbuscar.CurrentRow.Cells[8].Value.ToString();
                frm.txt4.Text = dgvbuscar.CurrentRow.Cells[10].Value.ToString();
                frm.txt5.Text = dgvbuscar.CurrentRow.Cells[11].Value.ToString();
                frm.txt6.Text = dgvbuscar.CurrentRow.Cells[12].Value.ToString();

                frm.StartPosition = FormStartPosition.CenterParent;

                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe selecionar una fila");
            }
        }

        private void btnmonto_Click(object sender, EventArgs e)
        {
            svmonto frm = new svmonto();
            if (dgvbuscar.SelectedRows.Count > 0)
            {
                frm.txt0.Text = dgvbuscar.CurrentRow.Cells[5].Value.ToString();
                frm.txt1.Text = dgvbuscar.CurrentRow.Cells[1].Value.ToString();
                frm.txt2.Text = dgvbuscar.CurrentRow.Cells[8].Value.ToString();

                frm.StartPosition = FormStartPosition.CenterParent;


                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe selecionar una fila");
            }
        }

        private void txt0_TextChanged(object sender, EventArgs e)
        {
            clases.Conexion p = new clases.Conexion();
            p.abrir();

            string cadena = "SELECT * FROM cliente JOIN prestamo on Idcliente=clienteid where Idcliente like('" + txt0.Text + "%')";
            SqlCommand comando = new SqlCommand(cadena, p.conectar);
            comando.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);

            da.Fill(dt);
            dgvbuscar.DataSource = dt;
            p.cerrar();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btntiempo_Click(object sender, EventArgs e)
        {
            svtiempo frm = new svtiempo();

            if (dgvbuscar.SelectedRows.Count > 0)
            {
                frm.txt0.Text = dgvbuscar.CurrentRow.Cells[5].Value.ToString();
                frm.txt1.Text = dgvbuscar.CurrentRow.Cells[1].Value.ToString();
                frm.txt2.Text = dgvbuscar.CurrentRow.Cells[7].Value.ToString();

                frm.StartPosition = FormStartPosition.CenterParent;


                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe selecionar una fila");
            }
        }

        private void btncuotas_Click(object sender, EventArgs e)
        {
            svcuota frm = new svcuota();

            if (dgvbuscar.SelectedRows.Count > 0)
            {
                frm.txt0.Text = dgvbuscar.CurrentRow.Cells[5].Value.ToString();
                frm.txt1.Text = dgvbuscar.CurrentRow.Cells[1].Value.ToString();
                frm.txt2.Text = dgvbuscar.CurrentRow.Cells[12].Value.ToString();

                frm.StartPosition = FormStartPosition.CenterParent;


                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe selecionar una fila");
            }
        }

        private void btn1pago_Click(object sender, EventArgs e)
        {
            svpago frm = new svpago();
            if (dgvbuscar.SelectedRows.Count > 0)
            {
                frm.txt0.Text = dgvbuscar.CurrentRow.Cells[5].Value.ToString();
                frm.txt1.Text = dgvbuscar.CurrentRow.Cells[1].Value.ToString();
                frm.txt2.Text = dgvbuscar.CurrentRow.Cells[9].Value.ToString();

                frm.StartPosition = FormStartPosition.CenterParent;


                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe selecionar una fila");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            svbalance frm = new svbalance ();
            if (dgvbuscar.SelectedRows.Count > 0)
            {
                frm.txt0.Text = dgvbuscar.CurrentRow.Cells[5].Value.ToString();
                frm.txt1.Text = dgvbuscar.CurrentRow.Cells[1].Value.ToString();
                frm.txt2.Text = dgvbuscar.CurrentRow.Cells[9].Value.ToString();

                frm.StartPosition = FormStartPosition.CenterParent;


                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe selecionar una fila");
            }

        }
    }
}
