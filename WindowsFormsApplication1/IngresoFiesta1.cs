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
    public partial class IngresoFiesta1 : Form
    {
        ControladoraFiestas ControladoraFiesta = new ControladoraFiestas();

        public IngresoFiesta1()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            try
            {

            dataGridView1.DataSource = ControladoraFiesta.TraerFiestas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = ControladoraFiesta.TraerFiestasxColegio(textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = ControladoraFiesta.TraerFiestasxFecha(dateTimePicker1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
                    if (id != 0)
                    {
                        Fiesta ofiesta = ControladoraFiesta.TraerFiestasxID(id);
                        IngresoFiesta2 form = new IngresoFiesta2();
                        form.Fiesta = ofiesta;
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una fiesta");
                    }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
