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
    public partial class ModificarEntrada : Form
    {
        ControladoraFiestas ControladoraFiesta = new ControladoraFiestas();
        public ControladoraEntradas ControladoraEntrada = new ControladoraEntradas();
        public ModificarEntrada()
        {
            InitializeComponent();
        }

        private void ModificarEntrada_Load(object sender, EventArgs e)
        {
            try
            {

            dataGridView1.DataSource = ControladoraEntrada.TraerEntradasTodas();
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

   

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (radioDNI.Checked == true)
                {
                    dataGridView1.DataSource = ControladoraEntrada.TraerEntradasxDNI(Convert.ToInt32(textBox1.Text));
                }
                if (radioNRO.Checked == true)
                {
                    dataGridView1.DataSource = ControladoraEntrada.TraerEntradasxNRO(Convert.ToInt32(textBox1.Text));
                }
                if (radioApellido.Checked == true)
                {
                    dataGridView1.DataSource = ControladoraEntrada.TraerEntradasxApellido(textBox1.Text);
                }
                foreach (DataGridViewRow row in dataGridView1.Rows)
                    if (Convert.ToInt32(row.Cells[5].Value) == 1)
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

  

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ModificarEntrada1 form = new ModificarEntrada1();
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
                form.IdEntrada = id;
                form.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
    }
}
