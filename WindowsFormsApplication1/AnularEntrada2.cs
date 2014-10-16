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
    public partial class AnularEntrada2 : Form
    {
        int IdEntrada;
        ControladoraEntradas ControladoraEntrada = new ControladoraEntradas();
        public int IdEntrada1
        {
            get { return IdEntrada; }
            set { IdEntrada = value; }
        }
        public AnularEntrada2()
        {
            InitializeComponent();
        }

    
        private void AnularEntrada2_Load(object sender, EventArgs e)
        {
            try
            {

            Entrada oEntrada = ControladoraEntrada.TraerEntradaxID(IdEntrada);
            txtdni.Text = oEntrada.DNI.ToString();
            txtape.Text = oEntrada.APELLIDO.ToString();
            txtFiesta.Text = oEntrada.Nombrefiesta.ToString();
            txtnombre.Text = oEntrada.NOMBRE.ToString();
            txtnro.Text = oEntrada.NRO.ToString();
            txtprecio.Text = oEntrada.Precio.ToString();
            if (oEntrada.USADA == 1)
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;

            }
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
                ControladoraEntrada.AnularEntrada(IdEntrada);
                MessageBox.Show("Entrada Anulada");
                this.Close();
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
    }
}
