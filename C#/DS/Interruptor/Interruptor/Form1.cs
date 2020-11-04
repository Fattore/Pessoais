using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Interruptor
{
    public partial class FrmMain : Form
    {
        Dados infos = new Dados(); //instânciando
        public FrmMain()
        {     
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picImg.ImageLocation = @"C:\Users\Etec\Desktop\Atividade C# Murilo\apagada.jpg"; 
            //inicia o programa com a lamp apagada
            lblNone.Text = infos.fabricante;
            //inicia o programa com o nome do fabricante, escrito na classe Dados
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            if (infos.acenderLamp() == true)
            {
                picImg.ImageLocation = @"C:\Users\Etec\Desktop\Atividade C# Murilo\acessa.jpg";
                txtMsg.Text = "A Lâmpada foi acessa !!!";
                //importar imagem para pasta resource, para nuncar dar o erro de destino
                //picImg.Image=Interruptor.Properties.Resources.imagem.txt
                //acende lampada
            }
            else
            {
                txtMsg.Text = "A Lâmpada já está acessa !!!";
            }
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            if (infos.apagarLamp() == true)
            {
                picImg.ImageLocation = @"C:\Users\Etec\Desktop\Atividade C# Murilo\apagada.jpg";
                txtMsg.Text = "A Lâmpada foi apagada !!!";
                //importar imagem para pasta resource, para nuncar dar o erro de destino
                //picImg.Image=Interruptor.Properties.Resources.imagem.txt
                //apaga lampada
            }
            else
            {
                txtMsg.Text = "A Lâmpada já está apagada !!!";
            }

        }

        private void btnStatus_Click(object sender, EventArgs e)
        {

            if (infos.verificaLamp())
            {
                txtMsg.Text = "A Lâmpada está acessa !!!";
            }
            else
            {
                txtMsg.Text = "A Lâmpada está apagada !!!";
            }
        }

    }
}
