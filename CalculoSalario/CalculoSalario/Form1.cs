namespace CalculoSalario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Gerente ger = new Gerente();
            Vendedor ven = new Vendedor();
            Atendente ate = new Atendente();
            Funcionario fun = new Funcionario();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            Funcionario fun = new Funcionario();
            fun.cadastrarFuncionario(txtNome.Text, txtCpf.Text, Convert.ToDouble(txtSalarioBase.Text));
        }
    }
}