using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioClase06
{
    public partial class FormTinta : Form
    {
        public FormTinta()
        {
            InitializeComponent();
            foreach (ConsoleColor colores in Enum.GetValues(typeof(ConsoleColor)))
            {
                this.cboColores.Items.Add(colores);
            }
            this.cboColores.SelectedItem = ConsoleColor.Yellow;
            this.cboColores.DropDownStyle = ComboBoxStyle.DropDownList;

            foreach (ETipoTinta tipos in Enum.GetValues(typeof(ETipoTinta)))
            {
                this.cboTipo.Items.Add(tipos);
            }
            this.cboTipo.SelectedItem = ETipoTinta.China;
            this.cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            
        }

        private void cboColores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
