using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace operacoes_aritimeticas_ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double valorA, valorB, valorC, valorD, valorE, somaA, somaB, somaC;

            valorA = double.Parse(txtA.Text);
            valorB = double.Parse(txtB.Text);
            valorC = double.Parse(txtC.Text);
            valorD = double.Parse(txtD.Text);
            valorE = double.Parse(txtE.Text);

            somaA = (valorA + valorB) * valorC;
            somaB = (somaA) / 5;
            somaC = valorA - valorB * (valorC + valorD * valorD) / valorE;

            MessageBox.Show("O Resultado de A + B * C é: " + somaA);
            MessageBox.Show("O Resultado do calculo anterior / pela quantidade informada (5) é: " + somaB);
            MessageBox.Show("A – B(C+D²) /E é: " + somaC);


        }
    }
}
