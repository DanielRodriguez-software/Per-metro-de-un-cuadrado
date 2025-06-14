using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perimetro_de_un_cuadrado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblError.Text= "";
        }

        private void txtLado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPerimetro_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnResolver_Click(object sender, EventArgs e)
        {
            double lado, perimetro;
            if (double.TryParse(txtLado.Text,out lado))
            {
                if (lado<=0) 
                {
                    lblError.Text = "Esto no es posible\nIngrese un dato numerico valido";
                    txtPerimetro.Text=string.Empty;
                   
                }
                else
                {
                    perimetro = lado * 4;
                    txtPerimetro.Text = perimetro.ToString("N2");
                    lblError.Text = "";
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPerimetro.Text=string.Empty;
            txtLado.Text=string.Empty; 
            lblError.Text=string.Empty;
        }
    }
}
