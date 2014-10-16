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
    public partial class Login : Form
    {
        ControladoraUsuario controladora = new ControladoraUsuario();
        Usuario oUsuario;

        public Login()
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
                        oUsuario = controladora.TraerUsuarioLogin(textBox1.Text, textBox2.Text);
                        if (oUsuario != null)
                        {
                            MenuPrincipal form2 = new MenuPrincipal();
                            form2.OUsuario = oUsuario;
                            form2.Show();
                        }
                        else
                            MessageBox.Show("Nombre de usuario o contraseña incorrecta");
                    }
                    else
                        MessageBox.Show("Ingresar contraseña del usuario");
                }
                else
                    MessageBox.Show("Ingresar nombre de usuario");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
