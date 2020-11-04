using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jogo_velha
{
    public partial class frmMain : Form
    {
        bool v = true;//declarando variavel booleana

        public frmMain()
        {
            InitializeComponent();
        }

        private void grpTabuleiro_Enter(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnUm.Click += new EventHandler(BClick);//eventhandler = função que invoca eventos do computador, como click, press e etc
            btnDois.Click += new EventHandler(BClick);
            btnTres.Click += new EventHandler(BClick);
            btnQuatro.Click += new EventHandler(BClick);
            btnCinco.Click += new EventHandler(BClick);
            btnSeis.Click += new EventHandler(BClick);
            btnSete.Click += new EventHandler(BClick);
            btnOito.Click += new EventHandler(BClick);
            btnNove.Click += new EventHandler(BClick);

            foreach (Control item in this.Controls)
            {
                if (item is Button)
                {
                    item.TabStop = false;
                }
            }
        }

        private void BClick(object sender, EventArgs e)
        {
            //não consegui fazer, para que a imagem apareca e etc

            /*if (v == true)
            {
                btnUm.Image = System.Drawing.Image.FromFile(@"C:\Users\Etec\Desktop\Exercicio_07_05\Jogo_velha\Jogo_velha\Resources\X.png");
            }
            else if (v == false)
            {
                btnUm.Image = System.Drawing.Image.FromFile(@"C:\Users\Etec\Desktop\Exercicio_07_05\Jogo_velha\Jogo_velha\Resources\O.png");
            }*/

            ((Button)sender).Text = this.v ? "x" : "o";
            ((Button)sender).Enabled = false;

            VerificarGanhador();

            v = !v;
        }

        private void VerificarGanhador()
        {
            if (
                btnUm.Text != String.Empty && btnUm.Text == btnQuatro.Text && btnDois == btnSete ||
                btnDois.Text != String.Empty && btnDois.Text == btnCinco.Text && btnDois == btnOito ||
                btnTres.Text != String.Empty && btnTres.Text == btnSeis.Text && btnDois == btnNove ||

                btnUm.Text != String.Empty && btnUm.Text == btnDois.Text && btnDois == btnTres ||
                btnQuatro.Text != String.Empty && btnQuatro.Text == btnCinco.Text && btnCinco == btnSeis ||
                btnSete.Text != String.Empty && btnSete.Text == btnOito.Text && btnOito == btnNove ||

                btnUm.Text != String.Empty && btnUm.Text == btnCinco.Text && btnCinco == btnNove ||
                btnSete.Text != String.Empty && btnUm.Text == btnCinco.Text && btnCinco == btnTres
               )
            {
                MessageBox.Show(String.Format("O ganhador é o [{0}]", v ? "x" : "o"), "Temos um vençedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //nunca aparece um vencedor

                Reiniciar();
            }
            else
            {
                VerificarEmpate();
            }


        }

        private void VerificarEmpate()
        {
            bool d = true;

            foreach (Control item in this.Controls)//dentro do foreach irá executar o código em loop
            {
                if (item is Button && item.Enabled)
                {
                    d = false;
                    break;
                }
            }

            if (d)//se for a bool = d = true
            {
                MessageBox.Show(String.Format("Ocorreu um empate"), "Ops!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //messageboxbutton.OK = botão OK

                Reiniciar();
            }
        }

        private void Reiniciar()
        {
            foreach (Control item in this.Controls)
            {
                if (item is Button)
                {
                    item.Enabled = true;
                    item.Text = String.Empty;
                }
            }
        }
    }
}
