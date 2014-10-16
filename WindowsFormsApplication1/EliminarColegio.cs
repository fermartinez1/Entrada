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
    public partial class EliminarColegio : Form
    {
        int id;
        ControladoraColegios controladora = new ControladoraColegios();

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public EliminarColegio()
        {
            InitializeComponent();
        }

        private void Si_Click(object sender, EventArgs e)
        {
            try
            {
                controladora.EliminarColegio(id);
                MessageBox.Show("El colegio fué eliminado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Close();
            }
        }

        private void No_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EliminarColegio_Load(object sender, EventArgs e)
        {

        }
    }
}
