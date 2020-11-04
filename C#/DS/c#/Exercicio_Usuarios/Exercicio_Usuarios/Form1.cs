using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Exercicio_Usuarios
{
    public partial class frmMain : System.Windows.Forms.Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Usuarios dados = new Usuarios();

            //utilizando o streamwriter
            StreamWriter wr1 = new StreamWriter(@"C:\Users\Etec\Desktop\c#\Exercicio_Usuarios\logins.txt", true);

            dados.username = txtUsuario.Text;
            dados.password = txtSenha.Text;

            wr1.WriteLine(dados.username + ";" + dados.password);

            if (txtUsuario.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Informações faltando !!");
            }
            else
            {
                //fechando o streamwriter
                wr1.Close();

                MessageBox.Show("Contato Adicionado à Agenda !!");
                //limpando formulário
                txtUsuario.Text = "";
                txtSenha.Text = "";
            }

            StreamReader sr1 = new StreamReader(@"C:\Users\Etec\Desktop\c#\Exercicio_Usuarios\logins.txt");//caminho do seu arquivo txt

            while (!sr1.EndOfStream)
            {
                string linha = sr1.ReadLine();
                string[] quebra = linha.Split(';');
                //dados.username = sr1.ReadLine();//vai ler a primeira linha onde está o usuario
                //dados.password = sr1.ReadLine(); //vai ler a segunda linha onde está a senha

                if ((dados.username == quebra[0]) && (dados.password == quebra[1]))
                {
                    MessageBox.Show("Seja Bem-Vindo " + dados.username);
                }
                else
                {
                    Console.WriteLine("usuario e senha invalidos");
                }
                
            }
            sr1.Close();
        }

        private void lnkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmForgot f2 = new frmForgot();
            f2.Show();
            lnkForgot.LinkVisited = true;
        }

        private void chkLembrar_CheckedChanged(object sender, EventArgs e)
        {
            //não programado !!
        }
    }
}
