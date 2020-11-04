using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculo_IMC
{
    public partial class frmIMC : Form
    {
        public frmIMC()
        {
            InitializeComponent();
        }

        private void frmIMC_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
                Double vtotal = 0, vAltura = 0, vPeso = 0;

                vAltura = double.Parse(txtAltura.Text);
                vPeso = double.Parse(txtPeso.Text);

                vtotal = vPeso / (vAltura * vAltura);

                //lblMostrarIMC.Text = String.Format("{0:N2}", vtotal); //deixar apenas duas casas decimais após a virgula
                //lblMostrarIMC.Text = lblIMCCal + vtotal.ToString("##,00"); //deixar apenas duas casas decimais após a virgula

                if (vtotal < 17)

                    lblMostraSitu.Text = "Muito abaixo do peso";

                else if (vtotal < 18.49)

                    lblMostraSitu.Text = "Abaixo do peso";

                else if (vtotal < 24.99)

                    lblMostraSitu.Text = "Peso normal";

                else if (vtotal < 29.99)

                    lblMostraSitu.Text = "Sobrepeso, cuidado !";

                else if (vtotal < 34.99)

                    lblMostraSitu.Text = "Obesidade I";

                else if (vtotal < 39.99)

                    lblMostraSitu.Text = "Obesidade II";

                else if (vtotal > 39.99)

                    lblMostraSitu.Text = "Obesidade III";


                lblMostrarIMC.Text = vtotal.ToString();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Text = "";
            txtPeso.Text = "";
            cmbSexo.Text = "";

            lblMostrarIMC.Text = "";
            lblMostraSitu.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmIMC_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult testeDialog = MessageBox.Show("Você tem certeza que deseja encerrar o programa?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (testeDialog == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else if (testeDialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void txtPeso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAltura.Focus(); //faz com que ao clicar no botão Enter com o código Keys.Enter, foque o proximo textbox
            }
        }

        private void txtAltura_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbSexo.Focus();
            }
        }

        private void cmbSexo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCalcular.Focus();
            }
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar)&& e.KeyChar!=(char)8 &&e.KeyChar!=(char)44)
            {
                e.Handled = true;
            }
        }
    }
}
