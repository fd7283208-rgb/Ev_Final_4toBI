using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ev_Final_4toBI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnProducto_Click(object sender, EventArgs e)
        {
            int Num1 = int.Parse(TextVar1.Text);
            int Num2 = int.Parse(TextVar2.Text);
            int producto = Num1 * Num2;
            MessageBox.Show("el resultado del peoducto es" + producto);
        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            int Num1 = int.Parse(TextVar1.Text);
            int Num2 = int.Parse(TextVar2.Text);
            int suma = Num1 + Num2;
            MessageBox.Show("El Resultado de la suma es " + suma);
        }

        private void BtnPotencia_Click(object sender, EventArgs e)
        {
            int Num1 = int.Parse(TextVar1.Text);
            int Num2 = int.Parse(TextVar2.Text);
            int Num3 = 1;
            int Potencia = 1;

            while (Num3 != Num2)
            {
                Potencia = Potencia * Num1;
                Num3++;
            }
                MessageBox.Show("El Resultado de la Potencia es " + Potencia);
        }

        private void BtnDivicion_Click(object sender, EventArgs e)
        {
            float Num1 = float.Parse(TextVar1.Text);
            float Num2 = float.Parse(TextVar2.Text);
            if (Num2 > 0)
            {
                float division = Num1 / Num2;
                MessageBox.Show("el resultado es" + division);
            }
            else
            {
                MessageBox.Show("la division es definitiva");
            }
        }
    }
}

