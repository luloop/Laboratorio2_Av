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
using frmTempera;

namespace frmPaleta
{
  public partial class frmPaleta : Form
    {
        private PaletaColecciones _paleta;

        public frmPaleta()
        {
            InitializeComponent();
            this._paleta = 5;
            this.groupBox1.Text = "Paleta de colores";
            this.textBox1.Multiline = true;
            this.groupBox1.Visible = false;
            this.button1.Text = "+";
            this.button2.Text = "-";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void agregarPaletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.groupBox1.Visible = true;
            this.agregarPaletaToolStripMenuItem.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           FrmTempera colores = new FrmTempera();
           DialogResult dialogResult = colores.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                this._paleta += colores.Tempera;
                textBox1.Text = (string)this._paleta; ////////////////////////////////////////////////
            }

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmTempera formtempera;
            string texto = this.textBox1.SelectedText;
            int index = -1;
            foreach (string item in this.textBox1.Lines)
            {
               

                if (texto == item)
                {
                    texto += "\r\n Posicion :" + index.ToString();
                    MessageBox.Show(texto);
                    break;
                }

                 index++;
                                             
            }

            if (index >=0)
            { 
                formtempera = new FrmTempera(_paleta[index]);
           
                DialogResult dialogo = formtempera.ShowDialog();
                if (dialogo == DialogResult.OK)
                {
                    this._paleta -= formtempera.Tempera;
                    this.textBox1.Text = (string)this._paleta;
                }


            }









        }
    }
}
