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
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Usuarios dados = new Usuarios();

            //utilizando o streamwriter
            StreamWriter wr1 = new StreamWriter(@"D:\Programação\C#\DS\c#\Exercicio_Usuarios_P\usuarios.txt", true);

            dados.username = txtUsuarioCad.Text;
            dados.password = txtSenhaCad.Text;

            wr1.WriteLine(dados.username + ";" + dados.password);

            if (txtUsuarioCad.Text == "" || txtSenhaCad.Text == "")
            {
                MessageBox.Show("Informações faltando !!");
            }
            else
            {
                //fechando o streamwriter
                wr1.Close();

                MessageBox.Show("Contato Adicionado à Agenda !!");
                //limpando formulário
                txtUsuarioCad.Text = "";
                txtSenhaCad.Text = "";
            }
            this.Close();
            frmMain f1 = new frmMain();
            f1.Show();
        }
    }
}
