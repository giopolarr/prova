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
                double dinheiro = 0.2;
                double pix = 0.1;
                double cartao = 0;


                if (cb_serviços.Text == "formatação")
                {
                  double resultado1 = dinheiro - (100 * dinheiro);
                    lb_resultado.Text = Convert.ToString(resultado1);
                }
                if ( formatacao == pix)
                {
                    pix = 0.10 - (100 * 0.10);
                }
                else if (formatacao == cartao)
                {
                   
                }



                lb_resultado.Text = "sdfas";
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
            cb_serviços.Items.Clear();
        }
    }
}
