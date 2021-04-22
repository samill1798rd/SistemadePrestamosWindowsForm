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
    public partial class clientes : Form
    {
        public clientes()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void clientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'prestamosDataSet.cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.prestamosDataSet.cliente);

            


        }

       
      

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Insertar fh = new Insertar();
            fh.StartPosition = FormStartPosition.CenterParent;
            fh.ShowDialog();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            modificar frm = new modificar();
            frm.StartPosition = FormStartPosition.CenterParent;
            if (dgvbuscar.SelectedRows.Count > 0)
            {
                frm.txt0.Text = dgvbuscar.CurrentRow.Cells[0].Value.ToString();
                frm.txt1.Text = dgvbuscar.CurrentRow.Cells[1].Value.ToString();
                frm.txt2.Text = dgvbuscar.CurrentRow.Cells[2].Value.ToString();
                frm.txt3.Text = dgvbuscar.CurrentRow.Cells[3].Value.ToString();
                frm.txt4.Text = dgvbuscar.CurrentRow.Cells[4].Value.ToString();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe selecionar una fila");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            delete frm = new delete();
            frm.StartPosition = FormStartPosition.CenterParent;
            if (dgvbuscar.SelectedRows.Count > 0)
            {
                frm.txt0.Text = dgvbuscar.CurrentRow.Cells[0].Value.ToString();
                frm.txt1.Text = dgvbuscar.CurrentRow.Cells[1].Value.ToString();
                frm.txt2.Text = dgvbuscar.CurrentRow.Cells[2].Value.ToString();
                frm.txt3.Text = dgvbuscar.CurrentRow.Cells[3].Value.ToString();
                frm.txt4.Text = dgvbuscar.CurrentRow.Cells[4].Value.ToString();
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

            string cadena = "select Idcliente,fullname, cedula, location, cell from cliente where Idcliente like('" + txt0.Text + "%')";
            SqlCommand comando = new SqlCommand(cadena, p.conectar);
            comando.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);

            da.Fill(dt);
            dgvbuscar.DataSource = dt;
            p.cerrar();
        }
    }
}
