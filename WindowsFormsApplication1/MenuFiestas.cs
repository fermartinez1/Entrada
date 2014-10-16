using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Controladora;
using System.Globalization;

namespace WindowsFormsApplication1
{
    public partial class MenuFiestas : Form
    {
        ControladoraFiestas ControladoraFiesta = new ControladoraFiestas();
        public MenuFiestas()
        {
            InitializeComponent();
        }

        private void form_FormClosed(object sender, FormClosedEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            AgregarFiesta form = new AgregarFiesta();
            form.Show();
            form.FormClosed += new System.Windows.Forms.FormClosedEventHandler(form_FormClosed);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
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

        private void button4_Click_1(object sender, EventArgs e)
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

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
                ModificarFiesta form = new ModificarFiesta();
                form.id = id;
                form.Show();
                form.FormClosed += new System.Windows.Forms.FormClosedEventHandler(form_FormClosed);
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
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
                EliminarFiesta form = new EliminarFiesta();
                form.Id = id;
                form.Show();
                form.FormClosed += new System.Windows.Forms.FormClosedEventHandler(form_FormClosed);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MenuFiestas_Load(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }





    }
}
