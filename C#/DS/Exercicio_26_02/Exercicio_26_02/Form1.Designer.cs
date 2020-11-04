namespace Exercicio_26_02
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.lblTR = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblNr = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblRua = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblFacebook = new System.Windows.Forms.Label();
            this.lblTwitter = new System.Windows.Forms.Label();
            this.radMasculino = new System.Windows.Forms.RadioButton();
            this.radFeminino = new System.Windows.Forms.RadioButton();
            this.chkEmail = new System.Windows.Forms.CheckBox();
            this.chkFacebook = new System.Windows.Forms.CheckBox();
            this.chkTwitter = new System.Windows.Forms.CheckBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtNr = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtFacebook = new System.Windows.Forms.TextBox();
            this.txtTwitter = new System.Windows.Forms.TextBox();
            this.picPessoa = new System.Windows.Forms.PictureBox();
            this.btnCarregarImg = new System.Windows.Forms.Button();
            this.btnLimparImg = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.grpDadosPessoais = new System.Windows.Forms.GroupBox();
            this.txtTR = new System.Windows.Forms.MaskedTextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtRG = new System.Windows.Forms.MaskedTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radIndefinido = new System.Windows.Forms.RadioButton();
            this.grpEndereco = new System.Windows.Forms.GroupBox();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.grpDadosExtras = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.errValida = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picPessoa)).BeginInit();
            this.grpDadosPessoais.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.grpEndereco.SuspendLayout();
            this.grpDadosExtras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errValida)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(14, 30);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(14, 57);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblRG
            // 
            this.lblRG.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(14, 83);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(26, 13);
            this.lblRG.TabIndex = 2;
            this.lblRG.Text = "R.G";
            // 
            // lblTR
            // 
            this.lblTR.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTR.AutoSize = true;
            this.lblTR.Location = new System.Drawing.Point(6, 109);
            this.lblTR.Name = "lblTR";
            this.lblTR.Size = new System.Drawing.Size(55, 13);
            this.lblTR.TabIndex = 3;
            this.lblTR.Text = "Tel.Resid.";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(139, 83);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(27, 13);
            this.lblCPF.TabIndex = 4;
            this.lblCPF.Text = "CPF";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(14, 28);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(28, 13);
            this.lblCEP.TabIndex = 5;
            this.lblCEP.Text = "CEP";
            // 
            // lblNr
            // 
            this.lblNr.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNr.AutoSize = true;
            this.lblNr.Location = new System.Drawing.Point(17, 57);
            this.lblNr.Name = "lblNr";
            this.lblNr.Size = new System.Drawing.Size(21, 13);
            this.lblNr.TabIndex = 6;
            this.lblNr.Text = "Nr.";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(96, 57);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(34, 13);
            this.lblBairro.TabIndex = 7;
            this.lblBairro.Text = "Bairro";
            // 
            // lblCidade
            // 
            this.lblCidade.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(274, 57);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 8;
            this.lblCidade.Text = "Cidade";
            // 
            // lblRua
            // 
            this.lblRua.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(171, 28);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(27, 13);
            this.lblRua.TabIndex = 9;
            this.lblRua.Text = "Rua";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(17, 27);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "E-mail";
            // 
            // lblFacebook
            // 
            this.lblFacebook.AutoSize = true;
            this.lblFacebook.Location = new System.Drawing.Point(14, 60);
            this.lblFacebook.Name = "lblFacebook";
            this.lblFacebook.Size = new System.Drawing.Size(55, 13);
            this.lblFacebook.TabIndex = 11;
            this.lblFacebook.Text = "Facebook";
            // 
            // lblTwitter
            // 
            this.lblTwitter.AutoSize = true;
            this.lblTwitter.Location = new System.Drawing.Point(17, 89);
            this.lblTwitter.Name = "lblTwitter";
            this.lblTwitter.Size = new System.Drawing.Size(39, 13);
            this.lblTwitter.TabIndex = 12;
            this.lblTwitter.Text = "Twitter";
            // 
            // radMasculino
            // 
            this.radMasculino.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radMasculino.AutoSize = true;
            this.radMasculino.Location = new System.Drawing.Point(11, 15);
            this.radMasculino.Name = "radMasculino";
            this.radMasculino.Size = new System.Drawing.Size(73, 17);
            this.radMasculino.TabIndex = 7;
            this.radMasculino.TabStop = true;
            this.radMasculino.Text = "Masculino";
            this.radMasculino.UseVisualStyleBackColor = true;
            // 
            // radFeminino
            // 
            this.radFeminino.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radFeminino.AutoSize = true;
            this.radFeminino.Location = new System.Drawing.Point(90, 15);
            this.radFeminino.Name = "radFeminino";
            this.radFeminino.Size = new System.Drawing.Size(67, 17);
            this.radFeminino.TabIndex = 8;
            this.radFeminino.TabStop = true;
            this.radFeminino.Text = "Feminino";
            this.radFeminino.UseVisualStyleBackColor = true;
            // 
            // chkEmail
            // 
            this.chkEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkEmail.Location = new System.Drawing.Point(453, 22);
            this.chkEmail.Name = "chkEmail";
            this.chkEmail.Size = new System.Drawing.Size(104, 24);
            this.chkEmail.TabIndex = 20;
            this.chkEmail.Text = "E-Mail";
            this.chkEmail.CheckedChanged += new System.EventHandler(this.chkEmail_CheckedChanged);
            // 
            // chkFacebook
            // 
            this.chkFacebook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkFacebook.Location = new System.Drawing.Point(453, 55);
            this.chkFacebook.Name = "chkFacebook";
            this.chkFacebook.Size = new System.Drawing.Size(104, 24);
            this.chkFacebook.TabIndex = 22;
            this.chkFacebook.Text = "Facebook";
            this.chkFacebook.CheckedChanged += new System.EventHandler(this.chkFacebook_CheckedChanged);
            // 
            // chkTwitter
            // 
            this.chkTwitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTwitter.Location = new System.Drawing.Point(453, 84);
            this.chkTwitter.Name = "chkTwitter";
            this.chkTwitter.Size = new System.Drawing.Size(104, 24);
            this.chkTwitter.TabIndex = 24;
            this.chkTwitter.Text = "Twitter";
            this.chkTwitter.CheckedChanged += new System.EventHandler(this.chkTwitter_CheckedChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(56, 27);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(59, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.Location = new System.Drawing.Point(56, 54);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(207, 20);
            this.txtNome.TabIndex = 2;
            // 
            // txtRua
            // 
            this.txtRua.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtRua.Location = new System.Drawing.Point(204, 25);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(354, 20);
            this.txtRua.TabIndex = 14;
            // 
            // txtNr
            // 
            this.txtNr.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNr.Location = new System.Drawing.Point(47, 54);
            this.txtNr.Name = "txtNr";
            this.txtNr.Size = new System.Drawing.Size(31, 20);
            this.txtNr.TabIndex = 15;
            // 
            // txtBairro
            // 
            this.txtBairro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBairro.Location = new System.Drawing.Point(136, 54);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(127, 20);
            this.txtBairro.TabIndex = 16;
            // 
            // txtCidade
            // 
            this.txtCidade.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtCidade.Location = new System.Drawing.Point(320, 54);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(237, 20);
            this.txtCidade.TabIndex = 17;
            // 
            // txtFacebook
            // 
            this.txtFacebook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFacebook.Location = new System.Drawing.Point(75, 57);
            this.txtFacebook.Name = "txtFacebook";
            this.txtFacebook.Size = new System.Drawing.Size(368, 20);
            this.txtFacebook.TabIndex = 21;
            // 
            // txtTwitter
            // 
            this.txtTwitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTwitter.Location = new System.Drawing.Point(75, 87);
            this.txtTwitter.Name = "txtTwitter";
            this.txtTwitter.Size = new System.Drawing.Size(368, 20);
            this.txtTwitter.TabIndex = 23;
            // 
            // picPessoa
            // 
            this.picPessoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picPessoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPessoa.Location = new System.Drawing.Point(277, 39);
            this.picPessoa.Name = "picPessoa";
            this.picPessoa.Size = new System.Drawing.Size(125, 125);
            this.picPessoa.TabIndex = 35;
            this.picPessoa.TabStop = false;
            // 
            // btnCarregarImg
            // 
            this.btnCarregarImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCarregarImg.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCarregarImg.Location = new System.Drawing.Point(414, 46);
            this.btnCarregarImg.Name = "btnCarregarImg";
            this.btnCarregarImg.Size = new System.Drawing.Size(143, 50);
            this.btnCarregarImg.TabIndex = 10;
            this.btnCarregarImg.Text = "Carregar Imagem";
            this.btnCarregarImg.UseVisualStyleBackColor = false;
            this.btnCarregarImg.Click += new System.EventHandler(this.btnCarregarImg_Click);
            // 
            // btnLimparImg
            // 
            this.btnLimparImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimparImg.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimparImg.Location = new System.Drawing.Point(415, 114);
            this.btnLimparImg.Name = "btnLimparImg";
            this.btnLimparImg.Size = new System.Drawing.Size(143, 50);
            this.btnLimparImg.TabIndex = 11;
            this.btnLimparImg.Text = "Limpar Imagem";
            this.btnLimparImg.UseVisualStyleBackColor = false;
            this.btnLimparImg.Click += new System.EventHandler(this.btnLimparImg_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnIncluir.Location = new System.Drawing.Point(7, 420);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(96, 23);
            this.btnIncluir.TabIndex = 25;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAlterar.Location = new System.Drawing.Point(106, 420);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(96, 23);
            this.btnAlterar.TabIndex = 26;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnConsultar.Location = new System.Drawing.Point(208, 420);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(96, 23);
            this.btnConsultar.TabIndex = 27;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExcluir.Location = new System.Drawing.Point(310, 420);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(96, 23);
            this.btnExcluir.TabIndex = 28;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.Location = new System.Drawing.Point(412, 420);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(96, 23);
            this.btnLimpar.TabIndex = 29;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.Location = new System.Drawing.Point(514, 420);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(64, 23);
            this.btnSair.TabIndex = 30;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // grpDadosPessoais
            // 
            this.grpDadosPessoais.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDadosPessoais.BackColor = System.Drawing.Color.LightSteelBlue;
            this.grpDadosPessoais.Controls.Add(this.txtTR);
            this.grpDadosPessoais.Controls.Add(this.txtCPF);
            this.grpDadosPessoais.Controls.Add(this.txtRG);
            this.grpDadosPessoais.Controls.Add(this.btnLimparImg);
            this.grpDadosPessoais.Controls.Add(this.btnCarregarImg);
            this.grpDadosPessoais.Controls.Add(this.txtNome);
            this.grpDadosPessoais.Controls.Add(this.picPessoa);
            this.grpDadosPessoais.Controls.Add(this.txtCodigo);
            this.grpDadosPessoais.Controls.Add(this.lblCPF);
            this.grpDadosPessoais.Controls.Add(this.lblTR);
            this.grpDadosPessoais.Controls.Add(this.lblRG);
            this.grpDadosPessoais.Controls.Add(this.lblNome);
            this.grpDadosPessoais.Controls.Add(this.lblCodigo);
            this.grpDadosPessoais.Controls.Add(this.groupBox4);
            this.grpDadosPessoais.Location = new System.Drawing.Point(7, 12);
            this.grpDadosPessoais.Name = "grpDadosPessoais";
            this.grpDadosPessoais.Size = new System.Drawing.Size(571, 182);
            this.grpDadosPessoais.TabIndex = 40;
            this.grpDadosPessoais.TabStop = false;
            this.grpDadosPessoais.Text = "Dados Pessoais";
            // 
            // txtTR
            // 
            this.txtTR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTR.Location = new System.Drawing.Point(62, 109);
            this.txtTR.Mask = "(99) 00000-0000";
            this.txtTR.Name = "txtTR";
            this.txtTR.Size = new System.Drawing.Size(104, 20);
            this.txtTR.TabIndex = 5;
            // 
            // txtCPF
            // 
            this.txtCPF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCPF.Location = new System.Drawing.Point(172, 80);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(89, 20);
            this.txtCPF.TabIndex = 4;
            // 
            // txtRG
            // 
            this.txtRG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRG.Location = new System.Drawing.Point(56, 80);
            this.txtRG.Mask = "00.000.000-A";
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(74, 20);
            this.txtRG.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.radIndefinido);
            this.groupBox4.Controls.Add(this.radMasculino);
            this.groupBox4.Controls.Add(this.radFeminino);
            this.groupBox4.Location = new System.Drawing.Point(9, 132);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(254, 44);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sexo";
            // 
            // radIndefinido
            // 
            this.radIndefinido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radIndefinido.AutoSize = true;
            this.radIndefinido.Location = new System.Drawing.Point(163, 15);
            this.radIndefinido.Name = "radIndefinido";
            this.radIndefinido.Size = new System.Drawing.Size(71, 17);
            this.radIndefinido.TabIndex = 9;
            this.radIndefinido.TabStop = true;
            this.radIndefinido.Text = "Indefinido";
            this.radIndefinido.UseVisualStyleBackColor = true;
            // 
            // grpEndereco
            // 
            this.grpEndereco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.grpEndereco.BackColor = System.Drawing.Color.LightSteelBlue;
            this.grpEndereco.Controls.Add(this.txtCEP);
            this.grpEndereco.Controls.Add(this.txtCidade);
            this.grpEndereco.Controls.Add(this.txtBairro);
            this.grpEndereco.Controls.Add(this.txtNr);
            this.grpEndereco.Controls.Add(this.lblRua);
            this.grpEndereco.Controls.Add(this.lblCidade);
            this.grpEndereco.Controls.Add(this.lblBairro);
            this.grpEndereco.Controls.Add(this.lblNr);
            this.grpEndereco.Controls.Add(this.lblCEP);
            this.grpEndereco.Controls.Add(this.txtRua);
            this.grpEndereco.Location = new System.Drawing.Point(7, 200);
            this.grpEndereco.Name = "grpEndereco";
            this.grpEndereco.Size = new System.Drawing.Size(571, 93);
            this.grpEndereco.TabIndex = 12;
            this.grpEndereco.TabStop = false;
            this.grpEndereco.Text = "Endereço";
            // 
            // txtCEP
            // 
            this.txtCEP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCEP.Location = new System.Drawing.Point(47, 25);
            this.txtCEP.Mask = "00000-000";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(68, 20);
            this.txtCEP.TabIndex = 13;
            // 
            // grpDadosExtras
            // 
            this.grpDadosExtras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDadosExtras.BackColor = System.Drawing.Color.LightSteelBlue;
            this.grpDadosExtras.Controls.Add(this.txtTwitter);
            this.grpDadosExtras.Controls.Add(this.txtFacebook);
            this.grpDadosExtras.Controls.Add(this.txtEmail);
            this.grpDadosExtras.Controls.Add(this.chkTwitter);
            this.grpDadosExtras.Controls.Add(this.chkFacebook);
            this.grpDadosExtras.Controls.Add(this.chkEmail);
            this.grpDadosExtras.Controls.Add(this.lblTwitter);
            this.grpDadosExtras.Controls.Add(this.lblFacebook);
            this.grpDadosExtras.Controls.Add(this.lblEmail);
            this.grpDadosExtras.Location = new System.Drawing.Point(7, 299);
            this.grpDadosExtras.Name = "grpDadosExtras";
            this.grpDadosExtras.Size = new System.Drawing.Size(571, 115);
            this.grpDadosExtras.TabIndex = 18;
            this.grpDadosExtras.TabStop = false;
            this.grpDadosExtras.Text = "Dados Extras";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(75, 24);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(368, 20);
            this.txtEmail.TabIndex = 19;
            // 
            // openFile
            // 
            this.openFile.DefaultExt = "*.jpg";
            this.openFile.FileName = "Selecionar Imagem";
            this.openFile.Filter = "Imagem JPG|*.jpg|Toddynho|*.*";
            this.openFile.FileOk += new System.ComponentModel.CancelEventHandler(this.openFile_FileOk);
            // 
            // errValida
            // 
            this.errValida.ContainerControl = this;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(586, 447);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.grpEndereco);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.grpDadosPessoais);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.grpDadosExtras);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.ShowInTaskbar = false;
            this.Text = "Formulário";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPessoa)).EndInit();
            this.grpDadosPessoais.ResumeLayout(false);
            this.grpDadosPessoais.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.grpEndereco.ResumeLayout(false);
            this.grpEndereco.PerformLayout();
            this.grpDadosExtras.ResumeLayout(false);
            this.grpDadosExtras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errValida)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label lblTR;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblNr;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblFacebook;
        private System.Windows.Forms.Label lblTwitter;
        private System.Windows.Forms.RadioButton radMasculino;
        private System.Windows.Forms.RadioButton radFeminino;
        private System.Windows.Forms.CheckBox chkEmail;
        private System.Windows.Forms.CheckBox chkFacebook;
        private System.Windows.Forms.CheckBox chkTwitter;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtNr;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtFacebook;
        private System.Windows.Forms.TextBox txtTwitter;
        private System.Windows.Forms.PictureBox picPessoa;
        private System.Windows.Forms.Button btnCarregarImg;
        private System.Windows.Forms.Button btnLimparImg;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox grpDadosPessoais;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radIndefinido;
        private System.Windows.Forms.GroupBox grpEndereco;
        private System.Windows.Forms.GroupBox grpDadosExtras;
        private System.Windows.Forms.MaskedTextBox txtTR;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.MaskedTextBox txtRG;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.ErrorProvider errValida;
    }
}

