namespace Jogo_velha
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnNove = new System.Windows.Forms.Button();
            this.btnUm = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnQuatro = new System.Windows.Forms.Button();
            this.btnOito = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnSete = new System.Windows.Forms.Button();
            this.btnDois = new System.Windows.Forms.Button();
            this.grpTabuleiro = new System.Windows.Forms.GroupBox();
            this.lblJogo = new System.Windows.Forms.Label();
            this.picBarra2 = new System.Windows.Forms.PictureBox();
            this.picBarra1 = new System.Windows.Forms.PictureBox();
            this.picImagem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBarra2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBarra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNove
            // 
            this.btnNove.Location = new System.Drawing.Point(326, 302);
            this.btnNove.Name = "btnNove";
            this.btnNove.Size = new System.Drawing.Size(107, 83);
            this.btnNove.TabIndex = 35;
            this.btnNove.UseVisualStyleBackColor = true;
            // 
            // btnUm
            // 
            this.btnUm.Location = new System.Drawing.Point(114, 138);
            this.btnUm.Name = "btnUm";
            this.btnUm.Size = new System.Drawing.Size(107, 83);
            this.btnUm.TabIndex = 27;
            this.btnUm.UseVisualStyleBackColor = true;
            // 
            // btnTres
            // 
            this.btnTres.Location = new System.Drawing.Point(114, 302);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(107, 83);
            this.btnTres.TabIndex = 29;
            this.btnTres.UseVisualStyleBackColor = true;
            // 
            // btnQuatro
            // 
            this.btnQuatro.Location = new System.Drawing.Point(220, 138);
            this.btnQuatro.Name = "btnQuatro";
            this.btnQuatro.Size = new System.Drawing.Size(107, 83);
            this.btnQuatro.TabIndex = 30;
            this.btnQuatro.UseVisualStyleBackColor = true;
            // 
            // btnOito
            // 
            this.btnOito.Location = new System.Drawing.Point(326, 220);
            this.btnOito.Name = "btnOito";
            this.btnOito.Size = new System.Drawing.Size(107, 83);
            this.btnOito.TabIndex = 34;
            this.btnOito.UseVisualStyleBackColor = true;
            // 
            // btnCinco
            // 
            this.btnCinco.Location = new System.Drawing.Point(220, 220);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(107, 83);
            this.btnCinco.TabIndex = 31;
            this.btnCinco.UseVisualStyleBackColor = true;
            // 
            // btnSeis
            // 
            this.btnSeis.Location = new System.Drawing.Point(220, 302);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(107, 83);
            this.btnSeis.TabIndex = 32;
            this.btnSeis.UseVisualStyleBackColor = true;
            // 
            // btnSete
            // 
            this.btnSete.Location = new System.Drawing.Point(326, 138);
            this.btnSete.Name = "btnSete";
            this.btnSete.Size = new System.Drawing.Size(107, 83);
            this.btnSete.TabIndex = 33;
            this.btnSete.UseVisualStyleBackColor = true;
            // 
            // btnDois
            // 
            this.btnDois.Location = new System.Drawing.Point(114, 220);
            this.btnDois.Name = "btnDois";
            this.btnDois.Size = new System.Drawing.Size(107, 83);
            this.btnDois.TabIndex = 28;
            this.btnDois.UseVisualStyleBackColor = true;
            // 
            // grpTabuleiro
            // 
            this.grpTabuleiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTabuleiro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(225)))));
            this.grpTabuleiro.Location = new System.Drawing.Point(109, 108);
            this.grpTabuleiro.Name = "grpTabuleiro";
            this.grpTabuleiro.Size = new System.Drawing.Size(330, 277);
            this.grpTabuleiro.TabIndex = 36;
            this.grpTabuleiro.TabStop = false;
            this.grpTabuleiro.Text = "Tabuleiro";
            this.grpTabuleiro.Enter += new System.EventHandler(this.grpTabuleiro_Enter);
            // 
            // lblJogo
            // 
            this.lblJogo.AutoSize = true;
            this.lblJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(209)))));
            this.lblJogo.Location = new System.Drawing.Point(153, 9);
            this.lblJogo.Name = "lblJogo";
            this.lblJogo.Size = new System.Drawing.Size(255, 39);
            this.lblJogo.TabIndex = 37;
            this.lblJogo.Text = "Jogo Da Velha";
            // 
            // picBarra2
            // 
            this.picBarra2.Image = global::Jogo_velha.Properties.Resources.cor;
            this.picBarra2.Location = new System.Drawing.Point(200, 391);
            this.picBarra2.Name = "picBarra2";
            this.picBarra2.Size = new System.Drawing.Size(145, 21);
            this.picBarra2.TabIndex = 40;
            this.picBarra2.TabStop = false;
            // 
            // picBarra1
            // 
            this.picBarra1.Image = global::Jogo_velha.Properties.Resources.cor;
            this.picBarra1.Location = new System.Drawing.Point(197, 51);
            this.picBarra1.Name = "picBarra1";
            this.picBarra1.Size = new System.Drawing.Size(145, 21);
            this.picBarra1.TabIndex = 39;
            this.picBarra1.TabStop = false;
            // 
            // picImagem
            // 
            this.picImagem.Image = global::Jogo_velha.Properties.Resources.cara;
            this.picImagem.Location = new System.Drawing.Point(454, 3);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(100, 104);
            this.picImagem.TabIndex = 38;
            this.picImagem.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 419);
            this.Controls.Add(this.picBarra2);
            this.Controls.Add(this.picBarra1);
            this.Controls.Add(this.picImagem);
            this.Controls.Add(this.lblJogo);
            this.Controls.Add(this.btnNove);
            this.Controls.Add(this.btnOito);
            this.Controls.Add(this.btnUm);
            this.Controls.Add(this.btnSete);
            this.Controls.Add(this.btnSeis);
            this.Controls.Add(this.btnQuatro);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btnDois);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.grpTabuleiro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Jogo da Velha - J. Marco B.";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBarra2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBarra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNove;
        private System.Windows.Forms.Button btnUm;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnQuatro;
        private System.Windows.Forms.Button btnOito;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnSete;
        private System.Windows.Forms.Button btnDois;
        private System.Windows.Forms.GroupBox grpTabuleiro;
        private System.Windows.Forms.Label lblJogo;
        private System.Windows.Forms.PictureBox picImagem;
        private System.Windows.Forms.PictureBox picBarra1;
        private System.Windows.Forms.PictureBox picBarra2;

    }
}

