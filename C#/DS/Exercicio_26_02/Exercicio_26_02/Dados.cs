using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Exercicio_26_02
{
    class Dados
    {   //definindo strings
        public string id;
        public string nome;
        public string sexo;
        public string rg;
        public string cpf;
        public string telresid;
        public string cep;
        public string rua;
        public string nr;
        public string bairro;
        public string cidade;
        public string email;
        public string face;
        public string twitter;
        public string caminhoImagem;

        public void Registra(string caminho)
        {
            if (!File.Exists(caminho))
            {
                using (StreamWriter sw = File.CreateText(caminho + @"\" + id + ".txt")) // Cria arquivo
                {
                    sw.WriteLine("A = " + nome); // Escreve no arquivo
                    sw.WriteLine("B = " + sexo); // Mesma coisa
                    sw.WriteLine("C = " + rg); // Aqui Tambem
                    sw.WriteLine("D = " + cpf); // Preciso falar mesmo?
                    sw.WriteLine("E = " + telresid); // O comando é o mesmo, é so ler
                    sw.WriteLine("F = " + cep); // ????
                    sw.WriteLine("G = " + rua); // Para de ler isso
                    sw.WriteLine("H = " + nr); // Nao vou falar mais
                    sw.WriteLine("I = " + bairro); // Beleza, voce chegou ao nivel Levi de irritação
                    sw.WriteLine("J = " + cidade); // Vou chamar o samael
                    sw.WriteLine("K = " + email); // O yg ficou puto com voce agora
                    sw.WriteLine("L = " + face); // vai estudar !!
                    sw.WriteLine("M = " + twitter); // aaaaaa
                    sw.WriteLine("N = " + caminhoImagem); // To fora *se demite*
                }
            }
            MessageBox.Show("Arquivo Salvo em " + caminho + @"\" + id + ".txt");
        }

        public void LimpaCampos(Control.ControlCollection controles)
        {
            foreach (Control item in controles)
            {
                if (item.GetType() == typeof(TextBox) && item.GetType() == typeof(MaskedTextBox))
                {
                    item.Text = string.Empty; //limpa todos os controles do tipo TextBox
                    // anotação ---- por algum motivo não está funcionando mais !
                }
            }
        }


    }
}
