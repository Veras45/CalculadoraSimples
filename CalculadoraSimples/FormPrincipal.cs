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

        private void lbresultado_Click_1(object sender, EventArgs e)
        {


        }
        private void btOperacao_Click(object sender, EventArgs e)
        {
            try
            {

                Button bt = (Button)sender;
                string va, vb;

                va = txtValorA.Text;
                vb = txtValorB.Text;

                matematica mat = new matematica(va, vb);

                switch (bt.Name)
                {
                    case "btsoma":
                        lbresultado.Text = mat.soma().ToString();
                        break;
                    case "btsubtracao":
                        lbresultado.Text = mat.subtracao().ToString();
                        break;
                    case "btmultiplicacao":
                        lbresultado.Text = mat.multiplicacao().ToString();
                        break;
                    case "btdivisao":
                        lbresultado.Text = mat.divisao().ToString();
                        break;
                }
            }
            catch(Exception ex)
            {
                lbresultado.Text = ex.Message;
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
