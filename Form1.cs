using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula07Funcoes
{
    public partial class Form1 : Form
    {

        // variaveis globais
        public Form1()
        {
            InitializeComponent();
        }

        // Minhas funções

        double conversao(Label dimdim )
        {
            double dinheiro = double.Parse(dimdim.Text);
            return (dinheiro);

        }




        void MostraMensagem()
        {
            MessageBox.Show("Ola mariline , a noite tainha , vinho e muito....");
            MessageBox.Show("Também , to cagado de fome");




        }
        void Morri()
        {
            string nome = txt_Main.Text;
            MessageBox.Show($"Ola {nome}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click_Click(object sender, EventArgs e)
        {
            Morri();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostraMensagem();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double valor;
            valor = double.Parse(txt_Valor.Text);
            double dinheiro = conversao(lbl_Valor);
            double soma = valor + dinheiro;
            lbl_Valor.Text = $"{soma}";


        }

        private void button3_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(textBox2.Text);
            double dinheiro = conversao(lbl_valor2);
            double soma = valor + dinheiro;
            lbl_valor2.Text = $"{soma}";
        }
    }

}


