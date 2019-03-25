using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteLacoFor
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Teste de Laço while 
            // Jonas Valereo Técnico em Inromática 


            //Declarando o codigo while for no form2

            int contador;
            contador = 2016;

            while ( contador >= 1950)
            {
                CboAno.Items.Add(contador);
                contador--;

            }

            // fim do programa
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            //Declarando o comando objeto novo do form2 atraves do metodo show
            Form1 novo = new Form1();
            novo.Show();
            //Declarando o fechamento do form2
            this.Visible = false;

        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            //Declarando o codigo fechar

            Close();

        }
    }
}
