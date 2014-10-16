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
    public partial class EliminarSalon : Form
    {
        public int id;
        ControladoraSalones Controladora = new ControladoraSalones();
        public EliminarSalon()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EliminarSalon_Load(object sender, EventArgs e)
        {  
            
        }

        private void Si_Click(object sender, EventArgs e)
        {
            try
            {
                Controladora.EliminarSalon(id);
                MessageBox.Show("Salón eliminado");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
