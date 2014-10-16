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
    public partial class ModificarColegio : Form
    {
        ControladoraColegios controladora = new ControladoraColegios();
        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public ModificarColegio()
        {
            InitializeComponent();
        }

        private void BotonModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length != 0)
                {
                    if (controladora.ModificarColegio(textBox1.Text, id) == true)
                    {
                        MessageBox.Show("El colegio fué modificado");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("El colegio ingresado ya existe");
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

        private void ModificarColegio_Load(object sender, EventArgs e)
        {

        }
    }
}
