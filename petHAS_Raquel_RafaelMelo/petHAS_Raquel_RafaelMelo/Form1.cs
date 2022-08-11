namespace petHAS_Raquel_RafaelMelo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Servicos s = new Servicos();

            s.setCodServico(Convert.ToInt16(txtCodigo.Text));

            s.setNomeServico(txtNome.Text);

            s.setPrecoServ(Convert.ToInt16(txtPreco.Text));

            s.setPreco(Convert.ToInt16(txtCusto.Text));
        }
    }
}