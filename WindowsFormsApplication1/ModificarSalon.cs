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
    public partial class ModificarSalon : Form
    {
        ControladoraSalones Controladora = new ControladoraSalones();
        public int id = 0;
        public ModificarSalon()
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
                        if (Controladora.ModificarSalon(textBox1.Text, Convert.ToInt32(textBox2.Text), id) == true)
                        {
                            MessageBox.Show("Salón Modificado");
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
            catch {
                MessageBox.Show("No se puede modificar el salón. Por favor verificar campos");
            }
        }

        private void ModificarSalon_Load(object sender, EventArgs e)
        {

        }
    }
}
