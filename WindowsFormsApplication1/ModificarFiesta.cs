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
    public partial class ModificarFiesta : Form
    {
        public int id = 0;
        ControladoraFiestas ControladoraFiesta = new ControladoraFiestas();
        ControladoraSalones ControladoraSalones = new ControladoraSalones();
        ControladoraColegios ControladoraColegios = new ControladoraColegios();
        public ModificarFiesta()
        {
            InitializeComponent();
        }

        private void ModificarFiesta_Load(object sender, EventArgs e)
        {
            try
            {
                Fiesta oFiesta = ControladoraFiesta.TraerFiestasxID(id);
                foreach (Colegio aux in ControladoraColegios.TraerColegios())
                {
                    checkedListBox1.Items.Add(aux.Nombre);
                }
                comboBox1.DataSource = ControladoraSalones.TraerSalones();
                comboBox1.DisplayMember = "nombre";
                textBox1.Text = Convert.ToInt32(oFiesta.Precio).ToString();
                dateTimePicker1.Text = oFiesta.Fecha.ToString();
                comboBox1.SelectedIndex = comboBox1.FindStringExact(oFiesta.Salon.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (checkedListBox1.CheckedItems.Count != 0)
                {
                    if (checkedListBox2.CheckedItems.Count != 0)
                    {
                        if (textBox1.Text.Length != 0)
                        {
                            string colegios = "";
                            foreach (string col in checkedListBox1.CheckedItems)
                            {
                                colegios = "" + colegios + " - " + col + "";
                            }

                            string cursos = "";
                            foreach (string cur in checkedListBox2.CheckedItems)
                            {
                                cursos = "" + cursos + " - " + cur + "";
                            }

                            Fiesta oFiesta = new Fiesta(colegios, Convert.ToDecimal(textBox1.Text), cursos, comboBox1.Text, dateTimePicker1.Text);
                            oFiesta.Id = id;
                            ControladoraFiesta.ModificarFiesta(oFiesta);
                            MessageBox.Show("La fiesta ha sido Modificada");
                            this.Close();
                        }
                        else
                            MessageBox.Show("Por favor ingresar el precio de la entrada");
                    }
                    else
                        MessageBox.Show("Por favor seleccionar cursos");
                }
                else
                    MessageBox.Show("Por favor seleccionar colegios");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
