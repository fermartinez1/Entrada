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
    public partial class MenuPrincipal : Form
    {
        ControladoraUsuario ControladoraUsuario = new ControladoraUsuario();
        Usuario oUsuario;

        public Usuario OUsuario
        {
            get { return oUsuario; }
            set { oUsuario = value; }
        }

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMSalones form = new ABMSalones();
            form.Show();
        }

        private void fiestasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuFiestas form = new MenuFiestas();
            form.Show();
        }

        private void ventaDeEntradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentaEntrada1N form = new VentaEntrada1N();
            form.Show();
        }

        private void ingresoALaFiestaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresoFiesta1 form = new IngresoFiesta1();
            form.Show();
        }

        private void modificaionDeEntradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarEntrada form = new ModificarEntrada();
            form.Show();
        }

        private void colegiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMColegios form = new ABMColegios();
            form.Show();
        }

        private void anulacionDeEntradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnularEntrada1 form = new AnularEntrada1();
            form.Show();
        }
    }
}
