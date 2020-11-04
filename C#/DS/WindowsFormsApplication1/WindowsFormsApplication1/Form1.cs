using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBuildPeople_Click(object sender, EventArgs e)
        {   //gerar um objeto do tipo pessoa...instânciar

            Pessoa people = new Pessoa();

            //gravando valores nos atributos do objeto people

            people.name = txtName.Text;

            //gravando o sexo em radio
            //necessário colocar else if(......)

            if (radMale.Checked == true)
            {
                people.gender = "Male";
            }
            else if (radFemale.Checked == true)
            {
                people.gender = "Female";
            }
            else
            {
                MessageBox.Show("`Please, select one gender !!");
            }

            //gravando idade e estatura

            people.age = int.Parse(txtAge.Text);
            people.height = double.Parse(txtHeight.Text);

            //ler valor do atributo do objeto

            lblNameBP.Text = people.name;
            lblGenderBP.Text = people.gender;

            //ler int e double
            //lblAgeBP.Text = people.age+""; -> wrong

            lblAgeBP.Text = people.age.ToString();
            lblHeightBP.Text = people.height.ToString();
            
            //fazendo a pessoa andar

            lblToWalk.Text = people.toWalk();
        }

    }
}
