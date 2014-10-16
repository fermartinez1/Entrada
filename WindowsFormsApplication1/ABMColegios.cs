using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using Controladora;

namespace WindowsFormsApplication1
{
    public partial class ABMColegios : Form
    {
        ControladoraColegios ControladoraColegios = new ControladoraColegios();

        public ABMColegios()
        {
            InitializeComponent();
        }

        private void ABMColegios_Load(object sender, EventArgs e)
        {

            try
            {
            dataGridView1.DataSource = ControladoraColegios.TraerColegios();
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

                AgregarColegio form = new AgregarColegio();
                form.FormClosed += new System.Windows.Forms.FormClosedEventHandler(ABMColegios_Load);
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
                if (id != 0)
                {
                    ModificarColegio form = new ModificarColegio();
                    form.Id = id;
                    form.FormClosed += new System.Windows.Forms.FormClosedEventHandler(ABMColegios_Load);
                    form.Show();
                }
                else
                    MessageBox.Show("Por favor seleccionar el colegio que desea modificar");
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
                if (id != 0)
                {
                    EliminarColegio form = new EliminarColegio();
                    form.Id = id;
                    form.FormClosed += new System.Windows.Forms.FormClosedEventHandler(ABMColegios_Load);
                    form.Show();
                }
                else
                    MessageBox.Show("Por favor seleccionar el colegio que desea eliminar");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
