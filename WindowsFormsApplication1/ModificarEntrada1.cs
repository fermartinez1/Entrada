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
    public partial class ModificarEntrada1 : Form
    {
        int idEntrada;
        ControladoraEntradas ControladoraEntrada = new ControladoraEntradas();

        public int IdEntrada
        {
            get { return idEntrada; }
            set { idEntrada = value; }
        }

        public ModificarEntrada1()
        {
            InitializeComponent();
        }

        private void ModificarEntrada1_Load(object sender, EventArgs e)
        {
            try
            {
                Entrada oEntrada = ControladoraEntrada.TraerEntradaxID(idEntrada);
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

  

 

        private void btnmodificar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Entrada oEntrada = ControladoraEntrada.TraerEntradaxID(idEntrada);
                oEntrada.NOMBRE = txtnombre.Text;
                oEntrada.APELLIDO = txtape.Text;
                oEntrada.DNI = Convert.ToInt32(txtdni.Text);
                oEntrada.NRO = Convert.ToInt32(txtnro.Text);
                if (checkBox1.Checked == true)
                {
                    oEntrada.USADA = 1;
                }
                else
                {
                    oEntrada.USADA = 0;
                }
                if (ControladoraEntrada.VerificarNro(oEntrada.NRO) == false)
                {

                    ControladoraEntrada.ModificarEntrada(oEntrada);
                    MessageBox.Show("Entrada modificada");
                    ModificarEntrada form = new ModificarEntrada();
                    form.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ese nro de entrada ya fue utilizado");
                }
            
               }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ModificarEntrada form = new ModificarEntrada();
            form.Show();
            this.Close();
        }
    }
}
