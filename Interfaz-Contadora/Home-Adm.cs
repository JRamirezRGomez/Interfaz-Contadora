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

        int PanelWidth;
        bool Hidden;
        public Form1()

        {
            InitializeComponent();
            PanelWidth = PanelSlide.Width;
            Hidden = false;
         
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
            //Pero que pasa
                
        }
        
        private void Slider_Tick(object sender, EventArgs e)
        {
            if (Hidden)
            {
                PanelSlide.Width = PanelSlide.Width + 30;
                if (PanelSlide.Width >= PanelWidth)
                {
                    Slider.Stop();
                    Hidden = false;
                    this.Refresh();

                }
            }
            else
            {
                PanelSlide.Width = PanelSlide.Width - 30;
                if (PanelSlide.Width <= 0)
                {
                    Slider.Stop();
                    Hidden = true;
                    this.Refresh();
                }
            }

        }
        
        private void BtnSlide_Click(object sender, EventArgs e)
        {
            Slider.Start();
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            //this.WindowState = FormWindowState.Normal;
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PanelSlide_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
