using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesClase07;
using FRM_Tempera;



namespace WF_08
{
    public partial class WF08 : Form
    {
        Paleta _miPaleta;

        public WF08()
        {
            InitializeComponent();
            this._miPaleta = 5;
            this.PaletaDeColores.Text = "Paleta de Colores";
            this.textBox2.Multiline = true;
            this.button1.Text = "+";
            this.button2.Text = "-";
        }

        private void PaletaDeColores_Enter(object sender, EventArgs e)
        {
            this.PaletaDeColores.Text = this._miPaleta;
        }

        private void agregarPaletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.PaletaDeColores.Visible = true;
            this.agregarPaletaToolStripMenuItem1.Enabled = false;
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmtempera frm = new frmtempera();
            frm.Show();
            this._miPaleta += frm.MiTempera;
        }
    }
}
