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
    public partial class AgregarFiesta : Form
    {
        ControladoraColegios ControladoraColegios = new ControladoraColegios();
        ControladoraSalones ControladoraSalones = new ControladoraSalones();
        ControladoraFiestas ControladoraFiestas = new ControladoraFiestas();
        public AgregarFiesta()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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
                            ControladoraFiestas.InsertarFiesta(oFiesta);
                            MessageBox.Show("Fiesta Creada");
                            this.Close();
                        }
                        else
                            MessageBox.Show("Por favor ingresar el precio de las entradas");
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

        private void AgregarFiesta_Load_1(object sender, EventArgs e)
        {
            try
            {

                foreach (Colegio aux in ControladoraColegios.TraerColegios())
                {
                    checkedListBox1.Items.Add(aux.Nombre);
                }
                comboBox1.DataSource = ControladoraSalones.TraerSalones();
                comboBox1.DisplayMember = "nombre";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}