using System.Reflection.PortableExecutable;

namespace CalculadoraIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void butt_Click(object sender, EventArgs e)
        {
            double imc = 0;
            try
            {
                double peso = double.Parse(cxa1.Text);
                double altura = double.Parse(cxa2.Text);

                // Verifica se a altura é zero ou menor para evitar divisão por zero
                if (altura <= 0 || altura > 2.5)
                {
                    recom.Text = "Altura inválida! Digite uma altura entre 1 e 2,5";
                    cxa1.Text = "";
                    cxa2.Text = "";
                    return;
                }

                if (peso <= 0 || altura > 200)
                {
                    recom.Text = "Altura inválida! Tente novamente! Digite um peso entre 1 e 200";
                    cxa1.Text = "";
                    cxa2.Text = "";
                    return;
                }

                // Calcula o IMC
                imc = peso / (altura * altura);
                classif.Text = "O valor do seu IMC é " + imc.ToString("F2");


                // Exibe a classificação baseada no valor do IMC
                if (imc < 16)
                {
                    recom.Text = "Magreza grave";
                }
                else if (imc >= 16 && imc <= 16.9)
                {
                    recom.Text = "Magreza Moderada";
                }
                else if (imc >= 17 && imc <= 18.5)
                {
                    recom.Text = "Magreza Leve";
                }
                else if (imc >= 18.6 && imc <= 24.9)
                {
                    recom.Text = "Peso ideal";
                }
                else if (imc >= 25 && imc <= 29.9)
                {
                    recom.Text = "Sobrepeso";
                }
                else if (imc >= 30 && imc <= 34.9)
                {
                    recom.Text = "Obesidade grau I";
                }
                else if (imc >= 35 && imc <= 39.9)
                {
                    recom.Text = "Obesidade grau II ou severa";
                }
                else if (imc >= 40)
                {
                    recom.Text = "Obesidade grau III ou mórbida";
                }
            }
            catch (FormatException)
            {
                recom.Text = "Valor inválido!";
                classif.Text = "Digite novamente!";
                cxa1.Text = "";
                cxa2.Text = "";
            }

        }




















        private void classif_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
