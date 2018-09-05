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
    public partial class Form1 : Form
    {
        private EjercicioClase05.Tinta _tinta;
        private EjercicioClase05.Pluma _pluma;

        public Form1()
        {
            InitializeComponent();

        }

        private void tintaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTinta form = new FormTinta();
            form.Show();
        }
    }
}
