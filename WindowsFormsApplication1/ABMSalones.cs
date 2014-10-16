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
    public partial class ABMSalones : Form
    {
        ControladoraSalones ControladoraSalon = new ControladoraSalones();
        
        public ABMSalones()
        {
            InitializeComponent();
        }

        public void Actualizar()
        {
            this.Refresh();
        }

        private void MenuSalones_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = ControladoraSalon.TraerSalones();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataGridView1.DataSource = ControladoraSalon.TraerSalones();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AgregarSalon form = new AgregarSalon();
                form.Owner = this;
                form.FormClosed += new System.Windows.Forms.FormClosedEventHandler(form_FormClosed);
                form.Show();
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
            EliminarSalon form = new EliminarSalon();
            form.id = id;
            form.FormClosed += new System.Windows.Forms.FormClosedEventHandler(form_FormClosed);
            form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try{
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
            ModificarSalon form = new ModificarSalon();
            form.id = id;
            form.FormClosed += new System.Windows.Forms.FormClosedEventHandler(form_FormClosed);
            form.Show();
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
