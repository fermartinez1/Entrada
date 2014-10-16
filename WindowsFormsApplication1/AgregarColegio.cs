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
    public partial class AgregarColegio : Form
    {
        ControladoraColegios Controladora = new ControladoraColegios();
        public AgregarColegio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length != 0)
                {
                    if (Controladora.InsertarColegio(textBox1.Text) == true)
                    {
                        MessageBox.Show("Colegio Creado");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("El Colegio ya existe");
                    }
                }
                else
                    MessageBox.Show("Por favor ingresar el nombre para el colegio");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AgregarColegio_Load(object sender, EventArgs e)
        {

        }
    }
}
