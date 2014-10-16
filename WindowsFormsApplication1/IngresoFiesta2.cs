using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Entidades;
using Controladora;

namespace WindowsFormsApplication1
{
    public partial class IngresoFiesta2 : Form
    {
        ControladoraEntradas ControladoraEntradas = new ControladoraEntradas();
        Fiesta fiesta;
    

     
        public Fiesta Fiesta
        {
            get { return fiesta; }
            set { fiesta = value; }
        }

        public IngresoFiesta2()
        {
            InitializeComponent();
        }

        public void exportaraexcel(DataGridView tabla)
        {
          
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            excel.Application.Workbooks.Add(true);

            int IndiceColumna = 0;

            foreach (DataGridViewColumn col in tabla.Columns) // Columnas
            {

                IndiceColumna++;

                excel.Cells[1, IndiceColumna] = col.Name;

            }

            int IndeceFila = 0;

            foreach (DataGridViewRow row in tabla.Rows) // Filas
            {

                IndeceFila++;

                IndiceColumna = 0;

                foreach (DataGridViewColumn col in tabla.Columns)
                {

                    IndiceColumna++;

                    excel.Cells[IndeceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;

                }

            }

            excel.Visible = true;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IngresoFiesta2_Load(object sender, EventArgs e)
        {
            try
            {
                label1.Text = "Fiesta: " + fiesta.Colegios + "";
                dataGridView1.DataSource = ControladoraEntradas.TraerEntradasxFiesta(fiesta.Id);
                foreach (DataGridViewRow row in dataGridView1.Rows)
                    if (Convert.ToInt32(row.Cells[6].Value) == 1)
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            exportaraexcel(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                List<Entrada> lista;
                if (radioButton1.Checked == true)
                {
                    if (textBox1.TextLength != 0)
                    {
                        lista = ControladoraEntradas.TraerEntradasxFiestaxDNI(fiesta.Id, Convert.ToInt32(textBox1.Text));
                        dataGridView1.DataSource = lista;
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                            if (Convert.ToInt32(row.Cells[6].Value) == 1)
                            {
                                row.DefaultCellStyle.BackColor = Color.Red;
                            }
                    }
                    else
                        MessageBox.Show("Por favor ingresar un número de DNI");
                }
                if (radioButton2.Checked == true)
                {
                    lista = ControladoraEntradas.TraerEntradasxFiestaxApellido(fiesta.Id, textBox1.Text);
                    dataGridView1.DataSource = lista;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                        if (Convert.ToInt32(row.Cells[6].Value) == 1)
                        {
                            row.DefaultCellStyle.BackColor = Color.Red;
                        }
                }
                if (radioButton3.Checked == true)
                {
                    if (textBox1.TextLength != 0)
                    {
                        lista = ControladoraEntradas.TraerEntradasxFiestaxNum(fiesta.Id, Convert.ToInt32(textBox1.Text));
                        dataGridView1.DataSource = lista;
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                            if (Convert.ToInt32(row.Cells[6].Value) == 1)
                            {
                                row.DefaultCellStyle.BackColor = Color.Red;
                            }
                    }
                    else
                        MessageBox.Show("Por favor ingresar un número de Entrada");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int idEntrada = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
                Entrada oEntrada = ControladoraEntradas.TraerEntradaFiestaxID(idEntrada);
                if (oEntrada.USADA == 0)
                {
                    IngresoFiesta3 form = new IngresoFiesta3();
                    form.IdEntrada = idEntrada;
                    form.FormClosed += new System.Windows.Forms.FormClosedEventHandler(IngresoFiesta2_Load);
                    form.Show();
                }
                if (oEntrada.USADA == 1)
                {
                    MessageBox.Show("La entrada número " + oEntrada.NRO + " con el DNI " + oEntrada.DNI + " ya fué utilizada");
                }
                if (oEntrada.USADA == 2)
                {
                    MessageBox.Show("La entrada número " + oEntrada.NRO + " con el DNI " + oEntrada.DNI + " fué ANULADA");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
