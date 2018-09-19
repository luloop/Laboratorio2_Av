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


namespace FRM_Tempera
{
    public partial class frmtempera : Form
    {
        private Tempera _MiTempera;

        public Tempera MiTempera { get { return this._MiTempera; }  }
        /// <summary>
        /// ////////////////////////////////////
        /// </summary>

        public frmtempera()
        {
            InitializeComponent();
            this.label1.Text = "Color";
            this.label2.Text = "Marca";
            this.label3.Text = "Cantidad";
            this.button2.Text = "Aceptar";
            this.button3.Text = "Cancela";

            foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
            {
                this.cbo2.Items.Add(color);
            }
            this.cbo2.SelectedItem = ConsoleColor.Blue;
            this.cbo2.DropDownStyle = ComboBoxStyle.DropDownList;



        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           this _MiTempera = new Tempera(sbyte.Parse(this.textBox2.Text),(ConsoleColor)this.cbo2.SelectedItem, this.textBox1.Text);
        }
    }
}
