namespace Exercicio_Usuarios
{
    partial class frmCadastro
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
            this.grpCadastrar = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblUsuarioCad = new System.Windows.Forms.Label();
            this.lblSenhaCad = new System.Windows.Forms.Label();
            this.txtSenhaCad = new System.Windows.Forms.TextBox();
            this.txtUsuarioCad = new System.Windows.Forms.TextBox();
            this.lblMsgCad = new System.Windows.Forms.Label();
            this.grpCadastrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCadastrar
            // 
            this.grpCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCadastrar.Controls.Add(this.lblMsgCad);
            this.grpCadastrar.Controls.Add(this.lblUsuarioCad);
            this.grpCadastrar.Controls.Add(this.lblSenhaCad);
            this.grpCadastrar.Controls.Add(this.txtSenhaCad);
            this.grpCadastrar.Controls.Add(this.txtUsuarioCad);
            this.grpCadastrar.Controls.Add(this.btnCadastrar);
            this.grpCadastrar.Location = new System.Drawing.Point(11, 12);
            this.grpCadastrar.Name = "grpCadastrar";
            this.grpCadastrar.Size = new System.Drawing.Size(260, 128);
            this.grpCadastrar.TabIndex = 1;
            this.grpCadastrar.TabStop = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadastrar.Location = new System.Drawing.Point(17, 92);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(229, 23);
            this.btnCadastrar.TabIndex = 9;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblUsuarioCad
            // 
            this.lblUsuarioCad.AutoSize = true;
            this.lblUsuarioCad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUsuarioCad.Location = new System.Drawing.Point(15, 39);
            this.lblUsuarioCad.Name = "lblUsuarioCad";
            this.lblUsuarioCad.Size = new System.Drawing.Size(43, 13);
            this.lblUsuarioCad.TabIndex = 10;
            this.lblUsuarioCad.Text = "Usuário";
            // 
            // lblSenhaCad
            // 
            this.lblSenhaCad.AutoSize = true;
            this.lblSenhaCad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSenhaCad.Location = new System.Drawing.Point(20, 66);
            this.lblSenhaCad.Name = "lblSenhaCad";
            this.lblSenhaCad.Size = new System.Drawing.Size(38, 13);
            this.lblSenhaCad.TabIndex = 11;
            this.lblSenhaCad.Text = "Senha";
            // 
            // txtSenhaCad
            // 
            this.txtSenhaCad.Location = new System.Drawing.Point(64, 66);
            this.txtSenhaCad.Name = "txtSenhaCad";
            this.txtSenhaCad.PasswordChar = '*';
            this.txtSenhaCad.Size = new System.Drawing.Size(182, 20);
            this.txtSenhaCad.TabIndex = 13;
            // 
            // txtUsuarioCad
            // 
            this.txtUsuarioCad.Location = new System.Drawing.Point(64, 36);
            this.txtUsuarioCad.Name = "txtUsuarioCad";
            this.txtUsuarioCad.Size = new System.Drawing.Size(182, 20);
            this.txtUsuarioCad.TabIndex = 12;
            // 
            // lblMsgCad
            // 
            this.lblMsgCad.AutoSize = true;
            this.lblMsgCad.Location = new System.Drawing.Point(61, 16);
            this.lblMsgCad.Name = "lblMsgCad";
            this.lblMsgCad.Size = new System.Drawing.Size(151, 13);
            this.lblMsgCad.TabIndex = 14;
            this.lblMsgCad.Text = "Digite o novo usuário e senha.";
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(283, 152);
            this.Controls.Add(this.grpCadastrar);
            this.Name = "frmCadastro";
            this.Text = "Cadastro";
            this.grpCadastrar.ResumeLayout(false);
            this.grpCadastrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCadastrar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblMsgCad;
        private System.Windows.Forms.Label lblUsuarioCad;
        private System.Windows.Forms.Label lblSenhaCad;
        private System.Windows.Forms.TextBox txtSenhaCad;
        private System.Windows.Forms.TextBox txtUsuarioCad;
    }
}