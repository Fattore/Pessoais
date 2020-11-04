using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Exercicio_Usuarios
{
    class Usuarios
    {
        public string username;
        public string password;
        public string name;
    }
}
//StreamWriter wr = new StreamWriter(@"C:\Users\Etec\Desktop\c#\arquivo.txt", true);primeiro intância e depois abre ou cria arquivo, usando o "true" para acrescentar e false para sobrescrever
//wr.Close(); fecha o streamwriter
//wr.WriteLine("texto texto texto"); será o texto salvo no streamwriter wr
//StreamReader rd = new StreamReader(@"C:\Users\Etec\Desktop\c#\arquivo.txt");
//split = quebra a string e transforma em vetor
//string[] words = string.Split(' ');
//while(!rd.EndOfStream){string linha = rd.ReadLine();} todo fim da stream vai ler e gravar as strings no txt