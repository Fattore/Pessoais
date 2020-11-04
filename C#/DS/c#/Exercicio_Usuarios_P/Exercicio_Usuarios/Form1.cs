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
        //declarando o objeto como public
        StreamReader sr1;
        private void frmMain_Load(object sender, EventArgs e)
        {
            //ler arquivo
            sr1 = new StreamReader(@"D:\Programação\C#\DS\c#\Exercicio_Usuarios_P\usuarios.txt");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Usuarios dados = new Usuarios();

            //utilizando o streamwriter
            //prof diferente = StreamWriter wr1 = new StreamWriter(@"C:\Users\Etec\Desktop\c#\Exercicio_Usuarios_P\usuarios.txt", true);

            dados.username = txtUsuario.Text;
            dados.password = txtSenha.Text;

            //prof diferente = wr1.WriteLine(dados.username + ";" + dados.password);

            if (txtUsuario.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Informações faltando !!");
            }

            bool achou=false;

            while (!sr1.EndOfStream)
            {
                string linha = sr1.ReadLine();
                string[] quebra = linha.Split(';');
                //dados.username = sr1.ReadLine();//vai ler a primeira linha onde está o usuario
                //dados.password = sr1.ReadLine(); //vai ler a segunda linha onde está a senha

                if (dados.username == quebra[0] && dados.password == quebra[1])
                {
                    achou = true;
                    break;//para o while
                    
                }
                
            }

            if (achou == false)
            {
                Console.WriteLine("usuario ou senha incorreto");
            }
            else
            {
                MessageBox.Show("Seja Bem-Vindo " + dados.username);
                frmPrincipal f3 = new frmPrincipal();
                f3.ShowDialog();
                //this.Close(); //fehca o form atual
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastro f4 = new frmCadastro();
            f4.ShowDialog();
        }
    }
}
