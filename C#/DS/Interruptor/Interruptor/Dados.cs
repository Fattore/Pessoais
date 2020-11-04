using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interruptor
{
    class Dados
    {
        //definindo atributos
        public string fabricante = "Murilo";
        public bool estadoLamp;

        //criando método
        public bool acenderLamp()
        {
            if (estadoLamp == false)
            {
                estadoLamp = true;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool apagarLamp()
        {
            if (estadoLamp == true)
            {
                estadoLamp = false;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool verificaLamp()
        {
            return estadoLamp; //não precisa de nenhum if else
        }
    }
}
