using System;

namespace Alura.Financas.Modelos
{
    public class Conta
    {
        public string Agencia { get; set; }
        public Cliente Cliente { get; set; }
        public decimal Saldo { get; set; }
        public Conta(string agencia, Cliente cliente)
        {
            Agencia = agencia;
            Cliente = cliente;
        }

        public void Depositar(decimal valor) => Saldo += valor;

        public void Sacar(decimal valor) 
        {
            if (valor > Saldo)
                throw new ArgumentException("Valor não pode ser maior que o saldo em conta!");
            
            Saldo -= valor;
        }
    }
}