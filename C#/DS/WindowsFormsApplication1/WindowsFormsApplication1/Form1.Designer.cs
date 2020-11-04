namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.btnBuildPeople = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblHeightBP = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAgeBP = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGenderBP = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNameBP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblToWalk = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Comic Sans MS", 14.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 28);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(94, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(379, 20);
            this.txtName.TabIndex = 1;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Location = new System.Drawing.Point(6, 47);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(72, 30);
            this.radMale.TabIndex = 3;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Location = new System.Drawing.Point(111, 47);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(92, 30);
            this.radFemale.TabIndex = 4;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.radFemale);
            this.groupBox1.Controls.Add(this.radMale);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 103);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.txtHeight);
            this.groupBox2.Controls.Add(this.lblHeight);
            this.groupBox2.Controls.Add(this.txtAge);
            this.groupBox2.Controls.Add(this.lblAge);
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(268, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(205, 103);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Age and Height";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(129, 61);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(66, 34);
            this.txtHeight.TabIndex = 8;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Comic Sans MS", 14.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(124, 30);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(75, 28);
            this.lblHeight.TabIndex = 8;
            this.lblHeight.Text = "Height";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(6, 61);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(61, 34);
            this.txtAge.TabIndex = 7;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Comic Sans MS", 14.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(6, 30);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(48, 28);
            this.lblAge.TabIndex = 7;
            this.lblAge.Text = "Age";
            // 
            // btnBuildPeople
            // 
            this.btnBuildPeople.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuildPeople.ForeColor = System.Drawing.Color.DarkRed;
            this.btnBuildPeople.Location = new System.Drawing.Point(186, 158);
            this.btnBuildPeople.Name = "btnBuildPeople";
            this.btnBuildPeople.Size = new System.Drawing.Size(136, 31);
            this.btnBuildPeople.TabIndex = 7;
            this.btnBuildPeople.Text = "Build the people";
            this.btnBuildPeople.UseVisualStyleBackColor = true;
            this.btnBuildPeople.Click += new System.EventHandler(this.btnBuildPeople_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox3.Controls.Add(this.lblHeightBP);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lblAgeBP);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.lblGenderBP);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.lblNameBP);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(18, 195);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(455, 156);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Built Person";
            // 
            // lblHeightBP
            // 
            this.lblHeightBP.AutoSize = true;
            this.lblHeightBP.Font = new System.Drawing.Font("Comic Sans MS", 14.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeightBP.Location = new System.Drawing.Point(100, 114);
            this.lblHeightBP.Name = "lblHeightBP";
            this.lblHeightBP.Size = new System.Drawing.Size(0, 28);
            this.lblHeightBP.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 14.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 28);
            this.label5.TabIndex = 14;
            this.label5.Text = "Height:";
            // 
            // lblAgeBP
            // 
            this.lblAgeBP.AutoSize = true;
            this.lblAgeBP.Font = new System.Drawing.Font("Comic Sans MS", 14.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeBP.Location = new System.Drawing.Point(100, 86);
            this.lblAgeBP.Name = "lblAgeBP";
            this.lblAgeBP.Size = new System.Drawing.Size(0, 28);
            this.lblAgeBP.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 28);
            this.label3.TabIndex = 12;
            this.label3.Text = "Age:";
            // 
            // lblGenderBP
            // 
            this.lblGenderBP.AutoSize = true;
            this.lblGenderBP.Font = new System.Drawing.Font("Comic Sans MS", 14.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenderBP.Location = new System.Drawing.Point(100, 58);
            this.lblGenderBP.Name = "lblGenderBP";
            this.lblGenderBP.Size = new System.Drawing.Size(0, 28);
            this.lblGenderBP.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "Gender:";
            // 
            // lblNameBP
            // 
            this.lblNameBP.AutoSize = true;
            this.lblNameBP.Font = new System.Drawing.Font("Comic Sans MS", 14.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameBP.Location = new System.Drawing.Point(100, 30);
            this.lblNameBP.Name = "lblNameBP";
            this.lblNameBP.Size = new System.Drawing.Size(0, 28);
            this.lblNameBP.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name:";
            // 
            // lblToWalk
            // 
            this.lblToWalk.AutoSize = true;
            this.lblToWalk.Font = new System.Drawing.Font("Comic Sans MS", 14.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToWalk.Location = new System.Drawing.Point(22, 354);
            this.lblToWalk.Name = "lblToWalk";
            this.lblToWalk.Size = new System.Drawing.Size(0, 28);
            this.lblToWalk.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(482, 382);
            this.Controls.Add(this.lblToWalk);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnBuildPeople);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "FIRST OF THE YEAR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Button btnBuildPeople;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblHeightBP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAgeBP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblGenderBP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNameBP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblToWalk;
    }
}

