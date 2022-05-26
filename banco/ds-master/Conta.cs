using System;
using System.Collections.Generic;
using System.Text;

namespace ds2_banco
{
    class Conta
    {
        public int numero;
        public Cliente titular;
        public double saldo;
        public double limite;

        public void sacar(double valor)
        {
            saldo = saldo - valor;
        }

        public void depositar(double valor)
        {
            saldo = saldo + valor;
        }

        public Conta(Cliente  cliente)
        {
            this.titular = cliente;
        }
    }
}
