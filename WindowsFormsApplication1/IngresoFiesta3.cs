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
    public partial class IngresoFiesta3 : Form
    {
        int idEntrada;
        Entrada oEntrada;
        ControladoraEntradas controladora = new ControladoraEntradas();

        public int IdEntrada
        {
            get { return idEntrada; }
            set { idEntrada = value; }
        }

        public IngresoFiesta3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                controladora.MarcarIngresada(idEntrada);
                MessageBox.Show("Ingreso permitido");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void IngresoFiesta3_Load(object sender, EventArgs e)
        {
            try
            {
                oEntrada = controladora.TraerEntradaFiestaxID(idEntrada);
                labelApellido.Text = oEntrada.APELLIDO.ToString();
                labelNombre.Text = oEntrada.NOMBRE.ToString();
                labelNum.Text = oEntrada.NRO.ToString();
                labelPrecio.Text = "$ " + oEntrada.Precio.ToString() + "";
                labelDNI.Text = oEntrada.DNI.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
