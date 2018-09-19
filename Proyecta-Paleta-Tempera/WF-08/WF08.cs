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
            this.gbxPaletaDeColores.Text = "Paleta de Colores";
            this.textBox2.Multiline = true;
            this.button1.Text = "+";
            this.button2.Text = "-";
        }

        private void PaletaDeColores_Enter(object sender, EventArgs e)
        {
            this.gbxPaletaDeColores.Text = this._miPaleta.ToString();
        }

        private void agregarPaletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.gbxPaletaDeColores.Visible = true;
            this.agregarPaletaToolStripMenuItem1.Enabled = false;
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmtempera frm = new frmtempera();
            DialogResult resultado = frm.ShowDialog();
            if ( resultado == DialogResult.OK)
            {
                this._miPaleta += frm.MiTempera;
                this.textBox2.Text = (string)this._miPaleta;
              
            }

            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
