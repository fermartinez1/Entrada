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
    public partial class EliminarFiesta : Form
    {
        int id;
        ControladoraFiestas ControladoraFiesta = new ControladoraFiestas();
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public EliminarFiesta()
        {
            InitializeComponent();
        }

        private void EliminarFiesta_Load(object sender, EventArgs e)
        {


        }

        private void Si_Click_1(object sender, EventArgs e)
        {
            try
            {
                ControladoraFiesta.EliminarFiesta(id);
                MessageBox.Show("Fiesta Eliminada");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void No_Click_1(object sender, EventArgs e)
        {
            this.Close();
            MenuFiestas form = new MenuFiestas();
            form.Show();
        }
    }
}
