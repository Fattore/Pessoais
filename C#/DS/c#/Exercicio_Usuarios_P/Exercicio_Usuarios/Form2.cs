using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exercicio_Usuarios
{
    public partial class frmForgot : System.Windows.Forms.Form
    {
        public frmForgot()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Um email foi enviado para: " + txtUsuario2.Text);
            this.Close();
        }

    }
}
