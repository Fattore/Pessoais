using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        OleDbConnection Conecta = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:/Usuario.accdb;Persist Security Info=False;");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conecta.Open();
            string VNome = textBox1.Text;
            string VEmail = textBox2.Text;
            string VTelefone = textBox4.Text;
            string VCPF = textBox5.Text;

            OleDbCommand Comanda = new OleDbCommand("Insert into Usuario(Nome, Email, Telefone, CPF) values ('"+VNome+"','"+VEmail+"','"+VTelefone+"','"+VCPF+"');",Conecta);
            Comanda.ExecuteNonQuery();
            MessageBox.Show("Cadastrado com Sucesso");
            Conecta.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Conecta.Open();
            String busca = textBox3.Text;
            OleDbCommand Selectcom = new OleDbCommand("Select * From Usuario where Nome = '" + busca + "' ", Conecta);
            OleDbDataReader leitor = Selectcom.ExecuteReader();
            leitor.Read();
            MessageBox.Show(leitor.GetString(1) + leitor.GetString(2) + leitor.GetString(3) + leitor.GetString(4));
            Conecta.Close();
        }
    }
}
