namespace lista_windowsForms
{

    public partial class Form1 : Form
    {
        List<string> nomes = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_ad_Click(object sender, EventArgs e)
        {
            string nome = txt_nome.Text;
            if (!string.IsNullOrEmpty(nome))
            {
                nomes.Add(nome);

                lista_nomes.Items.Add(nome);
                txt_nome.Clear();
                txt_nome.Focus();

            }
        }

        private void btn_rem_Click(object sender, EventArgs e)
        {
            if(lista_nomes.SelectedItem != null)
            {
                string nomeSelecionado = lista_nomes.SelectedItem.ToString();
                nomes.Remove(nomeSelecionado);
                lista_nomes.Items.Remove(nomeSelecionado);
            }
        }
    }
}
