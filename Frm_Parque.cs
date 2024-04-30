using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividadeParquinho
{
    public partial class Frm_Parque : Form
    {
        string nome;
        double altura;
        int idade, contagem1, contagem2, contagem3, contagem4;

        public Frm_Parque()
        {
            InitializeComponent();
        }

        private void Frm_Parque_Load(object sender, EventArgs e)
        {

        }

        private void txt_Nome_TextChanged(object sender, EventArgs e)
        {
            nome = txt_Nome.Text;
        }

        private void txt_Altura_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Lista_Click(object sender, EventArgs e)
        {
            
            const string message = "Você clicou em nova lista, tem certeza?";
            const string caption = "Atenção!";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (result == DialogResult.No)
            {
                return;
            }

            else if (rdb_Minhocao.Checked)
            {
                lst_Minhocao.Items.Clear();
                lbl_Valor1.Text = string.Empty;

                return;
            }
            else if (rdb_Roda.Checked)
            {
                lst_Roda.Items.Clear();
                lbl_Valor2.Text = string.Empty;
                return;
            }
            else if (rdb_Carrosel.Checked)
            {
                lst_Carrosel.Items.Clear();
                lbl_Valor3.Text = string.Empty;
                return;
            }
            else if (rdb_Montanha.Checked)
            {
                lst_Montanha.Items.Clear();
                lbl_Valor4.Text = string.Empty;
                return;
            }
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {


        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            const string message = "Você clicou em limpar tudo, tem certeza?";
            const string caption = "Atenção!";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (result == DialogResult.No)
            {
                return;
            }
            else
            {

                txt_Nome.Text = string.Empty;
                txt_Altura.Text = string.Empty;
                cmb_Idade.Text = string.Empty;
                rdb_Minhocao.Checked = false;
                rdb_Roda.Checked = false;
                rdb_Carrosel.Checked = false;
                rdb_Montanha.Checked = false;
                lst_Carrosel.Items.Clear();
                lst_Minhocao.Items.Clear();
                lst_Roda.Items.Clear();
                lst_Montanha.Items.Clear();
                lbl_Valor1.Text = string.Empty;
                lbl_Valor2.Text = string.Empty;
                lbl_Valor3.Text = string.Empty;
                lbl_Valor4.Text = string.Empty;
            }
        }

        private void cmb_Idade_SelectedIndexChanged(object sender, EventArgs e)
        {
            idade = Int32.Parse(cmb_Idade.Text);
        }

        private void lbl_Valor1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Incluir_Click(object sender, EventArgs e)
        {

            altura = double.Parse(txt_Altura.Text);

            contagem1 = lst_Minhocao.Items.Count;
            contagem2 = lst_Roda.Items.Count;
            contagem3 = lst_Carrosel.Items.Count;
            contagem4 = lst_Montanha.Items.Count;

            if (txt_Nome.Text == string.Empty || txt_Altura.Text == string.Empty || cmb_Idade.Text == string.Empty)
            {
                MessageBox.Show("Você não prencheu todos os campos!");
                return;
            }


            if (rdb_Minhocao.Checked == false && rdb_Roda.Checked == false && rdb_Carrosel.Checked == false && rdb_Montanha.Checked == false)
            {
                MessageBox.Show("Você não selecionou o brinquedo!");
                return;
            }



            if (rdb_Minhocao.Checked == true && idade == +12 || rdb_Carrosel.Checked == true && idade == +12)
            {
                MessageBox.Show("A criança é muito velha para o brinquedo!");
                return;
            }
            if (idade == -6 || rdb_Montanha.Checked == true && idade != +12)
            {
                MessageBox.Show("A criança não tem idade para entrar nesse brinquedo!");
                return;
            }
            if (altura < 1 || rdb_Roda.Checked == true && altura <= 1.3)
            {
                MessageBox.Show("A criança não tem altura para esse brinquedo");
                return;
            }
            if (rdb_Minhocao.Checked == true && altura >= 1.5 || rdb_Carrosel.Checked == true && altura >= 1.5)
            {
                MessageBox.Show("A criança é alta demais para esse brinquedo");
                return;
            }
            if (lst_Minhocao.Items.Count == 12)
            {
                MessageBox.Show("Esse brinquedo já está lotado, por favor escolha outro!");
                return;

            }
            if (lst_Roda.Items.Count == 26)
            {
                MessageBox.Show("Esse brinquedo já está lotado, por favor escolha outro!");
                return;

            }
            if (lst_Carrosel.Items.Count == 16)
            {
                MessageBox.Show("Esse brinquedo já está lotado, por favor escolha outro!");
                return;

            }
            if (lst_Montanha.Items.Count == 20)
            {
                MessageBox.Show("Esse brinquedo já está lotado, por favor escolha outro!");
                return;

            }

            else
            {
                if (rdb_Minhocao.Checked == true)
                {

                    lst_Minhocao.Items.Add(nome);
                    contagem1 = contagem1 + 1;


                }


                if (rdb_Roda.Checked == true)
                {
                    lst_Roda.Items.Add(nome);
                    contagem2 = contagem2 + 1;
                }

                if (rdb_Carrosel.Checked == true)
                {
                    lst_Carrosel.Items.Add(nome);
                    contagem3 = contagem3 + 1;
                }


                if (rdb_Montanha.Checked == true)
                {
                    lst_Montanha.Items.Add(nome);
                    contagem4 = contagem4 + 1;
                }




                lbl_Valor1.Text = contagem1.ToString();
                lbl_Valor2.Text = contagem2.ToString();
                lbl_Valor3.Text = contagem3.ToString();
                lbl_Valor4.Text = contagem4.ToString();
            }
        }

    }
}







            


        

    


        
       
    

