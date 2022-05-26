using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ds2_banco
{
    public partial class frmNovaconta : Form
    {
        public frmNovaconta()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbxCpf.Text == "" || tbxLimite.Text == "" || tbxNome.Text == "" || tbxNumero.Text == "" || tbxSaldo.Text == "" || tbxSobrenome.Text == "" || tbxValor.Text == "")
            {
                MessageBox.Show("Preencha os campos!");
            }
            else
            {
                Cliente cli = new Cliente();

                cli.nome = tbxNome.Text;
                cli.sobrenome = tbxSobrenome.Text;
                cli.cpf = tbxCpf.Text;

                Conta cc = new Conta(cli);

                cc.numero = Convert.ToInt32(tbxNumero.Text);
                cc.limite = Convert.ToDouble(tbxLimite.Text);
                cc.saldo = Convert.ToDouble(tbxSaldo.Text);

                if (rbtSaque.Checked)
                {
                    cc.sacar(Convert.ToDouble(tbxValor.Text));
                    tbxSaldo.Text = Convert.ToString(cc.saldo);
                }
                else if (rbtDeposito.Checked)
                {
                    cc.depositar(Convert.ToDouble(tbxValor.Text));
                    tbxSaldo.Text = Convert.ToString(cc.saldo);
                }
                else
                {
                    MessageBox.Show("Selecione o tipo de operação!");
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tbxNome.Text = "";
            tbxCpf.Text = "";
            tbxSobrenome.Text = "";
            tbxLimite.Text = "";
            tbxSaldo.Text = "";
            tbxValor.Text = "";
            tbxNumero.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja realmente sair", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
