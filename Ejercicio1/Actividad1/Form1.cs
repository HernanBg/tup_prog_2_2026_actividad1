using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Actividad1.Models;

namespace Actividad1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Rectangulo nuevo =new Rectangulo(7,10);
            string json = nuevo.Describir();
            textBox1.Text = json;
        }
    }
}
