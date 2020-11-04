using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projeto_Televisao
{
    public partial class FrmTV : Form
    {
        Dados powpow = new Dados(); //instânciando
        public FrmTV()
        {
            InitializeComponent();
        }

        private void btnCanalUP_Click(object sender, EventArgs e)
        {
            powpow.avancarCanal();
            //colocando as imagens de canais nos números especificos
            if (powpow.canal == 1)
            {
                picImgTV.Image = Projeto_Televisao.Properties.Resources.globo;
            }
            else if (powpow.canal == 2)
            {
                picImgTV.Image = Projeto_Televisao.Properties.Resources.history;
            }
            else if (powpow.canal == 8)
            {
                picImgTV.Image = Projeto_Televisao.Properties.Resources.discovery;
            }
            else if (powpow.canal == 26)
            {
                picImgTV.Image = Projeto_Televisao.Properties.Resources.animal;
            }
            else if (powpow.canal == 16)
            {
                picImgTV.Image = Projeto_Televisao.Properties.Resources.cartoon;
            }
            else if (powpow.canal == 38)
            {
                picImgTV.Image = Projeto_Televisao.Properties.Resources.bob_esponja_tv;
            }
            else if (powpow.canal == 31)
            {
                picImgTV.Image = Projeto_Televisao.Properties.Resources.narutinho;
            }
            else if (powpow.canal == 50)
            {
                picImgTV.Image = Projeto_Televisao.Properties.Resources.xxx;
            }
            else if (powpow.canal == 13)
            {
                picImgTV.Image = Projeto_Televisao.Properties.Resources.ss;
            }
            else if (powpow.canal == 44)
            {
                picImgTV.Image = Projeto_Televisao.Properties.Resources.neterror;
            }
            else
            {
                picImgTV.Image = Projeto_Televisao.Properties.Resources.YSBwR6__1_;
            }
            txtCanalMsg.Text = powpow.canal.ToString();
        }

        private void btnCanalD_Click(object sender, EventArgs e)
        {
            powpow.retrocederCanal();
            //colocando as imagens de canais nos números especificos
            if (powpow.canal == 1)
            {
                picImgTV.Image = Projeto_Televisao.Properties.Resources.globo;
            }
            else if (powpow.canal == 2)
            {
                picImgTV.Image = Projeto_Televisao.Properties.Resources.history;
            }
            else if (powpow.canal == 8)
            {
                picImgTV.Image = Projeto_Televisao.Properties.Resources.discovery;
            }
            else if (powpow.canal == 26)
            {
                picImgTV.Image = Projeto_Televisao.Properties.Resources.animal;
            }
            else if (powpow.canal == 16)
            {
                picImgTV.Image = Projeto_Televisao.Properties.Resources.cartoon;
            }
            else if (powpow.canal == 38)
            {
                picImgTV.Image = Projeto_Televisao.Properties.Resources.bob_esponja_tv;
            }
            else if (powpow.canal == 31)
            {
                picImgTV.Image = Projeto_Televisao.Properties.Resources.narutinho;
            }
            else if (powpow.canal == 50)
            {
                picImgTV.Image = Projeto_Televisao.Properties.Resources.xxx;
            }
            else if (powpow.canal == 13)
            {
                picImgTV.Image = Projeto_Televisao.Properties.Resources.ss;
            }
            else if (powpow.canal == 44)
            {
                picImgTV.Image = Projeto_Televisao.Properties.Resources.neterror;
            }
            else
            {
                picImgTV.Image = Projeto_Televisao.Properties.Resources.YSBwR6__1_;
            }
            txtCanalMsg.Text = powpow.canal.ToString();
        }

        private void btnVolUP_Click(object sender, EventArgs e)
        {
            powpow.aumentarVol();
            if (powpow.volume == 100)
            {
                MessageBox.Show("O volume já está no maximo, tente abaixar");
            }
            txtVolMsg.Text = powpow.volume.ToString();
        }

        private void btnVolD_Click(object sender, EventArgs e)
        {
            powpow.diminuirVol();
            if (powpow.volume == 0)
            {
                MessageBox.Show("O volume já está no mínimo, tente aumentar");
            }
            txtVolMsg.Text = powpow.volume.ToString();
        }

        private void picControlePower_Click(object sender, EventArgs e)
        {
                picImgTV.Image = Projeto_Televisao.Properties.Resources.globo;
                picPower.Image = Projeto_Televisao.Properties.Resources.Blue_button;
                if (powpow.canal == 0)
                {
                    powpow.canal = 1;
                    txtCanalMsg.Text = powpow.canal.ToString();
                }
                if (powpow.volume == 0)
                {
                    powpow.volume = 5;
                    txtVolMsg.Text = powpow.volume.ToString();
                }
        }

        private void picControlePower_DoubleClick(object sender, EventArgs e)
        {
            picImgTV.Image = Projeto_Televisao.Properties.Resources.download;
            picPower.Image = Projeto_Televisao.Properties.Resources.Pillbuttonred_clip_art_hight;
        }

    }
}
