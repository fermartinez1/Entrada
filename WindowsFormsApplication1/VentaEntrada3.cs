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
    public partial class VentaEntrada3 : Form
    {

        int idFiesta;
        ControladoraEntradas ControladoraEntradas = new ControladoraEntradas();
        ControladoraFiestas ControladoraFiesta = new ControladoraFiestas();
        public int IdFiesta
        {
            get { return idFiesta; }
            set { idFiesta = value; }
        }
        Fiesta oFiesta = new Fiesta();

        public VentaEntrada3()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            try
            {
            oFiesta = ControladoraFiesta.TraerFiestasxID(idFiesta);
            txtFiesta.Text = oFiesta.Colegios;
            txtprecio.Text = oFiesta.Precio.ToString();
            txtnro.Text = ControladoraEntradas.TraerProximoNum().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Entrada oEntrada = new Entrada(Convert.ToInt32(txtdni.Text), txtapellido.Text, txtnombre.Text, Convert.ToInt32(txtnro.Text), 0, IdFiesta, oFiesta.Colegios, Convert.ToDecimal(txtprecio.Text));
                if (ControladoraEntradas.VerificarNro(oEntrada.NRO) == false)
                {

                    ControladoraEntradas.InsertarEntrada(oEntrada);
                    MessageBox.Show("Entrada Vendida con Éxito");
                    this.Close();
                    VentaEntrada2 form = new VentaEntrada2();
                    form.IdFiesta = idFiesta;
                    form.Show();
                }
                else
                {
                    MessageBox.Show("El numero de entrada ya fue utilizado");
                }
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
