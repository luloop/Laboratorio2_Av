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


namespace frmTempera
{
    public partial class FrmTempera : Form
    {
        private Tempera _miTempera;

        public Tempera Tempera
        {
            get { return this._miTempera; }
        }

        public FrmTempera()
        {
            this.DialogResult = DialogResult.None;
            InitializeComponent();

            foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
            {
                comboBox1.Items.Add(color);
            }
            comboBox1.SelectedItem = ConsoleColor.DarkYellow;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public FrmTempera(Tempera tempera) : this() // llamas al constructor inicial, para que inicialice y depsus se le carga los setter
        {
            textBox3.Text=  tempera.Cantidad.ToString();
            comboBox1.Text = tempera.Color.ToString();
            textBox2.Text = tempera.Marca;            

        }


        private void button2_Click(object sender, EventArgs e)
        {
            this._miTempera = new Tempera(sbyte.Parse(textBox3.Text), (ConsoleColor)this.comboBox1.SelectedItem, textBox2.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}