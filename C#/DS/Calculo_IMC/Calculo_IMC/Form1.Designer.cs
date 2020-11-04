namespace Calculo_IMC
{
    partial class frmIMC
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.lblIMCCal = new System.Windows.Forms.Label();
            this.lblSituacaoCal = new System.Windows.Forms.Label();
            this.lblMostrarIMC = new System.Windows.Forms.Label();
            this.lblMostraSitu = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.grpGrupo = new System.Windows.Forms.GroupBox();
            this.grpGrupo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(6, 103);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(159, 27);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cmbSexo.Location = new System.Drawing.Point(45, 72);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(100, 21);
            this.cmbSexo.TabIndex = 6;
            this.cmbSexo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSexo_KeyDown);
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(6, 23);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(31, 13);
            this.lblPeso.TabIndex = 1;
            this.lblPeso.Text = "Peso";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(3, 49);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(34, 13);
            this.lblAltura.TabIndex = 3;
            this.lblAltura.Text = "Altura";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(6, 78);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 5;
            this.lblSexo.Text = "Sexo";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(45, 20);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 2;
            this.txtPeso.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPeso_KeyDown);
            this.txtPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeso_KeyPress);
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(45, 46);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 20);
            this.txtAltura.TabIndex = 4;
            this.txtAltura.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAltura_KeyDown);
            // 
            // lblIMCCal
            // 
            this.lblIMCCal.AutoSize = true;
            this.lblIMCCal.Location = new System.Drawing.Point(32, 143);
            this.lblIMCCal.Name = "lblIMCCal";
            this.lblIMCCal.Size = new System.Drawing.Size(35, 13);
            this.lblIMCCal.TabIndex = 8;
            this.lblIMCCal.Text = "IMC =";
            // 
            // lblSituacaoCal
            // 
            this.lblSituacaoCal.AutoSize = true;
            this.lblSituacaoCal.Location = new System.Drawing.Point(9, 172);
            this.lblSituacaoCal.Name = "lblSituacaoCal";
            this.lblSituacaoCal.Size = new System.Drawing.Size(58, 13);
            this.lblSituacaoCal.TabIndex = 10;
            this.lblSituacaoCal.Text = "Situação =";
            // 
            // lblMostrarIMC
            // 
            this.lblMostrarIMC.AutoSize = true;
            this.lblMostrarIMC.Location = new System.Drawing.Point(73, 143);
            this.lblMostrarIMC.Name = "lblMostrarIMC";
            this.lblMostrarIMC.Size = new System.Drawing.Size(0, 13);
            this.lblMostrarIMC.TabIndex = 9;
            // 
            // lblMostraSitu
            // 
            this.lblMostraSitu.AutoSize = true;
            this.lblMostraSitu.Location = new System.Drawing.Point(73, 172);
            this.lblMostraSitu.Name = "lblMostraSitu";
            this.lblMostraSitu.Size = new System.Drawing.Size(0, 13);
            this.lblMostraSitu.TabIndex = 11;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(12, 199);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(108, 199);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // grpGrupo
            // 
            this.grpGrupo.Controls.Add(this.txtPeso);
            this.grpGrupo.Controls.Add(this.btnCalcular);
            this.grpGrupo.Controls.Add(this.cmbSexo);
            this.grpGrupo.Controls.Add(this.lblPeso);
            this.grpGrupo.Controls.Add(this.lblAltura);
            this.grpGrupo.Controls.Add(this.lblSexo);
            this.grpGrupo.Controls.Add(this.txtAltura);
            this.grpGrupo.Location = new System.Drawing.Point(12, 4);
            this.grpGrupo.Name = "grpGrupo";
            this.grpGrupo.Size = new System.Drawing.Size(171, 136);
            this.grpGrupo.TabIndex = 14;
            this.grpGrupo.TabStop = false;
            // 
            // frmIMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 233);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblMostraSitu);
            this.Controls.Add(this.lblMostrarIMC);
            this.Controls.Add(this.lblSituacaoCal);
            this.Controls.Add(this.lblIMCCal);
            this.Controls.Add(this.grpGrupo);
            this.Name = "frmIMC";
            this.Text = "IMC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmIMC_FormClosing);
            this.Load += new System.EventHandler(this.frmIMC_Load);
            this.grpGrupo.ResumeLayout(false);
            this.grpGrupo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label lblIMCCal;
        private System.Windows.Forms.Label lblSituacaoCal;
        private System.Windows.Forms.Label lblMostrarIMC;
        private System.Windows.Forms.Label lblMostraSitu;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox grpGrupo;
    }
}

