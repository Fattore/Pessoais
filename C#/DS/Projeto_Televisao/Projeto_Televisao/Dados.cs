using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projeto_Televisao
{
    class Dados
    {
        //vaiaveis publicas
        public string marca;
        public string tipo;
        public int volume = 0;
        public int canal = 0;
        public bool estado = false;

        //metodos
        public bool ligarTV()
        {
            if(estado == false)
            {
                estado = true;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool desligarTV()
        {
            if(estado == true)
            {
                estado = false;
                return true;
            }
            else
            {
                return false;
            }
        }

        public int aumentarVol()
        {
            volume++;
            if (volume >= 100)
            {
                volume = 100;
            }
            return volume;
        }
        public int diminuirVol()
        {
            volume=volume-1;
            if (volume <= 0)
            {
                volume = 0;
            }
            return volume;
        }
        public int avancarCanal()
        {
            canal++;
             if (canal == 51)
             {
                 canal = 1;
             }
            return canal;
        }
        public int retrocederCanal()
        {
            canal=canal-1;
            if (canal == 0)
            {
                canal = 50;
            }
            return canal;
        }
        
    }
}
