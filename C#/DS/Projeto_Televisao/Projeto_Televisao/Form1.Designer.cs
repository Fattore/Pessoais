namespace Projeto_Televisao
{
    partial class FrmTV
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
            this.lblVol = new System.Windows.Forms.Label();
            this.lblCanal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCanalD = new System.Windows.Forms.Button();
            this.btnCanalUP = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnVolD = new System.Windows.Forms.Button();
            this.btnVolUP = new System.Windows.Forms.Button();
            this.txtVolMsg = new System.Windows.Forms.Label();
            this.txtCanalMsg = new System.Windows.Forms.Label();
            this.picPower = new System.Windows.Forms.PictureBox();
            this.picImgTV = new System.Windows.Forms.PictureBox();
            this.picControlePower = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImgTV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picControlePower)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVol
            // 
            this.lblVol.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVol.Location = new System.Drawing.Point(20, 16);
            this.lblVol.Name = "lblVol";
            this.lblVol.Size = new System.Drawing.Size(80, 21);
            this.lblVol.TabIndex = 0;
            this.lblVol.Text = "Volume:";
            // 
            // lblCanal
            // 
            this.lblCanal.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCanal.Location = new System.Drawing.Point(358, 16);
            this.lblCanal.Name = "lblCanal";
            this.lblCanal.Size = new System.Drawing.Size(65, 22);
            this.lblCanal.TabIndex = 1;
            this.lblCanal.Text = "Canal:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.picControlePower);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(470, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 282);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controle";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCanalD);
            this.groupBox3.Controls.Add(this.btnCanalUP);
            this.groupBox3.Location = new System.Drawing.Point(6, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(182, 92);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Canais";
            // 
            // btnCanalD
            // 
            this.btnCanalD.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCanalD.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCanalD.Location = new System.Drawing.Point(94, 19);
            this.btnCanalD.Name = "btnCanalD";
            this.btnCanalD.Size = new System.Drawing.Size(84, 63);
            this.btnCanalD.TabIndex = 1;
            this.btnCanalD.Text = " ↓ ";
            this.btnCanalD.UseVisualStyleBackColor = false;
            this.btnCanalD.Click += new System.EventHandler(this.btnCanalD_Click);
            // 
            // btnCanalUP
            // 
            this.btnCanalUP.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCanalUP.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCanalUP.Location = new System.Drawing.Point(8, 19);
            this.btnCanalUP.Name = "btnCanalUP";
            this.btnCanalUP.Size = new System.Drawing.Size(81, 63);
            this.btnCanalUP.TabIndex = 0;
            this.btnCanalUP.Text = " ↑";
            this.btnCanalUP.UseVisualStyleBackColor = false;
            this.btnCanalUP.Click += new System.EventHandler(this.btnCanalUP_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnVolD);
            this.groupBox2.Controls.Add(this.btnVolUP);
            this.groupBox2.Location = new System.Drawing.Point(6, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(183, 91);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Volume";
            // 
            // btnVolD
            // 
            this.btnVolD.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVolD.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolD.Location = new System.Drawing.Point(94, 19);
            this.btnVolD.Name = "btnVolD";
            this.btnVolD.Size = new System.Drawing.Size(84, 63);
            this.btnVolD.TabIndex = 3;
            this.btnVolD.Text = " ↓ ";
            this.btnVolD.UseVisualStyleBackColor = false;
            this.btnVolD.Click += new System.EventHandler(this.btnVolD_Click);
            // 
            // btnVolUP
            // 
            this.btnVolUP.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVolUP.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolUP.Location = new System.Drawing.Point(5, 19);
            this.btnVolUP.Name = "btnVolUP";
            this.btnVolUP.Size = new System.Drawing.Size(84, 63);
            this.btnVolUP.TabIndex = 2;
            this.btnVolUP.Text = " ↑";
            this.btnVolUP.UseVisualStyleBackColor = false;
            this.btnVolUP.Click += new System.EventHandler(this.btnVolUP_Click);
            // 
            // txtVolMsg
            // 
            this.txtVolMsg.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVolMsg.Location = new System.Drawing.Point(93, 16);
            this.txtVolMsg.Name = "txtVolMsg";
            this.txtVolMsg.Size = new System.Drawing.Size(62, 20);
            this.txtVolMsg.TabIndex = 4;
            // 
            // txtCanalMsg
            // 
            this.txtCanalMsg.AutoSize = true;
            this.txtCanalMsg.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCanalMsg.Location = new System.Drawing.Point(414, 16);
            this.txtCanalMsg.Name = "txtCanalMsg";
            this.txtCanalMsg.Size = new System.Drawing.Size(0, 26);
            this.txtCanalMsg.TabIndex = 5;
            // 
            // picPower
            // 
            this.picPower.Image = global::Projeto_Televisao.Properties.Resources.Pillbuttonred_clip_art_hight;
            this.picPower.Location = new System.Drawing.Point(390, 395);
            this.picPower.Name = "picPower";
            this.picPower.Size = new System.Drawing.Size(59, 14);
            this.picPower.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPower.TabIndex = 6;
            this.picPower.TabStop = false;
            // 
            // picImgTV
            // 
            this.picImgTV.Image = global::Projeto_Televisao.Properties.Resources.download;
            this.picImgTV.Location = new System.Drawing.Point(19, 56);
            this.picImgTV.Name = "picImgTV";
            this.picImgTV.Size = new System.Drawing.Size(430, 326);
            this.picImgTV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImgTV.TabIndex = 2;
            this.picImgTV.TabStop = false;
            // 
            // picControlePower
            // 
            this.picControlePower.Image = global::Projeto_Televisao.Properties.Resources.power;
            this.picControlePower.Location = new System.Drawing.Point(61, 220);
            this.picControlePower.Name = "picControlePower";
            this.picControlePower.Size = new System.Drawing.Size(73, 56);
            this.picControlePower.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picControlePower.TabIndex = 4;
            this.picControlePower.TabStop = false;
            this.picControlePower.Click += new System.EventHandler(this.picControlePower_Click);
            this.picControlePower.DoubleClick += new System.EventHandler(this.picControlePower_DoubleClick);
            // 
            // FrmTV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 412);
            this.Controls.Add(this.picPower);
            this.Controls.Add(this.txtCanalMsg);
            this.Controls.Add(this.txtVolMsg);
            this.Controls.Add(this.picImgTV);
            this.Controls.Add(this.lblCanal);
            this.Controls.Add(this.lblVol);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmTV";
            this.Text = "ETEC_TV";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImgTV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picControlePower)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVol;
        private System.Windows.Forms.Label lblCanal;
        private System.Windows.Forms.PictureBox picImgTV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVolD;
        private System.Windows.Forms.Button btnVolUP;
        private System.Windows.Forms.Button btnCanalD;
        private System.Windows.Forms.Button btnCanalUP;
        private System.Windows.Forms.Label txtVolMsg;
        private System.Windows.Forms.Label txtCanalMsg;
        private System.Windows.Forms.PictureBox picPower;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox picControlePower;
    }
}

