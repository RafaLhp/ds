using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petHAS_Raquel_RafaelMelo
{
    internal class Servicos
    {
        private int codServicos;
        private String nomeServico;
        private double preco;
        private double precoServ;

        public void setPrecoServ(double precoServ)
        {
            this.precoServ = precoServ;
        }
        public double getServ()
        {
            return precoServ;
        }

        public void setCodServico(int codServicos)
        {
            this.codServicos = codServicos;
        }

        public int getCodServico()
        {
            return codServicos;
        }

        public void setNomeServico(String nomeServico)
        {
            this.nomeServico = nomeServico;
        }

        public void setPreco(double preco)
        {
            this.preco = preco;
        }
    }
}
