using Microsoft.VisualBasic.Logging;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Security.Policy;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Atividade_Windows_forms__13_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //1. Saudação: Crie um form que receba um nome num textbox e, ao clicar em button, exiba "Bem-vindo, ********"
        //Desafio: Colocar um bloqueio caso o campo esteja vazio.
        private void btn_enviar_Click(object sender, EventArgs e)
        {
            string nome = txt_nome.Text;

            if (nome == "")
            {
                MessageBox.Show("O campo de nome não pode estar vazio. Por favor, insira seu nome.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_nome.Focus();
            }
            else
            {
                MessageBox.Show("Bem-vindo, " + nome, nome);
            }
        }
        //2. Soma: Crie um form com dois textbox que receberão números. Em seguida, crie um botão "somar" e exiba o resultado.
        //Desafio: Trate o erro caso o usuário digite um texto.


        private void btn_soma_Click(object sender, EventArgs e)
        {
            try
            {
                int n1 = int.Parse(txt_n1.Text);
                int n2 = int.Parse(txt_n2.Text);
                int soma = n1 + n2;
                MessageBox.Show("A soma é: " + soma);
            }
            catch
            {
                MessageBox.Show("Por favor, insira apenas números nos campos de entrada.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //3. Calculadora: Crie uma calculadora nos mesmos moldes da anterior, só que com a possibilidade de realizar as outras três operações(use combobox)
        //Desafio: Evite a divisão por zero.


        private void Form1_Load(object sender, EventArgs e)
        {
            lista_ope.Items.AddRange(new string[] { "Soma", "Subtração", "Multiplicação", "Divisão" });

            lista_pao.Items.AddRange(new string[] { "Pão Frances", "Pão Italiano", "Pão Austríaco", "Pão Americano" });

            lista_ham.Items.AddRange(new string[] { "Carne", "Frango", "Porco" });

            lista_bebida.Items.AddRange(new string[] { "Coca-cola", "Pepsi", "Fanta", "Sprite", "Guaraná", "Água" });

            lista_ecivil.Items.AddRange(new string[] { "Solteiro(a)", "Casado(a)", "Divorciado(a)", "Viúvo(a)" });
        }

        private void btn_result_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"O Resulttado da operação é: {lista_ope.Text switch
            {
                "Soma" => int.Parse(txt_num1.Text) + int.Parse(txt_num2.Text),
                "Subtração" => int.Parse(txt_num1.Text) - int.Parse(txt_num2.Text),
                "Multiplicação" => int.Parse(txt_num1.Text) * int.Parse(txt_num2.Text),
                "Divisão" => int.Parse(txt_num2.Text) != 0 ? (int.Parse(txt_num1.Text) / int.Parse(txt_num2.Text)).ToString() : "Erro: Divisão por zero",
            }}");
        }

        //4. Verificador de Idade: Crie um form que receba a idade e, ao clicar em verificar, informe se a pessoa é maior ou menor de idade.
        //Desafio: Impedir que o usuário coloque letras.

        private void btn_ver_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_idade.Text, out int idade))
            {
                MessageBox.Show($"Voce é: {(int.Parse(txt_idade.Text) >= 18 ? "Maior de idade" : "Menor de idade")}");
            }
        }



        /*5. Login e Senha: Crie um form com campo usuário e senha.
        Ao clicar no botão entrar, mostrar "Login Realizado" ou "Credenciais Inválidas".
        Login: admin
        Senha: 1234
        Desafio: Deixar a senha com asteriscos***** no textbox*/

        private void button1_Click(object sender, EventArgs e)
        {
            const int SENHA = 12345;
            const string USUÁRIO = "admin";
            if (txt_login.Text == USUÁRIO && int.TryParse(txt_senha.Text, out int senha) && senha == SENHA)
            {
                MessageBox.Show("Login Realizado");
            }
            else
            {
                MessageBox.Show("Credenciais Inválidas");
            }
        }




        //6. Cadastro: Crie um form que receba Nome, Email, Idade, Estado Civil, Endereço e telefone.
        //Ao clicar em enviar, mostrar todos os dados na tela.
        //Desafio: Validar todos os dados



        //7. Restaurante: Crie um sistema onde o usuário digita o lanche que vai comprar.Crie um checkbox com adicionais (cebola, bacon, cheddar e picles).
        //Ao clicar em adicionar, o sistema apresenta o pedido.

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"O lanche escolhido foi: {lista_pao.Text} com {lista_ham.Text} e a bebida escolhida foi: {lista_bebida.Text}", "Pedido Realizado");
            if (check_cebola.Checked && check_alface.Checked && check_bacon.Checked && check_cheddar.Checked && check_picles.Checked)
            {
                MessageBox.Show("Adicional: Cebola \nAlface \nBacon \nCheddar \nPicles");
            }
            else if (check_cebola.Checked && check_alface.Checked && check_bacon.Checked && check_cheddar.Checked)
            {
                MessageBox.Show("Adicional: Cebola \nAlface \nBacon \nCheddar");
            }
            else if (check_cebola.Checked && check_alface.Checked && check_bacon.Checked)
            {
                MessageBox.Show("Adicional: Cebola \nAlface \nBacon");
            }
            else if (check_cebola.Checked && check_alface.Checked)
            {
                MessageBox.Show("Adicional: Cebola \nAlface");
            }
            else if (check_cebola.Checked)
            {
                MessageBox.Show("Adicional: Cebola");
            }
        }

        private void txt_senha_TextChanged(object sender, EventArgs e)
        {
            txt_senha.PasswordChar = '*';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txt_nom.Text;
                string email = txt_email.Text;
                int idade = Convert.ToInt32(txt_idad.Text);
                string estadoCivil = lista_ecivil.Text;
                string endereco = txt_end.Text;
                int telefone = Convert.ToInt32(txt_num.Text);
                MessageBox.Show($"Nome: {nome}\nEmail: {email}\nIdade: {idade}\nEstado Civil: {estadoCivil}\nEndereço: {endereco}\nTelefone: {telefone}", "Cadastro Realizado");


            }
            catch
            {
                MessageBox.Show("Por favor, preencha todos os campos corretamente.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
