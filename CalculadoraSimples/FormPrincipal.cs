using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraSimples
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbresultado_Click(object sender, EventArgs e)
        {

        }

        private void lbresultado_Click_1(object sender, EventArgs e)
        {
            

        }

        private void btsoma_Click(object sender, EventArgs e)
        {
            string va, vb;
            double vaD, vbD;
            va = txtValorA.Text;
            vb = txtValorB.Text;



            try
            {
                vaD = double.Parse(va);
                vbD = double.Parse(vb);
                lbresultado.Text = (vaD + vbD).ToString();
                

            }
            catch (Exception ex)
            {
                lbresultado.Text = "Nao foi digitado numeros em um dos campos";

            }
        }

        private void btsubtracao_Click(object sender, EventArgs e)
        {
            string va, vb;
            double vaD, vbD;
            va = txtValorA.Text;
            vb = txtValorB.Text;



            try
            {
                vaD = double.Parse(va);
                vbD = double.Parse(vb);
                lbresultado.Text = (vaD - vbD).ToString();

            }
            catch (Exception ex)
            {
                lbresultado.Text = "Nao foi digitado numeros em um dos campos";

            }
        }

        private void btmultiplicacao_Click(object sender, EventArgs e)
        {
            string va, vb;
            double vaD, vbD;
            va = txtValorA.Text;
            vb = txtValorB.Text;



            try
            {
                vaD = double.Parse(va);
                vbD = double.Parse(vb);
                lbresultado.Text = (vaD * vbD).ToString();
                

            }
            catch (Exception ex)
            {
                lbresultado.Text = "Nao foi digitado numeros em um dos campos";

            }
        }

        private void btdivisao_Click(object sender, EventArgs e)
        {
            string va, vb;
            double vaD, vbD;
            va = txtValorA.Text;
            vb = txtValorB.Text;



            try
            {
                vaD = double.Parse(va);
                vbD = double.Parse(vb);
               
                lbresultado.Text = (vaD / vbD).ToString();
               

            }
            catch (Exception ex)
            {
                lbresultado.Text = "Nao foi digitado numeros em um dos campos, ou foi digitado 0";  

            }
        }

        private void btlimpar_Click(object sender, EventArgs e)
        {
            txtValorA.Clear();
            txtValorB.Clear();
            lbresultado.Text = "---";

            }
    }
}
