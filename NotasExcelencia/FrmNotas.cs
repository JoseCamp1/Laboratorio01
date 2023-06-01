using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NotasExcelencia
{
    public partial class FrmNotas : Form
    {
        public FrmNotas()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        //Funcion Calcular porcentaje
        public double CalcularPorcentaje(double nota)
        {
            return nota * 0.25;
        }

        //borrar datos
        public void Limpiar()
        {
            txtnombre.Text = string.Empty;
            txtexamen1.Text = "";
            txtexamen2.Text = "";
            txtexamen3.Text = "";
            txtexamen4.Text = "";
            txtporcentaje1.Text = string.Empty;
            txtporcentaje2.Text = string.Empty;
            txtporcentaje3.Text = string.Empty;
            txtporcentaje4.Text = string.Empty;
            txtpromedio.Text = string.Empty;
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double ex1, ex2, ex3, ex4;
            ex1 = ex2 = ex3 = ex4 = 0;
            double prom = 0;

            if (string.IsNullOrEmpty(txtexamen1.Text) || string.IsNullOrEmpty(txtexamen2.Text) || string.IsNullOrEmpty(txtexamen3.Text) || string.IsNullOrEmpty(txtexamen4.Text))
            {
                MessageBox.Show("Falta al menos una nota. Favor verificar e intentar de nuevo", "Atención", MessageBoxButtons.OK);
                if (string.IsNullOrEmpty(txtexamen1.Text))
                {
                    txtexamen1.Focus();
                }
                else if (string.IsNullOrEmpty(txtexamen2.Text))
                {
                    txtexamen2.Focus();
                }
                else if (string.IsNullOrEmpty(txtexamen3.Text))
                {
                    txtexamen3.Focus();
                }
                else
                {
                    txtexamen4.Focus();
                }
                return; // Detener la ejecución del método en caso de notas faltantes
            }

            if (string.IsNullOrEmpty(txtnombre.Text))
            {
                MessageBox.Show("Favor incluir el nombre del estudiante", "Atención", MessageBoxButtons.OK);
                txtnombre.Focus();
                return; // Detener la ejecución del método si no se ha ingresado un nombre
            }

            double.TryParse(txtexamen1.Text, out ex1);
            double.TryParse(txtexamen2.Text, out ex2);
            double.TryParse(txtexamen3.Text, out ex3);
            double.TryParse(txtexamen4.Text, out ex4);

            if (ex1 > 0 && ex1 <= 100 && ex2 > 0 && ex2 <= 100 && ex3 > 0 && ex3 <= 100 && ex4 > 0 && ex4 <= 100)
            {
                txtporcentaje1.Text = CalcularPorcentaje(ex1).ToString();
                txtporcentaje2.Text = CalcularPorcentaje(ex2).ToString();
                txtporcentaje3.Text = Math.Round(CalcularPorcentaje(ex3), 2).ToString();
                txtporcentaje4.Text = Math.Round(CalcularPorcentaje(ex4), 2).ToString();

                prom = (ex1 + ex2 + ex3 + ex4) / 4;

                string cond = "";
                if (prom >= 70)
                {
                    cond = "APROBADO";
                    txtpromedio.ForeColor = Color.Green;
                }
                else if (prom >= 50)
                {
                    cond = "APLAZADO";
                    txtpromedio.ForeColor = Color.Brown;
                }
                else
                {
                    cond = "REPROBADO";
                    txtpromedio.ForeColor = Color.Red;
                }

                txtpromedio.Text = txtnombre.Text + " - " + prom + " - " + cond;
            }
            else
            {
                MessageBox.Show("Las notas deben estar entre 0 y 100", "Atención", MessageBoxButtons.OK);
            }
        }




        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void ValidarEntrada(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // Verificar si es numérico, la tecla de retroceso o la coma decimal
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == ',')
            {
                // Permitir el carácter
                e.Handled = false;

                // Obtener el texto actual en el TextBox
                string currentText = textBox.Text;

                // Obtener el texto después de agregar el carácter presionado
                string newText = currentText.Insert(textBox.SelectionStart, e.KeyChar.ToString());

                // Verificar si el nuevo texto tiene más de 3 dígitos o si es mayor a 100
                if (newText.Length > 3 || (newText.Length == 3 && double.Parse(newText) > 100))
                {
                    e.Handled = true; // Cancelar el evento
                }
            }
            else
            {
                e.Handled = true; // Cancelar el evento
            }
        }


        public void MuyGrande(TextBox num)
        {
            if (double.TryParse(num.Text, out double n))
            {
                if (n > 100)
                {
                    MessageBox.Show("La nota no puede ser mayor a 100", "Nota fuera de rango", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    num.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("El valor ingresado no es válido", "Valor incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                num.Text = string.Empty;
            }
        }


        private void txtexamen1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarEntrada(sender, e);
            //Limpiar();
        }

        private void txtexamen2_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarEntrada(sender, e);
            //Limpiar();
        }

        private void txtexamen3_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarEntrada(sender, e);
            //Limpiar();
        }

        private void txtexamen4_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarEntrada(sender, e);
            //Limpiar();
        }

        private void txtexamen1_KeyUp(object sender, KeyEventArgs e)
        {
            MuyGrande(txtexamen1);
        }

        private void txtexamen2_KeyUp(object sender, KeyEventArgs e)
        {
            MuyGrande(txtexamen2);
        }

        private void txtexamen3_KeyUp(object sender, KeyEventArgs e)
        {
            MuyGrande(txtexamen3);
        }

        private void txtexamen4_KeyUp(object sender, KeyEventArgs e)
        {
            MuyGrande(txtexamen1);
        }
    }
}
