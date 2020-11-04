using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Pessoa
    {
        //atributos da pessoa

        public string name;
        public string gender;
        public int age;
        public double height;

        //assinar o método andar
        //void não retorna nada

        public string toWalk()
        {
            return "Now the people is walking . . .";
        }
    }
}
