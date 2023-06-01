using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NotasExcelencia
{
    public partial class FrmDeterminarExcelencia : Form
    {
        public FrmDeterminarExcelencia()
        {
            InitializeComponent();
        }

        public void ValidarEntrada(object sender, KeyPressEventArgs e)
        {
            //si es numerico o es una , o es la tecla de retroceso , no cancele el evento
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 4)
            {
                e.Handled = false;
            }
            //cancele el evento asociado
            else { e.Handled = true; }
        }
        private void txtpromedio_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarEntrada(sender, e);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double prom = 0;
            string condicion;
            if (string.IsNullOrEmpty(txtpromedio.Text) || string.IsNullOrEmpty(txtpromedio.Text))
            {
                MessageBox.Show("ingrese el nombre y/o el promedio antes de calcular la condicion", "datos incompletos", MessageBoxButtons.OK);
            }
            else
            {
                double.TryParse(txtpromedio.Text, out prom);
                if (prom > 100)
                {
                    MessageBox.Show("el promedio debe estar entre 1 y 100. porfavor introduzca un promedio valido. intentalo de nuevo");
                    txtpromedio.Text = string.Empty;
                }
                else
                {
                    if (prom >= 90)
                    {
                        condicion = "Excelente";
                    }
                    else if (prom >= 70)
                    {
                        condicion = "Aprovado";
                    }
                    else if (prom >= 60)
                    {
                        condicion = "Aplazado";
                    }
                    else
                    {
                        condicion = "Reprobado";
                    }
                    txtcondicion.Text = condicion;
                }
            }
        }

        public void Limpiar()
        {
            txtnombre.Text = string.Empty;
            txtpromedio.Text = string.Empty;
            txtcondicion.Text = string.Empty;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string datos = string.Empty;
            if (string.IsNullOrEmpty(txtnombre.Text) || string.IsNullOrEmpty(txtpromedio.Text) || string.IsNullOrEmpty(txtcondicion.Text))
            {
                MessageBox.Show("debe ingresar todos los datos antes de agregar al estudiante", "faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //limpiar
            }
            else
            {
                datos = txtnombre.Text + ": " + txtpromedio.Text + " " + txtcondicion.Text;
                lstEstudiantes.Items.Add(datos);
                Limpiar();
                txtnombre.Focus();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            lstEstudiantes.Items.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
