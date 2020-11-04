namespace Interruptor
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnOn = new System.Windows.Forms.Button();
            this.btnOff = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            this.picImg = new System.Windows.Forms.PictureBox();
            this.txtMsg = new System.Windows.Forms.Label();
            this.lblFabricante = new System.Windows.Forms.Label();
            this.lblNone = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOn
            // 
            this.btnOn.Location = new System.Drawing.Point(195, 12);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(147, 39);
            this.btnOn.TabIndex = 0;
            this.btnOn.Text = "Turn on ";
            this.btnOn.UseVisualStyleBackColor = true;
            this.btnOn.Click += new System.EventHandler(this.btnOn_Click);
            // 
            // btnOff
            // 
            this.btnOff.Location = new System.Drawing.Point(195, 57);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(147, 39);
            this.btnOff.TabIndex = 1;
            this.btnOff.Text = "Turn off";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(195, 184);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(147, 48);
            this.btnStatus.TabIndex = 2;
            this.btnStatus.Text = "Status";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // picImg
            // 
            this.picImg.Location = new System.Drawing.Point(12, 12);
            this.picImg.Name = "picImg";
            this.picImg.Size = new System.Drawing.Size(169, 220);
            this.picImg.TabIndex = 3;
            this.picImg.TabStop = false;
            // 
            // txtMsg
            // 
            this.txtMsg.AutoSize = true;
            this.txtMsg.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMsg.Location = new System.Drawing.Point(12, 235);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(0, 23);
            this.txtMsg.TabIndex = 4;
            // 
            // lblFabricante
            // 
            this.lblFabricante.AutoSize = true;
            this.lblFabricante.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFabricante.Location = new System.Drawing.Point(187, 140);
            this.lblFabricante.Name = "lblFabricante";
            this.lblFabricante.Size = new System.Drawing.Size(89, 20);
            this.lblFabricante.TabIndex = 5;
            this.lblFabricante.Text = "Fabricante:";
            // 
            // lblNone
            // 
            this.lblNone.AutoSize = true;
            this.lblNone.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNone.Location = new System.Drawing.Point(272, 140);
            this.lblNone.Name = "lblNone";
            this.lblNone.Size = new System.Drawing.Size(0, 20);
            this.lblNone.TabIndex = 6;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 267);
            this.Controls.Add(this.lblNone);
            this.Controls.Add(this.lblFabricante);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.picImg);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.btnOn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "Casa Inteligente";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOn;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.PictureBox picImg;
        private System.Windows.Forms.Label txtMsg;
        private System.Windows.Forms.Label lblFabricante;
        private System.Windows.Forms.Label lblNone;
    }
}

