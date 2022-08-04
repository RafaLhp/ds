using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoSalario
{
    internal class Funcionario
    { 

        protected String nome;
        protected String cpf;
        protected double salarioBase;
        protected double salarioFinal;
        protected double valorBonificacao;


        public void calcularBonificacao()
        {
            
        }

        public void cadastrarFuncionario(String nome, String cpf, double salarioBase)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.salarioBase = salarioBase;
            this.salarioFinal = 0;
            this.valorBonificacao = 0;
        }
    }
}
