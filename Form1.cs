using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textTotalCompra.Enabled = false;
            textTotalFinal.Enabled = false;
            textDesconto.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int quantidade;
            double valor_unitario;

            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string nomeProduto;
            int quantidade;
            double valorUnitario, totalCompra, desconto,totalFinal;
            nomeProduto = textNomeProduto.Text;

            quantidade = Convert.ToInt32(textQuantidade.Text);
            valorUnitario = Convert.ToDouble(textValorUnitario.Text);

            totalCompra = quantidade * valorUnitario;


            if (quantidade <= 5)
            {
                desconto = totalCompra * 0.02;
                textDesconto.Text = desconto.ToString();
                totalFinal = totalCompra - desconto;
            }
            else
            {
                desconto = 0;
                textDesconto.Text = desconto.ToString();
                totalFinal = totalCompra - desconto;
            }

            

            textTotalCompra.Text = totalCompra.ToString();
            textTotalFinal.Text = totalFinal.ToString();
            
            
        }
    }
}
