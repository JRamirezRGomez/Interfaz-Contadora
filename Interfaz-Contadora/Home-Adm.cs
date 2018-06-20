using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz_Contadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
         
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            int a = 0;
            decimal x = 0.0m;
            string b = "Holamundo";
            DateTime Fecha = DateTime.MinValue;
            Console.WriteLine("El numero es:{0}", a);
            Console.WriteLine("El valor de x es : {0:C}", x);

    */
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

        private void BtnNuevoTransporte_Click(object sender, EventArgs e)
        {

        }

        private void PanelBarra_Paint(object sender, PaintEventArgs e)
        {
            Console.WriteLine("Contadora de Varillas");
        }
    }
}
