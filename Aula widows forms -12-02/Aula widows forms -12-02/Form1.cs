namespace Aula_widows_forms__12_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Form Carregado");//Na Label carrega um pop up dizendo "Form Carregado"
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Adicionando itens a combo box
            lista_ecivil.Items.Add("Selecione o estado civil");
            lista_ecivil.Items.Add("Solteiro");
            lista_ecivil.Items.Add("Casado");
            lista_ecivil.Items.Add("Viúvo");
            lista_ecivil.Items.Add("Divorciado");
            lista_ecivil.Items.Add("Tia dos gatos");

            lista_ecivil.SelectedIndex = 0;//Seleciona o primeiro item da combo box
            //lista_ecivil.Items.AddRange(new string[] { "Solteiro", "Casado", "Viúvo", "Divorciado", "Tia dos gatos" });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();//botão responsavel por fechar a pagina
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nome = txt_nome.Text;
            MessageBox.Show("Olá," + nome, "Bem vindo");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Deseja fechar o sistema?", "Sistema Nana",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question,
                 MessageBoxDefaultButton.Button2);

            if (resposta == DialogResult.Yes)
            {
                MessageBox.Show("Voce clicou em sim!");
            }
            else
            {
                MessageBox.Show("Voce clicou em não!");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_ecivil_Click(object sender, EventArgs e)
        {
            string eCivil = lista_ecivil.SelectedItem.ToString();
            // string eCivil2 = lista_ecivil.Text;
            MessageBox.Show("Estado civil selecionado: " + eCivil, "Estado Civil");
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
            {
                MessageBox.Show("Usuario Possui todos");
            }
            else if (checkBox1.Checked && checkBox2.Checked)
            {
                MessageBox.Show("Usuario Possui Carro e Moto");
            }
            else if (checkBox1.Checked)
            {
                MessageBox.Show("Usuario Possui Carro");
            }
            else if (checkBox2.Checked)
            {
                MessageBox.Show("Usuario Possui de Moto");
            }
            else if (checkBox3.Checked)
            {
                MessageBox.Show("Usuario não possui Carro ou Moto");
            }
            
        }
    }
}