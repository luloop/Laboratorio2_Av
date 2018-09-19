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
        private Paleta _paleta;

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
                textBox1.Text = (string)this._paleta; 
            }

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string texto = this.textBox1.SelectedText;
            int index = 0;
            foreach (string item in this.textBox1.Lines)
            {
                if (texto == item)
                {
                   FrmTempera formtempera = new FrmTempera(this._paleta, index);
                    {
                        DialogResult dialogo = formtempera.ShowDialog();
                        if( dialogo == DialogResult.OK)
                        {
                            Tempera[] lolo = this._paleta + index;
                            this._paleta -= lolo[0];
                            textBox1.Text = (string)this._paleta; 
                        }

                        
                    }
                   



                    break;
                }
                else
                index++;
            }
            index = index - 1;
            texto += "\r\n Posicion :" + index.ToString();

            MessageBox.Show(texto);

            


            

        }
    }
}
