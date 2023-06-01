using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotasExcelencia
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mnuCalcular_Click(object sender, EventArgs e)
        {
            //crea la instancia del formulario
            FrmNotas frm = new FrmNotas();
            //hace que el formulario se muestre como un hijo del MDI
            frm.MdiParent = this;
            //muestra el formulario
            frm.Show();
        }

        private void mnuExcelencia_Click(object sender, EventArgs e)
        {
            FrmDeterminarExcelencia frm = new FrmDeterminarExcelencia();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuAcerca_Click(object sender, EventArgs e)
        {
            MessageBox.Show("INA-Laboratorio 1\nCualquier inconveniente preguntar al \nProfesor: Luis Alonso Bogantes Rodriguez.");
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
