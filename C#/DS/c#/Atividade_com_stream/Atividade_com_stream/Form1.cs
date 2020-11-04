using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Atividade_com_stream
{
    public partial class frmAgendaContato : Form
    {
        public frmAgendaContato()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddAgenda_Click(object sender, EventArgs e)
        {   //utilizando errorProvider para caso txt for igual a "" ou null
            if (txtNome.Text == "")
            {
                error1.SetError(txtNome, "Informe um nome");
            }

            if (txtEmail.Text == "")
            {
                error1.SetError(txtEmail, "Informe um email");
            }

            if (mskTelefone.Mask == "")
            {
                error1.SetError(mskTelefone, "Informe um telefone");
            }

                Dados dados = new Dados();
            //utilizando o streamwriter
                StreamWriter wr1 = new StreamWriter(@"C:\Users\Etec\Desktop\c#\contatos.txt", true);

                dados.nome = txtNome.Text;
                dados.email = txtEmail.Text;
                dados.telefone = mskTelefone.Text;

                wr1.WriteLine(dados.nome + ";" + dados.email + ";" + dados.telefone);

                if (txtNome.Text == "" || txtEmail.Text == "" || mskTelefone.Mask == "")
                {
                    MessageBox.Show("Informações faltando !!");
                }
                else
                {
                    //fechando o streamwriter
                    wr1.Close();

                    MessageBox.Show("Contato Adicionado à Agenda !!");
                    //limpando formulário
                    txtNome.Text = "";
                    txtEmail.Text = "";
                    mskTelefone.Text = "";
                }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Digite um email !!");
            }
            else
            {
                //instanciando o streamreader
                StreamReader rd1 = new StreamReader(@"C:\Users\Etec\Desktop\c#\contatos.txt");

                Boolean achou = false;

                while (!rd1.EndOfStream)
                {
                    string linha = rd1.ReadLine();
                    string[] quebra = linha.Split(';');

                    if (txtEmail.Text == quebra[1])
                    {
                        achou = true;
                        MessageBox.Show("Nome: " + quebra[0] + "\nE-Mail: " + quebra[1] + "\nTelefone: " + quebra[2]);
                        txtNome.Text = quebra[0];
                        txtEmail.Text = quebra[1];
                        mskTelefone.Text = quebra[2];
                    }
                }
                if (achou == false)
                {
                    MessageBox.Show("Contato não encontrado ou inexistente");
                }

                rd1.Close();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
//StreamWriter wr = new StreamWriter(@"C:\Users\Etec\Desktop\c#\arquivo.txt", true);primeiro intância e depois abre ou cria arquivo, usando o "true" para acrescentar e false para sobrescrever
//wr.Close(); fecha o streamwriter
//wr.WriteLine("texto texto texto"); será o texto salvo no streamwriter wr
//StreamReader rd = new StreamReader(@"C:\Users\Etec\Desktop\c#\arquivo.txt");
//split = quebra a string e transforma em vetor
//string[] words = string.Split(' ');
//while(!rd.EndOfStream){string linha = rd.ReadLine();} todo fim da stream vai ler e gravar as strings no txt