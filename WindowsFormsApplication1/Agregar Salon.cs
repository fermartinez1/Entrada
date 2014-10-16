using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Controladora;

namespace WindowsFormsApplication1
{
    public partial class AgregarSalon : Form
    {
        ControladoraSalones Controladora = new ControladoraSalones();
        public AgregarSalon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length != 0)
                {
                    if (textBox2.Text.Length != 0)
                    {
                        if (Controladora.InsertarSalon(textBox1.Text, Convert.ToInt32(textBox2.Text)) == true)
                        {
                            MessageBox.Show("El salón ha sido cargado");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("El salón ya existe");
                        }
                    }
                    else
                        MessageBox.Show("Por favor ingresar la capacidad del salón");
                }
                else
                    MessageBox.Show("Por favor ingresar el nombre para el salón");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AgregarSalon_Load(object sender, EventArgs e)
        {

        }
    }
}
