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
using CapaLogica;
using CapaEntidades;

namespace prestamo.form
{
    public partial class clientes : Form
    {

        Negocio obj = new Negocio();
        persona per = new persona();
        
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
                frm.txt5.Text = dgvbuscar.CurrentRow.Cells[5].Value.ToString();
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
                frm.txt5.Text = dgvbuscar.CurrentRow.Cells[5].Value.ToString();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe selecionar una fila");
            }


        }

    
        private void txt0_TextChanged(object sender, EventArgs e)
        {
    
           
        }

        private void dgvbuscar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dgvbuscar.DataSource = obj.Read();
        }
    }
}
