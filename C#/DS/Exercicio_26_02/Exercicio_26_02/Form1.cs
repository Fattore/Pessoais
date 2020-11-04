using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO; //chamado para a execução de streamWriter/Reader e etc

namespace Exercicio_26_02
{
    public partial class frmPrincipal : Form
    {
        // variaveis para consulta -----------------
        public string codigoPuxar;
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
        // -----------------------------------------
        public frmPrincipal()
        {
            InitializeComponent();
            Random rnd = new Random();//gera números randônicos para o autoincrement
            txtCodigo.Text = rnd.Next(100, 999).ToString();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            txtEmail.Enabled = false;
            txtFacebook.Enabled = false;
            txtTwitter.Enabled = false;
        }

        private bool ValidarRegistro()
        {
            /*
             * verifica campo a campo para checar se algum está vazio.
             * caso vazio, ErrorProvider(errValida) é chamado, para indicar o erro ao usuário.
             */
            if (txtNome.Text == "")
            {
                errValida.SetError(txtNome, "Campo Vazio");
                return false;
            }
            if (txtRG.Mask == "")
            {
                errValida.SetError(txtRG, "Campo Vazio");
                return false;
            }
            if (txtCPF.Mask == "")
            {
                errValida.SetError(txtCPF, "Campo Vazio");
                return false;
            }
            if (txtTR.Mask == "")
            {
                errValida.SetError(txtTR, "Campo Vazio");
                return false;
            }
            if (!radMasculino.Checked && !radFeminino.Checked && !radIndefinido.Checked)
            {
                errValida.SetError(groupBox4, "Campo Vazio");
                return false;
            }
            if (txtCEP.TextLength == 0)
            {
                errValida.SetError(txtCEP, "Campo Vazio");
                return false;
            }
            if (txtRua.Text == "")
            {
                errValida.SetError(txtRua, "Campo Vazio");
                return false;
            }
            if (txtNr.Text == "")
            {
                errValida.SetError(txtNr, "Campo Vazio");
                return false;
            }
            if (txtBairro.Text == "")
            {
                errValida.SetError(txtBairro, "Campo Vazio");
                return false;
            }
            if (txtCidade.Text == "")
            {
                errValida.SetError(txtCidade, "Campo Vazio");
                return false;
            }
            if (chkEmail.Checked == true && txtEmail.Text == "")
            {
                errValida.SetError(txtEmail, "Campo Vazio");
                return false;
            }
            if (chkFacebook.Checked == true && txtFacebook.Text == "")
            {
                errValida.SetError(txtFacebook, "Campo Vazio");
                return false;
            }
            if (chkTwitter.Checked == true && txtTwitter.Text == "")
            {
                errValida.SetError(txtTwitter, "Campo Vazio");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            errValida.Clear(); // limpa os erros
            if (ValidarRegistro()) // executa a verificação, caso return = true, code.continue();
            {
                //dados pessoais ---

                Dados dadinho = new Dados();

                dadinho.id = txtCodigo.Text; //autoincrement
                dadinho.nome = txtNome.Text;
                dadinho.rg = txtRG.Text;
                dadinho.cpf = txtCPF.Text;
                dadinho.telresid = txtTR.Text;

                ////gravando sexo em rádio

                if (radMasculino.Checked == true)
                {
                    dadinho.sexo = "Homem";
                }
                else if (radFeminino.Checked == true)
                {
                    dadinho.sexo = "Mulher";
                }
                else if (radIndefinido.Checked == true)
                {
                    dadinho.sexo = "Indefinido";
                }

                //endereço ---

                dadinho.cep = txtCEP.Text;
                dadinho.rua = txtRua.Text;
                dadinho.nr = txtNr.Text;
                dadinho.bairro = txtBairro.Text;
                dadinho.cidade = txtCidade.Text;

                //dados extras ---

                dadinho.email = txtEmail.Text;
                dadinho.face = txtFacebook.Text;
                dadinho.twitter = txtTwitter.Text;
                if (!(picPessoa.Tag == null))
                {
                    dadinho.caminhoImagem = picPessoa.Tag.ToString();
                }
                dadinho.Registra(@"C:\"); // chama funcão para registrar dados
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            /*
             * função para consulta do ultimo registro.
             * um campo pode ser adicionado para pedir qual codigo deve ser consultado
             */
            codigoPuxar = txtCodigo.Text;
            try
            {
                StreamReader sr = new StreamReader(@"C:\" + codigoPuxar + ".txt ");
            
                int counter = 0;
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.IndexOf("A = ") == 0)
                    {
                        nome = line.Replace("A = ", "");
                    }
                    else if (line.IndexOf("B = ") == 0)
                    {
                        sexo = line.Replace("B = ", "");
                    }
                    else if (line.IndexOf("C = ") == 0)
                    {
                        rg = line.Replace("C = ", "");
                    }
                    else if (line.IndexOf("D = ") == 0)
                    {
                        cpf = line.Replace("D = ", "");
                    }
                    else if (line.IndexOf("E = ") == 0)
                    {
                        telresid = line.Replace("E = ", "");
                    }
                    else if (line.IndexOf("F = ") == 0)
                    {
                        cep = line.Replace("F = ", "");
                    }
                    else if (line.IndexOf("G = ") == 0)
                    {
                        rua = line.Replace("G = ", "");
                    }
                    else if (line.IndexOf("H = ") == 0)
                    {
                        nr = line.Replace("H = ", "");
                    }
                    else if (line.IndexOf("I = ") == 0)
                    {
                        bairro = line.Replace("I = ", "");
                    }
                    else if (line.IndexOf("J = ") == 0)
                    {
                        cidade = line.Replace("J = ", "");
                    }
                    else if (line.IndexOf("K = ") == 0)
                    {
                        email = line.Replace("K = ", "");
                    }
                    else if (line.IndexOf("L = ") == 0)
                    {
                        face = line.Replace("L = ", "");
                    }
                    else if (line.IndexOf("M = ") == 0)
                    {
                        twitter = line.Replace("M = ", "");
                    }
                    else if (line.IndexOf("N = ") == 0)
                    {
                        caminhoImagem = line.Replace("N = ", "");
                    }
                    counter++;
                }
                string paraMostrar;
                paraMostrar = "Nome: " + nome + Environment.NewLine;
                paraMostrar = paraMostrar + "Sexo: " + sexo + Environment.NewLine;
                paraMostrar = paraMostrar + "RG: " + rg + Environment.NewLine;
                paraMostrar = paraMostrar + "CPF: " + cpf + Environment.NewLine;
                paraMostrar = paraMostrar + "Telefone Residencial: " + telresid + Environment.NewLine;
                paraMostrar = paraMostrar + "CEP: " + cep + Environment.NewLine;
                paraMostrar = paraMostrar + "Rua: " + rua + Environment.NewLine;
                paraMostrar = paraMostrar + "Numero: " + nr + Environment.NewLine;
                paraMostrar = paraMostrar + "Bairro: " + bairro + Environment.NewLine;
                paraMostrar = paraMostrar + "Cidade: " + cidade + Environment.NewLine;
                paraMostrar = paraMostrar + "Email: " + email + Environment.NewLine;
                paraMostrar = paraMostrar + "Facebook: " + face + Environment.NewLine;
                paraMostrar = paraMostrar + "Twitter: " + twitter + Environment.NewLine;
                paraMostrar = paraMostrar + "Caminho da imagem: " + caminhoImagem + Environment.NewLine;
                MessageBox.Show(paraMostrar);
                codigoPuxar = "";
                nome = "";
                sexo = "";
                rg = "";
                cpf = "";
                telresid = "";
                cep = "";
                rua = "";
                nr = "";
                bairro = "";
                cidade = "";
                email = "";
                face = "";
                twitter = "";
                caminhoImagem = "";

            }
            catch (Exception err)
            {
                MessageBox.Show("Falha ao ler arquivo - " + err.Message); // mostra msg de erro caso algo aconteça
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Dados dadinho = new Dados();
            txtNome.Text = "";
            txtRG.Text = "";
            txtCPF.Text = "";
            txtTR.Text = "";
            radFeminino.Checked = false;
            radMasculino.Checked = false;
            radIndefinido.Checked = false;
            txtCEP.Text = "";
            txtRua.Text = "";
            txtBairro.Text = "";
            txtNr.Text = "";
            txtCidade.Text = "";
            txtEmail.Text = "";
            txtFacebook.Text = "";
            txtTwitter.Text = "";
            /*
             * dadinho.LimpaCampos(this.grpDadosPessoais.Controls); ---não funcionando
             * dadinho.LimpaCampos(this.grpEndereco.Controls);  ---não funcionando
             * dadinho.LimpaCampos(this.grpDadosExtras.Controls);  ---não funcionando
             */
            Random rnd = new Random(); //gera um NOVO número randonico 
            txtCodigo.Text = rnd.Next(100, 999).ToString(); 
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        //checkbox visivel e insisivel
        private void chkEmail_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEmail.Checked)
            {
                txtEmail.Enabled = true;
            }
            else
            {
                txtEmail.Enabled = false;
            }

        }
        //checkbox visivel e insisivel
        private void chkFacebook_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFacebook.Checked)
            {
                txtFacebook.Enabled = true;
            }
            else
            {
                txtFacebook.Enabled = false;
            }
        }
        //checkbox visivel e insisivel
        private void chkTwitter_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTwitter.Checked)
            {
                txtTwitter.Enabled = true;
            }
            else
            {
                txtTwitter.Enabled = false;
            }
        }

        private void btnLimparImg_Click(object sender, EventArgs e)
        {
            picPessoa.BackgroundImage = null; //define a imagem como null
        }

        private void btnCarregarImg_Click(object sender, EventArgs e)
        {
            //picPessoa.ImageLocation = "D:/MURILO/escola/ETEC FINAL/ds/Exercicio_26_02/teste.jpg";
            openFile.ShowDialog(); // Mostra o dialogo
        }

        private void openFile_FileOk(object sender, CancelEventArgs e)
        {
            picPessoa.BackgroundImage = Image.FromFile(openFile.FileName.ToString()); // define imagem na picBox
            picPessoa.Tag = openFile.FileName.ToString(); // salva para acessar o caminho dps
        }

    }
}