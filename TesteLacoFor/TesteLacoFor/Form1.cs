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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CboAno_SelectedIndexChanged(object sender, EventArgs e)
        {
         

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // Teste de Laço for
            // Jonas Valereo Técnico em Inromática 


            //Declarando o codigo laço for no form1 

            int contador;
            for (contador = 2016; contador >= 1950; contador--)
            {
                CboAno.Items.Add(contador);
            }
            
            //Fim do programa 
        }

        private void BtnAvanca_Click(object sender, EventArgs e)
        {

            //Declarando o comando objeto novo do form atraves do metodo show
            Form2 novo = new Form2();
            novo.Show();
            //Declarando o fechamento do form1 
            this.Visible = false;

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            //Declarando o comando fechar

            Close();
        }

    }
}
