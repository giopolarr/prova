using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova2Bimestre
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            lb_resultado.Text = "";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                int formatacao = 100;
                int limpeza = 50;
                int troca_peca = 200;
                double dinheiro = 0.20;
                double pix = 0.1;
                double cartao = 0;
                double resultado1 = 100 - (dinheiro / 100);
                double resultado2 = 0.10 - (100 * 0.10);


                if (cb_servicos.Text == "formatação" && cb_pagamento.Text == "dinheiro")
                {
                  resultado1 = 100 - (dinheiro / 100);
                    
                }
                else if (cb_servicos.Text == "formatação" && cb_pagamento.Text == "pix")
                {
                     resultado2 = 100 - (pix / 100);
                }

                lb_resultado.Text = (Convert.ToString(resultado1));
                

                if(cb_servicos.Text == "limpeza" && cb_pagamento.Text == "dinheiro")
                {
                    double resultado3 = dinheiro = (dinheiro * 50);
                    lb_resultado.Text = (Convert.ToString(resultado3));
                }
                else if(cb_servicos.Text == "limpeza" && cb_pagamento.Text == "pix")
                {
                    double resultado4 = pix = (pix * 50);
                    lb_resultado.Text = (Convert.ToString(resultado4));

                }

                if (cb_servicos.Text == "troca de peças" && cb_pagamento.Text == "dinheiro")
                {
                    double resultado5 = (dinheiro / 200) - dinheiro;
                }
                else if (cb_servicos.Text == "troca de peças" && cb_pagamento.Text == "pix") ;
                {

                }

            }
            catch 
            
            { 
            
            }


            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tx_box1.Clear();
            tx_box2.Clear();
            cb_pagamento.Items.Clear();
            cb_servicos.Items.Clear();
        }
    }
}
