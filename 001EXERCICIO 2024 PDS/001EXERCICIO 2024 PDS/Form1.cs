using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _001EXERCICIO_2024_PDS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Cnpj = cnpj_lb.Text;
            string Razao = razaosozial_lb.Text;
            string NomeFantadia = nomefantasia_lb.Text;
            string NomePropietario = nomepro_tx.Text;
            string Situacao = situacao_cx.Text;
            string NaturezaJuridica = naturezajuridica_cb.Text;
            string Regime = "";
            string Telefone = telefone_masc.Text;
            string Capital = capitalsocial_mask.Text;
            string Endereco = enderecocompleto_cb.Text;
            string Data = data_date.Text;
            string cpf = cpf_mask.Text;
            string porte = "";
            string tipo = "";


            if (real_radion.Checked)
            {
                Regime = "Real";
            }
            else if (lucro_radionbt.Checked)
            {
                Regime = "Lucro";
            }
            else if (simplesnacional_radion.Checked)
            {
                Regime = "Simples";
            }

            if (pequeno_radion.Checked)
            {
                porte = "Pequeno";
            }
            else if (medio_radion.Checked)
            {
                porte = "Médio";
            }
            else if (grande_radion.Checked)
            {
                porte = "Grande";
            }

            if (matriz_radion.Checked)
            {
                tipo = "Matriz";
            }
            if (filiaj_radion.Checked)
            {
                tipo = "Filial";
            }


            MessageBox.Show($"{Cnpj} \n {Razao} \n {NomeFantadia} \n {NomePropietario} \n {Situacao} \n {NaturezaJuridica} \n {Regime} \n {Telefone} \n " +
                $"{Capital} \n {Endereco} \n {Data} \n {cpf} \n {porte} \n {tipo} ");
        }
    }
}
