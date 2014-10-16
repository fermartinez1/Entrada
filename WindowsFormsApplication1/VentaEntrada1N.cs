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
    public partial class VentaEntrada1N : Form
    {
        
        ControladoraFiestas controladoraFiestas = new ControladoraFiestas();
        public VentaEntrada1N()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            try{
            dataGridView1.DataSource = controladoraFiestas.TraerFiestas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

      



        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

   

  

         private void button2_Click_1(object sender, EventArgs e)
        {
             try
             {
            dataGridView1.DataSource = controladoraFiestas.TraerFiestasxColegio(textBox2.Text);
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
                dataGridView1.DataSource = controladoraFiestas.TraerFiestasxFecha(dateTimePicker1.Text);
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                VentaEntrada2 form = new VentaEntrada2();
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
                form.IdFiesta = id;
                form.Show();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
