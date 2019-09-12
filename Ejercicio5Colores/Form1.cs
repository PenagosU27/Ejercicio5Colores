using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5Colores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;
        }

        private void Fondo_Load(object sender, EventArgs e)
        {
           
        }

        private void Btnazul_Click(object sender, EventArgs e)
        {
           BackColor = Color.Blue;
        }

        private void Btnamarillo_Click(object sender, EventArgs e)
        {
           BackColor = Color.Yellow;
        }

        private void Btnrojo_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void Btncafe_Click(object sender, EventArgs e)
        {
            BackColor = Color.Brown;
        }
    }
}
