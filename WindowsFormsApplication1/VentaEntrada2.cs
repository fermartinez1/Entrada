using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Controladora;
using Entidades;
namespace WindowsFormsApplication1
{
    public partial class VentaEntrada2 : Form
    {
        int idFiesta;
        ControladoraEntradas ControladoraEntradas = new ControladoraEntradas();
        ControladoraFiestas ControladoraFiesta = new ControladoraFiestas();

        public int IdFiesta
        {
            get { return idFiesta; }
            set { idFiesta = value; }
        }
        public VentaEntrada2()
        {
            InitializeComponent();
        }

 
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void VentaEntrada2_Load(object sender, EventArgs e)
        {
            try
            {
            Fiesta oFiesta = ControladoraFiesta.TraerFiestasxID(IdFiesta);
            TxtFiesta.Text = oFiesta.Colegios;
            dataGridView1.DataSource = ControladoraEntradas.TraerEntradasxFiesta(idFiesta);
            dataGridView1.Columns["FiestaID1"].Visible = false;
            dataGridView1.Columns["Id"].Visible = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
                if (Convert.ToInt32(row.Cells[6].Value) == 1)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
            VentaEntrada3 form = new VentaEntrada3();
            form.IdFiesta = idFiesta;
            form.Show();
            this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
