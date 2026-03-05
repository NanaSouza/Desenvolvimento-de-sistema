namespace Jogo_7_erros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            combo_doce.Items.AddRange(new string[] { "Açai" , "Chocolate" , "Bolo" });
            string[] adicionais = { "Leite em pó", "Granola", "Leite condensado", "Chocolate", "Morango", "Banana" };
            lista_doce.Items.AddRange(adicionais);

            combo_ham.Items.AddRange(new string[] { "X-Burguer", "X-Salada", "X-Bacon", "X-Egg", "X-Tudo" });
            string[] adicionais1 = { "Queijo", "Bacon", "Ovo", "Alface", "Tomate", "Cebola", "Picles" };
            lista_ham.Items.AddRange(adicionais1);

            combo_pizza.Items.AddRange(new string[] { "Calabresa", "Mussarela", "Frango com Catupiry", "Portuguesa", "Marguerita" });
            string[] adicionais2 = { "Azeitona", "Cebola", "Pimentão", "Milho", "Ervilha", "Orégano", "Catupiry" };
            lista_pizza.Items.AddRange(adicionais2);

            try
            {
                combo_acom.Items.AddRange(new string[] { "Pão de queijo", "Batata Frita", "Chocolate", "Onion Rings", "Mandioca Frita", "Nuggets", "Salada" });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os acompanhamentos: " + ex.Message);
            }
            try
            {
                combo_bebida.Items.AddRange(new string[] { "Refrigerante", "Suco", "Água", "Cerveja", "Vinho", "Coca-cola", "Suco de Laranja" });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar as bebidas: " + ex.Message);
            }
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            string adicionais3 = " ";
            MessageBox.Show($"Você escolheu: {combo_bebida.SelectedItem} , {combo_doce.SelectedItem} , {combo_acom.SelectedItem}");
            //foreach (var item in lista_doce.CheckedItems)
            //{
            //    MessageBox.Show($"Adicional selecionado: {item}");
            //}
            //foreach (var item in lista_ham.CheckedItems)
            //{
            //    MessageBox.Show($"Acompanhamento selecionado: {item}");
            //}
            //foreach (var item in lista_pizza.CheckedItems)
            //{
            //    MessageBox.Show($"Bebida selecionada: {item}");
            //}
            if (lista_doce.Checked)
            {
                adicionais3 += "Adicional selecionado: " + lista_doce.CheckedItems + "\n";
            }

        }
    }

        
}